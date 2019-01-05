using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft2Datarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft2Datarefs(IXPlaneData data)
        {
            m_data = data;
            Engine = new Sim_Aircraft2_EngineDatarefs(data);
        }
        public Sim_Aircraft2_EngineDatarefs Engine { get; }
    }
}