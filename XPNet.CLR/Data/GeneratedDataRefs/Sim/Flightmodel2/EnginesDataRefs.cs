using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_enginesDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_enginesDataRefs(IXPlaneData data)
        {
            m_data = data;
            prop_disc = new sim_flightmodel2_engines_prop_discDataRefs(data);
        }
        public sim_flightmodel2_engines_prop_discDataRefs prop_disc { get; }

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.. Units:meters
        ///  Raw path: sim/flightmodel2/engines/location_x_mtr
        /// </summary>
        public IXPDataRef<float[]> location_x_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/engines/location_x_mtr");} }

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.. Units:meters
        ///  Raw path: sim/flightmodel2/engines/location_y_mtr
        /// </summary>
        public IXPDataRef<float[]> location_y_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/engines/location_y_mtr");} }

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.. Units:meters
        ///  Raw path: sim/flightmodel2/engines/location_z_mtr
        /// </summary>
        public IXPDataRef<float[]> location_z_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/engines/location_z_mtr");} }

        /// <summary>
        ///  Throttle that is actually going to the engine, which could be different than the commanded throttle due to FADEC throttle adjustments.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/throttle_used_ratio
        /// </summary>
        public IXPDataRef<float[]> throttle_used_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/throttle_used_ratio");} }

        /// <summary>
        ///  Engine has fuel making to the mixture control, yes or no.  Writable if override_fuel_system is true.. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/has_fuel_flow_before_mixture
        /// </summary>
        public IXPDataRef<bool[]> has_fuel_flow_before_mixture { get { return m_data.GetBoolArray("sim/flightmodel2/engines/has_fuel_flow_before_mixture");} }

        /// <summary>
        ///  Engine has fuel making to the combustion process, yes or no.. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/has_fuel_flow_after_mixture
        /// </summary>
        public IXPDataRef<bool[]> has_fuel_flow_after_mixture { get { return m_data.GetBoolArray("sim/flightmodel2/engines/has_fuel_flow_after_mixture");} }

        /// <summary>
        ///  Engine is currently burning fuel, yes or no.. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/engine_is_burning_fuel
        /// </summary>
        public IXPDataRef<bool[]> engine_is_burning_fuel { get { return m_data.GetBoolArray("sim/flightmodel2/engines/engine_is_burning_fuel");} }

        /// <summary>
        ///  How much fuel has been primed into the intake port (fuel-injected engine) 0..1. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/engine_fuel_in_intake
        /// </summary>
        public IXPDataRef<float[]> engine_fuel_in_intake { get { return m_data.GetFloatArray("sim/flightmodel2/engines/engine_fuel_in_intake");} }

        /// <summary>
        ///  Afterburner on, yes or no.. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/afterburner_on
        /// </summary>
        public IXPDataRef<bool[]> afterburner_on { get { return m_data.GetBoolArray("sim/flightmodel2/engines/afterburner_on");} }

        /// <summary>
        ///  Afterburner engaged ratio, 0.0 to 1.0.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/afterburner_ratio
        /// </summary>
        public IXPDataRef<float[]> afterburner_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/afterburner_ratio");} }

        /// <summary>
        ///  Rotational speed of the engine, in radians per second.. Units:radians/second
        ///  Raw path: sim/flightmodel2/engines/engine_rotation_speed_rad_sec
        /// </summary>
        public IXPDataRef<float[]> engine_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/flightmodel2/engines/engine_rotation_speed_rad_sec");} }

        /// <summary>
        ///  This is the angle of the engine as it turns over, running 0 to 360 over and over again in normal operation. Engine speed can be different than prop rotation speed in clutched designs. This is radians per second.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/engine_rotation_angle_deg
        /// </summary>
        public IXPDataRef<float[]> engine_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/engine_rotation_angle_deg");} }

        /// <summary>
        ///  Radians per second rotation speed of the prop.. Units:radians/second
        ///  Raw path: sim/flightmodel2/engines/prop_rotation_speed_rad_sec
        /// </summary>
        public IXPDataRef<float[]> prop_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_rotation_speed_rad_sec");} }

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns.  Override witih /prop_disc/override per engine!. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/prop_rotation_angle_deg
        /// </summary>
        public IXPDataRef<float[]> prop_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_rotation_angle_deg");} }

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns. This dataref NEVER shows the speed of the prop disc if it happens to be showing. This always tracks the actual prop.  Override witih /prop_disc/override per engine!. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/prop_no_disc_rotation_angle_deg
        /// </summary>
        public IXPDataRef<float[]> prop_no_disc_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_no_disc_rotation_angle_deg");} }

        /// <summary>
        ///  This is the ACTUAL pitch of the prop in degrees from its flat-pitch setting.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/prop_pitch_deg
        /// </summary>
        public IXPDataRef<float[]> prop_pitch_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_pitch_deg");} }

        /// <summary>
        ///  This is the coning angle of the disc, in radians. Typically close to 0.0.. Units:radians
        ///  Raw path: sim/flightmodel2/engines/prop_cone_angle_rad
        /// </summary>
        public IXPDataRef<float[]> prop_cone_angle_rad { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_cone_angle_rad");} }

        /// <summary>
        ///  This engine rotor-disc vertical vector, in degrees, where 0 is straight forwards, 90 is straight up.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/rotor_vertical_vector_deg
        /// </summary>
        public IXPDataRef<float[]> rotor_vertical_vector_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_vertical_vector_deg");} }

        /// <summary>
        ///  This engine rotor-disc longitudinal cyclic, in degrees, where -10 is 10 degrees forwards, 10 is 10 degrees aft.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/rotor_vertical_cyclic_deg
        /// </summary>
        public IXPDataRef<float[]> rotor_vertical_cyclic_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_vertical_cyclic_deg");} }

        /// <summary>
        ///  This engine rotor-disc lateral cyclic, in degrees, where -10 is 10 degrees left, 10 is 10 degrees right.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/rotor_side_cyclic_deg
        /// </summary>
        public IXPDataRef<float[]> rotor_side_cyclic_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_side_cyclic_deg");} }

        /// <summary>
        ///  Longitudinal disc tilt from cyclic deflection.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/rotor_cyclic_elevator_tilt_deg
        /// </summary>
        public IXPDataRef<float[]> rotor_cyclic_elevator_tilt_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_cyclic_elevator_tilt_deg");} }

        /// <summary>
        ///  Lateral disc tilt from cyclic deflection.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/rotor_cyclic_aileron_tilt_deg
        /// </summary>
        public IXPDataRef<float[]> rotor_cyclic_aileron_tilt_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_cyclic_aileron_tilt_deg");} }

        /// <summary>
        ///  This engine nacelle vertical vector, in degrees, where 0 is straight forwards, 90 is straight up.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/nacelle_vertical_angle_deg
        /// </summary>
        public IXPDataRef<float[]> nacelle_vertical_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/nacelle_vertical_angle_deg");} }

        /// <summary>
        ///  How far the reverser doors/mechanism have traveled.  0 = fully stowed, 1.0 = fully deployed.. Units:ratio
        ///  Raw path: sim/flightmodel2/engines/thrust_reverser_deploy_ratio
        /// </summary>
        public IXPDataRef<float[]> thrust_reverser_deploy_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/thrust_reverser_deploy_ratio");} }

        /// <summary>
        ///  Is the prop a disc now?  Override with /prop_disc/override per engine!. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/prop_is_disc
        /// </summary>
        public IXPDataRef<bool[]> prop_is_disc { get { return m_data.GetBoolArray("sim/flightmodel2/engines/prop_is_disc");} }

        /// <summary>
        ///  Degrees of deflection of a line from the crank shaft to the prop tip.. Units:degrees
        ///  Raw path: sim/flightmodel2/engines/prop_tip_deflection_degrees
        /// </summary>
        public IXPDataRef<float[]> prop_tip_deflection_degrees { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_tip_deflection_degrees");} }

        /// <summary>
        ///  Is the electric fuel pump for this engine spinning?  1 = yes, 0 = no.. Units:0..1
        ///  Raw path: sim/flightmodel2/engines/fuel_pump_spinning
        /// </summary>
        public IXPDataRef<float[]> fuel_pump_spinning { get { return m_data.GetFloatArray("sim/flightmodel2/engines/fuel_pump_spinning");} }

        /// <summary>
        ///  Is this starter running at all. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/starter_is_running
        /// </summary>
        public IXPDataRef<bool[]> starter_is_running { get { return m_data.GetBoolArray("sim/flightmodel2/engines/starter_is_running");} }

        /// <summary>
        ///  Is this starter applying torque to the engine. Units:boolean
        ///  Raw path: sim/flightmodel2/engines/starter_making_torque
        /// </summary>
        public IXPDataRef<bool[]> starter_making_torque { get { return m_data.GetBoolArray("sim/flightmodel2/engines/starter_making_torque");} }
    }
}