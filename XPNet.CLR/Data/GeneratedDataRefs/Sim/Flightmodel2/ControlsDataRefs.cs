using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_ControlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_ControlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}