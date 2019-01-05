using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_Animation_BirdsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_Animation_BirdsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  degree of wing flap for the currently drawn bird. Units:float
        /// </summary>
        public IXPDataRef<float> Wing_flap_deg => m_data.GetFloat("sim/graphics/animation/birds/wing_flap_deg");

        /// <summary>
        ///  angle the bird's feet are retracted for the flock of birds.. Units:float
        /// </summary>
        public IXPDataRef<float> Feet_retract_deg => m_data.GetFloat("sim/graphics/animation/birds/feet_retract_deg");
    }
}