using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animationDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animationDataRefs(IXPlaneData data)
        {
            m_data = data;
            birds = new sim_graphics_animation_birdsDataRefs(data);
            deer = new sim_graphics_animation_deerDataRefs(data);
            lights = new sim_graphics_animation_lightsDataRefs(data);
            ground_traffic = new sim_graphics_animation_ground_trafficDataRefs(data);
        }
        public sim_graphics_animation_birdsDataRefs birds { get; }
        public sim_graphics_animation_deerDataRefs deer { get; }
        public sim_graphics_animation_lightsDataRefs lights { get; }
        public sim_graphics_animation_ground_trafficDataRefs ground_traffic { get; }

        /// <summary>
        ///  X position in cartesian space of currently drawn object. Units:float
        ///  Raw path: sim/graphics/animation/draw_object_x
        /// </summary>
        public IXPDataRef<float> draw_object_x { get { return m_data.GetFloat("sim/graphics/animation/draw_object_x");} }

        /// <summary>
        ///  Y position in cartesian space of currently drawn object. Units:float
        ///  Raw path: sim/graphics/animation/draw_object_y
        /// </summary>
        public IXPDataRef<float> draw_object_y { get { return m_data.GetFloat("sim/graphics/animation/draw_object_y");} }

        /// <summary>
        ///  Z position in cartesian space of currently drawn object. Units:float
        ///  Raw path: sim/graphics/animation/draw_object_z
        /// </summary>
        public IXPDataRef<float> draw_object_z { get { return m_data.GetFloat("sim/graphics/animation/draw_object_z");} }

        /// <summary>
        ///  rotation in cartesian space of currently drawn object. Units:float
        ///  Raw path: sim/graphics/animation/draw_object_psi
        /// </summary>
        public IXPDataRef<float> draw_object_psi { get { return m_data.GetFloat("sim/graphics/animation/draw_object_psi");} }

        /// <summary>
        ///  This is the default _LIT light level that the object is being drawn at, before ATTR_light_level is applied.. Units:float
        ///  Raw path: sim/graphics/animation/draw_light_level
        /// </summary>
        public IXPDataRef<float> draw_light_level { get { return m_data.GetFloat("sim/graphics/animation/draw_light_level");} }

        /// <summary>
        ///  angle this beacon is rotating (0-360). Units:degrees
        ///  Raw path: sim/graphics/animation/airport_beacon_rotation
        /// </summary>
        public IXPDataRef<float> airport_beacon_rotation { get { return m_data.GetFloat("sim/graphics/animation/airport_beacon_rotation");} }

        /// <summary>
        ///  windsock heading. Units:degrees
        ///  Raw path: sim/graphics/animation/windsock_psi
        /// </summary>
        public IXPDataRef<float> windsock_psi { get { return m_data.GetFloat("sim/graphics/animation/windsock_psi");} }

        /// <summary>
        ///  windsock pitch. Units:degrees
        ///  Raw path: sim/graphics/animation/windsock_the
        /// </summary>
        public IXPDataRef<float> windsock_the { get { return m_data.GetFloat("sim/graphics/animation/windsock_the");} }

        /// <summary>
        ///  windsock roll. Units:degrees
        ///  Raw path: sim/graphics/animation/windsock_phi
        /// </summary>
        public IXPDataRef<float> windsock_phi { get { return m_data.GetFloat("sim/graphics/animation/windsock_phi");} }

        /// <summary>
        ///  crane heading. Units:ratio
        ///  Raw path: sim/graphics/animation/crane_psi
        /// </summary>
        public IXPDataRef<float> crane_psi { get { return m_data.GetFloat("sim/graphics/animation/crane_psi");} }

        /// <summary>
        ///  how high above MSL 0 is this buoy riding?. Units:meters
        ///  Raw path: sim/graphics/animation/buoy_height
        /// </summary>
        public IXPDataRef<float> buoy_height { get { return m_data.GetFloat("sim/graphics/animation/buoy_height");} }

        /// <summary>
        ///  ratio -1 to 1. Units:ratio -1 to 1
        ///  Raw path: sim/graphics/animation/ping_pong_2
        /// </summary>
        public IXPDataRef<float> ping_pong_2 { get { return m_data.GetFloat("sim/graphics/animation/ping_pong_2");} }

        /// <summary>
        ///  ratio -1 to 1. Units:ratio -1 to 1
        ///  Raw path: sim/graphics/animation/sin_wave_2
        /// </summary>
        public IXPDataRef<float> sin_wave_2 { get { return m_data.GetFloat("sim/graphics/animation/sin_wave_2");} }

        /// <summary>
        ///  Brightness of the wig-wag lights - stays in sync with sim/graphics/animation/lights/wigwag. Units:ratio
        ///  Raw path: sim/graphics/animation/obj_wigwag_brightness
        /// </summary>
        public IXPDataRef<float> obj_wigwag_brightness { get { return m_data.GetFloat("sim/graphics/animation/obj_wigwag_brightness");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (left front). Units:ratio
        ///  Raw path: sim/graphics/animation/carrier_blast_def_lf
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_lf { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_lf");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (right front). Units:ratio
        ///  Raw path: sim/graphics/animation/carrier_blast_def_rf
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_rf { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_rf");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (left rear). Units:ratio
        ///  Raw path: sim/graphics/animation/carrier_blast_def_lr
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_lr { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_lr");} }

        /// <summary>
        ///  Ratio of deployment of carrier blast door (right rear). Units:ratio
        ///  Raw path: sim/graphics/animation/carrier_blast_def_rr
        /// </summary>
        public IXPDataRef<float> carrier_blast_def_rr { get { return m_data.GetFloat("sim/graphics/animation/carrier_blast_def_rr");} }

        /// <summary>
        ///  Ratio of the position of all level crossing gates, 0 is up, 1 is down. Units:ratio
        ///  Raw path: sim/graphics/animation/level_crossing_gate
        /// </summary>
        public IXPDataRef<float> level_crossing_gate { get { return m_data.GetFloat("sim/graphics/animation/level_crossing_gate");} }
    }
}