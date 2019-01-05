using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_PrefsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_PrefsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Misc = new Sim_Operation_Prefs_MiscDatarefs(data);
        }
        public Sim_Operation_Prefs_MiscDatarefs Misc { get; }
    }
}