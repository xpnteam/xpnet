using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_TestDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_TestDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  this test dataref is used internally for testing our models
        /// </summary>
        public IXPDataRef<float> Test_float { get { return m_data.GetFloat("sim/test/test_float");} }
    }
}