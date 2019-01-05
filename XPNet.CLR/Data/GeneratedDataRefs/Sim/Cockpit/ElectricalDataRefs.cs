using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_ElectricalDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_ElectricalDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}