using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_failuresDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_failuresDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Hydraulic pressure ratio
        /// </summary>
        public IXPDataRef<float> hydraulic_pressure_ratio { get { return m_data.GetFloat("sim/operation/failures/hydraulic_pressure_ratio");} }

        /// <summary>
        ///  Hydraulic pressure ratio
        /// </summary>
        public IXPDataRef<float> hydraulic_pressure_ratio2 { get { return m_data.GetFloat("sim/operation/failures/hydraulic_pressure_ratio2");} }

        /// <summary>
        ///  Oil power or thrust ratio
        /// </summary>
        public IXPDataRef<float[]> oil_power_thrust_ratio { get { return m_data.GetFloatArray("sim/operation/failures/oil_power_thrust_ratio");} }

        /// <summary>
        ///  Enable random failures basde on mean time between failures
        /// </summary>
        public IXPDataRef<bool> enable_random_falures { get { return m_data.GetBool("sim/operation/failures/enable_random_falures");} }

        /// <summary>
        ///  Mean time between failures
        /// </summary>
        public IXPDataRef<float> mean_time_between_failure_hrs { get { return m_data.GetFloat("sim/operation/failures/mean_time_between_failure_hrs");} }

        /// <summary>
        ///  Ram air turbine is on?
        /// </summary>
        public IXPDataRef<bool> ram_air_turbine_on { get { return m_data.GetBool("sim/operation/failures/ram_air_turbine_on");} }
    }
}