using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Enable logging of network data
        /// </summary>
        public IXPDataRef<bool> debug_network { get { return m_data.GetBool("sim/operation/misc/debug_network");} }

        /// <summary>
        ///  The frame rate period. Use the reciprocal to get the frame rate (e.g. 1/mnw.prd)
        /// </summary>
        public IXPDataRef<float> frame_rate_period { get { return m_data.GetFloat("sim/operation/misc/frame_rate_period");} }

        /// <summary>
        ///  This is how close XP time matches real time. Ideal ratio is 1.  NOTE: in 930 and later time ratio is always 1.0.
        /// </summary>
        public IXPDataRef<float> time_ratio { get { return m_data.GetFloat("sim/operation/misc/time_ratio");} }
    }
}