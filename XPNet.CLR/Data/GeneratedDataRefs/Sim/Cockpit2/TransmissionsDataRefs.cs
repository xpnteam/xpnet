using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_transmissionsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_transmissionsDataRefs(IXPlaneData data)
        {
            m_data = data;
            indicators = new sim_cockpit2_transmissions_indicatorsDataRefs(data);
        }
        public sim_cockpit2_transmissions_indicatorsDataRefs indicators { get; }
    }
}