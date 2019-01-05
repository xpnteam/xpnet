using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_NetworkDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_NetworkDatarefs(IXPlaneData data)
        {
            m_data = data;
            Dataout = new Sim_Network_DataoutDatarefs(data);
            Misc = new Sim_Network_MiscDatarefs(data);
        }
        public Sim_Network_DataoutDatarefs Dataout { get; }
        public Sim_Network_MiscDatarefs Misc { get; }
    }
}