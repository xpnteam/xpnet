using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_weaponsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_weaponsDatarefs(IXPlaneData data)
        {
            m_data = data;
            shell = new sim_weapons_shellDatarefs(data);
        }
        public sim_weapons_shellDatarefs shell { get; }

        /// <summary>
        ///  Angle relative to the aircraft
        /// </summary>
        public IXPDataRef<float[]> the { get { return m_data.GetFloatArray("sim/weapons/the");} }

        /// <summary>
        ///  Angle relative to the aircraft
        /// </summary>
        public IXPDataRef<float[]> psi { get { return m_data.GetFloatArray("sim/weapons/psi");} }

        /// <summary>
        ///  Angle relative to the aircraft
        /// </summary>
        public IXPDataRef<float[]> phi { get { return m_data.GetFloatArray("sim/weapons/phi");} }
    }
}