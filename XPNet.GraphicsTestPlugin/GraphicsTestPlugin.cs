using System;
//using OpenTK
using System.Linq;

namespace XPNet
{
	/// <summary>
	/// This is a testbed for getting the graphics going.
	/// </summary>
	[XPlanePlugin(
		name: "GraphicsTestPlugin",
		signature: "mb.plugins.graphics",
		description: "This should test the graphics."
	)]

	public class GraphicsTestPlugin : IXPlanePlugin
	{
		private const string TUGPATH = "lib/airport/vehicles/pushback/tug.obj";
		//private const string TUGPATH = "lib/airport/vehicles/pushback/*.obj";
		private readonly IXPlaneApi m_api;
		private readonly IXPProbe m_probe;
		private readonly IXPDrawingLoopHook drawingLoopHook;
		private readonly IXPFlightLoopHook flightLoopHook;
		private IXPSceneryObject testTug;


		public GraphicsTestPlugin(IXPlaneApi api)
		{
			m_api = api ?? throw new ArgumentNullException(nameof(api));

			m_api.Log.Log("Displaytest started");
			drawingLoopHook = m_api.Display.RegisterDrawHook(DoSomething, XPLMDrawingPhase.xplm_Phase_Airplanes, 0);
			flightLoopHook = m_api.Processing.RegisterFlightLoopHook(FlightLoopTime.FromCycles(1), SimLoaded);
			m_api.Log.Log("And now create a probe");
			m_probe = m_api.Scenery.CreateProbe();
			m_api.Log.Log("Probe created");
			m_api.Messages.MessageReceived += Messages_MessageReceived;
		}

		private FlightLoopTime SimLoaded(TimeSpan elapsedTimeSinceLastCall, TimeSpan elapsedTimeSinceLastFlightLoop, int counter)
		{
			m_api.Log.Log($"Loading objects with path {TUGPATH}");
			var tugs = m_api.Scenery.LookupObjects(TUGPATH, 0, 0);
			foreach (var p in tugs)
			{
				m_api.Log.Log($"Filename: {p}");
			}
			testTug = m_api.Scenery.LoadObject(tugs.First());
			m_api.Log.Log($"Loaded and still living, reference is {testTug}");

			flightLoopHook.Dispose();
			return FlightLoopTime.Unscheduled;
		}

		private void Messages_MessageReceived(object sender, XPMessageEventArgs e)
		{
			m_api.Log.Log($"Received message {e.MessageId} from plugin {e.SentFromPluginId}");
		}

		private int DoSomething(XPLMDrawingPhase inPhase, int inIsBefore)
		{
			m_api.Log.Log("Entering drawing callback");

			var (x, y, z) = m_api.Graphics.WorldToLocal(47.439444, 19.261944, 0);
			var res = m_probe.ProbeTerrainXYZ((float)x, 0, (float)z);

			var (lat, lon, alt) = m_api.Graphics.LocalToWorld(res.LocationX, res.LocationY, res.LocationZ);

			testTug.Draw(0, 0, new XPLMDrawInfo_t[] { new XPLMDrawInfo_t((float)res.LocationX, (float)res.LocationY, (float)res.LocationZ, (float)0, (float)0, (float)0) });
			
			return 1;
		}

		public void Dispose()
		{
			// Clean up whatever we attached / registered for / etc.
			drawingLoopHook.Dispose();
			testTug.Dispose();
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

		private static readonly float[] _ArrayPosition = new float[] {
			0.0f, 0.0f,
			1.0f, 0.0f,
			1.0f, 1.0f
		};

		/// <summary>
		/// Vertex color array.
		/// </summary>
		private static readonly float[] _ArrayColor = new float[] {
			1.0f, 0.0f, 0.0f,
			0.0f, 1.0f, 0.0f,
			0.0f, 0.0f, 1.0f
		};
	}
}