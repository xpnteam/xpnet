using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_PressureDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_PressureDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}