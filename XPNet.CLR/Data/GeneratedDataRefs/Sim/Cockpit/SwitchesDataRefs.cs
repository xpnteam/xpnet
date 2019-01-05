using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_SwitchesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_SwitchesDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the anti-icing system on.  This turns on EVERY anti-ice system.
        /// </summary>
        public IXPDataRef<bool> Anti_ice_on => m_data.GetBool("sim/cockpit/switches/anti_ice_on");

        /// <summary>
        ///  Turns on inlet heating for engine 1
        /// </summary>
        public IXPDataRef<bool> Anti_ice_inlet_heat => m_data.GetBool("sim/cockpit/switches/anti_ice_inlet_heat");

        /// <summary>
        ///  Turns on inlet heating - array access to all engines, up to 8. (Deprecated - use correct spelled dataref)
        /// </summary>
        public IXPDataRef<bool[]> Anti_ice_inlet_heat_per_enigne => m_data.GetBoolArray("sim/cockpit/switches/anti_ice_inlet_heat_per_enigne");

        /// <summary>
        ///  Turns on inlet heating - array access to all engines, up to 8.
        /// </summary>
        public IXPDataRef<bool[]> Anti_ice_inlet_heat_per_engine => m_data.GetBoolArray("sim/cockpit/switches/anti_ice_inlet_heat_per_engine");

        /// <summary>
        ///  Turns on prop heat for prop 1
        /// </summary>
        public IXPDataRef<bool> Anti_ice_prop_heat => m_data.GetBool("sim/cockpit/switches/anti_ice_prop_heat");

        /// <summary>
        ///  Turns on prop heat - array access to all props, up to 8.
        /// </summary>
        public IXPDataRef<bool[]> Anti_ice_prop_heat_per_engine => m_data.GetBoolArray("sim/cockpit/switches/anti_ice_prop_heat_per_engine");

        /// <summary>
        ///  Turns on anti-icing fr the windshield
        /// </summary>
        public IXPDataRef<bool> Anti_ice_window_heat => m_data.GetBool("sim/cockpit/switches/anti_ice_window_heat");

        /// <summary>
        ///  Is the pitot heat on
        /// </summary>
        public IXPDataRef<bool> Pitot_heat_on => m_data.GetBool("sim/cockpit/switches/pitot_heat_on");

        /// <summary>
        ///  Is the backup pitot heat on
        /// </summary>
        public IXPDataRef<bool> Pitot_heat_on2 => m_data.GetBool("sim/cockpit/switches/pitot_heat_on2");

        /// <summary>
        ///  Turns on anti-icing for alpha vane heater, pilot side
        /// </summary>
        public IXPDataRef<bool> Anti_ice_AOA_heat => m_data.GetBool("sim/cockpit/switches/anti_ice_aoa_heat");

        /// <summary>
        ///  Turns on anti-icing for alpha vane heater, copilot side
        /// </summary>
        public IXPDataRef<bool> Anti_ice_AOA_heat2 => m_data.GetBool("sim/cockpit/switches/anti_ice_aoa_heat2");

        /// <summary>
        ///  Turns on surface heat on the wings
        /// </summary>
        public IXPDataRef<bool> Anti_ice_surf_heat => m_data.GetBool("sim/cockpit/switches/anti_ice_surf_heat");

        /// <summary>
        ///  Turns on surface heat on the left wing
        /// </summary>
        public IXPDataRef<bool> Anti_ice_surf_heat_left => m_data.GetBool("sim/cockpit/switches/anti_ice_surf_heat_left");

        /// <summary>
        ///  Turns on surface heat on the right wing
        /// </summary>
        public IXPDataRef<bool> Anti_ice_surf_heat_right => m_data.GetBool("sim/cockpit/switches/anti_ice_surf_heat_right");

        /// <summary>
        ///  Turns on the wing-surface anti-ice boot (knocks ice off I think).
        /// </summary>
        public IXPDataRef<bool> Anti_ice_surf_boot => m_data.GetBool("sim/cockpit/switches/anti_ice_surf_boot");

        /// <summary>
        ///  ignition source is turned on automatically on low N1 to prevent flameout
        /// </summary>
        public IXPDataRef<bool> Anti_ice_auto_ignite => m_data.GetBool("sim/cockpit/switches/anti_ice_auto_ignite");

        /// <summary>
        ///  Turns on ice detect
        /// </summary>
        public IXPDataRef<bool> Ice_detect => m_data.GetBool("sim/cockpit/switches/ice_detect");

        /// <summary>
        ///  Alpha level of EFIS weather from 0 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> EFIS_weather_alpha => m_data.GetFloat("sim/cockpit/switches/efis_weather_alpha");
    }
}