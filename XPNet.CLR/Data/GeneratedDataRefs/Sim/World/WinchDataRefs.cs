using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_world_winchDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_world_winchDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is how long it takes the winch to reach maximum speed for a glider winch take-off.. Units:seconds
        ///  Raw path: sim/world/winch/winch_ramp_up_time_sec
        /// </summary>
        public IXPDataRef<float> winch_ramp_up_time_sec { get { return m_data.GetFloat("sim/world/winch/winch_ramp_up_time_sec");} }

        /// <summary>
        ///  This is how fast the winch moves at its maximum speed.. Units:knots
        ///  Raw path: sim/world/winch/winch_speed_knots
        /// </summary>
        public IXPDataRef<float> winch_speed_knots { get { return m_data.GetFloat("sim/world/winch/winch_speed_knots");} }

        /// <summary>
        ///  This is the initial length of cable for a winch takeoff.. Units:meters
        ///  Raw path: sim/world/winch/winch_initial_length
        /// </summary>
        public IXPDataRef<float> winch_initial_length { get { return m_data.GetFloat("sim/world/winch/winch_initial_length");} }

        /// <summary>
        ///  This is the maximum horsepower the winch can deliver reeling in the cable. Cable speed will decay with higher force on the cable to not exceed this limit.. Units:bhp
        ///  Raw path: sim/world/winch/winch_max_bhp
        /// </summary>
        public IXPDataRef<float> winch_max_bhp { get { return m_data.GetFloat("sim/world/winch/winch_max_bhp");} }
    }
}