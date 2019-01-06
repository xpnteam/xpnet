using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_GearDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_GearDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Are any of the gear on this plane retractable.  We strongly recommend you DO NOT write to this dataref.
        /// </summary>
        public IXPDataRef<bool> Acf_gear_retract { get { return m_data.GetBool("sim/aircraft/gear/acf_gear_retract");} }
    }
}