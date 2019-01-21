using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_hydraulicsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_hydraulicsDataRefs(IXPlaneData data)
        {
            m_data = data;
            indicators = new sim_cockpit2_hydraulics_indicatorsDataRefs(data);
        }
        public sim_cockpit2_hydraulics_indicatorsDataRefs indicators { get; }
    }
}