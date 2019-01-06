using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_electricalDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_electricalDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the main battery on
        /// </summary>
        public IXPDataRef<bool> battery_on { get { return m_data.GetBool("sim/cockpit/electrical/battery_on");} }

        /// <summary>
        ///  Is the battery selected on
        /// </summary>
        public IXPDataRef<bool[]> battery_array_on { get { return m_data.GetBoolArray("sim/cockpit/electrical/battery_array_on");} }

        /// <summary>
        ///  Does this cockpit have a battery switch
        /// </summary>
        public IXPDataRef<bool> battery_EQ { get { return m_data.GetBool("sim/cockpit/electrical/battery_eq");} }

        /// <summary>
        ///  Is there power to the avionics
        /// </summary>
        public IXPDataRef<bool> avionics_on { get { return m_data.GetBool("sim/cockpit/electrical/avionics_on");} }

        /// <summary>
        ///  Does this cockpit have an avionics switch
        /// </summary>
        public IXPDataRef<bool> avionics_EQ { get { return m_data.GetBool("sim/cockpit/electrical/avionics_eq");} }

        /// <summary>
        ///  Is the generator on (to charge batteries) - one for each engine
        /// </summary>
        public IXPDataRef<bool[]> generator_on { get { return m_data.GetBoolArray("sim/cockpit/electrical/generator_on");} }

        /// <summary>
        ///  Does this cockpit have generator switches?
        /// </summary>
        public IXPDataRef<bool> generator_EQ { get { return m_data.GetBool("sim/cockpit/electrical/generator_eq");} }

        /// <summary>
        ///  Is the APU Generator on
        /// </summary>
        public IXPDataRef<bool> generator_apu_on { get { return m_data.GetBool("sim/cockpit/electrical/generator_apu_on");} }

        /// <summary>
        ///  Is the GPU on
        /// </summary>
        public IXPDataRef<bool> gpu_on { get { return m_data.GetBool("sim/cockpit/electrical/gpu_on");} }

        /// <summary>
        ///  APU Generator amps
        /// </summary>
        public IXPDataRef<float> generator_apu_amps { get { return m_data.GetFloat("sim/cockpit/electrical/generator_apu_amps");} }

        /// <summary>
        ///  GPU Amps
        /// </summary>
        public IXPDataRef<float> gpu_amps { get { return m_data.GetFloat("sim/cockpit/electrical/gpu_amps");} }

        /// <summary>
        ///  Is the HUD on
        /// </summary>
        public IXPDataRef<bool> HUD_on { get { return m_data.GetBool("sim/cockpit/electrical/hud_on");} }

        /// <summary>
        ///  HUD brightness level (0-1)
        /// </summary>
        public IXPDataRef<float> HUD_brightness { get { return m_data.GetFloat("sim/cockpit/electrical/hud_brightness");} }

        /// <summary>
        ///  Beacon Light
        /// </summary>
        public IXPDataRef<bool> beacon_lights_on { get { return m_data.GetBool("sim/cockpit/electrical/beacon_lights_on");} }

        /// <summary>
        ///  Landing Light
        /// </summary>
        public IXPDataRef<bool> landing_lights_on { get { return m_data.GetBool("sim/cockpit/electrical/landing_lights_on");} }

        /// <summary>
        ///  Navigation Light
        /// </summary>
        public IXPDataRef<bool> nav_lights_on { get { return m_data.GetBool("sim/cockpit/electrical/nav_lights_on");} }

        /// <summary>
        ///  Strobe Light
        /// </summary>
        public IXPDataRef<bool> strobe_lights_on { get { return m_data.GetBool("sim/cockpit/electrical/strobe_lights_on");} }

        /// <summary>
        ///  Taxi Lights
        /// </summary>
        public IXPDataRef<bool> taxi_light_on { get { return m_data.GetBool("sim/cockpit/electrical/taxi_light_on");} }

        /// <summary>
        ///  Are cockpit lights on.  (NOTE - previous docs were wrong, this is always read-only)
        /// </summary>
        public IXPDataRef<bool> cockpit_lights_on { get { return m_data.GetBool("sim/cockpit/electrical/cockpit_lights_on");} }

        /// <summary>
        ///  Cockpit light level
        /// </summary>
        public IXPDataRef<float> cockpit_lights { get { return m_data.GetFloat("sim/cockpit/electrical/cockpit_lights");} }

        /// <summary>
        ///  Instrument LED lighting level
        /// </summary>
        public IXPDataRef<float> instrument_brightness { get { return m_data.GetFloat("sim/cockpit/electrical/instrument_brightness");} }

        /// <summary>
        ///  Sunglasses on?
        /// </summary>
        public IXPDataRef<bool> sunglasses_on { get { return m_data.GetBool("sim/cockpit/electrical/sunglasses_on");} }

        /// <summary>
        ///  Night vision goggles on?
        /// </summary>
        public IXPDataRef<bool> night_vision_on { get { return m_data.GetBool("sim/cockpit/electrical/night_vision_on");} }

        /// <summary>
        ///  Current charge of each of the 8 batteries in watt-hours.
        /// </summary>
        public IXPDataRef<float[]> battery_charge_watt_hr { get { return m_data.GetFloatArray("sim/cockpit/electrical/battery_charge_watt_hr");} }
    }
}