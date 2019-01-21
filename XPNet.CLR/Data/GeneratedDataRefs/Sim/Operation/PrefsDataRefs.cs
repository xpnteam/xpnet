using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_prefsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_prefsDataRefs(IXPlaneData data)
        {
            m_data = data;
            misc = new sim_operation_prefs_miscDataRefs(data);
        }
        public sim_operation_prefs_miscDataRefs misc { get; }

        /// <summary>
        ///  Start up with the plane running?. Units:boolean
        ///  Raw path: sim/operation/prefs/startup_running
        /// </summary>
        public IXPDataRef<bool> startup_running { get { return m_data.GetBool("sim/operation/prefs/startup_running");} }

        /// <summary>
        ///  Warn if we exceed max airframe speed. Units:boolean
        ///  Raw path: sim/operation/prefs/warn_overspeed
        /// </summary>
        public IXPDataRef<bool> warn_overspeed { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed");} }

        /// <summary>
        ///  Warn if we exceed max g-forces on aircraft. Units:boolean
        ///  Raw path: sim/operation/prefs/warn_overgforce
        /// </summary>
        public IXPDataRef<bool> warn_overgforce { get { return m_data.GetBool("sim/operation/prefs/warn_overgforce");} }

        /// <summary>
        ///  Warn if we exceed max flap extended speed. Units:boolean
        ///  Raw path: sim/operation/prefs/warn_overspeed_flaps
        /// </summary>
        public IXPDataRef<bool> warn_overspeed_flaps { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed_flaps");} }

        /// <summary>
        ///  Warn if we exceed max gear deployed speed. Units:boolean
        ///  Raw path: sim/operation/prefs/warn_overspeed_gear
        /// </summary>
        public IXPDataRef<bool> warn_overspeed_gear { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed_gear");} }

        /// <summary>
        ///  On crash, do we reset the AC to the nearest airport? - gone in v11, read only dref returns false for compatibility.. Units:boolean
        ///  Raw path: sim/operation/prefs/reset_on_crash
        /// </summary>
        public IXPDataRef<bool> reset_on_crash { get { return m_data.GetBool("sim/operation/prefs/reset_on_crash");} }

        /// <summary>
        ///  Show text warning for otherwise hard to see things like carb-icing?. Units:boolean
        ///  Raw path: sim/operation/prefs/warn_nonobvious_stuff
        /// </summary>
        public IXPDataRef<bool> warn_nonobvious_stuff { get { return m_data.GetBool("sim/operation/prefs/warn_nonobvious_stuff");} }

        /// <summary>
        ///  show text ATC messages?. Units:boolean
        ///  Raw path: sim/operation/prefs/text_out
        /// </summary>
        public IXPDataRef<bool> text_out { get { return m_data.GetBool("sim/operation/prefs/text_out");} }

        /// <summary>
        ///  Are we in replay mode?. Units:enum
        ///  Raw path: sim/operation/prefs/replay_mode
        /// </summary>
        public IXPDataRef<int> replay_mode { get { return m_data.GetInt("sim/operation/prefs/replay_mode");} }

        /// <summary>
        ///  Controls whether the AI controls the user's plane. Units:boolean
        ///  Raw path: sim/operation/prefs/ai_flies_aircraft
        /// </summary>
        public IXPDataRef<bool> ai_flies_aircraft { get { return m_data.GetBool("sim/operation/prefs/ai_flies_aircraft");} }
    }
}