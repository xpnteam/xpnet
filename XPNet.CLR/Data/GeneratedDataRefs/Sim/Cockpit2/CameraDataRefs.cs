using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_cameraDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_cameraDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  In-cockpit camera angular offset relative to airplane orientation (Pitch). Units:degrees
        ///  Raw path: sim/cockpit2/camera/camera_offset_pitch
        /// </summary>
        public IXPDataRef<float> camera_offset_pitch { get { return m_data.GetFloat("sim/cockpit2/camera/camera_offset_pitch");} }

        /// <summary>
        ///  In-cockpit camera angular offset relative to airplane orientation (Heading). Units:degrees
        ///  Raw path: sim/cockpit2/camera/camera_offset_heading
        /// </summary>
        public IXPDataRef<float> camera_offset_heading { get { return m_data.GetFloat("sim/cockpit2/camera/camera_offset_heading");} }

        /// <summary>
        ///  In-cockpit camera angular offset relative to airplane orientation (Roll). Units:degrees
        ///  Raw path: sim/cockpit2/camera/camera_offset_roll
        /// </summary>
        public IXPDataRef<float> camera_offset_roll { get { return m_data.GetFloat("sim/cockpit2/camera/camera_offset_roll");} }

        /// <summary>
        ///  In-cockpit camera field of view. Units:degrees
        ///  Raw path: sim/cockpit2/camera/camera_field_of_view
        /// </summary>
        public IXPDataRef<float> camera_field_of_view { get { return m_data.GetFloat("sim/cockpit2/camera/camera_field_of_view");} }
    }
}