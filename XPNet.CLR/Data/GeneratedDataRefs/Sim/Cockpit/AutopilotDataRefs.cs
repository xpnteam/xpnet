using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_autopilotDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_autopilotDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Back course selection
        /// </summary>
        public IXPDataRef<bool> backcourse_on { get { return m_data.GetBool("sim/cockpit/autopilot/backcourse_on");} }

        /// <summary>
        ///  Altitude dialed into the AP
        /// </summary>
        public IXPDataRef<float> altitude { get { return m_data.GetFloat("sim/cockpit/autopilot/altitude");} }

        /// <summary>
        ///  Currently held altitude (remembered until you hit flchg)
        /// </summary>
        public IXPDataRef<float> current_altitude { get { return m_data.GetFloat("sim/cockpit/autopilot/current_altitude");} }

        /// <summary>
        ///  Vertical speed to hold
        /// </summary>
        public IXPDataRef<float> vertical_velocity { get { return m_data.GetFloat("sim/cockpit/autopilot/vertical_velocity");} }

        /// <summary>
        ///  Airspeed to hold, this changes from knots to a mach number
        /// </summary>
        public IXPDataRef<float> airspeed { get { return m_data.GetFloat("sim/cockpit/autopilot/airspeed");} }

        /// <summary>
        ///  The heading to fly (true, legacy)
        /// </summary>
        public IXPDataRef<float> heading { get { return m_data.GetFloat("sim/cockpit/autopilot/heading");} }

        /// <summary>
        ///  The heading to fly (magnetic, preferred) pilot
        /// </summary>
        public IXPDataRef<float> heading_mag { get { return m_data.GetFloat("sim/cockpit/autopilot/heading_mag");} }

        /// <summary>
        ///  The heading to fly (magnetic, preferred) copilot
        /// </summary>
        public IXPDataRef<float> heading_mag2 { get { return m_data.GetFloat("sim/cockpit/autopilot/heading_mag2");} }

        /// <summary>
        ///  Is our airspeed a mach number (this is writable if the panel has the button, otherwise sim controls)
        /// </summary>
        public IXPDataRef<bool> airspeed_is_mach { get { return m_data.GetBool("sim/cockpit/autopilot/airspeed_is_mach");} }

        /// <summary>
        ///  The recommended pitch from the Flight Director.  Use override_flightdir
        /// </summary>
        public IXPDataRef<float> flight_director_pitch { get { return m_data.GetFloat("sim/cockpit/autopilot/flight_director_pitch");} }

        /// <summary>
        ///  The recommended roll from the Flight Director.  Use override_flightdir
        /// </summary>
        public IXPDataRef<float> flight_director_roll { get { return m_data.GetFloat("sim/cockpit/autopilot/flight_director_roll");} }

        /// <summary>
        ///  The pitch held when in pitch-hold mode.
        /// </summary>
        public IXPDataRef<float> syn_hold_deg { get { return m_data.GetFloat("sim/cockpit/autopilot/syn_hold_deg");} }

        /// <summary>
        ///  Heading to fly in nav mode - write this when override_nav_heading is set.  Useful for making a custom GPS that flies arcs.
        /// </summary>
        public IXPDataRef<float> nav_steer_deg_mag { get { return m_data.GetFloat("sim/cockpit/autopilot/nav_steer_deg_mag");} }
    }
}