using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodelDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodelDatarefs(IXPlaneData data)
        {
            m_data = data;
            controls = new sim_flightmodel_controlsDatarefs(data);
            engine = new sim_flightmodel_engineDatarefs(data);
            failures = new sim_flightmodel_failuresDatarefs(data);
            forces = new sim_flightmodel_forcesDatarefs(data);
            misc = new sim_flightmodel_miscDatarefs(data);
            parts = new sim_flightmodel_partsDatarefs(data);
            position = new sim_flightmodel_positionDatarefs(data);
            weight = new sim_flightmodel_weightDatarefs(data);
        }
        public sim_flightmodel_controlsDatarefs controls { get; }
        public sim_flightmodel_engineDatarefs engine { get; }
        public sim_flightmodel_failuresDatarefs failures { get; }
        public sim_flightmodel_forcesDatarefs forces { get; }
        public sim_flightmodel_miscDatarefs misc { get; }
        public sim_flightmodel_partsDatarefs parts { get; }
        public sim_flightmodel_positionDatarefs position { get; }
        public sim_flightmodel_weightDatarefs weight { get; }
    }
}