using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_gaugesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_gaugesDatarefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_gauges_actuatorsDatarefs(data);
            indicators = new sim_cockpit2_gauges_indicatorsDatarefs(data);
        }
        public sim_cockpit2_gauges_actuatorsDatarefs actuators { get; }
        public sim_cockpit2_gauges_indicatorsDatarefs indicators { get; }
    }
}