using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_gearDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_gearDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Current gear heading angle, degrees.. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/gear_heading_deg
        /// </summary>
        public IXPDataRef<float[]> gear_heading_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/gear_heading_deg");} }

        /// <summary>
        ///  Current gear pitch angle, degrees.. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/gear_pitch_deg
        /// </summary>
        public IXPDataRef<float[]> gear_pitch_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/gear_pitch_deg");} }

        /// <summary>
        ///  Current gear roll angle, degrees.. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/gear_roll_deg
        /// </summary>
        public IXPDataRef<float[]> gear_roll_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/gear_roll_deg");} }

        /// <summary>
        ///  Steering command being sent to this gear, degrees positive right.  This takes into account steering algorithms for big planes like 747, but does not free castoring and springiness.  Writable in 1030.  Override via override_wheel_steer. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/tire_steer_command_deg
        /// </summary>
        public IXPDataRef<float[]> tire_steer_command_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_steer_command_deg");} }

        /// <summary>
        ///  Steering command actually enacted by the gear, degrees positive right.  Writable in 1030.  Override via override_wheel_steer. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/tire_steer_actual_deg
        /// </summary>
        public IXPDataRef<float[]> tire_steer_actual_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_steer_actual_deg");} }

        /// <summary>
        ///  Vertical deflection of this gear, meters.. Units:meters
        ///  Raw path: sim/flightmodel2/gear/tire_vertical_deflection_mtr
        /// </summary>
        public IXPDataRef<float[]> tire_vertical_deflection_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_vertical_deflection_mtr");} }

        /// <summary>
        ///  Vertical force on this gear, newtons.. Units:newton_meters
        ///  Raw path: sim/flightmodel2/gear/tire_vertical_force_n_mtr
        /// </summary>
        public IXPDataRef<float[]> tire_vertical_force_n_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_vertical_force_n_mtr");} }

        /// <summary>
        ///  Rotational speed of this tire, radians per second.. Units:radians/second
        ///  Raw path: sim/flightmodel2/gear/tire_rotation_speed_rad_sec
        /// </summary>
        public IXPDataRef<float[]> tire_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_rotation_speed_rad_sec");} }

        /// <summary>
        ///  Tire rotation in degrees, running 0 to 360 over and over as it rolls.. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/tire_rotation_angle_deg
        /// </summary>
        public IXPDataRef<float[]> tire_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_rotation_angle_deg");} }

        /// <summary>
        ///  This is how far down the landing gear is.  0=up, 1= down. Units:ratio
        ///  Raw path: sim/flightmodel2/gear/deploy_ratio
        /// </summary>
        public IXPDataRef<float[]> deploy_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/gear/deploy_ratio");} }

        /// <summary>
        ///  Angle of eagle-claw landing gear now, degrees, per gear.. Units:degrees
        ///  Raw path: sim/flightmodel2/gear/eagle_claw_angle_deg
        /// </summary>
        public IXPDataRef<float[]> eagle_claw_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/gear/eagle_claw_angle_deg");} }

        /// <summary>
        ///  Ratio of how much this tire is in a skid - 0 = full traction, 1 = completely skidding. Units:0..1
        ///  Raw path: sim/flightmodel2/gear/tire_skid_ratio
        /// </summary>
        public IXPDataRef<float[]> tire_skid_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/gear/tire_skid_ratio");} }

        /// <summary>
        ///  Rate at which the tires are deflecting, positive means shocks are contracting. Units:meters/second
        ///  Raw path: sim/flightmodel2/gear/total_deflection_rate
        /// </summary>
        public IXPDataRef<float[]> total_deflection_rate { get { return m_data.GetFloatArray("sim/flightmodel2/gear/total_deflection_rate");} }

        /// <summary>
        ///  Is this wheel on the ground. Units:boolean
        ///  Raw path: sim/flightmodel2/gear/on_ground
        /// </summary>
        public IXPDataRef<bool[]> on_ground { get { return m_data.GetBoolArray("sim/flightmodel2/gear/on_ground");} }

        /// <summary>
        ///  Is this wheel on grass. Units:boolean
        ///  Raw path: sim/flightmodel2/gear/on_grass
        /// </summary>
        public IXPDataRef<bool[]> on_grass { get { return m_data.GetBoolArray("sim/flightmodel2/gear/on_grass");} }

        /// <summary>
        ///  Is this wheel on some kind of noisy surface like gravel. Units:boolean
        ///  Raw path: sim/flightmodel2/gear/on_noisy
        /// </summary>
        public IXPDataRef<bool[]> on_noisy { get { return m_data.GetBoolArray("sim/flightmodel2/gear/on_noisy");} }
    }
}