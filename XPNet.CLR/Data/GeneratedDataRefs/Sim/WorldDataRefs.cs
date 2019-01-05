using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_WorldDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_WorldDatarefs(IXPlaneData data)
        {
            m_data = data;
            Boat = new Sim_World_BoatDatarefs(data);
            Winch = new Sim_World_WinchDatarefs(data);
        }
        public Sim_World_BoatDatarefs Boat { get; }
        public Sim_World_WinchDatarefs Winch { get; }
    }
}