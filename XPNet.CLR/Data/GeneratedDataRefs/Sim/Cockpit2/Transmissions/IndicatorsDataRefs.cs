using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_transmissions_indicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_transmissions_indicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Transmission oil temperature.  Units are the same as the max oil temperature in ACF file.
        /// </summary>
        public IXPDataRef<float> oil_temperature { get { return m_data.GetFloat("sim/cockpit2/transmissions/indicators/oil_temperature");} }

        /// <summary>
        ///  Transmission oil pressure.  Units are the same as the max oil pressure in ACF file.
        /// </summary>
        public IXPDataRef<float> oil_pressure { get { return m_data.GetFloat("sim/cockpit2/transmissions/indicators/oil_pressure");} }
    }
}