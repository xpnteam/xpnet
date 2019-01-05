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
        ///  OBS 1 (pilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav1_obs_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_obs_deg_mag_pilot");

        /// <summary>
        ///  OBS 2 (pilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav2_obs_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_obs_deg_mag_pilot");

        /// <summary>
        ///  OBS N (pilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float[]> Nav_obs_deg_mag_pilot => m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_obs_deg_mag_pilot");

        /// <summary>
        ///  OBS 1 (copilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav1_obs_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_obs_deg_mag_copilot");

        /// <summary>
        ///  OBS 2 (copilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav2_obs_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_obs_deg_mag_copilot");

        /// <summary>
        ///  OBS N (copilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float[]> Nav_obs_deg_mag_copilot => m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_obs_deg_mag_copilot");

        /// <summary>
        ///  CARD selection for ADF 1, pilot side, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Adf1_card_heading_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_pilot");

        /// <summary>
        ///  CARD selection for ADF 2, pilot side, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Adf2_card_heading_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_pilot");

        /// <summary>
        ///  CARD selection for ADF 1, copilot side, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Adf1_card_heading_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_copilot");

        /// <summary>
        ///  CARD selection for ADF 2, copilot side, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Adf2_card_heading_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_copilot");

        /// <summary>
        ///  Selected course based on nav1, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav1_course_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_course_deg_mag_pilot");

        /// <summary>
        ///  Selected course based on nav2, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav2_course_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_course_deg_mag_pilot");

        /// <summary>
        ///  Selected course based on navN, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float[]> Nav_course_deg_mag_pilot => m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_course_deg_mag_pilot");

        /// <summary>
        ///  Selected course based on nav1, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav1_course_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_course_deg_mag_copilot");

        /// <summary>
        ///  Selected course based on nav2, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Nav2_course_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_course_deg_mag_copilot");

        /// <summary>
        ///  Selected course based on navN, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float[]> Nav_course_deg_mag_copilot => m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_course_deg_mag_copilot");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for com1 audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_com1 => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_com1");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for com2 audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_com2 => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_com2");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for nav1 audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_nav1 => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_nav1");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for nav2 audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_nav2 => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_nav2");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for adf1 audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_adf1 => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_adf1");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for adf2 audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_adf2 => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_adf2");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for dme audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_dme => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_dme");

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for marker beacon audio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Audio_volume_mark => m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_mark");

        /// <summary>
        ///  HSI OBS (pilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Hsi_obs_deg_mag_pilot => m_data.GetFloat("sim/cockpit2/radios/actuators/hsi_obs_deg_mag_pilot");

        /// <summary>
        ///  HSI OBS (copilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Hsi_obs_deg_mag_copilot => m_data.GetFloat("sim/cockpit2/radios/actuators/hsi_obs_deg_mag_copilot");
    }
}