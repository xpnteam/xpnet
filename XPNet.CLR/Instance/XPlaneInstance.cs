using System;
using System.Collections.Generic;
using System.Linq;

namespace XPNet
{
	/// <summary>
	/// Provides access to the X-Plane instance API, which allows 
	/// instanced drawing of X-Plane objects (.obj files).
	/// </summary>
	/// <remarks>
	/// <para>
	/// By registering an instance of an object, the drawing
	/// is done by X-Plane itself, so no drawing loop needs 
	/// to be registered.
	/// </para>
	/// <para>
	/// Instance drawing is the recommended way of drawing objects
	/// in X-Plane. Drawing directly in the drawing loop is
	/// deprecated and will be possibly not be supported anymore
	/// in the future.
	/// </para>
	/// <para>
	/// Through XPNet, the typical usage looks like this:
	/// <list type="bullet">
	/// <item>
	/// <description>Load an XPSceneryObject with <code>api.Scenery.LoadObject</code></description>
	/// </item>
	/// <item>
	/// <description>Create an instance of the object with <code>api.Instance.Create</code> or <code>xpSceneryObject.CreateInstance</code>, passing
	/// the datarefs that are supposed to be manipulated during instance lifetime.</description>
	/// </item>
	/// <item>
	/// <description>Manipulate position and datarefs with <code>xpInstance.SetPosition</code></description>
	/// </item>
	/// <item>
	/// <description>Dispose the instance when not needed anymore</description>
	/// </item>
	/// </list>
	/// </para>
	/// </remarks>
	public interface IXPlaneInstance
	{
		/// <summary>
		/// Registers an instance of an X-Plane object.
		/// </summary>
		/// <param name="inSceneryObject">The object for which an instance should be registered</param>
		/// <param name="inDataRefs">A list of datarefs that are supposed to be manipulated during instance lifetime</param>
		/// <returns>The registered instance</returns>
		IXPInstance Create(IXPSceneryObject inSceneryObject, string[] inDataRefs);
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
