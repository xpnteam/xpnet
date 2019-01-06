using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_EFISDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_EFISDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Map is in HSI mode, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Map_mode_is_HSI { get { return m_data.GetBool("sim/cockpit2/efis/map_mode_is_hsi");} }

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
        ///  An array of EFIS page switches for selecting which EFIS page is visible.
        /// </summary>
        public IXPDataRef<bool[]> EFIS_page { get { return m_data.GetBoolArray("sim/cockpit2/efis/efis_page");} }
    }
}