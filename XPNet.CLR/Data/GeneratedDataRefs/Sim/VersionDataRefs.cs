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
        ///  This string contains the date and time that this x-plane was built.. Units:string
        ///  Raw path: sim/version/sim_build_string
        /// </summary>
        public IXPDataRef<string> sim_build_string { get { return m_data.GetString("sim/version/sim_build_string");} }

        /// <summary>
        ///  This string contains the date and time that the XPLM DLL was built.. Units:string
        ///  Raw path: sim/version/xplm_build_string
        /// </summary>
        public IXPDataRef<string> xplm_build_string { get { return m_data.GetString("sim/version/xplm_build_string");} }

        /// <summary>
        ///  This is the internal build number - it is a unique integer that always increases and is unique with each beta.  For example, 10.51b5 might be 105105.  There is no guarantee that the build numbe (last 2 digits) are in sync with the official beta number.. Units:integer
        ///  Raw path: sim/version/xplanee_internal_version
        /// </summary>
        public IXPDataRef<int> xplanee_internal_version { get { return m_data.GetInt("sim/version/xplanee_internal_version");} }

        /// <summary>
        ///  This is the internal build number - it is a unique integer that always increases and is unique with each beta.  For example, 10.51b5 might be 105105.  There is no guarantee that the build numbe (last 2 digits) are in sync with the official beta number.. Units:integer
        ///  Raw path: sim/version/xplane_internal_version
        /// </summary>
        public IXPDataRef<int> xplane_internal_version { get { return m_data.GetInt("sim/version/xplane_internal_version");} }
    }
}