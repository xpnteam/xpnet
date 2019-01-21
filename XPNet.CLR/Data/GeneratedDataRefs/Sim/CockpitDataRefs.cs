using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpitDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpitDataRefs(IXPlaneData data)
        {
            m_data = data;
            autopilot = new sim_cockpit_autopilotDataRefs(data);
            electrical = new sim_cockpit_electricalDataRefs(data);
            engine = new sim_cockpit_engineDataRefs(data);
            g430 = new sim_cockpit_g430DataRefs(data);
            gyros = new sim_cockpit_gyrosDataRefs(data);
            misc = new sim_cockpit_miscDataRefs(data);
            pressure = new sim_cockpit_pressureDataRefs(data);
            radios = new sim_cockpit_radiosDataRefs(data);
            switches = new sim_cockpit_switchesDataRefs(data);
            warnings = new sim_cockpit_warningsDataRefs(data);
        }
        public sim_cockpit_autopilotDataRefs autopilot { get; }
        public sim_cockpit_electricalDataRefs electrical { get; }
        public sim_cockpit_engineDataRefs engine { get; }
        public sim_cockpit_g430DataRefs g430 { get; }
        public sim_cockpit_gyrosDataRefs gyros { get; }
        public sim_cockpit_miscDataRefs misc { get; }
        public sim_cockpit_pressureDataRefs pressure { get; }
        public sim_cockpit_radiosDataRefs radios { get; }
        public sim_cockpit_switchesDataRefs switches { get; }
        public sim_cockpit_warningsDataRefs warnings { get; }
    }
}