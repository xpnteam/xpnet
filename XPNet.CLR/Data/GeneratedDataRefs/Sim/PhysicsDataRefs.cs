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
        ///  The earth's mass-gravity constant. Units:m^3/S^2
        /// </summary>
        public IXPDataRef<float> Earth_mu => m_data.GetFloat("sim/physics/earth_mu");

        /// <summary>
        ///  Earth's radius. Units:meters
        /// </summary>
        public IXPDataRef<float> Earth_radius_m => m_data.GetFloat("sim/physics/earth_radius_m");

        /// <summary>
        ///  Average sea level temp, current planet. Units:celsius
        /// </summary>
        public IXPDataRef<float> Earth_temp_c => m_data.GetFloat("sim/physics/earth_temp_c");

        /// <summary>
        ///  average pressure at sea level, current planet. Units:pascals
        /// </summary>
        public IXPDataRef<float> Earth_pressure_p => m_data.GetFloat("sim/physics/earth_pressure_p");
    }
}