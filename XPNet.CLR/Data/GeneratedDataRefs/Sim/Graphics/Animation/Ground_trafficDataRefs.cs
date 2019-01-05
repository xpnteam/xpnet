using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_Animation_Ground_trafficDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_Animation_Ground_trafficDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float> Tire_steer_deg => m_data.GetFloat("sim/graphics/animation/ground_traffic/tire_steer_deg");

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float[]> Tire_rotation_angle_deg => m_data.GetFloatArray("sim/graphics/animation/ground_traffic/tire_rotation_angle_deg");

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float[]> Wiper_angle_deg => m_data.GetFloatArray("sim/graphics/animation/ground_traffic/wiper_angle_deg");

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float> Towbar_heading_deg => m_data.GetFloat("sim/graphics/animation/ground_traffic/towbar_heading_deg");

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float> Towbar_pitch_deg => m_data.GetFloat("sim/graphics/animation/ground_traffic/towbar_pitch_deg");

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float> Belt_loader_height_meters => m_data.GetFloat("sim/graphics/animation/ground_traffic/belt_loader_height_meters");

        /// <summary>
        ///  . Units:TODOV11
        /// </summary>
        public IXPDataRef<float[]> Door_open => m_data.GetFloatArray("sim/graphics/animation/ground_traffic/door_open");
    }
}