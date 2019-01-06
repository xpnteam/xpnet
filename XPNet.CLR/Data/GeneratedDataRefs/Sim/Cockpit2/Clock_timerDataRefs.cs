using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Clock_timerDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Clock_timerDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  True if timer is running
        /// </summary>
        public IXPDataRef<bool> Timer_running { get { return m_data.GetBool("sim/cockpit2/clock_timer/timer_running");} }

        /// <summary>
        ///  True if time shown is GMT
        /// </summary>
        public IXPDataRef<bool> Timer_is_GMT { get { return m_data.GetBool("sim/cockpit2/clock_timer/timer_is_gmt");} }

        /// <summary>
        ///  True if date is showing (date button pressed recently)
        /// </summary>
        public IXPDataRef<bool> Date_is_showing { get { return m_data.GetBool("sim/cockpit2/clock_timer/date_is_showing");} }
    }
}