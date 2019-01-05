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
        ///  Cabin altitude commanded, feet.. Units:feet
        /// </summary>
        public IXPDataRef<float> Cabin_altitude_ft => m_data.GetFloat("sim/cockpit2/pressurization/actuators/cabin_altitude_ft");

        /// <summary>
        ///  Cabin VVI commanded, feet.. Units:feet/Minute
        /// </summary>
        public IXPDataRef<float> Cabin_vvi_fpm => m_data.GetFloat("sim/cockpit2/pressurization/actuators/cabin_vvi_fpm");

        /// <summary>
        ///  Maximum allowable altitude for this airplane to maintain the requested cabin altitude.. Units:feet
        /// </summary>
        public IXPDataRef<float> Max_allowable_altitude_ft => m_data.GetFloat("sim/cockpit2/pressurization/actuators/max_allowable_altitude_ft");
    }
}