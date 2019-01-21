using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_autopilotDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_autopilotDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Autopilot source system, pilots (0) or copilots (1).. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/autopilot_source
        /// </summary>
        public IXPDataRef<int> autopilot_source { get { return m_data.GetInt("sim/cockpit2/autopilot/autopilot_source");} }

        /// <summary>
        ///  Auto-throttle on, 0 or 1.  This is the switch.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/autothrottle_enabled
        /// </summary>
        public IXPDataRef<bool> autothrottle_enabled { get { return m_data.GetBool("sim/cockpit2/autopilot/autothrottle_enabled");} }

        /// <summary>
        ///  Auto-throttle really working?  Takes into account failures, esys, etc.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/autothrottle_on
        /// </summary>
        public IXPDataRef<bool> autothrottle_on { get { return m_data.GetBool("sim/cockpit2/autopilot/autothrottle_on");} }

        /// <summary>
        ///  Autopilot heading mode.. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/heading_mode
        /// </summary>
        public IXPDataRef<int> heading_mode { get { return m_data.GetInt("sim/cockpit2/autopilot/heading_mode");} }

        /// <summary>
        ///  Autopilot altitude mode.. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/altitude_mode
        /// </summary>
        public IXPDataRef<int> altitude_mode { get { return m_data.GetInt("sim/cockpit2/autopilot/altitude_mode");} }

        /// <summary>
        ///  Maximum bank angle mode, 0->6. Higher number is steeper allowable bank.. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/bank_angle_mode
        /// </summary>
        public IXPDataRef<int> bank_angle_mode { get { return m_data.GetInt("sim/cockpit2/autopilot/bank_angle_mode");} }

        /// <summary>
        ///  Flight director mode, 0 is off, 1 is on, 2 is on with autopilot servos.  Good for the FD swich.. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/flight_director_mode
        /// </summary>
        public IXPDataRef<int> flight_director_mode { get { return m_data.GetInt("sim/cockpit2/autopilot/flight_director_mode");} }

        /// <summary>
        ///  Is the autopilot really on? Takes into account electrical system, failures, etc.;. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/autopilot_on
        /// </summary>
        public IXPDataRef<bool> autopilot_on { get { return m_data.GetBool("sim/cockpit2/autopilot/autopilot_on");} }

        /// <summary>
        ///  Are the servos on?  Takes into account FD mode and control-wheel-steering, failures, etc.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/servos_on
        /// </summary>
        public IXPDataRef<bool> servos_on { get { return m_data.GetBool("sim/cockpit2/autopilot/servos_on");} }

        /// <summary>
        ///  Autopilot airspeed is Mach number rather than knots.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/airspeed_is_mach
        /// </summary>
        public IXPDataRef<bool> airspeed_is_mach { get { return m_data.GetBool("sim/cockpit2/autopilot/airspeed_is_mach");} }

        /// <summary>
        ///  Is the combined alt/vvi selector showing VVI?. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/alt_vvi_is_showing_vvi
        /// </summary>
        public IXPDataRef<bool> alt_vvi_is_showing_vvi { get { return m_data.GetBool("sim/cockpit2/autopilot/alt_vvi_is_showing_vvi");} }

        /// <summary>
        ///  Vnav is armed, 0 or 1 - this is different from the "FMS" button - it is used ONLY for a physical G1000 connected by ethernet.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/vnav_armed
        /// </summary>
        public IXPDataRef<bool> vnav_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/vnav_armed");} }

        /// <summary>
        ///  Altitude is armed, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/altitude_hold_armed
        /// </summary>
        public IXPDataRef<bool> altitude_hold_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/altitude_hold_armed");} }

        /// <summary>
        ///  Localizer is armed, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/hnav_armed
        /// </summary>
        public IXPDataRef<bool> hnav_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/hnav_armed");} }

        /// <summary>
        ///  Glideslope is armed, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/glideslope_armed
        /// </summary>
        public IXPDataRef<bool> glideslope_armed { get { return m_data.GetBool("sim/cockpit2/autopilot/glideslope_armed");} }

        /// <summary>
        ///  Back course is armed, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/backcourse_on
        /// </summary>
        public IXPDataRef<bool> backcourse_on { get { return m_data.GetBool("sim/cockpit2/autopilot/backcourse_on");} }

        /// <summary>
        ///  Airspeed hold value, knots or Mach depending on km_is_mach.. Units:knots/mach
        ///  Raw path: sim/cockpit2/autopilot/airspeed_dial_kts_mach
        /// </summary>
        public IXPDataRef<float> airspeed_dial_kts_mach { get { return m_data.GetFloat("sim/cockpit2/autopilot/airspeed_dial_kts_mach");} }

        /// <summary>
        ///  Airspeed hold bug, always in knots, even if the AP is in mach-hold mode.. Units:Knots
        ///  Raw path: sim/cockpit2/autopilot/airspeed_dial_kts
        /// </summary>
        public IXPDataRef<float> airspeed_dial_kts { get { return m_data.GetFloat("sim/cockpit2/autopilot/airspeed_dial_kts");} }

        /// <summary>
        ///  Heading hold commanded, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/autopilot/heading_dial_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> heading_dial_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/autopilot/heading_dial_deg_mag_pilot");} }

        /// <summary>
        ///  Heading hold commanded, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/autopilot/heading_dial_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> heading_dial_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/autopilot/heading_dial_deg_mag_copilot");} }

        /// <summary>
        ///  VVI commanded in FPM.. Units:feet/minute
        ///  Raw path: sim/cockpit2/autopilot/vvi_dial_fpm
        /// </summary>
        public IXPDataRef<float> vvi_dial_fpm { get { return m_data.GetFloat("sim/cockpit2/autopilot/vvi_dial_fpm");} }

        /// <summary>
        ///  VVI commanded in FPM.. Units:feet
        ///  Raw path: sim/cockpit2/autopilot/altitude_dial_ft
        /// </summary>
        public IXPDataRef<float> altitude_dial_ft { get { return m_data.GetFloat("sim/cockpit2/autopilot/altitude_dial_ft");} }

        /// <summary>
        ///  Altitude hold commanded in feet indicated.. Units:feet
        ///  Raw path: sim/cockpit2/autopilot/altitude_hold_ft
        /// </summary>
        public IXPDataRef<float> altitude_hold_ft { get { return m_data.GetFloat("sim/cockpit2/autopilot/altitude_hold_ft");} }

        /// <summary>
        ///  Target altitude hold in VNAV mode.. Units:feet
        ///  Raw path: sim/cockpit2/autopilot/altitude_vnav_ft
        /// </summary>
        public IXPDataRef<float> altitude_vnav_ft { get { return m_data.GetFloat("sim/cockpit2/autopilot/altitude_vnav_ft");} }

        /// <summary>
        ///  Pitch-hold commanded in degrees up.. Units:degrees
        ///  Raw path: sim/cockpit2/autopilot/sync_hold_pitch_deg
        /// </summary>
        public IXPDataRef<float> sync_hold_pitch_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/sync_hold_pitch_deg");} }

        /// <summary>
        ///  Roll-hold commanded in degrees right.. Units:degrees
        ///  Raw path: sim/cockpit2/autopilot/sync_hold_roll_deg
        /// </summary>
        public IXPDataRef<float> sync_hold_roll_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/sync_hold_roll_deg");} }

        /// <summary>
        ///  Flight director pitch deflection in degrees, pos up.. Units:degrees
        ///  Raw path: sim/cockpit2/autopilot/flight_director_pitch_deg
        /// </summary>
        public IXPDataRef<float> flight_director_pitch_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/flight_director_pitch_deg");} }

        /// <summary>
        ///  Flight director roll deflection in degrees, pos right.. Units:degrees
        ///  Raw path: sim/cockpit2/autopilot/flight_director_roll_deg
        /// </summary>
        public IXPDataRef<float> flight_director_roll_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/flight_director_roll_deg");} }

        /// <summary>
        ///  Nose-up pitch to hold when TOGA operations are in effect.  Set this back when your aircraft unloads!. Units:degrees
        ///  Raw path: sim/cockpit2/autopilot/TOGA_pitch_deg
        /// </summary>
        public IXPDataRef<float> TOGA_pitch_deg { get { return m_data.GetFloat("sim/cockpit2/autopilot/toga_pitch_deg");} }

        /// <summary>
        ///  Autopilot Roll-Hold Status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/roll_status
        /// </summary>
        public IXPDataRef<int> roll_status { get { return m_data.GetInt("sim/cockpit2/autopilot/roll_status");} }

        /// <summary>
        ///  Autopilot Heading Status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/heading_status
        /// </summary>
        public IXPDataRef<int> heading_status { get { return m_data.GetInt("sim/cockpit2/autopilot/heading_status");} }

        /// <summary>
        ///  Autopilot Nav Status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/nav_status
        /// </summary>
        public IXPDataRef<int> nav_status { get { return m_data.GetInt("sim/cockpit2/autopilot/nav_status");} }

        /// <summary>
        ///  Autopilot Back-course Status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/backcourse_status
        /// </summary>
        public IXPDataRef<int> backcourse_status { get { return m_data.GetInt("sim/cockpit2/autopilot/backcourse_status");} }

        /// <summary>
        ///  Autopilot Lateral TOGA mode: 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/TOGA_lateral_status
        /// </summary>
        public IXPDataRef<int> TOGA_lateral_status { get { return m_data.GetInt("sim/cockpit2/autopilot/toga_lateral_status");} }

        /// <summary>
        ///  Autopilot Pitch-Hold Status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/pitch_status
        /// </summary>
        public IXPDataRef<int> pitch_status { get { return m_data.GetInt("sim/cockpit2/autopilot/pitch_status");} }

        /// <summary>
        ///  Autopilot VVI Status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/vvi_status
        /// </summary>
        public IXPDataRef<int> vvi_status { get { return m_data.GetInt("sim/cockpit2/autopilot/vvi_status");} }

        /// <summary>
        ///  Autopilot Speed-hold (via pitch) status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/speed_status
        /// </summary>
        public IXPDataRef<int> speed_status { get { return m_data.GetInt("sim/cockpit2/autopilot/speed_status");} }

        /// <summary>
        ///  Autopilot Altitude hold status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/altitude_hold_status
        /// </summary>
        public IXPDataRef<int> altitude_hold_status { get { return m_data.GetInt("sim/cockpit2/autopilot/altitude_hold_status");} }

        /// <summary>
        ///  Autopilot glideslope status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/glideslope_status
        /// </summary>
        public IXPDataRef<int> glideslope_status { get { return m_data.GetInt("sim/cockpit2/autopilot/glideslope_status");} }

        /// <summary>
        ///  Autopilot VNAV status. 0=off,1=armed,2=captured - for a physical hardware g1000 connected by Ethernet only!!!. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/vnav_status
        /// </summary>
        public IXPDataRef<int> vnav_status { get { return m_data.GetInt("sim/cockpit2/autopilot/vnav_status");} }

        /// <summary>
        ///  Enables the FMS to take over vertical control of the autopilot.   This matches the command "sim/autopilot/FMS".". Units:boolean
        ///  Raw path: sim/cockpit2/autopilot/fms_vnav
        /// </summary>
        public IXPDataRef<bool> fms_vnav { get { return m_data.GetBool("sim/cockpit2/autopilot/fms_vnav");} }

        /// <summary>
        ///  Autopilot TOGA vertical (go-around) status. 0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/TOGA_status
        /// </summary>
        public IXPDataRef<int> TOGA_status { get { return m_data.GetInt("sim/cockpit2/autopilot/toga_status");} }

        /// <summary>
        ///  Autopilot approach status.  0=off,1=armed,2=captured. Units:enum
        ///  Raw path: sim/cockpit2/autopilot/approach_status
        /// </summary>
        public IXPDataRef<int> approach_status { get { return m_data.GetInt("sim/cockpit2/autopilot/approach_status");} }
    }
}