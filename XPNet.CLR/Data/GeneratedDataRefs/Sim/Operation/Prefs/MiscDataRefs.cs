using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_Prefs_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_Prefs_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Returns true if the sim provides a low-mem lua allocator via inter-plugin messaging.
        /// </summary>
        public IXPDataRef<bool> Has_lua_alloc => m_data.GetBool("sim/operation/prefs/misc/has_lua_alloc");
    }
}