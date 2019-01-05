using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_AnnunciatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_AnnunciatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  For aircraft with variable stall warnings, 0 = no stall, 1 = full stall. Units:0..1
        /// </summary>
        public IXPDataRef<float> Stall_warning_ratio => m_data.GetFloat("sim/cockpit2/annunciators/stall_warning_ratio");
    }
}