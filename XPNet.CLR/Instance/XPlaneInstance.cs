using System;
using System.Collections.Generic;
using System.Linq;

namespace XPNet
{
	public interface IXPlaneInstance
	{
		unsafe IXPInstance Create(IXPSceneryObject inSceneryObject, string[] inDataRefs);
	}

	internal class XPlaneInstance : IXPlaneInstance
	{
		public IXPInstance Create(IXPSceneryObject inSceneryObject, string[] inDataRefs)
		{
			return inSceneryObject.CreateInstance(inDataRefs);
		}
	}

	public interface IXPInstance : IDisposable
	{
		void SetPosition(XPDrawInfo xPLMDrawInfo_t, float[] v);
	}

	internal unsafe class XPInstance : IXPInstance
	{
		private readonly void* m_instanceRef;

		public XPInstance(void* instanceRef)
		{
			m_instanceRef = instanceRef;
		}

		public void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMDestroyInstance(m_instanceRef);
		}

		public void SetPosition(XPDrawInfo xPLMDrawInfo_t, float[] v)
		{
			var floatArray = v.ToArray();
			fixed (float* p = &floatArray[0])
			{
				PluginBridge.ApiFunctions.XPLMInstanceSetPosition(m_instanceRef, xPLMDrawInfo_t, p);
			}
		}
	}
}
