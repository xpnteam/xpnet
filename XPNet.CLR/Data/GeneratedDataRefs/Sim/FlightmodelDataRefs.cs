using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_FlightmodelDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_FlightmodelDatarefs(IXPlaneData data)
        {
            m_data = data;
            Controls = new Sim_Flightmodel_ControlsDatarefs(data);
            Engine = new Sim_Flightmodel_EngineDatarefs(data);
            Failures = new Sim_Flightmodel_FailuresDatarefs(data);
            Forces = new Sim_Flightmodel_ForcesDatarefs(data);
            Misc = new Sim_Flightmodel_MiscDatarefs(data);
            Parts = new Sim_Flightmodel_PartsDatarefs(data);
            Position = new Sim_Flightmodel_PositionDatarefs(data);
            Weight = new Sim_Flightmodel_WeightDatarefs(data);
        }
        public Sim_Flightmodel_ControlsDatarefs Controls { get; }
        public Sim_Flightmodel_EngineDatarefs Engine { get; }
        public Sim_Flightmodel_FailuresDatarefs Failures { get; }
        public Sim_Flightmodel_ForcesDatarefs Forces { get; }
        public Sim_Flightmodel_MiscDatarefs Misc { get; }
        public Sim_Flightmodel_PartsDatarefs Parts { get; }
        public Sim_Flightmodel_PositionDatarefs Position { get; }
        public Sim_Flightmodel_WeightDatarefs Weight { get; }
    }
}