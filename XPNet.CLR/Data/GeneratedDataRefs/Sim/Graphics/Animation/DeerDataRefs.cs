using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animation_deerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animation_deerDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  ratio for deer running. Units:float
        ///  Raw path: sim/graphics/animation/deer/deer_run_cycle
        /// </summary>
        public IXPDataRef<float> deer_run_cycle { get { return m_data.GetFloat("sim/graphics/animation/deer/deer_run_cycle");} }

        /// <summary>
        ///  ratio for deer turning. Units:float
        ///  Raw path: sim/graphics/animation/deer/deer_turn_cycle
        /// </summary>
        public IXPDataRef<float> deer_turn_cycle { get { return m_data.GetFloat("sim/graphics/animation/deer/deer_turn_cycle");} }
    }
}