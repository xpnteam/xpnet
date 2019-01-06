using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_weightDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_weightDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Payload Weight. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_fixed
        /// </summary>
        public IXPDataRef<float> m_fixed { get { return m_data.GetFloat("sim/flightmodel/weight/m_fixed");} }

        /// <summary>
        ///  Total Weight. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_total
        /// </summary>
        public IXPDataRef<float> m_total { get { return m_data.GetFloat("sim/flightmodel/weight/m_total");} }

        /// <summary>
        ///  Fuel Tank Weight - for 9 tanks. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_fuel
        /// </summary>
        public IXPDataRef<float[]> m_fuel { get { return m_data.GetFloatArray("sim/flightmodel/weight/m_fuel");} }

        /// <summary>
        ///  Fuel Tank 1 Weight. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_fuel1
        /// </summary>
        public IXPDataRef<float> m_fuel1 { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel1");} }

        /// <summary>
        ///  Fuel Tank 2 Weight. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_fuel2
        /// </summary>
        public IXPDataRef<float> m_fuel2 { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel2");} }

        /// <summary>
        ///  Fuel Tank 3 Weight. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_fuel3
        /// </summary>
        public IXPDataRef<float> m_fuel3 { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel3");} }

        /// <summary>
        ///  . Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_jettison
        /// </summary>
        public IXPDataRef<float> m_jettison { get { return m_data.GetFloat("sim/flightmodel/weight/m_jettison");} }

        /// <summary>
        ///  Fuel Total Weight. Units:kgs
        ///  Raw path: sim/flightmodel/weight/m_fuel_total
        /// </summary>
        public IXPDataRef<float> m_fuel_total { get { return m_data.GetFloat("sim/flightmodel/weight/m_fuel_total");} }
    }
}