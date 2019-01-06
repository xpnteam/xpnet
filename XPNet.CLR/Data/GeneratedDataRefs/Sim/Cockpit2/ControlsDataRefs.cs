using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_controlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_controlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is how much the yoke is deflected in the cockpit, in ratio, where -1.0 is full down, and 1.0 is full up.
        /// </summary>
        public IXPDataRef<float> yoke_pitch_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/yoke_pitch_ratio");} }

        /// <summary>
        ///  This is how much the yoke is deflected in the cockpit, in ratio, where -1.0 is full left, and 1.0 is full right.
        /// </summary>
        public IXPDataRef<float> yoke_roll_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/yoke_roll_ratio");} }

        /// <summary>
        ///  This is how much the rudder is deflected in the cockpit, in ratio, where -1.0 is full left, and 1.0 is full right.
        /// </summary>
        public IXPDataRef<float> yoke_heading_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/yoke_heading_ratio");} }

        /// <summary>
        ///  This is how much the speebrake HANDLE is deflected, in ratio, where 0.0 is fully retracted, 0.5 is halfway down, and 1.0 is fully down, and -0.5 is speedbrakes ARMED.
        /// </summary>
        public IXPDataRef<float> speedbrake_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/speedbrake_ratio");} }

        /// <summary>
        ///  Requested sweep, in ratio. 0.0 is no sweep requested, 1 is max sweep requested.
        /// </summary>
        public IXPDataRef<float> wingsweep_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/wingsweep_ratio");} }

        /// <summary>
        ///  Requested thrust vector, in ratio. 0.0 is no thrust vector requested, 1 is max thrust vector requested.
        /// </summary>
        public IXPDataRef<float> thrust_vector_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/thrust_vector_ratio");} }

        /// <summary>
        ///  Requested dihedral, in ratio. 0.0 is no dihedral requested, 1 is max dihedral requested.
        /// </summary>
        public IXPDataRef<float> dihedral_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/dihedral_ratio");} }

        /// <summary>
        ///  Requested incidence, in ratio. 0.0 is no incidence requested, 1 is max incidence requested.
        /// </summary>
        public IXPDataRef<float> incidence_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/incidence_ratio");} }

        /// <summary>
        ///  Requested wing-retraction, in ratio. 0.0 is no wing-retraction requested, 1 is max wing-retraction requested.
        /// </summary>
        public IXPDataRef<float> wing_retraction_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/wing_retraction_ratio");} }

        /// <summary>
        ///  This is the flap HANDLE location, in ratio, where 0.0 is handle fully retracted, and 1.0 is handle fully extended.
        /// </summary>
        public IXPDataRef<float> flap_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/flap_ratio");} }

        /// <summary>
        ///  This is the overall brake requested by the parking brake button... 0.0 is none, 1.0 is complete.
        /// </summary>
        public IXPDataRef<float> parking_brake_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/parking_brake_ratio");} }

        /// <summary>
        ///  This is additional left brake requested by pedal deflection, 0.0 to 1.0.
        /// </summary>
        public IXPDataRef<float> left_brake_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/left_brake_ratio");} }

        /// <summary>
        ///  This is additional right brake requested by pedal deflection, 0.0 to 1.0.
        /// </summary>
        public IXPDataRef<float> right_brake_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/right_brake_ratio");} }

        /// <summary>
        ///  Gear handle position. 0 is up. 1 is down.
        /// </summary>
        public IXPDataRef<bool> gear_handle_down { get { return m_data.GetBool("sim/cockpit2/controls/gear_handle_down");} }

        /// <summary>
        ///  Is the nosewheel steering turned on? 0 or 1.  This must be off AND the tail wheel must be unlocked to free castor.
        /// </summary>
        public IXPDataRef<bool> nosewheel_steer_on { get { return m_data.GetBool("sim/cockpit2/controls/nosewheel_steer_on");} }

        /// <summary>
        ///  Tail-wheel lockig ratio. 0 for free-castoring, 1 for totally locked.
        /// </summary>
        public IXPDataRef<float> tailwheel_lock_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/tailwheel_lock_ratio");} }

        /// <summary>
        ///  Aileron trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the aileron trim is deflected enough to move the ailerons through 30% of their travel, then that is an aileron trim of 0.3. -1=left 1=right
        /// </summary>
        public IXPDataRef<float> aileron_trim { get { return m_data.GetFloat("sim/cockpit2/controls/aileron_trim");} }

        /// <summary>
        ///  Elevator trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the elevator trim is deflected enough to move the elevators through 30% of their travel, then that is an elevator trim of 0.3. -1=down 1=up
        /// </summary>
        public IXPDataRef<float> elevator_trim { get { return m_data.GetFloat("sim/cockpit2/controls/elevator_trim");} }

        /// <summary>
        ///  Rudder trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the rudder trim is deflected enough to move the rudders through 30% of their travel, then that is an rudder trim of 0.3. -1=left 1=right
        /// </summary>
        public IXPDataRef<float> rudder_trim { get { return m_data.GetFloat("sim/cockpit2/controls/rudder_trim");} }

        /// <summary>
        ///  Rotor trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the rotor trim is deflected enough to move the rotor through 30% of its travel, then that is a rotor trim of 0.3. -1=down 1=up
        /// </summary>
        public IXPDataRef<float> rotor_trim { get { return m_data.GetFloat("sim/cockpit2/controls/rotor_trim");} }

        /// <summary>
        ///  Deployment of the water rudder, 0 is none, 1 is max
        /// </summary>
        public IXPDataRef<float> water_rudder_handle_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/water_rudder_handle_ratio");} }

        /// <summary>
        ///  This is how far the indicator of flap deployment has moved in the cockpit.
        /// </summary>
        public IXPDataRef<float> flap_handle_deploy_ratio { get { return m_data.GetFloat("sim/cockpit2/controls/flap_handle_deploy_ratio");} }
    }
}