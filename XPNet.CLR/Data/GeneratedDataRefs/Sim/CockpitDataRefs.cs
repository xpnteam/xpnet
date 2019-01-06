using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpitDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpitDatarefs(IXPlaneData data)
        {
            m_data = data;
            autopilot = new sim_cockpit_autopilotDatarefs(data);
            electrical = new sim_cockpit_electricalDatarefs(data);
            engine = new sim_cockpit_engineDatarefs(data);
            g430 = new sim_cockpit_g430Datarefs(data);
            gyros = new sim_cockpit_gyrosDatarefs(data);
            misc = new sim_cockpit_miscDatarefs(data);
            pressure = new sim_cockpit_pressureDatarefs(data);
            radios = new sim_cockpit_radiosDatarefs(data);
            switches = new sim_cockpit_switchesDatarefs(data);
            warnings = new sim_cockpit_warningsDatarefs(data);
        }
        public sim_cockpit_autopilotDatarefs autopilot { get; }
        public sim_cockpit_electricalDatarefs electrical { get; }
        public sim_cockpit_engineDatarefs engine { get; }
        public sim_cockpit_g430Datarefs g430 { get; }
        public sim_cockpit_gyrosDatarefs gyros { get; }
        public sim_cockpit_miscDatarefs misc { get; }
        public sim_cockpit_pressureDatarefs pressure { get; }
        public sim_cockpit_radiosDatarefs radios { get; }
        public sim_cockpit_switchesDatarefs switches { get; }
        public sim_cockpit_warningsDatarefs warnings { get; }
    }
}