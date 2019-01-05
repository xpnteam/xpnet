using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  N2 speed as percent of max (per engine). Units:percent
        /// </summary>
        public IXPDataRef<float[]> ENGN_N2_ => m_data.GetFloatArray("sim/flightmodel/engine/engn_n2_");

        /// <summary>
        ///  Exhaust Gas Temperature (ratio from min to max). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_EGT => m_data.GetFloatArray("sim/flightmodel/engine/engn_egt");

        /// <summary>
        ///  Interturbine Temperature per engine (ratio from min to max, min = 0, max = 700). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_ITT => m_data.GetFloatArray("sim/flightmodel/engine/engn_itt");

        /// <summary>
        ///  Cylinder Head Temperature (ratio from min to max). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_CHT => m_data.GetFloatArray("sim/flightmodel/engine/engn_cht");

        /// <summary>
        ///  EGT (per engine) in degrees  - units depend on plane, label wrong. Units:degc_or_f
        /// </summary>
        public IXPDataRef<float[]> ENGN_EGT_c => m_data.GetFloatArray("sim/flightmodel/engine/engn_egt_c");

        /// <summary>
        ///  ITT (per engine) in degrees - units depend on plane, label wrong. Units:degc_or_f
        /// </summary>
        public IXPDataRef<float[]> ENGN_ITT_c => m_data.GetFloatArray("sim/flightmodel/engine/engn_itt_c");

        /// <summary>
        ///  CHT (per engine in degrees  - units depend on plane, label wrong. Units:degc_or_f
        /// </summary>
        public IXPDataRef<float[]> ENGN_CHT_c => m_data.GetFloatArray("sim/flightmodel/engine/engn_cht_c");

        /// <summary>
        ///  Cowl flaps control (per engine) 0 = closed, 1 = open. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_cowl => m_data.GetFloatArray("sim/flightmodel/engine/engn_cowl");

        /// <summary>
        ///  Engine Pressure Ratio (per engine). Units:EPR
        /// </summary>
        public IXPDataRef<float[]> ENGN_EPR => m_data.GetFloatArray("sim/flightmodel/engine/engn_epr");

        /// <summary>
        ///  Fuel flow (per engine) in kg/Second. Units:kg/S
        /// </summary>
        public IXPDataRef<float[]> ENGN_FF_ => m_data.GetFloatArray("sim/flightmodel/engine/engn_ff_");

        /// <summary>
        ///  Carb Heat Control (per engine), 0 = off, 1 = on. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_heat => m_data.GetFloatArray("sim/flightmodel/engine/engn_heat");

        /// <summary>
        ///  Mixture Control (per engine), 0 = cutoff, 1 = full rich. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_mixt => m_data.GetFloatArray("sim/flightmodel/engine/engn_mixt");

        /// <summary>
        ///  N1 speed as percent of max (per engine). Units:percent
        /// </summary>
        public IXPDataRef<float[]> ENGN_N1_ => m_data.GetFloatArray("sim/flightmodel/engine/engn_n1_");

        /// <summary>
        ///  Oil pressure (per engine) in PSI. Units:psi
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_press_psi => m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_press_psi");

        /// <summary>
        ///  Oil temp (per engine) in degs - units depend on plane, dref name wrong. Units:degc_or_f
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_temp_c => m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_temp_c");

        /// <summary>
        ///  Oil pressure (per engine) as ratio of max. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_temp => m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_temp");

        /// <summary>
        ///  Oil temp (per engine) a ratio of max. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_press => m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_press");

        /// <summary>
        ///  Commanded Prop Speed (per engine). Units:rad/Sec
        /// </summary>
        public IXPDataRef<float[]> ENGN_prop => m_data.GetFloatArray("sim/flightmodel/engine/engn_prop");

        /// <summary>
        ///  Throttle (per engine) as set by user, 0 = idle, 1 = max. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_thro => m_data.GetFloatArray("sim/flightmodel/engine/engn_thro");

        /// <summary>
        ///  Throttle (per engine) when overridden by you, plus with thrust vectors - use override_throttles to change.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_thro_use => m_data.GetFloatArray("sim/flightmodel/engine/engn_thro_use");

        /// <summary>
        ///  An override from 0.0 to max fwd thrust for overriding all throttles.  Set to -2.0 to disengage.  DEPRECATED. Units:ratio
        /// </summary>
        public IXPDataRef<float> ENGN_thro_override => m_data.GetFloat("sim/flightmodel/engine/engn_thro_override");

        /// <summary>
        ///  Torque (per engine). Units:NewtonMeters
        /// </summary>
        public IXPDataRef<float[]> ENGN_TRQ => m_data.GetFloatArray("sim/flightmodel/engine/engn_trq");

        /// <summary>
        ///  Amount of carb ice buildup (0-1). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> ENGN_crbice => m_data.GetFloatArray("sim/flightmodel/engine/engn_crbice");

        /// <summary>
        ///  Engine speed in radians/Second. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float[]> ENGN_tacrad => m_data.GetFloatArray("sim/flightmodel/engine/engn_tacrad");

        /// <summary>
        ///  Prop Pitch as commanded by the user.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> POINT_pitch_deg => m_data.GetFloatArray("sim/flightmodel/engine/point_pitch_deg");

        /// <summary>
        ///  Prop speed in radians/Second. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float[]> POINT_tacrad => m_data.GetFloatArray("sim/flightmodel/engine/point_tacrad");

        /// <summary>
        ///  Torque for this prop after transmissions. Units:newton-meters
        /// </summary>
        public IXPDataRef<float[]> POINT_driv_TRQ => m_data.GetFloatArray("sim/flightmodel/engine/point_driv_trq");

        /// <summary>
        ///  Maximum torque this prop will get after transmissions. Units:newton-meters
        /// </summary>
        public IXPDataRef<float[]> POINT_max_TRQ => m_data.GetFloatArray("sim/flightmodel/engine/point_max_trq");

        /// <summary>
        ///  Pitch as we use, after all effects.   Use override_prop_pitch to change.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> POINT_pitch_deg_use => m_data.GetFloatArray("sim/flightmodel/engine/point_pitch_deg_use");

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns.  Override with /Prop_disc/Override per engine!. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> POINT_prop_ang_deg => m_data.GetFloatArray("sim/flightmodel/engine/point_prop_ang_deg");
    }
}