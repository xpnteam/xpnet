using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_WeaponsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_WeaponsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Heading offset of the gun from within its maximum heading range
        /// </summary>
        public IXPDataRef<float> Gun_offset_heading_ratio { get { return m_data.GetFloat("sim/cockpit2/weapons/gun_offset_heading_ratio");} }

        /// <summary>
        ///  Pitch offset of the gun from within its maximum pitch range
        /// </summary>
        public IXPDataRef<float> Gun_offset_pitch_ratio { get { return m_data.GetFloat("sim/cockpit2/weapons/gun_offset_pitch_ratio");} }
    }
}