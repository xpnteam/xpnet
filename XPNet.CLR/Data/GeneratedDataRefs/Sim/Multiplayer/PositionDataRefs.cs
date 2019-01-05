using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Multiplayer_PositionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Multiplayer_PositionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}