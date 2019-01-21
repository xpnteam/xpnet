using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_vtolcontrolsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_vtolcontrolsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  max rotor trim aft when stick fully forward. Units:degrees
        ///  Raw path: sim/aircraft/vtolcontrols/acf_rotor_trim_max_fwd
        /// </summary>
        public IXPDataRef<float> acf_rotor_trim_max_fwd { get { return m_data.GetFloat("sim/aircraft/vtolcontrols/acf_rotor_trim_max_fwd");} }

        /// <summary>
        ///  max rotor trim aft when stick fully aft. Units:degrees
        ///  Raw path: sim/aircraft/vtolcontrols/acf_rotor_trim_max_aft
        /// </summary>
        public IXPDataRef<float> acf_rotor_trim_max_aft { get { return m_data.GetFloat("sim/aircraft/vtolcontrols/acf_rotor_trim_max_aft");} }
    }
}