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
        ///  Elapsed time on the timer, hours. Units:hours
        ///  Raw path: sim/cockpit2/clock_timer/elapsed_time_hours
        /// </summary>
        public IXPDataRef<int> elapsed_time_hours { get { return m_data.GetInt("sim/cockpit2/clock_timer/elapsed_time_hours");} }

        /// <summary>
        ///  Elapsed time on the timer, minutes. Units:minutes
        ///  Raw path: sim/cockpit2/clock_timer/elapsed_time_minutes
        /// </summary>
        public IXPDataRef<int> elapsed_time_minutes { get { return m_data.GetInt("sim/cockpit2/clock_timer/elapsed_time_minutes");} }

        /// <summary>
        ///  Elapsed time on the timer, seconds. Units:seconds
        ///  Raw path: sim/cockpit2/clock_timer/elapsed_time_seconds
        /// </summary>
        public IXPDataRef<int> elapsed_time_seconds { get { return m_data.GetInt("sim/cockpit2/clock_timer/elapsed_time_seconds");} }

        /// <summary>
        ///  Zulu time, hours. Units:hours
        ///  Raw path: sim/cockpit2/clock_timer/zulu_time_hours
        /// </summary>
        public IXPDataRef<int> zulu_time_hours { get { return m_data.GetInt("sim/cockpit2/clock_timer/zulu_time_hours");} }

        /// <summary>
        ///  Zulu time, minutes. Units:minutes
        ///  Raw path: sim/cockpit2/clock_timer/zulu_time_minutes
        /// </summary>
        public IXPDataRef<int> zulu_time_minutes { get { return m_data.GetInt("sim/cockpit2/clock_timer/zulu_time_minutes");} }

        /// <summary>
        ///  Zulu time, seconds. Units:seconds
        ///  Raw path: sim/cockpit2/clock_timer/zulu_time_seconds
        /// </summary>
        public IXPDataRef<int> zulu_time_seconds { get { return m_data.GetInt("sim/cockpit2/clock_timer/zulu_time_seconds");} }

        /// <summary>
        ///  Local time, hours. Units:hours
        ///  Raw path: sim/cockpit2/clock_timer/local_time_hours
        /// </summary>
        public IXPDataRef<int> local_time_hours { get { return m_data.GetInt("sim/cockpit2/clock_timer/local_time_hours");} }

        /// <summary>
        ///  Local time, minutes. Units:minutes
        ///  Raw path: sim/cockpit2/clock_timer/local_time_minutes
        /// </summary>
        public IXPDataRef<int> local_time_minutes { get { return m_data.GetInt("sim/cockpit2/clock_timer/local_time_minutes");} }

        /// <summary>
        ///  Local time, seconds. Units:seconds
        ///  Raw path: sim/cockpit2/clock_timer/local_time_seconds
        /// </summary>
        public IXPDataRef<int> local_time_seconds { get { return m_data.GetInt("sim/cockpit2/clock_timer/local_time_seconds");} }

        /// <summary>
        ///  Hobbs meter time, hours. Units:hours
        ///  Raw path: sim/cockpit2/clock_timer/hobbs_time_hours
        /// </summary>
        public IXPDataRef<int> hobbs_time_hours { get { return m_data.GetInt("sim/cockpit2/clock_timer/hobbs_time_hours");} }

        /// <summary>
        ///  Hobbs meter time, minutes. Units:minutes
        ///  Raw path: sim/cockpit2/clock_timer/hobbs_time_minutes
        /// </summary>
        public IXPDataRef<int> hobbs_time_minutes { get { return m_data.GetInt("sim/cockpit2/clock_timer/hobbs_time_minutes");} }

        /// <summary>
        ///  Hobbs meter time, seconds. Units:seconds
        ///  Raw path: sim/cockpit2/clock_timer/hobbs_time_seconds
        /// </summary>
        public IXPDataRef<int> hobbs_time_seconds { get { return m_data.GetInt("sim/cockpit2/clock_timer/hobbs_time_seconds");} }

        /// <summary>
        ///  True if timer is running. Units:boolean
        ///  Raw path: sim/cockpit2/clock_timer/timer_running
        /// </summary>
        public IXPDataRef<bool> timer_running { get { return m_data.GetBool("sim/cockpit2/clock_timer/timer_running");} }

        /// <summary>
        ///  True if time shown is GMT. Units:boolean
        ///  Raw path: sim/cockpit2/clock_timer/timer_is_GMT
        /// </summary>
        public IXPDataRef<bool> timer_is_GMT { get { return m_data.GetBool("sim/cockpit2/clock_timer/timer_is_gmt");} }

        /// <summary>
        ///  True if date is showing (date button pressed recently). Units:boolean
        ///  Raw path: sim/cockpit2/clock_timer/date_is_showing
        /// </summary>
        public IXPDataRef<bool> date_is_showing { get { return m_data.GetBool("sim/cockpit2/clock_timer/date_is_showing");} }

        /// <summary>
        ///  Numeric day of month. Units:day
        ///  Raw path: sim/cockpit2/clock_timer/current_day
        /// </summary>
        public IXPDataRef<int> current_day { get { return m_data.GetInt("sim/cockpit2/clock_timer/current_day");} }

        /// <summary>
        ///  Numeric month of the year. Units:month
        ///  Raw path: sim/cockpit2/clock_timer/current_month
        /// </summary>
        public IXPDataRef<int> current_month { get { return m_data.GetInt("sim/cockpit2/clock_timer/current_month");} }

        /// <summary>
        ///  . Units:enum
        ///  Raw path: sim/cockpit2/clock_timer/timer_mode
        /// </summary>
        public IXPDataRef<int> timer_mode { get { return m_data.GetInt("sim/cockpit2/clock_timer/timer_mode");} }
    }
}