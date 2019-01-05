using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_AutopilotDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_AutopilotDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Altitude dialed into the AP. Units:ftmsl
        /// </summary>
        public IXPDataRef<float> Altitude => m_data.GetFloat("sim/cockpit/autopilot/altitude");

        /// <summary>
        ///  Currently held altitude (remembered until you hit flchg). Units:ftmsl
        /// </summary>
        public IXPDataRef<float> Current_altitude => m_data.GetFloat("sim/cockpit/autopilot/current_altitude");

        /// <summary>
        ///  Vertical speed to hold. Units:fpm
        /// </summary>
        public IXPDataRef<float> Vertical_velocity => m_data.GetFloat("sim/cockpit/autopilot/vertical_velocity");

        /// <summary>
        ///  Airspeed to hold, this changes from knots to a mach number. Units:knots_mach
        /// </summary>
        public IXPDataRef<float> Airspeed => m_data.GetFloat("sim/cockpit/autopilot/airspeed");

        /// <summary>
        ///  The heading to fly (true, legacy). Units:degt
        /// </summary>
        public IXPDataRef<float> Heading => m_data.GetFloat("sim/cockpit/autopilot/heading");

        /// <summary>
        ///  The heading to fly (magnetic, preferred) pilot. Units:degm
        /// </summary>
        public IXPDataRef<float> Heading_mag => m_data.GetFloat("sim/cockpit/autopilot/heading_mag");

        /// <summary>
        ///  The heading to fly (magnetic, preferred) copilot. Units:degm
        /// </summary>
        public IXPDataRef<float> Heading_mag2 => m_data.GetFloat("sim/cockpit/autopilot/heading_mag2");

        /// <summary>
        ///  The recommended pitch from the Flight Director.  Use override_flightdir. Units:degrees
        /// </summary>
        public IXPDataRef<float> Flight_director_pitch => m_data.GetFloat("sim/cockpit/autopilot/flight_director_pitch");

        /// <summary>
        ///  The recommended roll from the Flight Director.  Use override_flightdir. Units:degrees
        /// </summary>
        public IXPDataRef<float> Flight_director_roll => m_data.GetFloat("sim/cockpit/autopilot/flight_director_roll");

        /// <summary>
        ///  The pitch held when in pitch-hold mode.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Syn_hold_deg => m_data.GetFloat("sim/cockpit/autopilot/syn_hold_deg");

        /// <summary>
        ///  Heading to fly in nav mode - write this when override_nav_heading is set.  Useful for making a custom GPS that flies arcs.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Nav_steer_deg_mag => m_data.GetFloat("sim/cockpit/autopilot/nav_steer_deg_mag");
    }
}