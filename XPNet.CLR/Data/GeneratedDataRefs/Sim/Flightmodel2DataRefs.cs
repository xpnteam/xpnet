using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2DataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2DataRefs(IXPlaneData data)
        {
            m_data = data;
            controls = new sim_flightmodel2_controlsDataRefs(data);
            doors = new sim_flightmodel2_doorsDataRefs(data);
            engines = new sim_flightmodel2_enginesDataRefs(data);
            gear = new sim_flightmodel2_gearDataRefs(data);
            lights = new sim_flightmodel2_lightsDataRefs(data);
            misc = new sim_flightmodel2_miscDataRefs(data);
            wing = new sim_flightmodel2_wingDataRefs(data);
        }
        public sim_flightmodel2_controlsDataRefs controls { get; }
        public sim_flightmodel2_doorsDataRefs doors { get; }
        public sim_flightmodel2_enginesDataRefs engines { get; }
        public sim_flightmodel2_gearDataRefs gear { get; }
        public sim_flightmodel2_lightsDataRefs lights { get; }
        public sim_flightmodel2_miscDataRefs misc { get; }
        public sim_flightmodel2_wingDataRefs wing { get; }
    }
}