using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_tcas_indicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_tcas_indicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Relative bearing of each other plane in degrees for TCAS
        /// </summary>
        public IXPDataRef<float[]> relative_bearing_degs { get { return m_data.GetFloatArray("sim/cockpit2/tcas/indicators/relative_bearing_degs");} }

        /// <summary>
        ///  Distance to each other plane in meters for TCAS
        /// </summary>
        public IXPDataRef<float[]> relative_distance_mtrs { get { return m_data.GetFloatArray("sim/cockpit2/tcas/indicators/relative_distance_mtrs");} }

        /// <summary>
        ///  Relative altitude (positive means above us) for TCAS
        /// </summary>
        public IXPDataRef<float[]> relative_altitude_mtrs { get { return m_data.GetFloatArray("sim/cockpit2/tcas/indicators/relative_altitude_mtrs");} }
    }
}