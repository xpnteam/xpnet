using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_electricalDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_electricalDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Inverter turned on, 0 or 1. (Was 8, but should be 2 total.). Units:boolean
        ///  Raw path: sim/cockpit2/electrical/inverter_on
        /// </summary>
        public IXPDataRef<bool[]> inverter_on { get { return m_data.GetBoolArray("sim/cockpit2/electrical/inverter_on");} }

        /// <summary>
        ///  Battery turned on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/electrical/battery_on
        /// </summary>
        public IXPDataRef<bool[]> battery_on { get { return m_data.GetBoolArray("sim/cockpit2/electrical/battery_on");} }

        /// <summary>
        ///  Battery amperage, in (surprisingly) amps.. Units:amps
        ///  Raw path: sim/cockpit2/electrical/battery_amps
        /// </summary>
        public IXPDataRef<float[]> battery_amps { get { return m_data.GetFloatArray("sim/cockpit2/electrical/battery_amps");} }

        /// <summary>
        ///  Actual battery voltage in, umm, volts?. Units:volts
        ///  Raw path: sim/cockpit2/electrical/battery_voltage_actual_volts
        /// </summary>
        public IXPDataRef<float[]> battery_voltage_actual_volts { get { return m_data.GetFloatArray("sim/cockpit2/electrical/battery_voltage_actual_volts");} }

        /// <summary>
        ///  Indicated battery voltage in, umm, volts? ...The indication may be different than the actual voltage!. Units:volts
        ///  Raw path: sim/cockpit2/electrical/battery_voltage_indicated_volts
        /// </summary>
        public IXPDataRef<float[]> battery_voltage_indicated_volts { get { return m_data.GetFloatArray("sim/cockpit2/electrical/battery_voltage_indicated_volts");} }

        /// <summary>
        ///  Generator turned on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/electrical/generator_on
        /// </summary>
        public IXPDataRef<bool[]> generator_on { get { return m_data.GetBoolArray("sim/cockpit2/electrical/generator_on");} }

        /// <summary>
        ///  Generator amperage.. Units:amps
        ///  Raw path: sim/cockpit2/electrical/generator_amps
        /// </summary>
        public IXPDataRef<float[]> generator_amps { get { return m_data.GetFloatArray("sim/cockpit2/electrical/generator_amps");} }

        /// <summary>
        ///  APU generator is turned on, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/electrical/APU_generator_on
        /// </summary>
        public IXPDataRef<bool> APU_generator_on { get { return m_data.GetBool("sim/cockpit2/electrical/apu_generator_on");} }

        /// <summary>
        ///  APU generator amperage.. Units:amps
        ///  Raw path: sim/cockpit2/electrical/APU_generator_amps
        /// </summary>
        public IXPDataRef<float> APU_generator_amps { get { return m_data.GetFloat("sim/cockpit2/electrical/apu_generator_amps");} }

        /// <summary>
        ///  APU power switch, 0 is off, 1 is on, 2 is start-er-up!. Units:boolean
        ///  Raw path: sim/cockpit2/electrical/APU_starter_switch
        /// </summary>
        public IXPDataRef<bool> APU_starter_switch { get { return m_data.GetBool("sim/cockpit2/electrical/apu_starter_switch");} }

        /// <summary>
        ///  N1 of the APU. Units:percent
        ///  Raw path: sim/cockpit2/electrical/APU_N1_percent
        /// </summary>
        public IXPDataRef<float> APU_N1_percent { get { return m_data.GetFloat("sim/cockpit2/electrical/apu_n1_percent");} }

        /// <summary>
        ///  APU actually running, 0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/electrical/APU_running
        /// </summary>
        public IXPDataRef<bool> APU_running { get { return m_data.GetBool("sim/cockpit2/electrical/apu_running");} }

        /// <summary>
        ///  Switch to connect the two busses together - power from one feeds the other.  0 or 1.. Units:boolean
        ///  Raw path: sim/cockpit2/electrical/cross_tie
        /// </summary>
        public IXPDataRef<bool> cross_tie { get { return m_data.GetBool("sim/cockpit2/electrical/cross_tie");} }

        /// <summary>
        ///  Volt-meter selection (0=external,1=ctr,2=lft,3=rgt,4=tpl,5=bat - use cmnds to set!. Units:enum
        ///  Raw path: sim/cockpit2/electrical/dc_voltmeter_selection
        /// </summary>
        public IXPDataRef<int> dc_voltmeter_selection { get { return m_data.GetInt("sim/cockpit2/electrical/dc_voltmeter_selection");} }

        /// <summary>
        ///  volt-meter value. Units:voltage
        ///  Raw path: sim/cockpit2/electrical/dc_voltmeter_value
        /// </summary>
        public IXPDataRef<float> dc_voltmeter_value { get { return m_data.GetFloat("sim/cockpit2/electrical/dc_voltmeter_value");} }

        /// <summary>
        ///  Bus voltage for given bus - dim 4 until 1030. Units:voltage
        ///  Raw path: sim/cockpit2/electrical/bus_volts
        /// </summary>
        public IXPDataRef<float[]> bus_volts { get { return m_data.GetFloatArray("sim/cockpit2/electrical/bus_volts");} }

        /// <summary>
        ///  Bus load in amps per bus - dim 4 until 1030. Units:amps
        ///  Raw path: sim/cockpit2/electrical/bus_load_amps
        /// </summary>
        public IXPDataRef<float[]> bus_load_amps { get { return m_data.GetFloatArray("sim/cockpit2/electrical/bus_load_amps");} }

        /// <summary>
        ///  Add additional load to this dataref to create additional custom bus loads.. Units:amps
        ///  Raw path: sim/cockpit2/electrical/plugin_bus_load_amps
        /// </summary>
        public IXPDataRef<float[]> plugin_bus_load_amps { get { return m_data.GetFloatArray("sim/cockpit2/electrical/plugin_bus_load_amps");} }

        /// <summary>
        ///  This is the actual panel brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/panel_brightness_ratio
        /// </summary>
        public IXPDataRef<float[]> panel_brightness_ratio { get { return m_data.GetFloatArray("sim/cockpit2/electrical/panel_brightness_ratio");} }

        /// <summary>
        ///  This is the actual panel brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/panel_brightness_ratio_auto
        /// </summary>
        public IXPDataRef<float[]> panel_brightness_ratio_auto { get { return m_data.GetFloatArray("sim/cockpit2/electrical/panel_brightness_ratio_auto");} }

        /// <summary>
        ///  This is the actual panel brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/panel_brightness_ratio_manual
        /// </summary>
        public IXPDataRef<float[]> panel_brightness_ratio_manual { get { return m_data.GetFloatArray("sim/cockpit2/electrical/panel_brightness_ratio_manual");} }

        /// <summary>
        ///  Actual instrument brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/instrument_brightness_ratio
        /// </summary>
        public IXPDataRef<float[]> instrument_brightness_ratio { get { return m_data.GetFloatArray("sim/cockpit2/electrical/instrument_brightness_ratio");} }

        /// <summary>
        ///  Actual instrument brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/instrument_brightness_ratio_auto
        /// </summary>
        public IXPDataRef<float[]> instrument_brightness_ratio_auto { get { return m_data.GetFloatArray("sim/cockpit2/electrical/instrument_brightness_ratio_auto");} }

        /// <summary>
        ///  Actual instrument brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/instrument_brightness_ratio_manual
        /// </summary>
        public IXPDataRef<float[]> instrument_brightness_ratio_manual { get { return m_data.GetFloatArray("sim/cockpit2/electrical/instrument_brightness_ratio_manual");} }

        /// <summary>
        ///  Actual HUD brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/HUD_brightness_ratio
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio { get { return m_data.GetFloat("sim/cockpit2/electrical/hud_brightness_ratio");} }

        /// <summary>
        ///  Actual HUD brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/HUD_brightness_ratio_auto
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio_auto { get { return m_data.GetFloat("sim/cockpit2/electrical/hud_brightness_ratio_auto");} }

        /// <summary>
        ///  Actual HUD brightness, taking into account failures. Units:ratio
        ///  Raw path: sim/cockpit2/electrical/HUD_brightness_ratio_manual
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio_manual { get { return m_data.GetFloat("sim/cockpit2/electrical/hud_brightness_ratio_manual");} }
    }
}