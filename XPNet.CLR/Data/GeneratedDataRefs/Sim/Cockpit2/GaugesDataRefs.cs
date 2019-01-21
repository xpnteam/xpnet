using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_gaugesDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_gaugesDataRefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_gauges_actuatorsDataRefs(data);
            indicators = new sim_cockpit2_gauges_indicatorsDataRefs(data);
        }
        public sim_cockpit2_gauges_actuatorsDataRefs actuators { get; }
        public sim_cockpit2_gauges_indicatorsDataRefs indicators { get; }
    }
}