using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_SwitchesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_SwitchesDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Switch, 0 is off, 0.5 is half-intensity, etc. for any of the landing lights.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Landing_lights_switch => m_data.GetFloatArray("sim/cockpit2/switches/landing_lights_switch");

        /// <summary>
        ///  Switch, 0 is off, 0.5 is half-intensity, etc. for any of the generic lights.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Generic_lights_switch => m_data.GetFloatArray("sim/cockpit2/switches/generic_lights_switch");

        /// <summary>
        ///  This is the relative strength of the rotor brake compared to X-Plane default.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Rotor_brake_ratio => m_data.GetFloat("sim/cockpit2/switches/rotor_brake_ratio");

        /// <summary>
        ///  Current clutch ratio, 0.0 is off, 1.0 is on - follows clutch engage with some lag.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Clutch_ratio => m_data.GetFloat("sim/cockpit2/switches/clutch_ratio");

        /// <summary>
        ///  Alternate static air ratio, 0.0 is off, 1,.0 is on.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Alternate_static_air_ratio => m_data.GetFloat("sim/cockpit2/switches/alternate_static_air_ratio");

        /// <summary>
        ///  Rheostat controlling panel brightness.  0 = flood, 1-3 = spot lights.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Panel_brightness_ratio => m_data.GetFloatArray("sim/cockpit2/switches/panel_brightness_ratio");

        /// <summary>
        ///  Rheostat controlling instruments brightnesss.  0 = default pilot, 1 = default copilot, 2-15 = custom. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Instrument_brightness_ratio => m_data.GetFloatArray("sim/cockpit2/switches/instrument_brightness_ratio");

        /// <summary>
        ///  Rheostat controlling HUD brightness.. Units:ratio
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio => m_data.GetFloat("sim/cockpit2/switches/hud_brightness_ratio");
    }
}