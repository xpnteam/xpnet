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
		/// <summary>
		/// This is the earliest point at which you can draw in 3-d.
		/// </summary>
		FirstScene = 0,

		/// <summary>
		/// Drawing of land and water.
		/// </summary>
		Terrain = 5,

		/// <summary>
		/// Drawing runways and other airport detail.
		/// </summary>
		Airports = 10,

		/// <summary>
		/// Drawing roads, trails, trains, etc.
		/// </summary>
		Vectors = 15,

		/// <summary>
		/// 3-d objects (houses, smokestacks, etc.
		/// </summary>
		Objects = 20,

		/// <summary>
		/// External views of airplanes, both yours and the AI aircraft.
		/// </summary>
		Airplanes = 25,

		/// <summary>
		/// This is the last point at which you can draw in 3-d.
		/// </summary>
		LastScene = 30,

		/// <summary>
		/// This is the first phase where you can draw in 2-d.
		/// </summary>
		FirstCockpit = 35,

		/// <summary>
		/// The non-moving parts of the aircraft panel.
		/// </summary>
		Panel = 40,

		/// <summary>
		/// The moving parts of the aircraft panel.
		/// </summary>
		Gauges = 45,

		/// <summary>
		/// Floating windows from plugins.
		/// </summary>
		Window = 50,

		/// <summary>
		/// The last change to draw in 2d.
		/// </summary>
		LastCockpit = 55,

		[Obsolete("Removed as of XPLM300; Use the full-blown XPLMMap API instead.")]
		LocalMap3D = 100,

		[Obsolete("Removed as of XPLM300; Use the full-blown XPLMMap API instead.")]
		LocalMap2D = 101,

		[Obsolete("Removed as of XPLM300; Use the full-blown XPLMMap API instead.")]
		LocalMapProfile = 102
	}
}
