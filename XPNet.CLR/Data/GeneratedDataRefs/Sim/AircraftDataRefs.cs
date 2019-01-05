using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_AircraftDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_AircraftDatarefs(IXPlaneData data)
        {
            m_data = data;
            View = new Sim_Aircraft_ViewDatarefs(data);
            Forcefeedback = new Sim_Aircraft_ForcefeedbackDatarefs(data);
            Electrical = new Sim_Aircraft_ElectricalDatarefs(data);
            Engine = new Sim_Aircraft_EngineDatarefs(data);
            Limits = new Sim_Aircraft_LimitsDatarefs(data);
            Prop = new Sim_Aircraft_PropDatarefs(data);
            Parts = new Sim_Aircraft_PartsDatarefs(data);
            Controls = new Sim_Aircraft_ControlsDatarefs(data);
            Gear = new Sim_Aircraft_GearDatarefs(data);
            Weight = new Sim_Aircraft_WeightDatarefs(data);
            Specialcontrols = new Sim_Aircraft_SpecialcontrolsDatarefs(data);
            Vtolcontrols = new Sim_Aircraft_VtolcontrolsDatarefs(data);
            Artstability = new Sim_Aircraft_ArtstabilityDatarefs(data);
            Overflow = new Sim_Aircraft_OverflowDatarefs(data);
            Systems = new Sim_Aircraft_SystemsDatarefs(data);
        }
        public Sim_Aircraft_ViewDatarefs View { get; }
        public Sim_Aircraft_ForcefeedbackDatarefs Forcefeedback { get; }
        public Sim_Aircraft_ElectricalDatarefs Electrical { get; }
        public Sim_Aircraft_EngineDatarefs Engine { get; }
        public Sim_Aircraft_LimitsDatarefs Limits { get; }
        public Sim_Aircraft_PropDatarefs Prop { get; }
        public Sim_Aircraft_PartsDatarefs Parts { get; }
        public Sim_Aircraft_ControlsDatarefs Controls { get; }
        public Sim_Aircraft_GearDatarefs Gear { get; }
        public Sim_Aircraft_WeightDatarefs Weight { get; }
        public Sim_Aircraft_SpecialcontrolsDatarefs Specialcontrols { get; }
        public Sim_Aircraft_VtolcontrolsDatarefs Vtolcontrols { get; }
        public Sim_Aircraft_ArtstabilityDatarefs Artstability { get; }
        public Sim_Aircraft_OverflowDatarefs Overflow { get; }
        public Sim_Aircraft_SystemsDatarefs Systems { get; }
    }
}