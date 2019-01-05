using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}