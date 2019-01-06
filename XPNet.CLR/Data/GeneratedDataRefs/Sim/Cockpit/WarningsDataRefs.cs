using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_warningsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_warningsDatarefs(IXPlaneData data)
        {
            m_data = data;
            annunciators = new sim_cockpit_warnings_annunciatorsDatarefs(data);
        }
        public sim_cockpit_warnings_annunciatorsDatarefs annunciators { get; }

        /// <summary>
        ///  Time master caution will go out.  (Use command-system instead of this dataref.)
        /// </summary>
        public IXPDataRef<float> master_caution_timeout { get { return m_data.GetFloat("sim/cockpit/warnings/master_caution_timeout");} }

        /// <summary>
        ///  Master caution is enabled for being lit (because it is not pressed)
        /// </summary>
        public IXPDataRef<float> master_caution_on { get { return m_data.GetFloat("sim/cockpit/warnings/master_caution_on");} }

        /// <summary>
        ///  Master warning is enabled for being lit (because it is not pressed)
        /// </summary>
        public IXPDataRef<float> master_warning_on { get { return m_data.GetFloat("sim/cockpit/warnings/master_warning_on");} }

        /// <summary>
        ///  Master accept is enabled for being lit (because it is not pressed)
        /// </summary>
        public IXPDataRef<float> master_accept_on { get { return m_data.GetFloat("sim/cockpit/warnings/master_accept_on");} }

        /// <summary>
        ///  Time annunciator test will end (use annunciator_test_pressed instead)
        /// </summary>
        public IXPDataRef<float> annunciator_test_timeout { get { return m_data.GetFloat("sim/cockpit/warnings/annunciator_test_timeout");} }

        /// <summary>
        ///  True if the annunciator test button is pressed now.
        /// </summary>
        public IXPDataRef<bool> annunciator_test_pressed { get { return m_data.GetBool("sim/cockpit/warnings/annunciator_test_pressed");} }

        /// <summary>
        ///  The autopilot is beeping as part of its self-test
        /// </summary>
        public IXPDataRef<bool> autopilot_test_beeping { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_beeping");} }

        /// <summary>
        ///  The autopilot mode lights are on as part of its self test
        /// </summary>
        public IXPDataRef<bool> autopilot_test_modes_lit { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_modes_lit");} }

        /// <summary>
        ///  The autopilot trim lights are on as part of its self test
        /// </summary>
        public IXPDataRef<bool> autopilot_test_trim_lit { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_trim_lit");} }

        /// <summary>
        ///  The autopilot engaged lights are on as part of their self test
        /// </summary>
        public IXPDataRef<bool> autopilot_test_ap_lit { get { return m_data.GetBool("sim/cockpit/warnings/autopilot_test_ap_lit");} }
    }
}