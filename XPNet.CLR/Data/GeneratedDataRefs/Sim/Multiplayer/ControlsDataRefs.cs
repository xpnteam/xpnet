using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_multiplayer_controlsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_multiplayer_controlsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The deflection of the axis controlling pitch.. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/yoke_pitch_ratio
        /// </summary>
        public IXPDataRef<float[]> yoke_pitch_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/yoke_pitch_ratio");} }

        /// <summary>
        ///  The deflection of the axis controlling roll.. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/yoke_roll_ratio
        /// </summary>
        public IXPDataRef<float[]> yoke_roll_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/yoke_roll_ratio");} }

        /// <summary>
        ///  The deflection of the axis controlling yaw.. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/yoke_heading_ratio
        /// </summary>
        public IXPDataRef<float[]> yoke_heading_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/yoke_heading_ratio");} }

        /// <summary>
        ///  0 = up, 1 = down. Units:enum
        ///  Raw path: sim/multiplayer/controls/gear_request
        /// </summary>
        public IXPDataRef<int[]> gear_request { get { return m_data.GetIntArray("sim/multiplayer/controls/gear_request");} }

        /// <summary>
        ///  Requested flap deployment. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/flap_request
        /// </summary>
        public IXPDataRef<float[]> flap_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/flap_request");} }

        /// <summary>
        ///  Speed Brake. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/speed_brake_request
        /// </summary>
        public IXPDataRef<float[]> speed_brake_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/speed_brake_request");} }

        /// <summary>
        ///  Vectored Thrust. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/vector_request
        /// </summary>
        public IXPDataRef<float[]> vector_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/vector_request");} }

        /// <summary>
        ///  Wing Sweep. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/sweep__request
        /// </summary>
        public IXPDataRef<float[]> sweep__request { get { return m_data.GetFloatArray("sim/multiplayer/controls/sweep__request");} }

        /// <summary>
        ///  Variable Wing Incidence. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/incidence_request
        /// </summary>
        public IXPDataRef<float[]> incidence_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/incidence_request");} }

        /// <summary>
        ///  Variable Wing Dihedral. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/dihedral_request
        /// </summary>
        public IXPDataRef<float[]> dihedral_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/dihedral_request");} }

        /// <summary>
        ///  This is how locked the tail-wheel is ... 0 is free castoring, 1 is locked.. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/tail_lock_ratio
        /// </summary>
        public IXPDataRef<float[]> tail_lock_ratio { get { return m_data.GetFloatArray("sim/multiplayer/controls/tail_lock_ratio");} }

        /// <summary>
        ///  Left Brake (off to max braking). Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/l_brake_add
        /// </summary>
        public IXPDataRef<float[]> l_brake_add { get { return m_data.GetFloatArray("sim/multiplayer/controls/l_brake_add");} }

        /// <summary>
        ///  Right Brake (off to max braking). Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/r_brake_add
        /// </summary>
        public IXPDataRef<float[]> r_brake_add { get { return m_data.GetFloatArray("sim/multiplayer/controls/r_brake_add");} }

        /// <summary>
        ///  Parking Brake (off to max braking). Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/parking_brake
        /// </summary>
        public IXPDataRef<float[]> parking_brake { get { return m_data.GetFloatArray("sim/multiplayer/controls/parking_brake");} }

        /// <summary>
        ///  Aileron Trim (as ratio of full control surface deflection) -1=left,1=right. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/aileron_trim
        /// </summary>
        public IXPDataRef<float[]> aileron_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/aileron_trim");} }

        /// <summary>
        ///  Elevation Trim (as ratio of full control surface deflection) -1=down,1=up. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/elevator_trim
        /// </summary>
        public IXPDataRef<float[]> elevator_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/elevator_trim");} }

        /// <summary>
        ///  Rotor Trim (as ratio of full control surface deflection) -1=nose down,1=nose up. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/rotor_trim
        /// </summary>
        public IXPDataRef<float[]> rotor_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/rotor_trim");} }

        /// <summary>
        ///  Rudder Trim (as ratio of full control surface deflection) -1=left,1=right. Units:[-1..1]
        ///  Raw path: sim/multiplayer/controls/rudder_trim
        /// </summary>
        public IXPDataRef<float[]> rudder_trim { get { return m_data.GetFloatArray("sim/multiplayer/controls/rudder_trim");} }

        /// <summary>
        ///  Requested Throttle Position. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/engine_throttle_request
        /// </summary>
        public IXPDataRef<float[]> engine_throttle_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_throttle_request");} }

        /// <summary>
        ///  Requested Prop Position. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/engine_prop_request
        /// </summary>
        public IXPDataRef<float[]> engine_prop_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_prop_request");} }

        /// <summary>
        ///  Requested Pitch Position. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/engine_pitch_request
        /// </summary>
        public IXPDataRef<float[]> engine_pitch_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_pitch_request");} }

        /// <summary>
        ///  Requested Mixture Position. Units:[0..1]
        ///  Raw path: sim/multiplayer/controls/engine_mixture_request
        /// </summary>
        public IXPDataRef<float[]> engine_mixture_request { get { return m_data.GetFloatArray("sim/multiplayer/controls/engine_mixture_request");} }
    }
}