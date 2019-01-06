using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_network_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_network_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Has x-plane already inited Open Transport?  YOU SHOULD NEVER USE THIS DATAREF!!!. Units:boolean
        ///  Raw path: sim/network/misc/opentransport_inited
        /// </summary>
        public IXPDataRef<bool> opentransport_inited { get { return m_data.GetBool("sim/network/misc/opentransport_inited");} }

        /// <summary>
        ///  The current elapsed time synched across the network. Units:seconds
        ///  Raw path: sim/network/misc/network_time_sec
        /// </summary>
        public IXPDataRef<float> network_time_sec { get { return m_data.GetFloat("sim/network/misc/network_time_sec");} }
    }
}