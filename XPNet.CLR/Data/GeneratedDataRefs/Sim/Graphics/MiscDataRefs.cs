using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Show the clickable parts of the panel?
        /// </summary>
        public IXPDataRef<bool> show_panel_click_spots { get { return m_data.GetBool("sim/graphics/misc/show_panel_click_spots");} }

        /// <summary>
        ///  Show instrument descriptions on the panel?
        /// </summary>
        public IXPDataRef<bool> show_instrument_descriptions { get { return m_data.GetBool("sim/graphics/misc/show_instrument_descriptions");} }

        /// <summary>
        ///  The red level for the cockpit 'night' tinting, from 0 to 1
        /// </summary>
        public IXPDataRef<float> cockpit_light_level_r { get { return m_data.GetFloat("sim/graphics/misc/cockpit_light_level_r");} }

        /// <summary>
        ///  The green level for the cockpit 'night' tinting, from 0 to 1
        /// </summary>
        public IXPDataRef<float> cockpit_light_level_g { get { return m_data.GetFloat("sim/graphics/misc/cockpit_light_level_g");} }

        /// <summary>
        ///  The blue level for the cockpit 'night' tinting, from 0 to 1
        /// </summary>
        public IXPDataRef<float> cockpit_light_level_b { get { return m_data.GetFloat("sim/graphics/misc/cockpit_light_level_b");} }

        /// <summary>
        ///  The red level for the world, from 0 to 1
        /// </summary>
        public IXPDataRef<float> outside_light_level_r { get { return m_data.GetFloat("sim/graphics/misc/outside_light_level_r");} }

        /// <summary>
        ///  The green level for the world, from 0 to 1
        /// </summary>
        public IXPDataRef<float> outside_light_level_g { get { return m_data.GetFloat("sim/graphics/misc/outside_light_level_g");} }

        /// <summary>
        ///  The blue level for the world, from 0 to 1
        /// </summary>
        public IXPDataRef<float> outside_light_level_b { get { return m_data.GetFloat("sim/graphics/misc/outside_light_level_b");} }

        /// <summary>
        ///  Amount that artificial light is dimmed due to the sun's magnitude
        /// </summary>
        public IXPDataRef<float> light_attenuation { get { return m_data.GetFloat("sim/graphics/misc/light_attenuation");} }

        /// <summary>
        ///  Set this to 1 to enable proportional fonts when available.
        /// </summary>
        public IXPDataRef<bool> use_proportional_fonts { get { return m_data.GetBool("sim/graphics/misc/use_proportional_fonts");} }

        /// <summary>
        ///  If set to true, the map instruments won't draw the red FMS course line. SET THIS BACK TO 0 WHEN YOUR PLANE UNLOADS!
        /// </summary>
        public IXPDataRef<bool> kill_map_fms_line { get { return m_data.GetBool("sim/graphics/misc/kill_map_fms_line");} }

        /// <summary>
        ///  Is the red flashlight on now.  Note that the flashlight is inop when HDR is off.
        /// </summary>
        public IXPDataRef<bool> red_flashlight_on { get { return m_data.GetBool("sim/graphics/misc/red_flashlight_on");} }

        /// <summary>
        ///  Is the white flashlight on now.  Note that the flashlight is inop when HDR is off.
        /// </summary>
        public IXPDataRef<bool> white_flashlight_on { get { return m_data.GetBool("sim/graphics/misc/white_flashlight_on");} }

        /// <summary>
        ///  Default position for a scrolling plane panel
        /// </summary>
        public IXPDataRef<float> default_scroll_pos { get { return m_data.GetFloat("sim/graphics/misc/default_scroll_pos");} }

        /// <summary>
        ///  Current position of that panel
        /// </summary>
        public IXPDataRef<float> current_scroll_pos { get { return m_data.GetFloat("sim/graphics/misc/current_scroll_pos");} }

        /// <summary>
        ///  Default position for a scrolling plane panel
        /// </summary>
        public IXPDataRef<float> default_scroll_pos_x { get { return m_data.GetFloat("sim/graphics/misc/default_scroll_pos_x");} }

        /// <summary>
        ///  Current position of that panel
        /// </summary>
        public IXPDataRef<float> current_scroll_pos_x { get { return m_data.GetFloat("sim/graphics/misc/current_scroll_pos_x");} }
    }
}