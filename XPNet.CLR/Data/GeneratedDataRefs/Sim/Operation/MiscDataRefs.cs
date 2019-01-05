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
        ///  The frame rate period. Use the reciprocal to get the frame rate (e.g. 1/Mnw.prd). Units:secs
        /// </summary>
        public IXPDataRef<float> Frame_rate_period => m_data.GetFloat("sim/operation/misc/frame_rate_period");

        /// <summary>
        ///  This is how close XP time matches real time. Ideal ratio is 1.  NOTE: in 930 and later time ratio is always 1.0.. Units:secs
        /// </summary>
        public IXPDataRef<float> Time_ratio => m_data.GetFloat("sim/operation/misc/time_ratio");
    }
}