using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_DoorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_DoorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Current angle about the axis of rotation of this gear door, degrees.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Angle_now_deg => m_data.GetFloatArray("sim/flightmodel2/doors/angle_now_deg");
    }
}