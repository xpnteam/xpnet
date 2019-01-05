using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_World_WinchDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_World_WinchDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}