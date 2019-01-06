using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_gearDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_gearDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Are any of the gear on this plane retractable.  We strongly recommend you DO NOT write to this dataref.. Units:bool
        ///  Raw path: sim/aircraft/gear/acf_gear_retract
        /// </summary>
        public IXPDataRef<bool> acf_gear_retract { get { return m_data.GetBool("sim/aircraft/gear/acf_gear_retract");} }
    }
}