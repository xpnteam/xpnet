using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_weightDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_weightDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the ORIGINAL reference point in PM in _feet_.. Units:feet
        ///  Raw path: sim/aircraft/weight/acf_cgY_original
        /// </summary>
        public IXPDataRef<float> acf_cgY_original { get { return m_data.GetFloat("sim/aircraft/weight/acf_cgy_original");} }

        /// <summary>
        ///  This is the ORIGINAL reference point in PM in _feet_.. Units:feet
        ///  Raw path: sim/aircraft/weight/acf_cgZ_original
        /// </summary>
        public IXPDataRef<float> acf_cgZ_original { get { return m_data.GetFloat("sim/aircraft/weight/acf_cgz_original");} }

        /// <summary>
        ///  Weight of total fuel - appears to be in lbs.. Units:lbs
        ///  Raw path: sim/aircraft/weight/acf_m_fuel_tot
        /// </summary>
        public IXPDataRef<float> acf_m_fuel_tot { get { return m_data.GetFloat("sim/aircraft/weight/acf_m_fuel_tot");} }
    }
}