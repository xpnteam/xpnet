using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_OverrideDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_OverrideDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Override control of the joystick deflections (overrides stick, yoke, pedals, keys, mouse, and auto-coordination)
        /// </summary>
        public IXPDataRef<bool> Override_joystick { get { return m_data.GetBool("sim/operation/override/override_joystick");} }

        /// <summary>
        ///  Override control of the artificial stability system
        /// </summary>
        public IXPDataRef<bool> Override_artstab { get { return m_data.GetBool("sim/operation/override/override_artstab");} }

        /// <summary>
        ///  Override all parts of the flight system at once
        /// </summary>
        public IXPDataRef<bool> Override_flightcontrol { get { return m_data.GetBool("sim/operation/override/override_flightcontrol");} }

        /// <summary>
        ///  Override gear and brake status
        /// </summary>
        public IXPDataRef<bool> Override_gearbrake { get { return m_data.GetBool("sim/operation/override/override_gearbrake");} }

        /// <summary>
        ///  Override position updates of this plane
        /// </summary>
        public IXPDataRef<bool[]> Override_planepath { get { return m_data.GetBoolArray("sim/operation/override/override_planepath");} }

        /// <summary>
        ///  Override the AI's control of the plane via the autopilot
        /// </summary>
        public IXPDataRef<bool[]> Override_plane_ai_autopilot { get { return m_data.GetBoolArray("sim/operation/override/override_plane_ai_autopilot");} }

        /// <summary>
        ///  Override navcom radios
        /// </summary>
        public IXPDataRef<bool> Override_navneedles { get { return m_data.GetBool("sim/operation/override/override_navneedles");} }

        /// <summary>
        ///  Override nav1 receiver
        /// </summary>
        public IXPDataRef<bool> Override_nav1_needles { get { return m_data.GetBool("sim/operation/override/override_nav1_needles");} }

        /// <summary>
        ///  Override nav2 receiver
        /// </summary>
        public IXPDataRef<bool> Override_nav2_needles { get { return m_data.GetBool("sim/operation/override/override_nav2_needles");} }

        /// <summary>
        ///  Override ADF radios
        /// </summary>
        public IXPDataRef<bool> Override_adf { get { return m_data.GetBool("sim/operation/override/override_adf");} }

        /// <summary>
        ///  Override DME distances
        /// </summary>
        public IXPDataRef<bool> Override_dme { get { return m_data.GetBool("sim/operation/override/override_dme");} }

        /// <summary>
        ///  Override GPS computer
        /// </summary>
        public IXPDataRef<bool> Override_gps { get { return m_data.GetBool("sim/operation/override/override_gps");} }

        /// <summary>
        ///  Override raw heading flown by nav (for GPS that fly by roll commands)
        /// </summary>
        public IXPDataRef<bool> Override_nav_heading { get { return m_data.GetBool("sim/operation/override/override_nav_heading");} }

        /// <summary>
        ///  Override flight director needles (both axes)
        /// </summary>
        public IXPDataRef<bool> Override_flightdir { get { return m_data.GetBool("sim/operation/override/override_flightdir");} }

        /// <summary>
        ///  Override flight director needles (pitch only)
        /// </summary>
        public IXPDataRef<bool> Override_flightdir_ptch { get { return m_data.GetBool("sim/operation/override/override_flightdir_ptch");} }

        /// <summary>
        ///  Override flight director needles (roll only)
        /// </summary>
        public IXPDataRef<bool> Override_flightdir_roll { get { return m_data.GetBool("sim/operation/override/override_flightdir_roll");} }

        /// <summary>
        ///  Override camera control.  NOTE: DO NOT USE, USE XPLMCAMERA!!
        /// </summary>
        public IXPDataRef<bool> Override_camera { get { return m_data.GetBool("sim/operation/override/override_camera");} }

        /// <summary>
        ///  Override annunciators
        /// </summary>
        public IXPDataRef<bool> Override_annunciators { get { return m_data.GetBool("sim/operation/override/override_annunciators");} }

        /// <summary>
        ///  Override the autopilot's brains
        /// </summary>
        public IXPDataRef<bool> Override_autopilot { get { return m_data.GetBool("sim/operation/override/override_autopilot");} }

        /// <summary>
        ///  Override just heading (yaw) control (disables auto-coordination). Use yoke_heading_ratio.
        /// </summary>
        public IXPDataRef<bool> Override_joystick_heading { get { return m_data.GetBool("sim/operation/override/override_joystick_heading");} }

        /// <summary>
        ///  Override just pitch control. Use yoke_pitch_ratio.
        /// </summary>
        public IXPDataRef<bool> Override_joystick_pitch { get { return m_data.GetBool("sim/operation/override/override_joystick_pitch");} }

        /// <summary>
        ///  Override just roll control. Use yoke_roll_ratio.
        /// </summary>
        public IXPDataRef<bool> Override_joystick_roll { get { return m_data.GetBool("sim/operation/override/override_joystick_roll");} }

        /// <summary>
        ///  Override the throttles. Use ENGN_thro_use to control them.
        /// </summary>
        public IXPDataRef<bool> Override_throttles { get { return m_data.GetBool("sim/operation/override/override_throttles");} }

        /// <summary>
        ///  Override the prop pitch.  Use POINT_pitch_deg_use to edit.
        /// </summary>
        public IXPDataRef<bool> Override_prop_pitch { get { return m_data.GetBool("sim/operation/override/override_prop_pitch");} }

        /// <summary>
        ///  Override the prop mode.  Use ENGN_propmode to edit.
        /// </summary>
        public IXPDataRef<bool> Override_prop_mode { get { return m_data.GetBool("sim/operation/override/override_prop_mode");} }

        /// <summary>
        ///  Override the mixture controls.  Use ENGN_mixt to edit.
        /// </summary>
        public IXPDataRef<bool> Override_mixture { get { return m_data.GetBool("sim/operation/override/override_mixture");} }

        /// <summary>
        ///  Override the FMS going to the next waypoint.
        /// </summary>
        public IXPDataRef<bool> Override_fms_advance { get { return m_data.GetBool("sim/operation/override/override_fms_advance");} }

        /// <summary>
        ///  overrides fuel flow variable sim/Flightmodel/Engine/ENGN_FF_
        /// </summary>
        public IXPDataRef<bool> Override_fuel_flow { get { return m_data.GetBool("sim/operation/override/override_fuel_flow");} }

        /// <summary>
        ///  overrides engine temp vars sim/Flightmodel/Engine/ENGN_EGT_c and ENGN_ITT_c
        /// </summary>
        public IXPDataRef<bool> Override_itt_egt { get { return m_data.GetBool("sim/operation/override/override_itt_egt");} }

        /// <summary>
        ///  overrides individual control surfaces, e.g. sim/Flightmodel/Controls/Lail1def
        /// </summary>
        public IXPDataRef<bool> Override_control_surfaces { get { return m_data.GetBool("sim/operation/override/override_control_surfaces");} }

        /// <summary>
        ///  overrides all engine calculations - write to LMN and g_nrml/Side/Axil.
        /// </summary>
        public IXPDataRef<bool> Override_engines { get { return m_data.GetBool("sim/operation/override/override_engines");} }

        /// <summary>
        ///  overrides all force calculations - write to LMN and g_nrml/Side/Axil.
        /// </summary>
        public IXPDataRef<bool> Override_forces { get { return m_data.GetBool("sim/operation/override/override_forces");} }

        /// <summary>
        ///  overrides speed, heading, and rocking of boats. index 0=carrier, 1=frigate
        /// </summary>
        public IXPDataRef<bool[]> Override_boats { get { return m_data.GetBoolArray("sim/operation/override/override_boats");} }

        /// <summary>
        ///  overrides building and drawing of clouds as well as white-out-in-cloud effects
        /// </summary>
        public IXPDataRef<bool> Override_clouds { get { return m_data.GetBool("sim/operation/override/override_clouds");} }

        /// <summary>
        ///  overrides the steering of individual gear from tiller/Rudder.
        /// </summary>
        public IXPDataRef<bool> Override_wheel_steer { get { return m_data.GetBool("sim/operation/override/override_wheel_steer");} }

        /// <summary>
        ///  overrides when the airport lites go on and off.
        /// </summary>
        public IXPDataRef<bool> Override_airport_lites { get { return m_data.GetBool("sim/operation/override/override_airport_lites");} }

        /// <summary>
        ///  this override turns off transfer and dump and lets the plugin decide if the engine gets fuel
        /// </summary>
        public IXPDataRef<bool> Override_fuel_system { get { return m_data.GetBool("sim/operation/override/override_fuel_system");} }

        /// <summary>
        ///  this override lets third party add-ons write to the TCAS source data array
        /// </summary>
        public IXPDataRef<bool> Override_TCAS { get { return m_data.GetBool("sim/operation/override/override_tcas");} }

        /// <summary>
        ///  this override gives plguins control of sim/Flightmodel2/Controls/Left_brake_ratio and right_brake_ratio
        /// </summary>
        public IXPDataRef<bool> Override_toe_brakes { get { return m_data.GetBool("sim/operation/override/override_toe_brakes");} }
    }
}