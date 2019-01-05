using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Network_DataoutDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Network_DataoutDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}