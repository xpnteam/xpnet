using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}