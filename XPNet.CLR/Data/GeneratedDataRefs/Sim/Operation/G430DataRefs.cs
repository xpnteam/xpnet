using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_G430Datarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_G430Datarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  If true, vertical guidance is a glide slope - otherwise it is a GPS vertical guidance indicator.  Comes from the physical units!
        /// </summary>
        public IXPDataRef<bool[]> G430_is_vloc { get { return m_data.GetBoolArray("sim/operation/g430/g430_is_vloc");} }
    }
}