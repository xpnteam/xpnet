using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_WeightDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_WeightDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the ORIGINAL reference point in PM in _feet_.. Units:feet
        /// </summary>
        public IXPDataRef<float> Acf_cgY_original => m_data.GetFloat("sim/aircraft/weight/acf_cgy_original");

        /// <summary>
        ///  This is the ORIGINAL reference point in PM in _feet_.. Units:feet
        /// </summary>
        public IXPDataRef<float> Acf_cgZ_original => m_data.GetFloat("sim/aircraft/weight/acf_cgz_original");

        /// <summary>
        ///  Weight of total fuel - appears to be in lbs.. Units:lbs
        /// </summary>
        public IXPDataRef<float> Acf_m_fuel_tot => m_data.GetFloat("sim/aircraft/weight/acf_m_fuel_tot");
    }
}