using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_pressurization_actuatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_pressurization_actuatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Bleed air mode, 0=of, 1=left,2=both,3=right,4=apu,5=auto
        /// </summary>
        public IXPDataRef<int> bleed_air_mode { get { return m_data.GetInt("sim/cockpit2/pressurization/actuators/bleed_air_mode");} }

        /// <summary>
        ///  Dump all pressurization, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> dump_all_on { get { return m_data.GetBool("sim/cockpit2/pressurization/actuators/dump_all_on");} }

        /// <summary>
        ///  Dump pressurization to the current altitude, 0 or 1.
        /// </summary>
        public IXPDataRef<int> dump_to_altitude_on { get { return m_data.GetInt("sim/cockpit2/pressurization/actuators/dump_to_altitude_on");} }

        /// <summary>
        ///  Cabin altitude commanded, feet.
        /// </summary>
        public IXPDataRef<float> cabin_altitude_ft { get { return m_data.GetFloat("sim/cockpit2/pressurization/actuators/cabin_altitude_ft");} }

        /// <summary>
        ///  Cabin VVI commanded, feet.
        /// </summary>
        public IXPDataRef<float> cabin_vvi_fpm { get { return m_data.GetFloat("sim/cockpit2/pressurization/actuators/cabin_vvi_fpm");} }

        /// <summary>
        ///  Maximum allowable altitude for this airplane to maintain the requested cabin altitude.
        /// </summary>
        public IXPDataRef<float> max_allowable_altitude_ft { get { return m_data.GetFloat("sim/cockpit2/pressurization/actuators/max_allowable_altitude_ft");} }
    }
}