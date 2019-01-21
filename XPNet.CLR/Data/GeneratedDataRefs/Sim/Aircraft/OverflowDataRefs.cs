using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_overflowDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_overflowDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  amount the stab moves in trim automatically as you go to redline (zero at zero airspeed). Units:degree
        ///  Raw path: sim/aircraft/overflow/acf_stab_delinc_to_Vne
        /// </summary>
        public IXPDataRef<float> acf_stab_delinc_to_Vne { get { return m_data.GetFloat("sim/aircraft/overflow/acf_stab_delinc_to_vne");} }

        /// <summary>
        ///  max pressurization of the fuselage. Units:pascals
        ///  Raw path: sim/aircraft/overflow/acf_max_press_diff
        /// </summary>
        public IXPDataRef<float> acf_max_press_diff { get { return m_data.GetFloat("sim/aircraft/overflow/acf_max_press_diff");} }

        /// <summary>
        ///  number fuel tanks - as of 860, all planes have 9 tanks and ratios for each - ratio of 0.0 means tank is not used. Units:count
        ///  Raw path: sim/aircraft/overflow/acf_num_tanks
        /// </summary>
        public IXPDataRef<int> acf_num_tanks { get { return m_data.GetInt("sim/aircraft/overflow/acf_num_tanks");} }

        /// <summary>
        ///  auto-trim out any flight loads... numerous planes have this.. Units:boolean
        ///  Raw path: sim/aircraft/overflow/acf_auto_trimEQ
        /// </summary>
        public IXPDataRef<bool> acf_auto_trimEQ { get { return m_data.GetBool("sim/aircraft/overflow/acf_auto_trimeq");} }

        /// <summary>
        ///  Aircraft has Fuel selector. Units:boolean
        ///  Raw path: sim/aircraft/overflow/acf_has_fuel_any
        /// </summary>
        public IXPDataRef<bool> acf_has_fuel_any { get { return m_data.GetBool("sim/aircraft/overflow/acf_has_fuel_any");} }
    }
}