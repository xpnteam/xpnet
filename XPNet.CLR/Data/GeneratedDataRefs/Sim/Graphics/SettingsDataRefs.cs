using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_settingsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_settingsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  dim under high g-load?
        /// </summary>
        public IXPDataRef<bool> dim_gload { get { return m_data.GetBool("sim/graphics/settings/dim_gload");} }

        /// <summary>
        ///  draw forest fires?
        /// </summary>
        public IXPDataRef<bool> draw_forestfires { get { return m_data.GetBool("sim/graphics/settings/draw_forestfires");} }

        /// <summary>
        ///  FOV is non proportional, use if sim/graphics/view/vertical_field_of_view_deg needs to be written to.
        /// </summary>
        public IXPDataRef<bool> non_proportional_vertical_FOV { get { return m_data.GetBool("sim/graphics/settings/non_proportional_vertical_fov");} }

        /// <summary>
        ///  True if HDR rendering is enabled.
        /// </summary>
        public IXPDataRef<bool> HDR_on { get { return m_data.GetBool("sim/graphics/settings/hdr_on");} }

        /// <summary>
        ///  True if atmospheric scattering is enabled.
        /// </summary>
        public IXPDataRef<bool> scattering_on { get { return m_data.GetBool("sim/graphics/settings/scattering_on");} }
    }
}