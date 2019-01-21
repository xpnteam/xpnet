using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_multiplayerDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_multiplayerDataRefs(IXPlaneData data)
        {
            m_data = data;
            controls = new sim_multiplayer_controlsDataRefs(data);
            position = new sim_multiplayer_positionDataRefs(data);
        }
        public sim_multiplayer_controlsDataRefs controls { get; }
        public sim_multiplayer_positionDataRefs position { get; }
    }
}