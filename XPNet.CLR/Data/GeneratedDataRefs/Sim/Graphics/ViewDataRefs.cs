using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_viewDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_viewDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  True if modern correct RGBA blending is being used to draw panels; false if the legacy alpha-max equation is being used.
        /// </summary>
        public IXPDataRef<bool> panel_render_new_blending { get { return m_data.GetBool("sim/graphics/view/panel_render_new_blending");} }

        /// <summary>
        ///  Is the view in the cockpit or outside?  Affects sound!
        /// </summary>
        public IXPDataRef<bool> view_is_external { get { return m_data.GetBool("sim/graphics/view/view_is_external");} }

        /// <summary>
        ///  The location of the camera, X coordinate (OpenGL)
        /// </summary>
        public IXPDataRef<float> view_x { get { return m_data.GetFloat("sim/graphics/view/view_x");} }

        /// <summary>
        ///  The location of the camera, Y coordinate (OpenGL)
        /// </summary>
        public IXPDataRef<float> view_y { get { return m_data.GetFloat("sim/graphics/view/view_y");} }

        /// <summary>
        ///  The location of the camera, Z coordinate (OpenGL)
        /// </summary>
        public IXPDataRef<float> view_z { get { return m_data.GetFloat("sim/graphics/view/view_z");} }

        /// <summary>
        ///  The camera's pitch
        /// </summary>
        public IXPDataRef<float> view_pitch { get { return m_data.GetFloat("sim/graphics/view/view_pitch");} }

        /// <summary>
        ///  The camera's roll
        /// </summary>
        public IXPDataRef<float> view_roll { get { return m_data.GetFloat("sim/graphics/view/view_roll");} }

        /// <summary>
        ///  the camera's heading, CW frmo true north
        /// </summary>
        public IXPDataRef<float> view_heading { get { return m_data.GetFloat("sim/graphics/view/view_heading");} }

        /// <summary>
        ///  The cockpit's pitch
        /// </summary>
        public IXPDataRef<float> cockpit_pitch { get { return m_data.GetFloat("sim/graphics/view/cockpit_pitch");} }

        /// <summary>
        ///  The cockpit's heading (the dataref name is wrong - this is really true heading)
        /// </summary>
        public IXPDataRef<float> cockpit_roll { get { return m_data.GetFloat("sim/graphics/view/cockpit_roll");} }

        /// <summary>
        ///  the cockpit's roll (the dataref is name wrong - this is really roll)
        /// </summary>
        public IXPDataRef<float> cockpit_heading { get { return m_data.GetFloat("sim/graphics/view/cockpit_heading");} }

        /// <summary>
        ///  horizontal field of view in degrees
        /// </summary>
        public IXPDataRef<float> field_of_view_deg { get { return m_data.GetFloat("sim/graphics/view/field_of_view_deg");} }

        /// <summary>
        ///  vertical field of view in degrees, see sim/graphics/settings/non_proportional_vertical_FOV.
        /// </summary>
        public IXPDataRef<float> vertical_field_of_view_deg { get { return m_data.GetFloat("sim/graphics/view/vertical_field_of_view_deg");} }

        /// <summary>
        ///  pitch rotation for multi-monitor setup.
        /// </summary>
        public IXPDataRef<float> field_of_view_vertical_deg { get { return m_data.GetFloat("sim/graphics/view/field_of_view_vertical_deg");} }

        /// <summary>
        ///  heading rotation for multi-monitor setup.
        /// </summary>
        public IXPDataRef<float> field_of_view_horizontal_deg { get { return m_data.GetFloat("sim/graphics/view/field_of_view_horizontal_deg");} }

        /// <summary>
        ///  Roll rotation for multi-monitor setup.
        /// </summary>
        public IXPDataRef<float> field_of_view_roll_deg { get { return m_data.GetFloat("sim/graphics/view/field_of_view_roll_deg");} }

        /// <summary>
        ///  horizontal frustum shift (xp 6,7,8,10) - 1 unit shifts frustum by screen width
        /// </summary>
        public IXPDataRef<float> field_of_view_horizontal_ratio { get { return m_data.GetFloat("sim/graphics/view/field_of_view_horizontal_ratio");} }

        /// <summary>
        ///  The effective visibility after framerate-protecting visibility reductions.
        /// </summary>
        public IXPDataRef<float> visibility_effective_m { get { return m_data.GetFloat("sim/graphics/view/visibility_effective_m");} }

        /// <summary>
        ///  The range of ground visibility. When above the clouds, only some of the ground terrain is actually drawn.
        /// </summary>
        public IXPDataRef<float> visibility_terrain_m { get { return m_data.GetFloat("sim/graphics/view/visibility_terrain_m");} }

        /// <summary>
        ///  The ratio of the reported visibility to actually show for frame-rate protection. 1.0 means the user ses the reported visibility.  Writable in v9, fixed in v10.
        /// </summary>
        public IXPDataRef<float> visibility_framerate_ratio { get { return m_data.GetFloat("sim/graphics/view/visibility_framerate_ratio");} }

        /// <summary>
        ///  True if cinema verite camera is on.
        /// </summary>
        public IXPDataRef<bool> cinema_verite { get { return m_data.GetBool("sim/graphics/view/cinema_verite");} }

        /// <summary>
        ///  This is the location of the left edge of the panel, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_pnl_l { get { return m_data.GetFloat("sim/graphics/view/panel_total_pnl_l");} }

        /// <summary>
        ///  This is the location of the bottom edge of the panel, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_pnl_b { get { return m_data.GetFloat("sim/graphics/view/panel_total_pnl_b");} }

        /// <summary>
        ///  This is the location of the right edge of the panel, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_pnl_r { get { return m_data.GetFloat("sim/graphics/view/panel_total_pnl_r");} }

        /// <summary>
        ///  This is the location of the top edge of the panel, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_pnl_t { get { return m_data.GetFloat("sim/graphics/view/panel_total_pnl_t");} }

        /// <summary>
        ///  This is the location of the left edge of the screen, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_pnl_l { get { return m_data.GetFloat("sim/graphics/view/panel_visible_pnl_l");} }

        /// <summary>
        ///  This is the location of the bottom edge of the screen, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_pnl_b { get { return m_data.GetFloat("sim/graphics/view/panel_visible_pnl_b");} }

        /// <summary>
        ///  This is the location of the right edge of the screen, in the coordinate system used during panel drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_pnl_r { get { return m_data.GetFloat("sim/graphics/view/panel_visible_pnl_r");} }

        /// <summary>
        ///  This is the location of the top edge of the screen, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_pnl_t { get { return m_data.GetFloat("sim/graphics/view/panel_visible_pnl_t");} }

        /// <summary>
        ///  This is the location of the left edge of the panel, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_win_l { get { return m_data.GetFloat("sim/graphics/view/panel_total_win_l");} }

        /// <summary>
        ///  This is the location of the bottom edge of the panel, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_win_b { get { return m_data.GetFloat("sim/graphics/view/panel_total_win_b");} }

        /// <summary>
        ///  This is the location of the right edge of the panel, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_win_r { get { return m_data.GetFloat("sim/graphics/view/panel_total_win_r");} }

        /// <summary>
        ///  This is the location of the top edge of the panel, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_total_win_t { get { return m_data.GetFloat("sim/graphics/view/panel_total_win_t");} }

        /// <summary>
        ///  This is the location of the left edge of the screen, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_win_l { get { return m_data.GetFloat("sim/graphics/view/panel_visible_win_l");} }

        /// <summary>
        ///  This is the location of the bottom edge of the screen, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_win_b { get { return m_data.GetFloat("sim/graphics/view/panel_visible_win_b");} }

        /// <summary>
        ///  This is the location of the right edge of the screen, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_win_r { get { return m_data.GetFloat("sim/graphics/view/panel_visible_win_r");} }

        /// <summary>
        ///  This is the location of the top edge of the screen, in the coordinate system used during plugin window drawing.
        /// </summary>
        public IXPDataRef<float> panel_visible_win_t { get { return m_data.GetFloat("sim/graphics/view/panel_visible_win_t");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, X
        /// </summary>
        public IXPDataRef<float> pilots_head_x { get { return m_data.GetFloat("sim/graphics/view/pilots_head_x");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, Y
        /// </summary>
        public IXPDataRef<float> pilots_head_y { get { return m_data.GetFloat("sim/graphics/view/pilots_head_y");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, Z
        /// </summary>
        public IXPDataRef<float> pilots_head_z { get { return m_data.GetFloat("sim/graphics/view/pilots_head_z");} }

        /// <summary>
        ///  Position of pilot's head heading
        /// </summary>
        public IXPDataRef<float> pilots_head_psi { get { return m_data.GetFloat("sim/graphics/view/pilots_head_psi");} }

        /// <summary>
        ///  Position of pilot's head pitch
        /// </summary>
        public IXPDataRef<float> pilots_head_the { get { return m_data.GetFloat("sim/graphics/view/pilots_head_the");} }

        /// <summary>
        ///  Position of the pilot's head roll'
        /// </summary>
        public IXPDataRef<float> pilots_head_phi { get { return m_data.GetFloat("sim/graphics/view/pilots_head_phi");} }

        /// <summary>
        ///  coordinates of the panel click in 3-d
        /// </summary>
        public IXPDataRef<float> click_3d_x { get { return m_data.GetFloat("sim/graphics/view/click_3d_x");} }

        /// <summary>
        ///  as texture coords (E.g. 0-1)
        /// </summary>
        public IXPDataRef<float> click_3d_y { get { return m_data.GetFloat("sim/graphics/view/click_3d_y");} }

        /// <summary>
        ///  coordinates of the panel click in 3-d
        /// </summary>
        public IXPDataRef<float> click_3d_x_pixels { get { return m_data.GetFloat("sim/graphics/view/click_3d_x_pixels");} }

        /// <summary>
        ///  as texture coords (E.g. 0-1)
        /// </summary>
        public IXPDataRef<float> click_3d_y_pixels { get { return m_data.GetFloat("sim/graphics/view/click_3d_y_pixels");} }

        /// <summary>
        ///  Bounds of the local map window during callbacks - left
        /// </summary>
        public IXPDataRef<float> local_map_l { get { return m_data.GetFloat("sim/graphics/view/local_map_l");} }

        /// <summary>
        ///  Bounds of the local map window during callbacks - bottom
        /// </summary>
        public IXPDataRef<float> local_map_b { get { return m_data.GetFloat("sim/graphics/view/local_map_b");} }

        /// <summary>
        ///  Bounds of the local map window during callbacks - right
        /// </summary>
        public IXPDataRef<float> local_map_r { get { return m_data.GetFloat("sim/graphics/view/local_map_r");} }

        /// <summary>
        ///  Bounds of the local map window during callbacks - top
        /// </summary>
        public IXPDataRef<float> local_map_t { get { return m_data.GetFloat("sim/graphics/view/local_map_t");} }

        /// <summary>
        ///  The horizontal offset for this pass, in degrees
        /// </summary>
        public IXPDataRef<float[]> dome_offset_heading { get { return m_data.GetFloatArray("sim/graphics/view/dome_offset_heading");} }

        /// <summary>
        ///  The vertical offset for this pass, in degrees
        /// </summary>
        public IXPDataRef<float[]> dome_offset_pitch { get { return m_data.GetFloatArray("sim/graphics/view/dome_offset_pitch");} }

        /// <summary>
        ///  Does the user have trackIR hardware enabled
        /// </summary>
        public IXPDataRef<bool> eq_trackir { get { return m_data.GetBool("sim/graphics/view/eq_trackir");} }

        /// <summary>
        ///  Is the yoke visible in the 3-d cockpit?
        /// </summary>
        public IXPDataRef<bool> hide_yoke { get { return m_data.GetBool("sim/graphics/view/hide_yoke");} }

        /// <summary>
        ///  The current projection matrix - valid only during draw callbacks
        /// </summary>
        public IXPDataRef<float[]> projection_matrix { get { return m_data.GetFloatArray("sim/graphics/view/projection_matrix");} }

        /// <summary>
        ///  The current modelview matrix to draw in standard "OGL" coordinates - valid only during draw callbacks
        /// </summary>
        public IXPDataRef<float[]> world_matrix { get { return m_data.GetFloatArray("sim/graphics/view/world_matrix");} }

        /// <summary>
        ///  A modelview matrix to draw in the user's aircraft coordinates - valid only during draw callbacks
        /// </summary>
        public IXPDataRef<float[]> acf_matrix { get { return m_data.GetFloatArray("sim/graphics/view/acf_matrix");} }
    }
}