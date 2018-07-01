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
	}

	internal class XPlaneScenery : IXPlaneScenery
	{
		public IXPProbe CreateProbe()
		{
			return new XPProbe(XPLMProbeType.xplm_ProbeY);
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
			PluginBridge.Log.Log("Making a Proberesult");
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
