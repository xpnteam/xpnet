using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_TransmissionsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_TransmissionsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Indicators = new Sim_Cockpit2_Transmissions_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Transmissions_IndicatorsDatarefs Indicators { get; }
    }
}