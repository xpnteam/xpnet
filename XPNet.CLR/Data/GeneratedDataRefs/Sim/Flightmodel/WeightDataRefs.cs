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
        ///  Payload Weight. Units:kgs
        /// </summary>
        public IXPDataRef<float> M_fixed => m_data.GetFloat("sim/flightmodel/weight/m_fixed");

        /// <summary>
        ///  Total Weight. Units:kgs
        /// </summary>
        public IXPDataRef<float> M_total => m_data.GetFloat("sim/flightmodel/weight/m_total");

        /// <summary>
        ///  Fuel Tank Weight - for 9 tanks. Units:kgs
        /// </summary>
        public IXPDataRef<float[]> M_fuel => m_data.GetFloatArray("sim/flightmodel/weight/m_fuel");

        /// <summary>
        ///  Fuel Tank 1 Weight. Units:kgs
        /// </summary>
        public IXPDataRef<float> M_fuel1 => m_data.GetFloat("sim/flightmodel/weight/m_fuel1");

        /// <summary>
        ///  Fuel Tank 2 Weight. Units:kgs
        /// </summary>
        public IXPDataRef<float> M_fuel2 => m_data.GetFloat("sim/flightmodel/weight/m_fuel2");

        /// <summary>
        ///  Fuel Tank 3 Weight. Units:kgs
        /// </summary>
        public IXPDataRef<float> M_fuel3 => m_data.GetFloat("sim/flightmodel/weight/m_fuel3");

        /// <summary>
        ///  . Units:kgs
        /// </summary>
        public IXPDataRef<float> M_jettison => m_data.GetFloat("sim/flightmodel/weight/m_jettison");

        /// <summary>
        ///  Fuel Total Weight. Units:kgs
        /// </summary>
        public IXPDataRef<float> M_fuel_total => m_data.GetFloat("sim/flightmodel/weight/m_fuel_total");
    }
}