using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_electricalDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_electricalDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The number of batteries on this plane
        /// </summary>
        public IXPDataRef<int> num_batteries { get { return m_data.GetInt("sim/aircraft/electrical/num_batteries");} }

        /// <summary>
        ///  The number of generators on this plane
        /// </summary>
        public IXPDataRef<int> num_generators { get { return m_data.GetInt("sim/aircraft/electrical/num_generators");} }

        /// <summary>
        ///  The number of inverters on this plane
        /// </summary>
        public IXPDataRef<int> num_inverters { get { return m_data.GetInt("sim/aircraft/electrical/num_inverters");} }

        /// <summary>
        ///  The number of busses on this plane
        /// </summary>
        public IXPDataRef<int> num_buses { get { return m_data.GetInt("sim/aircraft/electrical/num_buses");} }
    }
}