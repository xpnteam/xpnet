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
        ///  max rotor trim aft when stick fully forward
        /// </summary>
        public IXPDataRef<float> Acf_rotor_trim_max_fwd { get { return m_data.GetFloat("sim/aircraft/vtolcontrols/acf_rotor_trim_max_fwd");} }

        /// <summary>
        ///  max rotor trim aft when stick fully aft
        /// </summary>
        public IXPDataRef<float> Acf_rotor_trim_max_aft { get { return m_data.GetFloat("sim/aircraft/vtolcontrols/acf_rotor_trim_max_aft");} }
    }
}