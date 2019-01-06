using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft2_engineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft2_engineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the idle ratio for the engines at low idle.  1.0 provides default behavior; this can be any number greater than zero.. Units:multiplier
        ///  Raw path: sim/aircraft2/engine/low_idle_ratio
        /// </summary>
        public IXPDataRef<float> low_idle_ratio { get { return m_data.GetFloat("sim/aircraft2/engine/low_idle_ratio");} }

        /// <summary>
        ///  This is the idle ratio for the engines at high idle. 1.0 provides default behavior; this can be any number greater than zero.. Units:multiplier
        ///  Raw path: sim/aircraft2/engine/high_idle_ratio
        /// </summary>
        public IXPDataRef<float> high_idle_ratio { get { return m_data.GetFloat("sim/aircraft2/engine/high_idle_ratio");} }
    }
}