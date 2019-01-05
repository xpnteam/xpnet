using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_ViewDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_ViewDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The location of the camera, X coordinate (OpenGL). Units:OGLcoords
        /// </summary>
        public IXPDataRef<float> View_x => m_data.GetFloat("sim/graphics/view/view_x");

        /// <summary>
        ///  The location of the camera, Y coordinate (OpenGL). Units:OGLcoords
        /// </summary>
        public IXPDataRef<float> View_y => m_data.GetFloat("sim/graphics/view/view_y");

        /// <summary>
        ///  The location of the camera, Z coordinate (OpenGL). Units:OGLcoords
        /// </summary>
        public IXPDataRef<float> View_z => m_data.GetFloat("sim/graphics/view/view_z");

        /// <summary>
        ///  The camera's pitch. Units:degrees
        /// </summary>
        public IXPDataRef<float> View_pitch => m_data.GetFloat("sim/graphics/view/view_pitch");

        /// <summary>
        ///  The camera's roll. Units:degrees
        /// </summary>
        public IXPDataRef<float> View_roll => m_data.GetFloat("sim/graphics/view/view_roll");

        /// <summary>
        ///  the camera's heading, CW frmo true north. Units:degrees
        /// </summary>
        public IXPDataRef<float> View_heading => m_data.GetFloat("sim/graphics/view/view_heading");

        /// <summary>
        ///  The cockpit's pitch. Units:degrees
        /// </summary>
        public IXPDataRef<float> Cockpit_pitch => m_data.GetFloat("sim/graphics/view/cockpit_pitch");

        /// <summary>
        ///  The cockpit's heading (the dataref name is wrong - this is really true heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Cockpit_roll => m_data.GetFloat("sim/graphics/view/cockpit_roll");

        /// <summary>
        ///  the cockpit's roll (the dataref is name wrong - this is really roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Cockpit_heading => m_data.GetFloat("sim/graphics/view/cockpit_heading");

        /// <summary>
        ///  horizontal field of view in degrees. Units:degrees
        /// </summary>
        public IXPDataRef<float> Field_of_view_deg => m_data.GetFloat("sim/graphics/view/field_of_view_deg");

        /// <summary>
        ///  vertical field of view in degrees, see sim/Graphics/Settings/Non_proportional_vertical_FOV.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Vertical_field_of_view_deg => m_data.GetFloat("sim/graphics/view/vertical_field_of_view_deg");

        /// <summary>
        ///  pitch rotation for multi-monitor setup.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Field_of_view_vertical_deg => m_data.GetFloat("sim/graphics/view/field_of_view_vertical_deg");

        /// <summary>
        ///  heading rotation for multi-monitor setup.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Field_of_view_horizontal_deg => m_data.GetFloat("sim/graphics/view/field_of_view_horizontal_deg");

        /// <summary>
        ///  Roll rotation for multi-monitor setup.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Field_of_view_roll_deg => m_data.GetFloat("sim/graphics/view/field_of_view_roll_deg");

        /// <summary>
        ///  horizontal frustum shift (xp 6,7,8,10) - 1 unit shifts frustum by screen width. Units:ratio
        /// </summary>
        public IXPDataRef<float> Field_of_view_horizontal_ratio => m_data.GetFloat("sim/graphics/view/field_of_view_horizontal_ratio");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Visibility_effective_m => m_data.GetFloat("sim/graphics/view/visibility_effective_m");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Visibility_terrain_m => m_data.GetFloat("sim/graphics/view/visibility_terrain_m");

        /// <summary>
        ///  - 1.0]. Units:[0.0
        /// </summary>
        public IXPDataRef<float> Visibility_framerate_ratio => m_data.GetFloat("sim/graphics/view/visibility_framerate_ratio");

        /// <summary>
        ///  This is the location of the left edge of the panel, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_pnl_l => m_data.GetFloat("sim/graphics/view/panel_total_pnl_l");

        /// <summary>
        ///  This is the location of the bottom edge of the panel, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_pnl_b => m_data.GetFloat("sim/graphics/view/panel_total_pnl_b");

        /// <summary>
        ///  This is the location of the right edge of the panel, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_pnl_r => m_data.GetFloat("sim/graphics/view/panel_total_pnl_r");

        /// <summary>
        ///  This is the location of the top edge of the panel, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_pnl_t => m_data.GetFloat("sim/graphics/view/panel_total_pnl_t");

        /// <summary>
        ///  This is the location of the left edge of the screen, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_pnl_l => m_data.GetFloat("sim/graphics/view/panel_visible_pnl_l");

        /// <summary>
        ///  This is the location of the bottom edge of the screen, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_pnl_b => m_data.GetFloat("sim/graphics/view/panel_visible_pnl_b");

        /// <summary>
        ///  This is the location of the right edge of the screen, in the coordinate system used during panel drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_pnl_r => m_data.GetFloat("sim/graphics/view/panel_visible_pnl_r");

        /// <summary>
        ///  This is the location of the top edge of the screen, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_pnl_t => m_data.GetFloat("sim/graphics/view/panel_visible_pnl_t");

        /// <summary>
        ///  This is the location of the left edge of the panel, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_win_l => m_data.GetFloat("sim/graphics/view/panel_total_win_l");

        /// <summary>
        ///  This is the location of the bottom edge of the panel, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_win_b => m_data.GetFloat("sim/graphics/view/panel_total_win_b");

        /// <summary>
        ///  This is the location of the right edge of the panel, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_win_r => m_data.GetFloat("sim/graphics/view/panel_total_win_r");

        /// <summary>
        ///  This is the location of the top edge of the panel, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_total_win_t => m_data.GetFloat("sim/graphics/view/panel_total_win_t");

        /// <summary>
        ///  This is the location of the left edge of the screen, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_win_l => m_data.GetFloat("sim/graphics/view/panel_visible_win_l");

        /// <summary>
        ///  This is the location of the bottom edge of the screen, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_win_b => m_data.GetFloat("sim/graphics/view/panel_visible_win_b");

        /// <summary>
        ///  This is the location of the right edge of the screen, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_win_r => m_data.GetFloat("sim/graphics/view/panel_visible_win_r");

        /// <summary>
        ///  This is the location of the top edge of the screen, in the coordinate system used during plugin window drawing.. Units:pixels
        /// </summary>
        public IXPDataRef<float> Panel_visible_win_t => m_data.GetFloat("sim/graphics/view/panel_visible_win_t");

        /// <summary>
        ///  Position of pilot's head relative to CG, X. Units:meters
        /// </summary>
        public IXPDataRef<float> Pilots_head_x => m_data.GetFloat("sim/graphics/view/pilots_head_x");

        /// <summary>
        ///  Position of pilot's head relative to CG, Y. Units:meters
        /// </summary>
        public IXPDataRef<float> Pilots_head_y => m_data.GetFloat("sim/graphics/view/pilots_head_y");

        /// <summary>
        ///  Position of pilot's head relative to CG, Z. Units:meters
        /// </summary>
        public IXPDataRef<float> Pilots_head_z => m_data.GetFloat("sim/graphics/view/pilots_head_z");

        /// <summary>
        ///  Position of pilot's head heading. Units:degrees
        /// </summary>
        public IXPDataRef<float> Pilots_head_psi => m_data.GetFloat("sim/graphics/view/pilots_head_psi");

        /// <summary>
        ///  Position of pilot's head pitch. Units:degrees
        /// </summary>
        public IXPDataRef<float> Pilots_head_the => m_data.GetFloat("sim/graphics/view/pilots_head_the");

        /// <summary>
        ///  Position of the pilot's head roll'. Units:degrees
        /// </summary>
        public IXPDataRef<float> Pilots_head_phi => m_data.GetFloat("sim/graphics/view/pilots_head_phi");

        /// <summary>
        ///  coordinates of the panel click in 3-d. Units:0-1
        /// </summary>
        public IXPDataRef<float> Click_3d_x => m_data.GetFloat("sim/graphics/view/click_3d_x");

        /// <summary>
        ///  as texture coords (E.g. 0-1). Units:0-1
        /// </summary>
        public IXPDataRef<float> Click_3d_y => m_data.GetFloat("sim/graphics/view/click_3d_y");

        /// <summary>
        ///  coordinates of the panel click in 3-d. Units:0-1
        /// </summary>
        public IXPDataRef<float> Click_3d_x_pixels => m_data.GetFloat("sim/graphics/view/click_3d_x_pixels");

        /// <summary>
        ///  as texture coords (E.g. 0-1). Units:0-1
        /// </summary>
        public IXPDataRef<float> Click_3d_y_pixels => m_data.GetFloat("sim/graphics/view/click_3d_y_pixels");

        /// <summary>
        ///  Bounds of the local map window during callbacks - left. Units:pixels
        /// </summary>
        public IXPDataRef<float> Local_map_l => m_data.GetFloat("sim/graphics/view/local_map_l");

        /// <summary>
        ///  Bounds of the local map window during callbacks - bottom. Units:pixels
        /// </summary>
        public IXPDataRef<float> Local_map_b => m_data.GetFloat("sim/graphics/view/local_map_b");

        /// <summary>
        ///  Bounds of the local map window during callbacks - right. Units:pixels
        /// </summary>
        public IXPDataRef<float> Local_map_r => m_data.GetFloat("sim/graphics/view/local_map_r");

        /// <summary>
        ///  Bounds of the local map window during callbacks - top. Units:pixels
        /// </summary>
        public IXPDataRef<float> Local_map_t => m_data.GetFloat("sim/graphics/view/local_map_t");

        /// <summary>
        ///  The horizontal offset for this pass, in degrees. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Dome_offset_heading => m_data.GetFloatArray("sim/graphics/view/dome_offset_heading");

        /// <summary>
        ///  The vertical offset for this pass, in degrees. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Dome_offset_pitch => m_data.GetFloatArray("sim/graphics/view/dome_offset_pitch");

        /// <summary>
        ///  The current projection matrix - valid only during draw callbacks. Units:Matrix4x4
        /// </summary>
        public IXPDataRef<float[]> Projection_matrix => m_data.GetFloatArray("sim/graphics/view/projection_matrix");

        /// <summary>
        ///  The current modelview matrix to draw in standard "OGL" coordinates - valid only during draw callbacks. Units:Matrix4x4
        /// </summary>
        public IXPDataRef<float[]> World_matrix => m_data.GetFloatArray("sim/graphics/view/world_matrix");

        /// <summary>
        ///  A modelview matrix to draw in the user's aircraft coordinates - valid only during draw callbacks. Units:Matrix4x4
        /// </summary>
        public IXPDataRef<float[]> Acf_matrix => m_data.GetFloatArray("sim/graphics/view/acf_matrix");
    }
}