using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_SceneryDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_SceneryDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  what percentage of city lites are on as night hits. Units:percent
        /// </summary>
        public IXPDataRef<float> Percent_lights_on => m_data.GetFloat("sim/graphics/scenery/percent_lights_on");

        /// <summary>
        ///  sun pitch from flat in OGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Sun_pitch_degrees => m_data.GetFloat("sim/graphics/scenery/sun_pitch_degrees");

        /// <summary>
        ///  sun heading from true north in OGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Sun_heading_degrees => m_data.GetFloat("sim/graphics/scenery/sun_heading_degrees");

        /// <summary>
        ///  moon pitch from flat in OGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Moon_pitch_degrees => m_data.GetFloat("sim/graphics/scenery/moon_pitch_degrees");

        /// <summary>
        ///  moon heading from true north in OGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Moon_heading_degrees => m_data.GetFloat("sim/graphics/scenery/moon_heading_degrees");

        /// <summary>
        ///  Level of airport light illumination, 0 = off, 1 = max brightness. Units:ratio
        /// </summary>
        public IXPDataRef<float> Airport_light_level => m_data.GetFloat("sim/graphics/scenery/airport_light_level");
    }
}