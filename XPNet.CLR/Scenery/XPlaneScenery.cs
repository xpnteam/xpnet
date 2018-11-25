using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace XPNet
{
	/// <summary>
	/// Provides access to the X-Plane scenery API, which allows working with the scenery.
	/// Provides probes for locating the physical scenery mesh (i.e., to get the Y-coordinate
	/// of the ground for a defined X-Z coordinate).  Allows loading, drawing and managing
	/// scenery objects.
	/// </summary>
	public interface IXPlaneScenery
	{
		IXPProbe CreateProbe();

		IXPSceneryObject LoadObject(string path);

		IEnumerable<string> LookupObjects(string path, float latitude, float longitude);
	}

	internal class XPlaneScenery : IXPlaneScenery
	{
		public IXPProbe CreateProbe()
		{
			return new XPProbe(XPLMProbeType.xplm_ProbeY);
		}

		public unsafe IXPSceneryObject LoadObject(string path)
		{
			var objectRef = PluginBridge.ApiFunctions.XPLMLoadObject(path);
			if (objectRef == null)
				throw new System.IO.FileNotFoundException(path);

			return new XPSceneryObject(objectRef);
		}

		public unsafe IEnumerable<string> LookupObjects(string path, float latitude, float longitude)
		{
			var lookupObjectPaths = new List<string>();

			unsafe void Enumerator(string inFilePath, void* inRef)
			{
				// PluginBridge.Log.Log($"Enumerator called with path {inFilePath}");
				lookupObjectPaths.Add(inFilePath);
			}

			var en = new XPLMLibraryEnumerator_f(Enumerator);

			// PluginBridge.Log.Log($"Now calling API function with path {path}");
			int numObjects = PluginBridge.ApiFunctions.XPLMLookupObjects(path, latitude, longitude, en, null);
			// PluginBridge.Log.Log($"API function called, {numObjects} objects were found");
			return lookupObjectPaths;
		}
	}

	public interface IXPSceneryObject : IDisposable
	{
		void Draw(int lighting, int earthRelative, XPDrawInfo[] drawInfos);
		IXPInstance CreateInstance(IEnumerable<string> inDataRefs);
	}

	internal unsafe class XPSceneryObject : IXPSceneryObject
	{
		private readonly void* m_objectRef;

		public XPSceneryObject(void* objectRef)
		{
			m_objectRef = objectRef;
		}

		public void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMUnloadObject(m_objectRef);
		}
		public IXPInstance CreateInstance(IEnumerable<string> inDataRefs)
		{
			List<string> dataRefList = inDataRefs.ToList();
			dataRefList.Add(null);
			string[] dataRefArray = dataRefList.ToArray();
			var instanceRef = PluginBridge.ApiFunctions.XPLMCreateInstance(m_objectRef, dataRefArray);
			return new XPInstance(instanceRef);
		}

		public void Draw(int lighting, int earthRelative, XPDrawInfo[] drawInfos)
		{
			fixed (XPDrawInfo* p = drawInfos)
			{
				PluginBridge.Log.Log($"Drawing {drawInfos.Length} objects");
				PluginBridge.ApiFunctions.XPLMDrawObjects(m_objectRef, drawInfos.Length, p, lighting, earthRelative);
			}
		}
	}

	/// <summary>
	/// This is the draw info struct that needs to be passed to 
	/// <see cref="XPLMDrawObjects"/> and corresponds to XPLMDrawInfo_t
	/// in the X-Plane Plugin API. Note that this structure is exposed directly
	/// for performance reasons.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 2)]
	public struct XPDrawInfo
	{
		//Note that the structSize needs to be also an instance member
		//of the struct such that it is layed out correcly for X-Plane
		//Therefore, the size of the struct is initially written into a
		//static member in the static constructor and copied into the
		//instance member in the instance constructor.
		private static readonly int m_structSizeInit;
		internal readonly int m_structSize;
		public float x;
		public float y;
		public float z;
		public float pitch;
		public float heading;
		public float roll;

		static XPDrawInfo()
		{
			m_structSizeInit = Marshal.SizeOf(typeof(XPDrawInfo));
		}

		public XPDrawInfo(float x = default(float), float y = default(float), float z = default(float), float pitch = default(float), float heading = default(float), float roll = default(float))
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



	public interface IXPProbe : IDisposable
	{
		IXPProbeInfo ProbeTerrainXYZ(float inX, float inY, float inZ);
	}

	public interface IXPProbeInfo
	{
		float LocationX { get; }

		float LocationY { get; }

		float LocationZ { get; }

		float NormalX { get; }

		float NormalY { get; }

		float NormalZ { get; }

		float VelocityX { get; }

		float VelocityY { get; }

		float VelocityZ { get; }

		int IsWet { get; }

		XPProbeResult Result { get; }

	}

	internal class XPProbeInfo : IXPProbeInfo
	{
		private readonly XPLMProbeInfo_t m_probeInfo;

		internal unsafe XPProbeInfo(void* probeRef, float inX, float inY, float inZ)
		{
			m_probeInfo = new XPLMProbeInfo_t();
			Result = PluginBridge.ApiFunctions.XPLMProbeTerrainXYZ(probeRef, inX, inY, inZ, m_probeInfo);
		}

		public float LocationX => m_probeInfo.locationX;

		public float LocationY => m_probeInfo.locationY;

		public float LocationZ => m_probeInfo.locationZ;

		public float NormalX => m_probeInfo.normalX;

		public float NormalY => m_probeInfo.normalY;

		public float NormalZ => m_probeInfo.normalZ;

		public float VelocityX => m_probeInfo.velocityX;

		public float VelocityY => m_probeInfo.velocityY;

		public float VelocityZ => m_probeInfo.velocityZ;

		public int IsWet => m_probeInfo.is_wet;

		public XPProbeResult Result { get; }
	}

	internal class XPProbe : IXPProbe
	{
		private unsafe readonly void* m_probeRef;

		public unsafe XPProbe(XPLMProbeType probeType)
		{
			m_probeRef = PluginBridge.ApiFunctions.XPLMCreateProbe(probeType);
		}

		public unsafe void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMDestroyProbe(m_probeRef);
		}

		public unsafe IXPProbeInfo ProbeTerrainXYZ(float inX, float inY, float inZ)
		{
			return new XPProbeInfo(m_probeRef, inX, inY, inZ);
		}
	}

	/// <summary>
	/// The result of the probing
	/// </summary>
	public enum XPProbeResult : int
	{
		// MAINT: This needs to be kept in sync with the
		// XPLMProbeResult enum from the X-Plane API
		ProbeHitTerrain = 0,
		ProbeError = 1,
		ProbeMissed = 2
	}
}
