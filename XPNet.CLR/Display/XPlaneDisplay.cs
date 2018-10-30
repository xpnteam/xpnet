using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet
{
	/// <summary>
	/// Delegate for C# code that wants to be called as part of the render loop.
	/// </summary>
	public delegate int DrawDelegate(
		XPLMDrawingPhase inPhase,
		int inIsBefore
	);

	/// <summary>
	/// Provides access to the X-Plane display API, which provides the basic hooks to draw in X-Plane
	/// and create the user interface.
	/// </summary>
	public interface IXPlaneDisplay
	{
		IXPDrawingLoopHook RegisterDrawHook(DrawDelegate drawDelegate, XPLMDrawingPhase inPhase, int inWantsBefore);
	}

	internal class XPlaneDisplay : IXPlaneDisplay
	{
		public IXPDrawingLoopHook RegisterDrawHook(DrawDelegate drawDelegate, XPLMDrawingPhase inPhase, int inWantsBefore)
		{
			return new XPDrawingLoopHook(drawDelegate, inPhase, inWantsBefore);
		}
	}

	/// <summary>
	/// Represents a hook into the X-Plane render loop.
	/// </summary>
	public interface IXPDrawingLoopHook : IDisposable
	{

	}

	internal class XPDrawingLoopHook : IXPDrawingLoopHook
	{
		private readonly DrawDelegate m_loopDelegate;
		private readonly XPLMDrawCallback_f m_hookDelegate;

		private XPLMDrawingPhase m_inPhase;
		private int m_inWantsBefore;
		private unsafe void* m_inRefcon;

		public unsafe XPDrawingLoopHook(DrawDelegate drawCallbackDelegate, XPLMDrawingPhase inPhase, int inWantsBefore)
		{
			m_loopDelegate = drawCallbackDelegate;
			m_inPhase = inPhase;
			m_inWantsBefore = inWantsBefore;
			m_inRefcon = null;
			m_hookDelegate = new XPLMDrawCallback_f(XPLMDrawHook);
			
			var x = PluginBridge.ApiFunctions.XPLMRegisterDrawCallback(m_hookDelegate, m_inPhase, m_inWantsBefore, m_inRefcon);
		}

		private unsafe int XPLMDrawHook(XPLMDrawingPhase inPhase, int inIsBefore, void* inRefcon)
		{
			try
			{
				var ret = m_loopDelegate(inPhase, inIsBefore);
				return ret;
			}
			catch (Exception exc)
			{
				PluginBridge.Log.Log($"XPNet CLR Drawing hook: {exc}");
				return 0;
			}
		}

		public unsafe void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMUnregisterDrawCallback(m_hookDelegate, m_inPhase, m_inWantsBefore, m_inRefcon);
		}
	}
}
