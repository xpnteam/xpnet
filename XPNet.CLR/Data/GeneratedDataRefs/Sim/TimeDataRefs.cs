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
        ///  Total time the sim has been up. Units:seconds
        /// </summary>
        public IXPDataRef<float> Total_running_time_sec => m_data.GetFloat("sim/time/total_running_time_sec");

        /// <summary>
        ///  Total time since the flight got reset by something. Units:seconds
        /// </summary>
        public IXPDataRef<float> Total_flight_time_sec => m_data.GetFloat("sim/time/total_flight_time_sec");

        /// <summary>
        ///  Total time elapsed on the timer. Units:seconds
        /// </summary>
        public IXPDataRef<float> Timer_elapsed_time_sec => m_data.GetFloat("sim/time/timer_elapsed_time_sec");

        /// <summary>
        ///  Local time  (seconds since midnight??). Units:seconds
        /// </summary>
        public IXPDataRef<float> Local_time_sec => m_data.GetFloat("sim/time/local_time_sec");

        /// <summary>
        ///  Zulu time  (seconds since midnight??). Units:seconds
        /// </summary>
        public IXPDataRef<float> Zulu_time_sec => m_data.GetFloat("sim/time/zulu_time_sec");

        /// <summary>
        ///  The actual time-speed increase the sim has achieved - takes into account fps limiting.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Sim_speed_actual => m_data.GetFloat("sim/time/sim_speed_actual");

        /// <summary>
        ///  elapsed time on the Hobbs meter. Units:seconds
        /// </summary>
        public IXPDataRef<float> Hobbs_time => m_data.GetFloat("sim/time/hobbs_time");
    }
}