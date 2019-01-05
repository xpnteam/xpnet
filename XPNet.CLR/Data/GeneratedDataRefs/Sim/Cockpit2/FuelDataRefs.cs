using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_FuelDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_FuelDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  True if the pump for this tank is on.
        /// </summary>
        public IXPDataRef<bool[]> Fuel_tank_pump_on => m_data.GetBoolArray("sim/cockpit2/fuel/fuel_tank_pump_on");

        /// <summary>
        ///  True if user is holding down the aux-tank button.
        /// </summary>
        public IXPDataRef<bool> Showing_aux => m_data.GetBool("sim/cockpit2/fuel/showing_aux");
    }
}