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
        public IXPDataRef<bool[]> Inverter_on => m_data.GetBoolArray("sim/cockpit/engine/inverter_on");

        /// <summary>
        ///  Does this cockpit have inverter switches?
        /// </summary>
        public IXPDataRef<bool> Inverter_eq => m_data.GetBool("sim/cockpit/engine/inverter_eq");

        /// <summary>
        ///  Is the fuel pump on (one per engine)
        /// </summary>
        public IXPDataRef<bool[]> Fuel_pump_on => m_data.GetBoolArray("sim/cockpit/engine/fuel_pump_on");

        /// <summary>
        ///  Is the fadec on (one per engine)
        /// </summary>
        public IXPDataRef<bool[]> Fadec_on => m_data.GetBoolArray("sim/cockpit/engine/fadec_on");

        /// <summary>
        ///  Idle speed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Idle_speed => m_data.GetBoolArray("sim/cockpit/engine/idle_speed");

        /// <summary>
        ///  time since ignition was pressed or something. Units:seconds
        /// </summary>
        public IXPDataRef<float[]> Starter_duration => m_data.GetFloatArray("sim/cockpit/engine/starter_duration");
    }
}