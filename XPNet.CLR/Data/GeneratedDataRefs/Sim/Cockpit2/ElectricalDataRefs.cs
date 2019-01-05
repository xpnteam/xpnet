using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_ElectricalDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_ElectricalDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Battery amperage, in (surprisingly) amps.. Units:amps
        /// </summary>
        public IXPDataRef<float[]> Battery_amps => m_data.GetFloatArray("sim/cockpit2/electrical/battery_amps");

        /// <summary>
        ///  Actual battery voltage in, umm, volts?. Units:volts
        /// </summary>
        public IXPDataRef<float[]> Battery_voltage_actual_volts => m_data.GetFloatArray("sim/cockpit2/electrical/battery_voltage_actual_volts");

        /// <summary>
        ///  Indicated battery voltage in, umm, volts? ...The indication may be different than the actual voltage!. Units:volts
        /// </summary>
        public IXPDataRef<float[]> Battery_voltage_indicated_volts => m_data.GetFloatArray("sim/cockpit2/electrical/battery_voltage_indicated_volts");

        /// <summary>
        ///  Generator amperage.. Units:amps
        /// </summary>
        public IXPDataRef<float[]> Generator_amps => m_data.GetFloatArray("sim/cockpit2/electrical/generator_amps");

        /// <summary>
        ///  APU generator amperage.. Units:amps
        /// </summary>
        public IXPDataRef<float> APU_generator_amps => m_data.GetFloat("sim/cockpit2/electrical/apu_generator_amps");

        /// <summary>
        ///  N1 of the APU. Units:percent
        /// </summary>
        public IXPDataRef<float> APU_N1_percent => m_data.GetFloat("sim/cockpit2/electrical/apu_n1_percent");

        /// <summary>
        ///  volt-meter value. Units:voltage
        /// </summary>
        public IXPDataRef<float> Dc_voltmeter_value => m_data.GetFloat("sim/cockpit2/electrical/dc_voltmeter_value");

        /// <summary>
        ///  Bus voltage for given bus - dim 4 until 1030. Units:voltage
        /// </summary>
        public IXPDataRef<float[]> Bus_volts => m_data.GetFloatArray("sim/cockpit2/electrical/bus_volts");

        /// <summary>
        ///  Bus load in amps per bus - dim 4 until 1030. Units:amps
        /// </summary>
        public IXPDataRef<float[]> Bus_load_amps => m_data.GetFloatArray("sim/cockpit2/electrical/bus_load_amps");

        /// <summary>
        ///  Add additional load to this dataref to create additional custom bus loads.. Units:amps
        /// </summary>
        public IXPDataRef<float[]> Plugin_bus_load_amps => m_data.GetFloatArray("sim/cockpit2/electrical/plugin_bus_load_amps");

        /// <summary>
        ///  This is the actual panel brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Panel_brightness_ratio => m_data.GetFloatArray("sim/cockpit2/electrical/panel_brightness_ratio");

        /// <summary>
        ///  This is the actual panel brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Panel_brightness_ratio_auto => m_data.GetFloatArray("sim/cockpit2/electrical/panel_brightness_ratio_auto");

        /// <summary>
        ///  This is the actual panel brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Panel_brightness_ratio_manual => m_data.GetFloatArray("sim/cockpit2/electrical/panel_brightness_ratio_manual");

        /// <summary>
        ///  Actual instrument brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Instrument_brightness_ratio => m_data.GetFloatArray("sim/cockpit2/electrical/instrument_brightness_ratio");

        /// <summary>
        ///  Actual instrument brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Instrument_brightness_ratio_auto => m_data.GetFloatArray("sim/cockpit2/electrical/instrument_brightness_ratio_auto");

        /// <summary>
        ///  Actual instrument brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Instrument_brightness_ratio_manual => m_data.GetFloatArray("sim/cockpit2/electrical/instrument_brightness_ratio_manual");

        /// <summary>
        ///  Actual HUD brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio => m_data.GetFloat("sim/cockpit2/electrical/hud_brightness_ratio");

        /// <summary>
        ///  Actual HUD brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio_auto => m_data.GetFloat("sim/cockpit2/electrical/hud_brightness_ratio_auto");

        /// <summary>
        ///  Actual HUD brightness, taking into account failures. Units:ratio
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio_manual => m_data.GetFloat("sim/cockpit2/electrical/hud_brightness_ratio_manual");
    }
}