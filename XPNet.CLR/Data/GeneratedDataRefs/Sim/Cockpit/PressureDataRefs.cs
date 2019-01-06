using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_pressureDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_pressureDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Bleeding air is on (legacy). Units:bool
        ///  Raw path: sim/cockpit/pressure/bleed_air_on
        /// </summary>
        public IXPDataRef<bool> bleed_air_on { get { return m_data.GetBool("sim/cockpit/pressure/bleed_air_on");} }

        /// <summary>
        ///  . Units:enum
        ///  Raw path: sim/cockpit/pressure/bleed_air_mode
        /// </summary>
        public IXPDataRef<int> bleed_air_mode { get { return m_data.GetInt("sim/cockpit/pressure/bleed_air_mode");} }

        /// <summary>
        ///  Pressure dump switch. Units:bool
        ///  Raw path: sim/cockpit/pressure/dump_all
        /// </summary>
        public IXPDataRef<bool> dump_all { get { return m_data.GetBool("sim/cockpit/pressure/dump_all");} }

        /// <summary>
        ///  Pressure dump to altitude switch. Units:bool
        ///  Raw path: sim/cockpit/pressure/dump_to_alt
        /// </summary>
        public IXPDataRef<bool> dump_to_alt { get { return m_data.GetBool("sim/cockpit/pressure/dump_to_alt");} }
    }
}