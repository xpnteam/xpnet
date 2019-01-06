using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_PhysicsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_PhysicsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The earth's mass-gravity constant
        /// </summary>
        public IXPDataRef<float> Earth_mu { get { return m_data.GetFloat("sim/physics/earth_mu");} }

        /// <summary>
        ///  Earth's radius
        /// </summary>
        public IXPDataRef<float> Earth_radius_m { get { return m_data.GetFloat("sim/physics/earth_radius_m");} }

        /// <summary>
        ///  Average sea level temp, current planet
        /// </summary>
        public IXPDataRef<float> Earth_temp_c { get { return m_data.GetFloat("sim/physics/earth_temp_c");} }

        /// <summary>
        ///  average pressure at sea level, current planet
        /// </summary>
        public IXPDataRef<float> Earth_pressure_p { get { return m_data.GetFloat("sim/physics/earth_pressure_p");} }

        /// <summary>
        ///  Are we showing metric temperature indications
        /// </summary>
        public IXPDataRef<bool> Metric_temp { get { return m_data.GetBool("sim/physics/metric_temp");} }

        /// <summary>
        ///  Are we showing metric pressure indications
        /// </summary>
        public IXPDataRef<bool> Metric_press { get { return m_data.GetBool("sim/physics/metric_press");} }
    }
}