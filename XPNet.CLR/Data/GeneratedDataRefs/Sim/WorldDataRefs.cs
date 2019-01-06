using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_worldDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_worldDatarefs(IXPlaneData data)
        {
            m_data = data;
            boat = new sim_world_boatDatarefs(data);
            winch = new sim_world_winchDatarefs(data);
        }
        public sim_world_boatDatarefs boat { get; }
        public sim_world_winchDatarefs winch { get; }
    }
}