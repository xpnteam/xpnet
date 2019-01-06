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
        ///  Override control of the joystick deflections (overrides stick, yoke, pedals, keys, mouse, and auto-coordination). Units:boolean
        ///  Raw path: sim/operation/override/override_joystick
        /// </summary>
        public IXPDataRef<bool> override_joystick { get { return m_data.GetBool("sim/operation/override/override_joystick");} }

        /// <summary>
        ///  Override control of the artificial stability system. Units:boolean
        ///  Raw path: sim/operation/override/override_artstab
        /// </summary>
        public IXPDataRef<bool> override_artstab { get { return m_data.GetBool("sim/operation/override/override_artstab");} }

        /// <summary>
        ///  Override all parts of the flight system at once. Units:boolean
        ///  Raw path: sim/operation/override/override_flightcontrol
        /// </summary>
        public IXPDataRef<bool> override_flightcontrol { get { return m_data.GetBool("sim/operation/override/override_flightcontrol");} }

        /// <summary>
        ///  Override gear and brake status. Units:boolean
        ///  Raw path: sim/operation/override/override_gearbrake
        /// </summary>
        public IXPDataRef<bool> override_gearbrake { get { return m_data.GetBool("sim/operation/override/override_gearbrake");} }

        /// <summary>
        ///  Override position updates of this plane. Units:boolean
        ///  Raw path: sim/operation/override/override_planepath
        /// </summary>
        public IXPDataRef<bool[]> override_planepath { get { return m_data.GetBoolArray("sim/operation/override/override_planepath");} }

        /// <summary>
        ///  Override the AI's control of the plane via the autopilot. Units:boolean
        ///  Raw path: sim/operation/override/override_plane_ai_autopilot
        /// </summary>
        public IXPDataRef<bool[]> override_plane_ai_autopilot { get { return m_data.GetBoolArray("sim/operation/override/override_plane_ai_autopilot");} }

        /// <summary>
        ///  Override navcom radios. Units:boolean
        ///  Raw path: sim/operation/override/override_navneedles
        /// </summary>
        public IXPDataRef<bool> override_navneedles { get { return m_data.GetBool("sim/operation/override/override_navneedles");} }

        /// <summary>
        ///  Override nav1 receiver. Units:boolean
        ///  Raw path: sim/operation/override/override_nav1_needles
        /// </summary>
        public IXPDataRef<bool> override_nav1_needles { get { return m_data.GetBool("sim/operation/override/override_nav1_needles");} }

        /// <summary>
        ///  Override nav2 receiver. Units:boolean
        ///  Raw path: sim/operation/override/override_nav2_needles
        /// </summary>
        public IXPDataRef<bool> override_nav2_needles { get { return m_data.GetBool("sim/operation/override/override_nav2_needles");} }

        /// <summary>
        ///  Override ADF radios. Units:boolean
        ///  Raw path: sim/operation/override/override_adf
        /// </summary>
        public IXPDataRef<bool> override_adf { get { return m_data.GetBool("sim/operation/override/override_adf");} }

        /// <summary>
        ///  Override DME distances. Units:boolean
        ///  Raw path: sim/operation/override/override_dme
        /// </summary>
        public IXPDataRef<bool> override_dme { get { return m_data.GetBool("sim/operation/override/override_dme");} }

        /// <summary>
        ///  Override GPS computer. Units:boolean
        ///  Raw path: sim/operation/override/override_gps
        /// </summary>
        public IXPDataRef<bool> override_gps { get { return m_data.GetBool("sim/operation/override/override_gps");} }

        /// <summary>
        ///  Override raw heading flown by nav (for GPS that fly by roll commands). Units:boolean
        ///  Raw path: sim/operation/override/override_nav_heading
        /// </summary>
        public IXPDataRef<bool> override_nav_heading { get { return m_data.GetBool("sim/operation/override/override_nav_heading");} }

        /// <summary>
        ///  Override flight director needles (both axes). Units:boolean
        ///  Raw path: sim/operation/override/override_flightdir
        /// </summary>
        public IXPDataRef<bool> override_flightdir { get { return m_data.GetBool("sim/operation/override/override_flightdir");} }

        /// <summary>
        ///  Override flight director needles (pitch only). Units:boolean
        ///  Raw path: sim/operation/override/override_flightdir_ptch
        /// </summary>
        public IXPDataRef<bool> override_flightdir_ptch { get { return m_data.GetBool("sim/operation/override/override_flightdir_ptch");} }

        /// <summary>
        ///  Override flight director needles (roll only). Units:boolean
        ///  Raw path: sim/operation/override/override_flightdir_roll
        /// </summary>
        public IXPDataRef<bool> override_flightdir_roll { get { return m_data.GetBool("sim/operation/override/override_flightdir_roll");} }

        /// <summary>
        ///  Override camera control.  NOTE: DO NOT USE, USE XPLMCAMERA!!. Units:boolean
        ///  Raw path: sim/operation/override/override_camera
        /// </summary>
        public IXPDataRef<bool> override_camera { get { return m_data.GetBool("sim/operation/override/override_camera");} }

        /// <summary>
        ///  Override annunciators. Units:boolean
        ///  Raw path: sim/operation/override/override_annunciators
        /// </summary>
        public IXPDataRef<bool> override_annunciators { get { return m_data.GetBool("sim/operation/override/override_annunciators");} }

        /// <summary>
        ///  Override the autopilot's brains. Units:boolean
        ///  Raw path: sim/operation/override/override_autopilot
        /// </summary>
        public IXPDataRef<bool> override_autopilot { get { return m_data.GetBool("sim/operation/override/override_autopilot");} }

        /// <summary>
        ///  Override just heading (yaw) control (disables auto-coordination). Use yoke_heading_ratio.. Units:boolean
        ///  Raw path: sim/operation/override/override_joystick_heading
        /// </summary>
        public IXPDataRef<bool> override_joystick_heading { get { return m_data.GetBool("sim/operation/override/override_joystick_heading");} }

        /// <summary>
        ///  Override just pitch control. Use yoke_pitch_ratio.. Units:boolean
        ///  Raw path: sim/operation/override/override_joystick_pitch
        /// </summary>
        public IXPDataRef<bool> override_joystick_pitch { get { return m_data.GetBool("sim/operation/override/override_joystick_pitch");} }

        /// <summary>
        ///  Override just roll control. Use yoke_roll_ratio.. Units:boolean
        ///  Raw path: sim/operation/override/override_joystick_roll
        /// </summary>
        public IXPDataRef<bool> override_joystick_roll { get { return m_data.GetBool("sim/operation/override/override_joystick_roll");} }

        /// <summary>
        ///  Override the throttles. Use ENGN_thro_use to control them.. Units:boolean
        ///  Raw path: sim/operation/override/override_throttles
        /// </summary>
        public IXPDataRef<bool> override_throttles { get { return m_data.GetBool("sim/operation/override/override_throttles");} }

        /// <summary>
        ///  Override the prop pitch.  Use POINT_pitch_deg_use to edit.. Units:boolean
        ///  Raw path: sim/operation/override/override_prop_pitch
        /// </summary>
        public IXPDataRef<bool> override_prop_pitch { get { return m_data.GetBool("sim/operation/override/override_prop_pitch");} }

        /// <summary>
        ///  Override the prop mode.  Use ENGN_propmode to edit.. Units:boolean
        ///  Raw path: sim/operation/override/override_prop_mode
        /// </summary>
        public IXPDataRef<bool> override_prop_mode { get { return m_data.GetBool("sim/operation/override/override_prop_mode");} }

        /// <summary>
        ///  Override the mixture controls.  Use ENGN_mixt to edit.. Units:boolean
        ///  Raw path: sim/operation/override/override_mixture
        /// </summary>
        public IXPDataRef<bool> override_mixture { get { return m_data.GetBool("sim/operation/override/override_mixture");} }

        /// <summary>
        ///  Override the FMS going to the next waypoint.. Units:boolean
        ///  Raw path: sim/operation/override/override_fms_advance
        /// </summary>
        public IXPDataRef<bool> override_fms_advance { get { return m_data.GetBool("sim/operation/override/override_fms_advance");} }

        /// <summary>
        ///  overrides fuel flow variable sim/flightmodel/engine/ENGN_FF_. Units:boolean
        ///  Raw path: sim/operation/override/override_fuel_flow
        /// </summary>
        public IXPDataRef<bool> override_fuel_flow { get { return m_data.GetBool("sim/operation/override/override_fuel_flow");} }

        /// <summary>
        ///  overrides engine temp vars sim/flightmodel/engine/ENGN_EGT_c and ENGN_ITT_c. Units:boolean
        ///  Raw path: sim/operation/override/override_itt_egt
        /// </summary>
        public IXPDataRef<bool> override_itt_egt { get { return m_data.GetBool("sim/operation/override/override_itt_egt");} }

        /// <summary>
        ///  overrides individual control surfaces, e.g. sim/flightmodel/controls/lail1def. Units:boolean
        ///  Raw path: sim/operation/override/override_control_surfaces
        /// </summary>
        public IXPDataRef<bool> override_control_surfaces { get { return m_data.GetBool("sim/operation/override/override_control_surfaces");} }

        /// <summary>
        ///  overrides all engine calculations - write to LMN and g_nrml/side/axil.. Units:boolean
        ///  Raw path: sim/operation/override/override_engines
        /// </summary>
        public IXPDataRef<bool> override_engines { get { return m_data.GetBool("sim/operation/override/override_engines");} }

        /// <summary>
        ///  overrides all force calculations - write to LMN and g_nrml/side/axil.. Units:boolean
        ///  Raw path: sim/operation/override/override_forces
        /// </summary>
        public IXPDataRef<bool> override_forces { get { return m_data.GetBool("sim/operation/override/override_forces");} }

        /// <summary>
        ///  overrides speed, heading, and rocking of boats. index 0=carrier, 1=frigate. Units:boolean
        ///  Raw path: sim/operation/override/override_boats
        /// </summary>
        public IXPDataRef<bool[]> override_boats { get { return m_data.GetBoolArray("sim/operation/override/override_boats");} }

        /// <summary>
        ///  overrides building and drawing of clouds as well as white-out-in-cloud effects. Units:boolean
        ///  Raw path: sim/operation/override/override_clouds
        /// </summary>
        public IXPDataRef<bool> override_clouds { get { return m_data.GetBool("sim/operation/override/override_clouds");} }

        /// <summary>
        ///  overrides the steering of individual gear from tiller/rudder.. Units:boolean
        ///  Raw path: sim/operation/override/override_wheel_steer
        /// </summary>
        public IXPDataRef<bool> override_wheel_steer { get { return m_data.GetBool("sim/operation/override/override_wheel_steer");} }

        /// <summary>
        ///  overrides when the airport lites go on and off.. Units:boolean
        ///  Raw path: sim/operation/override/override_airport_lites
        /// </summary>
        public IXPDataRef<bool> override_airport_lites { get { return m_data.GetBool("sim/operation/override/override_airport_lites");} }

        /// <summary>
        ///  this override turns off transfer and dump and lets the plugin decide if the engine gets fuel. Units:boolean
        ///  Raw path: sim/operation/override/override_fuel_system
        /// </summary>
        public IXPDataRef<bool> override_fuel_system { get { return m_data.GetBool("sim/operation/override/override_fuel_system");} }

        /// <summary>
        ///  this override lets third party add-ons write to the TCAS source data array. Units:boolean
        ///  Raw path: sim/operation/override/override_TCAS
        /// </summary>
        public IXPDataRef<bool> override_TCAS { get { return m_data.GetBool("sim/operation/override/override_tcas");} }

        /// <summary>
        ///  this override gives plguins control of sim/flightmodel2/controls/left_brake_ratio and right_brake_ratio. Units:boolean
        ///  Raw path: sim/operation/override/override_toe_brakes
        /// </summary>
        public IXPDataRef<bool> override_toe_brakes { get { return m_data.GetBool("sim/operation/override/override_toe_brakes");} }
    }
}