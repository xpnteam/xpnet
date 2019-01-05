using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_FailuresDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_FailuresDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Hydraulic pressure ratio. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hydraulic_pressure_ratio => m_data.GetFloat("sim/operation/failures/hydraulic_pressure_ratio");

        /// <summary>
        ///  Hydraulic pressure ratio. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hydraulic_pressure_ratio2 => m_data.GetFloat("sim/operation/failures/hydraulic_pressure_ratio2");

        /// <summary>
        ///  Oil power or thrust ratio. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Oil_power_thrust_ratio => m_data.GetFloatArray("sim/operation/failures/oil_power_thrust_ratio");

        /// <summary>
        ///  Mean time between failures. Units:hours
        /// </summary>
        public IXPDataRef<float> Mean_time_between_failure_hrs => m_data.GetFloat("sim/operation/failures/mean_time_between_failure_hrs");
    }
}