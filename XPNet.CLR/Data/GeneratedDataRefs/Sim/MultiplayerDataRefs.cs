using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_MultiplayerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_MultiplayerDatarefs(IXPlaneData data)
        {
            m_data = data;
            Controls = new Sim_Multiplayer_ControlsDatarefs(data);
            Position = new Sim_Multiplayer_PositionDatarefs(data);
        }
        public Sim_Multiplayer_ControlsDatarefs Controls { get; }
        public Sim_Multiplayer_PositionDatarefs Position { get; }
    }
}