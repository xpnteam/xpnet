using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_PrefsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_PrefsDatarefs(IXPlaneData data)
        {
            m_data = data;
            Misc = new Sim_Operation_Prefs_MiscDatarefs(data);
        }
        public Sim_Operation_Prefs_MiscDatarefs Misc { get; }

        /// <summary>
        ///  Start up with the plane running?
        /// </summary>
        public IXPDataRef<bool> Startup_running { get { return m_data.GetBool("sim/operation/prefs/startup_running");} }

        /// <summary>
        ///  Warn if we exceed max airframe speed
        /// </summary>
        public IXPDataRef<bool> Warn_overspeed { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed");} }

        /// <summary>
        ///  Warn if we exceed max g-forces on aircraft
        /// </summary>
        public IXPDataRef<bool> Warn_overgforce { get { return m_data.GetBool("sim/operation/prefs/warn_overgforce");} }

        /// <summary>
        ///  Warn if we exceed max flap extended speed
        /// </summary>
        public IXPDataRef<bool> Warn_overspeed_flaps { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed_flaps");} }

        /// <summary>
        ///  Warn if we exceed max gear deployed speed
        /// </summary>
        public IXPDataRef<bool> Warn_overspeed_gear { get { return m_data.GetBool("sim/operation/prefs/warn_overspeed_gear");} }

        /// <summary>
        ///  On crash, do we reset the AC to the nearest airport? - gone in v11, read only dref returns false for compatibility.
        /// </summary>
        public IXPDataRef<bool> Reset_on_crash { get { return m_data.GetBool("sim/operation/prefs/reset_on_crash");} }

        /// <summary>
        ///  Show text warning for otherwise hard to see things like carb-icing?
        /// </summary>
        public IXPDataRef<bool> Warn_nonobvious_stuff { get { return m_data.GetBool("sim/operation/prefs/warn_nonobvious_stuff");} }

        /// <summary>
        ///  show text ATC messages?
        /// </summary>
        public IXPDataRef<bool> Text_out { get { return m_data.GetBool("sim/operation/prefs/text_out");} }

        /// <summary>
        ///  Controls whether the AI controls the user's plane
        /// </summary>
        public IXPDataRef<bool> Ai_flies_aircraft { get { return m_data.GetBool("sim/operation/prefs/ai_flies_aircraft");} }
    }
}