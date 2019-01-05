using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_PhysicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_PhysicsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}