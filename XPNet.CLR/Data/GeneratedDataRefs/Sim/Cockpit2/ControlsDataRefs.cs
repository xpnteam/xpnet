using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_ControlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_ControlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is how much the yoke is deflected in the cockpit, in ratio, where -1.0 is full down, and 1.0 is full up.. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Yoke_pitch_ratio => m_data.GetFloat("sim/cockpit2/controls/yoke_pitch_ratio");

        /// <summary>
        ///  This is how much the yoke is deflected in the cockpit, in ratio, where -1.0 is full left, and 1.0 is full right.. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Yoke_roll_ratio => m_data.GetFloat("sim/cockpit2/controls/yoke_roll_ratio");

        /// <summary>
        ///  This is how much the rudder is deflected in the cockpit, in ratio, where -1.0 is full left, and 1.0 is full right.. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Yoke_heading_ratio => m_data.GetFloat("sim/cockpit2/controls/yoke_heading_ratio");

        /// <summary>
        ///  This is how much the speebrake HANDLE is deflected, in ratio, where 0.0 is fully retracted, 0.5 is halfway down, and 1.0 is fully down, and -0.5 is speedbrakes ARMED.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Speedbrake_ratio => m_data.GetFloat("sim/cockpit2/controls/speedbrake_ratio");

        /// <summary>
        ///  Requested sweep, in ratio. 0.0 is no sweep requested, 1 is max sweep requested.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wingsweep_ratio => m_data.GetFloat("sim/cockpit2/controls/wingsweep_ratio");

        /// <summary>
        ///  Requested thrust vector, in ratio. 0.0 is no thrust vector requested, 1 is max thrust vector requested.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Thrust_vector_ratio => m_data.GetFloat("sim/cockpit2/controls/thrust_vector_ratio");

        /// <summary>
        ///  Requested dihedral, in ratio. 0.0 is no dihedral requested, 1 is max dihedral requested.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Dihedral_ratio => m_data.GetFloat("sim/cockpit2/controls/dihedral_ratio");

        /// <summary>
        ///  Requested incidence, in ratio. 0.0 is no incidence requested, 1 is max incidence requested.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Incidence_ratio => m_data.GetFloat("sim/cockpit2/controls/incidence_ratio");

        /// <summary>
        ///  Requested wing-retraction, in ratio. 0.0 is no wing-retraction requested, 1 is max wing-retraction requested.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing_retraction_ratio => m_data.GetFloat("sim/cockpit2/controls/wing_retraction_ratio");

        /// <summary>
        ///  This is the flap HANDLE location, in ratio, where 0.0 is handle fully retracted, and 1.0 is handle fully extended.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Flap_ratio => m_data.GetFloat("sim/cockpit2/controls/flap_ratio");

        /// <summary>
        ///  This is the overall brake requested by the parking brake button... 0.0 is none, 1.0 is complete.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Parking_brake_ratio => m_data.GetFloat("sim/cockpit2/controls/parking_brake_ratio");

        /// <summary>
        ///  This is additional left brake requested by pedal deflection, 0.0 to 1.0.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Left_brake_ratio => m_data.GetFloat("sim/cockpit2/controls/left_brake_ratio");

        /// <summary>
        ///  This is additional right brake requested by pedal deflection, 0.0 to 1.0.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Right_brake_ratio => m_data.GetFloat("sim/cockpit2/controls/right_brake_ratio");

        /// <summary>
        ///  Tail-wheel lockig ratio. 0 for free-castoring, 1 for totally locked.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Tailwheel_lock_ratio => m_data.GetFloat("sim/cockpit2/controls/tailwheel_lock_ratio");

        /// <summary>
        ///  Aileron trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the aileron trim is deflected enough to move the ailerons through 30% of their travel, then that is an aileron trim of 0.3. -1=left 1=right. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Aileron_trim => m_data.GetFloat("sim/cockpit2/controls/aileron_trim");

        /// <summary>
        ///  Elevator trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the elevator trim is deflected enough to move the elevators through 30% of their travel, then that is an elevator trim of 0.3. -1=down 1=up. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Elevator_trim => m_data.GetFloat("sim/cockpit2/controls/elevator_trim");

        /// <summary>
        ///  Rudder trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the rudder trim is deflected enough to move the rudders through 30% of their travel, then that is an rudder trim of 0.3. -1=left 1=right. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Rudder_trim => m_data.GetFloat("sim/cockpit2/controls/rudder_trim");

        /// <summary>
        ///  Rotor trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the rotor trim is deflected enough to move the rotor through 30% of its travel, then that is a rotor trim of 0.3. -1=down 1=up. Units:-1..1
        /// </summary>
        public IXPDataRef<float> Rotor_trim => m_data.GetFloat("sim/cockpit2/controls/rotor_trim");

        /// <summary>
        ///  Deployment of the water rudder, 0 is none, 1 is max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Water_rudder_handle_ratio => m_data.GetFloat("sim/cockpit2/controls/water_rudder_handle_ratio");

        /// <summary>
        ///  This is how far the indicator of flap deployment has moved in the cockpit.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Flap_handle_deploy_ratio => m_data.GetFloat("sim/cockpit2/controls/flap_handle_deploy_ratio");
    }
}