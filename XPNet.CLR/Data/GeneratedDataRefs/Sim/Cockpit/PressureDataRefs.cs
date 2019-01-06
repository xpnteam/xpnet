using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_PressureDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_PressureDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Bleeding air is on (legacy)
        /// </summary>
        public IXPDataRef<bool> Bleed_air_on { get { return m_data.GetBool("sim/cockpit/pressure/bleed_air_on");} }

        /// <summary>
        ///  Pressure dump switch
        /// </summary>
        public IXPDataRef<bool> Dump_all { get { return m_data.GetBool("sim/cockpit/pressure/dump_all");} }

        /// <summary>
        ///  Pressure dump to altitude switch
        /// </summary>
        public IXPDataRef<bool> Dump_to_alt { get { return m_data.GetBool("sim/cockpit/pressure/dump_to_alt");} }
    }
}