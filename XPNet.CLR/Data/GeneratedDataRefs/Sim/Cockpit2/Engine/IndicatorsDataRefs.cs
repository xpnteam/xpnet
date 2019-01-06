using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_engine_indicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_engine_indicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  N1, %.. Units:percent
        ///  Raw path: sim/cockpit2/engine/indicators/N1_percent
        /// </summary>
        public IXPDataRef<float[]> N1_percent { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/n1_percent");} }

        /// <summary>
        ///  N2, %.. Units:percent
        ///  Raw path: sim/cockpit2/engine/indicators/N2_percent
        /// </summary>
        public IXPDataRef<float[]> N2_percent { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/n2_percent");} }

        /// <summary>
        ///  Manifold pressure, inches HG.. Units:inches_hg
        ///  Raw path: sim/cockpit2/engine/indicators/MPR_in_hg
        /// </summary>
        public IXPDataRef<float[]> MPR_in_hg { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/mpr_in_hg");} }

        /// <summary>
        ///  EPR, ratio.. Units:ratio
        ///  Raw path: sim/cockpit2/engine/indicators/EPR_ratio
        /// </summary>
        public IXPDataRef<float[]> EPR_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/epr_ratio");} }

        /// <summary>
        ///  Torque, NM.. Units:newton_meters
        ///  Raw path: sim/cockpit2/engine/indicators/torque_n_mtr
        /// </summary>
        public IXPDataRef<float[]> torque_n_mtr { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/torque_n_mtr");} }

        /// <summary>
        ///  FF, kilograms per second.. Units:kilograms/second
        ///  Raw path: sim/cockpit2/engine/indicators/fuel_flow_kg_sec
        /// </summary>
        public IXPDataRef<float[]> fuel_flow_kg_sec { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/fuel_flow_kg_sec");} }

        /// <summary>
        ///  ITT, deg.  Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        ///  Raw path: sim/cockpit2/engine/indicators/ITT_deg_C
        /// </summary>
        public IXPDataRef<float[]> ITT_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/itt_deg_c");} }

        /// <summary>
        ///  EGT, deg.  Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        ///  Raw path: sim/cockpit2/engine/indicators/EGT_deg_C
        /// </summary>
        public IXPDataRef<float[]> EGT_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/egt_deg_c");} }

        /// <summary>
        ///  CHT, deg.  Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        ///  Raw path: sim/cockpit2/engine/indicators/CHT_deg_C
        /// </summary>
        public IXPDataRef<float[]> CHT_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/cht_deg_c");} }

        /// <summary>
        ///  Fuel pressure, psi.. Units:pounds/square_inch
        ///  Raw path: sim/cockpit2/engine/indicators/fuel_pressure_psi
        /// </summary>
        public IXPDataRef<float[]> fuel_pressure_psi { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/fuel_pressure_psi");} }

        /// <summary>
        ///  Oil pressure, psi.. Units:pounds/square_inch
        ///  Raw path: sim/cockpit2/engine/indicators/oil_pressure_psi
        /// </summary>
        public IXPDataRef<float[]> oil_pressure_psi { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_pressure_psi");} }

        /// <summary>
        ///  Oil temp, deg.    Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        ///  Raw path: sim/cockpit2/engine/indicators/oil_temperature_deg_C
        /// </summary>
        public IXPDataRef<float[]> oil_temperature_deg_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_temperature_deg_c");} }

        /// <summary>
        ///  Oil quantity, 0.0 to 1.0.. Units:ratio
        ///  Raw path: sim/cockpit2/engine/indicators/oil_quantity_ratio
        /// </summary>
        public IXPDataRef<float[]> oil_quantity_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_quantity_ratio");} }

        /// <summary>
        ///  Actual engine power output.. Units:watts
        ///  Raw path: sim/cockpit2/engine/indicators/power_watts
        /// </summary>
        public IXPDataRef<float[]> power_watts { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/power_watts");} }

        /// <summary>
        ///  Engine thrust in Newtons. Units:newtons
        ///  Raw path: sim/cockpit2/engine/indicators/thrust_n
        /// </summary>
        public IXPDataRef<float[]> thrust_n { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/thrust_n");} }

        /// <summary>
        ///  Engine speed, radians per second. Units:revolutions/minute
        ///  Raw path: sim/cockpit2/engine/indicators/engine_speed_rpm
        /// </summary>
        public IXPDataRef<float[]> engine_speed_rpm { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/engine_speed_rpm");} }

        /// <summary>
        ///   Requests that the prop be feathered immediately, for plugin control of feathering.  Requires the prop to NOT be overriden for x-plane to actuate this.. Units:revolutions/minute
        ///  Raw path: sim/cockpit2/engine/indicators/prop_speed_rpm
        /// </summary>
        public IXPDataRef<float[]> prop_speed_rpm { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/prop_speed_rpm");} }

        /// <summary>
        ///  Carburator temperature in degrees C. Units:degrees_C
        ///  Raw path: sim/cockpit2/engine/indicators/carburetor_temperature_C
        /// </summary>
        public IXPDataRef<float[]> carburetor_temperature_C { get { return m_data.GetFloatArray("sim/cockpit2/engine/indicators/carburetor_temperature_c");} }
    }
}