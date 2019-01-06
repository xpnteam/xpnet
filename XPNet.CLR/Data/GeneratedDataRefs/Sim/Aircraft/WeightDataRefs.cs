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
        ///  This is the ORIGINAL reference point in PM in _feet_.
        /// </summary>
        public IXPDataRef<float> Acf_cgY_original { get { return m_data.GetFloat("sim/aircraft/weight/acf_cgy_original");} }

        /// <summary>
        ///  This is the ORIGINAL reference point in PM in _feet_.
        /// </summary>
        public IXPDataRef<float> Acf_cgZ_original { get { return m_data.GetFloat("sim/aircraft/weight/acf_cgz_original");} }

        /// <summary>
        ///  Weight of total fuel - appears to be in lbs.
        /// </summary>
        public IXPDataRef<float> Acf_m_fuel_tot { get { return m_data.GetFloat("sim/aircraft/weight/acf_m_fuel_tot");} }
    }
}