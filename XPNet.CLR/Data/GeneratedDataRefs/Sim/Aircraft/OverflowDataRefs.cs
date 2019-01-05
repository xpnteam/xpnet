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
        ///  amount the stab moves in trim automatically as you go to redline (zero at zero airspeed). Units:degree
        /// </summary>
        public IXPDataRef<float> Acf_stab_delinc_to_Vne => m_data.GetFloat("sim/aircraft/overflow/acf_stab_delinc_to_vne");

        /// <summary>
        ///  max pressurization of the fuselage. Units:pascals
        /// </summary>
        public IXPDataRef<float> Acf_max_press_diff => m_data.GetFloat("sim/aircraft/overflow/acf_max_press_diff");
    }
}