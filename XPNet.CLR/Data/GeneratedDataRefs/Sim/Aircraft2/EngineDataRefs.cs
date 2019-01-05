using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft2_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft2_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the idle ratio for the engines at low idle.  1.0 provides default behavior; this can be any number greater than zero.. Units:multiplier
        /// </summary>
        public IXPDataRef<float> Low_idle_ratio => m_data.GetFloat("sim/aircraft2/engine/low_idle_ratio");

        /// <summary>
        ///  This is the idle ratio for the engines at high idle. 1.0 provides default behavior; this can be any number greater than zero.. Units:multiplier
        /// </summary>
        public IXPDataRef<float> High_idle_ratio => m_data.GetFloat("sim/aircraft2/engine/high_idle_ratio");
    }
}