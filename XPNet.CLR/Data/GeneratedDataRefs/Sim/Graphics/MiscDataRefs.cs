using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The red level for the cockpit 'night' tinting, from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Cockpit_light_level_r => m_data.GetFloat("sim/graphics/misc/cockpit_light_level_r");

        /// <summary>
        ///  The green level for the cockpit 'night' tinting, from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Cockpit_light_level_g => m_data.GetFloat("sim/graphics/misc/cockpit_light_level_g");

        /// <summary>
        ///  The blue level for the cockpit 'night' tinting, from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Cockpit_light_level_b => m_data.GetFloat("sim/graphics/misc/cockpit_light_level_b");

        /// <summary>
        ///  The red level for the world, from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Outside_light_level_r => m_data.GetFloat("sim/graphics/misc/outside_light_level_r");

        /// <summary>
        ///  The green level for the world, from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Outside_light_level_g => m_data.GetFloat("sim/graphics/misc/outside_light_level_g");

        /// <summary>
        ///  The blue level for the world, from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Outside_light_level_b => m_data.GetFloat("sim/graphics/misc/outside_light_level_b");

        /// <summary>
        ///  Amount that artificial light is dimmed due to the sun's magnitude. Units:ratio
        /// </summary>
        public IXPDataRef<float> Light_attenuation => m_data.GetFloat("sim/graphics/misc/light_attenuation");

        /// <summary>
        ///  Default position for a scrolling plane panel. Units:pixels
        /// </summary>
        public IXPDataRef<float> Default_scroll_pos => m_data.GetFloat("sim/graphics/misc/default_scroll_pos");

        /// <summary>
        ///  Current position of that panel. Units:pixels
        /// </summary>
        public IXPDataRef<float> Current_scroll_pos => m_data.GetFloat("sim/graphics/misc/current_scroll_pos");

        /// <summary>
        ///  Default position for a scrolling plane panel. Units:pixels
        /// </summary>
        public IXPDataRef<float> Default_scroll_pos_x => m_data.GetFloat("sim/graphics/misc/default_scroll_pos_x");

        /// <summary>
        ///  Current position of that panel. Units:pixels
        /// </summary>
        public IXPDataRef<float> Current_scroll_pos_x => m_data.GetFloat("sim/graphics/misc/current_scroll_pos_x");
    }
}