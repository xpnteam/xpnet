using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_WindowsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_WindowsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}