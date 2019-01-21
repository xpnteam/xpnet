using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_g430DataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_g430DataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  If true, vertical guidance is a glide slope - otherwise it is a GPS vertical guidance indicator.  Comes from the physical units!. Units:boolean
        ///  Raw path: sim/operation/g430/G430_is_vloc
        /// </summary>
        public IXPDataRef<bool[]> G430_is_vloc { get { return m_data.GetBoolArray("sim/operation/g430/g430_is_vloc");} }
    }
}