
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Microsoft.Win32.SafeHandles;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace XPNet
{
	/// <summary>
	/// Manages interaction between the CLR world and the C world (from
	/// the CLR side).
	/// </summary>
	public static class PluginBridge
	{
		private static string m_logFilePath;
		private static bool m_loggingOverriddenByHostEnvironment;
		private static ILog m_log;

		private static string m_configFilePath;
		private static IConfiguration m_config;
		private static IChangeToken m_configReloadToken;
		private static IDisposable m_configReloadTokenDisposer;

		private static XPlaneApi m_api;
		private static IXPlanePlugin m_plugin;

		internal static ApiFunctions ApiFunctions;

		public static ILog Log => m_log;

		public static bool Start(ref StartParams startParams, ref ApiFunctionPointers apiFunctionPointers)
		{
			// MAINT: This is the initial entry point that gets called from C++ when the plugin system is
			// initialized.
			//
			// * Do not call anything from _this_ method that requires any other DLLs, other than those
			//   that come with the framework itself.  (Put such calls into StartInternal instead).
			//
			// * Do not introduce anything in a static constructor of this class that requires any
			//   other DLLs, other than those that come with the framework itself.
			//
			// Violating either of those rules makes debugging "missing dependency" problems much more
			// difficult.  When the framework finds a missing dependency, it throws an exception.  If that
			// happens at a place where we cannot catch it in C#, then it will make it back to C++-land
			// as a hard crash.  (It is actually an NT exception and could be handled with __try/__except,
			// but that wouldn't work on other macOS or Linux, and we wouldn't be able to log any information
			// about the exception, so that's a non-optimal solution).
			//
			// The reason you can't call methods that are loaded from other DLLs here, but can in StartInternal,
			// is to do with how the JIT compiler works.  If it encounters a method it can't compile because
			// of a missing DLL, it will fail to compile _that_ method with an exception.  If one of the core
			// dependencies (like Microsoft.Configuration.*) is missing, we want that failure to occur while
			// compiling StartInternal, which we call from here.  That way, we can catch it with our try/catch
			// here, and report a good error message.  If _this_ method were to fail to JIT-compile, there are
			// no other .NET methods higher in the stack to catch and properly report the error, and the result
			// looks to the user like a hard crash.
			//
			// Logically, this method should be very small, just a try/catch wrapper around StartInternal.
			// However,
			//
			// 1. Logging is safe, because we specifically make sure that it doesn't require any external
			//    dependencies.  (That is one of the reasons that we aren't using something like log4net).
			// 2. Setting up logging (but nothing else!) at this level lets us pass back to the host environment
			//    a useful message about exactly which DLL is missing, because in practice the host environment
			//    is our C++ X-Plane plugin DLL, which passes a log handle, so it can catch what we log.
			//    Without that, we might as well just be telling the user "¯\_(ツ)_/¯ sucks to be you..."
			//
			// NOTE: There's not much we can do right now about unhandled exceptions on other threads.
			// Plugin writers will have to be conscientious about taking care of that themselves.  When/if
			// .NET Core adds an equivalent to AppDomain.UnhandledException, we could give it a try.
			//

			try
			{
				var thisAssemblyPath = typeof(PluginBridge).GetTypeInfo().Assembly.Location;
				var rootDir = Path.GetDirectoryName(thisAssemblyPath);

				m_configFilePath = Path.Combine(rootDir, "xpnetcfg.json");
				m_logFilePath = Path.Combine(rootDir, "xpnet.log");

				// We always start out with logging enabled.  We may reconfigure it off once config loads.
				m_log = InitLogging(ref startParams);

				m_log.Log("XPNet CLR: Start");

				return StartInternal(ref startParams, ref apiFunctionPointers, rootDir);
			}
			catch (Exception exc)
			{
				// File.WriteAllText(@"D:\Games\X-Plane\X-Plane 11 Beta\Resources\plugins\XPNetDev\64\Emergency.txt", "Error: " + exc);
				m_log?.Log(exc);
				return false;
			}
		}

		internal static bool StartInternal(ref StartParams startParams, ref ApiFunctionPointers apiFunctionPointers, string rootDir)
		{
			if (!File.Exists(m_configFilePath))
			{
				m_log.Log($"XPNet CLR: Will not load plugin because config file does not exist: (Path = {m_configFilePath}).");
				return false;
			}

			m_config = GetConfig(m_configFilePath);
			if (m_config == null)
			{
				m_log.Log($"XPNet CLR: Will not load plugin because config file was unusable: (Path = {m_configFilePath}).");
				return false;
			}

			m_configReloadToken = m_config.GetReloadToken();
			m_configReloadTokenDisposer = m_configReloadToken.RegisterChangeCallback(o =>
			{
				m_log.Log($"XPNet CLR: Config file change detected: (Path = {m_configFilePath}).");

				m_log.Log($"XPNet CLR: Will reconfigure logging.");
				m_api.Log = m_log = ReconfigureLogging(forceLogging: false);

				m_log.Log($"XPNet CLR: Will tell plugin that config changed.");
				m_api.RaiseConfigChanged();

			}, state: null);

			// Make a local copy of the given set of API function pointers.
			ApiFunctions = new ApiFunctions(apiFunctionPointers);

			m_api = new XPlaneApi(m_log, m_config);

			m_plugin = LoadPlugin(rootDir);
			if (m_plugin == null)
			{
				m_log.Log("XPNet CLR: Failed to find a plugin to load.  Will tell X-Plane we failed to start.");
				return false;
			}

			var typeInfo = m_plugin.GetType().GetTypeInfo();
			var xpattr = typeInfo.GetCustomAttribute<XPlanePluginAttribute>();

			unsafe
			{
				fixed (byte* pc = startParams.Name)
					Interop.CopyCString(pc, 256, xpattr.Name);

				fixed (byte* pc = startParams.Signature)
					Interop.CopyCString(pc, 256, xpattr.Signature);

				fixed (byte* pc = startParams.Description)
					Interop.CopyCString(pc, 256, xpattr.Description);
			}

			return true;
		}

		public static bool Enable()
		{
			// MAINT: The same concern described in Start(), about not making any calls to
			// external DLLs directly from this method, also applies here.  Caveat: m_plugin
			// of course comes from an external DLL, but it _must_ have already successfully
			// loaded or it wouldn't be set.  We don't try to handle the case where methods
			// are called in an order that is different from the guarantees that X-Plane gives
			// us, so if called when m_plugin is null, behavior is officially undefined (though
			// you can see pretty easily what it'll do below).

			try
			{
				m_log?.Log("XPNet CLR: Enable");

				m_plugin.Enable();

				return true;
			}
			catch (Exception exc)
			{
				m_log?.Log(exc);
				return false;
			}
		}

		public static void Disable()
		{
			// MAINT: Ditto the note at the top of Enable().

			try
			{
                m_log?.Log("XPNet CLR: Disable");

				m_plugin.Disable();
			}
			catch (Exception exc)
			{
				m_log?.Log(exc);
			}
		}

		public static bool Stop()
		{
			// MAINT: Ditto the note at the top of Enable().

			try
			{
                m_log?.Log("XPNet CLR: Stop");

				m_plugin.Dispose();
				m_plugin = null;

				m_api.Dispose();
				m_api = null;

				m_configReloadTokenDisposer.Dispose();
				m_configReloadTokenDisposer = null;

				m_configReloadToken = null;
				m_config = null;

				ApiFunctions = new ApiFunctions();

				return true;
			}
			catch (Exception exc)
			{
				m_log?.Log(exc);
				return false;
			}
		}

		public static unsafe void ReceiveMessage(int fromPluginId, int msg, void* inParam)
		{
			// MAINT: Ditto the note at the top of Enable().

			try
			{
				m_api.Messages.RaiseMessage(fromPluginId, msg, inParam);
			}
			catch (Exception exc)
			{
				m_log?.Log(exc);
			}
		}

		private static unsafe ILog InitLogging(ref StartParams startParams)
		{
			// If the calling environment provides a log handle, that's
			// what we'll use.  Otherwise we use configuration to
			// determine what kind of log file to open.

			var hLog = (IntPtr)startParams.LogHandle;

			m_loggingOverriddenByHostEnvironment = hLog != IntPtr.Zero;

			if (m_loggingOverriddenByHostEnvironment)
			{
				var hSafeFile = new SafeFileHandle(hLog, ownsHandle: false);
				return new FileHandleLog(hSafeFile);
			}
			else
			{
				return ReconfigureLogging(forceLogging: true);
			}
		}

		private static ILog ReconfigureLogging(bool forceLogging)
		{
			bool loggingEnabled = forceLogging || m_config == null || (m_config["LoggingEnabled"] == "true");
			return loggingEnabled ? new StreamLog(m_logFilePath) : (ILog)new NullLog();
		}

		private static IConfiguration GetConfig(string configFilePath)
		{
			try
			{
				var builder = new ConfigurationBuilder()
					.SetBasePath(System.AppContext.BaseDirectory)
					.AddJsonFile(configFilePath, optional: false, reloadOnChange: true);
				return builder.Build();
			}
			catch (Exception exc)
			{
				m_log.Log(exc);
				return null;
			}
		}

		private static IXPlanePlugin LoadPlugin(string rootDir)
		{
			// MAINT: Where I started to find types automatically.  Didn't work out b/c
			// .NET Core doesn't seem to have its metadata analysis story really together
			// yet - stuff just didn't work at runtime.
			//            var candidateFiles = Directory.GetFiles(thisDir, "*Plugin.dll", SearchOption.TopDirectoryOnly)
			//                .Where(f => !string.Equals(f, thisAssemblyPath, StringComparison.CurrentCultureIgnoreCase));

			m_log.Log($"XPNet CLR: Looking for plugin in ({rootDir}).");

			var assemblyName = m_config["PluginAssemblyName"];
			var fullPluginTypeName = m_config["PluginType"];

			if (string.IsNullOrWhiteSpace(assemblyName))
			{
				m_log.Log($"XPNet CLR: Skipping plugin because config file does not contain a PluginAssemblyName entry: (Path = {m_configFilePath}).");
				return null;
			}

			if (string.IsNullOrWhiteSpace(fullPluginTypeName))
			{
				m_log.Log($"XPNet CLR: Skipping plugin because config file does not contain a PluginType entry: (Path = {m_configFilePath}).");
				return null;
			}

			var pluginTypeName = fullPluginTypeName.Split('.').Last();

			var asmPath = Path.Combine(rootDir, assemblyName);

			if (!File.Exists(asmPath))
			{
				m_log.Log($"XPNet CLR: Skipping plugin because file does not exist: (Path = {asmPath}).");
				return null;
			}

			try
			{
				m_log.Log($"XPNet CLR: Inspecting plugin candidate: (Path = {asmPath}).");

				var asmName = AssemblyLoadContext.GetAssemblyName(asmPath);
				var asm = AssemblyLoadContext.Default.LoadFromAssemblyName(asmName);
				var pluginType = asm.GetType(fullPluginTypeName);
				if (pluginType == null)
				{
					m_log.Log($"XPNet CLR: Skipping plugin type ({fullPluginTypeName}) because it could not be loaded from the assembly: (Assembly = {asmPath}).");
					return null;
				}

				var typeInfo = pluginType.GetTypeInfo();
				var xpattr = typeInfo.GetCustomAttribute<XPlanePluginAttribute>();
				if (xpattr == null)
				{
					m_log.Log($"XPNet CLR: Skipping plugin type ({fullPluginTypeName}) because it does not have XPlanePluginAttribute applied.");
					return null;
				}

				if (!typeInfo.ImplementedInterfaces.Contains(typeof(IXPlanePlugin)))
				{
					m_log.Log($"XPNet CLR: Skipping plugin type ({fullPluginTypeName}) because it does not implement IXPlanePlugin.");
					return null;
				}

				var ctor = typeInfo.GetConstructor(new[] { typeof(IXPlaneApi) });
				if (ctor == null)
				{
					m_log.Log($"XPNet CLR: Skipping plugin type ({fullPluginTypeName}) because it does not have a recognized constructor.");
					m_log.Log($"XPNet CLR:   Add a constructor like: ");
					m_log.Log($"XPNet CLR:   {pluginTypeName}(IXPlaneApi api)");
					return null;
				}

				return (IXPlanePlugin)ctor.Invoke(new[] { m_api });
			}
			catch (Exception exc)
			{
				m_log.Log(exc);
				m_log.Log($"XPNet CLR: Failed to load plugin due to exception: (Path = {asmPath}).");
				return null;
			}
		}
	}

	#region X-Plane Data API

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void* XPLMFindDataRef(
		[MarshalAs(UnmanagedType.LPStr)] string inDataRefName
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate XPDataTypes XPLMGetDataRefTypes(void* dataref);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMGetDatai(void* dataref);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetDatai(void* dataRef, int inValue);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate float XPLMGetDataf(void* dataRef);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetDataf(void* dataRef, float inValue);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate float XPLMGetDatad(void* dataRef);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetDatad(void* dataRef, double inValue);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMGetDatavi(void* dataRef, int* outValues, int inOffset, int inMax);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetDatavi(void* dataRef, int* inValues, int inOffset, int inCount);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMGetDatavf(void* dataRef, float* outValues, int inOffset, int inMax);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetDatavf(void* dataRef, float* inValues, int inOffset, int inCount);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMGetDatab(void* dataRef, byte* outValues, int inOffset, int inMax);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetDatab(void* dataRef, byte* inValues, int inOffset, int inCount);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void* XPLMRegisterDataAccessor(
		[MarshalAs(UnmanagedType.LPStr)] string inDataName,
		XPLMDataTypeID inDataType,
		int inIsWritable,
		XPLMGetDatai_f inReadInt,
		XPLMSetDatai_f inWriteInt,
		XPLMGetDataf_f inReadFloat,
		XPLMSetDataf_f inWriteFloat,
		XPLMGetDatad_f inReadDouble,
		XPLMSetDatad_f inWriteDouble,
		XPLMGetDatavi_f inReadIntArray,
		XPLMSetDatavi_f inWriteIntArray,
		XPLMGetDatavf_f inReadFloatArray,
		XPLMSetDatavf_f inWriteFloatArray,
		XPLMGetDatab_f inReadData,
		XPLMSetDatab_f inWriteData,
		void* inReadRefcon,
		void* inWriteRefcon
	);

	[Flags]
	internal enum XPLMDataTypeID : int
	{
		xplmType_Unknown = 0,
		xplmType_Int = 1,
		xplmType_Float = 2,
		xplmType_Double = 4,
		xplmType_FloatArray = 8,
		xplmType_IntArray = 16,
		xplmType_Data = 32
	}

	internal unsafe delegate int XPLMGetDatai_f(
		void* inRefcon
	);

	internal unsafe delegate void XPLMSetDatai_f(
		void* inRefcon,
		int inValue
	);

	internal unsafe delegate float XPLMGetDataf_f(
		void* inRefcon
	);

	internal unsafe delegate void XPLMSetDataf_f(
		void* inRefcon,
		float inValue
	);

	internal unsafe delegate double XPLMGetDatad_f(
		void* inRefcon
	);

	internal unsafe delegate void XPLMSetDatad_f(
		void* inRefcon,
		double inValue
	);

	internal unsafe delegate int XPLMGetDatavi_f(
		void* inRefcon,
		int* outValues,
		int inOffset,
		int inMax
	);

	internal unsafe delegate int XPLMSetDatavi_f(
		void* inRefcon,
		int* inValues,
		int inOffset,
		int inCount
	);

	internal unsafe delegate int XPLMGetDatavf_f(
		void* inRefcon,
		float* outValues,
		int inOffset,
		int inMax
	);

	internal unsafe delegate int XPLMSetDatavf_f(
		void* inRefcon,
		float* inValues,
		int inOffset,
		int inCount
	);

	internal unsafe delegate int XPLMGetDatab_f(
		void* inRefcon,
		void* outValue,
		int inOffset,
		int inMaxLength
	);

	internal unsafe delegate int XPLMSetDatab_f(
		void* inRefcon,
		void* inValue,
		int inOffset,
		int inLength
	);

	#endregion X-Plane Data API

	#region X-Plane Command API

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void* XPLMFindCommand(
		[MarshalAs(UnmanagedType.LPStr)] string inCommandName
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMCommandBegin(void* cmdref);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMCommandEnd(void* cmdref);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMCommandOnce(void* cmdref);

	#endregion X-Plane Command API

	#region X-Plane Processing API

	internal enum XPLMFlightLoopPhaseType : int
	{
		xplm_FlightLoop_Phase_BeforeFlightModel = 0,

		xplm_FlightLoop_Phase_AfterFlightModel = 1
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 2)]
	internal unsafe struct XPLMCreateFlightLoop_t
	{
		public int structSize;

		public XPLMFlightLoopPhaseType phase;

		public XPLMFlightLoop_f callbackFunc;

		public void* refcon;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate float XPLMFlightLoop_f(
		float inElapsedSinceLastCall,
		float inElapsedTimeSinceLastFlightLoop,
		int inCounter,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate float XPLMGetElapsedTime();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMGetCycleNumber();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMRegisterFlightLoopCallback(
		XPLMFlightLoop_f inFlightLoop,
		float inInterval,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMUnregisterFlightLoopCallback(
		XPLMFlightLoop_f inFlightLoop,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMSetFlightLoopCallbackInterval(
		XPLMFlightLoop_f inFlightLoop,
		float inInterval,
		int inRelativeToNow,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void* XPLMCreateFlightLoop(
		ref XPLMCreateFlightLoop_t inParams
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMDestroyFlightLoop(
		void* inFlightLoopID
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMScheduleFlightLoop(
		void* inFlightLoopID,
		 float inInterval,
		 int inRelativeToNow
	);

	#endregion X-Plane Processing API

	#region X-Plane Display API

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMRegisterDrawCallback(
		XPLMDrawCallback_f inCallback,
		XPLMDrawingPhase inPhase,
		int inWantsBefore,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMUnregisterDrawCallback(
		XPLMDrawCallback_f inCallback,
		XPLMDrawingPhase inPhase,
		int inWantsBefore,
		void* inRefcon
	);

	public enum XPLMDrawingPhase : int
	{
		xplm_Phase_FirstScene = 0,
		xplm_Phase_Terrain = 5,
		xplm_Phase_Airports = 10,
		xplm_Phase_Vectors = 15,
		xplm_Phase_Objects = 20,
		xplm_Phase_Airplanes = 25,
		xplm_Phase_LastScene = 30,
		xplm_Phase_FirstCockpit = 35,
		xplm_Phase_Panel = 40,
		xplm_Phase_Gauges = 45,
		xplm_Phase_Window = 50,
		xplm_Phase_LastCockpit = 55,
		xplm_Phase_LocalMap3D = 100,
		xplm_Phase_LocalMap2D = 101,
		xplm_Phase_LocalMapProfile = 102
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMDrawCallback_f(
		XPLMDrawingPhase inPhase,
		int inIsBefore,
		void* inRefcon
	);

	#endregion X-Plane Display API

	#region X-Plane Scenery API

	internal enum XPLMProbeType : int
	{
		xplm_ProbeY = 0,
	}

	public enum XPLMProbeResult : int
	{
		xplm_ProbeHitTerrain = 0,
		xplm_ProbeError = 1,
		xplm_ProbeMissed = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 2)]
	internal unsafe class XPLMProbeInfo_t
	{
		private static readonly int m_structSizeInit;

		public int structSize;

		public float locationX;

		public float locationY;

		public float locationZ;

		public float normalX;

		public float normalY;

		public float normalZ;

		public float velocityX;

		public float velocityY;

		public float velocityZ;

		public int is_wet;

		static XPLMProbeInfo_t()
		{
			m_structSizeInit = Marshal.SizeOf(typeof(XPLMProbeInfo_t));
		}

		public XPLMProbeInfo_t()
		{
			structSize = m_structSizeInit;
		}
	};

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void* XPLMCreateProbe(
		XPLMProbeType inProbeType
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMDestroyProbe(void* inProbe);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate XPLMProbeResult XPLMProbeTerrainXYZ(
								   void* inProbe,
								   float inX,
								   float inY,
								   float inZ,
								   [In, Out] XPLMProbeInfo_t outInfo);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 2)]
	public class XPLMDrawInfo_t
	{
		private static readonly int m_structSizeInit;
		private readonly int m_structSize;
		public float x;
		public float y;
		public float z;
		public float pitch;
		public float heading;
		public float roll;

		static XPLMDrawInfo_t()
		{
			m_structSizeInit = Marshal.SizeOf(typeof(XPLMDrawInfo_t));
		}

		public XPLMDrawInfo_t(float x = default(float), float y = default(float), float z = default(float), float pitch = default(float), float heading = default(float), float roll = default(float))
		{
			m_structSize = m_structSizeInit;
			this.x = x;
			this.y = y;
			this.z = z;
			this.pitch = pitch;
			this.heading = heading;
			this.roll = roll;
		}
	};

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMObjectLoaded_f(
		void* inObject,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void* XPLMLoadObject(
		[MarshalAs(UnmanagedType.LPStr)] string inPath
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMLoadObjectAsync(
		[MarshalAs(UnmanagedType.LPStr)] string inPath,
		XPLMObjectLoaded_f inCallback,
		void* inRefcon
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMDrawObjects(
		void* inObject,
		int inCount,
		XPLMDrawInfo_t inLocations,
		int lighting,
		int earth_relative
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMUnloadObject(
		void* inObject
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate void XPLMLibraryEnumerator_f(
		[MarshalAs(UnmanagedType.LPStr)] string inFilePath,
		void* inRef
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMLookupObjects(
		[MarshalAs(UnmanagedType.LPStr)] string inPath,
		float inLatitude,
		float inLongitude,
		XPLMLibraryEnumerator_f enumerator,
		void* reference
	);

	#endregion X-Plane Scenery API

	#region X-Plane Graphics API

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMWorldToLocal
	(
		double inLatitude,
		double inLongitude,
		double inAltitude,
		double* outX,
		double* outY,
		double* outZ
	);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal unsafe delegate int XPLMLocalToWorld
	(
		double inX,
		double inY,
		double inZ,
		double* outLatitude,
		double* outLongitude,
		double* outAltitude
	);

	#endregion X-Plane Graphics API

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 2)]
	public struct ApiFunctionPointers
	{
		// Data
		internal IntPtr XPLMFindDataRef;
		internal IntPtr XPLMGetDataRefTypes;
		internal IntPtr XPLMGetDatai;
		internal IntPtr XPLMSetDatai;
		internal IntPtr XPLMGetDataf;
		internal IntPtr XPLMSetDataf;
		internal IntPtr XPLMGetDatad;
		internal IntPtr XPLMSetDatad;
		internal IntPtr XPLMGetDatavi;
		internal IntPtr XPLMSetDatavi;
		internal IntPtr XPLMGetDatavf;
		internal IntPtr XPLMSetDatavf;
		internal IntPtr XPLMGetDatab;
		internal IntPtr XPLMSetDatab;
		internal IntPtr XPLMRegisterDataAccessor;

		// Commands
		internal IntPtr XPLMFindCommand;
		internal IntPtr XPLMCommandBegin;
		internal IntPtr XPLMCommandEnd;
		internal IntPtr XPLMCommandOnce;

		// Processing
		internal IntPtr XPLMGetElapsedTime;
		internal IntPtr XPLMGetCycleNumber;
		internal IntPtr XPLMRegisterFlightLoopCallback;
		internal IntPtr XPLMUnregisterFlightLoopCallback;
		internal IntPtr XPLMSetFlightLoopCallbackInterval;
		internal IntPtr XPLMCreateFlightLoop;
		internal IntPtr XPLMDestroyFlightLoop;
		internal IntPtr XPLMScheduleFlightLoop;

		// Display
		internal IntPtr XPLMRegisterDrawCallback;
		internal IntPtr XPLMUnregisterDrawCallback;

		// Scenery
		internal IntPtr XPLMCreateProbe;
		internal IntPtr XPLMDestroyProbe;
		internal IntPtr XPLMProbeTerrainXYZ;
		internal IntPtr XPLMLoadObject;
		internal IntPtr XPLMLoadObjectAsync;
		internal IntPtr XPLMDrawObjects;
		internal IntPtr XPLMUnloadObject;
		internal IntPtr XPLMLookupObjects;

		// Graphics
		internal IntPtr XPLMWorldToLocal;
		internal IntPtr XPLMLocalToWorld;

	}

	public unsafe struct ApiFunctions
	{
		// This type must be kept in sync with the version in C.

		public ApiFunctions(ApiFunctionPointers p)
		{
			// Data
			XPLMFindDataRef = Marshal.GetDelegateForFunctionPointer<XPLMFindDataRef>(p.XPLMFindDataRef);
			XPLMGetDataRefTypes = Marshal.GetDelegateForFunctionPointer<XPLMGetDataRefTypes>(p.XPLMGetDataRefTypes);
			XPLMGetDatai = Marshal.GetDelegateForFunctionPointer<XPLMGetDatai>(p.XPLMGetDatai);
			XPLMSetDatai = Marshal.GetDelegateForFunctionPointer<XPLMSetDatai>(p.XPLMSetDatai);
			XPLMGetDataf = Marshal.GetDelegateForFunctionPointer<XPLMGetDataf>(p.XPLMGetDataf);
			XPLMSetDataf = Marshal.GetDelegateForFunctionPointer<XPLMSetDataf>(p.XPLMSetDataf);
			XPLMGetDatad = Marshal.GetDelegateForFunctionPointer<XPLMGetDatad>(p.XPLMGetDatad);
			XPLMSetDatad = Marshal.GetDelegateForFunctionPointer<XPLMSetDatad>(p.XPLMSetDatad);
			XPLMGetDatavi = Marshal.GetDelegateForFunctionPointer<XPLMGetDatavi>(p.XPLMGetDatavi);
			XPLMSetDatavi = Marshal.GetDelegateForFunctionPointer<XPLMSetDatavi>(p.XPLMSetDatavi);
			XPLMGetDatavf = Marshal.GetDelegateForFunctionPointer<XPLMGetDatavf>(p.XPLMGetDatavf);
			XPLMSetDatavf = Marshal.GetDelegateForFunctionPointer<XPLMSetDatavf>(p.XPLMSetDatavf);
			XPLMGetDatab = Marshal.GetDelegateForFunctionPointer<XPLMGetDatab>(p.XPLMGetDatab);
			XPLMSetDatab = Marshal.GetDelegateForFunctionPointer<XPLMSetDatab>(p.XPLMSetDatab);
			XPLMRegisterDataAccessor = Marshal.GetDelegateForFunctionPointer<XPLMRegisterDataAccessor>(p.XPLMRegisterDataAccessor);

			// Commands
			XPLMFindCommand = Marshal.GetDelegateForFunctionPointer<XPLMFindCommand>(p.XPLMFindCommand);
			XPLMCommandBegin = Marshal.GetDelegateForFunctionPointer<XPLMCommandBegin>(p.XPLMCommandBegin);
			XPLMCommandEnd = Marshal.GetDelegateForFunctionPointer<XPLMCommandEnd>(p.XPLMCommandEnd);
			XPLMCommandOnce = Marshal.GetDelegateForFunctionPointer<XPLMCommandOnce>(p.XPLMCommandOnce);

			// Processing
			XPLMGetElapsedTime = Marshal.GetDelegateForFunctionPointer<XPLMGetElapsedTime>(p.XPLMGetElapsedTime);
			XPLMGetCycleNumber = Marshal.GetDelegateForFunctionPointer<XPLMGetCycleNumber>(p.XPLMGetCycleNumber);
			XPLMRegisterFlightLoopCallback = Marshal.GetDelegateForFunctionPointer<XPLMRegisterFlightLoopCallback>(p.XPLMRegisterFlightLoopCallback);
			XPLMUnregisterFlightLoopCallback = Marshal.GetDelegateForFunctionPointer<XPLMUnregisterFlightLoopCallback>(p.XPLMUnregisterFlightLoopCallback);
			XPLMSetFlightLoopCallbackInterval = Marshal.GetDelegateForFunctionPointer<XPLMSetFlightLoopCallbackInterval>(p.XPLMSetFlightLoopCallbackInterval);
			XPLMCreateFlightLoop = Marshal.GetDelegateForFunctionPointer<XPLMCreateFlightLoop>(p.XPLMCreateFlightLoop);
			XPLMDestroyFlightLoop = Marshal.GetDelegateForFunctionPointer<XPLMDestroyFlightLoop>(p.XPLMDestroyFlightLoop);
			XPLMScheduleFlightLoop = Marshal.GetDelegateForFunctionPointer<XPLMScheduleFlightLoop>(p.XPLMScheduleFlightLoop);

			// Display
			XPLMRegisterDrawCallback = Marshal.GetDelegateForFunctionPointer<XPLMRegisterDrawCallback>(p.XPLMRegisterDrawCallback);
			XPLMUnregisterDrawCallback = Marshal.GetDelegateForFunctionPointer<XPLMUnregisterDrawCallback>(p.XPLMUnregisterDrawCallback);

			// Scenery
			XPLMCreateProbe = Marshal.GetDelegateForFunctionPointer<XPLMCreateProbe>(p.XPLMCreateProbe);
			XPLMDestroyProbe = Marshal.GetDelegateForFunctionPointer<XPLMDestroyProbe>(p.XPLMDestroyProbe);
			XPLMProbeTerrainXYZ = Marshal.GetDelegateForFunctionPointer<XPLMProbeTerrainXYZ>(p.XPLMProbeTerrainXYZ);
			XPLMLoadObject = Marshal.GetDelegateForFunctionPointer<XPLMLoadObject>(p.XPLMLoadObject);
			XPLMLoadObjectAsync = Marshal.GetDelegateForFunctionPointer<XPLMLoadObjectAsync>(p.XPLMLoadObjectAsync);
			XPLMDrawObjects = Marshal.GetDelegateForFunctionPointer<XPLMDrawObjects>(p.XPLMDrawObjects);
			XPLMUnloadObject = Marshal.GetDelegateForFunctionPointer<XPLMUnloadObject>(p.XPLMUnloadObject);
			XPLMLookupObjects = Marshal.GetDelegateForFunctionPointer<XPLMLookupObjects>(p.XPLMLookupObjects);

			// Graphics
			XPLMWorldToLocal = Marshal.GetDelegateForFunctionPointer<XPLMWorldToLocal>(p.XPLMWorldToLocal);
			XPLMLocalToWorld = Marshal.GetDelegateForFunctionPointer<XPLMLocalToWorld>(p.XPLMLocalToWorld);
		}

		// Data
		internal XPLMFindDataRef XPLMFindDataRef;
		internal XPLMGetDataRefTypes XPLMGetDataRefTypes;
		internal XPLMGetDatai XPLMGetDatai;
		internal XPLMSetDatai XPLMSetDatai;
		internal XPLMGetDataf XPLMGetDataf;
		internal XPLMSetDataf XPLMSetDataf;
		internal XPLMGetDatad XPLMGetDatad;
		internal XPLMSetDatad XPLMSetDatad;
		internal XPLMGetDatavi XPLMGetDatavi;
		internal XPLMSetDatavi XPLMSetDatavi;
		internal XPLMGetDatavf XPLMGetDatavf;
		internal XPLMSetDatavf XPLMSetDatavf;
		internal XPLMGetDatab XPLMGetDatab;
		internal XPLMSetDatab XPLMSetDatab;
		internal XPLMRegisterDataAccessor XPLMRegisterDataAccessor;

		// Commands
		internal XPLMFindCommand XPLMFindCommand;
		internal XPLMCommandBegin XPLMCommandBegin;
		internal XPLMCommandEnd XPLMCommandEnd;
		internal XPLMCommandOnce XPLMCommandOnce;

		// Processing
		internal XPLMGetElapsedTime XPLMGetElapsedTime;
		internal XPLMGetCycleNumber XPLMGetCycleNumber;
		internal XPLMRegisterFlightLoopCallback XPLMRegisterFlightLoopCallback;
		internal XPLMUnregisterFlightLoopCallback XPLMUnregisterFlightLoopCallback;
		internal XPLMSetFlightLoopCallbackInterval XPLMSetFlightLoopCallbackInterval;
		internal XPLMCreateFlightLoop XPLMCreateFlightLoop;
		internal XPLMDestroyFlightLoop XPLMDestroyFlightLoop;
		internal XPLMScheduleFlightLoop XPLMScheduleFlightLoop;

		// Display
		internal XPLMRegisterDrawCallback XPLMRegisterDrawCallback;
		internal XPLMUnregisterDrawCallback XPLMUnregisterDrawCallback;

		// Scenery
		internal XPLMCreateProbe XPLMCreateProbe;
		internal XPLMDestroyProbe XPLMDestroyProbe;
		internal XPLMProbeTerrainXYZ XPLMProbeTerrainXYZ;
		internal XPLMLoadObject XPLMLoadObject;
		internal XPLMLoadObjectAsync XPLMLoadObjectAsync;
		internal XPLMDrawObjects XPLMDrawObjects;
		internal XPLMUnloadObject XPLMUnloadObject;
		internal XPLMLookupObjects XPLMLookupObjects;

		// Graphics
		internal XPLMWorldToLocal XPLMWorldToLocal;
		internal XPLMLocalToWorld XPLMLocalToWorld;

	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 2)]
	public unsafe struct StartParams
	{
		// This type must be kept in sync with the version in C.

		public fixed byte Name[256];

		public fixed byte Signature[256];

		public fixed byte Description[256];

		public long LogHandle;
	}
}
