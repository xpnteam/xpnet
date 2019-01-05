using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_Animation_DeerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_Animation_DeerDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  ratio for deer running. Units:float
        /// </summary>
        public IXPDataRef<float> Deer_run_cycle => m_data.GetFloat("sim/graphics/animation/deer/deer_run_cycle");

        /// <summary>
        ///  ratio for deer turning. Units:float
        /// </summary>
        public IXPDataRef<float> Deer_turn_cycle => m_data.GetFloat("sim/graphics/animation/deer/deer_turn_cycle");
    }
}