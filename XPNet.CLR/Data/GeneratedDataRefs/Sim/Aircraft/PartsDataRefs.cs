using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_PartsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_PartsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  [PART] Radius of part. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Acf_body_r => m_data.GetFloatArray("sim/aircraft/parts/acf_body_r");

        /// <summary>
        ///  x location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Acf_gear_xnodef => m_data.GetFloatArray("sim/aircraft/parts/acf_gear_xnodef");

        /// <summary>
        ///  y location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Acf_gear_ynodef => m_data.GetFloatArray("sim/aircraft/parts/acf_gear_ynodef");

        /// <summary>
        ///  z location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Acf_gear_znodef => m_data.GetFloatArray("sim/aircraft/parts/acf_gear_znodef");
    }
}