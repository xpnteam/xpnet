using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2DataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2DataRefs(IXPlaneData data)
        {
            m_data = data;
            annunciators = new sim_cockpit2_annunciatorsDataRefs(data);
            autopilot = new sim_cockpit2_autopilotDataRefs(data);
            camera = new sim_cockpit2_cameraDataRefs(data);
            clock_timer = new sim_cockpit2_clock_timerDataRefs(data);
            controls = new sim_cockpit2_controlsDataRefs(data);
            EFIS = new sim_cockpit2_EFISDataRefs(data);
            electrical = new sim_cockpit2_electricalDataRefs(data);
            engine = new sim_cockpit2_engineDataRefs(data);
            fuel = new sim_cockpit2_fuelDataRefs(data);
            gauges = new sim_cockpit2_gaugesDataRefs(data);
            hydraulics = new sim_cockpit2_hydraulicsDataRefs(data);
            ice = new sim_cockpit2_iceDataRefs(data);
            pressurization = new sim_cockpit2_pressurizationDataRefs(data);
            radios = new sim_cockpit2_radiosDataRefs(data);
            switches = new sim_cockpit2_switchesDataRefs(data);
            tcas = new sim_cockpit2_tcasDataRefs(data);
            temperature = new sim_cockpit2_temperatureDataRefs(data);
            transmissions = new sim_cockpit2_transmissionsDataRefs(data);
            weapons = new sim_cockpit2_weaponsDataRefs(data);
        }
        public sim_cockpit2_annunciatorsDataRefs annunciators { get; }
        public sim_cockpit2_autopilotDataRefs autopilot { get; }
        public sim_cockpit2_cameraDataRefs camera { get; }
        public sim_cockpit2_clock_timerDataRefs clock_timer { get; }
        public sim_cockpit2_controlsDataRefs controls { get; }
        public sim_cockpit2_EFISDataRefs EFIS { get; }
        public sim_cockpit2_electricalDataRefs electrical { get; }
        public sim_cockpit2_engineDataRefs engine { get; }
        public sim_cockpit2_fuelDataRefs fuel { get; }
        public sim_cockpit2_gaugesDataRefs gauges { get; }
        public sim_cockpit2_hydraulicsDataRefs hydraulics { get; }
        public sim_cockpit2_iceDataRefs ice { get; }
        public sim_cockpit2_pressurizationDataRefs pressurization { get; }
        public sim_cockpit2_radiosDataRefs radios { get; }
        public sim_cockpit2_switchesDataRefs switches { get; }
        public sim_cockpit2_tcasDataRefs tcas { get; }
        public sim_cockpit2_temperatureDataRefs temperature { get; }
        public sim_cockpit2_transmissionsDataRefs transmissions { get; }
        public sim_cockpit2_weaponsDataRefs weapons { get; }
    }
}