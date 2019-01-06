using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_windowsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_windowsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }
    }
}