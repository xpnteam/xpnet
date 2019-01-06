using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft2Datarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft2Datarefs(IXPlaneData data)
        {
            m_data = data;
            engine = new sim_aircraft2_engineDatarefs(data);
        }
        public sim_aircraft2_engineDatarefs engine { get; }
    }
}