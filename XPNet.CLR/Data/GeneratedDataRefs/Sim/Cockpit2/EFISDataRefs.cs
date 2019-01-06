using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_EFISDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_EFISDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Map mode. 0=approach, 1=vor,2=map,3=nav,4=plan
        /// </summary>
        public IXPDataRef<int> map_mode { get { return m_data.GetInt("sim/cockpit2/efis/map_mode");} }

        /// <summary>
        ///  Map is in HSI mode, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> map_mode_is_HSI { get { return m_data.GetBool("sim/cockpit2/efis/map_mode_is_hsi");} }

        /// <summary>
        ///  Map range, 1->6, where 6 is the longest range.
        /// </summary>
        public IXPDataRef<int> map_range { get { return m_data.GetInt("sim/cockpit2/efis/map_range");} }

        /// <summary>
        ///  Argus mode, 7=departure,8=enroute,9=approach,10=radar_on
        /// </summary>
        public IXPDataRef<int> argus_mode { get { return m_data.GetInt("sim/cockpit2/efis/argus_mode");} }

        /// <summary>
        ///  ECAM mode, 0=engine,1=fuel,2=controls,3=hydraulics,4=failures
        /// </summary>
        public IXPDataRef<int> ecam_mode { get { return m_data.GetInt("sim/cockpit2/efis/ecam_mode");} }

        /// <summary>
        ///  On the moving map, show the weather or not.
        /// </summary>
        public IXPDataRef<bool> EFIS_weather_on { get { return m_data.GetBool("sim/cockpit2/efis/efis_weather_on");} }

        /// <summary>
        ///  On the moving map, show the TCAS or not.
        /// </summary>
        public IXPDataRef<bool> EFIS_tcas_on { get { return m_data.GetBool("sim/cockpit2/efis/efis_tcas_on");} }

        /// <summary>
        ///  On the moving map, show the airports or not.
        /// </summary>
        public IXPDataRef<bool> EFIS_airport_on { get { return m_data.GetBool("sim/cockpit2/efis/efis_airport_on");} }

        /// <summary>
        ///  On the moving map, show the fixes or not.
        /// </summary>
        public IXPDataRef<bool> EFIS_fix_on { get { return m_data.GetBool("sim/cockpit2/efis/efis_fix_on");} }

        /// <summary>
        ///  On the moving map, show the VORs or not.
        /// </summary>
        public IXPDataRef<bool> EFIS_vor_on { get { return m_data.GetBool("sim/cockpit2/efis/efis_vor_on");} }

        /// <summary>
        ///  On the moving map, show the NDBs or not.
        /// </summary>
        public IXPDataRef<bool> EFIS_ndb_on { get { return m_data.GetBool("sim/cockpit2/efis/efis_ndb_on");} }

        /// <summary>
        ///  EFIS waypoint 1 is showing: 0=ADF1, 1=OFF, or 2=VOR1 -- Pilot
        /// </summary>
        public IXPDataRef<int> EFIS_1_selection_pilot { get { return m_data.GetInt("sim/cockpit2/efis/efis_1_selection_pilot");} }

        /// <summary>
        ///  EFIS waypoint 2 is showing: 0=ADF1, 1=OFF, or 2=VOR1 -- Copilot
        /// </summary>
        public IXPDataRef<int> EFIS_1_selection_copilot { get { return m_data.GetInt("sim/cockpit2/efis/efis_1_selection_copilot");} }

        /// <summary>
        ///  EFIS waypoint 1 is showing: 0=ADF2, 1=OFF, or 2=VOR2 -- Pilot
        /// </summary>
        public IXPDataRef<int> EFIS_2_selection_pilot { get { return m_data.GetInt("sim/cockpit2/efis/efis_2_selection_pilot");} }

        /// <summary>
        ///  EFIS waypoint 2 is showing: 0=ADF2, 1=OFF, or 2=VOR2 -- Copilot
        /// </summary>
        public IXPDataRef<int> EFIS_2_selection_copilot { get { return m_data.GetInt("sim/cockpit2/efis/efis_2_selection_copilot");} }

        /// <summary>
        ///  An array of EFIS page switches for selecting which EFIS page is visible.
        /// </summary>
        public IXPDataRef<bool[]> EFIS_page { get { return m_data.GetBoolArray("sim/cockpit2/efis/efis_page");} }
    }
}