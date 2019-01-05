using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
            Actuators = new Sim_Cockpit2_Engine_ActuatorsDatarefs(data);
            Indicators = new Sim_Cockpit2_Engine_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Engine_ActuatorsDatarefs Actuators { get; }
        public Sim_Cockpit2_Engine_IndicatorsDatarefs Indicators { get; }
    }
}