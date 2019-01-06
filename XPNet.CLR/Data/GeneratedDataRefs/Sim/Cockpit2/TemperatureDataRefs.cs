using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_temperatureDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_temperatureDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  outside air temperature, pilot selects units. Units:degrees
        ///  Raw path: sim/cockpit2/temperature/outside_air_temp_deg
        /// </summary>
        public IXPDataRef<float> outside_air_temp_deg { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_deg");} }

        /// <summary>
        ///  outside air temperature, celsius. Units:degreesC
        ///  Raw path: sim/cockpit2/temperature/outside_air_temp_degc
        /// </summary>
        public IXPDataRef<float> outside_air_temp_degc { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_degc");} }

        /// <summary>
        ///  outside air temperature, fahrenheit. Units:degreesF
        ///  Raw path: sim/cockpit2/temperature/outside_air_temp_degf
        /// </summary>
        public IXPDataRef<float> outside_air_temp_degf { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_temp_degf");} }

        /// <summary>
        ///  outside air temperature with leading edge, pilot selects units. Units:degrees
        ///  Raw path: sim/cockpit2/temperature/outside_air_LE_temp_deg
        /// </summary>
        public IXPDataRef<float> outside_air_LE_temp_deg { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_deg");} }

        /// <summary>
        ///  outside air temperature with leading edge, celsius. Units:degreesC
        ///  Raw path: sim/cockpit2/temperature/outside_air_LE_temp_degc
        /// </summary>
        public IXPDataRef<float> outside_air_LE_temp_degc { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_degc");} }

        /// <summary>
        ///  outside air temperature with leading edge, fahrenheit. Units:degreesF
        ///  Raw path: sim/cockpit2/temperature/outside_air_LE_temp_degf
        /// </summary>
        public IXPDataRef<float> outside_air_LE_temp_degf { get { return m_data.GetFloat("sim/cockpit2/temperature/outside_air_le_temp_degf");} }

        /// <summary>
        ///  1 if thermo is metric, 0 if fahrenheit.. Units:boolean
        ///  Raw path: sim/cockpit2/temperature/outside_air_temp_is_metric
        /// </summary>
        public IXPDataRef<bool> outside_air_temp_is_metric { get { return m_data.GetBool("sim/cockpit2/temperature/outside_air_temp_is_metric");} }
    }
}