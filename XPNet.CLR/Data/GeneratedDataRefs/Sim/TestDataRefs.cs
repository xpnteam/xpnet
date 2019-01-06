using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_testDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_testDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  this test dataref is used internally for testing our models. Units:ratio
        ///  Raw path: sim/test/test_float
        /// </summary>
        public IXPDataRef<float> test_float { get { return m_data.GetFloat("sim/test/test_float");} }
    }
}