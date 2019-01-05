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
        ///  current selected navID - nav radio 1
        /// </summary>
        public IXPDataRef<string> Nav1_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav1_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 2
        /// </summary>
        public IXPDataRef<string> Nav2_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav2_nav_id");

        /// <summary>
        ///  current selected navID - ADF 1
        /// </summary>
        public IXPDataRef<string> Adf1_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/adf1_nav_id");

        /// <summary>
        ///  current selected navID - ADF 2
        /// </summary>
        public IXPDataRef<string> Adf2_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/adf2_nav_id");

        /// <summary>
        ///  current selected navID - GPS 1
        /// </summary>
        public IXPDataRef<string> Gps_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/gps_nav_id");

        /// <summary>
        ///  current selected navID - GPS 2
        /// </summary>
        public IXPDataRef<string> Gps2_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/gps2_nav_id");

        /// <summary>
        ///  current selected navID - DME
        /// </summary>
        public IXPDataRef<string> Dme_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/dme_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 3
        /// </summary>
        public IXPDataRef<string> Nav3_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav3_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 4
        /// </summary>
        public IXPDataRef<string> Nav4_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav4_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 5
        /// </summary>
        public IXPDataRef<string> Nav5_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav5_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 6
        /// </summary>
        public IXPDataRef<string> Nav6_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav6_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 7
        /// </summary>
        public IXPDataRef<string> Nav7_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav7_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 8
        /// </summary>
        public IXPDataRef<string> Nav8_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav8_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 9
        /// </summary>
        public IXPDataRef<string> Nav9_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav9_nav_id");

        /// <summary>
        ///  current selected navID - nav radio 10
        /// </summary>
        public IXPDataRef<string> Nav10_nav_id => m_data.GetString("sim/cockpit2/radios/indicators/nav10_nav_id");

        /// <summary>
        ///  Whether we are squawking ident right now.
        /// </summary>
        public IXPDataRef<bool> Transponder_id => m_data.GetBool("sim/cockpit2/radios/indicators/transponder_id");
    }
}