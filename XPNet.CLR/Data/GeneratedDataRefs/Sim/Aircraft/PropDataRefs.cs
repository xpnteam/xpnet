using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_propDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_propDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  engine type - read only in v11, but you should NEVER EVER write this in v10 or earlier.  0=recip carb, 1=recip injected, 2=free turbine, 3=electric, 4=lo bypass jet, 5=hi bypass jet, 6=rocket, 7=tip rockets, 8=fixed turbine. Units:enum
        ///  Raw path: sim/aircraft/prop/acf_en_type
        /// </summary>
        public IXPDataRef<int[]> acf_en_type { get { return m_data.GetIntArray("sim/aircraft/prop/acf_en_type");} }
    }
}