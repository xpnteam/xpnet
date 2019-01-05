using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_GaugesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_GaugesDatarefs(IXPlaneData data)
        {
            m_data = data;
            Actuators = new Sim_Cockpit2_Gauges_ActuatorsDatarefs(data);
            Indicators = new Sim_Cockpit2_Gauges_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Gauges_ActuatorsDatarefs Actuators { get; }
        public Sim_Cockpit2_Gauges_IndicatorsDatarefs Indicators { get; }
    }
}