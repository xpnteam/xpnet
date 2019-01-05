using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_PropDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_PropDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}