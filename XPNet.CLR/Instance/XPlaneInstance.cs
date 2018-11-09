using System;
using System.Collections.Generic;
using System.Text;

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
}
