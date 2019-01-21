using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_controlsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_controlsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is how much the flight controls are deflected in pitch after any stability augmentation, in ratio, where -1.0 is full down, and 1.0 is full up.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/pitch_ratio
        /// </summary>
        public IXPDataRef<float> pitch_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/pitch_ratio");} }

        /// <summary>
        ///  This is how much the flight controls are deflected in roll after any stability augmentation, in ratio, where -1.0 is full left, and 1.0 is full right.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/roll_ratio
        /// </summary>
        public IXPDataRef<float> roll_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/roll_ratio");} }

        /// <summary>
        ///  This is how much the flight controls are deflected in heading after any stability augmentation, where -1.0 is full left, and 1.0 is full right.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/heading_ratio
        /// </summary>
        public IXPDataRef<float> heading_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/heading_ratio");} }

        /// <summary>
        ///  This is how much the speedbrakes surfaces are extended, in ratio, where 0.0 is fully retracted, and 1.0 is fully extended.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/speedbrake_ratio
        /// </summary>
        public IXPDataRef<float> speedbrake_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/speedbrake_ratio");} }

        /// <summary>
        ///  Actual sweep, in ratio. 0.0 is no sweep deployment, 1 is max sweep deployment.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/wingsweep_ratio
        /// </summary>
        public IXPDataRef<float> wingsweep_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/wingsweep_ratio");} }

        /// <summary>
        ///  Actual thrust vector, in ratio. 0.0 is no thrust vector deployment, 1 is max thrust vector deployment.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/thrust_vector_ratio
        /// </summary>
        public IXPDataRef<float> thrust_vector_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/thrust_vector_ratio");} }

        /// <summary>
        ///  Actual dihedral, in ratio. 0.0 is no dihedral deployment, 1 is max dihedral deployment.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/dihedral_ratio
        /// </summary>
        public IXPDataRef<float> dihedral_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/dihedral_ratio");} }

        /// <summary>
        ///  Actual incidence, in ratio. 0.0 is no incidence deployment, 1 is max incidence deployment.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/incidence_ratio
        /// </summary>
        public IXPDataRef<float> incidence_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/incidence_ratio");} }

        /// <summary>
        ///  Actual wing-retraction, in ratio. 0.0 is no wing-retraction deployment, 1 is max wing-retraction deployment.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/wing_retraction_ratio
        /// </summary>
        public IXPDataRef<float> wing_retraction_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/wing_retraction_ratio");} }

        /// <summary>
        ///  This is the ACTUAL FLAP deployment for overall flap system, in ratio, where 0.0 is flaps fully retracted, and 1.0 is flaps fully extended. You should probably use the deployment for flap set 1 or flap set 2 to deflect the surfaces though.  This takes into account that flaps deploy slowly, not instantaneously as the handle is dragged.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/flap_handle_deploy_ratio
        /// </summary>
        public IXPDataRef<float> flap_handle_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/flap_handle_deploy_ratio");} }

        /// <summary>
        ///  Slat deployment, where 0.0 is slats fully retracted, 1.0 is slats fully extended. This variable applies to lading-edge flaps as well.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/slat1_deploy_ratio
        /// </summary>
        public IXPDataRef<float> slat1_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/slat1_deploy_ratio");} }

        /// <summary>
        ///  Slat deployment, where 0.0 is slats fully retracted, 1.0 is slats fully extended. This variable applies to lading-edge flaps as well.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/slat2_deploy_ratio
        /// </summary>
        public IXPDataRef<float> slat2_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/slat2_deploy_ratio");} }

        /// <summary>
        ///  This is the ACTUAL FLAP deployment for flap-set #1, in ratio, where 0.0 is flaps fully retracted, and 1.0 is flaps fully extended.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/flap1_deploy_ratio
        /// </summary>
        public IXPDataRef<float> flap1_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/flap1_deploy_ratio");} }

        /// <summary>
        ///  This is the ACTUAL FLAP deployment for flap-set #2, in ratio, where 0.0 is flaps fully retracted, and 1.0 is flaps fully extended.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/flap2_deploy_ratio
        /// </summary>
        public IXPDataRef<float> flap2_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/flap2_deploy_ratio");} }

        /// <summary>
        ///  This is the actual stabilizer deflection with trim for all-moving horizontal stabilizers. This is the deflection you can see visually on airliners. This is in degrees, positive for leading-edge nose up.. Units:degrees
        ///  Raw path: sim/flightmodel2/controls/stabilizer_deflection_degrees
        /// </summary>
        public IXPDataRef<float> stabilizer_deflection_degrees { get { return m_data.GetFloat("sim/flightmodel2/controls/stabilizer_deflection_degrees");} }

        /// <summary>
        ///  Aileron trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the aileron trim is deflected enough to move the ailerons through 30% of their travel, then that is an aileron trim of 0.3.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/aileron_trim
        /// </summary>
        public IXPDataRef<float> aileron_trim { get { return m_data.GetFloat("sim/flightmodel2/controls/aileron_trim");} }

        /// <summary>
        ///  Elevator trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the elevator trim is deflected enough to move the elevators through 30% of their travel, then that is an elevator trim of 0.3.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/elevator_trim
        /// </summary>
        public IXPDataRef<float> elevator_trim { get { return m_data.GetFloat("sim/flightmodel2/controls/elevator_trim");} }

        /// <summary>
        ///  Rudder trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the rudder trim is deflected enough to move the rudders through 30% of their travel, then that is an rudder trim of 0.3.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/rudder_trim
        /// </summary>
        public IXPDataRef<float> rudder_trim { get { return m_data.GetFloat("sim/flightmodel2/controls/rudder_trim");} }

        /// <summary>
        ///  Rotor trim, in part of MAX FLIGHT CONTROL DEFLECTION. So, if the rotor trim is deflected enough to move the rotor through 30% of its travel, then that is a rotor trim of 0.3.. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/rotor_trim
        /// </summary>
        public IXPDataRef<float> rotor_trim { get { return m_data.GetFloat("sim/flightmodel2/controls/rotor_trim");} }

        /// <summary>
        ///  Deployment of the water rudder, 0 is none, 1 is max. Units:ratio
        ///  Raw path: sim/flightmodel2/controls/water_rudder_deploy_ratio
        /// </summary>
        public IXPDataRef<float> water_rudder_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/controls/water_rudder_deploy_ratio");} }
    }
}