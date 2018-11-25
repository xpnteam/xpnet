using System;
using System.Collections.Generic;
using System.Linq;

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
		void Draw(int lighting, int earthRelative, XPLMDrawInfo_t[] drawInfos);
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

		public void Draw(int lighting, int earthRelative, XPLMDrawInfo_t[] drawInfos)
		{
			fixed (XPLMDrawInfo_t* p = drawInfos)
			{
				PluginBridge.Log.Log($"Drawing {drawInfos.Length} objects");
				PluginBridge.ApiFunctions.XPLMDrawObjects(m_objectRef, drawInfos.Length, p, lighting, earthRelative);
			}
		}
	}


	public interface IXPProbe : IDisposable
	{
		IXPProbeResult ProbeTerrainXYZ(float inX, float inY, float inZ);
	}

	public interface IXPProbeResult
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

		XPLMProbeResult Result { get; }

	}

	internal class XPProbeResult : IXPProbeResult
	{
		private readonly XPLMProbeInfo_t m_probeInfo;
		private readonly XPLMProbeResult m_result;

		internal unsafe XPProbeResult(void* probeRef, float inX, float inY, float inZ)
		{
			m_probeInfo = new XPLMProbeInfo_t();
			m_result = PluginBridge.ApiFunctions.XPLMProbeTerrainXYZ(probeRef, inX, inY, inZ, m_probeInfo);
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

		public XPLMProbeResult Result => m_result;
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

		public unsafe IXPProbeResult ProbeTerrainXYZ(float inX, float inY, float inZ)
		{
			return new XPProbeResult(m_probeRef, inX, inY, inZ);
		}
	}
}
