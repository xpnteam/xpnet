using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Enable logging of network data
        /// </summary>
        public IXPDataRef<bool> Debug_network { get { return m_data.GetBool("sim/operation/misc/debug_network");} }

        /// <summary>
        ///  The frame rate period. Use the reciprocal to get the frame rate (e.g. 1/Mnw.prd)
        /// </summary>
        public IXPDataRef<float> Frame_rate_period { get { return m_data.GetFloat("sim/operation/misc/frame_rate_period");} }

        /// <summary>
        ///  This is how close XP time matches real time. Ideal ratio is 1.  NOTE: in 930 and later time ratio is always 1.0.
        /// </summary>
        public IXPDataRef<float> Time_ratio { get { return m_data.GetFloat("sim/operation/misc/time_ratio");} }
    }
}