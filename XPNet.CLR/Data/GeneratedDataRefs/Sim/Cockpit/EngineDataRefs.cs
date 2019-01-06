using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_EngineDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_EngineDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the inverter providing power (was one per engine, now 2 max.)
        /// </summary>
        public IXPDataRef<bool[]> Inverter_on { get { return m_data.GetBoolArray("sim/cockpit/engine/inverter_on");} }

        /// <summary>
        ///  Does this cockpit have inverter switches?
        /// </summary>
        public IXPDataRef<bool> Inverter_eq { get { return m_data.GetBool("sim/cockpit/engine/inverter_eq");} }

        /// <summary>
        ///  Is the fuel pump on (one per engine)
        /// </summary>
        public IXPDataRef<bool[]> Fuel_pump_on { get { return m_data.GetBoolArray("sim/cockpit/engine/fuel_pump_on");} }

        /// <summary>
        ///  Is the fadec on (one per engine)
        /// </summary>
        public IXPDataRef<bool[]> Fadec_on { get { return m_data.GetBoolArray("sim/cockpit/engine/fadec_on");} }

        /// <summary>
        ///  Idle speed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Idle_speed { get { return m_data.GetBoolArray("sim/cockpit/engine/idle_speed");} }

        /// <summary>
        ///  starter ignition
        /// </summary>
        public IXPDataRef<bool[]> Igniters_on { get { return m_data.GetBoolArray("sim/cockpit/engine/igniters_on");} }

        /// <summary>
        ///  time since ignition was pressed or something
        /// </summary>
        public IXPDataRef<float[]> Starter_duration { get { return m_data.GetFloatArray("sim/cockpit/engine/starter_duration");} }

        /// <summary>
        ///  APU running - 1 = on, 0 = off.
        /// </summary>
        public IXPDataRef<bool> APU_running { get { return m_data.GetBool("sim/cockpit/engine/apu_running");} }
    }
}