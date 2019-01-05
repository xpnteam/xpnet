using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_PressurizationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_PressurizationDatarefs(IXPlaneData data)
        {
            m_data = data;
            Actuators = new Sim_Cockpit2_Pressurization_ActuatorsDatarefs(data);
            Indicators = new Sim_Cockpit2_Pressurization_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Pressurization_ActuatorsDatarefs Actuators { get; }
        public Sim_Cockpit2_Pressurization_IndicatorsDatarefs Indicators { get; }
    }
}