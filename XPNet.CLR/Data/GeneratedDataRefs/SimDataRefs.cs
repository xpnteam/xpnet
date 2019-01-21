using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class SimDataRefs
    {
        private readonly IXPlaneData m_data;

        internal SimDataRefs(IXPlaneData data)
        {
            m_data = data;
            aircraft = new sim_aircraftDataRefs(data);
            cockpit = new sim_cockpitDataRefs(data);
            flightmodel = new sim_flightmodelDataRefs(data);
            graphics = new sim_graphicsDataRefs(data);
            joystick = new sim_joystickDataRefs(data);
            multiplayer = new sim_multiplayerDataRefs(data);
            network = new sim_networkDataRefs(data);
            physics = new sim_physicsDataRefs(data);
            operation = new sim_operationDataRefs(data);
            test = new sim_testDataRefs(data);
            time = new sim_timeDataRefs(data);
            version = new sim_versionDataRefs(data);
            weapons = new sim_weaponsDataRefs(data);
            weather = new sim_weatherDataRefs(data);
            world = new sim_worldDataRefs(data);
            aircraft2 = new sim_aircraft2DataRefs(data);
            cockpit2 = new sim_cockpit2DataRefs(data);
            flightmodel2 = new sim_flightmodel2DataRefs(data);
        }
        public sim_aircraftDataRefs aircraft { get; }
        public sim_cockpitDataRefs cockpit { get; }
        public sim_flightmodelDataRefs flightmodel { get; }
        public sim_graphicsDataRefs graphics { get; }
        public sim_joystickDataRefs joystick { get; }
        public sim_multiplayerDataRefs multiplayer { get; }
        public sim_networkDataRefs network { get; }
        public sim_physicsDataRefs physics { get; }
        public sim_operationDataRefs operation { get; }
        public sim_testDataRefs test { get; }
        public sim_timeDataRefs time { get; }
        public sim_versionDataRefs version { get; }
        public sim_weaponsDataRefs weapons { get; }
        public sim_weatherDataRefs weather { get; }
        public sim_worldDataRefs world { get; }
        public sim_aircraft2DataRefs aircraft2 { get; }
        public sim_cockpit2DataRefs cockpit2 { get; }
        public sim_flightmodel2DataRefs flightmodel2 { get; }
    }
}