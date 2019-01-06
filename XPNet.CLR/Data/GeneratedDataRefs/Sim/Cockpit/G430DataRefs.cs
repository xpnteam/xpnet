using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_g430Datarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_g430Datarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  enter com=0, enter_nav=1
        /// </summary>
        public IXPDataRef<int[]> g430_nav_com_sel { get { return m_data.GetIntArray("sim/cockpit/g430/g430_nav_com_sel");} }
    }
}