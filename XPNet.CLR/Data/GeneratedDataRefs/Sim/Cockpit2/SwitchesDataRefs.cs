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
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Avionics_power_on { get { return m_data.GetBool("sim/cockpit2/switches/avionics_power_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Navigation_lights_on { get { return m_data.GetBool("sim/cockpit2/switches/navigation_lights_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Beacon_on { get { return m_data.GetBool("sim/cockpit2/switches/beacon_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Strobe_lights_on { get { return m_data.GetBool("sim/cockpit2/switches/strobe_lights_on");} }

        /// <summary>
        ///  Switch, 0 or 1.  This affects the first landing light.
        /// </summary>
        public IXPDataRef<bool> Landing_lights_on { get { return m_data.GetBool("sim/cockpit2/switches/landing_lights_on");} }

        /// <summary>
        ///  Switch, 0 is off, 0.5 is half-intensity, etc. for any of the landing lights.
        /// </summary>
        public IXPDataRef<float[]> Landing_lights_switch { get { return m_data.GetFloatArray("sim/cockpit2/switches/landing_lights_switch");} }

        /// <summary>
        ///  Switch, 0 is off, 0.5 is half-intensity, etc. for any of the generic lights.
        /// </summary>
        public IXPDataRef<float[]> Generic_lights_switch { get { return m_data.GetFloatArray("sim/cockpit2/switches/generic_lights_switch");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Taxi_light_on { get { return m_data.GetBool("sim/cockpit2/switches/taxi_light_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Spot_light_on { get { return m_data.GetBool("sim/cockpit2/switches/spot_light_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Dump_fuel { get { return m_data.GetBool("sim/cockpit2/switches/dump_fuel");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Puffers_on { get { return m_data.GetBool("sim/cockpit2/switches/puffers_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Prop_sync_on { get { return m_data.GetBool("sim/cockpit2/switches/prop_sync_on");} }

        /// <summary>
        ///  electric hydro-pressure pump
        /// </summary>
        public IXPDataRef<bool> Electric_hydraulic_pump_on { get { return m_data.GetBool("sim/cockpit2/switches/electric_hydraulic_pump_on");} }

        /// <summary>
        ///  ram air turbine (the rat) when total failure
        /// </summary>
        public IXPDataRef<bool> Ram_air_turbine_on { get { return m_data.GetBool("sim/cockpit2/switches/ram_air_turbine_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Yaw_damper_on { get { return m_data.GetBool("sim/cockpit2/switches/yaw_damper_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Artificial_stability_on { get { return m_data.GetBool("sim/cockpit2/switches/artificial_stability_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Artificial_stability_pitch_on { get { return m_data.GetBool("sim/cockpit2/switches/artificial_stability_pitch_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Artificial_stability_roll_on { get { return m_data.GetBool("sim/cockpit2/switches/artificial_stability_roll_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> HUD_on { get { return m_data.GetBool("sim/cockpit2/switches/hud_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Parachute_deploy { get { return m_data.GetBool("sim/cockpit2/switches/parachute_deploy");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Jato_on { get { return m_data.GetBool("sim/cockpit2/switches/jato_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Tailhook_deploy { get { return m_data.GetBool("sim/cockpit2/switches/tailhook_deploy");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Canopy_open { get { return m_data.GetBool("sim/cockpit2/switches/canopy_open");} }

        /// <summary>
        ///  Switch, 0 or 1. 0 is closed, 1 is open
        /// </summary>
        public IXPDataRef<bool[]> Door_open { get { return m_data.GetBoolArray("sim/cockpit2/switches/door_open");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Water_scoop_deploy { get { return m_data.GetBool("sim/cockpit2/switches/water_scoop_deploy");} }

        /// <summary>
        ///  This will be set to true when water is in the process of dumping out of a water-bomber.
        /// </summary>
        public IXPDataRef<bool> Dump_water { get { return m_data.GetBool("sim/cockpit2/switches/dump_water");} }

        /// <summary>
        ///  No Smoking
        /// </summary>
        public IXPDataRef<bool> No_smoking { get { return m_data.GetBool("sim/cockpit2/switches/no_smoking");} }

        /// <summary>
        ///  Fasten Seat Belts
        /// </summary>
        public IXPDataRef<bool> Fasten_seat_belts { get { return m_data.GetBool("sim/cockpit2/switches/fasten_seat_belts");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Total_energy_audio { get { return m_data.GetBool("sim/cockpit2/switches/total_energy_audio");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> HSI_is_arc { get { return m_data.GetBool("sim/cockpit2/switches/hsi_is_arc");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Auto_reverse_on { get { return m_data.GetBool("sim/cockpit2/switches/auto_reverse_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Prop_feather_mode { get { return m_data.GetBool("sim/cockpit2/switches/prop_feather_mode");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> Pre_rotate_level { get { return m_data.GetBool("sim/cockpit2/switches/pre_rotate_level");} }

        /// <summary>
        ///  Switch, 0 or 1 - engage/Disengage rotor clutch
        /// </summary>
        public IXPDataRef<bool> Clutch_engage { get { return m_data.GetBool("sim/cockpit2/switches/clutch_engage");} }

        /// <summary>
        ///  Switch, 0 or 1 - turns on the rotor brake.
        /// </summary>
        public IXPDataRef<bool> Rotor_brake { get { return m_data.GetBool("sim/cockpit2/switches/rotor_brake");} }

        /// <summary>
        ///  This is the relative strength of the rotor brake compared to X-Plane default.
        /// </summary>
        public IXPDataRef<float> Rotor_brake_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/rotor_brake_ratio");} }

        /// <summary>
        ///  Current clutch ratio, 0.0 is off, 1.0 is on - follows clutch engage with some lag.
        /// </summary>
        public IXPDataRef<float> Clutch_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/clutch_ratio");} }

        /// <summary>
        ///  Alternate static air ratio, 0.0 is off, 1,.0 is on.
        /// </summary>
        public IXPDataRef<float> Alternate_static_air_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/alternate_static_air_ratio");} }

        /// <summary>
        ///  custom sliders.  When flipped, slider moves based on timing in planemaker.
        /// </summary>
        public IXPDataRef<bool[]> Custom_slider_on { get { return m_data.GetBoolArray("sim/cockpit2/switches/custom_slider_on");} }

        /// <summary>
        ///  Rheostat controlling panel brightness.  0 = flood, 1-3 = spot lights.
        /// </summary>
        public IXPDataRef<float[]> Panel_brightness_ratio { get { return m_data.GetFloatArray("sim/cockpit2/switches/panel_brightness_ratio");} }

        /// <summary>
        ///  Rheostat controlling instruments brightnesss.  0 = default pilot, 1 = default copilot, 2-15 = custom
        /// </summary>
        public IXPDataRef<float[]> Instrument_brightness_ratio { get { return m_data.GetFloatArray("sim/cockpit2/switches/instrument_brightness_ratio");} }

        /// <summary>
        ///  Rheostat controlling HUD brightness.
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/hud_brightness_ratio");} }

        /// <summary>
        ///  Camera power on
        /// </summary>
        public IXPDataRef<bool> Camera_power_on { get { return m_data.GetBool("sim/cockpit2/switches/camera_power_on");} }

        /// <summary>
        ///  Variometer audio on
        /// </summary>
        public IXPDataRef<bool> Total_energy_audio_on { get { return m_data.GetBool("sim/cockpit2/switches/total_energy_audio_on");} }
    }
}