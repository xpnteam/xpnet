using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_CockpitDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_CockpitDatarefs(IXPlaneData data)
        {
            m_data = data;
            Autopilot = new Sim_Cockpit_AutopilotDatarefs(data);
            Electrical = new Sim_Cockpit_ElectricalDatarefs(data);
            Engine = new Sim_Cockpit_EngineDatarefs(data);
            G430 = new Sim_Cockpit_G430Datarefs(data);
            Gyros = new Sim_Cockpit_GyrosDatarefs(data);
            Misc = new Sim_Cockpit_MiscDatarefs(data);
            Pressure = new Sim_Cockpit_PressureDatarefs(data);
            Radios = new Sim_Cockpit_RadiosDatarefs(data);
            Switches = new Sim_Cockpit_SwitchesDatarefs(data);
            Warnings = new Sim_Cockpit_WarningsDatarefs(data);
        }
        public Sim_Cockpit_AutopilotDatarefs Autopilot { get; }
        public Sim_Cockpit_ElectricalDatarefs Electrical { get; }
        public Sim_Cockpit_EngineDatarefs Engine { get; }
        public Sim_Cockpit_G430Datarefs G430 { get; }
        public Sim_Cockpit_GyrosDatarefs Gyros { get; }
        public Sim_Cockpit_MiscDatarefs Misc { get; }
        public Sim_Cockpit_PressureDatarefs Pressure { get; }
        public Sim_Cockpit_RadiosDatarefs Radios { get; }
        public Sim_Cockpit_SwitchesDatarefs Switches { get; }
        public Sim_Cockpit_WarningsDatarefs Warnings { get; }
    }
}