using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_AnimationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_AnimationDatarefs(IXPlaneData data)
        {
            m_data = data;
            Birds = new Sim_Graphics_Animation_BirdsDatarefs(data);
            Deer = new Sim_Graphics_Animation_DeerDatarefs(data);
            Lights = new Sim_Graphics_Animation_LightsDatarefs(data);
            Ground_traffic = new Sim_Graphics_Animation_Ground_trafficDatarefs(data);
        }
        public Sim_Graphics_Animation_BirdsDatarefs Birds { get; }
        public Sim_Graphics_Animation_DeerDatarefs Deer { get; }
        public Sim_Graphics_Animation_LightsDatarefs Lights { get; }
        public Sim_Graphics_Animation_Ground_trafficDatarefs Ground_traffic { get; }
    }
}