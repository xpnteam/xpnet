using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_tcasDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_tcasDatarefs(IXPlaneData data)
        {
            m_data = data;
            indicators = new sim_cockpit2_tcas_indicatorsDatarefs(data);
        }
        public sim_cockpit2_tcas_indicatorsDatarefs indicators { get; }
    }
}