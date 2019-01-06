using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_doorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_doorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  0=unused (plane does not use this door) 1=standard (opens before gear goes down) 2=attached to strut (cycles with door), 3=closed (opens before gear goes down, then closes again)
        /// </summary>
        public IXPDataRef<int[]> type { get { return m_data.GetIntArray("sim/flightmodel2/doors/type");} }

        /// <summary>
        ///  Current angle about the axis of rotation of this gear door, degrees.
        /// </summary>
        public IXPDataRef<float[]> angle_now_deg { get { return m_data.GetFloatArray("sim/flightmodel2/doors/angle_now_deg");} }
    }
}