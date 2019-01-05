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
    }
}