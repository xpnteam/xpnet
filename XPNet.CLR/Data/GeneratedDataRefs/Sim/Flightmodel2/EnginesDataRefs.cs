using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_EnginesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_EnginesDatarefs(IXPlaneData data)
        {
            m_data = data;
            Prop_disc = new Sim_Flightmodel2_Engines_Prop_discDatarefs(data);
        }
        public Sim_Flightmodel2_Engines_Prop_discDatarefs Prop_disc { get; }
    }
}