using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_overrideDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_overrideDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Override control of the joystick deflections (overrides stick, yoke, pedals, keys, mouse, and auto-coordination)
        /// </summary>
        public IXPDataRef<bool> override_joystick { get { return m_data.GetBool("sim/operation/override/override_joystick");} }

        /// <summary>
        ///  Override control of the artificial stability system
        /// </summary>
        public IXPDataRef<bool> override_artstab { get { return m_data.GetBool("sim/operation/override/override_artstab");} }

        /// <summary>
        ///  Override all parts of the flight system at once
        /// </summary>
        public IXPDataRef<bool> override_flightcontrol { get { return m_data.GetBool("sim/operation/override/override_flightcontrol");} }

        /// <summary>
        ///  Override gear and brake status
        /// </summary>
        public IXPDataRef<bool> override_gearbrake { get { return m_data.GetBool("sim/operation/override/override_gearbrake");} }

        /// <summary>
        ///  Override position updates of this plane
        /// </summary>
        public IXPDataRef<bool[]> override_planepath { get { return m_data.GetBoolArray("sim/operation/override/override_planepath");} }

        /// <summary>
        ///  Override the AI's control of the plane via the autopilot
        /// </summary>
        public IXPDataRef<bool[]> override_plane_ai_autopilot { get { return m_data.GetBoolArray("sim/operation/override/override_plane_ai_autopilot");} }

        /// <summary>
        ///  Override navcom radios
        /// </summary>
        public IXPDataRef<bool> override_navneedles { get { return m_data.GetBool("sim/operation/override/override_navneedles");} }

        /// <summary>
        ///  Override nav1 receiver
        /// </summary>
        public IXPDataRef<bool> override_nav1_needles { get { return m_data.GetBool("sim/operation/override/override_nav1_needles");} }

        /// <summary>
        ///  Override nav2 receiver
        /// </summary>
        public IXPDataRef<bool> override_nav2_needles { get { return m_data.GetBool("sim/operation/override/override_nav2_needles");} }

        /// <summary>
        ///  Override ADF radios
        /// </summary>
        public IXPDataRef<bool> override_adf { get { return m_data.GetBool("sim/operation/override/override_adf");} }

        /// <summary>
        ///  Override DME distances
        /// </summary>
        public IXPDataRef<bool> override_dme { get { return m_data.GetBool("sim/operation/override/override_dme");} }

        /// <summary>
        ///  Override GPS computer
        /// </summary>
        public IXPDataRef<bool> override_gps { get { return m_data.GetBool("sim/operation/override/override_gps");} }

        /// <summary>
        ///  Override raw heading flown by nav (for GPS that fly by roll commands)
        /// </summary>
        public IXPDataRef<bool> override_nav_heading { get { return m_data.GetBool("sim/operation/override/override_nav_heading");} }

        /// <summary>
        ///  Override flight director needles (both axes)
        /// </summary>
        public IXPDataRef<bool> override_flightdir { get { return m_data.GetBool("sim/operation/override/override_flightdir");} }

        /// <summary>
        ///  Override flight director needles (pitch only)
        /// </summary>
        public IXPDataRef<bool> override_flightdir_ptch { get { return m_data.GetBool("sim/operation/override/override_flightdir_ptch");} }

        /// <summary>
        ///  Override flight director needles (roll only)
        /// </summary>
        public IXPDataRef<bool> override_flightdir_roll { get { return m_data.GetBool("sim/operation/override/override_flightdir_roll");} }

        /// <summary>
        ///  Override camera control.  NOTE: DO NOT USE, USE XPLMCAMERA!!
        /// </summary>
        public IXPDataRef<bool> override_camera { get { return m_data.GetBool("sim/operation/override/override_camera");} }

        /// <summary>
        ///  Override annunciators
        /// </summary>
        public IXPDataRef<bool> override_annunciators { get { return m_data.GetBool("sim/operation/override/override_annunciators");} }

        /// <summary>
        ///  Override the autopilot's brains
        /// </summary>
        public IXPDataRef<bool> override_autopilot { get { return m_data.GetBool("sim/operation/override/override_autopilot");} }

        /// <summary>
        ///  Override just heading (yaw) control (disables auto-coordination). Use yoke_heading_ratio.
        /// </summary>
        public IXPDataRef<bool> override_joystick_heading { get { return m_data.GetBool("sim/operation/override/override_joystick_heading");} }

        /// <summary>
        ///  Override just pitch control. Use yoke_pitch_ratio.
        /// </summary>
        public IXPDataRef<bool> override_joystick_pitch { get { return m_data.GetBool("sim/operation/override/override_joystick_pitch");} }

        /// <summary>
        ///  Override just roll control. Use yoke_roll_ratio.
        /// </summary>
        public IXPDataRef<bool> override_joystick_roll { get { return m_data.GetBool("sim/operation/override/override_joystick_roll");} }

        /// <summary>
        ///  Override the throttles. Use ENGN_thro_use to control them.
        /// </summary>
        public IXPDataRef<bool> override_throttles { get { return m_data.GetBool("sim/operation/override/override_throttles");} }

        /// <summary>
        ///  Override the prop pitch.  Use POINT_pitch_deg_use to edit.
        /// </summary>
        public IXPDataRef<bool> override_prop_pitch { get { return m_data.GetBool("sim/operation/override/override_prop_pitch");} }

        /// <summary>
        ///  Override the prop mode.  Use ENGN_propmode to edit.
        /// </summary>
        public IXPDataRef<bool> override_prop_mode { get { return m_data.GetBool("sim/operation/override/override_prop_mode");} }

        /// <summary>
        ///  Override the mixture controls.  Use ENGN_mixt to edit.
        /// </summary>
        public IXPDataRef<bool> override_mixture { get { return m_data.GetBool("sim/operation/override/override_mixture");} }

        /// <summary>
        ///  Override the FMS going to the next waypoint.
        /// </summary>
        public IXPDataRef<bool> override_fms_advance { get { return m_data.GetBool("sim/operation/override/override_fms_advance");} }

        /// <summary>
        ///  overrides fuel flow variable sim/flightmodel/engine/ENGN_FF_
        /// </summary>
        public IXPDataRef<bool> override_fuel_flow { get { return m_data.GetBool("sim/operation/override/override_fuel_flow");} }

        /// <summary>
        ///  overrides engine temp vars sim/flightmodel/engine/ENGN_EGT_c and ENGN_ITT_c
        /// </summary>
        public IXPDataRef<bool> override_itt_egt { get { return m_data.GetBool("sim/operation/override/override_itt_egt");} }

        /// <summary>
        ///  overrides individual control surfaces, e.g. sim/flightmodel/controls/lail1def
        /// </summary>
        public IXPDataRef<bool> override_control_surfaces { get { return m_data.GetBool("sim/operation/override/override_control_surfaces");} }

        /// <summary>
        ///  overrides all engine calculations - write to LMN and g_nrml/side/axil.
        /// </summary>
        public IXPDataRef<bool> override_engines { get { return m_data.GetBool("sim/operation/override/override_engines");} }

        /// <summary>
        ///  overrides all force calculations - write to LMN and g_nrml/side/axil.
        /// </summary>
        public IXPDataRef<bool> override_forces { get { return m_data.GetBool("sim/operation/override/override_forces");} }

        /// <summary>
        ///  overrides speed, heading, and rocking of boats. index 0=carrier, 1=frigate
        /// </summary>
        public IXPDataRef<bool[]> override_boats { get { return m_data.GetBoolArray("sim/operation/override/override_boats");} }

        /// <summary>
        ///  overrides building and drawing of clouds as well as white-out-in-cloud effects
        /// </summary>
        public IXPDataRef<bool> override_clouds { get { return m_data.GetBool("sim/operation/override/override_clouds");} }

        /// <summary>
        ///  overrides the steering of individual gear from tiller/rudder.
        /// </summary>
        public IXPDataRef<bool> override_wheel_steer { get { return m_data.GetBool("sim/operation/override/override_wheel_steer");} }

        /// <summary>
        ///  overrides when the airport lites go on and off.
        /// </summary>
        public IXPDataRef<bool> override_airport_lites { get { return m_data.GetBool("sim/operation/override/override_airport_lites");} }

        /// <summary>
        ///  this override turns off transfer and dump and lets the plugin decide if the engine gets fuel
        /// </summary>
        public IXPDataRef<bool> override_fuel_system { get { return m_data.GetBool("sim/operation/override/override_fuel_system");} }

        /// <summary>
        ///  this override lets third party add-ons write to the TCAS source data array
        /// </summary>
        public IXPDataRef<bool> override_TCAS { get { return m_data.GetBool("sim/operation/override/override_tcas");} }

        /// <summary>
        ///  this override gives plguins control of sim/flightmodel2/controls/left_brake_ratio and right_brake_ratio
        /// </summary>
        public IXPDataRef<bool> override_toe_brakes { get { return m_data.GetBool("sim/operation/override/override_toe_brakes");} }
    }
}