using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_engineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_engineDatarefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_engine_actuatorsDatarefs(data);
            indicators = new sim_cockpit2_engine_indicatorsDatarefs(data);
        }
        public sim_cockpit2_engine_actuatorsDatarefs actuators { get; }
        public sim_cockpit2_engine_indicatorsDatarefs indicators { get; }
    }
}