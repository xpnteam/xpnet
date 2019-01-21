using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_timeDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_timeDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the timer running?. Units:boolean
        ///  Raw path: sim/time/timer_is_running_sec
        /// </summary>
        public IXPDataRef<bool> timer_is_running_sec { get { return m_data.GetBool("sim/time/timer_is_running_sec");} }

        /// <summary>
        ///  Total time the sim has been up. Units:seconds
        ///  Raw path: sim/time/total_running_time_sec
        /// </summary>
        public IXPDataRef<float> total_running_time_sec { get { return m_data.GetFloat("sim/time/total_running_time_sec");} }

        /// <summary>
        ///  Total time since the flight got reset by something. Units:seconds
        ///  Raw path: sim/time/total_flight_time_sec
        /// </summary>
        public IXPDataRef<float> total_flight_time_sec { get { return m_data.GetFloat("sim/time/total_flight_time_sec");} }

        /// <summary>
        ///  Total time elapsed on the timer. Units:seconds
        ///  Raw path: sim/time/timer_elapsed_time_sec
        /// </summary>
        public IXPDataRef<float> timer_elapsed_time_sec { get { return m_data.GetFloat("sim/time/timer_elapsed_time_sec");} }

        /// <summary>
        ///  Local time  (seconds since midnight??). Units:seconds
        ///  Raw path: sim/time/local_time_sec
        /// </summary>
        public IXPDataRef<float> local_time_sec { get { return m_data.GetFloat("sim/time/local_time_sec");} }

        /// <summary>
        ///  Zulu time  (seconds since midnight??). Units:seconds
        ///  Raw path: sim/time/zulu_time_sec
        /// </summary>
        public IXPDataRef<float> zulu_time_sec { get { return m_data.GetFloat("sim/time/zulu_time_sec");} }

        /// <summary>
        ///  Date in days since January 1st. Units:days
        ///  Raw path: sim/time/local_date_days
        /// </summary>
        public IXPDataRef<int> local_date_days { get { return m_data.GetInt("sim/time/local_date_days");} }

        /// <summary>
        ///  Use system date and time for local time. Units:boolean
        ///  Raw path: sim/time/use_system_time
        /// </summary>
        public IXPDataRef<bool> use_system_time { get { return m_data.GetBool("sim/time/use_system_time");} }

        /// <summary>
        ///  Is the sim paused?  Use cmd keys to change this.. Units:boolean
        ///  Raw path: sim/time/paused
        /// </summary>
        public IXPDataRef<bool> paused { get { return m_data.GetBool("sim/time/paused");} }

        /// <summary>
        ///  This is the multiplier for real-time...1 = realtime, 2 = 2x, 0 = paused, etc.. Units:ratio
        ///  Raw path: sim/time/sim_speed
        /// </summary>
        public IXPDataRef<int> sim_speed { get { return m_data.GetInt("sim/time/sim_speed");} }

        /// <summary>
        ///  The actual time-speed increase the sim has achieved - takes into account fps limiting.. Units:ratio
        ///  Raw path: sim/time/sim_speed_actual
        /// </summary>
        public IXPDataRef<float> sim_speed_actual { get { return m_data.GetFloat("sim/time/sim_speed_actual");} }

        /// <summary>
        ///  This is the multiplier on ground speed, for faster travel via double-distance. Units:ratio
        ///  Raw path: sim/time/ground_speed
        /// </summary>
        public IXPDataRef<int> ground_speed { get { return m_data.GetInt("sim/time/ground_speed");} }

        /// <summary>
        ///  elapsed time on the Hobbs meter. Units:seconds
        ///  Raw path: sim/time/hobbs_time
        /// </summary>
        public IXPDataRef<float> hobbs_time { get { return m_data.GetFloat("sim/time/hobbs_time");} }

        /// <summary>
        ///  true if we are in replay mode, false if we are flying. Units:boolean
        ///  Raw path: sim/time/is_in_replay
        /// </summary>
        public IXPDataRef<bool> is_in_replay { get { return m_data.GetBool("sim/time/is_in_replay");} }
    }
}