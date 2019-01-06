using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_TimeDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_TimeDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the timer running?
        /// </summary>
        public IXPDataRef<bool> Timer_is_running_sec { get { return m_data.GetBool("sim/time/timer_is_running_sec");} }

        /// <summary>
        ///  Total time the sim has been up
        /// </summary>
        public IXPDataRef<float> Total_running_time_sec { get { return m_data.GetFloat("sim/time/total_running_time_sec");} }

        /// <summary>
        ///  Total time since the flight got reset by something
        /// </summary>
        public IXPDataRef<float> Total_flight_time_sec { get { return m_data.GetFloat("sim/time/total_flight_time_sec");} }

        /// <summary>
        ///  Total time elapsed on the timer
        /// </summary>
        public IXPDataRef<float> Timer_elapsed_time_sec { get { return m_data.GetFloat("sim/time/timer_elapsed_time_sec");} }

        /// <summary>
        ///  Local time  (seconds since midnight??)
        /// </summary>
        public IXPDataRef<float> Local_time_sec { get { return m_data.GetFloat("sim/time/local_time_sec");} }

        /// <summary>
        ///  Zulu time  (seconds since midnight??)
        /// </summary>
        public IXPDataRef<float> Zulu_time_sec { get { return m_data.GetFloat("sim/time/zulu_time_sec");} }

        /// <summary>
        ///  Use system date and time for local time
        /// </summary>
        public IXPDataRef<bool> Use_system_time { get { return m_data.GetBool("sim/time/use_system_time");} }

        /// <summary>
        ///  Is the sim paused?  Use cmd keys to change this.
        /// </summary>
        public IXPDataRef<bool> Paused { get { return m_data.GetBool("sim/time/paused");} }

        /// <summary>
        ///  The actual time-speed increase the sim has achieved - takes into account fps limiting.
        /// </summary>
        public IXPDataRef<float> Sim_speed_actual { get { return m_data.GetFloat("sim/time/sim_speed_actual");} }

        /// <summary>
        ///  elapsed time on the Hobbs meter
        /// </summary>
        public IXPDataRef<float> Hobbs_time { get { return m_data.GetFloat("sim/time/hobbs_time");} }

        /// <summary>
        ///  true if we are in replay mode, false if we are flying
        /// </summary>
        public IXPDataRef<bool> Is_in_replay { get { return m_data.GetBool("sim/time/is_in_replay");} }
    }
}