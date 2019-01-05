using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_WeightDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_WeightDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}