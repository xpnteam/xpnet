using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_fuelDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_fuelDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is the left-engine fuel-tank selector.
        /// </summary>
        public IXPDataRef<int> fuel_tank_selector_left { get { return m_data.GetInt("sim/cockpit2/fuel/fuel_tank_selector_left");} }

        /// <summary>
        ///  This is the right-engine fuel-tank selector.
        /// </summary>
        public IXPDataRef<int> fuel_tank_selector_right { get { return m_data.GetInt("sim/cockpit2/fuel/fuel_tank_selector_right");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<int> fuel_tank_selector { get { return m_data.GetInt("sim/cockpit2/fuel/fuel_tank_selector");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<int> fuel_tank_transfer_to { get { return m_data.GetInt("sim/cockpit2/fuel/fuel_tank_transfer_to");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<int> fuel_tank_transfer_from { get { return m_data.GetInt("sim/cockpit2/fuel/fuel_tank_transfer_from");} }

        /// <summary>
        ///  True if the pump for this tank is on.
        /// </summary>
        public IXPDataRef<bool[]> fuel_tank_pump_on { get { return m_data.GetBoolArray("sim/cockpit2/fuel/fuel_tank_pump_on");} }

        /// <summary>
        ///  True if user is holding down the aux-tank button.
        /// </summary>
        public IXPDataRef<bool> showing_aux { get { return m_data.GetBool("sim/cockpit2/fuel/showing_aux");} }

        /// <summary>
        ///  Indicated fuel level per tank
        /// </summary>
        public IXPDataRef<float[]> fuel_quantity { get { return m_data.GetFloatArray("sim/cockpit2/fuel/fuel_quantity");} }
    }
}