using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2Datarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2Datarefs(IXPlaneData data)
        {
            m_data = data;
            controls = new sim_flightmodel2_controlsDatarefs(data);
            doors = new sim_flightmodel2_doorsDatarefs(data);
            engines = new sim_flightmodel2_enginesDatarefs(data);
            gear = new sim_flightmodel2_gearDatarefs(data);
            lights = new sim_flightmodel2_lightsDatarefs(data);
            misc = new sim_flightmodel2_miscDatarefs(data);
            wing = new sim_flightmodel2_wingDatarefs(data);
        }
        public sim_flightmodel2_controlsDatarefs controls { get; }
        public sim_flightmodel2_doorsDatarefs doors { get; }
        public sim_flightmodel2_enginesDatarefs engines { get; }
        public sim_flightmodel2_gearDatarefs gear { get; }
        public sim_flightmodel2_lightsDatarefs lights { get; }
        public sim_flightmodel2_miscDatarefs misc { get; }
        public sim_flightmodel2_wingDatarefs wing { get; }
    }
}