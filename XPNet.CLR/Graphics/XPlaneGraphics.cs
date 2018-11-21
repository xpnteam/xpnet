namespace XPNet
{
    /// <summary>
    /// Provides access to the X-Plane graphics API.
    /// </summary>
	public interface IXPlaneGraphics
	{
		(double X, double Y, double Z) WorldToLocal(double inLatitude, double inLongitude, double inAltitude);
		(double Latitude, double Longitude, double Altitude) LocalToWorld(double inX, double inY, double inZ);
	}

	internal class XPlaneGraphics : IXPlaneGraphics
	{
		public unsafe (double X, double Y, double Z) WorldToLocal(double inLatitude, double inLongitude, double inAltitude)
		{
			double outX;
			double outY;
			double outZ;

			PluginBridge.ApiFunctions.XPLMWorldToLocal(inLatitude, inLongitude, inAltitude, &outX, &outY, &outZ);

			// The following is needed to make a copy from the result variables that can be given back. Otherwise they can be collected
			// later on by the GC, leading to crashes.
			double newOutX = outX;
			double newOutY = outY;
			double newOutZ = outZ;
			return (newOutX, newOutY, newOutZ);
		}

		public unsafe (double Latitude, double Longitude, double Altitude) LocalToWorld(double inX, double inY, double inZ)
		{
			double outLatitude;
			double outLongitude;
			double outAltitude;

			PluginBridge.ApiFunctions.XPLMLocalToWorld(inX, inY, inZ, &outLatitude, &outLongitude, &outAltitude);

			// The following is needed to make a copy from the result variables that can be given back. Otherwise they can be collected
			// later on by the GC, leading to crashes.
			double newOutLatitude = outLatitude;
			double newOutLongitude = outLongitude;
			double newOutAltitude = outAltitude;
			return (newOutLatitude, newOutLongitude, newOutAltitude);
		}
	}
}
