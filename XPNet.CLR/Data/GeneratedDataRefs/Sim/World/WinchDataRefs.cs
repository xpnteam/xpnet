using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_World_WinchDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_World_WinchDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is how long it takes the winch to reach maximum speed for a glider winch take-off.
        /// </summary>
        public IXPDataRef<float> Winch_ramp_up_time_sec { get { return m_data.GetFloat("sim/world/winch/winch_ramp_up_time_sec");} }

        /// <summary>
        ///  This is how fast the winch moves at its maximum speed.
        /// </summary>
        public IXPDataRef<float> Winch_speed_knots { get { return m_data.GetFloat("sim/world/winch/winch_speed_knots");} }

        /// <summary>
        ///  This is the initial length of cable for a winch takeoff.
        /// </summary>
        public IXPDataRef<float> Winch_initial_length { get { return m_data.GetFloat("sim/world/winch/winch_initial_length");} }

        /// <summary>
        ///  This is the maximum horsepower the winch can deliver reeling in the cable. Cable speed will decay with higher force on the cable to not exceed this limit.
        /// </summary>
        public IXPDataRef<float> Winch_max_bhp { get { return m_data.GetFloat("sim/world/winch/winch_max_bhp");} }
    }
}