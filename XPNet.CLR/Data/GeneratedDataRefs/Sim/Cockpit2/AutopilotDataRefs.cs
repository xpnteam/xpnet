using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_AutopilotDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_AutopilotDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Airspeed hold value, knots or Mach depending on km_is_mach.. Units:knots/Mach
        /// </summary>
        public IXPDataRef<float> Airspeed_dial_kts_mach => m_data.GetFloat("sim/cockpit2/autopilot/airspeed_dial_kts_mach");

        /// <summary>
        ///  Airspeed hold bug, always in knots, even if the AP is in mach-hold mode.. Units:Knots
        /// </summary>
        public IXPDataRef<float> Airspeed_dial_kts => m_data.GetFloat("sim/cockpit2/autopilot/airspeed_dial_kts");

        /// <summary>
        ///  Heading hold commanded, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Heading_dial_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/autopilot/heading_dial_deg_mag_pilot");

        /// <summary>
        ///  Heading hold commanded, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Heading_dial_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/autopilot/heading_dial_deg_mag_copilot");

        /// <summary>
        ///  VVI commanded in FPM.. Units:feet/Minute
        /// </summary>
        public IXPDataRef<float> Vvi_dial_fpm => m_data.GetFloat("sim/cockpit2/autopilot/vvi_dial_fpm");

        /// <summary>
        ///  VVI commanded in FPM.. Units:feet
        /// </summary>
        public IXPDataRef<float> Altitude_dial_ft => m_data.GetFloat("sim/cockpit2/autopilot/altitude_dial_ft");

        /// <summary>
        ///  Altitude hold commanded in feet indicated.. Units:feet
        /// </summary>
        public IXPDataRef<float> Altitude_hold_ft => m_data.GetFloat("sim/cockpit2/autopilot/altitude_hold_ft");

        /// <summary>
        ///  Target altitude hold in VNAV mode.. Units:feet
        /// </summary>
        public IXPDataRef<float> Altitude_vnav_ft => m_data.GetFloat("sim/cockpit2/autopilot/altitude_vnav_ft");

        /// <summary>
        ///  Pitch-hold commanded in degrees up.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Sync_hold_pitch_deg => m_data.GetFloat("sim/cockpit2/autopilot/sync_hold_pitch_deg");

        /// <summary>
        ///  Roll-hold commanded in degrees right.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Sync_hold_roll_deg => m_data.GetFloat("sim/cockpit2/autopilot/sync_hold_roll_deg");

        /// <summary>
        ///  Flight director pitch deflection in degrees, pos up.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Flight_director_pitch_deg => m_data.GetFloat("sim/cockpit2/autopilot/flight_director_pitch_deg");

        /// <summary>
        ///  Flight director roll deflection in degrees, pos right.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Flight_director_roll_deg => m_data.GetFloat("sim/cockpit2/autopilot/flight_director_roll_deg");

        /// <summary>
        ///  Nose-up pitch to hold when TOGA operations are in effect.  Set this back when your aircraft unloads!. Units:degrees
        /// </summary>
        public IXPDataRef<float> TOGA_pitch_deg => m_data.GetFloat("sim/cockpit2/autopilot/toga_pitch_deg");
    }
}