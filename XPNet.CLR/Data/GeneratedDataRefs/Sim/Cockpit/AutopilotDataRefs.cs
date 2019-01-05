using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_AutopilotDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_AutopilotDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}