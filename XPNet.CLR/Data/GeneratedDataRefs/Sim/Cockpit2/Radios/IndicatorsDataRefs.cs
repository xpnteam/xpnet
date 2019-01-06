using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Radios_IndicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Radios_IndicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Indicated bearing to the nav1 navaid
        /// </summary>
        public IXPDataRef<float> Nav1_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the nav2 navaid
        /// </summary>
        public IXPDataRef<float> Nav2_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the nav N navaid
        /// </summary>
        public IXPDataRef<float[]> Nav_bearing_deg_mag { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the adf1 navaid
        /// </summary>
        public IXPDataRef<float> Adf1_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the adf2 navaid
        /// </summary>
        public IXPDataRef<float> Adf2_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the selected GPS 1 destination
        /// </summary>
        public IXPDataRef<float> Gps_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated bearing to the selected GPS 2 destination
        /// </summary>
        public IXPDataRef<float> Gps2_bearing_deg_mag { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_bearing_deg_mag");} }

        /// <summary>
        ///  Indicated relative bearing to the nav1 navaid
        /// </summary>
        public IXPDataRef<float> Nav1_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the nav2 navaid
        /// </summary>
        public IXPDataRef<float> Nav2_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the nav N navaid
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_bearing_deg { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the adf1 navaid
        /// </summary>
        public IXPDataRef<float> Adf1_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the adf2 navaid
        /// </summary>
        public IXPDataRef<float> Adf2_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the selected GPS 1 destination
        /// </summary>
        public IXPDataRef<float> Gps_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_bearing_deg");} }

        /// <summary>
        ///  Indicated relative bearing to the selected GPS 2 destination
        /// </summary>
        public IXPDataRef<float> Gps2_relative_bearing_deg { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_bearing_deg");} }

        /// <summary>
        ///  Glide slope flag, nav1.
        /// </summary>
        public IXPDataRef<bool> Nav1_flag_glideslope { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_flag_glideslope");} }

        /// <summary>
        ///  Glide slope flag, nav2.
        /// </summary>
        public IXPDataRef<bool> Nav2_flag_glideslope { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_flag_glideslope");} }

        /// <summary>
        ///  Glide slope flag, nav N.
        /// </summary>
        public IXPDataRef<bool[]> Nav_flag_glideslope { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_flag_glideslope");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on nav1
        /// </summary>
        public IXPDataRef<bool> Nav1_display_horizontal { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_display_horizontal");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on nav2
        /// </summary>
        public IXPDataRef<bool> Nav2_display_horizontal { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_display_horizontal");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on nav N
        /// </summary>
        public IXPDataRef<bool[]> Nav_display_horizontal { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_display_horizontal");} }

        /// <summary>
        ///  Is there some kind of vertical signal on nav1
        /// </summary>
        public IXPDataRef<bool> Nav1_display_vertical { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_display_vertical");} }

        /// <summary>
        ///  Is there some kind of vertical signal on nav2
        /// </summary>
        public IXPDataRef<bool> Nav2_display_vertical { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_display_vertical");} }

        /// <summary>
        ///  Is there some kind of vertical signal on nav N
        /// </summary>
        public IXPDataRef<bool[]> Nav_display_vertical { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_display_vertical");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, pilot
        /// </summary>
        public IXPDataRef<float> Nav1_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav2, pilot
        /// </summary>
        public IXPDataRef<float> Nav2_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, navN, pilot
        /// </summary>
        public IXPDataRef<float[]> Nav_hdef_dots_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps 1, pilot
        /// </summary>
        public IXPDataRef<float> Gps_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps 2, pilot
        /// </summary>
        public IXPDataRef<float> Gps2_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, copilot
        /// </summary>
        public IXPDataRef<float> Nav1_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav2, copilot
        /// </summary>
        public IXPDataRef<float> Nav2_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, navN, copilot
        /// </summary>
        public IXPDataRef<float[]> Nav_hdef_dots_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps, copilot
        /// </summary>
        public IXPDataRef<float> Gps_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, gps 2, copilot
        /// </summary>
        public IXPDataRef<float> Gps2_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, pilot
        /// </summary>
        public IXPDataRef<float> Nav1_vdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav2, pilot
        /// </summary>
        public IXPDataRef<float> Nav2_vdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, navN, pilot
        /// </summary>
        public IXPDataRef<float[]> Nav_vdef_dots_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, copilot
        /// </summary>
        public IXPDataRef<float> Nav1_vdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_vdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav2, copilot
        /// </summary>
        public IXPDataRef<float> Nav2_vdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_vdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, navN, copilot
        /// </summary>
        public IXPDataRef<float[]> Nav_vdef_dots_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_vdef_dots_copilot");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Nav1_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav1_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Nav2_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/nav2_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool[]> Nav_has_dme { get { return m_data.GetBoolArray("sim/cockpit2/radios/indicators/nav_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Adf1_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/adf1_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Adf2_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/adf2_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Gps_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/gps_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Gps2_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/gps2_has_dme");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Dme_has_dme { get { return m_data.GetBool("sim/cockpit2/radios/indicators/dme_has_dme");} }

        /// <summary>
        ///  nav1 DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Nav1_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_dme_distance_nm");} }

        /// <summary>
        ///  nav2 DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Nav2_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_dme_distance_nm");} }

        /// <summary>
        ///  navN DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float[]> Nav_dme_distance_nm { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_dme_distance_nm");} }

        /// <summary>
        ///  adf1 DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Adf1_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_dme_distance_nm");} }

        /// <summary>
        ///  adf2 DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Adf2_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_dme_distance_nm");} }

        /// <summary>
        ///  gps 1 DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Gps_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_dme_distance_nm");} }

        /// <summary>
        ///  gps 2 DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Gps2_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_dme_distance_nm");} }

        /// <summary>
        ///  standalone dme DME distance in nautical miles.
        /// </summary>
        public IXPDataRef<float> Dme_dme_distance_nm { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/dme_dme_distance_nm");} }

        /// <summary>
        ///  nav1 DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Nav1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_dme_speed_kts");} }

        /// <summary>
        ///  nav2 DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Nav2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_dme_speed_kts");} }

        /// <summary>
        ///  navN DME speed in knots.
        /// </summary>
        public IXPDataRef<float[]> Nav_dme_speed_kts { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_dme_speed_kts");} }

        /// <summary>
        ///  adf1 DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Adf1_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_dme_speed_kts");} }

        /// <summary>
        ///  adf2 DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Adf2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_dme_speed_kts");} }

        /// <summary>
        ///  gps 1 DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Gps_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_dme_speed_kts");} }

        /// <summary>
        ///  gps 2 DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Gps2_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_dme_speed_kts");} }

        /// <summary>
        ///  standalone dme DME speed in knots.
        /// </summary>
        public IXPDataRef<float> Dme_dme_speed_kts { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/dme_dme_speed_kts");} }

        /// <summary>
        ///  nav1 DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Nav1_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_dme_time_min");} }

        /// <summary>
        ///  nav2 DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Nav2_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_dme_time_min");} }

        /// <summary>
        ///  navN DME time in minutes.
        /// </summary>
        public IXPDataRef<float[]> Nav_dme_time_min { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_dme_time_min");} }

        /// <summary>
        ///  adf1 DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Adf1_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf1_dme_time_min");} }

        /// <summary>
        ///  adf2 DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Adf2_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/adf2_dme_time_min");} }

        /// <summary>
        ///  gps 1 DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Gps_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_dme_time_min");} }

        /// <summary>
        ///  gps 2 DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Gps2_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_dme_time_min");} }

        /// <summary>
        ///  standalone dme DME time in minutes.
        /// </summary>
        public IXPDataRef<float> Dme_dme_time_min { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/dme_dme_time_min");} }

        /// <summary>
        ///  current selected navID - nav radio 1
        /// </summary>
        public IXPDataRef<string> Nav1_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav1_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 2
        /// </summary>
        public IXPDataRef<string> Nav2_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav2_nav_id");} }

        /// <summary>
        ///  current selected navID - ADF 1
        /// </summary>
        public IXPDataRef<string> Adf1_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/adf1_nav_id");} }

        /// <summary>
        ///  current selected navID - ADF 2
        /// </summary>
        public IXPDataRef<string> Adf2_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/adf2_nav_id");} }

        /// <summary>
        ///  current selected navID - GPS 1
        /// </summary>
        public IXPDataRef<string> Gps_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/gps_nav_id");} }

        /// <summary>
        ///  current selected navID - GPS 2
        /// </summary>
        public IXPDataRef<string> Gps2_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/gps2_nav_id");} }

        /// <summary>
        ///  current selected navID - DME
        /// </summary>
        public IXPDataRef<string> Dme_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/dme_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 3
        /// </summary>
        public IXPDataRef<string> Nav3_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav3_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 4
        /// </summary>
        public IXPDataRef<string> Nav4_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav4_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 5
        /// </summary>
        public IXPDataRef<string> Nav5_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav5_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 6
        /// </summary>
        public IXPDataRef<string> Nav6_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav6_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 7
        /// </summary>
        public IXPDataRef<string> Nav7_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav7_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 8
        /// </summary>
        public IXPDataRef<string> Nav8_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav8_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 9
        /// </summary>
        public IXPDataRef<string> Nav9_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav9_nav_id");} }

        /// <summary>
        ///  current selected navID - nav radio 10
        /// </summary>
        public IXPDataRef<string> Nav10_nav_id { get { return m_data.GetString("sim/cockpit2/radios/indicators/nav10_nav_id");} }

        /// <summary>
        ///  Over the marker, 0 or 1.  This stays on when over the marker
        /// </summary>
        public IXPDataRef<bool> Over_outer_marker { get { return m_data.GetBool("sim/cockpit2/radios/indicators/over_outer_marker");} }

        /// <summary>
        ///  Over the marker, 0 or 1.  This stays on when over the marker
        /// </summary>
        public IXPDataRef<bool> Over_middle_marker { get { return m_data.GetBool("sim/cockpit2/radios/indicators/over_middle_marker");} }

        /// <summary>
        ///  Over the marker, 0 or 1.  This stays on when over the marker
        /// </summary>
        public IXPDataRef<bool> Over_inner_marker { get { return m_data.GetBool("sim/cockpit2/radios/indicators/over_inner_marker");} }

        /// <summary>
        ///  Marker light actually lit, 0 or 1.  This flashes as we go over.
        /// </summary>
        public IXPDataRef<bool> Outer_marker_lit { get { return m_data.GetBool("sim/cockpit2/radios/indicators/outer_marker_lit");} }

        /// <summary>
        ///  This flashes as we go over.
        /// </summary>
        public IXPDataRef<bool> Middle_marker_lit { get { return m_data.GetBool("sim/cockpit2/radios/indicators/middle_marker_lit");} }

        /// <summary>
        ///  This flashes as we go over.
        /// </summary>
        public IXPDataRef<bool> Inner_marker_lit { get { return m_data.GetBool("sim/cockpit2/radios/indicators/inner_marker_lit");} }

        /// <summary>
        ///  Indicated bearing to the pilot's HSI-selected navaid
        /// </summary>
        public IXPDataRef<float> Hsi_bearing_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_bearing_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated bearing to the copilot's HSI-selected navaid
        /// </summary>
        public IXPDataRef<float> Hsi_bearing_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_bearing_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated relative bearing to the pilot's HSI-selected navaid
        /// </summary>
        public IXPDataRef<float> Hsi_relative_bearing_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_bearing_deg_pilot");} }

        /// <summary>
        ///  Indicated relative bearing to the copilot's HSI-selected navaid
        /// </summary>
        public IXPDataRef<float> Hsi_relative_bearing_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_bearing_deg_copilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, pilot
        /// </summary>
        public IXPDataRef<float> Hsi_hdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_hdef_dots_pilot");} }

        /// <summary>
        ///  CDI lateral deflection in dots, nav1, copilot
        /// </summary>
        public IXPDataRef<float> Hsi_hdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_hdef_dots_copilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, pilot
        /// </summary>
        public IXPDataRef<float> Hsi_vdef_dots_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_vdef_dots_pilot");} }

        /// <summary>
        ///  CDI vertical deflection in dots, nav1, copilot
        /// </summary>
        public IXPDataRef<float> Hsi_vdef_dots_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_vdef_dots_copilot");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Hsi_has_dme_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_has_dme_pilot");} }

        /// <summary>
        ///  1 if yes, 0 if no
        /// </summary>
        public IXPDataRef<bool> Hsi_has_dme_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_has_dme_copilot");} }

        /// <summary>
        ///  nav1 DME distance in nautical miles, pilot HSI
        /// </summary>
        public IXPDataRef<float> Hsi_dme_distance_nm_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_distance_nm_pilot");} }

        /// <summary>
        ///  nav1 DME distance in nautical miles. copilot HSI
        /// </summary>
        public IXPDataRef<float> Hsi_dme_distance_nm_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_distance_nm_copilot");} }

        /// <summary>
        ///  nav1 DME speed in knots. pilot HSI
        /// </summary>
        public IXPDataRef<float> Hsi_dme_speed_kts_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_speed_kts_pilot");} }

        /// <summary>
        ///  nav1 DME speed in knots. copilot HSI
        /// </summary>
        public IXPDataRef<float> Hsi_dme_speed_kts_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_speed_kts_copilot");} }

        /// <summary>
        ///  nav1 DME time in minutes. pilot HSI
        /// </summary>
        public IXPDataRef<float> Hsi_dme_time_min_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_time_min_pilot");} }

        /// <summary>
        ///  nav1 DME time in minutes. copilot HSI
        /// </summary>
        public IXPDataRef<float> Hsi_dme_time_min_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_dme_time_min_copilot");} }

        /// <summary>
        ///  Glide slope flag, pilot side HSI
        /// </summary>
        public IXPDataRef<bool> Hsi_flag_glideslope_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_flag_glideslope_pilot");} }

        /// <summary>
        ///  Glide slope flag, copilot side HSI
        /// </summary>
        public IXPDataRef<bool> Hsi_flag_glideslope_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_flag_glideslope_copilot");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on pilot side HSI
        /// </summary>
        public IXPDataRef<bool> Hsi_display_horizontal_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_horizontal_pilot");} }

        /// <summary>
        ///  Is there some kind of horizontal signal on copilot side HSI
        /// </summary>
        public IXPDataRef<bool> Hsi_display_horizontal_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_horizontal_copilot");} }

        /// <summary>
        ///  Is there some kind of vertical signal on pilot side HSI
        /// </summary>
        public IXPDataRef<bool> Hsi_display_vertical_pilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_vertical_pilot");} }

        /// <summary>
        ///  Is there some kind of vertical signal on copilot side HSI
        /// </summary>
        public IXPDataRef<bool> Hsi_display_vertical_copilot { get { return m_data.GetBool("sim/cockpit2/radios/indicators/hsi_display_vertical_copilot");} }

        /// <summary>
        ///  Whether we are squawking ident right now.
        /// </summary>
        public IXPDataRef<bool> Transponder_id { get { return m_data.GetBool("sim/cockpit2/radios/indicators/transponder_id");} }

        /// <summary>
        ///  Transponder light brightness ratio from 0 to 1
        /// </summary>
        public IXPDataRef<float> Transponder_brightness { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/transponder_brightness");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Nav1_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Nav1_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Nav1_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Nav1_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Nav1_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS for the copilot.
        /// </summary>
        public IXPDataRef<float> Nav1_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav1_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the vacuum driven gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Nav2_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the vacuum driven gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Nav2_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the electric gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Nav2_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to the electric gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Nav2_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to AHARS gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Nav2_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav2 OBS to AHARS for the copilot.
        /// </summary>
        public IXPDataRef<float> Nav2_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/nav2_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the vacuum driven gyro for the pilot.
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the vacuum driven gyro for the copilot.
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the electric gyro for the pilot.
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_heading_electric_deg_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to the electric gyro for the copilot.
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_heading_electric_deg_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to AHARS gyro for the pilot.
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav N OBS to AHARS for the copilot.
        /// </summary>
        public IXPDataRef<float[]> Nav_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/indicators/nav_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the vacuum driven gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Gps_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the vacuum driven gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Gps_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the electric gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Gps_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to the electric gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Gps_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to AHARS gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Gps_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 1 course to AHARS for the copilot.
        /// </summary>
        public IXPDataRef<float> Gps_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the vacuum driven gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Gps2_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the vacuum driven gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Gps2_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the electric gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Gps2_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to the electric gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Gps2_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to AHARS gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Gps2_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the GPS 2 course to AHARS for the copilot.
        /// </summary>
        public IXPDataRef<float> Gps2_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/gps2_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Hsi_relative_heading_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_vacuum_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the vacuum driven gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Hsi_relative_heading_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_vacuum_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Hsi_relative_heading_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_electric_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to the electric gyro for the copilot.
        /// </summary>
        public IXPDataRef<float> Hsi_relative_heading_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_electric_deg_copilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS gyro for the pilot.
        /// </summary>
        public IXPDataRef<float> Hsi_relative_heading_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_ahars_deg_pilot");} }

        /// <summary>
        ///  This is the relative heading of the nav1 OBS to AHARS for the copilot.
        /// </summary>
        public IXPDataRef<float> Hsi_relative_heading_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/hsi_relative_heading_ahars_deg_copilot");} }

        /// <summary>
        ///  FMS Flight Plan Target Altitude
        /// </summary>
        public IXPDataRef<float> Fms_fpta_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_fpta_pilot");} }

        /// <summary>
        ///  FMS Vertical Path Angle
        /// </summary>
        public IXPDataRef<float> Fms_vpa_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_vpa_pilot");} }

        /// <summary>
        ///  FMS Vertical Track Error
        /// </summary>
        public IXPDataRef<float> Fms_vtk_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_vtk_pilot");} }

        /// <summary>
        ///  FMS Distance to Top of Descent
        /// </summary>
        public IXPDataRef<float> Fms_distance_to_tod_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_distance_to_tod_pilot");} }

        /// <summary>
        ///  Distance from top of descent to Nth waypoint (wayoint found via fms_tod_before_index_pilot)
        /// </summary>
        public IXPDataRef<float> Fms_tod_before_distance_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/indicators/fms_tod_before_distance_pilot");} }
    }
}