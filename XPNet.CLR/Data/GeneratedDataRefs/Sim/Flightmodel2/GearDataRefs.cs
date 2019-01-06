using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_GearDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_GearDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Current gear heading angle, degrees.
        /// </summary>
        public IXPDataRef<float[]> Gear_heading_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/gear_heading_deg");} }

        /// <summary>
        ///  Current gear pitch angle, degrees.
        /// </summary>
        public IXPDataRef<float[]> Gear_pitch_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/gear_pitch_deg");} }

        /// <summary>
        ///  Current gear roll angle, degrees.
        /// </summary>
        public IXPDataRef<float[]> Gear_roll_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/gear_roll_deg");} }

        /// <summary>
        ///  Steering command being sent to this gear, degrees positive right.  This takes into account steering algorithms for big planes like 747, but does not free castoring and springiness.  Writable in 1030.  Override via override_wheel_steer
        /// </summary>
        public IXPDataRef<float[]> Tire_steer_command_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_steer_command_deg");} }

        /// <summary>
        ///  Steering command actually enacted by the gear, degrees positive right.  Writable in 1030.  Override via override_wheel_steer
        /// </summary>
        public IXPDataRef<float[]> Tire_steer_actual_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_steer_actual_deg");} }

        /// <summary>
        ///  Vertical deflection of this gear, meters.
        /// </summary>
        public IXPDataRef<float[]> Tire_vertical_deflection_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_vertical_deflection_mtr");} }

        /// <summary>
        ///  Vertical force on this gear, newtons.
        /// </summary>
        public IXPDataRef<float[]> Tire_vertical_force_n_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_vertical_force_n_mtr");} }

        /// <summary>
        ///  Rotational speed of this tire, radians per second.
        /// </summary>
        public IXPDataRef<float[]> Tire_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_rotation_speed_rad_sec");} }

        /// <summary>
        ///  Tire rotation in degrees, running 0 to 360 over and over as it rolls.
        /// </summary>
        public IXPDataRef<float[]> Tire_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_rotation_angle_deg");} }

        /// <summary>
        ///  This is how far down the landing gear is.  0=up, 1= down
        /// </summary>
        public IXPDataRef<float[]> Deploy_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/gear/deploy_ratio");} }

        /// <summary>
        ///  Angle of eagle-claw landing gear now, degrees, per gear.
        /// </summary>
        public IXPDataRef<float[]> Eagle_claw_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/eagle_claw_angle_deg");} }

        /// <summary>
        ///  Ratio of how much this tire is in a skid - 0 = full traction, 1 = completely skidding
        /// </summary>
        public IXPDataRef<float[]> Tire_skid_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_skid_ratio");} }

        /// <summary>
        ///  Rate at which the tires are deflecting, positive means shocks are contracting
        /// </summary>
        public IXPDataRef<float[]> Total_deflection_rate { get { return m_data.GetFloatArray("sim/flightmodel2/gear/total_deflection_rate");} }

        /// <summary>
        ///  Is this wheel on the ground
        /// </summary>
        public IXPDataRef<bool[]> On_ground { get { return m_data.GetBoolArray("sim/flightmodel2/gear/on_ground");} }

        /// <summary>
        ///  Is this wheel on grass
        /// </summary>
        public IXPDataRef<bool[]> On_grass { get { return m_data.GetBoolArray("sim/flightmodel2/gear/on_grass");} }

        /// <summary>
        ///  Is this wheel on some kind of noisy surface like gravel
        /// </summary>
        public IXPDataRef<bool[]> On_noisy { get { return m_data.GetBoolArray("sim/flightmodel2/gear/on_noisy");} }
    }
}