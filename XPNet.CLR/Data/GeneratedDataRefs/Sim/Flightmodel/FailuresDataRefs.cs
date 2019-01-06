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
        ///  Ratio of icing on wings/airframe - left wing
        /// </summary>
        public IXPDataRef<float> frm_ice { get { return m_data.GetFloat("sim/flightmodel/failures/frm_ice");} }

        /// <summary>
        ///  Ratio of icing on wings/airframe - right wing
        /// </summary>
        public IXPDataRef<float> frm_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/frm_ice2");} }

        /// <summary>
        ///  Ratio of icing on pitot tube
        /// </summary>
        public IXPDataRef<float> pitot_ice { get { return m_data.GetFloat("sim/flightmodel/failures/pitot_ice");} }

        /// <summary>
        ///  Ratio of icing on pitot tube2
        /// </summary>
        public IXPDataRef<float> pitot_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/pitot_ice2");} }

        /// <summary>
        ///  Ratio of icing on the prop - first prop
        /// </summary>
        public IXPDataRef<float> prop_ice { get { return m_data.GetFloat("sim/flightmodel/failures/prop_ice");} }

        /// <summary>
        ///  Ratio of icing on the air inlets - first engine
        /// </summary>
        public IXPDataRef<float> inlet_ice { get { return m_data.GetFloat("sim/flightmodel/failures/inlet_ice");} }

        /// <summary>
        ///  Ratio of icing on the prop - array access to all props.
        /// </summary>
        public IXPDataRef<float[]> prop_ice_per_engine { get { return m_data.GetFloatArray("sim/flightmodel/failures/prop_ice_per_engine");} }

        /// <summary>
        ///  Ratio of icing on the air inlets - array access to all engines.
        /// </summary>
        public IXPDataRef<float[]> inlet_ice_per_engine { get { return m_data.GetFloatArray("sim/flightmodel/failures/inlet_ice_per_engine");} }

        /// <summary>
        ///  Ratio of icing on the windshield
        /// </summary>
        public IXPDataRef<float> window_ice { get { return m_data.GetFloat("sim/flightmodel/failures/window_ice");} }

        /// <summary>
        ///  Ratio of icing on alpha vane - pilot AoA
        /// </summary>
        public IXPDataRef<float> aoa_ice { get { return m_data.GetFloat("sim/flightmodel/failures/aoa_ice");} }

        /// <summary>
        ///  Ratio of icing on alpha vane - copilot AoA
        /// </summary>
        public IXPDataRef<float> aoa_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/aoa_ice2");} }
    }
}