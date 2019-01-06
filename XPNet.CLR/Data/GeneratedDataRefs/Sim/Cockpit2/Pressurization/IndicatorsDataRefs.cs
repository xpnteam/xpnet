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
        ///  Cabin altitude actually occurring, feet.
        /// </summary>
        public IXPDataRef<float> Cabin_altitude_ft { get { return m_data.GetFloat("sim/cockpit2/pressurization/indicators/cabin_altitude_ft");} }

        /// <summary>
        ///  Cabin VVI actually occurring, fpm.
        /// </summary>
        public IXPDataRef<float> Cabin_vvi_fpm { get { return m_data.GetFloat("sim/cockpit2/pressurization/indicators/cabin_vvi_fpm");} }

        /// <summary>
        ///  Cabin differential pressure, psi.
        /// </summary>
        public IXPDataRef<float> Pressure_diffential_psi { get { return m_data.GetFloat("sim/cockpit2/pressurization/indicators/pressure_diffential_psi");} }
    }
}