using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_RadiosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_RadiosDatarefs(IXPlaneData data)
        {
            m_data = data;
            Actuators = new Sim_Cockpit2_Radios_ActuatorsDatarefs(data);
            Indicators = new Sim_Cockpit2_Radios_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Radios_ActuatorsDatarefs Actuators { get; }
        public Sim_Cockpit2_Radios_IndicatorsDatarefs Indicators { get; }
    }
}