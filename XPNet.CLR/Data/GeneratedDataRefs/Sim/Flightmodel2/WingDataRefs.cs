using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_wingDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_wingDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Deflection of the aileron from set #1 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/aileron1_deg
        /// </summary>
        public IXPDataRef<float[]> aileron1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/aileron1_deg");} }

        /// <summary>
        ///  Deflection of the aileron from set #2 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/aileron2_deg
        /// </summary>
        public IXPDataRef<float[]> aileron2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/aileron2_deg");} }

        /// <summary>
        ///  Deflection of the roll-spoilerfrom set #1 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/spoiler1_deg
        /// </summary>
        public IXPDataRef<float[]> spoiler1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/spoiler1_deg");} }

        /// <summary>
        ///  Deflection of the roll-spoilerfrom set #1 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/spoiler2_deg
        /// </summary>
        public IXPDataRef<float[]> spoiler2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/spoiler2_deg");} }

        /// <summary>
        ///  Deflection of the yaw-brake on this wing. A yaw-brake is a set of spoilers on the top and bottom of the wing that split open symmetrically to drag that wing aft and yaw the plane. They are used on the B-2, for example.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/yawbrake_deg
        /// </summary>
        public IXPDataRef<float[]> yawbrake_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/yawbrake_deg");} }

        /// <summary>
        ///  Deflection of the elevator from set #1 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/elevator1_deg
        /// </summary>
        public IXPDataRef<float[]> elevator1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/elevator1_deg");} }

        /// <summary>
        ///  Deflection of the elevator from set #2 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/elevator2_deg
        /// </summary>
        public IXPDataRef<float[]> elevator2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/elevator2_deg");} }

        /// <summary>
        ///  Deflection of the rudder from set #1 on this wing. Degrees, positive is trailing-edge right.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/rudder1_deg
        /// </summary>
        public IXPDataRef<float[]> rudder1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/rudder1_deg");} }

        /// <summary>
        ///  Deflection of the rudder from set #2 on this wing. Degrees, positive is trailing-edge right.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/rudder2_deg
        /// </summary>
        public IXPDataRef<float[]> rudder2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/rudder2_deg");} }

        /// <summary>
        ///  Deflection of the flap from set #1 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/flap1_deg
        /// </summary>
        public IXPDataRef<float[]> flap1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/flap1_deg");} }

        /// <summary>
        ///  Deflection of the flap from set #2 on this wing. Degrees, positive is trailing-edge down.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/flap2_deg
        /// </summary>
        public IXPDataRef<float[]> flap2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/flap2_deg");} }

        /// <summary>
        ///  Deflection of the speedbrakes from set #1 on this wing.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/speedbrake1_deg
        /// </summary>
        public IXPDataRef<float[]> speedbrake1_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/speedbrake1_deg");} }

        /// <summary>
        ///  Deflection of the speedbrakes from set #2 on this wing.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/speedbrake2_deg
        /// </summary>
        public IXPDataRef<float[]> speedbrake2_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/speedbrake2_deg");} }

        /// <summary>
        ///  Degrees of deflection of a line from the wing root (extended to the plane centerline) to the tip.. Units:degrees
        ///  Raw path: sim/flightmodel2/wing/wing_tip_deflection_deg
        /// </summary>
        public IXPDataRef<float[]> wing_tip_deflection_deg { get { return m_data.GetFloatArray("sim/flightmodel2/wing/wing_tip_deflection_deg");} }
    }
}