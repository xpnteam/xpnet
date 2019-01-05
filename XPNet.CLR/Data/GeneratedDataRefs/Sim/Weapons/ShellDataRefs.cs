using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Weapons_ShellDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Weapons_ShellDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  . Units:V11TODO
        /// </summary>
        public IXPDataRef<float> Thrust_rat => m_data.GetFloat("sim/weapons/shell/thrust_rat");
    }
}