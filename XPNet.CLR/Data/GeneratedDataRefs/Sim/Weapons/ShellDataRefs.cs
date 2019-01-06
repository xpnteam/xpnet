using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_weapons_shellDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_weapons_shellDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<int> is_attached { get { return m_data.GetInt("sim/weapons/shell/is_attached");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> thrust_rat { get { return m_data.GetFloat("sim/weapons/shell/thrust_rat");} }
    }
}