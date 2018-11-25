using System;

namespace XPNet
{
	/// <summary>
	/// Delegate for .NET code that wants to be called as part of the render loop.
	/// </summary>
	public delegate int DrawDelegate(
		XPDrawingPhase inPhase,
		int inIsBefore
	);

	/// <summary>
	/// Provides access to the X-Plane display API, which provides the basic hooks to draw in X-Plane
	/// and create the user interface.
	/// </summary>
	public interface IXPlaneDisplay
	{
		IXPDrawingLoopHook RegisterDrawHook(DrawDelegate drawDelegate, XPDrawingPhase inPhase, int inWantsBefore);
	}

	internal class XPlaneDisplay : IXPlaneDisplay
	{
		public IXPDrawingLoopHook RegisterDrawHook(DrawDelegate drawDelegate, XPDrawingPhase inPhase, int inWantsBefore)
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

		private readonly XPDrawingPhase m_inPhase;
		private readonly int m_inWantsBefore;

		public unsafe XPDrawingLoopHook(DrawDelegate drawCallbackDelegate, XPDrawingPhase inPhase, int inWantsBefore)
		{
			m_loopDelegate = drawCallbackDelegate;
			m_inPhase = inPhase;
			m_inWantsBefore = inWantsBefore;
			m_hookDelegate = new XPLMDrawCallback_f(XPLMDrawHook);

			var res = PluginBridge.ApiFunctions.XPLMRegisterDrawCallback(m_hookDelegate, m_inPhase, m_inWantsBefore, null);
			if (res == 0)
				throw new ArgumentException($"Phase {m_inPhase} does not exist in this version of X-Plane");
            else if (res > 1)
				throw new Exception($"Unexpected return value {res}.");
		}

		public unsafe void Dispose()
		{
			PluginBridge.ApiFunctions.XPLMUnregisterDrawCallback(m_hookDelegate, m_inPhase, m_inWantsBefore, null);
		}

		private unsafe int XPLMDrawHook(XPDrawingPhase inPhase, int inIsBefore, void* inRefcon)
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
	}

	/// <summary>
	/// Describes the phase in which X-Plane is currently drawing
	/// </summary>
	public enum XPDrawingPhase : int
	{
		// MAINT: This needs to be kept in sync with the
		// XPLMDrawingPhase enumerable from the X-Plane API
		FirstScene = 0,
		Terrain = 5,
		Airports = 10,
		Vectors = 15,
		Objects = 20,
		Airplanes = 25,
		LastScene = 30,
		FirstCockpit = 35,
		Panel = 40,
		Gauges = 45,
		Window = 50,
		LastCockpit = 55,
		LocalMap3D = 100,
		LocalMap2D = 101,
		LocalMapProfile = 102
	}
}
