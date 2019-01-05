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
        ///  The deflection of the axis controlling pitch.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Yoke_pitch_ratio => m_data.GetFloatArray("sim/multiplayer/controls/yoke_pitch_ratio");

        /// <summary>
        ///  The deflection of the axis controlling roll.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Yoke_roll_ratio => m_data.GetFloatArray("sim/multiplayer/controls/yoke_roll_ratio");

        /// <summary>
        ///  The deflection of the axis controlling yaw.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Yoke_heading_ratio => m_data.GetFloatArray("sim/multiplayer/controls/yoke_heading_ratio");

        /// <summary>
        ///  Requested flap deployment. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Flap_request => m_data.GetFloatArray("sim/multiplayer/controls/flap_request");

        /// <summary>
        ///  Speed Brake. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Speed_brake_request => m_data.GetFloatArray("sim/multiplayer/controls/speed_brake_request");

        /// <summary>
        ///  Vectored Thrust. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Vector_request => m_data.GetFloatArray("sim/multiplayer/controls/vector_request");

        /// <summary>
        ///  Wing Sweep. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Sweep__request => m_data.GetFloatArray("sim/multiplayer/controls/sweep__request");

        /// <summary>
        ///  Variable Wing Incidence. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Incidence_request => m_data.GetFloatArray("sim/multiplayer/controls/incidence_request");

        /// <summary>
        ///  Variable Wing Dihedral. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Dihedral_request => m_data.GetFloatArray("sim/multiplayer/controls/dihedral_request");

        /// <summary>
        ///  This is how locked the tail-wheel is ... 0 is free castoring, 1 is locked.. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Tail_lock_ratio => m_data.GetFloatArray("sim/multiplayer/controls/tail_lock_ratio");

        /// <summary>
        ///  Left Brake (off to max braking). Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> L_brake_add => m_data.GetFloatArray("sim/multiplayer/controls/l_brake_add");

        /// <summary>
        ///  Right Brake (off to max braking). Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> R_brake_add => m_data.GetFloatArray("sim/multiplayer/controls/r_brake_add");

        /// <summary>
        ///  Parking Brake (off to max braking). Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Parking_brake => m_data.GetFloatArray("sim/multiplayer/controls/parking_brake");

        /// <summary>
        ///  Aileron Trim (as ratio of full control surface deflection) -1=left,1=right. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Aileron_trim => m_data.GetFloatArray("sim/multiplayer/controls/aileron_trim");

        /// <summary>
        ///  Elevation Trim (as ratio of full control surface deflection) -1=down,1=up. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Elevator_trim => m_data.GetFloatArray("sim/multiplayer/controls/elevator_trim");

        /// <summary>
        ///  Rotor Trim (as ratio of full control surface deflection) -1=nose down,1=nose up. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Rotor_trim => m_data.GetFloatArray("sim/multiplayer/controls/rotor_trim");

        /// <summary>
        ///  Rudder Trim (as ratio of full control surface deflection) -1=left,1=right. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float[]> Rudder_trim => m_data.GetFloatArray("sim/multiplayer/controls/rudder_trim");

        /// <summary>
        ///  Requested Throttle Position. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Engine_throttle_request => m_data.GetFloatArray("sim/multiplayer/controls/engine_throttle_request");

        /// <summary>
        ///  Requested Prop Position. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Engine_prop_request => m_data.GetFloatArray("sim/multiplayer/controls/engine_prop_request");

        /// <summary>
        ///  Requested Pitch Position. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Engine_pitch_request => m_data.GetFloatArray("sim/multiplayer/controls/engine_pitch_request");

        /// <summary>
        ///  Requested Mixture Position. Units:[0..1]
        /// </summary>
        public IXPDataRef<float[]> Engine_mixture_request => m_data.GetFloatArray("sim/multiplayer/controls/engine_mixture_request");
    }
}