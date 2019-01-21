using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_engineDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_engineDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Minimum engine speed with governor on radians/second. Units:rad/sec
        ///  Raw path: sim/aircraft/engine/acf_RSC_mingov_eng
        /// </summary>
        public IXPDataRef<float> acf_RSC_mingov_eng { get { return m_data.GetFloat("sim/aircraft/engine/acf_rsc_mingov_eng");} }

        /// <summary>
        ///  Engine idle speed radians/second.. Units:rad/sec
        ///  Raw path: sim/aircraft/engine/acf_RSC_idlespeed_eng
        /// </summary>
        public IXPDataRef<float> acf_RSC_idlespeed_eng { get { return m_data.GetFloat("sim/aircraft/engine/acf_rsc_idlespeed_eng");} }

        /// <summary>
        ///  Max engine speed radians/second.. Units:rad/sec
        ///  Raw path: sim/aircraft/engine/acf_RSC_redline_eng
        /// </summary>
        public IXPDataRef<float> acf_RSC_redline_eng { get { return m_data.GetFloat("sim/aircraft/engine/acf_rsc_redline_eng");} }

        /// <summary>
        ///  Critical altitude for props. Units:meters
        ///  Raw path: sim/aircraft/engine/acf_critalt
        /// </summary>
        public IXPDataRef<float> acf_critalt { get { return m_data.GetFloat("sim/aircraft/engine/acf_critalt");} }

        /// <summary>
        ///  This is the delay in increasing the throttle for jet engines - it is the number of seconds to actuate a full advance.. Units:seconds
        ///  Raw path: sim/aircraft/engine/acf_spooltime_jet
        /// </summary>
        public IXPDataRef<float> acf_spooltime_jet { get { return m_data.GetFloat("sim/aircraft/engine/acf_spooltime_jet");} }

        /// <summary>
        ///  This is the delay in increasing the throttle for prop/turboprop engines - it is the number of seconds to actuate a full advance.. Units:seconds
        ///  Raw path: sim/aircraft/engine/acf_spooltime_prop
        /// </summary>
        public IXPDataRef<float> acf_spooltime_prop { get { return m_data.GetFloat("sim/aircraft/engine/acf_spooltime_prop");} }

        /// <summary>
        ///  This is the number of seconds it takes for a free turbine to spin up from idle to full RPM.. Units:seconds
        ///  Raw path: sim/aircraft/engine/acf_spooltime_turbine
        /// </summary>
        public IXPDataRef<float> acf_spooltime_turbine { get { return m_data.GetFloat("sim/aircraft/engine/acf_spooltime_turbine");} }

        /// <summary>
        ///  This is the ratio of the engine's maximum torque that the starter applies at its design RPM.. Units:Ratio
        ///  Raw path: sim/aircraft/engine/acf_starter_torque_ratio
        /// </summary>
        public IXPDataRef<float> acf_starter_torque_ratio { get { return m_data.GetFloat("sim/aircraft/engine/acf_starter_torque_ratio");} }

        /// <summary>
        ///  This is the ratio of the engine's max RPM that the starter can spin the engine up to before it loses torque.. Units:Ratio
        ///  Raw path: sim/aircraft/engine/acf_starter_max_rpm_ratio
        /// </summary>
        public IXPDataRef<float> acf_starter_max_rpm_ratio { get { return m_data.GetFloat("sim/aircraft/engine/acf_starter_max_rpm_ratio");} }

        /// <summary>
        ///  Boost Amount. Units:ratio
        ///  Raw path: sim/aircraft/engine/boost_ratio
        /// </summary>
        public IXPDataRef<float> boost_ratio { get { return m_data.GetFloat("sim/aircraft/engine/boost_ratio");} }

        /// <summary>
        ///  Boost Capacity. Units:seconds
        ///  Raw path: sim/aircraft/engine/boost_max_seconds
        /// </summary>
        public IXPDataRef<float> boost_max_seconds { get { return m_data.GetFloat("sim/aircraft/engine/boost_max_seconds");} }
    }
}