using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_multiplayerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_multiplayerDatarefs(IXPlaneData data)
        {
            m_data = data;
            controls = new sim_multiplayer_controlsDatarefs(data);
            position = new sim_multiplayer_positionDatarefs(data);
        }
        public sim_multiplayer_controlsDatarefs controls { get; }
        public sim_multiplayer_positionDatarefs position { get; }
    }
}