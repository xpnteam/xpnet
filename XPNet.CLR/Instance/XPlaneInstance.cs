using System;
using System.Collections.Generic;
using System.Linq;

namespace XPNet
{
	public interface IXPlaneInstance
	{
		void CreateInstance();
		void DestroyInstance();
	}

	internal class XPlaneInstance : IXPlaneInstance
	{
		public void CreateInstance()
		{
			throw new NotImplementedException();
		}

		public void DestroyInstance()
		{
			throw new NotImplementedException();
		}
	}

	public interface IXPInstance : IDisposable
	{
		void SetPosition(XPDrawInfo xPLMDrawInfo_t, IEnumerable<float> v);
	}

	internal unsafe class XPInstance : IXPInstance
	{
		readonly void* m_instanceRef;

		public XPInstance(void* instanceRef)
		{
			m_instanceRef = instanceRef;
		}

		public void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMDestroyInstance(m_instanceRef);
		}

		public void SetPosition(XPDrawInfo xPLMDrawInfo_t, IEnumerable<float> v)
		{
			var floatArray = v.ToArray();
			fixed (float* p = &floatArray[0])
			{
				PluginBridge.ApiFunctions.XPLMInstanceSetPosition(m_instanceRef, xPLMDrawInfo_t, p);
			}
		}
	}
}
