using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_radiosDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_radiosDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The current frequency of the nav1 radio.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/nav1_freq_hz
        /// </summary>
        public IXPDataRef<int> nav1_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/nav1_freq_hz");} }

        /// <summary>
        ///  The current frequency of the nav2 radio.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/nav2_freq_hz
        /// </summary>
        public IXPDataRef<int> nav2_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/nav2_freq_hz");} }

        /// <summary>
        ///  The current frequency of the copm1 radio.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/com1_freq_hz
        /// </summary>
        public IXPDataRef<int> com1_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/com1_freq_hz");} }

        /// <summary>
        ///  The current frequency of the com2 radio.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/com2_freq_hz
        /// </summary>
        public IXPDataRef<int> com2_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/com2_freq_hz");} }

        /// <summary>
        ///  The current frequency of the first automatic direction finder.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/adf1_freq_hz
        /// </summary>
        public IXPDataRef<int> adf1_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/adf1_freq_hz");} }

        /// <summary>
        ///  The current frequency of the second automatic direction finder.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/adf2_freq_hz
        /// </summary>
        public IXPDataRef<int> adf2_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/adf2_freq_hz");} }

        /// <summary>
        ///  The current frequency of the standalone DME receiver.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/dme_freq_hz
        /// </summary>
        public IXPDataRef<int> dme_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/dme_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/nav1_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> nav1_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/nav1_stdby_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/nav2_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> nav2_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/nav2_stdby_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/com1_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> com1_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/com1_stdby_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/com2_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> com2_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/com2_stdby_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/adf1_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> adf1_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/adf1_stdby_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/adf2_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> adf2_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/adf2_stdby_freq_hz");} }

        /// <summary>
        ///  The standby frequency for the radio mentioned above for flip/flop radios.<p>NOTE: X-Plane does not currently feature a flip-flop standalone DME instrument, but the data exists.. Units:10Hz
        ///  Raw path: sim/cockpit/radios/dme_stdby_freq_hz
        /// </summary>
        public IXPDataRef<int> dme_stdby_freq_hz { get { return m_data.GetInt("sim/cockpit/radios/dme_stdby_freq_hz");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (true: legacy). Units:degt
        ///  Raw path: sim/cockpit/radios/nav1_obs_degt
        /// </summary>
        public IXPDataRef<float> nav1_obs_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav1_obs_degt");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (true: legacy). Units:degt
        ///  Raw path: sim/cockpit/radios/nav2_obs_degt
        /// </summary>
        public IXPDataRef<float> nav2_obs_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav2_obs_degt");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (mag: modern) pilot. Units:degm
        ///  Raw path: sim/cockpit/radios/nav1_obs_degm
        /// </summary>
        public IXPDataRef<float> nav1_obs_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav1_obs_degm");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 1. (mag: modern) copilot. Units:degm
        ///  Raw path: sim/cockpit/radios/nav1_obs_degm2
        /// </summary>
        public IXPDataRef<float> nav1_obs_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_obs_degm2");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (mag: modern) pilot. Units:degm
        ///  Raw path: sim/cockpit/radios/nav2_obs_degm
        /// </summary>
        public IXPDataRef<float> nav2_obs_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav2_obs_degm");} }

        /// <summary>
        ///  The 'obs' heading programmed into VOR and HSI gauges that follow nav radio 2. (mag: modern) copilot. Units:degm
        ///  Raw path: sim/cockpit/radios/nav2_obs_degm2
        /// </summary>
        public IXPDataRef<float> nav2_obs_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_obs_degm2");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by nav1.  Set override with override_navneedles. Units:deg
        ///  Raw path: sim/cockpit/radios/nav1_dir_degt
        /// </summary>
        public IXPDataRef<float> nav1_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by nav2.  Set override with override_navneedles. Units:deg
        ///  Raw path: sim/cockpit/radios/nav2_dir_degt
        /// </summary>
        public IXPDataRef<float> nav2_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by adf1.  Use override_adf to stg.. Units:deg
        ///  Raw path: sim/cockpit/radios/adf1_dir_degt
        /// </summary>
        public IXPDataRef<float> adf1_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the beacon indicated by adf2.  Use override_adf to stg.. Units:deg
        ///  Raw path: sim/cockpit/radios/adf2_dir_degt
        /// </summary>
        public IXPDataRef<float> adf2_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the GPS 1 destination.. Units:deg
        ///  Raw path: sim/cockpit/radios/gps_dir_degt
        /// </summary>
        public IXPDataRef<float> gps_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps_dir_degt");} }

        /// <summary>
        ///  The relative bearing to the GPS 2 destination.. Units:deg
        ///  Raw path: sim/cockpit/radios/gps2_dir_degt
        /// </summary>
        public IXPDataRef<float> gps2_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dir_degt");} }

        /// <summary>
        ///  The relative bearing to whatever becaon the standalone DME is programmed for.. Units:deg
        ///  Raw path: sim/cockpit/radios/dme_dir_degt
        /// </summary>
        public IXPDataRef<float> dme_dir_degt { get { return m_data.GetFloat("sim/cockpit/radios/dme_dir_degt");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav1_hdef_dot
        /// </summary>
        public IXPDataRef<float> nav1_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav1_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav1_hdef_dot2
        /// </summary>
        public IXPDataRef<float> nav1_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav2_hdef_dot
        /// </summary>
        public IXPDataRef<float> nav2_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav2_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav2_hdef_dot2
        /// </summary>
        public IXPDataRef<float> nav2_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps_hdef_dot
        /// </summary>
        public IXPDataRef<float> gps_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps_hdef_dot2
        /// </summary>
        public IXPDataRef<float> gps_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - pilot.  override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps2_hdef_dot
        /// </summary>
        public IXPDataRef<float> gps2_hdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps2_hdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in course in 'dots' on a VOR compass - copilot.  override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps2_hdef_dot2
        /// </summary>
        public IXPDataRef<float> gps2_hdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps2_hdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav1_vdef_dot
        /// </summary>
        public IXPDataRef<float> nav1_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav1_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav1_vdef_dot2
        /// </summary>
        public IXPDataRef<float> nav1_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_vdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav2_vdef_dot
        /// </summary>
        public IXPDataRef<float> nav2_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/nav2_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot.  override_navneedles. Units:prcnt
        ///  Raw path: sim/cockpit/radios/nav2_vdef_dot2
        /// </summary>
        public IXPDataRef<float> nav2_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_vdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot. override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps_vdef_dot
        /// </summary>
        public IXPDataRef<float> gps_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot. override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps_vdef_dot2
        /// </summary>
        public IXPDataRef<float> gps_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps_vdef_dot2");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - pilot. override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps2_vdef_dot
        /// </summary>
        public IXPDataRef<float> gps2_vdef_dot { get { return m_data.GetFloat("sim/cockpit/radios/gps2_vdef_dot");} }

        /// <summary>
        ///  The deflection from the aircraft to the tuned in glide slope in dots on an ILS gauge - copilot. override_gps. Units:prcnt
        ///  Raw path: sim/cockpit/radios/gps2_vdef_dot2
        /// </summary>
        public IXPDataRef<float> gps2_vdef_dot2 { get { return m_data.GetFloat("sim/cockpit/radios/gps2_vdef_dot2");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav1 beacon - pilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/nav1_fromto
        /// </summary>
        public IXPDataRef<int> nav1_fromto { get { return m_data.GetInt("sim/cockpit/radios/nav1_fromto");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav1 beacon - copilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/nav1_fromto2
        /// </summary>
        public IXPDataRef<int> nav1_fromto2 { get { return m_data.GetInt("sim/cockpit/radios/nav1_fromto2");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav2 beacon - pilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/nav2_fromto
        /// </summary>
        public IXPDataRef<int> nav2_fromto { get { return m_data.GetInt("sim/cockpit/radios/nav2_fromto");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav2 beacon - copilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/nav2_fromto2
        /// </summary>
        public IXPDataRef<int> nav2_fromto2 { get { return m_data.GetInt("sim/cockpit/radios/nav2_fromto2");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav2 beacon - pilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/gps_fromto
        /// </summary>
        public IXPDataRef<int> gps_fromto { get { return m_data.GetInt("sim/cockpit/radios/gps_fromto");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav2 beacon - copilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/gps_fromto2
        /// </summary>
        public IXPDataRef<int> gps_fromto2 { get { return m_data.GetInt("sim/cockpit/radios/gps_fromto2");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav2 beacon - pilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/gps2_fromto
        /// </summary>
        public IXPDataRef<int> gps2_fromto { get { return m_data.GetInt("sim/cockpit/radios/gps2_fromto");} }

        /// <summary>
        ///  Whether we are heading to or from (or over) our nav2 beacon - copilot.. Units:enum
        ///  Raw path: sim/cockpit/radios/gps2_fromto2
        /// </summary>
        public IXPDataRef<int> gps2_fromto2 { get { return m_data.GetInt("sim/cockpit/radios/gps2_fromto2");} }

        /// <summary>
        ///  Are we receiving an expected glide slope for nav1. Units:bool
        ///  Raw path: sim/cockpit/radios/nav1_CDI
        /// </summary>
        public IXPDataRef<bool> nav1_CDI { get { return m_data.GetBool("sim/cockpit/radios/nav1_cdi");} }

        /// <summary>
        ///  Are we receiving an expected glide slope for nav2. Units:bool
        ///  Raw path: sim/cockpit/radios/nav2_CDI
        /// </summary>
        public IXPDataRef<bool> nav2_CDI { get { return m_data.GetBool("sim/cockpit/radios/nav2_cdi");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on nav1.  override_navneedles. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/nav1_dme_dist_m
        /// </summary>
        public IXPDataRef<float> nav1_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on nav2.  override_navneedles. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/nav2_dme_dist_m
        /// </summary>
        public IXPDataRef<float> nav2_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on adf1.  override_dme. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/adf1_dme_dist_m
        /// </summary>
        public IXPDataRef<float> adf1_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on adf2.  override_dme. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/adf2_dme_dist_m
        /// </summary>
        public IXPDataRef<float> adf2_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the GPS.  override_gps. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/gps_dme_dist_m
        /// </summary>
        public IXPDataRef<float> gps_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/gps_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the GPS.  override_gps. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/gps2_dme_dist_m
        /// </summary>
        public IXPDataRef<float> gps2_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dme_dist_m");} }

        /// <summary>
        ///  Our distance in nautical miles from the beacon tuned in on the standalone DME receiver. override_dme. Units:nautical_miles
        ///  Raw path: sim/cockpit/radios/standalone_dme_dist_m
        /// </summary>
        public IXPDataRef<float> standalone_dme_dist_m { get { return m_data.GetFloat("sim/cockpit/radios/standalone_dme_dist_m");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on nav1. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/nav1_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> nav1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on nav2. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/nav2_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> nav2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on adf1. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/adf1_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> adf1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on adf2. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/adf2_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> adf2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the GPS. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/gps_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> gps_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/gps_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the GPS. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/gps2_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> gps2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dme_speed_kts");} }

        /// <summary>
        ///  Our closing speed to the beacon tuned in on the standalone DME receiver. override_dme. Units:knots
        ///  Raw path: sim/cockpit/radios/standalone_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> standalone_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit/radios/standalone_dme_speed_kts");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on nav1. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        ///  Raw path: sim/cockpit/radios/nav1_dme_time_secs
        /// </summary>
        public IXPDataRef<float> nav1_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/nav1_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on nav2. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        ///  Raw path: sim/cockpit/radios/nav2_dme_time_secs
        /// </summary>
        public IXPDataRef<float> nav2_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/nav2_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on adf1. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        ///  Raw path: sim/cockpit/radios/adf1_dme_time_secs
        /// </summary>
        public IXPDataRef<float> adf1_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/adf1_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on adf2. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        ///  Raw path: sim/cockpit/radios/adf2_dme_time_secs
        /// </summary>
        public IXPDataRef<float> adf2_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/adf2_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on the GPS 1. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        ///  Raw path: sim/cockpit/radios/gps_dme_time_secs
        /// </summary>
        public IXPDataRef<float> gps_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/gps_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on the GPS 2. override_dme  (Dataref is labeled - this has always been minutes.). Units:mins
        ///  Raw path: sim/cockpit/radios/gps2_dme_time_secs
        /// </summary>
        public IXPDataRef<float> gps2_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/gps2_dme_time_secs");} }

        /// <summary>
        ///  Our time to reach the beacon tuned in on the standalone DME. override_dme  (Dataref is labeled - this has always been minutes.)\. Units:mins
        ///  Raw path: sim/cockpit/radios/standalone_dme_time_secs
        /// </summary>
        public IXPDataRef<float> standalone_dme_time_secs { get { return m_data.GetFloat("sim/cockpit/radios/standalone_dme_time_secs");} }

        /// <summary>
        ///  The localizer course for Nav1 or tuned in radial for a VOR. (Magnetic, new) - pilot use override_navneedles. Units:degm
        ///  Raw path: sim/cockpit/radios/nav1_course_degm
        /// </summary>
        public IXPDataRef<float> nav1_course_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav1_course_degm");} }

        /// <summary>
        ///  The localizer course for Nav1 or tuned in radial for a VOR. (Magnetic, new) - copilot use override_navneedles. Units:degm
        ///  Raw path: sim/cockpit/radios/nav1_course_degm2
        /// </summary>
        public IXPDataRef<float> nav1_course_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_course_degm2");} }

        /// <summary>
        ///  The localizer course for Nav2 or tuned in radial for a VOR. (Magnetic, new) - pilot use override_navneedles. Units:degm
        ///  Raw path: sim/cockpit/radios/nav2_course_degm
        /// </summary>
        public IXPDataRef<float> nav2_course_degm { get { return m_data.GetFloat("sim/cockpit/radios/nav2_course_degm");} }

        /// <summary>
        ///  The localizer course for Nav2 or tuned in radial for a VOR. (Magnetic, new) - copilot use override_navneedles. Units:degm
        ///  Raw path: sim/cockpit/radios/nav2_course_degm2
        /// </summary>
        public IXPDataRef<float> nav2_course_degm2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_course_degm2");} }

        /// <summary>
        ///  The localizer course for GPS 1 or tuned in radial for a VOR (Magnetic, new) - pilot - use override_gps. Units:degm
        ///  Raw path: sim/cockpit/radios/gps_course_degtm
        /// </summary>
        public IXPDataRef<float> gps_course_degtm { get { return m_data.GetFloat("sim/cockpit/radios/gps_course_degtm");} }

        /// <summary>
        ///  The localizer course for GPS 1 or tuned in radial for a VOR (Magnetic, new) - copilot - use override_gps. Units:degm
        ///  Raw path: sim/cockpit/radios/gps_course_degtm2
        /// </summary>
        public IXPDataRef<float> gps_course_degtm2 { get { return m_data.GetFloat("sim/cockpit/radios/gps_course_degtm2");} }

        /// <summary>
        ///  The localizer course for GPS 2 or tuned in radial for a VOR (Magnetic, new) - pilot - use override_gps. Units:degm
        ///  Raw path: sim/cockpit/radios/gps2_course_degtm
        /// </summary>
        public IXPDataRef<float> gps2_course_degtm { get { return m_data.GetFloat("sim/cockpit/radios/gps2_course_degtm");} }

        /// <summary>
        ///  The localizer course for GPS 2 or tuned in radial for a VOR (Magnetic, new) - copilot - use override_gps. Units:degm
        ///  Raw path: sim/cockpit/radios/gps2_course_degtm2
        /// </summary>
        public IXPDataRef<float> gps2_course_degtm2 { get { return m_data.GetFloat("sim/cockpit/radios/gps2_course_degtm2");} }

        /// <summary>
        ///  The glide slope slope for nav1.  Writable with override_navneedles starting in 940.. Units:deg
        ///  Raw path: sim/cockpit/radios/nav1_slope_degt
        /// </summary>
        public IXPDataRef<float> nav1_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav1_slope_degt");} }

        /// <summary>
        ///  The glide slope slope for nav2.  Writable with override_navneedles starting in 940.. Units:deg
        ///  Raw path: sim/cockpit/radios/nav2_slope_degt
        /// </summary>
        public IXPDataRef<float> nav2_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/nav2_slope_degt");} }

        /// <summary>
        ///  The glide slope slope for the GPS 1.  Writable with override_gps.. Units:deg
        ///  Raw path: sim/cockpit/radios/gps_slope_degt
        /// </summary>
        public IXPDataRef<float> gps_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps_slope_degt");} }

        /// <summary>
        ///  The glide slope slope for the GPS 1.  Writable with override_gps.. Units:deg
        ///  Raw path: sim/cockpit/radios/gps2_slope_degt
        /// </summary>
        public IXPDataRef<float> gps2_slope_degt { get { return m_data.GetFloat("sim/cockpit/radios/gps2_slope_degt");} }

        /// <summary>
        ///  Our transponder code.. Units:code
        ///  Raw path: sim/cockpit/radios/transponder_code
        /// </summary>
        public IXPDataRef<int> transponder_code { get { return m_data.GetInt("sim/cockpit/radios/transponder_code");} }

        /// <summary>
        ///  Whether we are squawking ident right now.. Units:bool
        ///  Raw path: sim/cockpit/radios/transponder_id
        /// </summary>
        public IXPDataRef<bool> transponder_id { get { return m_data.GetBool("sim/cockpit/radios/transponder_id");} }

        /// <summary>
        ///  Transponder light brightness ratio from 0 to 1. Units:ratio
        ///  Raw path: sim/cockpit/radios/transponder_brightness
        /// </summary>
        public IXPDataRef<float> transponder_brightness { get { return m_data.GetFloat("sim/cockpit/radios/transponder_brightness");} }

        /// <summary>
        ///  Transponder mode (off=0,stdby=1,on=2,test=3). Units:enum
        ///  Raw path: sim/cockpit/radios/transponder_mode
        /// </summary>
        public IXPDataRef<int> transponder_mode { get { return m_data.GetInt("sim/cockpit/radios/transponder_mode");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 1 - pilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/nav1_cardinal_dir
        /// </summary>
        public IXPDataRef<float> nav1_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/nav1_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 1 - copilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/nav1_cardinal_dir2
        /// </summary>
        public IXPDataRef<float> nav1_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/nav1_cardinal_dir2");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 2 - pilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/nav2_cardinal_dir
        /// </summary>
        public IXPDataRef<float> nav2_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/nav2_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for VOR 2 - copilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/nav2_cardinal_dir2
        /// </summary>
        public IXPDataRef<float> nav2_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/nav2_cardinal_dir2");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 1 - pilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/adf1_cardinal_dir
        /// </summary>
        public IXPDataRef<float> adf1_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/adf1_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 1 - copilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/adf1_cardinal_dir2
        /// </summary>
        public IXPDataRef<float> adf1_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/adf1_cardinal_dir2");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 2 - pilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/adf2_cardinal_dir
        /// </summary>
        public IXPDataRef<float> adf2_cardinal_dir { get { return m_data.GetFloat("sim/cockpit/radios/adf2_cardinal_dir");} }

        /// <summary>
        ///  Magnetic heading of the compass card for ADF 2 - copilot.. Units:degm
        ///  Raw path: sim/cockpit/radios/adf2_cardinal_dir2
        /// </summary>
        public IXPDataRef<float> adf2_cardinal_dir2 { get { return m_data.GetFloat("sim/cockpit/radios/adf2_cardinal_dir2");} }

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set. Units:bool
        ///  Raw path: sim/cockpit/radios/nav1_has_dme
        /// </summary>
        public IXPDataRef<bool> nav1_has_dme { get { return m_data.GetBool("sim/cockpit/radios/nav1_has_dme");} }

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set. Units:bool
        ///  Raw path: sim/cockpit/radios/nav2_has_dme
        /// </summary>
        public IXPDataRef<bool> nav2_has_dme { get { return m_data.GetBool("sim/cockpit/radios/nav2_has_dme");} }

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set. Units:bool
        ///  Raw path: sim/cockpit/radios/adf1_has_dme
        /// </summary>
        public IXPDataRef<bool> adf1_has_dme { get { return m_data.GetBool("sim/cockpit/radios/adf1_has_dme");} }

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set. Units:bool
        ///  Raw path: sim/cockpit/radios/adf2_has_dme
        /// </summary>
        public IXPDataRef<bool> adf2_has_dme { get { return m_data.GetBool("sim/cockpit/radios/adf2_has_dme");} }

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set. Units:bool
        ///  Raw path: sim/cockpit/radios/dme5_has_dme
        /// </summary>
        public IXPDataRef<bool> dme5_has_dme { get { return m_data.GetBool("sim/cockpit/radios/dme5_has_dme");} }

        /// <summary>
        ///  Type of NAVAID that is tuned in.. Units:enum
        ///  Raw path: sim/cockpit/radios/nav_type
        /// </summary>
        public IXPDataRef<int[]> nav_type { get { return m_data.GetIntArray("sim/cockpit/radios/nav_type");} }

        /// <summary>
        ///  autopilot source 0 is pilot, 1 is copilot. Units:int
        ///  Raw path: sim/cockpit/radios/ap_src
        /// </summary>
        public IXPDataRef<int> ap_src { get { return m_data.GetInt("sim/cockpit/radios/ap_src");} }

        /// <summary>
        ///  for a multifunction receiver...0-5 for nav1,nav2,com1,com2,adf1,adf2.. Units:int
        ///  Raw path: sim/cockpit/radios/nav_com_adf_mode
        /// </summary>
        public IXPDataRef<int> nav_com_adf_mode { get { return m_data.GetInt("sim/cockpit/radios/nav_com_adf_mode");} }

        /// <summary>
        ///  does the GPS 1 provide vertical guidance?  Write with override_gps. Units:int
        ///  Raw path: sim/cockpit/radios/gps_has_glideslope
        /// </summary>
        public IXPDataRef<int> gps_has_glideslope { get { return m_data.GetInt("sim/cockpit/radios/gps_has_glideslope");} }

        /// <summary>
        ///  does the GPS 2 provide vertical guidance?  Write with override_gps. Units:int
        ///  Raw path: sim/cockpit/radios/gps2_has_glideslope
        /// </summary>
        public IXPDataRef<int> gps2_has_glideslope { get { return m_data.GetInt("sim/cockpit/radios/gps2_has_glideslope");} }
    }
}