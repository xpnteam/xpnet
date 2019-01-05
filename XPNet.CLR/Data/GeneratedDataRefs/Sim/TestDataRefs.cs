using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_TestDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_TestDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}