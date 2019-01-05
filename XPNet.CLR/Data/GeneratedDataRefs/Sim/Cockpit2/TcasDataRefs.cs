using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_TcasDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_TcasDatarefs(IXPlaneData data)
        {
            m_data = data;
            Indicators = new Sim_Cockpit2_Tcas_IndicatorsDatarefs(data);
        }
        public Sim_Cockpit2_Tcas_IndicatorsDatarefs Indicators { get; }
    }
}