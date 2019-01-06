using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraftDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraftDatarefs(IXPlaneData data)
        {
            m_data = data;
            view = new sim_aircraft_viewDatarefs(data);
            forcefeedback = new sim_aircraft_forcefeedbackDatarefs(data);
            electrical = new sim_aircraft_electricalDatarefs(data);
            engine = new sim_aircraft_engineDatarefs(data);
            limits = new sim_aircraft_limitsDatarefs(data);
            prop = new sim_aircraft_propDatarefs(data);
            parts = new sim_aircraft_partsDatarefs(data);
            controls = new sim_aircraft_controlsDatarefs(data);
            gear = new sim_aircraft_gearDatarefs(data);
            weight = new sim_aircraft_weightDatarefs(data);
            specialcontrols = new sim_aircraft_specialcontrolsDatarefs(data);
            vtolcontrols = new sim_aircraft_vtolcontrolsDatarefs(data);
            artstability = new sim_aircraft_artstabilityDatarefs(data);
            overflow = new sim_aircraft_overflowDatarefs(data);
            systems = new sim_aircraft_systemsDatarefs(data);
        }
        public sim_aircraft_viewDatarefs view { get; }
        public sim_aircraft_forcefeedbackDatarefs forcefeedback { get; }
        public sim_aircraft_electricalDatarefs electrical { get; }
        public sim_aircraft_engineDatarefs engine { get; }
        public sim_aircraft_limitsDatarefs limits { get; }
        public sim_aircraft_propDatarefs prop { get; }
        public sim_aircraft_partsDatarefs parts { get; }
        public sim_aircraft_controlsDatarefs controls { get; }
        public sim_aircraft_gearDatarefs gear { get; }
        public sim_aircraft_weightDatarefs weight { get; }
        public sim_aircraft_specialcontrolsDatarefs specialcontrols { get; }
        public sim_aircraft_vtolcontrolsDatarefs vtolcontrols { get; }
        public sim_aircraft_artstabilityDatarefs artstability { get; }
        public sim_aircraft_overflowDatarefs overflow { get; }
        public sim_aircraft_systemsDatarefs systems { get; }
    }
}