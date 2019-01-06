using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Radios_ActuatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Radios_ActuatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Nav radio 1 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Nav1_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav1_power");} }

        /// <summary>
        ///  Nav radio 2 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Nav2_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav2_power");} }

        /// <summary>
        ///  Nav radio N off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool[]> Nav_power { get { return m_data.GetBoolArray("sim/cockpit2/radios/actuators/nav_power");} }

        /// <summary>
        ///  Com radio 1 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Com1_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com1_power");} }

        /// <summary>
        ///  Com radio 2 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Com2_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com2_power");} }

        /// <summary>
        ///  GPS 1 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Gps_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/gps_power");} }

        /// <summary>
        ///  GPS 2 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Gps2_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/gps2_power");} }

        /// <summary>
        ///  DME radio 1 off or on, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Dme_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/dme_power");} }

        /// <summary>
        ///  OBS 1 (pilot side) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Nav1_obs_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_obs_deg_mag_pilot");} }

        /// <summary>
        ///  OBS 2 (pilot isde) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Nav2_obs_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_obs_deg_mag_pilot");} }

        /// <summary>
        ///  OBS N (pilot isde) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float[]> Nav_obs_deg_mag_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_obs_deg_mag_pilot");} }

        /// <summary>
        ///  OBS 1 (copilot side) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Nav1_obs_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_obs_deg_mag_copilot");} }

        /// <summary>
        ///  OBS 2 (copilot isde) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Nav2_obs_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_obs_deg_mag_copilot");} }

        /// <summary>
        ///  OBS N (copilot isde) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float[]> Nav_obs_deg_mag_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_obs_deg_mag_copilot");} }

        /// <summary>
        ///  CARD selection for ADF 1, pilot side, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Adf1_card_heading_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_pilot");} }

        /// <summary>
        ///  CARD selection for ADF 2, pilot side, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Adf2_card_heading_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_pilot");} }

        /// <summary>
        ///  CARD selection for ADF 1, copilot side, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Adf1_card_heading_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_copilot");} }

        /// <summary>
        ///  CARD selection for ADF 2, copilot side, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Adf2_card_heading_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_copilot");} }

        /// <summary>
        ///  Selected course based on nav1, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS
        /// </summary>
        public IXPDataRef<float> Nav1_course_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_course_deg_mag_pilot");} }

        /// <summary>
        ///  Selected course based on nav2, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS
        /// </summary>
        public IXPDataRef<float> Nav2_course_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_course_deg_mag_pilot");} }

        /// <summary>
        ///  Selected course based on navN, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS
        /// </summary>
        public IXPDataRef<float[]> Nav_course_deg_mag_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_course_deg_mag_pilot");} }

        /// <summary>
        ///  Selected course based on nav1, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS
        /// </summary>
        public IXPDataRef<float> Nav1_course_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_course_deg_mag_copilot");} }

        /// <summary>
        ///  Selected course based on nav2, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS
        /// </summary>
        public IXPDataRef<float> Nav2_course_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_course_deg_mag_copilot");} }

        /// <summary>
        ///  Selected course based on navN, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS
        /// </summary>
        public IXPDataRef<float[]> Nav_course_deg_mag_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_course_deg_mag_copilot");} }

        /// <summary>
        ///  is com1 selected for listening
        /// </summary>
        public IXPDataRef<bool> Audio_selection_com1 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_com1");} }

        /// <summary>
        ///  is com2 selected for listening
        /// </summary>
        public IXPDataRef<bool> Audio_selection_com2 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_com2");} }

        /// <summary>
        ///  is nav1 selected for listening
        /// </summary>
        public IXPDataRef<bool> Audio_selection_nav1 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_nav1");} }

        /// <summary>
        ///  is nav2 selected for listening
        /// </summary>
        public IXPDataRef<bool> Audio_selection_nav2 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_nav2");} }

        /// <summary>
        ///  is adf1 selected for listening
        /// </summary>
        public IXPDataRef<bool> Audio_selection_adf1 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_adf1");} }

        /// <summary>
        ///  is adf2 selected for listening
        /// </summary>
        public IXPDataRef<bool> Audio_selection_adf2 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_adf2");} }

        /// <summary>
        ///  Is DME audio enabled?  This only matters if the current selection has DME
        /// </summary>
        public IXPDataRef<bool> Audio_dme_enabled { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_dme_enabled");} }

        /// <summary>
        ///  Is audio for the marker beacons enabled?
        /// </summary>
        public IXPDataRef<bool> Audio_marker_enabled { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_marker_enabled");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for com1 audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_com1 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_com1");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for com2 audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_com2 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_com2");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for nav1 audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_nav1 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_nav1");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for nav2 audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_nav2 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_nav2");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for adf1 audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_adf1 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_adf1");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for adf2 audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_adf2 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_adf2");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for dme audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_dme { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_dme");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for marker beacon audio
        /// </summary>
        public IXPDataRef<float> Audio_volume_mark { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_mark");} }

        /// <summary>
        ///  HSI OBS (pilot side) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Hsi_obs_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/hsi_obs_deg_mag_pilot");} }

        /// <summary>
        ///  HSI OBS (copilot side) selection, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Hsi_obs_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/hsi_obs_deg_mag_copilot");} }

        /// <summary>
        ///  1 if right nav 1 radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Nav1_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav1_right_is_selected");} }

        /// <summary>
        ///  1 if right nav 2 radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Nav2_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav2_right_is_selected");} }

        /// <summary>
        ///  1 if right com 1 radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Com1_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com1_right_is_selected");} }

        /// <summary>
        ///  1 if right com 2 radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Com2_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com2_right_is_selected");} }

        /// <summary>
        ///  1 if right adf 1 radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Adf1_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/adf1_right_is_selected");} }

        /// <summary>
        ///  1 if right adf 2 radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Adf2_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/adf2_right_is_selected");} }

        /// <summary>
        ///  1 if right DME radio is selected, 0 if left is selected
        /// </summary>
        public IXPDataRef<bool> Dme_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/dme_right_is_selected");} }
    }
}