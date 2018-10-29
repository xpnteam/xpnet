using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet
{
	/// <summary>
	/// Provides access to the X-Plane scenery API, which allows working with the scenery.
	/// On one hand, it provides probes for locating the physical scenery mesh (get the Y-coordinate of the ground for 
	/// a defined X-Z coordinate).
	/// Furthermore, it allows loading, drawing and managing scenery objects.
	/// </summary>
	public interface IXPlaneScenery
	{
		IXPProbe CreateProbe();

		IXPSceneryObject LoadObject(string path);

		IEnumerable<string> LookupObjects(string path, float latitude, float longitude);
	}

	internal class XPlaneScenery : IXPlaneScenery
	{
		private List<string> lookupObjectPaths;

		public IXPProbe CreateProbe()
		{
			return new XPProbe(XPLMProbeType.xplm_ProbeY);
		}

		public IXPSceneryObject LoadObject(string path)
		{
			return new XPSceneryObject(path);
		}

		public unsafe IEnumerable<string> LookupObjects(string path, float latitude, float longitude)
		{
			var en = new XPLMLibraryEnumerator_f(Enumerator);
			lookupObjectPaths = new List<string>();
			PluginBridge.Log.Log($"Now calling API function with path {path}");
			int numObjects = PluginBridge.ApiFunctions.XPLMLookupObjects(path, latitude, longitude, en, null);
			PluginBridge.Log.Log($"API function called, {numObjects} objects were found");
			return lookupObjectPaths;
		}

		private unsafe void Enumerator(string inFilePath, void* inRef)
		{
			PluginBridge.Log.Log($"Enumerator called with path {inFilePath}");
			lookupObjectPaths.Add(inFilePath);
		}
	}

	public interface IXPSceneryObject : IDisposable
	{
		void Draw(int lighting, int earthRelativ, XPLMDrawInfo_t[] drawInfos);
	}

	internal unsafe class XPSceneryObject : IXPSceneryObject
	{
		private void* m_objectRef;

		public XPSceneryObject(string path)
		{
			m_objectRef = PluginBridge.ApiFunctions.XPLMLoadObject(path);
			if (m_objectRef == null) throw new System.IO.FileNotFoundException();
		}

		public unsafe void Draw(int lighting, int earthRelative, XPLMDrawInfo_t[] drawInfos)
		{
			fixed (XPLMDrawInfo_t* drawInfosP = &drawInfos[0])
				PluginBridge.ApiFunctions.XPLMDrawObjects(m_objectRef, drawInfos.Length, drawInfosP, lighting, earthRelative);
		}

		public void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMUnloadObject(m_objectRef);
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
		private XPLMProbeInfo_t _probeInfo;
		private XPLMProbeResult _result;

		internal unsafe XPProbeResult(void* probeRef, float inX, float inY, float inZ)
		{
			_probeInfo = new XPLMProbeInfo_t();
			_probeInfo.structSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(XPLMProbeInfo_t));

			fixed (XPLMProbeInfo_t* probeInfoP = &_probeInfo)
			{
				_result = PluginBridge.ApiFunctions.XPLMProbeTerrainXYZ(probeRef, inX, inY, inZ, probeInfoP);
			}
		}

		public float LocationX => _probeInfo.locationX;

		public float LocationY => _probeInfo.locationY;

		public float LocationZ => _probeInfo.locationZ;

		public float NormalX => _probeInfo.normalX;

		public float NormalY => _probeInfo.normalY;

		public float NormalZ => _probeInfo.normalZ;

		public float VelocityX => _probeInfo.velocityX;

		public float VelocityY => _probeInfo.velocityY;

		public float VelocityZ => _probeInfo.velocityZ;

		public int IsWet => _probeInfo.is_wet;

		public XPLMProbeResult Result => _result;
	}

	internal class XPProbe : IXPProbe
	{
		private unsafe void* probeRef;

		public unsafe XPProbe(XPLMProbeType probeType)
		{
			probeRef = PluginBridge.ApiFunctions.XPLMCreateProbe(probeType);
		}

		public unsafe void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMDestroyProbe(probeRef);
		}

		public unsafe IXPProbeResult ProbeTerrainXYZ(float inX, float inY, float inZ)
		{
			return new XPProbeResult(probeRef, inX, inY, inZ);
		}
	}


}
