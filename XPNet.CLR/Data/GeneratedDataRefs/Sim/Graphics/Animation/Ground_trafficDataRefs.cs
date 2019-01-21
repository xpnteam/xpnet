using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animation_ground_trafficDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animation_ground_trafficDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/tire_steer_deg
        /// </summary>
        public IXPDataRef<float> tire_steer_deg { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/tire_steer_deg");} }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/tire_rotation_angle_deg
        /// </summary>
        public IXPDataRef<float[]> tire_rotation_angle_deg { get { return m_data.GetFloatArray("sim/graphics/animation/ground_traffic/tire_rotation_angle_deg");} }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/wiper_angle_deg
        /// </summary>
        public IXPDataRef<float[]> wiper_angle_deg { get { return m_data.GetFloatArray("sim/graphics/animation/ground_traffic/wiper_angle_deg");} }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/towbar_heading_deg
        /// </summary>
        public IXPDataRef<float> towbar_heading_deg { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/towbar_heading_deg");} }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/towbar_pitch_deg
        /// </summary>
        public IXPDataRef<float> towbar_pitch_deg { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/towbar_pitch_deg");} }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/belt_loader_height_meters
        /// </summary>
        public IXPDataRef<float> belt_loader_height_meters { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/belt_loader_height_meters");} }

        /// <summary>
        ///  . Units:TODOV11
        ///  Raw path: sim/graphics/animation/ground_traffic/door_open
        /// </summary>
        public IXPDataRef<float[]> door_open { get { return m_data.GetFloatArray("sim/graphics/animation/ground_traffic/door_open");} }
    }
}