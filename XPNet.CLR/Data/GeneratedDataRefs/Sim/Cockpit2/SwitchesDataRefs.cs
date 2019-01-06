using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_switchesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_switchesDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> avionics_power_on { get { return m_data.GetBool("sim/cockpit2/switches/avionics_power_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> navigation_lights_on { get { return m_data.GetBool("sim/cockpit2/switches/navigation_lights_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> beacon_on { get { return m_data.GetBool("sim/cockpit2/switches/beacon_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> strobe_lights_on { get { return m_data.GetBool("sim/cockpit2/switches/strobe_lights_on");} }

        /// <summary>
        ///  Switch, 0 or 1.  This affects the first landing light.
        /// </summary>
        public IXPDataRef<bool> landing_lights_on { get { return m_data.GetBool("sim/cockpit2/switches/landing_lights_on");} }

        /// <summary>
        ///  Switch, 0 is off, 0.5 is half-intensity, etc. for any of the landing lights.
        /// </summary>
        public IXPDataRef<float[]> landing_lights_switch { get { return m_data.GetFloatArray("sim/cockpit2/switches/landing_lights_switch");} }

        /// <summary>
        ///  Switch, 0 is off, 0.5 is half-intensity, etc. for any of the generic lights.
        /// </summary>
        public IXPDataRef<float[]> generic_lights_switch { get { return m_data.GetFloatArray("sim/cockpit2/switches/generic_lights_switch");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> taxi_light_on { get { return m_data.GetBool("sim/cockpit2/switches/taxi_light_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> spot_light_on { get { return m_data.GetBool("sim/cockpit2/switches/spot_light_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> dump_fuel { get { return m_data.GetBool("sim/cockpit2/switches/dump_fuel");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> puffers_on { get { return m_data.GetBool("sim/cockpit2/switches/puffers_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> prop_sync_on { get { return m_data.GetBool("sim/cockpit2/switches/prop_sync_on");} }

        /// <summary>
        ///  Switch, 0 or 1. fan=0, off=1, turbine=2#WHAT ARE THESE?
        /// </summary>
        public IXPDataRef<int> jet_sync_mode { get { return m_data.GetInt("sim/cockpit2/switches/jet_sync_mode");} }

        /// <summary>
        ///  electric hydro-pressure pump
        /// </summary>
        public IXPDataRef<bool> electric_hydraulic_pump_on { get { return m_data.GetBool("sim/cockpit2/switches/electric_hydraulic_pump_on");} }

        /// <summary>
        ///  ram air turbine (the rat) when total failure
        /// </summary>
        public IXPDataRef<bool> ram_air_turbine_on { get { return m_data.GetBool("sim/cockpit2/switches/ram_air_turbine_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> yaw_damper_on { get { return m_data.GetBool("sim/cockpit2/switches/yaw_damper_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> artificial_stability_on { get { return m_data.GetBool("sim/cockpit2/switches/artificial_stability_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> artificial_stability_pitch_on { get { return m_data.GetBool("sim/cockpit2/switches/artificial_stability_pitch_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> artificial_stability_roll_on { get { return m_data.GetBool("sim/cockpit2/switches/artificial_stability_roll_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> HUD_on { get { return m_data.GetBool("sim/cockpit2/switches/hud_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> parachute_deploy { get { return m_data.GetBool("sim/cockpit2/switches/parachute_deploy");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> jato_on { get { return m_data.GetBool("sim/cockpit2/switches/jato_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> tailhook_deploy { get { return m_data.GetBool("sim/cockpit2/switches/tailhook_deploy");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> canopy_open { get { return m_data.GetBool("sim/cockpit2/switches/canopy_open");} }

        /// <summary>
        ///  Switch, 0 or 1. 0 is closed, 1 is open
        /// </summary>
        public IXPDataRef<bool[]> door_open { get { return m_data.GetBoolArray("sim/cockpit2/switches/door_open");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> water_scoop_deploy { get { return m_data.GetBool("sim/cockpit2/switches/water_scoop_deploy");} }

        /// <summary>
        ///  This will be set to true when water is in the process of dumping out of a water-bomber.
        /// </summary>
        public IXPDataRef<bool> dump_water { get { return m_data.GetBool("sim/cockpit2/switches/dump_water");} }

        /// <summary>
        ///  No Smoking
        /// </summary>
        public IXPDataRef<bool> no_smoking { get { return m_data.GetBool("sim/cockpit2/switches/no_smoking");} }

        /// <summary>
        ///  Fasten Seat Belts
        /// </summary>
        public IXPDataRef<bool> fasten_seat_belts { get { return m_data.GetBool("sim/cockpit2/switches/fasten_seat_belts");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> total_energy_audio { get { return m_data.GetBool("sim/cockpit2/switches/total_energy_audio");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> HSI_is_arc { get { return m_data.GetBool("sim/cockpit2/switches/hsi_is_arc");} }

        /// <summary>
        ///  Switch, 0 is RTO (Rejected Take-Off), 1 is off, 2->5 are increasing auto-brake levels.
        /// </summary>
        public IXPDataRef<int> auto_brake_level { get { return m_data.GetInt("sim/cockpit2/switches/auto_brake_level");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> auto_reverse_on { get { return m_data.GetBool("sim/cockpit2/switches/auto_reverse_on");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> prop_feather_mode { get { return m_data.GetBool("sim/cockpit2/switches/prop_feather_mode");} }

        /// <summary>
        ///  Switch, 0 or 1.
        /// </summary>
        public IXPDataRef<bool> pre_rotate_level { get { return m_data.GetBool("sim/cockpit2/switches/pre_rotate_level");} }

        /// <summary>
        ///  Switch, 0 or 1 - engage/disengage rotor clutch
        /// </summary>
        public IXPDataRef<bool> clutch_engage { get { return m_data.GetBool("sim/cockpit2/switches/clutch_engage");} }

        /// <summary>
        ///  Switch, 0 or 1 - turns on the rotor brake.
        /// </summary>
        public IXPDataRef<bool> rotor_brake { get { return m_data.GetBool("sim/cockpit2/switches/rotor_brake");} }

        /// <summary>
        ///  This is the relative strength of the rotor brake compared to X-Plane default.
        /// </summary>
        public IXPDataRef<float> rotor_brake_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/rotor_brake_ratio");} }

        /// <summary>
        ///  Current clutch ratio, 0.0 is off, 1.0 is on - follows clutch engage with some lag.
        /// </summary>
        public IXPDataRef<float> clutch_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/clutch_ratio");} }

        /// <summary>
        ///  This will have an enumeration based on the direction of fire of any maneuvering rockets.
        /// </summary>
        public IXPDataRef<int> rocket_mode { get { return m_data.GetInt("sim/cockpit2/switches/rocket_mode");} }

        /// <summary>
        ///  This can be 0 (half-power afterburners) or 1 (full-power burner).
        /// </summary>
        public IXPDataRef<int> burner_level { get { return m_data.GetInt("sim/cockpit2/switches/burner_level");} }

        /// <summary>
        ///  Alternate static air ratio, 0.0 is off, 1,.0 is on.
        /// </summary>
        public IXPDataRef<float> alternate_static_air_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/alternate_static_air_ratio");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<int> wiper_speed { get { return m_data.GetInt("sim/cockpit2/switches/wiper_speed");} }

        /// <summary>
        ///  custom sliders.  When flipped, slider moves based on timing in planemaker.
        /// </summary>
        public IXPDataRef<bool[]> custom_slider_on { get { return m_data.GetBoolArray("sim/cockpit2/switches/custom_slider_on");} }

        /// <summary>
        ///  Rheostat controlling panel brightness.  0 = flood, 1-3 = spot lights.
        /// </summary>
        public IXPDataRef<float[]> panel_brightness_ratio { get { return m_data.GetFloatArray("sim/cockpit2/switches/panel_brightness_ratio");} }

        /// <summary>
        ///  Rheostat controlling instruments brightnesss.  0 = default pilot, 1 = default copilot, 2-15 = custom
        /// </summary>
        public IXPDataRef<float[]> instrument_brightness_ratio { get { return m_data.GetFloatArray("sim/cockpit2/switches/instrument_brightness_ratio");} }

        /// <summary>
        ///  Rheostat controlling HUD brightness.
        /// </summary>
        public IXPDataRef<float> HUD_brightness_ratio { get { return m_data.GetFloat("sim/cockpit2/switches/hud_brightness_ratio");} }

        /// <summary>
        ///  Camera power on
        /// </summary>
        public IXPDataRef<bool> camera_power_on { get { return m_data.GetBool("sim/cockpit2/switches/camera_power_on");} }

        /// <summary>
        ///  Variometer audio on
        /// </summary>
        public IXPDataRef<bool> total_energy_audio_on { get { return m_data.GetBool("sim/cockpit2/switches/total_energy_audio_on");} }
    }
}