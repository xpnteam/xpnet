using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Engine_ActuatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Engine_ActuatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the longitudinal cyclic COMMAND, in degrees. Positive forwards cyclic.
        /// </summary>
        public IXPDataRef<float[]> Cyclic_elevator_deg { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/cyclic_elevator_deg");} }

        /// <summary>
        ///  This is the lateral cyclic COMMAND, in degrees. Positive right cyclic.
        /// </summary>
        public IXPDataRef<float[]> Cyclic_aileron_deg { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/cyclic_aileron_deg");} }

        /// <summary>
        ///  Throttle position of the handle itself, from 0.0 (idle) to 1.0 (max normal).
        /// </summary>
        public IXPDataRef<float[]> Throttle_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/throttle_ratio");} }

        /// <summary>
        ///  Throttle position of the handle as a ratio, 0.0 is minimum beta, 1.0 = maximum beta.
        /// </summary>
        public IXPDataRef<float[]> Beta_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/beta_ratio");} }

        /// <summary>
        ///  Throttle position of the handle itself - this controls all the handles at once.
        /// </summary>
        public IXPDataRef<float> Throttle_ratio_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/throttle_ratio_all");} }

        /// <summary>
        ///  Prop handle position, in radians per second of requested prop rpm.  Use this if your plane has a constant speed prop.
        /// </summary>
        public IXPDataRef<float[]> Prop_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec");} }

        /// <summary>
        ///  Prop handle position, this controls all props at once.
        /// </summary>
        public IXPDataRef<float> Prop_rotation_speed_rad_sec_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec_all");} }

        /// <summary>
        ///  Prop handle position, in degrees.  Use this if your plane has a manual-adjust prop.
        /// </summary>
        public IXPDataRef<float[]> Prop_angle_degrees { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_angle_degrees");} }

        /// <summary>
        ///  Prop handle position, in degrees, set all at once.
        /// </summary>
        public IXPDataRef<float> Prop_angle_degrees_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/prop_angle_degrees_all");} }

        /// <summary>
        ///  Prop handle position, in ratio. NOTE: This is also used for helicopter collective!
        /// </summary>
        public IXPDataRef<float[]> Prop_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_ratio");} }

        /// <summary>
        ///  Prop handle position, in ratio. This controls all handles at once. NOTE: This is also used for helicopter collective!
        /// </summary>
        public IXPDataRef<float> Prop_ratio_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/prop_ratio_all");} }

        /// <summary>
        ///  Mixture handle position, 0.0 (cutoff) to 1.0 (full rich).
        /// </summary>
        public IXPDataRef<float[]> Mixture_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/mixture_ratio");} }

        /// <summary>
        ///  Mixture handle position, this controls all at once.
        /// </summary>
        public IXPDataRef<float> Mixture_ratio_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/mixture_ratio_all");} }

        /// <summary>
        ///  Carb-heat handle position, 0.0 (none) to 1.0 (full).
        /// </summary>
        public IXPDataRef<float[]> Carb_heat_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/carb_heat_ratio");} }

        /// <summary>
        ///  Cowl-flap handle position, 0.0 (none) to 1.0 (full open).
        /// </summary>
        public IXPDataRef<float[]> Cowl_flap_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/cowl_flap_ratio");} }

        /// <summary>
        ///  Primer handle position, 0.0 (none) to 1.0 (on).
        /// </summary>
        public IXPDataRef<float[]> Primer_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/primer_ratio");} }

        /// <summary>
        ///  Afterburner enabled, on or off.
        /// </summary>
        public IXPDataRef<bool[]> Afterburner_enabled { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/afterburner_enabled");} }

        /// <summary>
        ///  Igniter, on or off.
        /// </summary>
        public IXPDataRef<bool[]> Igniter_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/igniter_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - auto-ignition. This switch turns on a continuous ignition source in the engine to automatically relight it if there is a flameout.
        /// </summary>
        public IXPDataRef<bool[]> Auto_ignite_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/auto_ignite_on");} }

        /// <summary>
        ///  True while the starter motor is engaged
        /// </summary>
        public IXPDataRef<bool[]> Starter_hit { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/starter_hit");} }

        /// <summary>
        ///  Fadec, ok or off.
        /// </summary>
        public IXPDataRef<bool[]> Fadec_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/fadec_on");} }

        /// <summary>
        ///  Primer button, on or off.
        /// </summary>
        public IXPDataRef<bool[]> Primer_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/primer_on");} }

        /// <summary>
        ///  Fuel pump, on or off.  This is the electric per-engine fuel pump!
        /// </summary>
        public IXPDataRef<bool[]> Fuel_pump_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/fuel_pump_on");} }

        /// <summary>
        ///  Idle speed, hi=1 or lo=0.
        /// </summary>
        public IXPDataRef<bool[]> Idle_speed { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/idle_speed");} }

        /// <summary>
        ///  Idle speed, hi=1 or lo=0 - continuous control
        /// </summary>
        public IXPDataRef<float[]> Idle_speed_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/idle_speed_ratio");} }

        /// <summary>
        ///  This is the REQUESTED pitch of the prop in degrees from its flat-pitch setting.
        /// </summary>
        public IXPDataRef<float[]> Prop_pitch_deg { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_pitch_deg");} }

        /// <summary>
        ///  Governor on-off switch.
        /// </summary>
        public IXPDataRef<bool[]> Governor_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/governor_on");} }

        /// <summary>
        ///  Fire extinguisher on
        /// </summary>
        public IXPDataRef<bool[]> Fire_extinguisher_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/fire_extinguisher_on");} }

        /// <summary>
        ///  XP10: the on/Off status of the clutch, either per engine or per prop, depending on voodoo, dim 8.  V11: there is only ONE clutch for the whle airplane.
        /// </summary>
        public IXPDataRef<float[]> Clutch_engage { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/clutch_engage");} }

        /// <summary>
        ///  XP10: the ratio of the clutch, either per engine or per prop, depending on voodoo, dim 8.  V11: there is only ONE clutch for the whle airplane.
        /// </summary>
        public IXPDataRef<float[]> Manual_feather_prop { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/manual_feather_prop");} }
    }
}