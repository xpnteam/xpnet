using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Network_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Network_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The current elapsed time synched across the network. Units:seconds
        /// </summary>
        public IXPDataRef<float> Network_time_sec => m_data.GetFloat("sim/network/misc/network_time_sec");
    }
}