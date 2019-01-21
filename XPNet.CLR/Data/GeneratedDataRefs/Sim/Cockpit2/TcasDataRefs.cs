using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_tcasDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_tcasDataRefs(IXPlaneData data)
        {
            m_data = data;
            indicators = new sim_cockpit2_tcas_indicatorsDataRefs(data);
        }
        public sim_cockpit2_tcas_indicatorsDataRefs indicators { get; }
    }
}