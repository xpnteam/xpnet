using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_sceneryDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_sceneryDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  What planet are we on?  (Earth = 0, mars = 1)
        /// </summary>
        public IXPDataRef<int> current_planet { get { return m_data.GetInt("sim/graphics/scenery/current_planet");} }

        /// <summary>
        ///  what percentage of city lites are on as night hits
        /// </summary>
        public IXPDataRef<float> percent_lights_on { get { return m_data.GetFloat("sim/graphics/scenery/percent_lights_on");} }

        /// <summary>
        ///  sun pitch from flat in OGL coordinates
        /// </summary>
        public IXPDataRef<float> sun_pitch_degrees { get { return m_data.GetFloat("sim/graphics/scenery/sun_pitch_degrees");} }

        /// <summary>
        ///  sun heading from true north in OGL coordinates
        /// </summary>
        public IXPDataRef<float> sun_heading_degrees { get { return m_data.GetFloat("sim/graphics/scenery/sun_heading_degrees");} }

        /// <summary>
        ///  moon pitch from flat in OGL coordinates
        /// </summary>
        public IXPDataRef<float> moon_pitch_degrees { get { return m_data.GetFloat("sim/graphics/scenery/moon_pitch_degrees");} }

        /// <summary>
        ///  moon heading from true north in OGL coordinates
        /// </summary>
        public IXPDataRef<float> moon_heading_degrees { get { return m_data.GetFloat("sim/graphics/scenery/moon_heading_degrees");} }

        /// <summary>
        ///  Level of airport light illumination, 0 = off, 1 = max brightness
        /// </summary>
        public IXPDataRef<float> airport_light_level { get { return m_data.GetFloat("sim/graphics/scenery/airport_light_level");} }

        /// <summary>
        ///  Are the airport lites on?  set override_airport_lites to 1t o write this.
        /// </summary>
        public IXPDataRef<bool> airport_lights_on { get { return m_data.GetBool("sim/graphics/scenery/airport_lights_on");} }

        /// <summary>
        ///  True when some kind of asynchronous scenery load or unload is in progress.
        /// </summary>
        public IXPDataRef<bool> async_scenery_load_in_progress { get { return m_data.GetBool("sim/graphics/scenery/async_scenery_load_in_progress");} }
    }
}