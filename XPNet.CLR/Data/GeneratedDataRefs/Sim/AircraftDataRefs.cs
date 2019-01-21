using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraftDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraftDataRefs(IXPlaneData data)
        {
            m_data = data;
            view = new sim_aircraft_viewDataRefs(data);
            forcefeedback = new sim_aircraft_forcefeedbackDataRefs(data);
            electrical = new sim_aircraft_electricalDataRefs(data);
            engine = new sim_aircraft_engineDataRefs(data);
            limits = new sim_aircraft_limitsDataRefs(data);
            prop = new sim_aircraft_propDataRefs(data);
            parts = new sim_aircraft_partsDataRefs(data);
            controls = new sim_aircraft_controlsDataRefs(data);
            gear = new sim_aircraft_gearDataRefs(data);
            weight = new sim_aircraft_weightDataRefs(data);
            specialcontrols = new sim_aircraft_specialcontrolsDataRefs(data);
            vtolcontrols = new sim_aircraft_vtolcontrolsDataRefs(data);
            artstability = new sim_aircraft_artstabilityDataRefs(data);
            overflow = new sim_aircraft_overflowDataRefs(data);
            systems = new sim_aircraft_systemsDataRefs(data);
        }
        public sim_aircraft_viewDataRefs view { get; }
        public sim_aircraft_forcefeedbackDataRefs forcefeedback { get; }
        public sim_aircraft_electricalDataRefs electrical { get; }
        public sim_aircraft_engineDataRefs engine { get; }
        public sim_aircraft_limitsDataRefs limits { get; }
        public sim_aircraft_propDataRefs prop { get; }
        public sim_aircraft_partsDataRefs parts { get; }
        public sim_aircraft_controlsDataRefs controls { get; }
        public sim_aircraft_gearDataRefs gear { get; }
        public sim_aircraft_weightDataRefs weight { get; }
        public sim_aircraft_specialcontrolsDataRefs specialcontrols { get; }
        public sim_aircraft_vtolcontrolsDataRefs vtolcontrols { get; }
        public sim_aircraft_artstabilityDataRefs artstability { get; }
        public sim_aircraft_overflowDataRefs overflow { get; }
        public sim_aircraft_systemsDataRefs systems { get; }
    }
}