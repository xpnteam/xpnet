using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_OverflowDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_OverflowDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  amount the stab moves in trim automatically as you go to redline (zero at zero airspeed)
        /// </summary>
        public IXPDataRef<float> Acf_stab_delinc_to_Vne { get { return m_data.GetFloat("sim/aircraft/overflow/acf_stab_delinc_to_vne");} }

        /// <summary>
        ///  max pressurization of the fuselage
        /// </summary>
        public IXPDataRef<float> Acf_max_press_diff { get { return m_data.GetFloat("sim/aircraft/overflow/acf_max_press_diff");} }

        /// <summary>
        ///  auto-trim out any flight loads... numerous planes have this.
        /// </summary>
        public IXPDataRef<bool> Acf_auto_trimEQ { get { return m_data.GetBool("sim/aircraft/overflow/acf_auto_trimeq");} }

        /// <summary>
        ///  Aircraft has Fuel selector
        /// </summary>
        public IXPDataRef<bool> Acf_has_fuel_any { get { return m_data.GetBool("sim/aircraft/overflow/acf_has_fuel_any");} }
    }
}