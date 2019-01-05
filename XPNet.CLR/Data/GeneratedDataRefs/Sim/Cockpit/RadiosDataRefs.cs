using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_RadiosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_RadiosDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (true: legacy). Units:degt
        /// </summary>
        public IXPDataRef<float> Nav1_obs_degt => m_data.GetFloat("sim/cockpit/radios/nav1_obs_degt");

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (true: legacy). Units:degt
        /// </summary>
        public IXPDataRef<float> Nav2_obs_degt => m_data.GetFloat("sim/cockpit/radios/nav2_obs_degt");

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (mag: modern) pilot. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav1_obs_degm => m_data.GetFloat("sim/cockpit/radios/nav1_obs_degm");

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (mag: modern) copilot. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav1_obs_degm2 => m_data.GetFloat("sim/cockpit/radios/nav1_obs_degm2");

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (mag: modern) pilot. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav2_obs_degm => m_data.GetFloat("sim/cockpit/radios/nav2_obs_degm");

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (mag: modern) copilot. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav2_obs_degm2 => m_data.GetFloat("sim/cockpit/radios/nav2_obs_degm2");

        /// <summary>
        ///  The relative bearing to the beacon indicated by nav1.  Set override with override_navneedles. Units:deg
        /// </summary>
        public IXPDataRef<float> Nav1_dir_degt => m_data.GetFloat("sim/cockpit/radios/nav1_dir_degt");

        /// <summary>
        ///  The relative bearing to the beacon indicated by nav2.  Set override with override_navneedles. Units:deg
        /// </summary>
        public IXPDataRef<float> Nav2_dir_degt => m_data.GetFloat("sim/cockpit/radios/nav2_dir_degt");

        /// <summary>
        ///  The relative bearing to the beacon indicated by adf1.  Use override_adf to stg.. Units:deg
        /// </summary>
        public IXPDataRef<float> Adf1_dir_degt => m_data.GetFloat("sim/cockpit/radios/adf1_dir_degt");

        /// <summary>
        ///  The relative bearing to the beacon indicated by adf2.  Use override_adf to stg.. Units:deg
        /// </summary>
        public IXPDataRef<float> Adf2_dir_degt => m_data.GetFloat("sim/cockpit/radios/adf2_dir_degt");

        /// <summary>
        ///  The relative bearing to the GPS 1 destination.. Units:deg
        /// </summary>
        public IXPDataRef<float> Gps_dir_degt => m_data.GetFloat("sim/cockpit/radios/gps_dir_degt");

        /// <summary>
        ///  The relative bearing to the GPS 2 destination.. Units:deg
        /// </summary>
        public IXPDataRef<float> Gps2_dir_degt => m_data.GetFloat("sim/cockpit/radios/gps2_dir_degt");

        /// <summary>
        ///  The relative bearing to whatever becaon the standalone DME is programmed for.. Units:deg
        /// </summary>
        public IXPDataRef<float> Dme_dir_degt => m_data.GetFloat("sim/cockpit/radios/dme_dir_degt");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav1_hdef_dot => m_data.GetFloat("sim/cockpit/radios/nav1_hdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav1_hdef_dot2 => m_data.GetFloat("sim/cockpit/radios/nav1_hdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav2_hdef_dot => m_data.GetFloat("sim/cockpit/radios/nav2_hdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav2_hdef_dot2 => m_data.GetFloat("sim/cockpit/radios/nav2_hdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps_hdef_dot => m_data.GetFloat("sim/cockpit/radios/gps_hdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps_hdef_dot2 => m_data.GetFloat("sim/cockpit/radios/gps_hdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps2_hdef_dot => m_data.GetFloat("sim/cockpit/radios/gps2_hdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps2_hdef_dot2 => m_data.GetFloat("sim/cockpit/radios/gps2_hdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav1_vdef_dot => m_data.GetFloat("sim/cockpit/radios/nav1_vdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav1_vdef_dot2 => m_data.GetFloat("sim/cockpit/radios/nav1_vdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav2_vdef_dot => m_data.GetFloat("sim/cockpit/radios/nav2_vdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot.  override_navneedles. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Nav2_vdef_dot2 => m_data.GetFloat("sim/cockpit/radios/nav2_vdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot. override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps_vdef_dot => m_data.GetFloat("sim/cockpit/radios/gps_vdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot. override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps_vdef_dot2 => m_data.GetFloat("sim/cockpit/radios/gps_vdef_dot2");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot. override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps2_vdef_dot => m_data.GetFloat("sim/cockpit/radios/gps2_vdef_dot");

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot. override_gps. Units:prcnt
        /// </summary>
        public IXPDataRef<float> Gps2_vdef_dot2 => m_data.GetFloat("sim/cockpit/radios/gps2_vdef_dot2");

        /// <summary>
        ///  Are we receiving an expected glide slope for nav1
        /// </summary>
        public IXPDataRef<bool> Nav1_CDI => m_data.GetBool("sim/cockpit/radios/nav1_cdi");

        /// <summary>
        ///  Are we receiving an expected glide slope for nav2
        /// </summary>
        public IXPDataRef<bool> Nav2_CDI => m_data.GetBool("sim/cockpit/radios/nav2_cdi");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on nav1.  override_navneedles. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Nav1_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/nav1_dme_dist_m");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on nav2.  override_navneedles. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Nav2_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/nav2_dme_dist_m");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on adf1.  override_dme. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Adf1_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/adf1_dme_dist_m");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on adf2.  override_dme. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Adf2_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/adf2_dme_dist_m");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the GPS.  override_gps. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Gps_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/gps_dme_dist_m");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the GPS.  override_gps. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Gps2_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/gps2_dme_dist_m");

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the standalone DME receiver. override_dme. Units:nautical_miles
        /// </summary>
        public IXPDataRef<float> Standalone_dme_dist_m => m_data.GetFloat("sim/cockpit/radios/standalone_dme_dist_m");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on nav1. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Nav1_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/nav1_dme_speed_kts");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on nav2. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Nav2_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/nav2_dme_speed_kts");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on adf1. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Adf1_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/adf1_dme_speed_kts");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on adf2. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Adf2_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/adf2_dme_speed_kts");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the GPS. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Gps_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/gps_dme_speed_kts");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the GPS. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Gps2_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/gps2_dme_speed_kts");

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the standalone DME receiver. override_dme. Units:knots
        /// </summary>
        public IXPDataRef<float> Standalone_dme_speed_kts => m_data.GetFloat("sim/cockpit/radios/standalone_dme_speed_kts");

        /// <summary>
        ///  Our time to reach the beacon tuned in on nav1. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        /// </summary>
        public IXPDataRef<float> Nav1_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/nav1_dme_time_secs");

        /// <summary>
        ///  Our time to reach the beacon tuned in on nav2. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        /// </summary>
        public IXPDataRef<float> Nav2_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/nav2_dme_time_secs");

        /// <summary>
        ///  Our time to reach the beacon tuned in on adf1. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        /// </summary>
        public IXPDataRef<float> Adf1_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/adf1_dme_time_secs");

        /// <summary>
        ///  Our time to reach the beacon tuned in on adf2. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        /// </summary>
        public IXPDataRef<float> Adf2_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/adf2_dme_time_secs");

        /// <summary>
        ///  Our time to reach the beacon tuned in on the GPS 1. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        /// </summary>
        public IXPDataRef<float> Gps_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/gps_dme_time_secs");

        /// <summary>
        ///  Our time to reach the beacon tuned in on the GPS 2. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        /// </summary>
        public IXPDataRef<float> Gps2_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/gps2_dme_time_secs");

        /// <summary>
        ///  Our time to reach the beacon tuned in on the standalone DME. override_dme  (Dataref is labeled - this has always been minutes.)\. Units:mins
        /// </summary>
        public IXPDataRef<float> Standalone_dme_time_secs => m_data.GetFloat("sim/cockpit/radios/standalone_dme_time_secs");

        /// <summary>
        ///  The localizer course for Nav1 or tuned in radial for a VOR. (Magnetic, new) - pilot use override_navneedles. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav1_course_degm => m_data.GetFloat("sim/cockpit/radios/nav1_course_degm");

        /// <summary>
        ///  The localizer course for Nav1 or tuned in radial for a VOR. (Magnetic, new) - copilot use override_navneedles. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav1_course_degm2 => m_data.GetFloat("sim/cockpit/radios/nav1_course_degm2");

        /// <summary>
        ///  The localizer course for Nav2 or tuned in radial for a VOR. (Magnetic, new) - pilot use override_navneedles. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav2_course_degm => m_data.GetFloat("sim/cockpit/radios/nav2_course_degm");

        /// <summary>
        ///  The localizer course for Nav2 or tuned in radial for a VOR. (Magnetic, new) - copilot use override_navneedles. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav2_course_degm2 => m_data.GetFloat("sim/cockpit/radios/nav2_course_degm2");

        /// <summary>
        ///  The localizer course for GPS 1 or tuned in radial for a VOR (Magnetic, new) - pilot - use override_gps. Units:degm
        /// </summary>
        public IXPDataRef<float> Gps_course_degtm => m_data.GetFloat("sim/cockpit/radios/gps_course_degtm");

        /// <summary>
        ///  The localizer course for GPS 1 or tuned in radial for a VOR (Magnetic, new) - copilot - use override_gps. Units:degm
        /// </summary>
        public IXPDataRef<float> Gps_course_degtm2 => m_data.GetFloat("sim/cockpit/radios/gps_course_degtm2");

        /// <summary>
        ///  The localizer course for GPS 2 or tuned in radial for a VOR (Magnetic, new) - pilot - use override_gps. Units:degm
        /// </summary>
        public IXPDataRef<float> Gps2_course_degtm => m_data.GetFloat("sim/cockpit/radios/gps2_course_degtm");

        /// <summary>
        ///  The localizer course for GPS 2 or tuned in radial for a VOR (Magnetic, new) - copilot - use override_gps. Units:degm
        /// </summary>
        public IXPDataRef<float> Gps2_course_degtm2 => m_data.GetFloat("sim/cockpit/radios/gps2_course_degtm2");

        /// <summary>
        ///  The glide slope slope for nav1.  Writable with override_navneedles starting in 940.. Units:deg
        /// </summary>
        public IXPDataRef<float> Nav1_slope_degt => m_data.GetFloat("sim/cockpit/radios/nav1_slope_degt");

        /// <summary>
        ///  The glide slope slope for nav2.  Writable with override_navneedles starting in 940.. Units:deg
        /// </summary>
        public IXPDataRef<float> Nav2_slope_degt => m_data.GetFloat("sim/cockpit/radios/nav2_slope_degt");

        /// <summary>
        ///  The glide slope slope for the GPS 1.  Writable with override_gps.. Units:deg
        /// </summary>
        public IXPDataRef<float> Gps_slope_degt => m_data.GetFloat("sim/cockpit/radios/gps_slope_degt");

        /// <summary>
        ///  The glide slope slope for the GPS 1.  Writable with override_gps.. Units:deg
        /// </summary>
        public IXPDataRef<float> Gps2_slope_degt => m_data.GetFloat("sim/cockpit/radios/gps2_slope_degt");

        /// <summary>
        ///  Whether we are squawking ident right now.
        /// </summary>
        public IXPDataRef<bool> Transponder_id => m_data.GetBool("sim/cockpit/radios/transponder_id");

        /// <summary>
        ///  Transponder light brightness ratio from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Transponder_brightness => m_data.GetFloat("sim/cockpit/radios/transponder_brightness");

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 1 - pilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav1_cardinal_dir => m_data.GetFloat("sim/cockpit/radios/nav1_cardinal_dir");

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 1 - copilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav1_cardinal_dir2 => m_data.GetFloat("sim/cockpit/radios/nav1_cardinal_dir2");

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 2 - pilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav2_cardinal_dir => m_data.GetFloat("sim/cockpit/radios/nav2_cardinal_dir");

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 2 - copilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Nav2_cardinal_dir2 => m_data.GetFloat("sim/cockpit/radios/nav2_cardinal_dir2");

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 1 - pilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Adf1_cardinal_dir => m_data.GetFloat("sim/cockpit/radios/adf1_cardinal_dir");

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 1 - copilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Adf1_cardinal_dir2 => m_data.GetFloat("sim/cockpit/radios/adf1_cardinal_dir2");

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 2 - pilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Adf2_cardinal_dir => m_data.GetFloat("sim/cockpit/radios/adf2_cardinal_dir");

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 2 - copilot.. Units:degm
        /// </summary>
        public IXPDataRef<float> Adf2_cardinal_dir2 => m_data.GetFloat("sim/cockpit/radios/adf2_cardinal_dir2");

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Nav1_has_dme => m_data.GetBool("sim/cockpit/radios/nav1_has_dme");

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Nav2_has_dme => m_data.GetBool("sim/cockpit/radios/nav2_has_dme");

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Adf1_has_dme => m_data.GetBool("sim/cockpit/radios/adf1_has_dme");

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Adf2_has_dme => m_data.GetBool("sim/cockpit/radios/adf2_has_dme");

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Dme5_has_dme => m_data.GetBool("sim/cockpit/radios/dme5_has_dme");
    }
}