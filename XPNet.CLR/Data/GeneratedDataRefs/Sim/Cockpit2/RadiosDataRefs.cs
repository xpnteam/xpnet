using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_radiosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_radiosDatarefs(IXPlaneData data)
        {
            m_data = data;
            actuators = new sim_cockpit2_radios_actuatorsDatarefs(data);
            indicators = new sim_cockpit2_radios_indicatorsDatarefs(data);
        }
        public sim_cockpit2_radios_actuatorsDatarefs actuators { get; }
        public sim_cockpit2_radios_indicatorsDatarefs indicators { get; }
    }
}