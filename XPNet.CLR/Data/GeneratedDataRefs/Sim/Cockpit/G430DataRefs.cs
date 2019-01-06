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
    }
}