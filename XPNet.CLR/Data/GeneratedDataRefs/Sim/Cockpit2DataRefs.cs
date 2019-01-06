using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2Datarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2Datarefs(IXPlaneData data)
        {
            m_data = data;
            annunciators = new sim_cockpit2_annunciatorsDatarefs(data);
            autopilot = new sim_cockpit2_autopilotDatarefs(data);
            camera = new sim_cockpit2_cameraDatarefs(data);
            clock_timer = new sim_cockpit2_clock_timerDatarefs(data);
            controls = new sim_cockpit2_controlsDatarefs(data);
            EFIS = new sim_cockpit2_EFISDatarefs(data);
            electrical = new sim_cockpit2_electricalDatarefs(data);
            engine = new sim_cockpit2_engineDatarefs(data);
            fuel = new sim_cockpit2_fuelDatarefs(data);
            gauges = new sim_cockpit2_gaugesDatarefs(data);
            hydraulics = new sim_cockpit2_hydraulicsDatarefs(data);
            ice = new sim_cockpit2_iceDatarefs(data);
            pressurization = new sim_cockpit2_pressurizationDatarefs(data);
            radios = new sim_cockpit2_radiosDatarefs(data);
            switches = new sim_cockpit2_switchesDatarefs(data);
            tcas = new sim_cockpit2_tcasDatarefs(data);
            temperature = new sim_cockpit2_temperatureDatarefs(data);
            transmissions = new sim_cockpit2_transmissionsDatarefs(data);
            weapons = new sim_cockpit2_weaponsDatarefs(data);
        }
        public sim_cockpit2_annunciatorsDatarefs annunciators { get; }
        public sim_cockpit2_autopilotDatarefs autopilot { get; }
        public sim_cockpit2_cameraDatarefs camera { get; }
        public sim_cockpit2_clock_timerDatarefs clock_timer { get; }
        public sim_cockpit2_controlsDatarefs controls { get; }
        public sim_cockpit2_EFISDatarefs EFIS { get; }
        public sim_cockpit2_electricalDatarefs electrical { get; }
        public sim_cockpit2_engineDatarefs engine { get; }
        public sim_cockpit2_fuelDatarefs fuel { get; }
        public sim_cockpit2_gaugesDatarefs gauges { get; }
        public sim_cockpit2_hydraulicsDatarefs hydraulics { get; }
        public sim_cockpit2_iceDatarefs ice { get; }
        public sim_cockpit2_pressurizationDatarefs pressurization { get; }
        public sim_cockpit2_radiosDatarefs radios { get; }
        public sim_cockpit2_switchesDatarefs switches { get; }
        public sim_cockpit2_tcasDatarefs tcas { get; }
        public sim_cockpit2_temperatureDatarefs temperature { get; }
        public sim_cockpit2_transmissionsDatarefs transmissions { get; }
        public sim_cockpit2_weaponsDatarefs weapons { get; }
    }
}