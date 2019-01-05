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
        ///  Minimum engine speed with governor on radians/Second. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Acf_RSC_mingov_eng => m_data.GetFloat("sim/aircraft/engine/acf_rsc_mingov_eng");

        /// <summary>
        ///  Engine idle speed radians/Second.. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Acf_RSC_idlespeed_eng => m_data.GetFloat("sim/aircraft/engine/acf_rsc_idlespeed_eng");

        /// <summary>
        ///  Max engine speed radians/Second.. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Acf_RSC_redline_eng => m_data.GetFloat("sim/aircraft/engine/acf_rsc_redline_eng");

        /// <summary>
        ///  Critical altitude for props. Units:meters
        /// </summary>
        public IXPDataRef<float> Acf_critalt => m_data.GetFloat("sim/aircraft/engine/acf_critalt");

        /// <summary>
        ///  This is the delay in increasing the throttle for jet engines - it is the number of seconds to actuate a full advance.. Units:seconds
        /// </summary>
        public IXPDataRef<float> Acf_spooltime_jet => m_data.GetFloat("sim/aircraft/engine/acf_spooltime_jet");

        /// <summary>
        ///  This is the delay in increasing the throttle for prop/Turboprop engines - it is the number of seconds to actuate a full advance.. Units:seconds
        /// </summary>
        public IXPDataRef<float> Acf_spooltime_prop => m_data.GetFloat("sim/aircraft/engine/acf_spooltime_prop");

        /// <summary>
        ///  This is the number of seconds it takes for a free turbine to spin up from idle to full RPM.. Units:seconds
        /// </summary>
        public IXPDataRef<float> Acf_spooltime_turbine => m_data.GetFloat("sim/aircraft/engine/acf_spooltime_turbine");

        /// <summary>
        ///  This is the ratio of the engine's maximum torque that the starter applies at its design RPM.. Units:Ratio
        /// </summary>
        public IXPDataRef<float> Acf_starter_torque_ratio => m_data.GetFloat("sim/aircraft/engine/acf_starter_torque_ratio");

        /// <summary>
        ///  This is the ratio of the engine's max RPM that the starter can spin the engine up to before it loses torque.. Units:Ratio
        /// </summary>
        public IXPDataRef<float> Acf_starter_max_rpm_ratio => m_data.GetFloat("sim/aircraft/engine/acf_starter_max_rpm_ratio");

        /// <summary>
        ///  Boost Amount. Units:ratio
        /// </summary>
        public IXPDataRef<float> Boost_ratio => m_data.GetFloat("sim/aircraft/engine/boost_ratio");

        /// <summary>
        ///  Boost Capacity. Units:seconds
        /// </summary>
        public IXPDataRef<float> Boost_max_seconds => m_data.GetFloat("sim/aircraft/engine/boost_max_seconds");
    }
}