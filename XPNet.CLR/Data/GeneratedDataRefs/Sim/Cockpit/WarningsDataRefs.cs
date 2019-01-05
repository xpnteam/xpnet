using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_WarningsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_WarningsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Annunciators = new Sim_Cockpit_Warnings_AnnunciatorsDatarefs(data);
        }
        public Sim_Cockpit_Warnings_AnnunciatorsDatarefs Annunciators { get; }
    }
}