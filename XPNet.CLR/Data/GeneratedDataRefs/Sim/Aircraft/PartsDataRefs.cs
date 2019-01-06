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
        ///  [PART] Radius of part
        /// </summary>
        public IXPDataRef<float[]> Acf_body_r { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_body_r");} }

        /// <summary>
        ///  x location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.
        /// </summary>
        public IXPDataRef<float[]> Acf_gear_xnodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_xnodef");} }

        /// <summary>
        ///  y location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.
        /// </summary>
        public IXPDataRef<float[]> Acf_gear_ynodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_ynodef");} }

        /// <summary>
        ///  z location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.
        /// </summary>
        public IXPDataRef<float[]> Acf_gear_znodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_znodef");} }
    }
}