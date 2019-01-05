using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Hydraulics_IndicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Hydraulics_IndicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Hydraulic system 1 pressure, units set by Plane-Maker.. Units:any
        /// </summary>
        public IXPDataRef<float> Hydraulic_pressure_1 => m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_pressure_1");

        /// <summary>
        ///  Hydraulic system 2 pressure, units set by Plane-Maker.. Units:any
        /// </summary>
        public IXPDataRef<float> Hydraulic_pressure_2 => m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_pressure_2");

        /// <summary>
        ///  Hydraulic fluid quantity, ratio of max, system 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hydraulic_fluid_ratio_1 => m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_fluid_ratio_1");

        /// <summary>
        ///  Hydraulic fluid quantity, ratio of max, system 2. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hydraulic_fluid_ratio_2 => m_data.GetFloat("sim/cockpit2/hydraulics/indicators/hydraulic_fluid_ratio_2");
    }
}