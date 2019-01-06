using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_WingDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_WingDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Deflection of the aileron from set #1 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Aileron1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/aileron1_deg");} }

        /// <summary>
        ///  Deflection of the aileron from set #2 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Aileron2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/aileron2_deg");} }

        /// <summary>
        ///  Deflection of the roll-spoilerfrom set #1 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Spoiler1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/spoiler1_deg");} }

        /// <summary>
        ///  Deflection of the roll-spoilerfrom set #1 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Spoiler2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/spoiler2_deg");} }

        /// <summary>
        ///  Deflection of the yaw-brake on this wing. A yaw-brake is a set of spoilers on the top and bottom of the wing that split open symmetrically to drag that wing aft and yaw the plane. They are used on the B-2, for example.
        /// </summary>
        public IXPDataRef<float[]> Yawbrake_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/yawbrake_deg");} }

        /// <summary>
        ///  Deflection of the elevator from set #1 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Elevator1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/elevator1_deg");} }

        /// <summary>
        ///  Deflection of the elevator from set #2 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Elevator2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/elevator2_deg");} }

        /// <summary>
        ///  Deflection of the rudder from set #1 on this wing. Degrees, positive is trailing-edge right.
        /// </summary>
        public IXPDataRef<float[]> Rudder1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/rudder1_deg");} }

        /// <summary>
        ///  Deflection of the rudder from set #2 on this wing. Degrees, positive is trailing-edge right.
        /// </summary>
        public IXPDataRef<float[]> Rudder2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/rudder2_deg");} }

        /// <summary>
        ///  Deflection of the flap from set #1 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Flap1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/flap1_deg");} }

        /// <summary>
        ///  Deflection of the flap from set #2 on this wing. Degrees, positive is trailing-edge down.
        /// </summary>
        public IXPDataRef<float[]> Flap2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/flap2_deg");} }

        /// <summary>
        ///  Deflection of the speedbrakes from set #1 on this wing.
        /// </summary>
        public IXPDataRef<float[]> Speedbrake1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/speedbrake1_deg");} }

        /// <summary>
        ///  Deflection of the speedbrakes from set #2 on this wing.
        /// </summary>
        public IXPDataRef<float[]> Speedbrake2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/speedbrake2_deg");} }

        /// <summary>
        ///  Degrees of deflection of a line from the wing root (extended to the plane centerline) to the tip.
        /// </summary>
        public IXPDataRef<float[]> Wing_tip_deflection_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/wing_tip_deflection_deg");} }
    }
}