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
        ///  The decision height for the radio altimeter. Units:Feet
        /// </summary>
        public IXPDataRef<float> Radio_altimeter_minimum => m_data.GetFloat("sim/cockpit/misc/radio_altimeter_minimum");

        /// <summary>
        ///  Adjustment to the artificial horizon bars (pilot). Units:pixels
        /// </summary>
        public IXPDataRef<float> Ah_adjust => m_data.GetFloat("sim/cockpit/misc/ah_adjust");

        /// <summary>
        ///  Adjustment to the artificial horizon bars (copilot). Units:pixels
        /// </summary>
        public IXPDataRef<float> Ah_adjust2 => m_data.GetFloat("sim/cockpit/misc/ah_adjust2");

        /// <summary>
        ///  Indicated cockpit heading in magnetic degrees. Units:degm
        /// </summary>
        public IXPDataRef<float> Compass_indicated => m_data.GetFloat("sim/cockpit/misc/compass_indicated");
    }
}