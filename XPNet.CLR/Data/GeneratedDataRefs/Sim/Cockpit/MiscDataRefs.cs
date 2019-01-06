using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The decision height for the radio altimeter
        /// </summary>
        public IXPDataRef<float> radio_altimeter_minimum { get { return m_data.GetFloat("sim/cockpit/misc/radio_altimeter_minimum");} }

        /// <summary>
        ///  Adjustment to the artificial horizon bars (pilot)
        /// </summary>
        public IXPDataRef<float> ah_adjust { get { return m_data.GetFloat("sim/cockpit/misc/ah_adjust");} }

        /// <summary>
        ///  Adjustment to the artificial horizon bars (copilot)
        /// </summary>
        public IXPDataRef<float> ah_adjust2 { get { return m_data.GetFloat("sim/cockpit/misc/ah_adjust2");} }

        /// <summary>
        ///  Indicated cockpit heading in magnetic degrees
        /// </summary>
        public IXPDataRef<float> compass_indicated { get { return m_data.GetFloat("sim/cockpit/misc/compass_indicated");} }
    }
}