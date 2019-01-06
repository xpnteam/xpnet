using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_versionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_versionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This string contains the date and time that this x-plane was built.
        /// </summary>
        public IXPDataRef<string> sim_build_string { get { return m_data.GetString("sim/version/sim_build_string");} }

        /// <summary>
        ///  This string contains the date and time that the XPLM DLL was built.
        /// </summary>
        public IXPDataRef<string> xplm_build_string { get { return m_data.GetString("sim/version/xplm_build_string");} }
    }
}