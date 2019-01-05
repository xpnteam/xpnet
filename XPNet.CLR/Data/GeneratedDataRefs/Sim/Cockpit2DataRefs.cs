using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2Datarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2Datarefs(IXPlaneData data)
        {
            m_data = data;
            Annunciators = new Sim_Cockpit2_AnnunciatorsDatarefs(data);
            Autopilot = new Sim_Cockpit2_AutopilotDatarefs(data);
            Camera = new Sim_Cockpit2_CameraDatarefs(data);
            Clock_timer = new Sim_Cockpit2_Clock_timerDatarefs(data);
            Controls = new Sim_Cockpit2_ControlsDatarefs(data);
            EFIS = new Sim_Cockpit2_EFISDatarefs(data);
            Electrical = new Sim_Cockpit2_ElectricalDatarefs(data);
            Engine = new Sim_Cockpit2_EngineDatarefs(data);
            Fuel = new Sim_Cockpit2_FuelDatarefs(data);
            Gauges = new Sim_Cockpit2_GaugesDatarefs(data);
            Hydraulics = new Sim_Cockpit2_HydraulicsDatarefs(data);
            Ice = new Sim_Cockpit2_IceDatarefs(data);
            Pressurization = new Sim_Cockpit2_PressurizationDatarefs(data);
            Radios = new Sim_Cockpit2_RadiosDatarefs(data);
            Switches = new Sim_Cockpit2_SwitchesDatarefs(data);
            Tcas = new Sim_Cockpit2_TcasDatarefs(data);
            Temperature = new Sim_Cockpit2_TemperatureDatarefs(data);
            Transmissions = new Sim_Cockpit2_TransmissionsDatarefs(data);
            Weapons = new Sim_Cockpit2_WeaponsDatarefs(data);
        }
        public Sim_Cockpit2_AnnunciatorsDatarefs Annunciators { get; }
        public Sim_Cockpit2_AutopilotDatarefs Autopilot { get; }
        public Sim_Cockpit2_CameraDatarefs Camera { get; }
        public Sim_Cockpit2_Clock_timerDatarefs Clock_timer { get; }
        public Sim_Cockpit2_ControlsDatarefs Controls { get; }
        public Sim_Cockpit2_EFISDatarefs EFIS { get; }
        public Sim_Cockpit2_ElectricalDatarefs Electrical { get; }
        public Sim_Cockpit2_EngineDatarefs Engine { get; }
        public Sim_Cockpit2_FuelDatarefs Fuel { get; }
        public Sim_Cockpit2_GaugesDatarefs Gauges { get; }
        public Sim_Cockpit2_HydraulicsDatarefs Hydraulics { get; }
        public Sim_Cockpit2_IceDatarefs Ice { get; }
        public Sim_Cockpit2_PressurizationDatarefs Pressurization { get; }
        public Sim_Cockpit2_RadiosDatarefs Radios { get; }
        public Sim_Cockpit2_SwitchesDatarefs Switches { get; }
        public Sim_Cockpit2_TcasDatarefs Tcas { get; }
        public Sim_Cockpit2_TemperatureDatarefs Temperature { get; }
        public Sim_Cockpit2_TransmissionsDatarefs Transmissions { get; }
        public Sim_Cockpit2_WeaponsDatarefs Weapons { get; }
    }
}