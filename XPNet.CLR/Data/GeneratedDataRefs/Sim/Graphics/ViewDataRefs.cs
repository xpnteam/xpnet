using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_ViewDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_ViewDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}