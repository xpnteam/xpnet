using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_TimeDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_TimeDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}