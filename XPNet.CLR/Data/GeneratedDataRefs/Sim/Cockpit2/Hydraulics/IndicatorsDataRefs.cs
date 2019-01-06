using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_hydraulics_indicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_hydraulics_indicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Hydraulic system 1 pressure, units set by Plane-Maker.
        /// </summary>
        public IXPDataRef<float> hydraulic_pressure_1 { get { return m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_pressure_1");} }

        /// <summary>
        ///  Hydraulic system 2 pressure, units set by Plane-Maker.
        /// </summary>
        public IXPDataRef<float> hydraulic_pressure_2 { get { return m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_pressure_2");} }

        /// <summary>
        ///  Hydraulic fluid quantity, ratio of max, system 1
        /// </summary>
        public IXPDataRef<float> hydraulic_fluid_ratio_1 { get { return m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_fluid_ratio_1");} }

        /// <summary>
        ///  Hydraulic fluid quantity, ratio of max, system 2
        /// </summary>
        public IXPDataRef<float> hydraulic_fluid_ratio_2 { get { return m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_fluid_ratio_2");} }
    }
}