using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_lightsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_lightsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Ratio of the brightness of the landing lights, 0 is off, 1 is max.
        /// </summary>
        public IXPDataRef<float[]> landing_lights_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/landing_lights_brightness_ratio");} }

        /// <summary>
        ///  Ratio of the brightness of the landing lights, 0 is off, 1 is max.
        /// </summary>
        public IXPDataRef<float[]> generic_lights_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/generic_lights_brightness_ratio");} }

        /// <summary>
        ///  Ratio of the brightness of the taxi light, 0 is off, 1 is max.
        /// </summary>
        public IXPDataRef<float[]> taxi_lights_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/taxi_lights_brightness_ratio");} }

        /// <summary>
        ///  Ratio of the brightness of the spot light, 0 is off, 1 is max.
        /// </summary>
        public IXPDataRef<float[]> spot_lights_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/spot_lights_brightness_ratio");} }

        /// <summary>
        ///  Ratio of the brightness of the nav lights, 0 is off, 1 is max.
        /// </summary>
        public IXPDataRef<float[]> nav_lights_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/nav_lights_brightness_ratio");} }

        /// <summary>
        ///  Ratio of the brightness of the beacon, 0 is off, 1 is max.  Use override_beacons_and_strobes
        /// </summary>
        public IXPDataRef<float[]> beacon_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/beacon_brightness_ratio");} }

        /// <summary>
        ///  Ratio of the brightness of the strobe, 0 is off, 1 is max.  Use override_beacons_and_strobes
        /// </summary>
        public IXPDataRef<float[]> strobe_brightness_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/lights/strobe_brightness_ratio");} }

        /// <summary>
        ///  Heading offset in degrees of the spot light from its default position, positive is right.
        /// </summary>
        public IXPDataRef<float[]> spot_light_heading_deg { get { return m_data.GetFloatArray("sim/flightmodel2/lights/spot_light_heading_deg");} }

        /// <summary>
        ///  Pitch offset in degrees of the spot light from its default position, positive is up.
        /// </summary>
        public IXPDataRef<float[]> spot_light_pitch_deg { get { return m_data.GetFloatArray("sim/flightmodel2/lights/spot_light_pitch_deg");} }

        /// <summary>
        ///  Is any strobe flashing right now?
        /// </summary>
        public IXPDataRef<bool> strobe_flash_now { get { return m_data.GetBool("sim/flightmodel2/lights/strobe_flash_now");} }

        /// <summary>
        ///  override beacon and strobe control
        /// </summary>
        public IXPDataRef<bool> override_beacons_and_strobes { get { return m_data.GetBool("sim/flightmodel2/lights/override_beacons_and_strobes");} }
    }
}