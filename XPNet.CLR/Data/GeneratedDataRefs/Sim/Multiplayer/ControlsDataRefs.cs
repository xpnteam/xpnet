using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Multiplayer_ControlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Multiplayer_ControlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The deflection of the axis controlling pitch.
        /// </summary>
        public IXPDataRef<float[]> Yoke_pitch_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/yoke_pitch_ratio");} }

        /// <summary>
        ///  The deflection of the axis controlling roll.
        /// </summary>
        public IXPDataRef<float[]> Yoke_roll_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/yoke_roll_ratio");} }

        /// <summary>
        ///  The deflection of the axis controlling yaw.
        /// </summary>
        public IXPDataRef<float[]> Yoke_heading_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/yoke_heading_ratio");} }

        /// <summary>
        ///  Requested flap deployment
        /// </summary>
        public IXPDataRef<float[]> Flap_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/flap_request");} }

        /// <summary>
        ///  Speed Brake
        /// </summary>
        public IXPDataRef<float[]> Speed_brake_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/speed_brake_request");} }

        /// <summary>
        ///  Vectored Thrust
        /// </summary>
        public IXPDataRef<float[]> Vector_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/vector_request");} }

        /// <summary>
        ///  Wing Sweep
        /// </summary>
        public IXPDataRef<float[]> Sweep__request { get { return m_data.GetFloatArray("sim/multiplayer/controls/sweep__request");} }

        /// <summary>
        ///  Variable Wing Incidence
        /// </summary>
        public IXPDataRef<float[]> Incidence_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/incidence_request");} }

        /// <summary>
        ///  Variable Wing Dihedral
        /// </summary>
        public IXPDataRef<float[]> Dihedral_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/dihedral_request");} }

        /// <summary>
        ///  This is how locked the tail-wheel is ... 0 is free castoring, 1 is locked.
        /// </summary>
        public IXPDataRef<float[]> Tail_lock_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/tail_lock_ratio");} }

        /// <summary>
        ///  Left Brake (off to max braking)
        /// </summary>
        public IXPDataRef<float[]> L_brake_add { get { return m_data.GetFloatArray("sim/multiplayer/controls/l_brake_add");} }

        /// <summary>
        ///  Right Brake (off to max braking)
        /// </summary>
        public IXPDataRef<float[]> R_brake_add { get { return m_data.GetFloatArray("sim/multiplayer/controls/r_brake_add");} }

        /// <summary>
        ///  Parking Brake (off to max braking)
        /// </summary>
        public IXPDataRef<float[]> Parking_brake { get { return m_data.GetFloatArray("sim/multiplayer/controls/parking_brake");} }

        /// <summary>
        ///  Aileron Trim (as ratio of full control surface deflection) -1=left,1=right
        /// </summary>
        public IXPDataRef<float[]> Aileron_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/aileron_trim");} }

        /// <summary>
        ///  Elevation Trim (as ratio of full control surface deflection) -1=down,1=up
        /// </summary>
        public IXPDataRef<float[]> Elevator_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/elevator_trim");} }

        /// <summary>
        ///  Rotor Trim (as ratio of full control surface deflection) -1=nose down,1=nose up
        /// </summary>
        public IXPDataRef<float[]> Rotor_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/rotor_trim");} }

        /// <summary>
        ///  Rudder Trim (as ratio of full control surface deflection) -1=left,1=right
        /// </summary>
        public IXPDataRef<float[]> Rudder_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/rudder_trim");} }

        /// <summary>
        ///  Requested Throttle Position
        /// </summary>
        public IXPDataRef<float[]> Engine_throttle_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_throttle_request");} }

        /// <summary>
        ///  Requested Prop Position
        /// </summary>
        public IXPDataRef<float[]> Engine_prop_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_prop_request");} }

        /// <summary>
        ///  Requested Pitch Position
        /// </summary>
        public IXPDataRef<float[]> Engine_pitch_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_pitch_request");} }

        /// <summary>
        ///  Requested Mixture Position
        /// </summary>
        public IXPDataRef<float[]> Engine_mixture_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_mixture_request");} }
    }
}