using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_SettingsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_SettingsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  dim under high g-load?
        /// </summary>
        public IXPDataRef<bool> Dim_gload { get { return m_data.GetBool("sim/graphics/settings/dim_gload");} }

        /// <summary>
        ///  draw forest fires?
        /// </summary>
        public IXPDataRef<bool> Draw_forestfires { get { return m_data.GetBool("sim/graphics/settings/draw_forestfires");} }

        /// <summary>
        ///  FOV is non proportional, use if sim/Graphics/View/Vertical_field_of_view_deg needs to be written to.
        /// </summary>
        public IXPDataRef<bool> Non_proportional_vertical_FOV { get { return m_data.GetBool("sim/graphics/settings/non_proportional_vertical_fov");} }

        /// <summary>
        ///  True if HDR rendering is enabled.
        /// </summary>
        public IXPDataRef<bool> HDR_on { get { return m_data.GetBool("sim/graphics/settings/hdr_on");} }

        /// <summary>
        ///  True if atmospheric scattering is enabled.
        /// </summary>
        public IXPDataRef<bool> Scattering_on { get { return m_data.GetBool("sim/graphics/settings/scattering_on");} }
    }
}