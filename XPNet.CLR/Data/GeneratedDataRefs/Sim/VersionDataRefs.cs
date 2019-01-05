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

        /// <summary>
        ///  This string contains the date and time that this x-plane was built.
        /// </summary>
        public IXPDataRef<string> Sim_build_string => m_data.GetString("sim/version/sim_build_string");

        /// <summary>
        ///  This string contains the date and time that the XPLM DLL was built.
        /// </summary>
        public IXPDataRef<string> Xplm_build_string => m_data.GetString("sim/version/xplm_build_string");
    }
}