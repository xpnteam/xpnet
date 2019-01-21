using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_radios_indicatorsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_radios_indicatorsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Indicated bearing to the nav1 navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float> nav1_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the nav2 navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float> nav2_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the nav N navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/nav_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float[]> nav_bearing_deg_mag { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the adf1 navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float> adf1_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the adf2 navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float> adf2_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the selected GPS 1 destination. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/gps_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float> gps_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the selected GPS 2 destination. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_bearing_deg_mag
        /// </summary>
        public IXPDataRef<float> gps2_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated relative bearing to the nav1 navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float> nav1_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the nav2 navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float> nav2_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the nav N navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float[]> nav_relative_bearing_deg { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the adf1 navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float> adf1_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the adf2 navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float> adf2_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the selected GPS 1 destination. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float> gps_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the selected GPS 2 destination. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_bearing_deg
        /// </summary>
        public IXPDataRef<float> gps2_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_bearing_deg");} }

        /// <summary>
        ///  Nav-To-From indication, nav1, pilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_flag_from_to_pilot
        /// </summary>
        public IXPDataRef<int> nav1_flag_from_to_pilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/nav1_flag_from_to_pilot");} }

        /// <summary>
        ///  Nav-To-From indication, nav2, pilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_flag_from_to_pilot
        /// </summary>
        public IXPDataRef<int> nav2_flag_from_to_pilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/nav2_flag_from_to_pilot");} }

        /// <summary>
        ///  Nav-To-From indication, navN, pilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav_flag_from_to_pilot
        /// </summary>
        public IXPDataRef<int[]> nav_flag_from_to_pilot { get { return m_data.GetIntArray("sim/cockpit2/radios/indicators/nav_flag_from_to_pilot");} }

        /// <summary>
        ///  Nav-To-From indication, nav1, copilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_flag_from_to_copilot
        /// </summary>
        public IXPDataRef<int> nav1_flag_from_to_copilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/nav1_flag_from_to_copilot");} }

        /// <summary>
        ///  Nav-To-From indication, nav2, copilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_flag_from_to_copilot
        /// </summary>
        public IXPDataRef<int> nav2_flag_from_to_copilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/nav2_flag_from_to_copilot");} }

        /// <summary>
        ///  Nav-To-From indication, navN, copilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav_flag_from_to_copilot
        /// </summary>
        public IXPDataRef<int[]> nav_flag_from_to_copilot { get { return m_data.GetIntArray("sim/cockpit2/radios/indicators/nav_flag_from_to_copilot");} }

        /// <summary>
        ///  Glide slope flag, nav1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_flag_glideslope
        /// </summary>
        public IXPDataRef<bool> nav1_flag_glideslope { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_flag_glideslope");} }

        /// <summary>
        ///  Glide slope flag, nav2.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_flag_glideslope
        /// </summary>
        public IXPDataRef<bool> nav2_flag_glideslope { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_flag_glideslope");} }

        /// <summary>
        ///  Glide slope flag, nav N.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav_flag_glideslope
        /// </summary>
        public IXPDataRef<bool[]> nav_flag_glideslope { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_flag_glideslope");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on nav1. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_display_horizontal
        /// </summary>
        public IXPDataRef<bool> nav1_display_horizontal { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_display_horizontal");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on nav2. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_display_horizontal
        /// </summary>
        public IXPDataRef<bool> nav2_display_horizontal { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_display_horizontal");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on nav N. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav_display_horizontal
        /// </summary>
        public IXPDataRef<bool[]> nav_display_horizontal { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_display_horizontal");} }

        /// <summary>
        ///  Is there some kind of vertical signal on nav1. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_display_vertical
        /// </summary>
        public IXPDataRef<bool> nav1_display_vertical { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_display_vertical");} }

        /// <summary>
        ///  Is there some kind of vertical signal on nav2. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_display_vertical
        /// </summary>
        public IXPDataRef<bool> nav2_display_vertical { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_display_vertical");} }

        /// <summary>
        ///  Is there some kind of vertical signal on nav N. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav_display_vertical
        /// </summary>
        public IXPDataRef<bool[]> nav_display_vertical { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_display_vertical");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_hdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> nav1_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav2, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_hdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> nav2_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, navN, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav_hdef_dots_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_hdef_dots_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps 1, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/gps_hdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> gps_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps 2, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_hdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> gps2_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_hdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> nav1_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav2, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_hdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> nav2_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, navN, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav_hdef_dots_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_hdef_dots_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/gps_hdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> gps_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps 2, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_hdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> gps2_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_vdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> nav1_vdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav2, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_vdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> nav2_vdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, navN, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav_vdef_dots_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_vdef_dots_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_vdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> nav1_vdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_vdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav2, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_vdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> nav2_vdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_vdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, navN, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/nav_vdef_dots_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_vdef_dots_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_vdef_dots_copilot");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_has_dme
        /// </summary>
        public IXPDataRef<bool> nav1_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_has_dme
        /// </summary>
        public IXPDataRef<bool> nav2_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/nav_has_dme
        /// </summary>
        public IXPDataRef<bool[]> nav_has_dme { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_has_dme
        /// </summary>
        public IXPDataRef<bool> adf1_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/adf1_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_has_dme
        /// </summary>
        public IXPDataRef<bool> adf2_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/adf2_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/gps_has_dme
        /// </summary>
        public IXPDataRef<bool> gps_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/gps_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_has_dme
        /// </summary>
        public IXPDataRef<bool> gps2_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/gps2_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/dme_has_dme
        /// </summary>
        public IXPDataRef<bool> dme_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/dme_has_dme");} }

        /// <summary>
        ///  nav1 DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> nav1_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_dme_distance_nm");} }

        /// <summary>
        ///  nav2 DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> nav2_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_dme_distance_nm");} }

        /// <summary>
        ///  navN DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/nav_dme_distance_nm
        /// </summary>
        public IXPDataRef<float[]> nav_dme_distance_nm { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_dme_distance_nm");} }

        /// <summary>
        ///  adf1 DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> adf1_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_dme_distance_nm");} }

        /// <summary>
        ///  adf2 DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> adf2_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_dme_distance_nm");} }

        /// <summary>
        ///  gps 1 DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/gps_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> gps_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_dme_distance_nm");} }

        /// <summary>
        ///  gps 2 DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> gps2_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_dme_distance_nm");} }

        /// <summary>
        ///  standalone dme DME distance in nautical miles.. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/dme_dme_distance_nm
        /// </summary>
        public IXPDataRef<float> dme_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/dme_dme_distance_nm");} }

        /// <summary>
        ///  nav1 DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> nav1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_dme_speed_kts");} }

        /// <summary>
        ///  nav2 DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> nav2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_dme_speed_kts");} }

        /// <summary>
        ///  navN DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/nav_dme_speed_kts
        /// </summary>
        public IXPDataRef<float[]> nav_dme_speed_kts { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_dme_speed_kts");} }

        /// <summary>
        ///  adf1 DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> adf1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_dme_speed_kts");} }

        /// <summary>
        ///  adf2 DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> adf2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_dme_speed_kts");} }

        /// <summary>
        ///  gps 1 DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/gps_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> gps_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_dme_speed_kts");} }

        /// <summary>
        ///  gps 2 DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> gps2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_dme_speed_kts");} }

        /// <summary>
        ///  standalone dme DME speed in knots.. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/dme_dme_speed_kts
        /// </summary>
        public IXPDataRef<float> dme_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/dme_dme_speed_kts");} }

        /// <summary>
        ///  nav1 DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_dme_time_min
        /// </summary>
        public IXPDataRef<float> nav1_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_dme_time_min");} }

        /// <summary>
        ///  nav2 DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_dme_time_min
        /// </summary>
        public IXPDataRef<float> nav2_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_dme_time_min");} }

        /// <summary>
        ///  navN DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/nav_dme_time_min
        /// </summary>
        public IXPDataRef<float[]> nav_dme_time_min { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_dme_time_min");} }

        /// <summary>
        ///  adf1 DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_dme_time_min
        /// </summary>
        public IXPDataRef<float> adf1_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_dme_time_min");} }

        /// <summary>
        ///  adf2 DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_dme_time_min
        /// </summary>
        public IXPDataRef<float> adf2_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_dme_time_min");} }

        /// <summary>
        ///  gps 1 DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/gps_dme_time_min
        /// </summary>
        public IXPDataRef<float> gps_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_dme_time_min");} }

        /// <summary>
        ///  gps 2 DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_dme_time_min
        /// </summary>
        public IXPDataRef<float> gps2_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_dme_time_min");} }

        /// <summary>
        ///  standalone dme DME time in minutes.. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/dme_dme_time_min
        /// </summary>
        public IXPDataRef<float> dme_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/dme_dme_time_min");} }

        /// <summary>
        ///  current selected navID - nav radio 1. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_nav_id
        /// </summary>
        public IXPDataRef<string> nav1_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav1_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 2. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_nav_id
        /// </summary>
        public IXPDataRef<string> nav2_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav2_nav_id");} }

        /// <summary>
        ///  current selected navID - ADF 1. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/adf1_nav_id
        /// </summary>
        public IXPDataRef<string> adf1_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/adf1_nav_id");} }

        /// <summary>
        ///  current selected navID - ADF 2. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/adf2_nav_id
        /// </summary>
        public IXPDataRef<string> adf2_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/adf2_nav_id");} }

        /// <summary>
        ///  current selected navID - GPS 1. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/gps_nav_id
        /// </summary>
        public IXPDataRef<string> gps_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/gps_nav_id");} }

        /// <summary>
        ///  current selected navID - GPS 2. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_nav_id
        /// </summary>
        public IXPDataRef<string> gps2_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/gps2_nav_id");} }

        /// <summary>
        ///  current selected navID - DME. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/dme_nav_id
        /// </summary>
        public IXPDataRef<string> dme_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/dme_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 3. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav3_nav_id
        /// </summary>
        public IXPDataRef<string> nav3_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav3_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 4. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav4_nav_id
        /// </summary>
        public IXPDataRef<string> nav4_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav4_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 5. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav5_nav_id
        /// </summary>
        public IXPDataRef<string> nav5_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav5_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 6. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav6_nav_id
        /// </summary>
        public IXPDataRef<string> nav6_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav6_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 7. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav7_nav_id
        /// </summary>
        public IXPDataRef<string> nav7_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav7_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 8. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav8_nav_id
        /// </summary>
        public IXPDataRef<string> nav8_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav8_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 9. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav9_nav_id
        /// </summary>
        public IXPDataRef<string> nav9_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav9_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 10. Units:string
        ///  Raw path: sim/cockpit2/radios/indicators/nav10_nav_id
        /// </summary>
        public IXPDataRef<string> nav10_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav10_nav_id");} }

        /// <summary>
        ///  Type of navaid that's currently tuned in and being received - nav1. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_type
        /// </summary>
        public IXPDataRef<int> nav1_type { get { return m_data.GetInt("sim/cockpit2/radios/indicators/nav1_type");} }

        /// <summary>
        ///  Type of navaid that's currently tuned in and being received - nav2. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_type
        /// </summary>
        public IXPDataRef<int> nav2_type { get { return m_data.GetInt("sim/cockpit2/radios/indicators/nav2_type");} }

        /// <summary>
        ///  Type of navaid that's currently tuned in and being received - any nav receiver. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/nav_type
        /// </summary>
        public IXPDataRef<int[]> nav_type { get { return m_data.GetIntArray("sim/cockpit2/radios/indicators/nav_type");} }

        /// <summary>
        ///  Over the marker, 0 or 1.  This stays on when over the marker. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/over_outer_marker
        /// </summary>
        public IXPDataRef<bool> over_outer_marker { get { return m_data.GetBool("sim/cockpit2/radios/indicators/over_outer_marker");} }

        /// <summary>
        ///  Over the marker, 0 or 1.  This stays on when over the marker. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/over_middle_marker
        /// </summary>
        public IXPDataRef<bool> over_middle_marker { get { return m_data.GetBool("sim/cockpit2/radios/indicators/over_middle_marker");} }

        /// <summary>
        ///  Over the marker, 0 or 1.  This stays on when over the marker. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/over_inner_marker
        /// </summary>
        public IXPDataRef<bool> over_inner_marker { get { return m_data.GetBool("sim/cockpit2/radios/indicators/over_inner_marker");} }

        /// <summary>
        ///  Marker light actually lit, 0 or 1.  This flashes as we go over.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/outer_marker_lit
        /// </summary>
        public IXPDataRef<bool> outer_marker_lit { get { return m_data.GetBool("sim/cockpit2/radios/indicators/outer_marker_lit");} }

        /// <summary>
        ///  This flashes as we go over.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/middle_marker_lit
        /// </summary>
        public IXPDataRef<bool> middle_marker_lit { get { return m_data.GetBool("sim/cockpit2/radios/indicators/middle_marker_lit");} }

        /// <summary>
        ///  This flashes as we go over.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/inner_marker_lit
        /// </summary>
        public IXPDataRef<bool> inner_marker_lit { get { return m_data.GetBool("sim/cockpit2/radios/indicators/inner_marker_lit");} }

        /// <summary>
        ///  Indicated bearing to the pilot's HSI-selected navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_bearing_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> hsi_bearing_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_bearing_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated bearing to the copilot's HSI-selected navaid. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_bearing_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> hsi_bearing_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_bearing_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated relative bearing to the pilot's HSI-selected navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_bearing_deg_pilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_bearing_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_bearing_deg_pilot");} }

        /// <summary>
        ///  Indicated relative bearing to the copilot's HSI-selected navaid. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_bearing_deg_copilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_bearing_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_bearing_deg_copilot");} }

        /// <summary>
        ///  Nav-To-From indication, nav1, pilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_flag_from_to_pilot
        /// </summary>
        public IXPDataRef<int> hsi_flag_from_to_pilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/hsi_flag_from_to_pilot");} }

        /// <summary>
        ///  Nav-To-From indication, nav1, copilot, 0 is flag, 1 is to, 2 is from.. Units:enum
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_flag_from_to_copilot
        /// </summary>
        public IXPDataRef<int> hsi_flag_from_to_copilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/hsi_flag_from_to_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_hdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> hsi_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_hdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> hsi_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, pilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_vdef_dots_pilot
        /// </summary>
        public IXPDataRef<float> hsi_vdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, copilot. Units:dots
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_vdef_dots_copilot
        /// </summary>
        public IXPDataRef<float> hsi_vdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_vdef_dots_copilot");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_has_dme_pilot
        /// </summary>
        public IXPDataRef<bool> hsi_has_dme_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_has_dme_pilot");} }

        /// <summary>
        ///  1 if yes, 0 if no. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_has_dme_copilot
        /// </summary>
        public IXPDataRef<bool> hsi_has_dme_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_has_dme_copilot");} }

        /// <summary>
        ///  nav1 DME distance in nautical miles, pilot HSI. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_dme_distance_nm_pilot
        /// </summary>
        public IXPDataRef<float> hsi_dme_distance_nm_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_distance_nm_pilot");} }

        /// <summary>
        ///  nav1 DME distance in nautical miles. copilot HSI. Units:nautical_miles
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_dme_distance_nm_copilot
        /// </summary>
        public IXPDataRef<float> hsi_dme_distance_nm_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_distance_nm_copilot");} }

        /// <summary>
        ///  nav1 DME speed in knots. pilot HSI. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_dme_speed_kts_pilot
        /// </summary>
        public IXPDataRef<float> hsi_dme_speed_kts_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_speed_kts_pilot");} }

        /// <summary>
        ///  nav1 DME speed in knots. copilot HSI. Units:knots
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_dme_speed_kts_copilot
        /// </summary>
        public IXPDataRef<float> hsi_dme_speed_kts_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_speed_kts_copilot");} }

        /// <summary>
        ///  nav1 DME time in minutes. pilot HSI. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_dme_time_min_pilot
        /// </summary>
        public IXPDataRef<float> hsi_dme_time_min_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_time_min_pilot");} }

        /// <summary>
        ///  nav1 DME time in minutes. copilot HSI. Units:minutes
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_dme_time_min_copilot
        /// </summary>
        public IXPDataRef<float> hsi_dme_time_min_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_time_min_copilot");} }

        /// <summary>
        ///  Glide slope flag, pilot side HSI. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_flag_glideslope_pilot
        /// </summary>
        public IXPDataRef<bool> hsi_flag_glideslope_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_flag_glideslope_pilot");} }

        /// <summary>
        ///  Glide slope flag, copilot side HSI. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_flag_glideslope_copilot
        /// </summary>
        public IXPDataRef<bool> hsi_flag_glideslope_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_flag_glideslope_copilot");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on pilot side HSI. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_display_horizontal_pilot
        /// </summary>
        public IXPDataRef<bool> hsi_display_horizontal_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_horizontal_pilot");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on copilot side HSI. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_display_horizontal_copilot
        /// </summary>
        public IXPDataRef<bool> hsi_display_horizontal_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_horizontal_copilot");} }

        /// <summary>
        ///  Is there some kind of vertical signal on pilot side HSI. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_display_vertical_pilot
        /// </summary>
        public IXPDataRef<bool> hsi_display_vertical_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_vertical_pilot");} }

        /// <summary>
        ///  Is there some kind of vertical signal on copilot side HSI. Units:boolean
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_display_vertical_copilot
        /// </summary>
        public IXPDataRef<bool> hsi_display_vertical_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_vertical_copilot");} }

        /// <summary>
        ///  Whether we are squawking ident right now.. Units:bool
        ///  Raw path: sim/cockpit2/radios/indicators/transponder_id
        /// </summary>
        public IXPDataRef<bool> transponder_id { get { return m_data.GetBool("sim/cockpit2/radios/indicators/transponder_id");} }

        /// <summary>
        ///  Transponder light brightness ratio from 0 to 1. Units:ratio
        ///  Raw path: sim/cockpit2/radios/indicators/transponder_brightness
        /// </summary>
        public IXPDataRef<float> transponder_brightness { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/transponder_brightness");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_heading_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> nav1_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_heading_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> nav1_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_heading_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> nav1_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_heading_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> nav1_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_heading_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> nav1_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav1_relative_heading_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> nav1_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the vacuum driven gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_heading_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> nav2_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the vacuum driven gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_heading_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> nav2_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the electric gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_heading_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> nav2_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the electric gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_heading_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> nav2_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to AHARS gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_heading_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> nav2_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to AHARS for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav2_relative_heading_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> nav2_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the vacuum driven gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_heading_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the vacuum driven gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_heading_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the electric gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_heading_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_relative_heading_electric_deg_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the electric gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_heading_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_relative_heading_electric_deg_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to AHARS gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_heading_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to AHARS for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/nav_relative_heading_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the vacuum driven gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_heading_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> gps_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the vacuum driven gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_heading_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> gps_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the electric gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_heading_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> gps_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the electric gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_heading_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> gps_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to AHARS gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_heading_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> gps_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to AHARS for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps_relative_heading_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> gps_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the vacuum driven gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_heading_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> gps2_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the vacuum driven gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_heading_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> gps2_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the electric gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_heading_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> gps2_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the electric gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_heading_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> gps2_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to AHARS gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_heading_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> gps2_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to AHARS for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/gps2_relative_heading_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> gps2_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_heading_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_heading_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_heading_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_heading_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS gyro for the pilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_heading_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS for the copilot.. Units:degrees
        ///  Raw path: sim/cockpit2/radios/indicators/hsi_relative_heading_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> hsi_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  Is the exec FMS light/warning lit for the pilot. Units:Boolean
        ///  Raw path: sim/cockpit2/radios/indicators/fms_exec_light_pilot
        /// </summary>
        public IXPDataRef<int> fms_exec_light_pilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/fms_exec_light_pilot");} }

        /// <summary>
        ///  Is the exec FMS light/warning lit for the co-pilot. Units:Boolean
        ///  Raw path: sim/cockpit2/radios/indicators/fms_exec_light_copilot
        /// </summary>
        public IXPDataRef<int> fms_exec_light_copilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/fms_exec_light_copilot");} }

        /// <summary>
        ///  FMS Flight Plan Target Altitude. Units:Feet
        ///  Raw path: sim/cockpit2/radios/indicators/fms_fpta_pilot
        /// </summary>
        public IXPDataRef<float> fms_fpta_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_fpta_pilot");} }

        /// <summary>
        ///  FMS Vertical Path Angle. Units:Degrees
        ///  Raw path: sim/cockpit2/radios/indicators/fms_vpa_pilot
        /// </summary>
        public IXPDataRef<float> fms_vpa_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_vpa_pilot");} }

        /// <summary>
        ///  FMS Vertical Track Error. Units:Degrees
        ///  Raw path: sim/cockpit2/radios/indicators/fms_vtk_pilot
        /// </summary>
        public IXPDataRef<float> fms_vtk_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_vtk_pilot");} }

        /// <summary>
        ///  FMS Distance to Top of Descent. Units:nm
        ///  Raw path: sim/cockpit2/radios/indicators/fms_distance_to_tod_pilot
        /// </summary>
        public IXPDataRef<float> fms_distance_to_tod_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_distance_to_tod_pilot");} }

        /// <summary>
        ///  Index of waypoint in flightplan before which top of descent is located. Units:index
        ///  Raw path: sim/cockpit2/radios/indicators/fms_tod_before_index_pilot
        /// </summary>
        public IXPDataRef<int> fms_tod_before_index_pilot { get { return m_data.GetInt("sim/cockpit2/radios/indicators/fms_tod_before_index_pilot");} }

        /// <summary>
        ///  Distance from top of descent to Nth waypoint (wayoint found via fms_tod_before_index_pilot). Units:nm
        ///  Raw path: sim/cockpit2/radios/indicators/fms_tod_before_distance_pilot
        /// </summary>
        public IXPDataRef<float> fms_tod_before_distance_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_tod_before_distance_pilot");} }
    }
}