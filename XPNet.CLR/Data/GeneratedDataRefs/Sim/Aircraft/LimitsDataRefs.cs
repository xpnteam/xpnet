using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_LimitsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_LimitsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}