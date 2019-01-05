using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_ControlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_ControlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}