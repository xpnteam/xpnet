using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_weaponsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_weaponsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Heading offset of the gun from within its maximum heading range
        /// </summary>
        public IXPDataRef<float> gun_offset_heading_ratio { get { return m_data.GetFloat("sim/cockpit2/weapons/gun_offset_heading_ratio");} }

        /// <summary>
        ///  Pitch offset of the gun from within its maximum pitch range
        /// </summary>
        public IXPDataRef<float> gun_offset_pitch_ratio { get { return m_data.GetFloat("sim/cockpit2/weapons/gun_offset_pitch_ratio");} }
    }
}