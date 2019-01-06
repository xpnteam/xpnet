using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_gauges_actuatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_gauges_actuatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Barometric pressure setting, inches HG.  Pilot side.
        /// </summary>
        public IXPDataRef<float> barometer_setting_in_hg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/barometer_setting_in_hg_pilot");} }

        /// <summary>
        ///  Barometric pressure setting, inches HG.  Copilot side.
        /// </summary>
        public IXPDataRef<float> barometer_setting_in_hg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/barometer_setting_in_hg_copilot");} }

        /// <summary>
        ///  Radio altitude bug entered into the radio altimeter. Pilot side.
        /// </summary>
        public IXPDataRef<float> radio_altimeter_bug_ft_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/radio_altimeter_bug_ft_pilot");} }

        /// <summary>
        ///  Radio altitude bug entered into the radio altimeter. Copilot side.
        /// </summary>
        public IXPDataRef<float> radio_altimeter_bug_ft_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/radio_altimeter_bug_ft_copilot");} }

        /// <summary>
        ///  Artificial horizon pitch-reference adjustment. Pilot side.
        /// </summary>
        public IXPDataRef<float> artificial_horizon_adjust_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/artificial_horizon_adjust_deg_pilot");} }

        /// <summary>
        ///  Artificial horizon pitch-reference adjustment. Copilot side.
        /// </summary>
        public IXPDataRef<float> artificial_horizon_adjust_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/artificial_horizon_adjust_deg_copilot");} }

        /// <summary>
        ///  ASI bug location on the dial, in degrees, 0 straight up, positive clockwise.
        /// </summary>
        public IXPDataRef<float> airspeed_bug_deg { get { return m_data.GetFloat("sim/cockpit2/gauges/actuators/airspeed_bug_deg");} }
    }
}