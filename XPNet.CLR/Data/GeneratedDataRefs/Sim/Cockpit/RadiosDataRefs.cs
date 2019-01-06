using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_radiosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_radiosDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (true: legacy)
        /// </summary>
        public IXPDataRef<float> nav1_obs_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav1_obs_degt");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (true: legacy)
        /// </summary>
        public IXPDataRef<float> nav2_obs_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav2_obs_degt");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (mag: modern) pilot
        /// </summary>
        public IXPDataRef<float> nav1_obs_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav1_obs_degm");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (mag: modern) copilot
        /// </summary>
        public IXPDataRef<float> nav1_obs_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_obs_degm2");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (mag: modern) pilot
        /// </summary>
        public IXPDataRef<float> nav2_obs_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav2_obs_degm");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (mag: modern) copilot
        /// </summary>
        public IXPDataRef<float> nav2_obs_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_obs_degm2");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by nav1.  Set override with override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by nav2.  Set override with override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by adf1.  Use override_adf to stg.
        /// </summary>
        public IXPDataRef<float> adf1_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by adf2.  Use override_adf to stg.
        /// </summary>
        public IXPDataRef<float> adf2_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the GPS 1 destination.
        /// </summary>
        public IXPDataRef<float> gps_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the GPS 2 destination.
        /// </summary>
        public IXPDataRef<float> gps2_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dir_degt");} }

        /// <summary>
        ///  The relative bearing to whatever becaon the standalone DME is programmed for.
        /// </summary>
        public IXPDataRef<float> dme_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/dme_dir_degt");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav1_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav2_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_gps
        /// </summary>
        public IXPDataRef<float> gps_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_gps
        /// </summary>
        public IXPDataRef<float> gps_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_gps
        /// </summary>
        public IXPDataRef<float> gps2_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps2_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_gps
        /// </summary>
        public IXPDataRef<float> gps2_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps2_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav1_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_vdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav2_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_vdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot. override_gps
        /// </summary>
        public IXPDataRef<float> gps_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot. override_gps
        /// </summary>
        public IXPDataRef<float> gps_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps_vdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot. override_gps
        /// </summary>
        public IXPDataRef<float> gps2_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps2_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot. override_gps
        /// </summary>
        public IXPDataRef<float> gps2_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps2_vdef_dot2");} }

        /// <summary>
        ///  Are we receiving an expected glide slope for nav1
        /// </summary>
        public IXPDataRef<bool> nav1_CDI { get { return m_data.GetBool("sim/cockpit/radios/nav1_cdi");} }

        /// <summary>
        ///  Are we receiving an expected glide slope for nav2
        /// </summary>
        public IXPDataRef<bool> nav2_CDI { get { return m_data.GetBool("sim/cockpit/radios/nav2_cdi");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on nav1.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on nav2.  override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on adf1.  override_dme
        /// </summary>
        public IXPDataRef<float> adf1_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on adf2.  override_dme
        /// </summary>
        public IXPDataRef<float> adf2_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the GPS.  override_gps
        /// </summary>
        public IXPDataRef<float> gps_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/gps_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the GPS.  override_gps
        /// </summary>
        public IXPDataRef<float> gps2_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the standalone DME receiver. override_dme
        /// </summary>
        public IXPDataRef<float> standalone_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/standalone_dme_dist_m");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on nav1. override_dme
        /// </summary>
        public IXPDataRef<float> nav1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on nav2. override_dme
        /// </summary>
        public IXPDataRef<float> nav2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on adf1. override_dme
        /// </summary>
        public IXPDataRef<float> adf1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on adf2. override_dme
        /// </summary>
        public IXPDataRef<float> adf2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the GPS. override_dme
        /// </summary>
        public IXPDataRef<float> gps_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/gps_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the GPS. override_dme
        /// </summary>
        public IXPDataRef<float> gps2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the standalone DME receiver. override_dme
        /// </summary>
        public IXPDataRef<float> standalone_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/standalone_dme_speed_kts");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on nav1. override_dme  (Dataref is labeled - this has always been minutes.)
        /// </summary>
        public IXPDataRef<float> nav1_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on nav2. override_dme  (Dataref is labeled - this has always been minutes.)
        /// </summary>
        public IXPDataRef<float> nav2_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on adf1. override_dme  (Dataref is labeled - this has always been minutes.)
        /// </summary>
        public IXPDataRef<float> adf1_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on adf2. override_dme  (Dataref is labeled - this has always been minutes.)
        /// </summary>
        public IXPDataRef<float> adf2_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on the GPS 1. override_dme  (Dataref is labeled - this has always been minutes.)
        /// </summary>
        public IXPDataRef<float> gps_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/gps_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on the GPS 2. override_dme  (Dataref is labeled - this has always been minutes.)
        /// </summary>
        public IXPDataRef<float> gps2_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on the standalone DME. override_dme  (Dataref is labeled - this has always been minutes.)\
        /// </summary>
        public IXPDataRef<float> standalone_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/standalone_dme_time_secs");} }

        /// <summary>
        ///  The localizer course for Nav1 or tuned in radial for a VOR. (Magnetic, new) - pilot use override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_course_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav1_course_degm");} }

        /// <summary>
        ///  The localizer course for Nav1 or tuned in radial for a VOR. (Magnetic, new) - copilot use override_navneedles
        /// </summary>
        public IXPDataRef<float> nav1_course_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_course_degm2");} }

        /// <summary>
        ///  The localizer course for Nav2 or tuned in radial for a VOR. (Magnetic, new) - pilot use override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_course_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav2_course_degm");} }

        /// <summary>
        ///  The localizer course for Nav2 or tuned in radial for a VOR. (Magnetic, new) - copilot use override_navneedles
        /// </summary>
        public IXPDataRef<float> nav2_course_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_course_degm2");} }

        /// <summary>
        ///  The localizer course for GPS 1 or tuned in radial for a VOR (Magnetic, new) - pilot - use override_gps
        /// </summary>
        public IXPDataRef<float> gps_course_degtm { get { return m_data.GetFloat("sim/cockpit/radios/gps_course_degtm");} }

        /// <summary>
        ///  The localizer course for GPS 1 or tuned in radial for a VOR (Magnetic, new) - copilot - use override_gps
        /// </summary>
        public IXPDataRef<float> gps_course_degtm2 { get { return m_data.GetFloat("sim/cockpit/radios/gps_course_degtm2");} }

        /// <summary>
        ///  The localizer course for GPS 2 or tuned in radial for a VOR (Magnetic, new) - pilot - use override_gps
        /// </summary>
        public IXPDataRef<float> gps2_course_degtm { get { return m_data.GetFloat("sim/cockpit/radios/gps2_course_degtm");} }

        /// <summary>
        ///  The localizer course for GPS 2 or tuned in radial for a VOR (Magnetic, new) - copilot - use override_gps
        /// </summary>
        public IXPDataRef<float> gps2_course_degtm2 { get { return m_data.GetFloat("sim/cockpit/radios/gps2_course_degtm2");} }

        /// <summary>
        ///  The glide slope slope for nav1.  Writable with override_navneedles starting in 940.
        /// </summary>
        public IXPDataRef<float> nav1_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav1_slope_degt");} }

        /// <summary>
        ///  The glide slope slope for nav2.  Writable with override_navneedles starting in 940.
        /// </summary>
        public IXPDataRef<float> nav2_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav2_slope_degt");} }

        /// <summary>
        ///  The glide slope slope for the GPS 1.  Writable with override_gps.
        /// </summary>
        public IXPDataRef<float> gps_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps_slope_degt");} }

        /// <summary>
        ///  The glide slope slope for the GPS 1.  Writable with override_gps.
        /// </summary>
        public IXPDataRef<float> gps2_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps2_slope_degt");} }

        /// <summary>
        ///  Whether we are squawking ident right now.
        /// </summary>
        public IXPDataRef<bool> transponder_id { get { return m_data.GetBool("sim/cockpit/radios/transponder_id");} }

        /// <summary>
        ///  Transponder light brightness ratio from 0 to 1
        /// </summary>
        public IXPDataRef<float> transponder_brightness { get { return m_data.GetFloat("sim/cockpit/radios/transponder_brightness");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 1 - pilot.
        /// </summary>
        public IXPDataRef<float> nav1_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/nav1_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 1 - copilot.
        /// </summary>
        public IXPDataRef<float> nav1_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_cardinal_dir2");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 2 - pilot.
        /// </summary>
        public IXPDataRef<float> nav2_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/nav2_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 2 - copilot.
        /// </summary>
        public IXPDataRef<float> nav2_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_cardinal_dir2");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 1 - pilot.
        /// </summary>
        public IXPDataRef<float> adf1_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/adf1_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 1 - copilot.
        /// </summary>
        public IXPDataRef<float> adf1_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/adf1_cardinal_dir2");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 2 - pilot.
        /// </summary>
        public IXPDataRef<float> adf2_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/adf2_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 2 - copilot.
        /// </summary>
        public IXPDataRef<float> adf2_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/adf2_cardinal_dir2");} }

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> nav1_has_dme { get { return m_data.GetBool("sim/cockpit/radios/nav1_has_dme");} }

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> nav2_has_dme { get { return m_data.GetBool("sim/cockpit/radios/nav2_has_dme");} }

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> adf1_has_dme { get { return m_data.GetBool("sim/cockpit/radios/adf1_has_dme");} }

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> adf2_has_dme { get { return m_data.GetBool("sim/cockpit/radios/adf2_has_dme");} }

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> dme5_has_dme { get { return m_data.GetBool("sim/cockpit/radios/dme5_has_dme");} }
    }
}