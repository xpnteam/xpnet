using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Multiplayer_PositionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Multiplayer_PositionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Plane 1 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane1_the => m_data.GetFloat("sim/multiplayer/position/plane1_the");

        /// <summary>
        ///  Plane 1 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane1_phi => m_data.GetFloat("sim/multiplayer/position/plane1_phi");

        /// <summary>
        ///  Plane 1 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane1_psi => m_data.GetFloat("sim/multiplayer/position/plane1_psi");

        /// <summary>
        ///  Plane 1 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane1_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane1_gear_deploy");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane1_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane1_flap_ratio2");

        /// <summary>
        ///  Plane 1 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane1_spoiler_ratio");

        /// <summary>
        ///  Plane 1 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane1_speedbrake_ratio");

        /// <summary>
        ///  Plane 1 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_slat_ratio => m_data.GetFloat("sim/multiplayer/position/plane1_slat_ratio");

        /// <summary>
        ///  Plane 1 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane1_wing_sweep");

        /// <summary>
        ///  Plane 1 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane1_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane1_throttle");

        /// <summary>
        ///  Plane 1 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane1_yolk_pitch");

        /// <summary>
        ///  Plane 1 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane1_yolk_roll");

        /// <summary>
        ///  Plane 1 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane1_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane1_yolk_yaw");

        /// <summary>
        ///  Plane 2 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane2_the => m_data.GetFloat("sim/multiplayer/position/plane2_the");

        /// <summary>
        ///  Plane 2 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane2_phi => m_data.GetFloat("sim/multiplayer/position/plane2_phi");

        /// <summary>
        ///  Plane 2 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane2_psi => m_data.GetFloat("sim/multiplayer/position/plane2_psi");

        /// <summary>
        ///  Plane 2 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane2_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane2_gear_deploy");

        /// <summary>
        ///  Plane 2 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane2_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane2_flap_ratio2");

        /// <summary>
        ///  Plane 2 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane2_spoiler_ratio");

        /// <summary>
        ///  Plane 2 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane2_speedbrake_ratio");

        /// <summary>
        ///  Plane 2 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane2_sla1_ratio");

        /// <summary>
        ///  Plane 2 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane2_wing_sweep");

        /// <summary>
        ///  Plane 2 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane2_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane2_throttle");

        /// <summary>
        ///  Plane 2 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane2_yolk_pitch");

        /// <summary>
        ///  Plane 2 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane2_yolk_roll");

        /// <summary>
        ///  Plane 2 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane2_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane2_yolk_yaw");

        /// <summary>
        ///  Plane 3 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane3_the => m_data.GetFloat("sim/multiplayer/position/plane3_the");

        /// <summary>
        ///  Plane 3 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane3_phi => m_data.GetFloat("sim/multiplayer/position/plane3_phi");

        /// <summary>
        ///  Plane 3 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane3_psi => m_data.GetFloat("sim/multiplayer/position/plane3_psi");

        /// <summary>
        ///  Plane 3 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane3_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane3_gear_deploy");

        /// <summary>
        ///  Plane 3 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane3_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane3_flap_ratio2");

        /// <summary>
        ///  Plane 3 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane3_spoiler_ratio");

        /// <summary>
        ///  Plane 3 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane3_speedbrake_ratio");

        /// <summary>
        ///  Plane 3 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane3_sla1_ratio");

        /// <summary>
        ///  Plane 3 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane3_wing_sweep");

        /// <summary>
        ///  Plane 3 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane3_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane3_throttle");

        /// <summary>
        ///  Plane 3 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane3_yolk_pitch");

        /// <summary>
        ///  Plane 3 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane3_yolk_roll");

        /// <summary>
        ///  Plane 3 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane3_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane3_yolk_yaw");

        /// <summary>
        ///  Plane 4 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane4_the => m_data.GetFloat("sim/multiplayer/position/plane4_the");

        /// <summary>
        ///  Plane 4 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane4_phi => m_data.GetFloat("sim/multiplayer/position/plane4_phi");

        /// <summary>
        ///  Plane 4 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane4_psi => m_data.GetFloat("sim/multiplayer/position/plane4_psi");

        /// <summary>
        ///  Plane 4 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane4_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane4_gear_deploy");

        /// <summary>
        ///  Plane 4 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane4_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane4_flap_ratio2");

        /// <summary>
        ///  Plane 4 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane4_spoiler_ratio");

        /// <summary>
        ///  Plane 4 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane4_speedbrake_ratio");

        /// <summary>
        ///  Plane 4 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane4_sla1_ratio");

        /// <summary>
        ///  Plane 4 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane4_wing_sweep");

        /// <summary>
        ///  Plane 4 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane4_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane4_throttle");

        /// <summary>
        ///  Plane 4 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane4_yolk_pitch");

        /// <summary>
        ///  Plane 4 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane4_yolk_roll");

        /// <summary>
        ///  Plane 4 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane4_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane4_yolk_yaw");

        /// <summary>
        ///  Plane 5 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane5_the => m_data.GetFloat("sim/multiplayer/position/plane5_the");

        /// <summary>
        ///  Plane 5 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane5_phi => m_data.GetFloat("sim/multiplayer/position/plane5_phi");

        /// <summary>
        ///  Plane 5 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane5_psi => m_data.GetFloat("sim/multiplayer/position/plane5_psi");

        /// <summary>
        ///  Plane 5 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane5_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane5_gear_deploy");

        /// <summary>
        ///  Plane 5 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane5_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane5_flap_ratio2");

        /// <summary>
        ///  Plane 5 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane5_spoiler_ratio");

        /// <summary>
        ///  Plane 5 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane5_speedbrake_ratio");

        /// <summary>
        ///  Plane 5 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane5_sla1_ratio");

        /// <summary>
        ///  Plane 5 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane5_wing_sweep");

        /// <summary>
        ///  Plane 5 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane5_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane5_throttle");

        /// <summary>
        ///  Plane 5 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane5_yolk_pitch");

        /// <summary>
        ///  Plane 5 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane5_yolk_roll");

        /// <summary>
        ///  Plane 5 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane5_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane5_yolk_yaw");

        /// <summary>
        ///  Plane 6 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane6_the => m_data.GetFloat("sim/multiplayer/position/plane6_the");

        /// <summary>
        ///  Plane 6 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane6_phi => m_data.GetFloat("sim/multiplayer/position/plane6_phi");

        /// <summary>
        ///  Plane 6 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane6_psi => m_data.GetFloat("sim/multiplayer/position/plane6_psi");

        /// <summary>
        ///  Plane 6 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane6_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane6_gear_deploy");

        /// <summary>
        ///  Plane 6 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane6_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane6_flap_ratio2");

        /// <summary>
        ///  Plane 6 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane6_spoiler_ratio");

        /// <summary>
        ///  Plane 6 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane6_speedbrake_ratio");

        /// <summary>
        ///  Plane 6 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane6_sla1_ratio");

        /// <summary>
        ///  Plane 6 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane6_wing_sweep");

        /// <summary>
        ///  Plane 6 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane6_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane6_throttle");

        /// <summary>
        ///  Plane 6 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane6_yolk_pitch");

        /// <summary>
        ///  Plane 6 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane6_yolk_roll");

        /// <summary>
        ///  Plane 6 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane6_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane6_yolk_yaw");

        /// <summary>
        ///  Plane 7 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane7_the => m_data.GetFloat("sim/multiplayer/position/plane7_the");

        /// <summary>
        ///  Plane 7 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane7_phi => m_data.GetFloat("sim/multiplayer/position/plane7_phi");

        /// <summary>
        ///  Plane 7 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane7_psi => m_data.GetFloat("sim/multiplayer/position/plane7_psi");

        /// <summary>
        ///  Plane 7 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane7_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane7_gear_deploy");

        /// <summary>
        ///  Plane 7 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane7_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane7_flap_ratio2");

        /// <summary>
        ///  Plane 7 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane7_spoiler_ratio");

        /// <summary>
        ///  Plane 7 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane7_speedbrake_ratio");

        /// <summary>
        ///  Plane 7 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane7_sla1_ratio");

        /// <summary>
        ///  Plane 7 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane7_wing_sweep");

        /// <summary>
        ///  Plane 7 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane7_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane7_throttle");

        /// <summary>
        ///  Plane 7 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane7_yolk_pitch");

        /// <summary>
        ///  Plane 7 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane7_yolk_roll");

        /// <summary>
        ///  Plane 7 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane7_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane7_yolk_yaw");

        /// <summary>
        ///  Plane 8 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane8_the => m_data.GetFloat("sim/multiplayer/position/plane8_the");

        /// <summary>
        ///  Plane 8 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane8_phi => m_data.GetFloat("sim/multiplayer/position/plane8_phi");

        /// <summary>
        ///  Plane 8 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane8_psi => m_data.GetFloat("sim/multiplayer/position/plane8_psi");

        /// <summary>
        ///  Plane 8 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane8_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane8_gear_deploy");

        /// <summary>
        ///  Plane 8 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane8_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane8_flap_ratio2");

        /// <summary>
        ///  Plane 8 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane8_spoiler_ratio");

        /// <summary>
        ///  Plane 8 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane8_speedbrake_ratio");

        /// <summary>
        ///  Plane 8 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane8_sla1_ratio");

        /// <summary>
        ///  Plane 8 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane8_wing_sweep");

        /// <summary>
        ///  Plane 8 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane8_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane8_throttle");

        /// <summary>
        ///  Plane 8 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane8_yolk_pitch");

        /// <summary>
        ///  Plane 8 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane8_yolk_roll");

        /// <summary>
        ///  Plane 8 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane8_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane8_yolk_yaw");

        /// <summary>
        ///  Plane 9 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane9_the => m_data.GetFloat("sim/multiplayer/position/plane9_the");

        /// <summary>
        ///  Plane 9 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane9_phi => m_data.GetFloat("sim/multiplayer/position/plane9_phi");

        /// <summary>
        ///  Plane 9 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane9_psi => m_data.GetFloat("sim/multiplayer/position/plane9_psi");

        /// <summary>
        ///  Plane 9 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane9_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane9_gear_deploy");

        /// <summary>
        ///  Plane 9 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane9_flap_ratio");

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane9_flap_ratio2");

        /// <summary>
        ///  Plane 9 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane9_spoiler_ratio");

        /// <summary>
        ///  Plane 9 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane9_speedbrake_ratio");

        /// <summary>
        ///  Plane 9 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane9_sla1_ratio");

        /// <summary>
        ///  Plane 9 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane9_wing_sweep");

        /// <summary>
        ///  Plane 9 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane9_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane9_throttle");

        /// <summary>
        ///  Plane 9 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane9_yolk_pitch");

        /// <summary>
        ///  Plane 9 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane9_yolk_roll");

        /// <summary>
        ///  Plane 9 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane9_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane9_yolk_yaw");

        /// <summary>
        ///  Plane 1 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane1_v_x => m_data.GetFloat("sim/multiplayer/position/plane1_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane1_v_y => m_data.GetFloat("sim/multiplayer/position/plane1_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane1_v_z => m_data.GetFloat("sim/multiplayer/position/plane1_v_z");

        /// <summary>
        ///  Plane 2 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane2_v_x => m_data.GetFloat("sim/multiplayer/position/plane2_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane2_v_y => m_data.GetFloat("sim/multiplayer/position/plane2_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane2_v_z => m_data.GetFloat("sim/multiplayer/position/plane2_v_z");

        /// <summary>
        ///  Plane 3 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane3_v_x => m_data.GetFloat("sim/multiplayer/position/plane3_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane3_v_y => m_data.GetFloat("sim/multiplayer/position/plane3_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane3_v_z => m_data.GetFloat("sim/multiplayer/position/plane3_v_z");

        /// <summary>
        ///  Plane 4 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane4_v_x => m_data.GetFloat("sim/multiplayer/position/plane4_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane4_v_y => m_data.GetFloat("sim/multiplayer/position/plane4_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane4_v_z => m_data.GetFloat("sim/multiplayer/position/plane4_v_z");

        /// <summary>
        ///  Plane 5 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane5_v_x => m_data.GetFloat("sim/multiplayer/position/plane5_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane5_v_y => m_data.GetFloat("sim/multiplayer/position/plane5_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane5_v_z => m_data.GetFloat("sim/multiplayer/position/plane5_v_z");

        /// <summary>
        ///  Plane 6 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane6_v_x => m_data.GetFloat("sim/multiplayer/position/plane6_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane6_v_y => m_data.GetFloat("sim/multiplayer/position/plane6_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane6_v_z => m_data.GetFloat("sim/multiplayer/position/plane6_v_z");

        /// <summary>
        ///  Plane 7 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane7_v_x => m_data.GetFloat("sim/multiplayer/position/plane7_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane7_v_y => m_data.GetFloat("sim/multiplayer/position/plane7_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane7_v_z => m_data.GetFloat("sim/multiplayer/position/plane7_v_z");

        /// <summary>
        ///  Plane 8 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane8_v_x => m_data.GetFloat("sim/multiplayer/position/plane8_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane8_v_y => m_data.GetFloat("sim/multiplayer/position/plane8_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane8_v_z => m_data.GetFloat("sim/multiplayer/position/plane8_v_z");

        /// <summary>
        ///  Plane 9 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane9_v_x => m_data.GetFloat("sim/multiplayer/position/plane9_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane9_v_y => m_data.GetFloat("sim/multiplayer/position/plane9_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane9_v_z => m_data.GetFloat("sim/multiplayer/position/plane9_v_z");

        /// <summary>
        ///  Plane 1 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane1_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_beacon_lights_on");

        /// <summary>
        ///  Plane 1 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane1_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_landing_lights_on");

        /// <summary>
        ///  Plane 1 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane1_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_nav_lights_on");

        /// <summary>
        ///  Plane 1 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane1_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_strobe_lights_on");

        /// <summary>
        ///  Plane 1 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane1_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane1_taxi_light_on");

        /// <summary>
        ///  Plane 2 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane2_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_beacon_lights_on");

        /// <summary>
        ///  Plane 2 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane2_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_landing_lights_on");

        /// <summary>
        ///  Plane 2 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane2_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_nav_lights_on");

        /// <summary>
        ///  Plane 2 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane2_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_strobe_lights_on");

        /// <summary>
        ///  Plane 2 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane2_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane2_taxi_light_on");

        /// <summary>
        ///  Plane 3 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane3_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_beacon_lights_on");

        /// <summary>
        ///  Plane 3 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane3_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_landing_lights_on");

        /// <summary>
        ///  Plane 3 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane3_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_nav_lights_on");

        /// <summary>
        ///  Plane 3 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane3_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_strobe_lights_on");

        /// <summary>
        ///  Plane 3 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane3_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane3_taxi_light_on");

        /// <summary>
        ///  Plane 4 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane4_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_beacon_lights_on");

        /// <summary>
        ///  Plane 4 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane4_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_landing_lights_on");

        /// <summary>
        ///  Plane 4 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane4_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_nav_lights_on");

        /// <summary>
        ///  Plane 4 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane4_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_strobe_lights_on");

        /// <summary>
        ///  Plane 4 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane4_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane4_taxi_light_on");

        /// <summary>
        ///  Plane 5 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane5_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_beacon_lights_on");

        /// <summary>
        ///  Plane 5 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane5_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_landing_lights_on");

        /// <summary>
        ///  Plane 5 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane5_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_nav_lights_on");

        /// <summary>
        ///  Plane 5 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane5_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_strobe_lights_on");

        /// <summary>
        ///  Plane 5 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane5_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane5_taxi_light_on");

        /// <summary>
        ///  Plane 6 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane6_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_beacon_lights_on");

        /// <summary>
        ///  Plane 6 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane6_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_landing_lights_on");

        /// <summary>
        ///  Plane 6 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane6_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_nav_lights_on");

        /// <summary>
        ///  Plane 6 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane6_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_strobe_lights_on");

        /// <summary>
        ///  Plane 6 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane6_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane6_taxi_light_on");

        /// <summary>
        ///  Plane 7 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane7_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_beacon_lights_on");

        /// <summary>
        ///  Plane 7 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane7_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_landing_lights_on");

        /// <summary>
        ///  Plane 7 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane7_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_nav_lights_on");

        /// <summary>
        ///  Plane 7 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane7_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_strobe_lights_on");

        /// <summary>
        ///  Plane 7 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane7_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane7_taxi_light_on");

        /// <summary>
        ///  Plane 8 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane8_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_beacon_lights_on");

        /// <summary>
        ///  Plane 8 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane8_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_landing_lights_on");

        /// <summary>
        ///  Plane 8 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane8_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_nav_lights_on");

        /// <summary>
        ///  Plane 8 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane8_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_strobe_lights_on");

        /// <summary>
        ///  Plane 8 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane8_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane8_taxi_light_on");

        /// <summary>
        ///  Plane 9 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane9_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_beacon_lights_on");

        /// <summary>
        ///  Plane 9 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane9_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_landing_lights_on");

        /// <summary>
        ///  Plane 9 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane9_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_nav_lights_on");

        /// <summary>
        ///  Plane 9 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane9_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_strobe_lights_on");

        /// <summary>
        ///  Plane 9 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane9_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane9_taxi_light_on");

        /// <summary>
        ///  Plane 10 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane10_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_beacon_lights_on");

        /// <summary>
        ///  Plane 10 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane10_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_landing_lights_on");

        /// <summary>
        ///  Plane 10 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane10_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_nav_lights_on");

        /// <summary>
        ///  Plane 10 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane10_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_strobe_lights_on");

        /// <summary>
        ///  Plane 10 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane10_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane10_taxi_light_on");

        /// <summary>
        ///  Plane 11 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane11_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_beacon_lights_on");

        /// <summary>
        ///  Plane 11 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane11_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_landing_lights_on");

        /// <summary>
        ///  Plane 11 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane11_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_nav_lights_on");

        /// <summary>
        ///  Plane 11 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane11_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_strobe_lights_on");

        /// <summary>
        ///  Plane 11 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane11_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane11_taxi_light_on");

        /// <summary>
        ///  Plane 12 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane12_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_beacon_lights_on");

        /// <summary>
        ///  Plane 12 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane12_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_landing_lights_on");

        /// <summary>
        ///  Plane 12 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane12_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_nav_lights_on");

        /// <summary>
        ///  Plane 12 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane12_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_strobe_lights_on");

        /// <summary>
        ///  Plane 12 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane12_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane12_taxi_light_on");

        /// <summary>
        ///  Plane 13 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane13_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_beacon_lights_on");

        /// <summary>
        ///  Plane 13 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane13_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_landing_lights_on");

        /// <summary>
        ///  Plane 13 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane13_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_nav_lights_on");

        /// <summary>
        ///  Plane 13 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane13_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_strobe_lights_on");

        /// <summary>
        ///  Plane 13 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane13_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane13_taxi_light_on");

        /// <summary>
        ///  Plane 14 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane14_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_beacon_lights_on");

        /// <summary>
        ///  Plane 14 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane14_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_landing_lights_on");

        /// <summary>
        ///  Plane 14 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane14_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_nav_lights_on");

        /// <summary>
        ///  Plane 14 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane14_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_strobe_lights_on");

        /// <summary>
        ///  Plane 14 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane14_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane14_taxi_light_on");

        /// <summary>
        ///  Plane 15 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane15_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_beacon_lights_on");

        /// <summary>
        ///  Plane 15 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane15_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_landing_lights_on");

        /// <summary>
        ///  Plane 15 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane15_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_nav_lights_on");

        /// <summary>
        ///  Plane 15 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane15_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_strobe_lights_on");

        /// <summary>
        ///  Plane 15 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane15_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane15_taxi_light_on");

        /// <summary>
        ///  Plane 16 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane16_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_beacon_lights_on");

        /// <summary>
        ///  Plane 16 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane16_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_landing_lights_on");

        /// <summary>
        ///  Plane 16 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane16_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_nav_lights_on");

        /// <summary>
        ///  Plane 16 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane16_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_strobe_lights_on");

        /// <summary>
        ///  Plane 16 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane16_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane16_taxi_light_on");

        /// <summary>
        ///  Plane 17 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane17_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_beacon_lights_on");

        /// <summary>
        ///  Plane 17 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane17_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_landing_lights_on");

        /// <summary>
        ///  Plane 17 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane17_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_nav_lights_on");

        /// <summary>
        ///  Plane 17 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane17_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_strobe_lights_on");

        /// <summary>
        ///  Plane 17 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane17_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane17_taxi_light_on");

        /// <summary>
        ///  Plane 18 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane18_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_beacon_lights_on");

        /// <summary>
        ///  Plane 18 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane18_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_landing_lights_on");

        /// <summary>
        ///  Plane 18 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane18_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_nav_lights_on");

        /// <summary>
        ///  Plane 18 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane18_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_strobe_lights_on");

        /// <summary>
        ///  Plane 18 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane18_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane18_taxi_light_on");

        /// <summary>
        ///  Plane 19 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane19_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_beacon_lights_on");

        /// <summary>
        ///  Plane 19 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane19_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_landing_lights_on");

        /// <summary>
        ///  Plane 19 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane19_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_nav_lights_on");

        /// <summary>
        ///  Plane 19 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane19_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_strobe_lights_on");

        /// <summary>
        ///  Plane 19 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane19_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane19_taxi_light_on");

        /// <summary>
        ///  Plane 10 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane10_the => m_data.GetFloat("sim/multiplayer/position/plane10_the");

        /// <summary>
        ///  Plane 10 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane10_phi => m_data.GetFloat("sim/multiplayer/position/plane10_phi");

        /// <summary>
        ///  Plane 10 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane10_psi => m_data.GetFloat("sim/multiplayer/position/plane10_psi");

        /// <summary>
        ///  Plane 10 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane10_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane10_gear_deploy");

        /// <summary>
        ///  Plane 10 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane10_flap_ratio");

        /// <summary>
        ///  Plane 10 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane10_flap_ratio2");

        /// <summary>
        ///  Plane 10 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane10_spoiler_ratio");

        /// <summary>
        ///  Plane 10 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane10_speedbrake_ratio");

        /// <summary>
        ///  Plane 10 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane10_sla1_ratio");

        /// <summary>
        ///  Plane 10 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane10_wing_sweep");

        /// <summary>
        ///  Plane 10 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane10_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane10_throttle");

        /// <summary>
        ///  Plane 10 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane10_yolk_pitch");

        /// <summary>
        ///  Plane 10 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane10_yolk_roll");

        /// <summary>
        ///  Plane 10 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane10_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane10_yolk_yaw");

        /// <summary>
        ///  Plane 10 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane10_v_x => m_data.GetFloat("sim/multiplayer/position/plane10_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane10_v_y => m_data.GetFloat("sim/multiplayer/position/plane10_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane10_v_z => m_data.GetFloat("sim/multiplayer/position/plane10_v_z");

        /// <summary>
        ///  Plane 11 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane11_the => m_data.GetFloat("sim/multiplayer/position/plane11_the");

        /// <summary>
        ///  Plane 11 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane11_phi => m_data.GetFloat("sim/multiplayer/position/plane11_phi");

        /// <summary>
        ///  Plane 11 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane11_psi => m_data.GetFloat("sim/multiplayer/position/plane11_psi");

        /// <summary>
        ///  Plane 11 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane11_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane11_gear_deploy");

        /// <summary>
        ///  Plane 11 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane11_flap_ratio");

        /// <summary>
        ///  Plane 11 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane11_flap_ratio2");

        /// <summary>
        ///  Plane 11 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane11_spoiler_ratio");

        /// <summary>
        ///  Plane 11 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane11_speedbrake_ratio");

        /// <summary>
        ///  Plane 11 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane11_sla1_ratio");

        /// <summary>
        ///  Plane 11 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane11_wing_sweep");

        /// <summary>
        ///  Plane 11 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane11_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane11_throttle");

        /// <summary>
        ///  Plane 11 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane11_yolk_pitch");

        /// <summary>
        ///  Plane 11 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane11_yolk_roll");

        /// <summary>
        ///  Plane 11 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane11_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane11_yolk_yaw");

        /// <summary>
        ///  Plane 11 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane11_v_x => m_data.GetFloat("sim/multiplayer/position/plane11_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane11_v_y => m_data.GetFloat("sim/multiplayer/position/plane11_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane11_v_z => m_data.GetFloat("sim/multiplayer/position/plane11_v_z");

        /// <summary>
        ///  Plane 12 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane12_the => m_data.GetFloat("sim/multiplayer/position/plane12_the");

        /// <summary>
        ///  Plane 12 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane12_phi => m_data.GetFloat("sim/multiplayer/position/plane12_phi");

        /// <summary>
        ///  Plane 12 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane12_psi => m_data.GetFloat("sim/multiplayer/position/plane12_psi");

        /// <summary>
        ///  Plane 12 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane12_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane12_gear_deploy");

        /// <summary>
        ///  Plane 12 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane12_flap_ratio");

        /// <summary>
        ///  Plane 12 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane12_flap_ratio2");

        /// <summary>
        ///  Plane 12 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane12_spoiler_ratio");

        /// <summary>
        ///  Plane 12 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane12_speedbrake_ratio");

        /// <summary>
        ///  Plane 12 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane12_sla1_ratio");

        /// <summary>
        ///  Plane 12 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane12_wing_sweep");

        /// <summary>
        ///  Plane 12 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane12_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane12_throttle");

        /// <summary>
        ///  Plane 12 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane12_yolk_pitch");

        /// <summary>
        ///  Plane 12 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane12_yolk_roll");

        /// <summary>
        ///  Plane 12 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane12_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane12_yolk_yaw");

        /// <summary>
        ///  Plane 12 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane12_v_x => m_data.GetFloat("sim/multiplayer/position/plane12_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane12_v_y => m_data.GetFloat("sim/multiplayer/position/plane12_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane12_v_z => m_data.GetFloat("sim/multiplayer/position/plane12_v_z");

        /// <summary>
        ///  Plane 13 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane13_the => m_data.GetFloat("sim/multiplayer/position/plane13_the");

        /// <summary>
        ///  Plane 13 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane13_phi => m_data.GetFloat("sim/multiplayer/position/plane13_phi");

        /// <summary>
        ///  Plane 13 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane13_psi => m_data.GetFloat("sim/multiplayer/position/plane13_psi");

        /// <summary>
        ///  Plane 13 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane13_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane13_gear_deploy");

        /// <summary>
        ///  Plane 13 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane13_flap_ratio");

        /// <summary>
        ///  Plane 13 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane13_flap_ratio2");

        /// <summary>
        ///  Plane 13 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane13_spoiler_ratio");

        /// <summary>
        ///  Plane 13 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane13_speedbrake_ratio");

        /// <summary>
        ///  Plane 13 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane13_sla1_ratio");

        /// <summary>
        ///  Plane 13 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane13_wing_sweep");

        /// <summary>
        ///  Plane 13 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane13_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane13_throttle");

        /// <summary>
        ///  Plane 13 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane13_yolk_pitch");

        /// <summary>
        ///  Plane 13 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane13_yolk_roll");

        /// <summary>
        ///  Plane 13 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane13_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane13_yolk_yaw");

        /// <summary>
        ///  Plane 13 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane13_v_x => m_data.GetFloat("sim/multiplayer/position/plane13_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane13_v_y => m_data.GetFloat("sim/multiplayer/position/plane13_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane13_v_z => m_data.GetFloat("sim/multiplayer/position/plane13_v_z");

        /// <summary>
        ///  Plane 14 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane14_the => m_data.GetFloat("sim/multiplayer/position/plane14_the");

        /// <summary>
        ///  Plane 14 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane14_phi => m_data.GetFloat("sim/multiplayer/position/plane14_phi");

        /// <summary>
        ///  Plane 14 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane14_psi => m_data.GetFloat("sim/multiplayer/position/plane14_psi");

        /// <summary>
        ///  Plane 14 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane14_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane14_gear_deploy");

        /// <summary>
        ///  Plane 14 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane14_flap_ratio");

        /// <summary>
        ///  Plane 14 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane14_flap_ratio2");

        /// <summary>
        ///  Plane 14 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane14_spoiler_ratio");

        /// <summary>
        ///  Plane 14 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane14_speedbrake_ratio");

        /// <summary>
        ///  Plane 14 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane14_sla1_ratio");

        /// <summary>
        ///  Plane 14 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane14_wing_sweep");

        /// <summary>
        ///  Plane 14 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane14_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane14_throttle");

        /// <summary>
        ///  Plane 14 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane14_yolk_pitch");

        /// <summary>
        ///  Plane 14 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane14_yolk_roll");

        /// <summary>
        ///  Plane 14 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane14_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane14_yolk_yaw");

        /// <summary>
        ///  Plane 14 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane14_v_x => m_data.GetFloat("sim/multiplayer/position/plane14_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane14_v_y => m_data.GetFloat("sim/multiplayer/position/plane14_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane14_v_z => m_data.GetFloat("sim/multiplayer/position/plane14_v_z");

        /// <summary>
        ///  Plane 15 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane15_the => m_data.GetFloat("sim/multiplayer/position/plane15_the");

        /// <summary>
        ///  Plane 15 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane15_phi => m_data.GetFloat("sim/multiplayer/position/plane15_phi");

        /// <summary>
        ///  Plane 15 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane15_psi => m_data.GetFloat("sim/multiplayer/position/plane15_psi");

        /// <summary>
        ///  Plane 15 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane15_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane15_gear_deploy");

        /// <summary>
        ///  Plane 15 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane15_flap_ratio");

        /// <summary>
        ///  Plane 15 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane15_flap_ratio2");

        /// <summary>
        ///  Plane 15 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane15_spoiler_ratio");

        /// <summary>
        ///  Plane 15 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane15_speedbrake_ratio");

        /// <summary>
        ///  Plane 15 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane15_sla1_ratio");

        /// <summary>
        ///  Plane 15 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane15_wing_sweep");

        /// <summary>
        ///  Plane 15 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane15_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane15_throttle");

        /// <summary>
        ///  Plane 15 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane15_yolk_pitch");

        /// <summary>
        ///  Plane 15 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane15_yolk_roll");

        /// <summary>
        ///  Plane 15 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane15_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane15_yolk_yaw");

        /// <summary>
        ///  Plane 15 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane15_v_x => m_data.GetFloat("sim/multiplayer/position/plane15_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane15_v_y => m_data.GetFloat("sim/multiplayer/position/plane15_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane15_v_z => m_data.GetFloat("sim/multiplayer/position/plane15_v_z");

        /// <summary>
        ///  Plane 16 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane16_the => m_data.GetFloat("sim/multiplayer/position/plane16_the");

        /// <summary>
        ///  Plane 16 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane16_phi => m_data.GetFloat("sim/multiplayer/position/plane16_phi");

        /// <summary>
        ///  Plane 16 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane16_psi => m_data.GetFloat("sim/multiplayer/position/plane16_psi");

        /// <summary>
        ///  Plane 16 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane16_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane16_gear_deploy");

        /// <summary>
        ///  Plane 16 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane16_flap_ratio");

        /// <summary>
        ///  Plane 16 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane16_flap_ratio2");

        /// <summary>
        ///  Plane 16 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane16_spoiler_ratio");

        /// <summary>
        ///  Plane 16 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane16_speedbrake_ratio");

        /// <summary>
        ///  Plane 16 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane16_sla1_ratio");

        /// <summary>
        ///  Plane 16 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane16_wing_sweep");

        /// <summary>
        ///  Plane 16 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane16_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane16_throttle");

        /// <summary>
        ///  Plane 16 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane16_yolk_pitch");

        /// <summary>
        ///  Plane 16 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane16_yolk_roll");

        /// <summary>
        ///  Plane 16 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane16_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane16_yolk_yaw");

        /// <summary>
        ///  Plane 16 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane16_v_x => m_data.GetFloat("sim/multiplayer/position/plane16_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane16_v_y => m_data.GetFloat("sim/multiplayer/position/plane16_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane16_v_z => m_data.GetFloat("sim/multiplayer/position/plane16_v_z");

        /// <summary>
        ///  Plane 17 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane17_the => m_data.GetFloat("sim/multiplayer/position/plane17_the");

        /// <summary>
        ///  Plane 17 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane17_phi => m_data.GetFloat("sim/multiplayer/position/plane17_phi");

        /// <summary>
        ///  Plane 17 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane17_psi => m_data.GetFloat("sim/multiplayer/position/plane17_psi");

        /// <summary>
        ///  Plane 17 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane17_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane17_gear_deploy");

        /// <summary>
        ///  Plane 17 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane17_flap_ratio");

        /// <summary>
        ///  Plane 17 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane17_flap_ratio2");

        /// <summary>
        ///  Plane 17 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane17_spoiler_ratio");

        /// <summary>
        ///  Plane 17 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane17_speedbrake_ratio");

        /// <summary>
        ///  Plane 17 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane17_sla1_ratio");

        /// <summary>
        ///  Plane 17 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane17_wing_sweep");

        /// <summary>
        ///  Plane 17 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane17_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane17_throttle");

        /// <summary>
        ///  Plane 17 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane17_yolk_pitch");

        /// <summary>
        ///  Plane 17 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane17_yolk_roll");

        /// <summary>
        ///  Plane 17 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane17_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane17_yolk_yaw");

        /// <summary>
        ///  Plane 17 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane17_v_x => m_data.GetFloat("sim/multiplayer/position/plane17_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane17_v_y => m_data.GetFloat("sim/multiplayer/position/plane17_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane17_v_z => m_data.GetFloat("sim/multiplayer/position/plane17_v_z");

        /// <summary>
        ///  Plane 18 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane18_the => m_data.GetFloat("sim/multiplayer/position/plane18_the");

        /// <summary>
        ///  Plane 18 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane18_phi => m_data.GetFloat("sim/multiplayer/position/plane18_phi");

        /// <summary>
        ///  Plane 18 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane18_psi => m_data.GetFloat("sim/multiplayer/position/plane18_psi");

        /// <summary>
        ///  Plane 18 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane18_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane18_gear_deploy");

        /// <summary>
        ///  Plane 18 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane18_flap_ratio");

        /// <summary>
        ///  Plane 18 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane18_flap_ratio2");

        /// <summary>
        ///  Plane 18 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane18_spoiler_ratio");

        /// <summary>
        ///  Plane 18 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane18_speedbrake_ratio");

        /// <summary>
        ///  Plane 18 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane18_sla1_ratio");

        /// <summary>
        ///  Plane 18 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane18_wing_sweep");

        /// <summary>
        ///  Plane 18 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane18_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane18_throttle");

        /// <summary>
        ///  Plane 18 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane18_yolk_pitch");

        /// <summary>
        ///  Plane 18 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane18_yolk_roll");

        /// <summary>
        ///  Plane 18 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane18_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane18_yolk_yaw");

        /// <summary>
        ///  Plane 18 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane18_v_x => m_data.GetFloat("sim/multiplayer/position/plane18_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane18_v_y => m_data.GetFloat("sim/multiplayer/position/plane18_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane18_v_z => m_data.GetFloat("sim/multiplayer/position/plane18_v_z");

        /// <summary>
        ///  Plane 19 theta (pitch). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane19_the => m_data.GetFloat("sim/multiplayer/position/plane19_the");

        /// <summary>
        ///  Plane 19 phi (roll). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane19_phi => m_data.GetFloat("sim/multiplayer/position/plane19_phi");

        /// <summary>
        ///  Plane 19 psi (heading). Units:degrees
        /// </summary>
        public IXPDataRef<float> Plane19_psi => m_data.GetFloat("sim/multiplayer/position/plane19_psi");

        /// <summary>
        ///  Plane 19 gear deployment for 6 gear. 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane19_gear_deploy => m_data.GetFloatArray("sim/multiplayer/position/plane19_gear_deploy");

        /// <summary>
        ///  Plane 19 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_flap_ratio => m_data.GetFloat("sim/multiplayer/position/plane19_flap_ratio");

        /// <summary>
        ///  Plane 19 flap lowering 0 = clean, 1 = max flaps. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_flap_ratio2 => m_data.GetFloat("sim/multiplayer/position/plane19_flap_ratio2");

        /// <summary>
        ///  Plane 19 spoiler ratio (0 = clean, 1 = max spoilers). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_spoiler_ratio => m_data.GetFloat("sim/multiplayer/position/plane19_spoiler_ratio");

        /// <summary>
        ///  Plane 19 speed brake ratio (0 = clean, 1 = max speed brakes). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_speedbrake_ratio => m_data.GetFloat("sim/multiplayer/position/plane19_speedbrake_ratio");

        /// <summary>
        ///  Plane 19 slat deployment ratio 0 = clean, 1 = max slats. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_sla1_ratio => m_data.GetFloat("sim/multiplayer/position/plane19_sla1_ratio");

        /// <summary>
        ///  Plane 19 wing sweep, 0 = normal, 1 = most sweep. Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_wing_sweep => m_data.GetFloat("sim/multiplayer/position/plane19_wing_sweep");

        /// <summary>
        ///  Plane 19 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse). Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Plane19_throttle => m_data.GetFloatArray("sim/multiplayer/position/plane19_throttle");

        /// <summary>
        ///  Plane 19 Commanded pitch (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_pitch_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_yolk_pitch => m_data.GetFloat("sim/multiplayer/position/plane19_yolk_pitch");

        /// <summary>
        ///  Plane 19 Commanded roll (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_roll_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_yolk_roll => m_data.GetFloat("sim/multiplayer/position/plane19_yolk_roll");

        /// <summary>
        ///  Plane 19 Commanded yaw (Legacy for compatibility - use sim/Multiplayer/Controls/Yoke_heading_ratio). Units:ratio
        /// </summary>
        public IXPDataRef<float> Plane19_yolk_yaw => m_data.GetFloat("sim/multiplayer/position/plane19_yolk_yaw");

        /// <summary>
        ///  Plane 19 cartesian velocities.  These may not be accurate if another plugin. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane19_v_x => m_data.GetFloat("sim/multiplayer/position/plane19_v_x");

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane19_v_y => m_data.GetFloat("sim/multiplayer/position/plane19_v_y");

        /// <summary>
        ///  manipulate the plane.. Units:m/S
        /// </summary>
        public IXPDataRef<float> Plane19_v_z => m_data.GetFloat("sim/multiplayer/position/plane19_v_z");
    }
}