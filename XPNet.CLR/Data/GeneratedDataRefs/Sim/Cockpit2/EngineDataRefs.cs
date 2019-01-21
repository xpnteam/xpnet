using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_engineDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_engineDataRefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_engine_actuatorsDataRefs(data);
            indicators = new sim_cockpit2_engine_indicatorsDataRefs(data);
        }
        public sim_cockpit2_engine_actuatorsDataRefs actuators { get; }
        public sim_cockpit2_engine_indicatorsDataRefs indicators { get; }
    }
}