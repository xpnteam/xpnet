using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_clock_timerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_clock_timerDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  True if timer is running
        /// </summary>
        public IXPDataRef<bool> timer_running { get { return m_data.GetBool("sim/cockpit2/clock_timer/timer_running");} }

        /// <summary>
        ///  True if time shown is GMT
        /// </summary>
        public IXPDataRef<bool> timer_is_GMT { get { return m_data.GetBool("sim/cockpit2/clock_timer/timer_is_gmt");} }

        /// <summary>
        ///  True if date is showing (date button pressed recently)
        /// </summary>
        public IXPDataRef<bool> date_is_showing { get { return m_data.GetBool("sim/cockpit2/clock_timer/date_is_showing");} }
    }
}