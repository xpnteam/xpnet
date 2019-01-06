using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Minimum engine speed with governor on radians/Second
        /// </summary>
        public IXPDataRef<float> Acf_RSC_mingov_eng { get { return m_data.GetFloat("sim/aircraft/engine/acf_rsc_mingov_eng");} }

        /// <summary>
        ///  Engine idle speed radians/Second.
        /// </summary>
        public IXPDataRef<float> Acf_RSC_idlespeed_eng { get { return m_data.GetFloat("sim/aircraft/engine/acf_rsc_idlespeed_eng");} }

        /// <summary>
        ///  Max engine speed radians/Second.
        /// </summary>
        public IXPDataRef<float> Acf_RSC_redline_eng { get { return m_data.GetFloat("sim/aircraft/engine/acf_rsc_redline_eng");} }

        /// <summary>
        ///  Critical altitude for props
        /// </summary>
        public IXPDataRef<float> Acf_critalt { get { return m_data.GetFloat("sim/aircraft/engine/acf_critalt");} }

        /// <summary>
        ///  This is the delay in increasing the throttle for jet engines - it is the number of seconds to actuate a full advance.
        /// </summary>
        public IXPDataRef<float> Acf_spooltime_jet { get { return m_data.GetFloat("sim/aircraft/engine/acf_spooltime_jet");} }

        /// <summary>
        ///  This is the delay in increasing the throttle for prop/Turboprop engines - it is the number of seconds to actuate a full advance.
        /// </summary>
        public IXPDataRef<float> Acf_spooltime_prop { get { return m_data.GetFloat("sim/aircraft/engine/acf_spooltime_prop");} }

        /// <summary>
        ///  This is the number of seconds it takes for a free turbine to spin up from idle to full RPM.
        /// </summary>
        public IXPDataRef<float> Acf_spooltime_turbine { get { return m_data.GetFloat("sim/aircraft/engine/acf_spooltime_turbine");} }

        /// <summary>
        ///  This is the ratio of the engine's maximum torque that the starter applies at its design RPM.
        /// </summary>
        public IXPDataRef<float> Acf_starter_torque_ratio { get { return m_data.GetFloat("sim/aircraft/engine/acf_starter_torque_ratio");} }

        /// <summary>
        ///  This is the ratio of the engine's max RPM that the starter can spin the engine up to before it loses torque.
        /// </summary>
        public IXPDataRef<float> Acf_starter_max_rpm_ratio { get { return m_data.GetFloat("sim/aircraft/engine/acf_starter_max_rpm_ratio");} }

        /// <summary>
        ///  Boost Amount
        /// </summary>
        public IXPDataRef<float> Boost_ratio { get { return m_data.GetFloat("sim/aircraft/engine/boost_ratio");} }

        /// <summary>
        ///  Boost Capacity
        /// </summary>
        public IXPDataRef<float> Boost_max_seconds { get { return m_data.GetFloat("sim/aircraft/engine/boost_max_seconds");} }
    }
}