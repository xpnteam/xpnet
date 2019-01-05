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
        ///  This is the longitudinal cyclic COMMAND, in degrees. Positive forwards cyclic.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Cyclic_elevator_deg => m_data.GetFloatArray("sim/cockpit2/engine/actuators/cyclic_elevator_deg");

        /// <summary>
        ///  This is the lateral cyclic COMMAND, in degrees. Positive right cyclic.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Cyclic_aileron_deg => m_data.GetFloatArray("sim/cockpit2/engine/actuators/cyclic_aileron_deg");

        /// <summary>
        ///  Throttle position of the handle itself, from 0.0 (idle) to 1.0 (max normal).. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Throttle_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/throttle_ratio");

        /// <summary>
        ///  Throttle position of the handle as a ratio, 0.0 is minimum beta, 1.0 = maximum beta.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Beta_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/beta_ratio");

        /// <summary>
        ///  Throttle position of the handle itself - this controls all the handles at once.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Throttle_ratio_all => m_data.GetFloat("sim/cockpit2/engine/actuators/throttle_ratio_all");

        /// <summary>
        ///  Prop handle position, in radians per second of requested prop rpm.  Use this if your plane has a constant speed prop.. Units:radians/Second
        /// </summary>
        public IXPDataRef<float[]> Prop_rotation_speed_rad_sec => m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec");

        /// <summary>
        ///  Prop handle position, this controls all props at once.. Units:radians/Second
        /// </summary>
        public IXPDataRef<float> Prop_rotation_speed_rad_sec_all => m_data.GetFloat("sim/cockpit2/engine/actuators/prop_rotation_speed_rad_sec_all");

        /// <summary>
        ///  Prop handle position, in degrees.  Use this if your plane has a manual-adjust prop.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Prop_angle_degrees => m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_angle_degrees");

        /// <summary>
        ///  Prop handle position, in degrees, set all at once.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Prop_angle_degrees_all => m_data.GetFloat("sim/cockpit2/engine/actuators/prop_angle_degrees_all");

        /// <summary>
        ///  Prop handle position, in ratio. NOTE: This is also used for helicopter collective!. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Prop_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_ratio");

        /// <summary>
        ///  Prop handle position, in ratio. This controls all handles at once. NOTE: This is also used for helicopter collective!. Units:ratio
        /// </summary>
        public IXPDataRef<float> Prop_ratio_all => m_data.GetFloat("sim/cockpit2/engine/actuators/prop_ratio_all");

        /// <summary>
        ///  Mixture handle position, 0.0 (cutoff) to 1.0 (full rich).. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Mixture_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/mixture_ratio");

        /// <summary>
        ///  Mixture handle position, this controls all at once.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mixture_ratio_all => m_data.GetFloat("sim/cockpit2/engine/actuators/mixture_ratio_all");

        /// <summary>
        ///  Carb-heat handle position, 0.0 (none) to 1.0 (full).. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Carb_heat_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/carb_heat_ratio");

        /// <summary>
        ///  Cowl-flap handle position, 0.0 (none) to 1.0 (full open).. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Cowl_flap_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/cowl_flap_ratio");

        /// <summary>
        ///  Primer handle position, 0.0 (none) to 1.0 (on).. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Primer_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/primer_ratio");

        /// <summary>
        ///  Idle speed, hi=1 or lo=0 - continuous control. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Idle_speed_ratio => m_data.GetFloatArray("sim/cockpit2/engine/actuators/idle_speed_ratio");

        /// <summary>
        ///  This is the REQUESTED pitch of the prop in degrees from its flat-pitch setting.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Prop_pitch_deg => m_data.GetFloatArray("sim/cockpit2/engine/actuators/prop_pitch_deg");

        /// <summary>
        ///  XP10: the on/Off status of the clutch, either per engine or per prop, depending on voodoo, dim 8.  V11: there is only ONE clutch for the whle airplane.. Units:boolean
        /// </summary>
        public IXPDataRef<float[]> Clutch_engage => m_data.GetFloatArray("sim/cockpit2/engine/actuators/clutch_engage");

        /// <summary>
        ///  XP10: the ratio of the clutch, either per engine or per prop, depending on voodoo, dim 8.  V11: there is only ONE clutch for the whle airplane.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Manual_feather_prop => m_data.GetFloatArray("sim/cockpit2/engine/actuators/manual_feather_prop");
    }
}