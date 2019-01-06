using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_systemsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_systemsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  If this is true, commands to engage the AP servos will be ignored if the FD is not on.
        /// </summary>
        public IXPDataRef<bool> fdir_needed_to_engage_servos { get { return m_data.GetBool("sim/aircraft/systems/fdir_needed_to_engage_servos");} }
    }
}