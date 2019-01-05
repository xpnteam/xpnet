using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_HydraulicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_HydraulicsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Indicators = new Sim_Cockpit2_Hydraulics_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Hydraulics_IndicatorsDatarefs Indicators { get; }
    }
}