using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_settingsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_settingsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Texture Rendering Level. Units:int
        ///  Raw path: sim/graphics/settings/rendering_res
        /// </summary>
        public IXPDataRef<int> rendering_res { get { return m_data.GetInt("sim/graphics/settings/rendering_res");} }

        /// <summary>
        ///  dim under high g-load?. Units:boolean
        ///  Raw path: sim/graphics/settings/dim_gload
        /// </summary>
        public IXPDataRef<bool> dim_gload { get { return m_data.GetBool("sim/graphics/settings/dim_gload");} }

        /// <summary>
        ///  draw forest fires?. Units:boolean
        ///  Raw path: sim/graphics/settings/draw_forestfires
        /// </summary>
        public IXPDataRef<bool> draw_forestfires { get { return m_data.GetBool("sim/graphics/settings/draw_forestfires");} }

        /// <summary>
        ///  FOV is non proportional, use if sim/graphics/view/vertical_field_of_view_deg needs to be written to.. Units:boolean
        ///  Raw path: sim/graphics/settings/non_proportional_vertical_FOV
        /// </summary>
        public IXPDataRef<bool> non_proportional_vertical_FOV { get { return m_data.GetBool("sim/graphics/settings/non_proportional_vertical_fov");} }

        /// <summary>
        ///  True if HDR rendering is enabled.. Units:boolean
        ///  Raw path: sim/graphics/settings/HDR_on
        /// </summary>
        public IXPDataRef<bool> HDR_on { get { return m_data.GetBool("sim/graphics/settings/hdr_on");} }

        /// <summary>
        ///  True if atmospheric scattering is enabled.. Units:boolean
        ///  Raw path: sim/graphics/settings/scattering_on
        /// </summary>
        public IXPDataRef<bool> scattering_on { get { return m_data.GetBool("sim/graphics/settings/scattering_on");} }
    }
}