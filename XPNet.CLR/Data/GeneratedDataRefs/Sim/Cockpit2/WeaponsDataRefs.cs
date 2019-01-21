using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_weaponsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_weaponsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Weapon index selected on the weapon console.. Units:index
        ///  Raw path: sim/cockpit2/weapons/weapon_select_console_name
        /// </summary>
        public IXPDataRef<byte[]> weapon_select_console_name { get { return m_data.GetByteArray("sim/cockpit2/weapons/weapon_select_console_name");} }

        /// <summary>
        ///  Weapon fire-mode, 0=single, 1=pair, 2=ripple, 3=salvo.. Units:enum
        ///  Raw path: sim/cockpit2/weapons/fire_mode
        /// </summary>
        public IXPDataRef<int> fire_mode { get { return m_data.GetInt("sim/cockpit2/weapons/fire_mode");} }

        /// <summary>
        ///  Weapon fire-rate, 0, 1, 2, 3 depending on fire rate.. Units:enum
        ///  Raw path: sim/cockpit2/weapons/fire_rate
        /// </summary>
        public IXPDataRef<int> fire_rate { get { return m_data.GetInt("sim/cockpit2/weapons/fire_rate");} }

        /// <summary>
        ///  Switch position for each weapon-arming switch (there can be several). These are the rotaries that can be dialed up or down to select various systems.. Units:enum
        ///  Raw path: sim/cockpit2/weapons/weapon_selected
        /// </summary>
        public IXPDataRef<int> weapon_selected { get { return m_data.GetInt("sim/cockpit2/weapons/weapon_selected");} }

        /// <summary>
        ///  Heading offset of the gun from within its maximum heading range. Units:ratio
        ///  Raw path: sim/cockpit2/weapons/gun_offset_heading_ratio
        /// </summary>
        public IXPDataRef<float> gun_offset_heading_ratio { get { return m_data.GetFloat("sim/cockpit2/weapons/gun_offset_heading_ratio");} }

        /// <summary>
        ///  Pitch offset of the gun from within its maximum pitch range. Units:ratio
        ///  Raw path: sim/cockpit2/weapons/gun_offset_pitch_ratio
        /// </summary>
        public IXPDataRef<float> gun_offset_pitch_ratio { get { return m_data.GetFloat("sim/cockpit2/weapons/gun_offset_pitch_ratio");} }
    }
}