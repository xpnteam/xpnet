using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_pressurizationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_pressurizationDatarefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_pressurization_actuatorsDatarefs(data);
            indicators = new sim_cockpit2_pressurization_indicatorsDatarefs(data);
        }
        public sim_cockpit2_pressurization_actuatorsDatarefs actuators { get; }
        public sim_cockpit2_pressurization_indicatorsDatarefs indicators { get; }
    }
}