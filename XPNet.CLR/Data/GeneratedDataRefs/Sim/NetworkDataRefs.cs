using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_networkDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_networkDataRefs(IXPlaneData data)
        {
            m_data = data;
            dataout = new sim_network_dataoutDataRefs(data);
            misc = new sim_network_miscDataRefs(data);
        }
        public sim_network_dataoutDataRefs dataout { get; }
        public sim_network_miscDataRefs misc { get; }
    }
}