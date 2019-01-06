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
        ///  array of airfoil names, per part. Units:string[40]
        ///  Raw path: sim/aircraft/parts/acf_Rafl0
        /// </summary>
        public IXPDataRef<byte[]> acf_Rafl0 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_rafl0");} }

        /// <summary>
        ///  file, not path. Units:string[40]
        ///  Raw path: sim/aircraft/parts/acf_Rafl1
        /// </summary>
        public IXPDataRef<byte[]> acf_Rafl1 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_rafl1");} }

        /// <summary>
        ///  file, not path. Units:string[40]
        ///  Raw path: sim/aircraft/parts/acf_Tafl0
        /// </summary>
        public IXPDataRef<byte[]> acf_Tafl0 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_tafl0");} }

        /// <summary>
        ///  file, not path. Units:string[40]
        ///  Raw path: sim/aircraft/parts/acf_Tafl1
        /// </summary>
        public IXPDataRef<byte[]> acf_Tafl1 { get { return m_data.GetByteArray("sim/aircraft/parts/acf_tafl1");} }

        /// <summary>
        ///  [PART] Radius of part. Units:meters
        ///  Raw path: sim/aircraft/parts/acf_body_r
        /// </summary>
        public IXPDataRef<float[]> acf_body_r { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_body_r");} }

        /// <summary>
        ///  x location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.. Units:meters
        ///  Raw path: sim/aircraft/parts/acf_gear_xnodef
        /// </summary>
        public IXPDataRef<float[]> acf_gear_xnodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_xnodef");} }

        /// <summary>
        ///  y location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.. Units:meters
        ///  Raw path: sim/aircraft/parts/acf_gear_ynodef
        /// </summary>
        public IXPDataRef<float[]> acf_gear_ynodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_ynodef");} }

        /// <summary>
        ///  z location of the Nth gear's attach point relative to the CG, airplane coordinates.  This does not change as gear is raised.. Units:meters
        ///  Raw path: sim/aircraft/parts/acf_gear_znodef
        /// </summary>
        public IXPDataRef<float[]> acf_gear_znodef { get { return m_data.GetFloatArray("sim/aircraft/parts/acf_gear_znodef");} }
    }
}