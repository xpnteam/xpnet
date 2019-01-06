using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_ColorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_ColorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Background color behind a modal window
        /// </summary>
        public IXPDataRef<float[]> Background_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/background_rgb");} }

        /// <summary>
        ///  Dark tinging for menus
        /// </summary>
        public IXPDataRef<float[]> Menu_dark_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/menu_dark_rgb");} }

        /// <summary>
        ///  Menu color of a selected item
        /// </summary>
        public IXPDataRef<float[]> Menu_hilite_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/menu_hilite_rgb");} }

        /// <summary>
        ///  Light tinging for menus
        /// </summary>
        public IXPDataRef<float[]> Menu_lite_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/menu_lite_rgb");} }

        /// <summary>
        ///  Menu Item Text Color
        /// </summary>
        public IXPDataRef<float[]> Menu_text_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/menu_text_rgb");} }

        /// <summary>
        ///  Menu Item Text Color When Disabled
        /// </summary>
        public IXPDataRef<float[]> Menu_text_disabled_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/menu_text_disabled_rgb");} }

        /// <summary>
        ///  Subtitle text colors
        /// </summary>
        public IXPDataRef<float[]> Subtitle_text_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/subtitle_text_rgb");} }

        /// <summary>
        ///  Color of text on tabs that are forward
        /// </summary>
        public IXPDataRef<float[]> Tab_front_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/tab_front_rgb");} }

        /// <summary>
        ///  Color of text on tabs that are in the bkgnd
        /// </summary>
        public IXPDataRef<float[]> Tab_back_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/tab_back_rgb");} }

        /// <summary>
        ///  Caption text (for on a main window)
        /// </summary>
        public IXPDataRef<float[]> Caption_text_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/caption_text_rgb");} }

        /// <summary>
        ///  Text Color for scrolling lists
        /// </summary>
        public IXPDataRef<float[]> List_text_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/list_text_rgb");} }

        /// <summary>
        ///  Text color for on a 'glass' screen
        /// </summary>
        public IXPDataRef<float[]> Glass_text_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/glass_text_rgb");} }

        /// <summary>
        ///  Color for 3-d plane path
        /// </summary>
        public IXPDataRef<float[]> Plane_path1_3d_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/plane_path1_3d_rgb");} }

        /// <summary>
        ///  Striping color for 3-d plane path
        /// </summary>
        public IXPDataRef<float[]> Plane_path2_3d_rgb { get { return m_data.GetFloatArray("sim/graphics/colors/plane_path2_3d_rgb");} }
    }
}