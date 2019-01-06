using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_failuresDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_failuresDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Ratio of icing on wings/airframe - left wing. Units:ratio
        ///  Raw path: sim/flightmodel/failures/frm_ice
        /// </summary>
        public IXPDataRef<float> frm_ice { get { return m_data.GetFloat("sim/flightmodel/failures/frm_ice");} }

        /// <summary>
        ///  Ratio of icing on wings/airframe - right wing. Units:ratio
        ///  Raw path: sim/flightmodel/failures/frm_ice2
        /// </summary>
        public IXPDataRef<float> frm_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/frm_ice2");} }

        /// <summary>
        ///  Ratio of icing on pitot tube. Units:ratio
        ///  Raw path: sim/flightmodel/failures/pitot_ice
        /// </summary>
        public IXPDataRef<float> pitot_ice { get { return m_data.GetFloat("sim/flightmodel/failures/pitot_ice");} }

        /// <summary>
        ///  Ratio of icing on pitot tube2. Units:ratio
        ///  Raw path: sim/flightmodel/failures/pitot_ice2
        /// </summary>
        public IXPDataRef<float> pitot_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/pitot_ice2");} }

        /// <summary>
        ///  Ratio of icing on the prop - first prop. Units:ratio
        ///  Raw path: sim/flightmodel/failures/prop_ice
        /// </summary>
        public IXPDataRef<float> prop_ice { get { return m_data.GetFloat("sim/flightmodel/failures/prop_ice");} }

        /// <summary>
        ///  Ratio of icing on the air inlets - first engine. Units:ratio
        ///  Raw path: sim/flightmodel/failures/inlet_ice
        /// </summary>
        public IXPDataRef<float> inlet_ice { get { return m_data.GetFloat("sim/flightmodel/failures/inlet_ice");} }

        /// <summary>
        ///  Ratio of icing on the prop - array access to all props.. Units:ratio
        ///  Raw path: sim/flightmodel/failures/prop_ice_per_engine
        /// </summary>
        public IXPDataRef<float[]> prop_ice_per_engine { get { return m_data.GetFloatArray("sim/flightmodel/failures/prop_ice_per_engine");} }

        /// <summary>
        ///  Ratio of icing on the air inlets - array access to all engines.. Units:ratio
        ///  Raw path: sim/flightmodel/failures/inlet_ice_per_engine
        /// </summary>
        public IXPDataRef<float[]> inlet_ice_per_engine { get { return m_data.GetFloatArray("sim/flightmodel/failures/inlet_ice_per_engine");} }

        /// <summary>
        ///  Ratio of icing on the windshield. Units:ratio
        ///  Raw path: sim/flightmodel/failures/window_ice
        /// </summary>
        public IXPDataRef<float> window_ice { get { return m_data.GetFloat("sim/flightmodel/failures/window_ice");} }

        /// <summary>
        ///  Ratio of icing on alpha vane - pilot AoA. Units:ratio
        ///  Raw path: sim/flightmodel/failures/aoa_ice
        /// </summary>
        public IXPDataRef<float> aoa_ice { get { return m_data.GetFloat("sim/flightmodel/failures/aoa_ice");} }

        /// <summary>
        ///  Ratio of icing on alpha vane - copilot AoA. Units:ratio
        ///  Raw path: sim/flightmodel/failures/aoa_ice2
        /// </summary>
        public IXPDataRef<float> aoa_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/aoa_ice2");} }
    }
}