using XPNet;
using System;
using System.Numerics;
//using OpenTK
using XPNet.CLR;

namespace XPNet
{
	/// <summary>
	/// This is a testbed for getting the graphics going.
	/// </summary>
	[XPlanePlugin(
		name: "Graphicstest",
		signature: "mb.plugins.graphics",
		description: "This should test the graphics."
	)]

	public class GraphicsTestPlugin : IXPlanePlugin
	{
		private readonly IXPlaneApi m_api;
		private readonly IXPProbe m_probe;
		private readonly IXPDrawingLoopHook drawingLoopHook;
		private readonly IXPSceneryObject myPrivateBoeing;
		private double incYaw;


		public GraphicsTestPlugin(IXPlaneApi api)
		{
			m_api = api ?? throw new ArgumentNullException(nameof(api));

			m_api.Log.Log("Displaytest started");
			drawingLoopHook = m_api.Display.RegisterDrawCallback(DoSomething, XPLMDrawingPhase.xplm_Phase_Airplanes, 0);
			m_api.Log.Log("And now create a probe");
			m_probe = m_api.Scenery.CreateProbe();
			m_api.Log.Log("Probe created");
			m_api.Log.Log("Loading my private Boeing 737-800");
			myPrivateBoeing = m_api.Scenery.LoadObject(@"Resources/CSL/BB_Boeing/B738/B738_NAX.obj");
			m_api.Log.Log("Loaded and still living");
			incYaw = 0;

		}

		private int DoSomething(XPLMDrawingPhase inPhase, int inIsBefore)
		{
			var (x, y, z) = m_api.Graphics.WorldToLocal(47.439444, 19.261944, 151);
			var res = m_probe.ProbeTerrainXYZ((float)x, 0, (float)z);
			//var pitch = Math.Asin(-res.NormalY)*180/Math.PI;
			//var yaw = Math.Atan2(res.NormalX, res.NormalZ)*180/Math.PI;
			//incRoll += 1 % 360;
			Vector3 myLocation = new Vector3((float)x, (float)y, (float)z);
			Vector3 myTerrain = new Vector3(res.NormalX, res.NormalY, res.NormalZ);
			var biigVector = myLocation + myTerrain * 100;



			myTerrain = myTerrain / myTerrain.Length();
			Vector2 projYZ = new Vector2(myTerrain.Y, myTerrain.Z);
			//var angl1 = Vector3.Dot(projYZ, Vector3.UnitY)/projYZ.Length();
			var angl1 = myTerrain.Y / projYZ.Length();
			var radPitch = Math.Acos(angl1);
			var degPitch = radPitch * 180 / Math.PI;

			Vector2 projXY = new Vector2(myTerrain.X, myTerrain.Y);
			//var angl2 = Vector3.Dot(projXY, Vector3.UnitY) / projXY.Length();
			var angl2 = myTerrain.Y / projXY.Length();
			var radRoll = Math.Acos(angl2);
			var degRoll = radRoll * 180 / Math.PI;

			incYaw += 1 % 360;

			var (lat, lon, alt) = m_api.Graphics.LocalToWorld(res.LocationX, res.LocationY, res.LocationZ);


			//PluginBridge.Log.Log("GL.Color3(0.0, 1.0, 0.2);");
			OpenGL.glColor3f((float)0.0, (float)1.0, (float)0.2);
			//PluginBridge.Log.Log("GL.Color3(0.0, 1.0, 0.2); Done");

			//PluginBridge.Log.Log("Gl.Begin(PrimitiveType.Lines);");
			OpenGL.glBegin((uint)OpenGL.BeginMode.GL_LINES);

			//PluginBridge.Log.Log("Gl.Vertex3(x,y,z);");
			OpenGL.glVertex3d(x,y,z);

			////PluginBridge.Log.Log("Gl.Vertex3(biigVector.X,biigVector.Y,biigVector.Z);");
			OpenGL.glVertex3f(biigVector.X,biigVector.Y,biigVector.Z);

			////PluginBridge.Log.Log("Gl.End();");
			OpenGL.glEnd();

			OpenGL.glMatrixMode((uint)OpenGL.MatrixMode.GL_MODELVIEW);
			
			OpenGL.glPushMatrix();
			//OpenGL.glTranslatef((float)x, res.LocationY, (float)z);
			//OpenGL.glLoadIdentity();
			//OpenGL.gluLookAt(x, res.LocationY, z, x, res.LocationY, z, 0, 1, 0);
			//OpenGL.glRotated(incYaw/360, 0, -1, 0);
			OpenGL.glTranslatef((float)x, res.LocationY, (float)z);


			//OpenGL.glRotated(radPitch, 1, 0, 0);
			//OpenGL.glRotated(radRoll, 0, 0, -1);

			myPrivateBoeing.Draw(0, 0, new XPLMDrawInfo_t[] { new XPLMDrawInfo_t((float)0, (float)0, (float)0, (float)0, (float)0, (float)0) });

			OpenGL.glPopMatrix();


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