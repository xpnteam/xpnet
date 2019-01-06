using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_prefs_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_prefs_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Returns true if the sim provides a low-mem lua allocator via inter-plugin messaging.
        /// </summary>
        public IXPDataRef<bool> has_lua_alloc { get { return m_data.GetBool("sim/operation/prefs/misc/has_lua_alloc");} }
    }
}