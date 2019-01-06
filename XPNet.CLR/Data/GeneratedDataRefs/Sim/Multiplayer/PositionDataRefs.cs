using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_multiplayer_positionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_multiplayer_positionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Plane 1 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane1_the { get { return m_data.GetFloat("sim/multiplayer/position/plane1_the");} }

        /// <summary>
        ///  Plane 1 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane1_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane1_phi");} }

        /// <summary>
        ///  Plane 1 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane1_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane1_psi");} }

        /// <summary>
        ///  Plane 1 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane1_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane1_gear_deploy");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane1_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane1_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane1_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane1_flap_ratio2");} }

        /// <summary>
        ///  Plane 1 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane1_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane1_spoiler_ratio");} }

        /// <summary>
        ///  Plane 1 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane1_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane1_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 1 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane1_slat_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane1_slat_ratio");} }

        /// <summary>
        ///  Plane 1 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane1_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane1_wing_sweep");} }

        /// <summary>
        ///  Plane 1 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane1_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane1_throttle");} }

        /// <summary>
        ///  Plane 1 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane1_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane1_yolk_pitch");} }

        /// <summary>
        ///  Plane 1 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane1_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane1_yolk_roll");} }

        /// <summary>
        ///  Plane 1 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane1_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane1_yolk_yaw");} }

        /// <summary>
        ///  Plane 2 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane2_the { get { return m_data.GetFloat("sim/multiplayer/position/plane2_the");} }

        /// <summary>
        ///  Plane 2 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane2_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane2_phi");} }

        /// <summary>
        ///  Plane 2 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane2_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane2_psi");} }

        /// <summary>
        ///  Plane 2 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane2_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane2_gear_deploy");} }

        /// <summary>
        ///  Plane 2 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane2_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane2_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane2_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane2_flap_ratio2");} }

        /// <summary>
        ///  Plane 2 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane2_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane2_spoiler_ratio");} }

        /// <summary>
        ///  Plane 2 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane2_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane2_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 2 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane2_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane2_sla1_ratio");} }

        /// <summary>
        ///  Plane 2 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane2_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane2_wing_sweep");} }

        /// <summary>
        ///  Plane 2 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane2_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane2_throttle");} }

        /// <summary>
        ///  Plane 2 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane2_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane2_yolk_pitch");} }

        /// <summary>
        ///  Plane 2 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane2_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane2_yolk_roll");} }

        /// <summary>
        ///  Plane 2 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane2_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane2_yolk_yaw");} }

        /// <summary>
        ///  Plane 3 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane3_the { get { return m_data.GetFloat("sim/multiplayer/position/plane3_the");} }

        /// <summary>
        ///  Plane 3 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane3_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane3_phi");} }

        /// <summary>
        ///  Plane 3 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane3_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane3_psi");} }

        /// <summary>
        ///  Plane 3 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane3_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane3_gear_deploy");} }

        /// <summary>
        ///  Plane 3 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane3_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane3_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane3_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane3_flap_ratio2");} }

        /// <summary>
        ///  Plane 3 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane3_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane3_spoiler_ratio");} }

        /// <summary>
        ///  Plane 3 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane3_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane3_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 3 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane3_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane3_sla1_ratio");} }

        /// <summary>
        ///  Plane 3 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane3_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane3_wing_sweep");} }

        /// <summary>
        ///  Plane 3 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane3_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane3_throttle");} }

        /// <summary>
        ///  Plane 3 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane3_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane3_yolk_pitch");} }

        /// <summary>
        ///  Plane 3 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane3_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane3_yolk_roll");} }

        /// <summary>
        ///  Plane 3 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane3_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane3_yolk_yaw");} }

        /// <summary>
        ///  Plane 4 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane4_the { get { return m_data.GetFloat("sim/multiplayer/position/plane4_the");} }

        /// <summary>
        ///  Plane 4 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane4_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane4_phi");} }

        /// <summary>
        ///  Plane 4 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane4_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane4_psi");} }

        /// <summary>
        ///  Plane 4 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane4_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane4_gear_deploy");} }

        /// <summary>
        ///  Plane 4 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane4_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane4_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane4_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane4_flap_ratio2");} }

        /// <summary>
        ///  Plane 4 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane4_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane4_spoiler_ratio");} }

        /// <summary>
        ///  Plane 4 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane4_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane4_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 4 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane4_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane4_sla1_ratio");} }

        /// <summary>
        ///  Plane 4 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane4_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane4_wing_sweep");} }

        /// <summary>
        ///  Plane 4 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane4_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane4_throttle");} }

        /// <summary>
        ///  Plane 4 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane4_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane4_yolk_pitch");} }

        /// <summary>
        ///  Plane 4 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane4_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane4_yolk_roll");} }

        /// <summary>
        ///  Plane 4 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane4_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane4_yolk_yaw");} }

        /// <summary>
        ///  Plane 5 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane5_the { get { return m_data.GetFloat("sim/multiplayer/position/plane5_the");} }

        /// <summary>
        ///  Plane 5 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane5_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane5_phi");} }

        /// <summary>
        ///  Plane 5 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane5_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane5_psi");} }

        /// <summary>
        ///  Plane 5 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane5_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane5_gear_deploy");} }

        /// <summary>
        ///  Plane 5 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane5_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane5_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane5_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane5_flap_ratio2");} }

        /// <summary>
        ///  Plane 5 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane5_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane5_spoiler_ratio");} }

        /// <summary>
        ///  Plane 5 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane5_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane5_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 5 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane5_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane5_sla1_ratio");} }

        /// <summary>
        ///  Plane 5 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane5_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane5_wing_sweep");} }

        /// <summary>
        ///  Plane 5 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane5_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane5_throttle");} }

        /// <summary>
        ///  Plane 5 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane5_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane5_yolk_pitch");} }

        /// <summary>
        ///  Plane 5 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane5_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane5_yolk_roll");} }

        /// <summary>
        ///  Plane 5 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane5_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane5_yolk_yaw");} }

        /// <summary>
        ///  Plane 6 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane6_the { get { return m_data.GetFloat("sim/multiplayer/position/plane6_the");} }

        /// <summary>
        ///  Plane 6 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane6_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane6_phi");} }

        /// <summary>
        ///  Plane 6 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane6_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane6_psi");} }

        /// <summary>
        ///  Plane 6 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane6_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane6_gear_deploy");} }

        /// <summary>
        ///  Plane 6 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane6_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane6_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane6_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane6_flap_ratio2");} }

        /// <summary>
        ///  Plane 6 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane6_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane6_spoiler_ratio");} }

        /// <summary>
        ///  Plane 6 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane6_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane6_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 6 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane6_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane6_sla1_ratio");} }

        /// <summary>
        ///  Plane 6 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane6_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane6_wing_sweep");} }

        /// <summary>
        ///  Plane 6 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane6_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane6_throttle");} }

        /// <summary>
        ///  Plane 6 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane6_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane6_yolk_pitch");} }

        /// <summary>
        ///  Plane 6 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane6_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane6_yolk_roll");} }

        /// <summary>
        ///  Plane 6 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane6_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane6_yolk_yaw");} }

        /// <summary>
        ///  Plane 7 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane7_the { get { return m_data.GetFloat("sim/multiplayer/position/plane7_the");} }

        /// <summary>
        ///  Plane 7 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane7_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane7_phi");} }

        /// <summary>
        ///  Plane 7 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane7_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane7_psi");} }

        /// <summary>
        ///  Plane 7 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane7_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane7_gear_deploy");} }

        /// <summary>
        ///  Plane 7 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane7_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane7_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane7_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane7_flap_ratio2");} }

        /// <summary>
        ///  Plane 7 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane7_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane7_spoiler_ratio");} }

        /// <summary>
        ///  Plane 7 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane7_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane7_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 7 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane7_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane7_sla1_ratio");} }

        /// <summary>
        ///  Plane 7 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane7_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane7_wing_sweep");} }

        /// <summary>
        ///  Plane 7 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane7_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane7_throttle");} }

        /// <summary>
        ///  Plane 7 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane7_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane7_yolk_pitch");} }

        /// <summary>
        ///  Plane 7 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane7_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane7_yolk_roll");} }

        /// <summary>
        ///  Plane 7 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane7_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane7_yolk_yaw");} }

        /// <summary>
        ///  Plane 8 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane8_the { get { return m_data.GetFloat("sim/multiplayer/position/plane8_the");} }

        /// <summary>
        ///  Plane 8 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane8_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane8_phi");} }

        /// <summary>
        ///  Plane 8 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane8_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane8_psi");} }

        /// <summary>
        ///  Plane 8 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane8_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane8_gear_deploy");} }

        /// <summary>
        ///  Plane 8 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane8_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane8_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane8_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane8_flap_ratio2");} }

        /// <summary>
        ///  Plane 8 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane8_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane8_spoiler_ratio");} }

        /// <summary>
        ///  Plane 8 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane8_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane8_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 8 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane8_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane8_sla1_ratio");} }

        /// <summary>
        ///  Plane 8 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane8_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane8_wing_sweep");} }

        /// <summary>
        ///  Plane 8 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane8_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane8_throttle");} }

        /// <summary>
        ///  Plane 8 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane8_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane8_yolk_pitch");} }

        /// <summary>
        ///  Plane 8 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane8_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane8_yolk_roll");} }

        /// <summary>
        ///  Plane 8 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane8_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane8_yolk_yaw");} }

        /// <summary>
        ///  Plane 9 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane9_the { get { return m_data.GetFloat("sim/multiplayer/position/plane9_the");} }

        /// <summary>
        ///  Plane 9 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane9_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane9_phi");} }

        /// <summary>
        ///  Plane 9 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane9_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane9_psi");} }

        /// <summary>
        ///  Plane 9 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane9_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane9_gear_deploy");} }

        /// <summary>
        ///  Plane 9 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane9_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane9_flap_ratio");} }

        /// <summary>
        ///  Plane 1 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane9_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane9_flap_ratio2");} }

        /// <summary>
        ///  Plane 9 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane9_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane9_spoiler_ratio");} }

        /// <summary>
        ///  Plane 9 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane9_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane9_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 9 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane9_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane9_sla1_ratio");} }

        /// <summary>
        ///  Plane 9 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane9_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane9_wing_sweep");} }

        /// <summary>
        ///  Plane 9 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane9_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane9_throttle");} }

        /// <summary>
        ///  Plane 9 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane9_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane9_yolk_pitch");} }

        /// <summary>
        ///  Plane 9 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane9_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane9_yolk_roll");} }

        /// <summary>
        ///  Plane 9 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane9_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane9_yolk_yaw");} }

        /// <summary>
        ///  Plane 1 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane1_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane1_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane1_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane1_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane1_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane1_v_z");} }

        /// <summary>
        ///  Plane 2 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane2_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane2_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane2_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane2_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane2_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane2_v_z");} }

        /// <summary>
        ///  Plane 3 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane3_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane3_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane3_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane3_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane3_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane3_v_z");} }

        /// <summary>
        ///  Plane 4 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane4_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane4_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane4_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane4_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane4_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane4_v_z");} }

        /// <summary>
        ///  Plane 5 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane5_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane5_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane5_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane5_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane5_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane5_v_z");} }

        /// <summary>
        ///  Plane 6 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane6_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane6_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane6_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane6_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane6_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane6_v_z");} }

        /// <summary>
        ///  Plane 7 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane7_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane7_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane7_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane7_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane7_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane7_v_z");} }

        /// <summary>
        ///  Plane 8 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane8_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane8_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane8_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane8_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane8_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane8_v_z");} }

        /// <summary>
        ///  Plane 9 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane9_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane9_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane9_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane9_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane9_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane9_v_z");} }

        /// <summary>
        ///  Plane 1 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane1_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane1_beacon_lights_on");} }

        /// <summary>
        ///  Plane 1 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane1_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane1_landing_lights_on");} }

        /// <summary>
        ///  Plane 1 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane1_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane1_nav_lights_on");} }

        /// <summary>
        ///  Plane 1 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane1_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane1_strobe_lights_on");} }

        /// <summary>
        ///  Plane 1 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane1_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane1_taxi_light_on");} }

        /// <summary>
        ///  Plane 2 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane2_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane2_beacon_lights_on");} }

        /// <summary>
        ///  Plane 2 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane2_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane2_landing_lights_on");} }

        /// <summary>
        ///  Plane 2 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane2_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane2_nav_lights_on");} }

        /// <summary>
        ///  Plane 2 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane2_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane2_strobe_lights_on");} }

        /// <summary>
        ///  Plane 2 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane2_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane2_taxi_light_on");} }

        /// <summary>
        ///  Plane 3 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane3_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane3_beacon_lights_on");} }

        /// <summary>
        ///  Plane 3 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane3_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane3_landing_lights_on");} }

        /// <summary>
        ///  Plane 3 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane3_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane3_nav_lights_on");} }

        /// <summary>
        ///  Plane 3 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane3_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane3_strobe_lights_on");} }

        /// <summary>
        ///  Plane 3 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane3_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane3_taxi_light_on");} }

        /// <summary>
        ///  Plane 4 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane4_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane4_beacon_lights_on");} }

        /// <summary>
        ///  Plane 4 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane4_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane4_landing_lights_on");} }

        /// <summary>
        ///  Plane 4 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane4_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane4_nav_lights_on");} }

        /// <summary>
        ///  Plane 4 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane4_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane4_strobe_lights_on");} }

        /// <summary>
        ///  Plane 4 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane4_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane4_taxi_light_on");} }

        /// <summary>
        ///  Plane 5 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane5_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane5_beacon_lights_on");} }

        /// <summary>
        ///  Plane 5 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane5_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane5_landing_lights_on");} }

        /// <summary>
        ///  Plane 5 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane5_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane5_nav_lights_on");} }

        /// <summary>
        ///  Plane 5 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane5_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane5_strobe_lights_on");} }

        /// <summary>
        ///  Plane 5 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane5_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane5_taxi_light_on");} }

        /// <summary>
        ///  Plane 6 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane6_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane6_beacon_lights_on");} }

        /// <summary>
        ///  Plane 6 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane6_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane6_landing_lights_on");} }

        /// <summary>
        ///  Plane 6 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane6_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane6_nav_lights_on");} }

        /// <summary>
        ///  Plane 6 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane6_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane6_strobe_lights_on");} }

        /// <summary>
        ///  Plane 6 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane6_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane6_taxi_light_on");} }

        /// <summary>
        ///  Plane 7 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane7_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane7_beacon_lights_on");} }

        /// <summary>
        ///  Plane 7 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane7_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane7_landing_lights_on");} }

        /// <summary>
        ///  Plane 7 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane7_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane7_nav_lights_on");} }

        /// <summary>
        ///  Plane 7 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane7_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane7_strobe_lights_on");} }

        /// <summary>
        ///  Plane 7 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane7_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane7_taxi_light_on");} }

        /// <summary>
        ///  Plane 8 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane8_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane8_beacon_lights_on");} }

        /// <summary>
        ///  Plane 8 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane8_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane8_landing_lights_on");} }

        /// <summary>
        ///  Plane 8 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane8_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane8_nav_lights_on");} }

        /// <summary>
        ///  Plane 8 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane8_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane8_strobe_lights_on");} }

        /// <summary>
        ///  Plane 8 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane8_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane8_taxi_light_on");} }

        /// <summary>
        ///  Plane 9 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane9_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane9_beacon_lights_on");} }

        /// <summary>
        ///  Plane 9 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane9_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane9_landing_lights_on");} }

        /// <summary>
        ///  Plane 9 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane9_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane9_nav_lights_on");} }

        /// <summary>
        ///  Plane 9 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane9_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane9_strobe_lights_on");} }

        /// <summary>
        ///  Plane 9 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane9_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane9_taxi_light_on");} }

        /// <summary>
        ///  Plane 10 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane10_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane10_beacon_lights_on");} }

        /// <summary>
        ///  Plane 10 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane10_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane10_landing_lights_on");} }

        /// <summary>
        ///  Plane 10 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane10_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane10_nav_lights_on");} }

        /// <summary>
        ///  Plane 10 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane10_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane10_strobe_lights_on");} }

        /// <summary>
        ///  Plane 10 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane10_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane10_taxi_light_on");} }

        /// <summary>
        ///  Plane 11 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane11_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane11_beacon_lights_on");} }

        /// <summary>
        ///  Plane 11 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane11_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane11_landing_lights_on");} }

        /// <summary>
        ///  Plane 11 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane11_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane11_nav_lights_on");} }

        /// <summary>
        ///  Plane 11 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane11_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane11_strobe_lights_on");} }

        /// <summary>
        ///  Plane 11 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane11_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane11_taxi_light_on");} }

        /// <summary>
        ///  Plane 12 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane12_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane12_beacon_lights_on");} }

        /// <summary>
        ///  Plane 12 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane12_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane12_landing_lights_on");} }

        /// <summary>
        ///  Plane 12 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane12_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane12_nav_lights_on");} }

        /// <summary>
        ///  Plane 12 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane12_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane12_strobe_lights_on");} }

        /// <summary>
        ///  Plane 12 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane12_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane12_taxi_light_on");} }

        /// <summary>
        ///  Plane 13 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane13_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane13_beacon_lights_on");} }

        /// <summary>
        ///  Plane 13 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane13_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane13_landing_lights_on");} }

        /// <summary>
        ///  Plane 13 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane13_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane13_nav_lights_on");} }

        /// <summary>
        ///  Plane 13 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane13_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane13_strobe_lights_on");} }

        /// <summary>
        ///  Plane 13 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane13_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane13_taxi_light_on");} }

        /// <summary>
        ///  Plane 14 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane14_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane14_beacon_lights_on");} }

        /// <summary>
        ///  Plane 14 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane14_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane14_landing_lights_on");} }

        /// <summary>
        ///  Plane 14 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane14_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane14_nav_lights_on");} }

        /// <summary>
        ///  Plane 14 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane14_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane14_strobe_lights_on");} }

        /// <summary>
        ///  Plane 14 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane14_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane14_taxi_light_on");} }

        /// <summary>
        ///  Plane 15 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane15_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane15_beacon_lights_on");} }

        /// <summary>
        ///  Plane 15 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane15_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane15_landing_lights_on");} }

        /// <summary>
        ///  Plane 15 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane15_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane15_nav_lights_on");} }

        /// <summary>
        ///  Plane 15 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane15_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane15_strobe_lights_on");} }

        /// <summary>
        ///  Plane 15 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane15_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane15_taxi_light_on");} }

        /// <summary>
        ///  Plane 16 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane16_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane16_beacon_lights_on");} }

        /// <summary>
        ///  Plane 16 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane16_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane16_landing_lights_on");} }

        /// <summary>
        ///  Plane 16 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane16_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane16_nav_lights_on");} }

        /// <summary>
        ///  Plane 16 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane16_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane16_strobe_lights_on");} }

        /// <summary>
        ///  Plane 16 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane16_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane16_taxi_light_on");} }

        /// <summary>
        ///  Plane 17 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane17_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane17_beacon_lights_on");} }

        /// <summary>
        ///  Plane 17 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane17_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane17_landing_lights_on");} }

        /// <summary>
        ///  Plane 17 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane17_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane17_nav_lights_on");} }

        /// <summary>
        ///  Plane 17 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane17_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane17_strobe_lights_on");} }

        /// <summary>
        ///  Plane 17 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane17_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane17_taxi_light_on");} }

        /// <summary>
        ///  Plane 18 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane18_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane18_beacon_lights_on");} }

        /// <summary>
        ///  Plane 18 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane18_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane18_landing_lights_on");} }

        /// <summary>
        ///  Plane 18 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane18_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane18_nav_lights_on");} }

        /// <summary>
        ///  Plane 18 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane18_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane18_strobe_lights_on");} }

        /// <summary>
        ///  Plane 18 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane18_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane18_taxi_light_on");} }

        /// <summary>
        ///  Plane 19 Beacon Light
        /// </summary>
        public IXPDataRef<bool> plane19_beacon_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane19_beacon_lights_on");} }

        /// <summary>
        ///  Plane 19 Landing Light
        /// </summary>
        public IXPDataRef<bool> plane19_landing_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane19_landing_lights_on");} }

        /// <summary>
        ///  Plane 19 Navigation Light
        /// </summary>
        public IXPDataRef<bool> plane19_nav_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane19_nav_lights_on");} }

        /// <summary>
        ///  Plane 19 Strobe Light
        /// </summary>
        public IXPDataRef<bool> plane19_strobe_lights_on { get { return m_data.GetBool("sim/multiplayer/position/plane19_strobe_lights_on");} }

        /// <summary>
        ///  Plane 19 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> plane19_taxi_light_on { get { return m_data.GetBool("sim/multiplayer/position/plane19_taxi_light_on");} }

        /// <summary>
        ///  Plane 10 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane10_the { get { return m_data.GetFloat("sim/multiplayer/position/plane10_the");} }

        /// <summary>
        ///  Plane 10 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane10_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane10_phi");} }

        /// <summary>
        ///  Plane 10 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane10_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane10_psi");} }

        /// <summary>
        ///  Plane 10 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane10_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane10_gear_deploy");} }

        /// <summary>
        ///  Plane 10 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane10_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane10_flap_ratio");} }

        /// <summary>
        ///  Plane 10 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane10_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane10_flap_ratio2");} }

        /// <summary>
        ///  Plane 10 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane10_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane10_spoiler_ratio");} }

        /// <summary>
        ///  Plane 10 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane10_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane10_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 10 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane10_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane10_sla1_ratio");} }

        /// <summary>
        ///  Plane 10 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane10_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane10_wing_sweep");} }

        /// <summary>
        ///  Plane 10 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane10_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane10_throttle");} }

        /// <summary>
        ///  Plane 10 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane10_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane10_yolk_pitch");} }

        /// <summary>
        ///  Plane 10 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane10_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane10_yolk_roll");} }

        /// <summary>
        ///  Plane 10 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane10_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane10_yolk_yaw");} }

        /// <summary>
        ///  Plane 10 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane10_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane10_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane10_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane10_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane10_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane10_v_z");} }

        /// <summary>
        ///  Plane 11 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane11_the { get { return m_data.GetFloat("sim/multiplayer/position/plane11_the");} }

        /// <summary>
        ///  Plane 11 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane11_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane11_phi");} }

        /// <summary>
        ///  Plane 11 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane11_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane11_psi");} }

        /// <summary>
        ///  Plane 11 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane11_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane11_gear_deploy");} }

        /// <summary>
        ///  Plane 11 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane11_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane11_flap_ratio");} }

        /// <summary>
        ///  Plane 11 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane11_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane11_flap_ratio2");} }

        /// <summary>
        ///  Plane 11 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane11_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane11_spoiler_ratio");} }

        /// <summary>
        ///  Plane 11 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane11_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane11_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 11 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane11_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane11_sla1_ratio");} }

        /// <summary>
        ///  Plane 11 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane11_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane11_wing_sweep");} }

        /// <summary>
        ///  Plane 11 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane11_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane11_throttle");} }

        /// <summary>
        ///  Plane 11 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane11_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane11_yolk_pitch");} }

        /// <summary>
        ///  Plane 11 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane11_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane11_yolk_roll");} }

        /// <summary>
        ///  Plane 11 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane11_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane11_yolk_yaw");} }

        /// <summary>
        ///  Plane 11 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane11_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane11_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane11_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane11_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane11_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane11_v_z");} }

        /// <summary>
        ///  Plane 12 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane12_the { get { return m_data.GetFloat("sim/multiplayer/position/plane12_the");} }

        /// <summary>
        ///  Plane 12 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane12_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane12_phi");} }

        /// <summary>
        ///  Plane 12 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane12_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane12_psi");} }

        /// <summary>
        ///  Plane 12 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane12_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane12_gear_deploy");} }

        /// <summary>
        ///  Plane 12 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane12_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane12_flap_ratio");} }

        /// <summary>
        ///  Plane 12 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane12_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane12_flap_ratio2");} }

        /// <summary>
        ///  Plane 12 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane12_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane12_spoiler_ratio");} }

        /// <summary>
        ///  Plane 12 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane12_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane12_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 12 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane12_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane12_sla1_ratio");} }

        /// <summary>
        ///  Plane 12 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane12_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane12_wing_sweep");} }

        /// <summary>
        ///  Plane 12 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane12_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane12_throttle");} }

        /// <summary>
        ///  Plane 12 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane12_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane12_yolk_pitch");} }

        /// <summary>
        ///  Plane 12 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane12_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane12_yolk_roll");} }

        /// <summary>
        ///  Plane 12 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane12_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane12_yolk_yaw");} }

        /// <summary>
        ///  Plane 12 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane12_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane12_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane12_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane12_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane12_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane12_v_z");} }

        /// <summary>
        ///  Plane 13 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane13_the { get { return m_data.GetFloat("sim/multiplayer/position/plane13_the");} }

        /// <summary>
        ///  Plane 13 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane13_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane13_phi");} }

        /// <summary>
        ///  Plane 13 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane13_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane13_psi");} }

        /// <summary>
        ///  Plane 13 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane13_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane13_gear_deploy");} }

        /// <summary>
        ///  Plane 13 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane13_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane13_flap_ratio");} }

        /// <summary>
        ///  Plane 13 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane13_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane13_flap_ratio2");} }

        /// <summary>
        ///  Plane 13 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane13_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane13_spoiler_ratio");} }

        /// <summary>
        ///  Plane 13 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane13_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane13_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 13 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane13_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane13_sla1_ratio");} }

        /// <summary>
        ///  Plane 13 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane13_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane13_wing_sweep");} }

        /// <summary>
        ///  Plane 13 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane13_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane13_throttle");} }

        /// <summary>
        ///  Plane 13 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane13_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane13_yolk_pitch");} }

        /// <summary>
        ///  Plane 13 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane13_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane13_yolk_roll");} }

        /// <summary>
        ///  Plane 13 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane13_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane13_yolk_yaw");} }

        /// <summary>
        ///  Plane 13 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane13_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane13_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane13_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane13_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane13_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane13_v_z");} }

        /// <summary>
        ///  Plane 14 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane14_the { get { return m_data.GetFloat("sim/multiplayer/position/plane14_the");} }

        /// <summary>
        ///  Plane 14 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane14_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane14_phi");} }

        /// <summary>
        ///  Plane 14 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane14_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane14_psi");} }

        /// <summary>
        ///  Plane 14 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane14_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane14_gear_deploy");} }

        /// <summary>
        ///  Plane 14 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane14_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane14_flap_ratio");} }

        /// <summary>
        ///  Plane 14 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane14_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane14_flap_ratio2");} }

        /// <summary>
        ///  Plane 14 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane14_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane14_spoiler_ratio");} }

        /// <summary>
        ///  Plane 14 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane14_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane14_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 14 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane14_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane14_sla1_ratio");} }

        /// <summary>
        ///  Plane 14 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane14_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane14_wing_sweep");} }

        /// <summary>
        ///  Plane 14 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane14_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane14_throttle");} }

        /// <summary>
        ///  Plane 14 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane14_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane14_yolk_pitch");} }

        /// <summary>
        ///  Plane 14 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane14_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane14_yolk_roll");} }

        /// <summary>
        ///  Plane 14 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane14_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane14_yolk_yaw");} }

        /// <summary>
        ///  Plane 14 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane14_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane14_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane14_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane14_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane14_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane14_v_z");} }

        /// <summary>
        ///  Plane 15 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane15_the { get { return m_data.GetFloat("sim/multiplayer/position/plane15_the");} }

        /// <summary>
        ///  Plane 15 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane15_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane15_phi");} }

        /// <summary>
        ///  Plane 15 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane15_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane15_psi");} }

        /// <summary>
        ///  Plane 15 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane15_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane15_gear_deploy");} }

        /// <summary>
        ///  Plane 15 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane15_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane15_flap_ratio");} }

        /// <summary>
        ///  Plane 15 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane15_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane15_flap_ratio2");} }

        /// <summary>
        ///  Plane 15 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane15_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane15_spoiler_ratio");} }

        /// <summary>
        ///  Plane 15 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane15_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane15_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 15 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane15_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane15_sla1_ratio");} }

        /// <summary>
        ///  Plane 15 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane15_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane15_wing_sweep");} }

        /// <summary>
        ///  Plane 15 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane15_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane15_throttle");} }

        /// <summary>
        ///  Plane 15 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane15_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane15_yolk_pitch");} }

        /// <summary>
        ///  Plane 15 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane15_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane15_yolk_roll");} }

        /// <summary>
        ///  Plane 15 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane15_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane15_yolk_yaw");} }

        /// <summary>
        ///  Plane 15 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane15_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane15_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane15_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane15_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane15_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane15_v_z");} }

        /// <summary>
        ///  Plane 16 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane16_the { get { return m_data.GetFloat("sim/multiplayer/position/plane16_the");} }

        /// <summary>
        ///  Plane 16 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane16_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane16_phi");} }

        /// <summary>
        ///  Plane 16 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane16_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane16_psi");} }

        /// <summary>
        ///  Plane 16 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane16_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane16_gear_deploy");} }

        /// <summary>
        ///  Plane 16 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane16_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane16_flap_ratio");} }

        /// <summary>
        ///  Plane 16 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane16_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane16_flap_ratio2");} }

        /// <summary>
        ///  Plane 16 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane16_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane16_spoiler_ratio");} }

        /// <summary>
        ///  Plane 16 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane16_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane16_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 16 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane16_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane16_sla1_ratio");} }

        /// <summary>
        ///  Plane 16 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane16_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane16_wing_sweep");} }

        /// <summary>
        ///  Plane 16 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane16_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane16_throttle");} }

        /// <summary>
        ///  Plane 16 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane16_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane16_yolk_pitch");} }

        /// <summary>
        ///  Plane 16 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane16_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane16_yolk_roll");} }

        /// <summary>
        ///  Plane 16 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane16_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane16_yolk_yaw");} }

        /// <summary>
        ///  Plane 16 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane16_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane16_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane16_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane16_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane16_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane16_v_z");} }

        /// <summary>
        ///  Plane 17 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane17_the { get { return m_data.GetFloat("sim/multiplayer/position/plane17_the");} }

        /// <summary>
        ///  Plane 17 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane17_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane17_phi");} }

        /// <summary>
        ///  Plane 17 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane17_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane17_psi");} }

        /// <summary>
        ///  Plane 17 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane17_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane17_gear_deploy");} }

        /// <summary>
        ///  Plane 17 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane17_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane17_flap_ratio");} }

        /// <summary>
        ///  Plane 17 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane17_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane17_flap_ratio2");} }

        /// <summary>
        ///  Plane 17 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane17_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane17_spoiler_ratio");} }

        /// <summary>
        ///  Plane 17 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane17_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane17_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 17 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane17_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane17_sla1_ratio");} }

        /// <summary>
        ///  Plane 17 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane17_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane17_wing_sweep");} }

        /// <summary>
        ///  Plane 17 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane17_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane17_throttle");} }

        /// <summary>
        ///  Plane 17 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane17_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane17_yolk_pitch");} }

        /// <summary>
        ///  Plane 17 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane17_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane17_yolk_roll");} }

        /// <summary>
        ///  Plane 17 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane17_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane17_yolk_yaw");} }

        /// <summary>
        ///  Plane 17 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane17_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane17_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane17_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane17_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane17_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane17_v_z");} }

        /// <summary>
        ///  Plane 18 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane18_the { get { return m_data.GetFloat("sim/multiplayer/position/plane18_the");} }

        /// <summary>
        ///  Plane 18 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane18_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane18_phi");} }

        /// <summary>
        ///  Plane 18 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane18_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane18_psi");} }

        /// <summary>
        ///  Plane 18 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane18_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane18_gear_deploy");} }

        /// <summary>
        ///  Plane 18 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane18_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane18_flap_ratio");} }

        /// <summary>
        ///  Plane 18 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane18_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane18_flap_ratio2");} }

        /// <summary>
        ///  Plane 18 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane18_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane18_spoiler_ratio");} }

        /// <summary>
        ///  Plane 18 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane18_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane18_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 18 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane18_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane18_sla1_ratio");} }

        /// <summary>
        ///  Plane 18 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane18_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane18_wing_sweep");} }

        /// <summary>
        ///  Plane 18 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane18_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane18_throttle");} }

        /// <summary>
        ///  Plane 18 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane18_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane18_yolk_pitch");} }

        /// <summary>
        ///  Plane 18 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane18_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane18_yolk_roll");} }

        /// <summary>
        ///  Plane 18 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane18_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane18_yolk_yaw");} }

        /// <summary>
        ///  Plane 18 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane18_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane18_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane18_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane18_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane18_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane18_v_z");} }

        /// <summary>
        ///  Plane 19 theta (pitch)
        /// </summary>
        public IXPDataRef<float> plane19_the { get { return m_data.GetFloat("sim/multiplayer/position/plane19_the");} }

        /// <summary>
        ///  Plane 19 phi (roll)
        /// </summary>
        public IXPDataRef<float> plane19_phi { get { return m_data.GetFloat("sim/multiplayer/position/plane19_phi");} }

        /// <summary>
        ///  Plane 19 psi (heading)
        /// </summary>
        public IXPDataRef<float> plane19_psi { get { return m_data.GetFloat("sim/multiplayer/position/plane19_psi");} }

        /// <summary>
        ///  Plane 19 gear deployment for 6 gear. 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float[]> plane19_gear_deploy { get { return m_data.GetFloatArray("sim/multiplayer/position/plane19_gear_deploy");} }

        /// <summary>
        ///  Plane 19 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane19_flap_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane19_flap_ratio");} }

        /// <summary>
        ///  Plane 19 flap lowering 0 = clean, 1 = max flaps
        /// </summary>
        public IXPDataRef<float> plane19_flap_ratio2 { get { return m_data.GetFloat("sim/multiplayer/position/plane19_flap_ratio2");} }

        /// <summary>
        ///  Plane 19 spoiler ratio (0 = clean, 1 = max spoilers)
        /// </summary>
        public IXPDataRef<float> plane19_spoiler_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane19_spoiler_ratio");} }

        /// <summary>
        ///  Plane 19 speed brake ratio (0 = clean, 1 = max speed brakes)
        /// </summary>
        public IXPDataRef<float> plane19_speedbrake_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane19_speedbrake_ratio");} }

        /// <summary>
        ///  Plane 19 slat deployment ratio 0 = clean, 1 = max slats
        /// </summary>
        public IXPDataRef<float> plane19_sla1_ratio { get { return m_data.GetFloat("sim/multiplayer/position/plane19_sla1_ratio");} }

        /// <summary>
        ///  Plane 19 wing sweep, 0 = normal, 1 = most sweep
        /// </summary>
        public IXPDataRef<float> plane19_wing_sweep { get { return m_data.GetFloat("sim/multiplayer/position/plane19_wing_sweep");} }

        /// <summary>
        ///  Plane 19 Percent of max throttle per 8 engines (0 = none, 1 = full fwd, -1 = full reverse)
        /// </summary>
        public IXPDataRef<float[]> plane19_throttle { get { return m_data.GetFloatArray("sim/multiplayer/position/plane19_throttle");} }

        /// <summary>
        ///  Plane 19 Commanded pitch (Legacy for compatibility - use sim/multiplayer/controls/yoke_pitch_ratio)
        /// </summary>
        public IXPDataRef<float> plane19_yolk_pitch { get { return m_data.GetFloat("sim/multiplayer/position/plane19_yolk_pitch");} }

        /// <summary>
        ///  Plane 19 Commanded roll (Legacy for compatibility - use sim/multiplayer/controls/yoke_roll_ratio)
        /// </summary>
        public IXPDataRef<float> plane19_yolk_roll { get { return m_data.GetFloat("sim/multiplayer/position/plane19_yolk_roll");} }

        /// <summary>
        ///  Plane 19 Commanded yaw (Legacy for compatibility - use sim/multiplayer/controls/yoke_heading_ratio)
        /// </summary>
        public IXPDataRef<float> plane19_yolk_yaw { get { return m_data.GetFloat("sim/multiplayer/position/plane19_yolk_yaw");} }

        /// <summary>
        ///  Plane 19 cartesian velocities.  These may not be accurate if another plugin
        /// </summary>
        public IXPDataRef<float> plane19_v_x { get { return m_data.GetFloat("sim/multiplayer/position/plane19_v_x");} }

        /// <summary>
        ///  is controlling the plane andn ot updating this data.  You cannot use these to
        /// </summary>
        public IXPDataRef<float> plane19_v_y { get { return m_data.GetFloat("sim/multiplayer/position/plane19_v_y");} }

        /// <summary>
        ///  manipulate the plane.
        /// </summary>
        public IXPDataRef<float> plane19_v_z { get { return m_data.GetFloat("sim/multiplayer/position/plane19_v_z");} }
    }
}