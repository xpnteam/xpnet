using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_CameraDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_CameraDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  In-cockpit camera angular offset relative to airplane orientation (Pitch)
        /// </summary>
        public IXPDataRef<float> Camera_offset_pitch { get { return m_data.GetFloat("sim/cockpit2/camera/camera_offset_pitch");} }

        /// <summary>
        ///  In-cockpit camera angular offset relative to airplane orientation (Heading)
        /// </summary>
        public IXPDataRef<float> Camera_offset_heading { get { return m_data.GetFloat("sim/cockpit2/camera/camera_offset_heading");} }

        /// <summary>
        ///  In-cockpit camera angular offset relative to airplane orientation (Roll)
        /// </summary>
        public IXPDataRef<float> Camera_offset_roll { get { return m_data.GetFloat("sim/cockpit2/camera/camera_offset_roll");} }

        /// <summary>
        ///  In-cockpit camera field of view
        /// </summary>
        public IXPDataRef<float> Camera_field_of_view { get { return m_data.GetFloat("sim/cockpit2/camera/camera_field_of_view");} }
    }
}