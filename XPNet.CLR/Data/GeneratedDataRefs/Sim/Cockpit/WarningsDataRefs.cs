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
        ///  Time master caution will go out.  (Use command-system instead of this dataref.)
        /// </summary>
        public IXPDataRef<float> Master_caution_timeout { get { return m_data.GetFloat("sim/cockpit/warnings/master_caution_timeout");} }

        /// <summary>
        ///  Master caution is enabled for being lit (because it is not pressed)
        /// </summary>
        public IXPDataRef<float> Master_caution_on { get { return m_data.GetFloat("sim/cockpit/warnings/master_caution_on");} }

        /// <summary>
        ///  Master warning is enabled for being lit (because it is not pressed)
        /// </summary>
        public IXPDataRef<float> Master_warning_on { get { return m_data.GetFloat("sim/cockpit/warnings/master_warning_on");} }

        /// <summary>
        ///  Master accept is enabled for being lit (because it is not pressed)
        /// </summary>
        public IXPDataRef<float> Master_accept_on { get { return m_data.GetFloat("sim/cockpit/warnings/master_accept_on");} }

        /// <summary>
        ///  Time annunciator test will end (use annunciator_test_pressed instead)
        /// </summary>
        public IXPDataRef<float> Annunciator_test_timeout { get { return m_data.GetFloat("sim/cockpit/warnings/annunciator_test_timeout");} }

        /// <summary>
        ///  True if the annunciator test button is pressed now.
        /// </summary>
        public IXPDataRef<bool> Annunciator_test_pressed { get { return m_data.GetBool("sim/cockpit/warnings/annunciator_test_pressed");} }

        /// <summary>
        ///  The autopilot is beeping as part of its self-test
        /// </summary>
        public IXPDataRef<bool> Autopilot_test_beeping { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_beeping");} }

        /// <summary>
        ///  The autopilot mode lights are on as part of its self test
        /// </summary>
        public IXPDataRef<bool> Autopilot_test_modes_lit { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_modes_lit");} }

        /// <summary>
        ///  The autopilot trim lights are on as part of its self test
        /// </summary>
        public IXPDataRef<bool> Autopilot_test_trim_lit { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_trim_lit");} }

        /// <summary>
        ///  The autopilot engaged lights are on as part of their self test
        /// </summary>
        public IXPDataRef<bool> Autopilot_test_ap_lit { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_ap_lit");} }
    }
}