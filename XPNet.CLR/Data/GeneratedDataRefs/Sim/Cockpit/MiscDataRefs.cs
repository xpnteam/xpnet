using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}