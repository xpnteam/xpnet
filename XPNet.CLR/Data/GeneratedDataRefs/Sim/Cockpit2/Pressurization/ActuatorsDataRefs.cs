using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Pressurization_ActuatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Pressurization_ActuatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Dump all pressurization, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Dump_all_on { get { return m_data.GetBool("sim/cockpit2/pressurization/actuators/dump_all_on");} }

        /// <summary>
        ///  Cabin altitude commanded, feet.
        /// </summary>
        public IXPDataRef<float> Cabin_altitude_ft { get { return m_data.GetFloat("sim/cockpit2/pressurization/actuators/cabin_altitude_ft");} }

        /// <summary>
        ///  Cabin VVI commanded, feet.
        /// </summary>
        public IXPDataRef<float> Cabin_vvi_fpm { get { return m_data.GetFloat("sim/cockpit2/pressurization/actuators/cabin_vvi_fpm");} }

        /// <summary>
        ///  Maximum allowable altitude for this airplane to maintain the requested cabin altitude.
        /// </summary>
        public IXPDataRef<float> Max_allowable_altitude_ft { get { return m_data.GetFloat("sim/cockpit2/pressurization/actuators/max_allowable_altitude_ft");} }
    }
}