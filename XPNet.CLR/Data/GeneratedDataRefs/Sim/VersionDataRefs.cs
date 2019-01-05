using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_VersionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_VersionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
        public IXPDataRef<string> Sim_build_string => m_data.GetString("sim/version/sim_build_string");
        public IXPDataRef<string> Xplm_build_string => m_data.GetString("sim/version/xplm_build_string");
    }
}