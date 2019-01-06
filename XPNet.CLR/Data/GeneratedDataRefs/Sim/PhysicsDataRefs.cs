using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_physicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_physicsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The earth's mass-gravity constant. Units:m^3/s^2
        ///  Raw path: sim/physics/earth_mu
        /// </summary>
        public IXPDataRef<float> earth_mu { get { return m_data.GetFloat("sim/physics/earth_mu");} }

        /// <summary>
        ///  Earth's radius. Units:meters
        ///  Raw path: sim/physics/earth_radius_m
        /// </summary>
        public IXPDataRef<float> earth_radius_m { get { return m_data.GetFloat("sim/physics/earth_radius_m");} }

        /// <summary>
        ///  Average sea level temp, current planet. Units:celsius
        ///  Raw path: sim/physics/earth_temp_c
        /// </summary>
        public IXPDataRef<float> earth_temp_c { get { return m_data.GetFloat("sim/physics/earth_temp_c");} }

        /// <summary>
        ///  average pressure at sea level, current planet. Units:pascals
        ///  Raw path: sim/physics/earth_pressure_p
        /// </summary>
        public IXPDataRef<float> earth_pressure_p { get { return m_data.GetFloat("sim/physics/earth_pressure_p");} }

        /// <summary>
        ///  Are we showing metric temperature indications. Units:boolean
        ///  Raw path: sim/physics/metric_temp
        /// </summary>
        public IXPDataRef<bool> metric_temp { get { return m_data.GetBool("sim/physics/metric_temp");} }

        /// <summary>
        ///  Are we showing metric pressure indications. Units:boolean
        ///  Raw path: sim/physics/metric_press
        /// </summary>
        public IXPDataRef<bool> metric_press { get { return m_data.GetBool("sim/physics/metric_press");} }
    }
}