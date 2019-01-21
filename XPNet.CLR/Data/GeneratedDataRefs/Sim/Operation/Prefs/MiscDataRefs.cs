using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_prefs_miscDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_prefs_miscDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Current language. Units:enum
        ///  Raw path: sim/operation/prefs/misc/language
        /// </summary>
        public IXPDataRef<int> language { get { return m_data.GetInt("sim/operation/prefs/misc/language");} }

        /// <summary>
        ///  Returns true if the sim provides a low-mem lua allocator via inter-plugin messaging.. Units:bool
        ///  Raw path: sim/operation/prefs/misc/has_lua_alloc
        /// </summary>
        public IXPDataRef<bool> has_lua_alloc { get { return m_data.GetBool("sim/operation/prefs/misc/has_lua_alloc");} }
    }
}