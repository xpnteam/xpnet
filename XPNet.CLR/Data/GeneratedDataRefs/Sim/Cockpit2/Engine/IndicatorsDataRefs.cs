using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Engine_IndicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Engine_IndicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  N1, %.
        /// </summary>
        public IXPDataRef<float[]> N1_percent { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/n1_percent");} }

        /// <summary>
        ///  N2, %.
        /// </summary>
        public IXPDataRef<float[]> N2_percent { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/n2_percent");} }

        /// <summary>
        ///  Manifold pressure, inches HG.
        /// </summary>
        public IXPDataRef<float[]> MPR_in_hg { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/mpr_in_hg");} }

        /// <summary>
        ///  EPR, ratio.
        /// </summary>
        public IXPDataRef<float[]> EPR_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/epr_ratio");} }

        /// <summary>
        ///  Torque, NM.
        /// </summary>
        public IXPDataRef<float[]> Torque_n_mtr { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/torque_n_mtr");} }

        /// <summary>
        ///  FF, kilograms per second.
        /// </summary>
        public IXPDataRef<float[]> Fuel_flow_kg_sec { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/fuel_flow_kg_sec");} }

        /// <summary>
        ///  ITT, deg.  Dataref label is wrong, units vary by plane.
        /// </summary>
        public IXPDataRef<float[]> ITT_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/itt_deg_c");} }

        /// <summary>
        ///  EGT, deg.  Dataref label is wrong, units vary by plane.
        /// </summary>
        public IXPDataRef<float[]> EGT_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/egt_deg_c");} }

        /// <summary>
        ///  CHT, deg.  Dataref label is wrong, units vary by plane.
        /// </summary>
        public IXPDataRef<float[]> CHT_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/cht_deg_c");} }

        /// <summary>
        ///  Fuel pressure, psi.
        /// </summary>
        public IXPDataRef<float[]> Fuel_pressure_psi { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/fuel_pressure_psi");} }

        /// <summary>
        ///  Oil pressure, psi.
        /// </summary>
        public IXPDataRef<float[]> Oil_pressure_psi { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_pressure_psi");} }

        /// <summary>
        ///  Oil temp, deg.    Dataref label is wrong, units vary by plane.
        /// </summary>
        public IXPDataRef<float[]> Oil_temperature_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_temperature_deg_c");} }

        /// <summary>
        ///  Oil quantity, 0.0 to 1.0.
        /// </summary>
        public IXPDataRef<float[]> Oil_quantity_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_quantity_ratio");} }

        /// <summary>
        ///  Actual engine power output.
        /// </summary>
        public IXPDataRef<float[]> Power_watts { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/power_watts");} }

        /// <summary>
        ///  Engine thrust in Newtons
        /// </summary>
        public IXPDataRef<float[]> Thrust_n { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/thrust_n");} }

        /// <summary>
        ///  Engine speed, radians per second
        /// </summary>
        public IXPDataRef<float[]> Engine_speed_rpm { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/engine_speed_rpm");} }

        /// <summary>
        ///   Requests that the prop be feathered immediately, for plugin control of feathering.  Requires the prop to NOT be overriden for x-plane to actuate this.
        /// </summary>
        public IXPDataRef<float[]> Prop_speed_rpm { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/prop_speed_rpm");} }

        /// <summary>
        ///  Carburator temperature in degrees C
        /// </summary>
        public IXPDataRef<float[]> Carburetor_temperature_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/carburetor_temperature_c");} }
    }
}