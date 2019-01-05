using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_VtolcontrolsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_VtolcontrolsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  max rotor trim aft when stick fully forward. Units:degrees
        /// </summary>
        public IXPDataRef<float> Acf_rotor_trim_max_fwd => m_data.GetFloat("sim/aircraft/vtolcontrols/acf_rotor_trim_max_fwd");

        /// <summary>
        ///  max rotor trim aft when stick fully aft. Units:degrees
        /// </summary>
        public IXPDataRef<float> Acf_rotor_trim_max_aft => m_data.GetFloat("sim/aircraft/vtolcontrols/acf_rotor_trim_max_aft");
    }
}