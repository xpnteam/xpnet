using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_networkDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_networkDatarefs(IXPlaneData data)
        {
            m_data = data;
            dataout = new sim_network_dataoutDatarefs(data);
            misc = new sim_network_miscDatarefs(data);
        }
        public sim_network_dataoutDatarefs dataout { get; }
        public sim_network_miscDatarefs misc { get; }
    }
}