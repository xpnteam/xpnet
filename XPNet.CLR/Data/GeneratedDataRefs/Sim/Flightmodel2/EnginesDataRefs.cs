using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_EnginesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_EnginesDatarefs(IXPlaneData data)
        {
            m_data = data;
            Prop_disc = new Sim_Flightmodel2_Engines_Prop_discDatarefs(data);
        }
        public Sim_Flightmodel2_Engines_Prop_discDatarefs Prop_disc { get; }

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.
        /// </summary>
        public IXPDataRef<float[]> Location_x_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/engines/location_x_mtr");} }

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.
        /// </summary>
        public IXPDataRef<float[]> Location_y_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/engines/location_y_mtr");} }

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.
        /// </summary>
        public IXPDataRef<float[]> Location_z_mtr { get { return m_data.GetFloatArray("sim/flightmodel2/engines/location_z_mtr");} }

        /// <summary>
        ///  Throttle that is actually going to the engine, which could be different than the commanded throttle due to FADEC throttle adjustments.
        /// </summary>
        public IXPDataRef<float[]> Throttle_used_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/throttle_used_ratio");} }

        /// <summary>
        ///  Engine has fuel making to the mixture control, yes or no.  Writable if override_fuel_system is true.
        /// </summary>
        public IXPDataRef<bool[]> Has_fuel_flow_before_mixture { get { return m_data.GetBoolArray("sim/flightmodel2/engines/has_fuel_flow_before_mixture");} }

        /// <summary>
        ///  Engine has fuel making to the combustion process, yes or no.
        /// </summary>
        public IXPDataRef<bool[]> Has_fuel_flow_after_mixture { get { return m_data.GetBoolArray("sim/flightmodel2/engines/has_fuel_flow_after_mixture");} }

        /// <summary>
        ///  Engine is currently burning fuel, yes or no.
        /// </summary>
        public IXPDataRef<bool[]> Engine_is_burning_fuel { get { return m_data.GetBoolArray("sim/flightmodel2/engines/engine_is_burning_fuel");} }

        /// <summary>
        ///  How much fuel has been primed into the intake port (fuel-injected engine) 0..1
        /// </summary>
        public IXPDataRef<float[]> Engine_fuel_in_intake { get { return m_data.GetFloatArray("sim/flightmodel2/engines/engine_fuel_in_intake");} }

        /// <summary>
        ///  Afterburner on, yes or no.
        /// </summary>
        public IXPDataRef<bool[]> Afterburner_on { get { return m_data.GetBoolArray("sim/flightmodel2/engines/afterburner_on");} }

        /// <summary>
        ///  Afterburner engaged ratio, 0.0 to 1.0.
        /// </summary>
        public IXPDataRef<float[]> Afterburner_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/afterburner_ratio");} }

        /// <summary>
        ///  Rotational speed of the engine, in radians per second.
        /// </summary>
        public IXPDataRef<float[]> Engine_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/flightmodel2/engines/engine_rotation_speed_rad_sec");} }

        /// <summary>
        ///  This is the angle of the engine as it turns over, running 0 to 360 over and over again in normal operation. Engine speed can be different than prop rotation speed in clutched designs. This is radians per second.
        /// </summary>
        public IXPDataRef<float[]> Engine_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/engine_rotation_angle_deg");} }

        /// <summary>
        ///  Radians per second rotation speed of the prop.
        /// </summary>
        public IXPDataRef<float[]> Prop_rotation_speed_rad_sec { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_rotation_speed_rad_sec");} }

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns.  Override witih /Prop_disc/Override per engine!
        /// </summary>
        public IXPDataRef<float[]> Prop_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_rotation_angle_deg");} }

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns. This dataref NEVER shows the speed of the prop disc if it happens to be showing. This always tracks the actual prop.  Override witih /Prop_disc/Override per engine!
        /// </summary>
        public IXPDataRef<float[]> Prop_no_disc_rotation_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_no_disc_rotation_angle_deg");} }

        /// <summary>
        ///  This is the ACTUAL pitch of the prop in degrees from its flat-pitch setting.
        /// </summary>
        public IXPDataRef<float[]> Prop_pitch_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_pitch_deg");} }

        /// <summary>
        ///  This is the coning angle of the disc, in radians. Typically close to 0.0.
        /// </summary>
        public IXPDataRef<float[]> Prop_cone_angle_rad { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_cone_angle_rad");} }

        /// <summary>
        ///  This engine rotor-disc vertical vector, in degrees, where 0 is straight forwards, 90 is straight up.
        /// </summary>
        public IXPDataRef<float[]> Rotor_vertical_vector_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_vertical_vector_deg");} }

        /// <summary>
        ///  This engine rotor-disc longitudinal cyclic, in degrees, where -10 is 10 degrees forwards, 10 is 10 degrees aft.
        /// </summary>
        public IXPDataRef<float[]> Rotor_vertical_cyclic_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_vertical_cyclic_deg");} }

        /// <summary>
        ///  This engine rotor-disc lateral cyclic, in degrees, where -10 is 10 degrees left, 10 is 10 degrees right.
        /// </summary>
        public IXPDataRef<float[]> Rotor_side_cyclic_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_side_cyclic_deg");} }

        /// <summary>
        ///  Longitudinal disc tilt from cyclic deflection.
        /// </summary>
        public IXPDataRef<float[]> Rotor_cyclic_elevator_tilt_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_cyclic_elevator_tilt_deg");} }

        /// <summary>
        ///  Lateral disc tilt from cyclic deflection.
        /// </summary>
        public IXPDataRef<float[]> Rotor_cyclic_aileron_tilt_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/rotor_cyclic_aileron_tilt_deg");} }

        /// <summary>
        ///  This engine nacelle vertical vector, in degrees, where 0 is straight forwards, 90 is straight up.
        /// </summary>
        public IXPDataRef<float[]> Nacelle_vertical_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/engines/nacelle_vertical_angle_deg");} }

        /// <summary>
        ///  How far the reverser doors/Mechanism have traveled.  0 = fully stowed, 1.0 = fully deployed.
        /// </summary>
        public IXPDataRef<float[]> Thrust_reverser_deploy_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/engines/thrust_reverser_deploy_ratio");} }

        /// <summary>
        ///  Is the prop a disc now?  Override with /Prop_disc/Override per engine!
        /// </summary>
        public IXPDataRef<bool[]> Prop_is_disc { get { return m_data.GetBoolArray("sim/flightmodel2/engines/prop_is_disc");} }

        /// <summary>
        ///  Degrees of deflection of a line from the crank shaft to the prop tip.
        /// </summary>
        public IXPDataRef<float[]> Prop_tip_deflection_degrees { get { return m_data.GetFloatArray("sim/flightmodel2/engines/prop_tip_deflection_degrees");} }

        /// <summary>
        ///  Is the electric fuel pump for this engine spinning?  1 = yes, 0 = no.
        /// </summary>
        public IXPDataRef<float[]> Fuel_pump_spinning { get { return m_data.GetFloatArray("sim/flightmodel2/engines/fuel_pump_spinning");} }

        /// <summary>
        ///  Is this starter running at all
        /// </summary>
        public IXPDataRef<bool[]> Starter_is_running { get { return m_data.GetBoolArray("sim/flightmodel2/engines/starter_is_running");} }

        /// <summary>
        ///  Is this starter applying torque to the engine
        /// </summary>
        public IXPDataRef<bool[]> Starter_making_torque { get { return m_data.GetBoolArray("sim/flightmodel2/engines/starter_making_torque");} }
    }
}