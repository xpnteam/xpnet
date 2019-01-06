using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_FailuresDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_FailuresDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Ratio of icing on wings/Airframe - left wing
        /// </summary>
        public IXPDataRef<float> Frm_ice { get { return m_data.GetFloat("sim/flightmodel/failures/frm_ice");} }

        /// <summary>
        ///  Ratio of icing on wings/Airframe - right wing
        /// </summary>
        public IXPDataRef<float> Frm_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/frm_ice2");} }

        /// <summary>
        ///  Ratio of icing on pitot tube
        /// </summary>
        public IXPDataRef<float> Pitot_ice { get { return m_data.GetFloat("sim/flightmodel/failures/pitot_ice");} }

        /// <summary>
        ///  Ratio of icing on pitot tube2
        /// </summary>
        public IXPDataRef<float> Pitot_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/pitot_ice2");} }

        /// <summary>
        ///  Ratio of icing on the prop - first prop
        /// </summary>
        public IXPDataRef<float> Prop_ice { get { return m_data.GetFloat("sim/flightmodel/failures/prop_ice");} }

        /// <summary>
        ///  Ratio of icing on the air inlets - first engine
        /// </summary>
        public IXPDataRef<float> Inlet_ice { get { return m_data.GetFloat("sim/flightmodel/failures/inlet_ice");} }

        /// <summary>
        ///  Ratio of icing on the prop - array access to all props.
        /// </summary>
        public IXPDataRef<float[]> Prop_ice_per_engine { get { return m_data.GetFloatArray("sim/flightmodel/failures/prop_ice_per_engine");} }

        /// <summary>
        ///  Ratio of icing on the air inlets - array access to all engines.
        /// </summary>
        public IXPDataRef<float[]> Inlet_ice_per_engine { get { return m_data.GetFloatArray("sim/flightmodel/failures/inlet_ice_per_engine");} }

        /// <summary>
        ///  Ratio of icing on the windshield
        /// </summary>
        public IXPDataRef<float> Window_ice { get { return m_data.GetFloat("sim/flightmodel/failures/window_ice");} }

        /// <summary>
        ///  Ratio of icing on alpha vane - pilot AoA
        /// </summary>
        public IXPDataRef<float> Aoa_ice { get { return m_data.GetFloat("sim/flightmodel/failures/aoa_ice");} }

        /// <summary>
        ///  Ratio of icing on alpha vane - copilot AoA
        /// </summary>
        public IXPDataRef<float> Aoa_ice2 { get { return m_data.GetFloat("sim/flightmodel/failures/aoa_ice2");} }
    }
}