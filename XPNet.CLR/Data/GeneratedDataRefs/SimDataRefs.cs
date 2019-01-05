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
            Aircraft = new Sim_AircraftDatarefs(data);
            Cockpit = new Sim_CockpitDatarefs(data);
            Flightmodel = new Sim_FlightmodelDatarefs(data);
            Graphics = new Sim_GraphicsDatarefs(data);
            Joystick = new Sim_JoystickDatarefs(data);
            Multiplayer = new Sim_MultiplayerDatarefs(data);
            Network = new Sim_NetworkDatarefs(data);
            Physics = new Sim_PhysicsDatarefs(data);
            Operation = new Sim_OperationDatarefs(data);
            Test = new Sim_TestDatarefs(data);
            Time = new Sim_TimeDatarefs(data);
            Version = new Sim_VersionDatarefs(data);
            Weapons = new Sim_WeaponsDatarefs(data);
            Weather = new Sim_WeatherDatarefs(data);
            World = new Sim_WorldDatarefs(data);
            Aircraft2 = new Sim_Aircraft2Datarefs(data);
            Cockpit2 = new Sim_Cockpit2Datarefs(data);
            Flightmodel2 = new Sim_Flightmodel2Datarefs(data);
        }
        public Sim_AircraftDatarefs Aircraft { get; }
        public Sim_CockpitDatarefs Cockpit { get; }
        public Sim_FlightmodelDatarefs Flightmodel { get; }
        public Sim_GraphicsDatarefs Graphics { get; }
        public Sim_JoystickDatarefs Joystick { get; }
        public Sim_MultiplayerDatarefs Multiplayer { get; }
        public Sim_NetworkDatarefs Network { get; }
        public Sim_PhysicsDatarefs Physics { get; }
        public Sim_OperationDatarefs Operation { get; }
        public Sim_TestDatarefs Test { get; }
        public Sim_TimeDatarefs Time { get; }
        public Sim_VersionDatarefs Version { get; }
        public Sim_WeaponsDatarefs Weapons { get; }
        public Sim_WeatherDatarefs Weather { get; }
        public Sim_WorldDatarefs World { get; }
        public Sim_Aircraft2Datarefs Aircraft2 { get; }
        public Sim_Cockpit2Datarefs Cockpit2 { get; }
        public Sim_Flightmodel2Datarefs Flightmodel2 { get; }
    }
}