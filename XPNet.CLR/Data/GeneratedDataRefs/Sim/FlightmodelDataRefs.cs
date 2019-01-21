using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodelDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodelDataRefs(IXPlaneData data)
        {
            m_data = data;
            controls = new sim_flightmodel_controlsDataRefs(data);
            engine = new sim_flightmodel_engineDataRefs(data);
            failures = new sim_flightmodel_failuresDataRefs(data);
            forces = new sim_flightmodel_forcesDataRefs(data);
            misc = new sim_flightmodel_miscDataRefs(data);
            parts = new sim_flightmodel_partsDataRefs(data);
            position = new sim_flightmodel_positionDataRefs(data);
            weight = new sim_flightmodel_weightDataRefs(data);
        }
        public sim_flightmodel_controlsDataRefs controls { get; }
        public sim_flightmodel_engineDataRefs engine { get; }
        public sim_flightmodel_failuresDataRefs failures { get; }
        public sim_flightmodel_forcesDataRefs forces { get; }
        public sim_flightmodel_miscDataRefs misc { get; }
        public sim_flightmodel_partsDataRefs parts { get; }
        public sim_flightmodel_positionDataRefs position { get; }
        public sim_flightmodel_weightDataRefs weight { get; }
    }
}