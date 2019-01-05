using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_WarningsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_WarningsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Annunciators = new Sim_Cockpit_Warnings_AnnunciatorsDatarefs(data);
        }
        public Sim_Cockpit_Warnings_AnnunciatorsDatarefs Annunciators { get; }

        /// <summary>
        ///  Time master caution will go out.  (Use command-system instead of this dataref.). Units:seconds
        /// </summary>
        public IXPDataRef<float> Master_caution_timeout => m_data.GetFloat("sim/cockpit/warnings/master_caution_timeout");

        /// <summary>
        ///  Master caution is enabled for being lit (because it is not pressed). Units:boolean
        /// </summary>
        public IXPDataRef<float> Master_caution_on => m_data.GetFloat("sim/cockpit/warnings/master_caution_on");

        /// <summary>
        ///  Master warning is enabled for being lit (because it is not pressed). Units:boolean
        /// </summary>
        public IXPDataRef<float> Master_warning_on => m_data.GetFloat("sim/cockpit/warnings/master_warning_on");

        /// <summary>
        ///  Master accept is enabled for being lit (because it is not pressed). Units:boolean
        /// </summary>
        public IXPDataRef<float> Master_accept_on => m_data.GetFloat("sim/cockpit/warnings/master_accept_on");

        /// <summary>
        ///  Time annunciator test will end (use annunciator_test_pressed instead). Units:seconds
        /// </summary>
        public IXPDataRef<float> Annunciator_test_timeout => m_data.GetFloat("sim/cockpit/warnings/annunciator_test_timeout");
    }
}