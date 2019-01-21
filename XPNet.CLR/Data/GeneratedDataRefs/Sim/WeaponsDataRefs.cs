using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_weaponsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_weaponsDataRefs(IXPlaneData data)
        {
            m_data = data;
            shell = new sim_weapons_shellDataRefs(data);
        }
        public sim_weapons_shellDataRefs shell { get; }

        /// <summary>
        ///  This is the number of weapons available via datarefs.. Units:int
        ///  Raw path: sim/weapons/weapon_count
        /// </summary>
        public IXPDataRef<int> weapon_count { get { return m_data.GetInt("sim/weapons/weapon_count");} }

        /// <summary>
        ///  0 = In carriage/still in the gun/reloaded, 1 = firing, and 2 = destroyed. Units:enum
        ///  Raw path: sim/weapons/action_mode
        /// </summary>
        public IXPDataRef<int[]> action_mode { get { return m_data.GetIntArray("sim/weapons/action_mode");} }

        /// <summary>
        ///  Angle relative to the aircraft. Units:Deg
        ///  Raw path: sim/weapons/the
        /// </summary>
        public IXPDataRef<float[]> the { get { return m_data.GetFloatArray("sim/weapons/the");} }

        /// <summary>
        ///  Angle relative to the aircraft. Units:Deg
        ///  Raw path: sim/weapons/psi
        /// </summary>
        public IXPDataRef<float[]> psi { get { return m_data.GetFloatArray("sim/weapons/psi");} }

        /// <summary>
        ///  Angle relative to the aircraft. Units:Deg
        ///  Raw path: sim/weapons/phi
        /// </summary>
        public IXPDataRef<float[]> phi { get { return m_data.GetFloatArray("sim/weapons/phi");} }
    }
}