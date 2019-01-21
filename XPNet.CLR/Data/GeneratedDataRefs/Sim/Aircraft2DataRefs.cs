using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft2DataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft2DataRefs(IXPlaneData data)
        {
            m_data = data;
            engine = new sim_aircraft2_engineDataRefs(data);
        }
        public sim_aircraft2_engineDataRefs engine { get; }
    }
}