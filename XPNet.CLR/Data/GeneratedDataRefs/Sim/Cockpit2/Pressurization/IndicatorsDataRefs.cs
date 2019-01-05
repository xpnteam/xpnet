using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Pressurization_IndicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Pressurization_IndicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Cabin altitude actually occurring, feet.. Units:feet
        /// </summary>
        public IXPDataRef<float> Cabin_altitude_ft => m_data.GetFloat("sim/cockpit2/pressurization/indicators/cabin_altitude_ft");

        /// <summary>
        ///  Cabin VVI actually occurring, fpm.. Units:feet/Minute
        /// </summary>
        public IXPDataRef<float> Cabin_vvi_fpm => m_data.GetFloat("sim/cockpit2/pressurization/indicators/cabin_vvi_fpm");

        /// <summary>
        ///  Cabin differential pressure, psi.. Units:pounds/Square_inch
        /// </summary>
        public IXPDataRef<float> Pressure_diffential_psi => m_data.GetFloat("sim/cockpit2/pressurization/indicators/pressure_diffential_psi");
    }
}