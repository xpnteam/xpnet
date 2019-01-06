using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_pressurization_indicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_pressurization_indicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Cabin altitude actually occurring, feet.. Units:feet
        ///  Raw path: sim/cockpit2/pressurization/indicators/cabin_altitude_ft
        /// </summary>
        public IXPDataRef<float> cabin_altitude_ft { get { return m_data.GetFloat("sim/cockpit2/pressurization/indicators/cabin_altitude_ft");} }

        /// <summary>
        ///  Cabin VVI actually occurring, fpm.. Units:feet/minute
        ///  Raw path: sim/cockpit2/pressurization/indicators/cabin_vvi_fpm
        /// </summary>
        public IXPDataRef<float> cabin_vvi_fpm { get { return m_data.GetFloat("sim/cockpit2/pressurization/indicators/cabin_vvi_fpm");} }

        /// <summary>
        ///  Cabin differential pressure, psi.. Units:pounds/square_inch
        ///  Raw path: sim/cockpit2/pressurization/indicators/pressure_diffential_psi
        /// </summary>
        public IXPDataRef<float> pressure_diffential_psi { get { return m_data.GetFloat("sim/cockpit2/pressurization/indicators/pressure_diffential_psi");} }
    }
}