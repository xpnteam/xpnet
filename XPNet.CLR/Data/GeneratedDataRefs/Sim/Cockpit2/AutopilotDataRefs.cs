using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_autopilotDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_autopilotDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Auto-throttle on, 0 or 1.  This is the switch.
        /// </summary>
        public IXPDataRef<bool> autothrottle_enabled { get { return m_data.GetBool("sim/cockpit2/autopilot/autothrottle_enabled");} }

        /// <summary>
        ///  Auto-throttle really working?  Takes into account failures, esys, etc.
        /// </summary>
        public IXPDataRef<bool> autothrottle_on { get { return m_data.GetBool("sim/cockpit2/autopilot/autothrottle_on");} }

        /// <summary>
        ///  Is the autopilot really on? Takes into account electrical system, failures, etc.;
        /// </summary>
        public IXPDataRef<bool> autopilot_on { get { return m_data.GetBool("sim/cockpit2/autopilot/autopilot_on");} }

        /// <summary>
        ///  Are the servos on?  Takes into account FD mode and control-wheel-steering, failures, etc.
        /// </summary>
        public IXPDataRef<bool> servos_on { get { return m_data.GetBool("sim/cockpit2/autopilot/servos_on");} }

        /// <summary>
        ///  Autopilot airspeed is Mach number rather than knots.
        /// </summary>
        public IXPDataRef<bool> airspeed_is_mach { get { return m_data.GetBool("sim/cockpit2/autopilot/airspeed_is_mach");} }

        /// <summary>
        ///  Is the combined alt/vvi selector showing VVI?
        /// </summary>
        public IXPDataRef<bool> alt_vvi_is_showing_vvi { get { return m_data.GetBool("sim/cockpit2/autopilot/alt_vvi_is_showing_vvi");} }

        /// <summary>
        ///  Vnav is armed, 0 or 1 - this is different from the "FMS" button - it is used ONLY for a physical G1000 connected by ethernet.
        /// </summary>
        public IXPDataRef<bool> vnav_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/vnav_armed");} }

        /// <summary>
        ///  Altitude is armed, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> altitude_hold_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/altitude_hold_armed");} }

        /// <summary>
        ///  Localizer is armed, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> hnav_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/hnav_armed");} }

        /// <summary>
        ///  Glideslope is armed, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> glideslope_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/glideslope_armed");} }

        /// <summary>
        ///  Back course is armed, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> backcourse_on { get { return m_data.GetBool("sim/cockpit2/autopilot/backcourse_on");} }

        /// <summary>
        ///  Airspeed hold value, knots or Mach depending on km_is_mach.
        /// </summary>
        public IXPDataRef<float> airspeed_dial_kts_mach { get { return m_data.GetFloat("sim/cockpit2/autopilot/airspeed_dial_kts_mach");} }

        /// <summary>
        ///  Airspeed hold bug, always in knots, even if the AP is in mach-hold mode.
        /// </summary>
        public IXPDataRef<float> airspeed_dial_kts { get { return m_data.GetFloat("sim/cockpit2/autopilot/airspeed_dial_kts");} }

        /// <summary>
        ///  Heading hold commanded, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> heading_dial_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/autopilot/heading_dial_deg_mag_pilot");} }

        /// <summary>
        ///  Heading hold commanded, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> heading_dial_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/autopilot/heading_dial_deg_mag_copilot");} }

        /// <summary>
        ///  VVI commanded in FPM.
        /// </summary>
        public IXPDataRef<float> vvi_dial_fpm { get { return m_data.GetFloat("sim/cockpit2/autopilot/vvi_dial_fpm");} }

        /// <summary>
        ///  VVI commanded in FPM.
        /// </summary>
        public IXPDataRef<float> altitude_dial_ft { get { return m_data.GetFloat("sim/cockpit2/autopilot/altitude_dial_ft");} }

        /// <summary>
        ///  Altitude hold commanded in feet indicated.
        /// </summary>
        public IXPDataRef<float> altitude_hold_ft { get { return m_data.GetFloat("sim/cockpit2/autopilot/altitude_hold_ft");} }

        /// <summary>
        ///  Target altitude hold in VNAV mode.
        /// </summary>
        public IXPDataRef<float> altitude_vnav_ft { get { return m_data.GetFloat("sim/cockpit2/autopilot/altitude_vnav_ft");} }

        /// <summary>
        ///  Pitch-hold commanded in degrees up.
        /// </summary>
        public IXPDataRef<float> sync_hold_pitch_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/sync_hold_pitch_deg");} }

        /// <summary>
        ///  Roll-hold commanded in degrees right.
        /// </summary>
        public IXPDataRef<float> sync_hold_roll_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/sync_hold_roll_deg");} }

        /// <summary>
        ///  Flight director pitch deflection in degrees, pos up.
        /// </summary>
        public IXPDataRef<float> flight_director_pitch_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/flight_director_pitch_deg");} }

        /// <summary>
        ///  Flight director roll deflection in degrees, pos right.
        /// </summary>
        public IXPDataRef<float> flight_director_roll_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/flight_director_roll_deg");} }

        /// <summary>
        ///  Nose-up pitch to hold when TOGA operations are in effect.  Set this back when your aircraft unloads!
        /// </summary>
        public IXPDataRef<float> TOGA_pitch_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/toga_pitch_deg");} }

        /// <summary>
        ///  Enables the FMS to take over vertical control of the autopilot.   This matches the command "sim/autopilot/FMS"."
        /// </summary>
        public IXPDataRef<bool> fms_vnav { get { return m_data.GetBool("sim/cockpit2/autopilot/fms_vnav");} }
    }
}