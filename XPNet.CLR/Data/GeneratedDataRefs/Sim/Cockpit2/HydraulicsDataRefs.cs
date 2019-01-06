using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_hydraulicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_hydraulicsDatarefs(IXPlaneData data)
        {
            m_data = data;
            indicators = new sim_cockpit2_hydraulics_indicatorsDatarefs(data);
        }
        public sim_cockpit2_hydraulics_indicatorsDatarefs indicators { get; }
    }
}