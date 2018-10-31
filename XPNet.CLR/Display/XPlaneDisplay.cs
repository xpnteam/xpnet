using System;

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

		private readonly XPLMDrawingPhase m_inPhase;
		private readonly int m_inWantsBefore;

		public unsafe XPDrawingLoopHook(DrawDelegate drawCallbackDelegate, XPLMDrawingPhase inPhase, int inWantsBefore)
		{
			m_loopDelegate = drawCallbackDelegate;
			m_inPhase = inPhase;
			m_inWantsBefore = inWantsBefore;
			m_hookDelegate = new XPLMDrawCallback_f(XPLMDrawHook);

			var res = PluginBridge.ApiFunctions.XPLMRegisterDrawCallback(m_hookDelegate, m_inPhase, m_inWantsBefore, null);
			if (res == 0)
			{
				throw new ArgumentException($"Phase {m_inPhase} does not exist in this version of X-Plane");
			} else if (res > 1)
			{
				throw new Exception($"Return value {res} is undefined");
			}
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
				PluginBridge.Log.Log(exc);
				return 1; // If an exception happens in the draw hook, then let X-Plane draw
			}
		}

		public unsafe void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMUnregisterDrawCallback(m_hookDelegate, m_inPhase, m_inWantsBefore, null);
		}
	}
}
