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
        ///  Has x-plane already inited Open Transport?  YOU SHOULD NEVER USE THIS DATAREF!!!
        /// </summary>
        public IXPDataRef<bool> Opentransport_inited { get { return m_data.GetBool("sim/network/misc/opentransport_inited");} }

        /// <summary>
        ///  The current elapsed time synched across the network
        /// </summary>
        public IXPDataRef<float> Network_time_sec { get { return m_data.GetFloat("sim/network/misc/network_time_sec");} }
    }
}