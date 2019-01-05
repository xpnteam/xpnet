using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_IceDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_IceDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  De-Ice ratio.  (Description needed). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Anti_ice_engine_air => m_data.GetFloatArray("sim/cockpit2/ice/anti_ice_engine_air");

        /// <summary>
        ///  De-Ice ratio.  (Description needed). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Anti_ice_engine_air_b => m_data.GetFloatArray("sim/cockpit2/ice/anti_ice_engine_air_b");
    }
}