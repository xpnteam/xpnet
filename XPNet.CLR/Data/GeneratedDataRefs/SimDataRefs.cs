using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class SimDatarefs
    {
        private readonly IXPlaneData m_data;

        internal SimDatarefs(IXPlaneData data)
        {
            m_data = data;
            aircraft = new sim_aircraftDatarefs(data);
            cockpit = new sim_cockpitDatarefs(data);
            flightmodel = new sim_flightmodelDatarefs(data);
            graphics = new sim_graphicsDatarefs(data);
            joystick = new sim_joystickDatarefs(data);
            multiplayer = new sim_multiplayerDatarefs(data);
            network = new sim_networkDatarefs(data);
            physics = new sim_physicsDatarefs(data);
            operation = new sim_operationDatarefs(data);
            test = new sim_testDatarefs(data);
            time = new sim_timeDatarefs(data);
            version = new sim_versionDatarefs(data);
            weapons = new sim_weaponsDatarefs(data);
            weather = new sim_weatherDatarefs(data);
            world = new sim_worldDatarefs(data);
            aircraft2 = new sim_aircraft2Datarefs(data);
            cockpit2 = new sim_cockpit2Datarefs(data);
            flightmodel2 = new sim_flightmodel2Datarefs(data);
        }
        public sim_aircraftDatarefs aircraft { get; }
        public sim_cockpitDatarefs cockpit { get; }
        public sim_flightmodelDatarefs flightmodel { get; }
        public sim_graphicsDatarefs graphics { get; }
        public sim_joystickDatarefs joystick { get; }
        public sim_multiplayerDatarefs multiplayer { get; }
        public sim_networkDatarefs network { get; }
        public sim_physicsDatarefs physics { get; }
        public sim_operationDatarefs operation { get; }
        public sim_testDatarefs test { get; }
        public sim_timeDatarefs time { get; }
        public sim_versionDatarefs version { get; }
        public sim_weaponsDatarefs weapons { get; }
        public sim_weatherDatarefs weather { get; }
        public sim_worldDatarefs world { get; }
        public sim_aircraft2Datarefs aircraft2 { get; }
        public sim_cockpit2Datarefs cockpit2 { get; }
        public sim_flightmodel2Datarefs flightmodel2 { get; }
    }
}