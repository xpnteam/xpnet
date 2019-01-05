using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_TemperatureDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_TemperatureDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  outside air temperature, pilot selects units. Units:degrees
        /// </summary>
        public IXPDataRef<float> Outside_air_temp_deg => m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_deg");

        /// <summary>
        ///  outside air temperature, celsius. Units:degreesC
        /// </summary>
        public IXPDataRef<float> Outside_air_temp_degc => m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_degc");

        /// <summary>
        ///  outside air temperature, fahrenheit. Units:degreesF
        /// </summary>
        public IXPDataRef<float> Outside_air_temp_degf => m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_degf");

        /// <summary>
        ///  outside air temperature with leading edge, pilot selects units. Units:degrees
        /// </summary>
        public IXPDataRef<float> Outside_air_LE_temp_deg => m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_deg");

        /// <summary>
        ///  outside air temperature with leading edge, celsius. Units:degreesC
        /// </summary>
        public IXPDataRef<float> Outside_air_LE_temp_degc => m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_degc");

        /// <summary>
        ///  outside air temperature with leading edge, fahrenheit. Units:degreesF
        /// </summary>
        public IXPDataRef<float> Outside_air_LE_temp_degf => m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_degf");
    }
}