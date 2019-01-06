using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_radios_actuatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_radios_actuatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Nav radio 1 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_power
        /// </summary>
        public IXPDataRef<bool> nav1_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav1_power");} }

        /// <summary>
        ///  Nav radio 2 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_power
        /// </summary>
        public IXPDataRef<bool> nav2_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav2_power");} }

        /// <summary>
        ///  Nav radio N off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/nav_power
        /// </summary>
        public IXPDataRef<bool[]> nav_power { get { return m_data.GetBoolArray("sim/cockpit2/radios/actuators/nav_power");} }

        /// <summary>
        ///  Com radio 1 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/com1_power
        /// </summary>
        public IXPDataRef<bool> com1_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com1_power");} }

        /// <summary>
        ///  Com radio 2 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/com2_power
        /// </summary>
        public IXPDataRef<bool> com2_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com2_power");} }

        /// <summary>
        ///  ADF radio 1 off or on, 0 = off, 1 = antenna, 2 = on, 3 = tone, 4 = test. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_power
        /// </summary>
        public IXPDataRef<int> adf1_power { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf1_power");} }

        /// <summary>
        ///  ADF radio 2 off or on, 0 = off, 1 = antenna, 2 = on, 3 = tone, 4 = test. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_power
        /// </summary>
        public IXPDataRef<int> adf2_power { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf2_power");} }

        /// <summary>
        ///  GPS 1 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/gps_power
        /// </summary>
        public IXPDataRef<bool> gps_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/gps_power");} }

        /// <summary>
        ///  GPS 2 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/gps2_power
        /// </summary>
        public IXPDataRef<bool> gps2_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/gps2_power");} }

        /// <summary>
        ///  DME radio 1 off or on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/dme_power
        /// </summary>
        public IXPDataRef<bool> dme_power { get { return m_data.GetBool("sim/cockpit2/radios/actuators/dme_power");} }

        /// <summary>
        ///  Nav radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav1_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_frequency_hz");} }

        /// <summary>
        ///  Nav radio 1 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> nav1_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_frequency_mhz");} }

        /// <summary>
        ///  Nav radio 1 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_frequency_khz
        /// </summary>
        public IXPDataRef<int> nav1_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_frequency_khz");} }

        /// <summary>
        ///  Nav radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav2_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_frequency_hz");} }

        /// <summary>
        ///  Nav radio 2 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> nav2_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_frequency_mhz");} }

        /// <summary>
        ///  Nav radio 2 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_frequency_khz
        /// </summary>
        public IXPDataRef<int> nav2_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_frequency_khz");} }

        /// <summary>
        ///  Nav radio N frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav_frequency_hz
        /// </summary>
        public IXPDataRef<int[]> nav_frequency_hz { get { return m_data.GetIntArray("sim/cockpit2/radios/actuators/nav_frequency_hz");} }

        /// <summary>
        ///  Nav radio N frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/nav_frequency_Mhz
        /// </summary>
        public IXPDataRef<int[]> nav_frequency_Mhz { get { return m_data.GetIntArray("sim/cockpit2/radios/actuators/nav_frequency_mhz");} }

        /// <summary>
        ///  Nav radio N frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/nav_frequency_khz
        /// </summary>
        public IXPDataRef<int[]> nav_frequency_khz { get { return m_data.GetIntArray("sim/cockpit2/radios/actuators/nav_frequency_khz");} }

        /// <summary>
        ///  Com radio 1 frequency, 10 hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_frequency_hz
        /// </summary>
        public IXPDataRef<int> com1_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_frequency_hz");} }

        /// <summary>
        ///  Com radio 1 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> com1_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_frequency_mhz");} }

        /// <summary>
        ///  Com radio 1 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_frequency_khz
        /// </summary>
        public IXPDataRef<int> com1_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_frequency_khz");} }

        /// <summary>
        ///  Com radio 1 frequency, hz, supports 8.3 khz spacing. Units:hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_frequency_hz_833
        /// </summary>
        public IXPDataRef<int> com1_frequency_hz_833 { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_frequency_hz_833");} }

        /// <summary>
        ///  Com radio 2 frequency, 10 hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_frequency_hz
        /// </summary>
        public IXPDataRef<int> com2_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_frequency_hz");} }

        /// <summary>
        ///  Com radio 2 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> com2_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_frequency_mhz");} }

        /// <summary>
        ///  Com radio 2 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_frequency_khz
        /// </summary>
        public IXPDataRef<int> com2_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_frequency_khz");} }

        /// <summary>
        ///  Com radio 2 frequency, hz, supports 8.3 khz spacing. Units:hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_frequency_hz_833
        /// </summary>
        public IXPDataRef<int> com2_frequency_hz_833 { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_frequency_hz_833");} }

        /// <summary>
        ///  ADF radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf1_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf1_frequency_hz");} }

        /// <summary>
        ///  ADF radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf2_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf2_frequency_hz");} }

        /// <summary>
        ///  DME radio frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/dme_frequency_hz
        /// </summary>
        public IXPDataRef<int> dme_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/dme_frequency_hz");} }

        /// <summary>
        ///  Nav radio 1 standby frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav1_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_standby_frequency_hz");} }

        /// <summary>
        ///  Standby Nav radio 1 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_standby_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> nav1_standby_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_standby_frequency_mhz");} }

        /// <summary>
        ///  Standby Nav radio 1 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_standby_frequency_khz
        /// </summary>
        public IXPDataRef<int> nav1_standby_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_standby_frequency_khz");} }

        /// <summary>
        ///  Nav radio 2 standby frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav2_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_standby_frequency_hz");} }

        /// <summary>
        ///  Standby Nav radio 2 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_standby_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> nav2_standby_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_standby_frequency_mhz");} }

        /// <summary>
        ///  Standby Nav radio 2 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_standby_frequency_khz
        /// </summary>
        public IXPDataRef<int> nav2_standby_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_standby_frequency_khz");} }

        /// <summary>
        ///  Nav radio N standby frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int[]> nav_standby_frequency_hz { get { return m_data.GetIntArray("sim/cockpit2/radios/actuators/nav_standby_frequency_hz");} }

        /// <summary>
        ///  Standby Nav radio N frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/nav_standby_frequency_Mhz
        /// </summary>
        public IXPDataRef<int[]> nav_standby_frequency_Mhz { get { return m_data.GetIntArray("sim/cockpit2/radios/actuators/nav_standby_frequency_mhz");} }

        /// <summary>
        ///  Standby Nav radio N frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/nav_standby_frequency_khz
        /// </summary>
        public IXPDataRef<int[]> nav_standby_frequency_khz { get { return m_data.GetIntArray("sim/cockpit2/radios/actuators/nav_standby_frequency_khz");} }

        /// <summary>
        ///  Com radio 1 standby frequency, 10 hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> com1_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_standby_frequency_hz");} }

        /// <summary>
        ///  Standby Com radio 1 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_standby_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> com1_standby_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_standby_frequency_mhz");} }

        /// <summary>
        ///  Standby Com radio 1 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_standby_frequency_khz
        /// </summary>
        public IXPDataRef<int> com1_standby_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_standby_frequency_khz");} }

        /// <summary>
        ///  Com radio 1 standby frequency, hz, supports 8.3 khz spacing. Units:hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_standby_frequency_hz_833
        /// </summary>
        public IXPDataRef<int> com1_standby_frequency_hz_833 { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_standby_frequency_hz_833");} }

        /// <summary>
        ///  Com radio 2 standby frequency, 10 hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> com2_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_standby_frequency_hz");} }

        /// <summary>
        ///  Standby Com radio 2 frequency, Mhz component only. Units:Mhz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_standby_frequency_Mhz
        /// </summary>
        public IXPDataRef<int> com2_standby_frequency_Mhz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_standby_frequency_mhz");} }

        /// <summary>
        ///  Standby com radio 2 frequency, khz component only. Units:khz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_standby_frequency_khz
        /// </summary>
        public IXPDataRef<int> com2_standby_frequency_khz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_standby_frequency_khz");} }

        /// <summary>
        ///  Com radio 2 standby frequency, hz, supports 8.3 khz spacing. Units:hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_standby_frequency_hz_833
        /// </summary>
        public IXPDataRef<int> com2_standby_frequency_hz_833 { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_standby_frequency_hz_833");} }

        /// <summary>
        ///  ADF radio 1 standby frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf1_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf1_standby_frequency_hz");} }

        /// <summary>
        ///  ADF radio 2 standby frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf2_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf2_standby_frequency_hz");} }

        /// <summary>
        ///  DME radio standby frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/dme_standby_frequency_hz
        /// </summary>
        public IXPDataRef<int> dme_standby_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/dme_standby_frequency_hz");} }

        /// <summary>
        ///  OBS 1 (pilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_obs_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> nav1_obs_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_obs_deg_mag_pilot");} }

        /// <summary>
        ///  OBS 2 (pilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_obs_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> nav2_obs_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_obs_deg_mag_pilot");} }

        /// <summary>
        ///  OBS N (pilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav_obs_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_obs_deg_mag_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_obs_deg_mag_pilot");} }

        /// <summary>
        ///  OBS 1 (copilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_obs_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> nav1_obs_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_obs_deg_mag_copilot");} }

        /// <summary>
        ///  OBS 2 (copilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_obs_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> nav2_obs_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_obs_deg_mag_copilot");} }

        /// <summary>
        ///  OBS N (copilot isde) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav_obs_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_obs_deg_mag_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_obs_deg_mag_copilot");} }

        /// <summary>
        ///  CARD selection for ADF 1, pilot side, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> adf1_card_heading_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_pilot");} }

        /// <summary>
        ///  CARD selection for ADF 2, pilot side, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> adf2_card_heading_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_pilot");} }

        /// <summary>
        ///  CARD selection for ADF 1, copilot side, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> adf1_card_heading_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf1_card_heading_deg_mag_copilot");} }

        /// <summary>
        ///  CARD selection for ADF 2, copilot side, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> adf2_card_heading_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/adf2_card_heading_deg_mag_copilot");} }

        /// <summary>
        ///  Selected course based on nav1, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_course_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> nav1_course_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_course_deg_mag_pilot");} }

        /// <summary>
        ///  Selected course based on nav2, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_course_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> nav2_course_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_course_deg_mag_pilot");} }

        /// <summary>
        ///  Selected course based on navN, pilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav_course_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float[]> nav_course_deg_mag_pilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_course_deg_mag_pilot");} }

        /// <summary>
        ///  Selected course based on nav1, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_course_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> nav1_course_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav1_course_deg_mag_copilot");} }

        /// <summary>
        ///  Selected course based on nav2, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_course_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> nav2_course_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/nav2_course_deg_mag_copilot");} }

        /// <summary>
        ///  Selected course based on navN, copilot, degrees magnetic.  This is OBS for VORs, or localizer heading for ILS. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/nav_course_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float[]> nav_course_deg_mag_copilot { get { return m_data.GetFloatArray("sim/cockpit2/radios/actuators/nav_course_deg_mag_copilot");} }

        /// <summary>
        ///  HSI source to display: 0 for Nav1, 1 for Nav2, 2 for GPS.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/HSI_source_select_pilot
        /// </summary>
        public IXPDataRef<int> HSI_source_select_pilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/hsi_source_select_pilot");} }

        /// <summary>
        ///  HSI source to display: 0 for Nav1, 1 for Nav2, 2 for GPS.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/HSI_source_select_copilot
        /// </summary>
        public IXPDataRef<int> HSI_source_select_copilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/hsi_source_select_copilot");} }

        /// <summary>
        ///  RMI source to display: 0 for Nav1, 1 for Nav2, 2 for GPS.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/RMI_source_select_pilot
        /// </summary>
        public IXPDataRef<int> RMI_source_select_pilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/rmi_source_select_pilot");} }

        /// <summary>
        ///  RMI source to display: 0 for Nav1, 1 for Nav2, 2 for GPS.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/RMI_source_select_copilot
        /// </summary>
        public IXPDataRef<int> RMI_source_select_copilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/rmi_source_select_copilot");} }

        /// <summary>
        ///  RMI is taking ADF (1) or VOR (0).. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/RMI_left_use_adf_pilot
        /// </summary>
        public IXPDataRef<int> RMI_left_use_adf_pilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/rmi_left_use_adf_pilot");} }

        /// <summary>
        ///  RMI is taking ADF (1) or VOR (0).. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/RMI_left_use_adf_copilot
        /// </summary>
        public IXPDataRef<int> RMI_left_use_adf_copilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/rmi_left_use_adf_copilot");} }

        /// <summary>
        ///  RMI is taking ADF (1) or VOR (0).. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/RMI_right_use_adf_pilot
        /// </summary>
        public IXPDataRef<int> RMI_right_use_adf_pilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/rmi_right_use_adf_pilot");} }

        /// <summary>
        ///  RMI is taking ADF (1) or VOR (0).. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/RMI_right_use_adf_copilot
        /// </summary>
        public IXPDataRef<int> RMI_right_use_adf_copilot { get { return m_data.GetInt("sim/cockpit2/radios/actuators/rmi_right_use_adf_copilot");} }

        /// <summary>
        ///  DME display mode, where 0 is remote, 1 is frequency, and 2 is groundspeed-time.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/DME_mode
        /// </summary>
        public IXPDataRef<int> DME_mode { get { return m_data.GetInt("sim/cockpit2/radios/actuators/dme_mode");} }

        /// <summary>
        ///  DME display selection of what NAV radio to display. 0 for Nav1, 1for Nav2.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/DME_slave_source
        /// </summary>
        public IXPDataRef<int> DME_slave_source { get { return m_data.GetInt("sim/cockpit2/radios/actuators/dme_slave_source");} }

        /// <summary>
        ///  Frequency-to-change selection for the all-in-one radio, 0->5 are Nav1, Nav2, Com1, Com2, ADF1, ADF2.. Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/nav_com_adf_mode
        /// </summary>
        public IXPDataRef<int> nav_com_adf_mode { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav_com_adf_mode");} }

        /// <summary>
        ///  Current Transponder code (0000-7777). Units:transponder_code
        ///  Raw path: sim/cockpit2/radios/actuators/transponder_code
        /// </summary>
        public IXPDataRef<int> transponder_code { get { return m_data.GetInt("sim/cockpit2/radios/actuators/transponder_code");} }

        /// <summary>
        ///  Transponder mode (off=0,stdby=1,on=2,test=3). Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/transponder_mode
        /// </summary>
        public IXPDataRef<int> transponder_mode { get { return m_data.GetInt("sim/cockpit2/radios/actuators/transponder_mode");} }

        /// <summary>
        ///  . Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/audio_com_selection
        /// </summary>
        public IXPDataRef<int> audio_com_selection { get { return m_data.GetInt("sim/cockpit2/radios/actuators/audio_com_selection");} }

        /// <summary>
        ///  . Units:enum
        ///  Raw path: sim/cockpit2/radios/actuators/audio_nav_selection
        /// </summary>
        public IXPDataRef<int> audio_nav_selection { get { return m_data.GetInt("sim/cockpit2/radios/actuators/audio_nav_selection");} }

        /// <summary>
        ///  is com1 selected for listening. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_selection_com1
        /// </summary>
        public IXPDataRef<bool> audio_selection_com1 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_com1");} }

        /// <summary>
        ///  is com2 selected for listening. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_selection_com2
        /// </summary>
        public IXPDataRef<bool> audio_selection_com2 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_com2");} }

        /// <summary>
        ///  is nav1 selected for listening. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_selection_nav1
        /// </summary>
        public IXPDataRef<bool> audio_selection_nav1 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_nav1");} }

        /// <summary>
        ///  is nav2 selected for listening. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_selection_nav2
        /// </summary>
        public IXPDataRef<bool> audio_selection_nav2 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_nav2");} }

        /// <summary>
        ///  is adf1 selected for listening. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_selection_adf1
        /// </summary>
        public IXPDataRef<bool> audio_selection_adf1 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_adf1");} }

        /// <summary>
        ///  is adf2 selected for listening. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_selection_adf2
        /// </summary>
        public IXPDataRef<bool> audio_selection_adf2 { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_selection_adf2");} }

        /// <summary>
        ///  Is DME audio enabled?  This only matters if the current selection has DME. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_dme_enabled
        /// </summary>
        public IXPDataRef<bool> audio_dme_enabled { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_dme_enabled");} }

        /// <summary>
        ///  Is audio for the marker beacons enabled?. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/audio_marker_enabled
        /// </summary>
        public IXPDataRef<bool> audio_marker_enabled { get { return m_data.GetBool("sim/cockpit2/radios/actuators/audio_marker_enabled");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for com1 audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_com1
        /// </summary>
        public IXPDataRef<float> audio_volume_com1 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_com1");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for com2 audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_com2
        /// </summary>
        public IXPDataRef<float> audio_volume_com2 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_com2");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for nav1 audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_nav1
        /// </summary>
        public IXPDataRef<float> audio_volume_nav1 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_nav1");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for nav2 audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_nav2
        /// </summary>
        public IXPDataRef<float> audio_volume_nav2 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_nav2");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for adf1 audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_adf1
        /// </summary>
        public IXPDataRef<float> audio_volume_adf1 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_adf1");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for adf2 audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_adf2
        /// </summary>
        public IXPDataRef<float> audio_volume_adf2 { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_adf2");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for dme audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_dme
        /// </summary>
        public IXPDataRef<float> audio_volume_dme { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_dme");} }

        /// <summary>
        ///  Audio level (0 is off, 1 is max) for marker beacon audio. Units:[0..1]
        ///  Raw path: sim/cockpit2/radios/actuators/audio_volume_mark
        /// </summary>
        public IXPDataRef<float> audio_volume_mark { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/audio_volume_mark");} }

        /// <summary>
        ///  HSI OBS (pilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/hsi_obs_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> hsi_obs_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/hsi_obs_deg_mag_pilot");} }

        /// <summary>
        ///  HSI OBS (copilot side) selection, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/radios/actuators/hsi_obs_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> hsi_obs_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/radios/actuators/hsi_obs_deg_mag_copilot");} }

        /// <summary>
        ///  Left Nav radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav1_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_left_frequency_hz");} }

        /// <summary>
        ///  Left Nav radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav2_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_left_frequency_hz");} }

        /// <summary>
        ///  Left Com radio 1 frequency, 10 hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> com1_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_left_frequency_hz");} }

        /// <summary>
        ///  Left Nav radio 1 frequency, hz, supports 8.3 khz spacing. Units:hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_left_frequency_hz_833
        /// </summary>
        public IXPDataRef<int> com1_left_frequency_hz_833 { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_left_frequency_hz_833");} }

        /// <summary>
        ///  Left Com radio 2 frequency, 10 hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> com2_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_left_frequency_hz");} }

        /// <summary>
        ///  Left Nav radio 2 frequency, hz, supports 8.3 khz spacing. Units:hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_left_frequency_hz_833
        /// </summary>
        public IXPDataRef<int> com2_left_frequency_hz_833 { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_left_frequency_hz_833");} }

        /// <summary>
        ///  Left ADF radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf1_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf1_left_frequency_hz");} }

        /// <summary>
        ///  Left ADF radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf2_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf2_left_frequency_hz");} }

        /// <summary>
        ///  Left DME radio frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/dme_left_frequency_hz
        /// </summary>
        public IXPDataRef<int> dme_left_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/dme_left_frequency_hz");} }

        /// <summary>
        ///  Right Nav radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav1_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav1_right_frequency_hz");} }

        /// <summary>
        ///  Right Nav radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> nav2_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/nav2_right_frequency_hz");} }

        /// <summary>
        ///  Right Com radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com1_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> com1_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com1_right_frequency_hz");} }

        /// <summary>
        ///  Right Com radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/com2_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> com2_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/com2_right_frequency_hz");} }

        /// <summary>
        ///  Right ADF radio 1 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf1_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf1_right_frequency_hz");} }

        /// <summary>
        ///  Right ADF radio 2 frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> adf2_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/adf2_right_frequency_hz");} }

        /// <summary>
        ///  Right DME radio frequency, hz. Units:10hertz
        ///  Raw path: sim/cockpit2/radios/actuators/dme_right_frequency_hz
        /// </summary>
        public IXPDataRef<int> dme_right_frequency_hz { get { return m_data.GetInt("sim/cockpit2/radios/actuators/dme_right_frequency_hz");} }

        /// <summary>
        ///  1 if right nav 1 radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/nav1_right_is_selected
        /// </summary>
        public IXPDataRef<bool> nav1_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav1_right_is_selected");} }

        /// <summary>
        ///  1 if right nav 2 radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/nav2_right_is_selected
        /// </summary>
        public IXPDataRef<bool> nav2_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/nav2_right_is_selected");} }

        /// <summary>
        ///  1 if right com 1 radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/com1_right_is_selected
        /// </summary>
        public IXPDataRef<bool> com1_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com1_right_is_selected");} }

        /// <summary>
        ///  1 if right com 2 radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/com2_right_is_selected
        /// </summary>
        public IXPDataRef<bool> com2_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/com2_right_is_selected");} }

        /// <summary>
        ///  1 if right adf 1 radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/adf1_right_is_selected
        /// </summary>
        public IXPDataRef<bool> adf1_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/adf1_right_is_selected");} }

        /// <summary>
        ///  1 if right adf 2 radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/adf2_right_is_selected
        /// </summary>
        public IXPDataRef<bool> adf2_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/adf2_right_is_selected");} }

        /// <summary>
        ///  1 if right DME radio is selected, 0 if left is selected. Units:boolean
        ///  Raw path: sim/cockpit2/radios/actuators/dme_right_is_selected
        /// </summary>
        public IXPDataRef<bool> dme_right_is_selected { get { return m_data.GetBool("sim/cockpit2/radios/actuators/dme_right_is_selected");} }
    }
}