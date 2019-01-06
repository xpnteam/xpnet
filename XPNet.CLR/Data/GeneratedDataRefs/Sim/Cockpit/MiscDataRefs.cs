using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The decision height for the radio altimeter
        /// </summary>
        public IXPDataRef<float> Radio_altimeter_minimum { get { return m_data.GetFloat("sim/cockpit/misc/radio_altimeter_minimum");} }

        /// <summary>
        ///  Adjustment to the artificial horizon bars (pilot)
        /// </summary>
        public IXPDataRef<float> Ah_adjust { get { return m_data.GetFloat("sim/cockpit/misc/ah_adjust");} }

        /// <summary>
        ///  Adjustment to the artificial horizon bars (copilot)
        /// </summary>
        public IXPDataRef<float> Ah_adjust2 { get { return m_data.GetFloat("sim/cockpit/misc/ah_adjust2");} }

        /// <summary>
        ///  Indicated cockpit heading in magnetic degrees
        /// </summary>
        public IXPDataRef<float> Compass_indicated { get { return m_data.GetFloat("sim/cockpit/misc/compass_indicated");} }
    }
}