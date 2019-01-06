using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_graphics_animation_ground_trafficDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_graphics_animation_ground_trafficDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> tire_steer_deg { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/tire_steer_deg");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float[]> tire_rotation_angle_deg { get { return m_data.GetFloatArray("sim/graphics/animation/ground_traffic/tire_rotation_angle_deg");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float[]> wiper_angle_deg { get { return m_data.GetFloatArray("sim/graphics/animation/ground_traffic/wiper_angle_deg");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> towbar_heading_deg { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/towbar_heading_deg");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> towbar_pitch_deg { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/towbar_pitch_deg");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> belt_loader_height_meters { get { return m_data.GetFloat("sim/graphics/animation/ground_traffic/belt_loader_height_meters");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float[]> door_open { get { return m_data.GetFloatArray("sim/graphics/animation/ground_traffic/door_open");} }
    }
}