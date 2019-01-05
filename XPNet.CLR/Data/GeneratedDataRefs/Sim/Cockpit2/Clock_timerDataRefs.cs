using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Clock_timerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Clock_timerDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}