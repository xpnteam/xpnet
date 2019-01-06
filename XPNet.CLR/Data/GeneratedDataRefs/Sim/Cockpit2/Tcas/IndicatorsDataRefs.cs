using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Tcas_IndicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Tcas_IndicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Relative bearing of each other plane in degrees for TCAS
        /// </summary>
        public IXPDataRef<float[]> Relative_bearing_degs { get { return m_data.GetFloatArray("sim/cockpit2/tcas/indicators/relative_bearing_degs");} }

        /// <summary>
        ///  Distance to each other plane in meters for TCAS
        /// </summary>
        public IXPDataRef<float[]> Relative_distance_mtrs { get { return m_data.GetFloatArray("sim/cockpit2/tcas/indicators/relative_distance_mtrs");} }

        /// <summary>
        ///  Relative altitude (positive means above us) for TCAS
        /// </summary>
        public IXPDataRef<float[]> Relative_altitude_mtrs { get { return m_data.GetFloatArray("sim/cockpit2/tcas/indicators/relative_altitude_mtrs");} }
    }
}