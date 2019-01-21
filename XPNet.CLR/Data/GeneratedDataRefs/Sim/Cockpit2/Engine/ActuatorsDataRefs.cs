using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_engine_actuatorsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_engine_actuatorsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the longitudinal cyclic COMMAND, in degrees. Positive forwards cyclic.. Units:degrees
        ///  Raw path: sim/cockpit2/engine/actuators/cyclic_elevator_deg
        /// </summary>
        public IXPDataRef<float[]> cyclic_elevator_deg { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/cyclic_elevator_deg");} }

        /// <summary>
        ///  This is the lateral cyclic COMMAND, in degrees. Positive right cyclic.. Units:degrees
        ///  Raw path: sim/cockpit2/engine/actuators/cyclic_aileron_deg
        /// </summary>
        public IXPDataRef<float[]> cyclic_aileron_deg { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/cyclic_aileron_deg");} }

        /// <summary>
        ///  Throttle position of the handle itself, from 0.0 (idle) to 1.0 (max normal).. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/throttle_ratio
        /// </summary>
        public IXPDataRef<float[]> throttle_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/throttle_ratio");} }

        /// <summary>
        ///  Throttle position of the handle as a ratio, 0.0 is minimum beta, 1.0 = maximum beta.. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/beta_ratio
        /// </summary>
        public IXPDataRef<float[]> beta_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/beta_ratio");} }

        /// <summary>
        ///  Throttle position of the handle itself - this controls all the handles at once.. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/throttle_ratio_all
        /// </summary>
        public IXPDataRef<float> throttle_ratio_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/throttle_ratio_all");} }

        /// <summary>
        ///  Prop handle position, in radians per second of requested prop rpm.  Use this if your plane has a constant speed prop.. Units:radians/second
        ///  Raw path: sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec
        /// </summary>
        public IXPDataRef<float[]> prop_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec");} }

        /// <summary>
        ///  Prop handle position, this controls all props at once.. Units:radians/second
        ///  Raw path: sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec_all
        /// </summary>
        public IXPDataRef<float> prop_rotation_speed_rad_sec_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec_all");} }

        /// <summary>
        ///  Prop handle position, in degrees.  Use this if your plane has a manual-adjust prop.. Units:degrees
        ///  Raw path: sim/cockpit2/engine/actuators/prop_angle_degrees
        /// </summary>
        public IXPDataRef<float[]> prop_angle_degrees { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_angle_degrees");} }

        /// <summary>
        ///  Prop handle position, in degrees, set all at once.. Units:degrees
        ///  Raw path: sim/cockpit2/engine/actuators/prop_angle_degrees_all
        /// </summary>
        public IXPDataRef<float> prop_angle_degrees_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/prop_angle_degrees_all");} }

        /// <summary>
        ///  Prop handle position, in ratio. NOTE: This is also used for helicopter collective!. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/prop_ratio
        /// </summary>
        public IXPDataRef<float[]> prop_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_ratio");} }

        /// <summary>
        ///  Prop handle position, in ratio. This controls all handles at once. NOTE: This is also used for helicopter collective!. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/prop_ratio_all
        /// </summary>
        public IXPDataRef<float> prop_ratio_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/prop_ratio_all");} }

        /// <summary>
        ///  Mixture handle position, 0.0 (cutoff) to 1.0 (full rich).. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/mixture_ratio
        /// </summary>
        public IXPDataRef<float[]> mixture_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/mixture_ratio");} }

        /// <summary>
        ///  Mixture handle position, this controls all at once.. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/mixture_ratio_all
        /// </summary>
        public IXPDataRef<float> mixture_ratio_all { get { return m_data.GetFloat("sim/cockpit2/engine/actuators/mixture_ratio_all");} }

        /// <summary>
        ///  Carb-heat handle position, 0.0 (none) to 1.0 (full).. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/carb_heat_ratio
        /// </summary>
        public IXPDataRef<float[]> carb_heat_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/carb_heat_ratio");} }

        /// <summary>
        ///  Cowl-flap handle position, 0.0 (none) to 1.0 (full open).. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/cowl_flap_ratio
        /// </summary>
        public IXPDataRef<float[]> cowl_flap_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/cowl_flap_ratio");} }

        /// <summary>
        ///  Primer handle position, 0.0 (none) to 1.0 (on).. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/primer_ratio
        /// </summary>
        public IXPDataRef<float[]> primer_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/primer_ratio");} }

        /// <summary>
        ///  Afterburner enabled, on or off.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/afterburner_enabled
        /// </summary>
        public IXPDataRef<bool[]> afterburner_enabled { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/afterburner_enabled");} }

        /// <summary>
        ///  Igniter, on or off.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/igniter_on
        /// </summary>
        public IXPDataRef<bool[]> igniter_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/igniter_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - auto-ignition. This switch turns on a continuous ignition source in the engine to automatically relight it if there is a flameout.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/auto_ignite_on
        /// </summary>
        public IXPDataRef<bool[]> auto_ignite_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/auto_ignite_on");} }

        /// <summary>
        ///  0 = off, 1 = left, 2 = right, 3 = both. Units:enum
        ///  Raw path: sim/cockpit2/engine/actuators/ignition_on
        /// </summary>
        public IXPDataRef<int[]> ignition_on { get { return m_data.GetIntArray("sim/cockpit2/engine/actuators/ignition_on");} }

        /// <summary>
        ///  0 = off, 1 = left, 2 = right, 3 = both, 4 = starting. Units:enum
        ///  Raw path: sim/cockpit2/engine/actuators/ignition_key
        /// </summary>
        public IXPDataRef<int[]> ignition_key { get { return m_data.GetIntArray("sim/cockpit2/engine/actuators/ignition_key");} }

        /// <summary>
        ///  True while the starter motor is engaged. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/starter_hit
        /// </summary>
        public IXPDataRef<bool[]> starter_hit { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/starter_hit");} }

        /// <summary>
        ///  Fadec, ok or off.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/fadec_on
        /// </summary>
        public IXPDataRef<bool[]> fadec_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/fadec_on");} }

        /// <summary>
        ///  Primer button, on or off.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/primer_on
        /// </summary>
        public IXPDataRef<bool[]> primer_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/primer_on");} }

        /// <summary>
        ///  Fuel pump, on or off.  This is the electric per-engine fuel pump!. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/fuel_pump_on
        /// </summary>
        public IXPDataRef<bool[]> fuel_pump_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/fuel_pump_on");} }

        /// <summary>
        ///  Idle speed, hi=1 or lo=0.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/idle_speed
        /// </summary>
        public IXPDataRef<bool[]> idle_speed { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/idle_speed");} }

        /// <summary>
        ///  Idle speed, hi=1 or lo=0 - continuous control. Units:[0..1]
        ///  Raw path: sim/cockpit2/engine/actuators/idle_speed_ratio
        /// </summary>
        public IXPDataRef<float[]> idle_speed_ratio { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/idle_speed_ratio");} }

        /// <summary>
        ///  This is the propeller and engine operation mode. It is used for props and jets. Mode 0 is feathered, 1 is normal, 2 is in beta, and reverse (prop or jet) is mode 3.. Units:enum
        ///  Raw path: sim/cockpit2/engine/actuators/prop_mode
        /// </summary>
        public IXPDataRef<int[]> prop_mode { get { return m_data.GetIntArray("sim/cockpit2/engine/actuators/prop_mode");} }

        /// <summary>
        ///  This is the REQUESTED pitch of the prop in degrees from its flat-pitch setting.. Units:degrees
        ///  Raw path: sim/cockpit2/engine/actuators/prop_pitch_deg
        /// </summary>
        public IXPDataRef<float[]> prop_pitch_deg { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_pitch_deg");} }

        /// <summary>
        ///  Governor on-off switch.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/governor_on
        /// </summary>
        public IXPDataRef<bool[]> governor_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/governor_on");} }

        /// <summary>
        ///  Fire extinguisher on. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/fire_extinguisher_on
        /// </summary>
        public IXPDataRef<bool[]> fire_extinguisher_on { get { return m_data.GetBoolArray("sim/cockpit2/engine/actuators/fire_extinguisher_on");} }

        /// <summary>
        ///  XP10: the on/off status of the clutch, either per engine or per prop, depending on voodoo, dim 8.  V11: there is only ONE clutch for the whle airplane.. Units:boolean
        ///  Raw path: sim/cockpit2/engine/actuators/clutch_engage
        /// </summary>
        public IXPDataRef<float[]> clutch_engage { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/clutch_engage");} }

        /// <summary>
        ///  XP10: the ratio of the clutch, either per engine or per prop, depending on voodoo, dim 8.  V11: there is only ONE clutch for the whle airplane.. Units:ratio
        ///  Raw path: sim/cockpit2/engine/actuators/manual_feather_prop
        /// </summary>
        public IXPDataRef<float[]> manual_feather_prop { get { return m_data.GetFloatArray("sim/cockpit2/engine/actuators/manual_feather_prop");} }
    }
}