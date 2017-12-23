
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Runtime.Loader;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

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
            try
            {
                var thisAssemblyPath = typeof(PluginBridge).GetTypeInfo().Assembly.Location;
                var rootDir = Path.GetDirectoryName(thisAssemblyPath);

                m_configFilePath = Path.Combine(rootDir, "xpnetcfg.json");
                m_logFilePath = Path.Combine(rootDir, "xpnet.log");

                // We always start out with logging enabled.  We may reconfigure it off once config loads.
                m_log = InitLogging(ref startParams);

                m_log.Log("XPNet CLR: Start");

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
            catch (Exception exc)
            {
                // File.WriteAllText(@"D:\Games\X-Plane\X-Plane 11 Beta\Resources\plugins\XPNetDev\64\Emergency.txt", "Error: " + exc);
                m_log?.Log(exc);
                return false;
            }
        }

        public static bool Enable()
        {
            try
            {
                m_api.Log.Log("XPNet CLR: Enable");

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
            try
            {
                m_api.Log.Log("XPNet CLR: Disable");

                m_plugin.Disable();
            }
            catch (Exception exc)
            {
                m_log?.Log(exc);
            }
        }

        public static bool Stop()
        {
            try
            {
                m_api.Log.Log("XPNet CLR: Stop");

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
            m_api.Messages.RaiseMessage(fromPluginId, msg, inParam);
        }

        private static unsafe ILog InitLogging(ref StartParams startParams)
        {
            // If the calling environment provides a log handle, that's
            // what we'll use.  Otherwise we use configuration to
            // determine what kind of log file to open.

            var hLog = (IntPtr) startParams.LogHandle;

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
            return loggingEnabled ? new StreamLog(m_logFilePath) : (ILog) new NullLog();
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

                return (IXPlanePlugin) ctor.Invoke(new[] { m_api });
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
