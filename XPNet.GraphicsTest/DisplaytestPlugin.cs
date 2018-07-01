using XPNet;
using System;

namespace XPNet
{
	[XPlanePlugin(
		name: "Displaytest",
		signature: "mb.plugins.displaytest",
		description: "This should test the display."
	)]

	public class DisplaytestPlugin : IXPlanePlugin
	{
		private readonly IXPlaneApi m_api;
		private readonly IXPProbe m_probe;
		private readonly IXPDrawingLoopHook drawingLoopHook;

		public DisplaytestPlugin(IXPlaneApi api)
		{
			m_api = api ?? throw new ArgumentNullException("api");

			m_api.Log.Log("Displaytest started");
			drawingLoopHook = m_api.Display.RegisterDrawCallback(DoSomething, XPLMDrawingPhase.xplm_Phase_Airplanes, 0);
			m_api.Log.Log("And now create a probe");
			m_probe = m_api.Scenery.CreateProbe();
			m_api.Log.Log("Probe created");
		}

		private int DoSomething(XPLMDrawingPhase inPhase, int inIsBefore)
		{
			var (x,y,z) = m_api.Graphics.WorldToLocal(47.439444, 19.261944, 151);
			m_api.Log.Log($"The coordinate is {x}, {y}, {z}!");
			var res = m_probe.ProbeTerrainXYZ((float)x, 0, (float)z);
			var (lat, lon, alt) = m_api.Graphics.LocalToWorld(res.LocationX, res.LocationY, res.LocationZ);
			m_api.Log.Log($"Altitude in meters is {alt}");
			m_api.Log.Log($"Result is {res.Result}");

			return 1;
		}

		public void Dispose()
		{
			// Clean up whatever we attached / registered for / etc.
			drawingLoopHook.Dispose();
			m_probe.Dispose();
		}

		public void Enable()
		{
			// Nothing to do b/c we don't have any interesting work going on.
		}

		public void Disable()
		{
			// Nothing to do b/c we don't have any interesting work going on.
		}
	}
}