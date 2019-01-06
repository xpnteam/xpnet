using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_partsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_partsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  array of airfoil names, per part
        /// </summary>
        public IXPDataRef<byte[]> acf_Rafl0 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_rafl0");} }

        /// <summary>
        ///  file, not path
        /// </summary>
        public IXPDataRef<byte[]> acf_Rafl1 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_rafl1");} }

        /// <summary>
        ///  file, not path
        /// </summary>
        public IXPDataRef<byte[]> acf_Tafl0 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_tafl0");} }

        /// <summary>
        ///  file, not path
        /// </summary>
        public IXPDataRef<byte[]> acf_Tafl1 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_tafl1");} }

        /// <summary>
        ///  [PART] Radius of part
        /// </summary>
        public IXPDataRef<float[]> acf_body_r { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_body_r");} }

        /// <summary>
        ///  x location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.
        /// </summary>
        public IXPDataRef<float[]> acf_gear_xnodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_xnodef");} }

        /// <summary>
        ///  y location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.
        /// </summary>
        public IXPDataRef<float[]> acf_gear_ynodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_ynodef");} }

        /// <summary>
        ///  z location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.
        /// </summary>
        public IXPDataRef<float[]> acf_gear_znodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_znodef");} }
    }
}