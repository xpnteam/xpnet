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
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Location_x_mtr => m_data.GetFloatArray("sim/flightmodel2/engines/location_x_mtr");

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Location_y_mtr => m_data.GetFloatArray("sim/flightmodel2/engines/location_y_mtr");

        /// <summary>
        ///  Engine location, meters x, y, z, with respect to the default center of gravity.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Location_z_mtr => m_data.GetFloatArray("sim/flightmodel2/engines/location_z_mtr");

        /// <summary>
        ///  Throttle that is actually going to the engine, which could be different than the commanded throttle due to FADEC throttle adjustments.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Throttle_used_ratio => m_data.GetFloatArray("sim/flightmodel2/engines/throttle_used_ratio");

        /// <summary>
        ///  How much fuel has been primed into the intake port (fuel-injected engine) 0..1. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Engine_fuel_in_intake => m_data.GetFloatArray("sim/flightmodel2/engines/engine_fuel_in_intake");

        /// <summary>
        ///  Afterburner engaged ratio, 0.0 to 1.0.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Afterburner_ratio => m_data.GetFloatArray("sim/flightmodel2/engines/afterburner_ratio");

        /// <summary>
        ///  Rotational speed of the engine, in radians per second.. Units:radians/Second
        /// </summary>
        public IXPDataRef<float[]> Engine_rotation_speed_rad_sec => m_data.GetFloatArray("sim/flightmodel2/engines/engine_rotation_speed_rad_sec");

        /// <summary>
        ///  This is the angle of the engine as it turns over, running 0 to 360 over and over again in normal operation. Engine speed can be different than prop rotation speed in clutched designs. This is radians per second.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Engine_rotation_angle_deg => m_data.GetFloatArray("sim/flightmodel2/engines/engine_rotation_angle_deg");

        /// <summary>
        ///  Radians per second rotation speed of the prop.. Units:radians/Second
        /// </summary>
        public IXPDataRef<float[]> Prop_rotation_speed_rad_sec => m_data.GetFloatArray("sim/flightmodel2/engines/prop_rotation_speed_rad_sec");

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns.  Override witih /Prop_disc/Override per engine!. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Prop_rotation_angle_deg => m_data.GetFloatArray("sim/flightmodel2/engines/prop_rotation_angle_deg");

        /// <summary>
        ///  This is the angle of the prop or engine-fan as it rotates. You will see this value circulate 0 to 360 degrees over and over as the engine runs and the prop or fan turns. This dataref NEVER shows the speed of the prop disc if it happens to be showing. This always tracks the actual prop.  Override witih /Prop_disc/Override per engine!. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Prop_no_disc_rotation_angle_deg => m_data.GetFloatArray("sim/flightmodel2/engines/prop_no_disc_rotation_angle_deg");

        /// <summary>
        ///  This is the ACTUAL pitch of the prop in degrees from its flat-pitch setting.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Prop_pitch_deg => m_data.GetFloatArray("sim/flightmodel2/engines/prop_pitch_deg");

        /// <summary>
        ///  This is the coning angle of the disc, in radians. Typically close to 0.0.. Units:radians
        /// </summary>
        public IXPDataRef<float[]> Prop_cone_angle_rad => m_data.GetFloatArray("sim/flightmodel2/engines/prop_cone_angle_rad");

        /// <summary>
        ///  This engine rotor-disc vertical vector, in degrees, where 0 is straight forwards, 90 is straight up.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rotor_vertical_vector_deg => m_data.GetFloatArray("sim/flightmodel2/engines/rotor_vertical_vector_deg");

        /// <summary>
        ///  This engine rotor-disc longitudinal cyclic, in degrees, where -10 is 10 degrees forwards, 10 is 10 degrees aft.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rotor_vertical_cyclic_deg => m_data.GetFloatArray("sim/flightmodel2/engines/rotor_vertical_cyclic_deg");

        /// <summary>
        ///  This engine rotor-disc lateral cyclic, in degrees, where -10 is 10 degrees left, 10 is 10 degrees right.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rotor_side_cyclic_deg => m_data.GetFloatArray("sim/flightmodel2/engines/rotor_side_cyclic_deg");

        /// <summary>
        ///  Longitudinal disc tilt from cyclic deflection.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rotor_cyclic_elevator_tilt_deg => m_data.GetFloatArray("sim/flightmodel2/engines/rotor_cyclic_elevator_tilt_deg");

        /// <summary>
        ///  Lateral disc tilt from cyclic deflection.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rotor_cyclic_aileron_tilt_deg => m_data.GetFloatArray("sim/flightmodel2/engines/rotor_cyclic_aileron_tilt_deg");

        /// <summary>
        ///  This engine nacelle vertical vector, in degrees, where 0 is straight forwards, 90 is straight up.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Nacelle_vertical_angle_deg => m_data.GetFloatArray("sim/flightmodel2/engines/nacelle_vertical_angle_deg");

        /// <summary>
        ///  How far the reverser doors/Mechanism have traveled.  0 = fully stowed, 1.0 = fully deployed.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Thrust_reverser_deploy_ratio => m_data.GetFloatArray("sim/flightmodel2/engines/thrust_reverser_deploy_ratio");

        /// <summary>
        ///  Degrees of deflection of a line from the crank shaft to the prop tip.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Prop_tip_deflection_degrees => m_data.GetFloatArray("sim/flightmodel2/engines/prop_tip_deflection_degrees");

        /// <summary>
        ///  Is the electric fuel pump for this engine spinning?  1 = yes, 0 = no.. Units:0..1
        /// </summary>
        public IXPDataRef<float[]> Fuel_pump_spinning => m_data.GetFloatArray("sim/flightmodel2/engines/fuel_pump_spinning");
    }
}