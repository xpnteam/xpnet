using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animationDatarefs(IXPlaneData data)
        {
            m_data = data;
            birds = new sim_graphics_animation_birdsDatarefs(data);
            deer = new sim_graphics_animation_deerDatarefs(data);
            lights = new sim_graphics_animation_lightsDatarefs(data);
            ground_traffic = new sim_graphics_animation_ground_trafficDatarefs(data);
        }
        public sim_graphics_animation_birdsDatarefs birds { get; }
        public sim_graphics_animation_deerDatarefs deer { get; }
        public sim_graphics_animation_lightsDatarefs lights { get; }
        public sim_graphics_animation_ground_trafficDatarefs ground_traffic { get; }

        /// <summary>
        ///  X position in cartesian space of currently drawn object
        /// </summary>
        public IXPDataRef<float> draw_object_x { get { return m_data.GetFloat("sim/graphics/animation/draw_object_x");} }

        /// <summary>
        ///  Y position in cartesian space of currently drawn object
        /// </summary>
        public IXPDataRef<float> draw_object_y { get { return m_data.GetFloat("sim/graphics/animation/draw_object_y");} }

        /// <summary>
        ///  Z position in cartesian space of currently drawn object
        /// </summary>
        public IXPDataRef<float> draw_object_z { get { return m_data.GetFloat("sim/graphics/animation/draw_object_z");} }

        /// <summary>
        ///  rotation in cartesian space of currently drawn object
        /// </summary>
        public IXPDataRef<float> draw_object_psi { get { return m_data.GetFloat("sim/graphics/animation/draw_object_psi");} }

        /// <summary>
        ///  This is the default _LIT light level that the object is being drawn at, before ATTR_light_level is applied.
        /// </summary>
        public IXPDataRef<float> draw_light_level { get { return m_data.GetFloat("sim/graphics/animation/draw_light_level");} }

        /// <summary>
        ///  angle this beacon is rotating (0-360)
        /// </summary>
        public IXPDataRef<float> airport_beacon_rotation { get { return m_data.GetFloat("sim/graphics/animation/airport_beacon_rotation");} }

        /// <summary>
        ///  windsock heading
        /// </summary>
        public IXPDataRef<float> windsock_psi { get { return m_data.GetFloat("sim/graphics/animation/windsock_psi");} }

        /// <summary>
        ///  windsock pitch
        /// </summary>
        public IXPDataRef<float> windsock_the { get { return m_data.GetFloat("sim/graphics/animation/windsock_the");} }

        /// <summary>
        ///  windsock roll
        /// </summary>
        public IXPDataRef<float> windsock_phi { get { return m_data.GetFloat("sim/graphics/animation/windsock_phi");} }

        /// <summary>
        ///  crane heading
        /// </summary>
        public IXPDataRef<float> crane_psi { get { return m_data.GetFloat("sim/graphics/animation/crane_psi");} }

        /// <summary>
        ///  how high above MSL 0 is this buoy riding?
        /// </summary>
        public IXPDataRef<float> buoy_height { get { return m_data.GetFloat("sim/graphics/animation/buoy_height");} }

        /// <summary>
        ///  ratio -1 to 1
        /// </summary>
        public IXPDataRef<float> ping_pong_2 { get { return m_data.GetFloat("sim/graphics/animation/ping_pong_2");} }

        /// <summary>
        ///  ratio -1 to 1
        /// </summary>
        public IXPDataRef<float> sin_wave_2 { get { return m_data.GetFloat("sim/graphics/animation/sin_wave_2");} }

        /// <summary>
        ///  Brightness of the wig-wag lights - stays in sync with sim/graphics/animation/lights/wigwag
        /// </summary>
        public IXPDataRef<float> obj_wigwag_brightness { get { return m_data.GetFloat("sim/graphics/animation/obj_wigwag_brightness");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (left front)
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_lf { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_lf");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (right front)
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_rf { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_rf");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (left rear)
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_lr { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_lr");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (right rear)
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_rr { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_rr");} }

        /// <summary>
        ///  Ratio of the position of all level crossing gates, 0 is up, 1 is down
        /// </summary>
        public IXPDataRef<float> level_crossing_gate { get { return m_data.GetFloat("sim/graphics/animation/level_crossing_gate");} }
    }
}