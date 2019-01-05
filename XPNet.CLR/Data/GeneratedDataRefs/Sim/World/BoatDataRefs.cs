using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_World_BoatDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_World_BoatDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}