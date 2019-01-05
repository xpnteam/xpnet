using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_ForcesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_ForcesDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}