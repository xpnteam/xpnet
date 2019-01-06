using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_engineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_engineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  N2 speed as percent of max (per engine)
        /// </summary>
        public IXPDataRef<float[]> ENGN_N2_ { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_n2_");} }

        /// <summary>
        ///  Exhaust Gas Temperature (ratio from min to max)
        /// </summary>
        public IXPDataRef<float[]> ENGN_EGT { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_egt");} }

        /// <summary>
        ///  Interturbine Temperature per engine (ratio from min to max, min = 0, max = 700)
        /// </summary>
        public IXPDataRef<float[]> ENGN_ITT { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_itt");} }

        /// <summary>
        ///  Cylinder Head Temperature (ratio from min to max)
        /// </summary>
        public IXPDataRef<float[]> ENGN_CHT { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_cht");} }

        /// <summary>
        ///  EGT (per engine) in degrees  - units depend on plane, label wrong
        /// </summary>
        public IXPDataRef<float[]> ENGN_EGT_c { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_egt_c");} }

        /// <summary>
        ///  ITT (per engine) in degrees - units depend on plane, label wrong
        /// </summary>
        public IXPDataRef<float[]> ENGN_ITT_c { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_itt_c");} }

        /// <summary>
        ///  CHT (per engine in degrees  - units depend on plane, label wrong
        /// </summary>
        public IXPDataRef<float[]> ENGN_CHT_c { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_cht_c");} }

        /// <summary>
        ///  Cowl flaps control (per engine) 0 = closed, 1 = open
        /// </summary>
        public IXPDataRef<float[]> ENGN_cowl { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_cowl");} }

        /// <summary>
        ///  Engine Pressure Ratio (per engine)
        /// </summary>
        public IXPDataRef<float[]> ENGN_EPR { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_epr");} }

        /// <summary>
        ///  Fuel flow (per engine) in kg/second
        /// </summary>
        public IXPDataRef<float[]> ENGN_FF_ { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_ff_");} }

        /// <summary>
        ///  Carb Heat Control (per engine), 0 = off, 1 = on
        /// </summary>
        public IXPDataRef<float[]> ENGN_heat { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_heat");} }

        /// <summary>
        ///  Mixture Control (per engine), 0 = cutoff, 1 = full rich
        /// </summary>
        public IXPDataRef<float[]> ENGN_mixt { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_mixt");} }

        /// <summary>
        ///  N1 speed as percent of max (per engine)
        /// </summary>
        public IXPDataRef<float[]> ENGN_N1_ { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_n1_");} }

        /// <summary>
        ///  Oil pressure (per engine) in PSI
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_press_psi { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_press_psi");} }

        /// <summary>
        ///  Oil temp (per engine) in degs - units depend on plane, dref name wrong
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_temp_c { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_temp_c");} }

        /// <summary>
        ///  Oil pressure (per engine) as ratio of max
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_temp { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_temp");} }

        /// <summary>
        ///  Oil temp (per engine) a ratio of max
        /// </summary>
        public IXPDataRef<float[]> ENGN_oil_press { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_oil_press");} }

        /// <summary>
        ///  Commanded Prop Speed (per engine)
        /// </summary>
        public IXPDataRef<float[]> ENGN_prop { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_prop");} }

        /// <summary>
        ///  Throttle (per engine) as set by user, 0 = idle, 1 = max
        /// </summary>
        public IXPDataRef<float[]> ENGN_thro { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_thro");} }

        /// <summary>
        ///  Throttle (per engine) when overridden by you, plus with thrust vectors - use override_throttles to change.
        /// </summary>
        public IXPDataRef<float[]> ENGN_thro_use { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_thro_use");} }

        /// <summary>
        ///  An override from 0.0 to max fwd thrust for overriding all throttles.  Set to -2.0 to disengage.  DEPRECATED
        /// </summary>
        public IXPDataRef<float> ENGN_thro_override { get { return m_data.GetFloat("sim/flightmodel/engine/engn_thro_override");} }

        /// <summary>
        ///  Torque (per engine)
        /// </summary>
        public IXPDataRef<float[]> ENGN_TRQ { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_trq");} }

        /// <summary>
        ///  Engine on and using fuel (only reliable in 740 and later)
        /// </summary>
        public IXPDataRef<bool[]> ENGN_running { get { return m_data.GetBoolArray("sim/flightmodel/engine/engn_running");} }

        /// <summary>
        ///  Afterburner on (only reliable in 740 and later)
        /// </summary>
        public IXPDataRef<bool[]> ENGN_burning { get { return m_data.GetBoolArray("sim/flightmodel/engine/engn_burning");} }

        /// <summary>
        ///  Amount of carb ice buildup (0-1)
        /// </summary>
        public IXPDataRef<float[]> ENGN_crbice { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_crbice");} }

        /// <summary>
        ///  Engine speed in radians/second
        /// </summary>
        public IXPDataRef<float[]> ENGN_tacrad { get { return m_data.GetFloatArray("sim/flightmodel/engine/engn_tacrad");} }

        /// <summary>
        ///  Prop Pitch as commanded by the user.
        /// </summary>
        public IXPDataRef<float[]> POINT_pitch_deg { get { return m_data.GetFloatArray("sim/flightmodel/engine/point_pitch_deg");} }

        /// <summary>
        ///  Prop speed in radians/second
        /// </summary>
        public IXPDataRef<float[]> POINT_tacrad { get { return m_data.GetFloatArray("sim/flightmodel/engine/point_tacrad");} }

        /// <summary>
        ///  Torque for this prop after transmissions
        /// </summary>
        public IXPDataRef<float[]> POINT_driv_TRQ { get { return m_data.GetFloatArray("sim/flightmodel/engine/point_driv_trq");} }

        /// <summary>
        ///  Maximum torque this prop will get after transmissions
        /// </summary>
        public IXPDataRef<float[]> POINT_max_TRQ { get { return m_data.GetFloatArray("sim/flightmodel/engine/point_max_trq");} }

        /// <summary>
        ///  Pitch as we use, after all effects.   Use override_prop_pitch to change.
        /// </summary>
        public IXPDataRef<float[]> POINT_pitch_deg_use { get { return m_data.GetFloatArray("sim/flightmodel/engine/point_pitch_deg_use");} }

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns.  Override with /prop_disc/override per engine!
        /// </summary>
        public IXPDataRef<float[]> POINT_prop_ang_deg { get { return m_data.GetFloatArray("sim/flightmodel/engine/point_prop_ang_deg");} }

        /// <summary>
        ///  Burner is on or off
        /// </summary>
        public IXPDataRef<bool> burner_enabled { get { return m_data.GetBool("sim/flightmodel/engine/burner_enabled");} }

        /// <summary>
        ///  Burner is high or low
        /// </summary>
        public IXPDataRef<bool> burner_level { get { return m_data.GetBool("sim/flightmodel/engine/burner_level");} }
    }
}