using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_WeightDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_WeightDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Payload Weight
        /// </summary>
        public IXPDataRef<float> M_fixed { get { return m_data.GetFloat("sim/flightmodel/weight/m_fixed");} }

        /// <summary>
        ///  Total Weight
        /// </summary>
        public IXPDataRef<float> M_total { get { return m_data.GetFloat("sim/flightmodel/weight/m_total");} }

        /// <summary>
        ///  Fuel Tank Weight - for 9 tanks
        /// </summary>
        public IXPDataRef<float[]> M_fuel { get { return m_data.GetFloatArray("sim/flightmodel/weight/m_fuel");} }

        /// <summary>
        ///  Fuel Tank 1 Weight
        /// </summary>
        public IXPDataRef<float> M_fuel1 { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel1");} }

        /// <summary>
        ///  Fuel Tank 2 Weight
        /// </summary>
        public IXPDataRef<float> M_fuel2 { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel2");} }

        /// <summary>
        ///  Fuel Tank 3 Weight
        /// </summary>
        public IXPDataRef<float> M_fuel3 { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel3");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> M_jettison { get { return m_data.GetFloat("sim/flightmodel/weight/m_jettison");} }

        /// <summary>
        ///  Fuel Total Weight
        /// </summary>
        public IXPDataRef<float> M_fuel_total { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel_total");} }
    }
}