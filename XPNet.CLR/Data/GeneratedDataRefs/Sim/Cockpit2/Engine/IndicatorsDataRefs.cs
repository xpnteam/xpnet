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
        ///  N1, %.. Units:percent
        /// </summary>
        public IXPDataRef<float[]> N1_percent => m_data.GetFloatArray("sim/cockpit2/engine/indicators/n1_percent");

        /// <summary>
        ///  N2, %.. Units:percent
        /// </summary>
        public IXPDataRef<float[]> N2_percent => m_data.GetFloatArray("sim/cockpit2/engine/indicators/n2_percent");

        /// <summary>
        ///  Manifold pressure, inches HG.. Units:inches_hg
        /// </summary>
        public IXPDataRef<float[]> MPR_in_hg => m_data.GetFloatArray("sim/cockpit2/engine/indicators/mpr_in_hg");

        /// <summary>
        ///  EPR, ratio.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> EPR_ratio => m_data.GetFloatArray("sim/cockpit2/engine/indicators/epr_ratio");

        /// <summary>
        ///  Torque, NM.. Units:newton_meters
        /// </summary>
        public IXPDataRef<float[]> Torque_n_mtr => m_data.GetFloatArray("sim/cockpit2/engine/indicators/torque_n_mtr");

        /// <summary>
        ///  FF, kilograms per second.. Units:kilograms/Second
        /// </summary>
        public IXPDataRef<float[]> Fuel_flow_kg_sec => m_data.GetFloatArray("sim/cockpit2/engine/indicators/fuel_flow_kg_sec");

        /// <summary>
        ///  ITT, deg.  Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        /// </summary>
        public IXPDataRef<float[]> ITT_deg_C => m_data.GetFloatArray("sim/cockpit2/engine/indicators/itt_deg_c");

        /// <summary>
        ///  EGT, deg.  Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        /// </summary>
        public IXPDataRef<float[]> EGT_deg_C => m_data.GetFloatArray("sim/cockpit2/engine/indicators/egt_deg_c");

        /// <summary>
        ///  CHT, deg.  Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        /// </summary>
        public IXPDataRef<float[]> CHT_deg_C => m_data.GetFloatArray("sim/cockpit2/engine/indicators/cht_deg_c");

        /// <summary>
        ///  Fuel pressure, psi.. Units:pounds/Square_inch
        /// </summary>
        public IXPDataRef<float[]> Fuel_pressure_psi => m_data.GetFloatArray("sim/cockpit2/engine/indicators/fuel_pressure_psi");

        /// <summary>
        ///  Oil pressure, psi.. Units:pounds/Square_inch
        /// </summary>
        public IXPDataRef<float[]> Oil_pressure_psi => m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_pressure_psi");

        /// <summary>
        ///  Oil temp, deg.    Dataref label is wrong, units vary by plane.. Units:degrees_C_or_F
        /// </summary>
        public IXPDataRef<float[]> Oil_temperature_deg_C => m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_temperature_deg_c");

        /// <summary>
        ///  Oil quantity, 0.0 to 1.0.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Oil_quantity_ratio => m_data.GetFloatArray("sim/cockpit2/engine/indicators/oil_quantity_ratio");

        /// <summary>
        ///  Actual engine power output.. Units:watts
        /// </summary>
        public IXPDataRef<float[]> Power_watts => m_data.GetFloatArray("sim/cockpit2/engine/indicators/power_watts");

        /// <summary>
        ///  Engine thrust in Newtons. Units:newtons
        /// </summary>
        public IXPDataRef<float[]> Thrust_n => m_data.GetFloatArray("sim/cockpit2/engine/indicators/thrust_n");

        /// <summary>
        ///  Engine speed, radians per second. Units:revolutions/Minute
        /// </summary>
        public IXPDataRef<float[]> Engine_speed_rpm => m_data.GetFloatArray("sim/cockpit2/engine/indicators/engine_speed_rpm");

        /// <summary>
        ///  Prop speed, radians per second                                                                                                                                                                                                         boolean. Units:revolutions/Minute
        /// </summary>
        public IXPDataRef<float[]> Prop_speed_rpm => m_data.GetFloatArray("sim/cockpit2/engine/indicators/prop_speed_rpm");

        /// <summary>
        ///  Carburator temperature in degrees C. Units:degrees_C
        /// </summary>
        public IXPDataRef<float[]> Carburetor_temperature_C => m_data.GetFloatArray("sim/cockpit2/engine/indicators/carburetor_temperature_c");
    }
}