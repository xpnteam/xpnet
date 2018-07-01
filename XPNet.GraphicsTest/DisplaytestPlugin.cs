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
		private readonly IXPSceneryObject myPrivateBoeing;

		public DisplaytestPlugin(IXPlaneApi api)
		{
			m_api = api ?? throw new ArgumentNullException("api");

			m_api.Log.Log("Displaytest started");
			drawingLoopHook = m_api.Display.RegisterDrawCallback(DoSomething, XPLMDrawingPhase.xplm_Phase_Airplanes, 0);
			m_api.Log.Log("And now create a probe");
			m_probe = m_api.Scenery.CreateProbe();
			m_api.Log.Log("Probe created");
			m_api.Log.Log("Loading my private Boeing 737-800");
			myPrivateBoeing = m_api.Scenery.LoadObject(@"/Users/markusb/Desktop/X-Plane 11/Resources/plugins/disabled/XPlanePlugin/Resources/CSL/BB_Boeing/B738/B738_NAX.obj");
			m_api.Log.Log("Loaded and still living");
		}

		private int DoSomething(XPLMDrawingPhase inPhase, int inIsBefore)
		{
			var (x,y,z) = m_api.Graphics.WorldToLocal(47.439444, 19.261944, 151);
			var res = m_probe.ProbeTerrainXYZ((float)x, 0, (float)z);
			var (lat, lon, alt) = m_api.Graphics.LocalToWorld(res.LocationX, res.LocationY, res.LocationZ);
			myPrivateBoeing.Draw(0, 1, new XPLMDrawInfo_t[] { new XPLMDrawInfo_t((float)x, res.LocationY, (float)z, 0, 0, 0) });

			return 1;
		}

		public void Dispose()
		{
			// Clean up whatever we attached / registered for / etc.
			drawingLoopHook.Dispose();
			myPrivateBoeing.Dispose();
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