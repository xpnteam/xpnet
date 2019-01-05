using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2Datarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2Datarefs(IXPlaneData data)
        {
            m_data = data;
            Controls = new Sim_Flightmodel2_ControlsDatarefs(data);
            Doors = new Sim_Flightmodel2_DoorsDatarefs(data);
            Engines = new Sim_Flightmodel2_EnginesDatarefs(data);
            Gear = new Sim_Flightmodel2_GearDatarefs(data);
            Lights = new Sim_Flightmodel2_LightsDatarefs(data);
            Misc = new Sim_Flightmodel2_MiscDatarefs(data);
            Wing = new Sim_Flightmodel2_WingDatarefs(data);
        }
        public Sim_Flightmodel2_ControlsDatarefs Controls { get; }
        public Sim_Flightmodel2_DoorsDatarefs Doors { get; }
        public Sim_Flightmodel2_EnginesDatarefs Engines { get; }
        public Sim_Flightmodel2_GearDatarefs Gear { get; }
        public Sim_Flightmodel2_LightsDatarefs Lights { get; }
        public Sim_Flightmodel2_MiscDatarefs Misc { get; }
        public Sim_Flightmodel2_WingDatarefs Wing { get; }
    }
}