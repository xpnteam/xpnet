using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_worldDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_worldDataRefs(IXPlaneData data)
        {
            m_data = data;
            boat = new sim_world_boatDataRefs(data);
            winch = new sim_world_winchDataRefs(data);
        }
        public sim_world_boatDataRefs boat { get; }
        public sim_world_winchDataRefs winch { get; }
    }
}