using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_WeaponsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_WeaponsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Shell = new Sim_Weapons_ShellDatarefs(data);
        }
        public Sim_Weapons_ShellDatarefs Shell { get; }
    }
}