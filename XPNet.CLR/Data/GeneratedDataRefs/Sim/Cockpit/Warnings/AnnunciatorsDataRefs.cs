using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_warnings_annunciatorsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_warnings_annunciatorsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Master caution light on/off. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/master_caution
        /// </summary>
        public IXPDataRef<bool> master_caution { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/master_caution");} }

        /// <summary>
        ///  Master warning. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/master_warning
        /// </summary>
        public IXPDataRef<bool> master_warning { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/master_warning");} }

        /// <summary>
        ///  Master accept light on/off. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/master_accept
        /// </summary>
        public IXPDataRef<bool> master_accept { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/master_accept");} }

        /// <summary>
        ///  autopilot has been disconnected. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot_disconnect
        /// </summary>
        public IXPDataRef<bool> autopilot_disconnect { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_disconnect");} }

        /// <summary>
        ///  low vacuum pressure. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/low_vacuum
        /// </summary>
        public IXPDataRef<bool> low_vacuum { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/low_vacuum");} }

        /// <summary>
        ///  low battery voltage. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/low_voltage
        /// </summary>
        public IXPDataRef<bool> low_voltage { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/low_voltage");} }

        /// <summary>
        ///  running out of fuel. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/fuel_quantity
        /// </summary>
        public IXPDataRef<bool> fuel_quantity { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/fuel_quantity");} }

        /// <summary>
        ///  hydraulic pressure low. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/hydraulic_pressure
        /// </summary>
        public IXPDataRef<bool> hydraulic_pressure { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/hydraulic_pressure");} }

        /// <summary>
        ///  speedbrakes deployed. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/speedbrake
        /// </summary>
        public IXPDataRef<bool> speedbrake { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/speedbrake");} }

        /// <summary>
        ///  GPWS failed. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/GPWS
        /// </summary>
        public IXPDataRef<bool> GPWS { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/gpws");} }

        /// <summary>
        ///  ice detected. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/ice
        /// </summary>
        public IXPDataRef<bool> ice { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/ice");} }

        /// <summary>
        ///  low rotor speed. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/lo_rotor
        /// </summary>
        public IXPDataRef<bool> lo_rotor { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/lo_rotor");} }

        /// <summary>
        ///  high rotor speed. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/hi_rotor
        /// </summary>
        public IXPDataRef<bool> hi_rotor { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/hi_rotor");} }

        /// <summary>
        ///  pitot heat off. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/pitot_heat_off
        /// </summary>
        public IXPDataRef<bool> pitot_heat_off { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/pitot_heat_off");} }

        /// <summary>
        ///  . Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/transonic
        /// </summary>
        public IXPDataRef<bool> transonic { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/transonic");} }

        /// <summary>
        ///  slats deployed. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/slats
        /// </summary>
        public IXPDataRef<bool> slats { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/slats");} }

        /// <summary>
        ///  flight director failure. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/flight_director
        /// </summary>
        public IXPDataRef<bool> flight_director { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/flight_director");} }

        /// <summary>
        ///  autopilot failure. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot
        /// </summary>
        public IXPDataRef<bool> autopilot { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot");} }

        /// <summary>
        ///  yaw damper failure. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/yaw_damper
        /// </summary>
        public IXPDataRef<bool> yaw_damper { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/yaw_damper");} }

        /// <summary>
        ///  fuel pressure low - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/fuel_pressure_low
        /// </summary>
        public IXPDataRef<bool[]> fuel_pressure_low { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/fuel_pressure_low");} }

        /// <summary>
        ///  fuel pressure low - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/oil_pressure_low
        /// </summary>
        public IXPDataRef<bool[]> oil_pressure_low { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/oil_pressure_low");} }

        /// <summary>
        ///  oil temperature high - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/oil_temperature_high
        /// </summary>
        public IXPDataRef<bool[]> oil_temperature_high { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/oil_temperature_high");} }

        /// <summary>
        ///  generator off - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/generator_off
        /// </summary>
        public IXPDataRef<bool[]> generator_off { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/generator_off");} }

        /// <summary>
        ///  chip detected - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/chip_detected
        /// </summary>
        public IXPDataRef<bool[]> chip_detected { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/chip_detected");} }

        /// <summary>
        ///  engine fire - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/engine_fires
        /// </summary>
        public IXPDataRef<bool[]> engine_fires { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/engine_fires");} }

        /// <summary>
        ///  igniter on - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/igniter_on
        /// </summary>
        public IXPDataRef<bool[]> igniter_on { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/igniter_on");} }

        /// <summary>
        ///  reverser on - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/reverser_on
        /// </summary>
        public IXPDataRef<bool[]> reverser_on { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/reverser_on");} }

        /// <summary>
        ///  burner on - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/burner_on
        /// </summary>
        public IXPDataRef<bool[]> burner_on { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/burner_on");} }

        /// <summary>
        ///  inverter off - per 2 inverters. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/inverter_off
        /// </summary>
        public IXPDataRef<bool[]> inverter_off { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/inverter_off");} }

        /// <summary>
        ///  N1 of engine is too low for AC - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/N1_low
        /// </summary>
        public IXPDataRef<bool[]> N1_low { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/n1_low");} }

        /// <summary>
        ///  N1 too high - per engine. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/N1_high
        /// </summary>
        public IXPDataRef<bool[]> N1_high { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/n1_high");} }

        /// <summary>
        ///  reversers not ready. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/reverser_not_ready
        /// </summary>
        public IXPDataRef<bool[]> reverser_not_ready { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/reverser_not_ready");} }

        /// <summary>
        ///  ice vain extended (per engine). Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/ice_vane_extend
        /// </summary>
        public IXPDataRef<bool[]> ice_vane_extend { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/ice_vane_extend");} }

        /// <summary>
        ///  ice vain failed (per engine). Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/ice_vane_fail
        /// </summary>
        public IXPDataRef<bool[]> ice_vane_fail { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/ice_vane_fail");} }

        /// <summary>
        ///  bleed air off (per engine). Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/bleed_air_off
        /// </summary>
        public IXPDataRef<bool[]> bleed_air_off { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/bleed_air_off");} }

        /// <summary>
        ///  bleed air failed (per engine). Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/bleed_air_fail
        /// </summary>
        public IXPDataRef<bool[]> bleed_air_fail { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/bleed_air_fail");} }

        /// <summary>
        ///  auto feather armed (per engine). Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/auto_feather_arm
        /// </summary>
        public IXPDataRef<bool[]> auto_feather_arm { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/auto_feather_arm");} }

        /// <summary>
        ///  fuel transfer on (per tank). Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/fuel_transfer
        /// </summary>
        public IXPDataRef<bool[]> fuel_transfer { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/fuel_transfer");} }

        /// <summary>
        ///  duct overheated. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/hvac
        /// </summary>
        public IXPDataRef<bool> hvac { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/hvac");} }

        /// <summary>
        ///  battery is charging too rapidly - may overheat. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/battery_charge_hi
        /// </summary>
        public IXPDataRef<bool> battery_charge_hi { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/battery_charge_hi");} }

        /// <summary>
        ///  cabin altitude at or above 12500. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/cabin_altitude_12500
        /// </summary>
        public IXPDataRef<bool> cabin_altitude_12500 { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/cabin_altitude_12500");} }

        /// <summary>
        ///  autopilot trim failure. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot_trim_fail
        /// </summary>
        public IXPDataRef<bool> autopilot_trim_fail { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_trim_fail");} }

        /// <summary>
        ///  electric trim is off. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/electric_trim_off
        /// </summary>
        public IXPDataRef<bool> electric_trim_off { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/electric_trim_off");} }

        /// <summary>
        ///  crossfeed on. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/crossfeed_on
        /// </summary>
        public IXPDataRef<bool> crossfeed_on { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/crossfeed_on");} }

        /// <summary>
        ///  landing or taxiway light on but gear up. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/landing_taxi_lite
        /// </summary>
        public IXPDataRef<bool> landing_taxi_lite { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/landing_taxi_lite");} }

        /// <summary>
        ///  cabin door is open. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/cabin_door_open
        /// </summary>
        public IXPDataRef<bool> cabin_door_open { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/cabin_door_open");} }

        /// <summary>
        ///  external power is on. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/external_power_on
        /// </summary>
        public IXPDataRef<bool> external_power_on { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/external_power_on");} }

        /// <summary>
        ///  passenger oxygen on. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/passenger_oxy_on
        /// </summary>
        public IXPDataRef<bool> passenger_oxy_on { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/passenger_oxy_on");} }

        /// <summary>
        ///  gear is unsafe. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/gear_unsafe
        /// </summary>
        public IXPDataRef<bool> gear_unsafe { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/gear_unsafe");} }

        /// <summary>
        ///  autopilot trimming down. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot_trim_down
        /// </summary>
        public IXPDataRef<bool> autopilot_trim_down { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_trim_down");} }

        /// <summary>
        ///  autopilot trimming up. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot_trim_up
        /// </summary>
        public IXPDataRef<bool> autopilot_trim_up { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_trim_up");} }

        /// <summary>
        ///  autopilot bank limit is turned ON, autopilot will keep bank below 12.5 degrees of bank. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot_bank_limit
        /// </summary>
        public IXPDataRef<bool> autopilot_bank_limit { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_bank_limit");} }

        /// <summary>
        ///  autopilot soft ride is on. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/autopilot_soft_ride
        /// </summary>
        public IXPDataRef<bool> autopilot_soft_ride { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_soft_ride");} }

        /// <summary>
        ///  no inverters are on. Units:boolean
        ///  Raw path: sim/cockpit/warnings/annunciators/no_inverters
        /// </summary>
        public IXPDataRef<bool> no_inverters { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/no_inverters");} }

        /// <summary>
        ///  fuel pressure low. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/fuel_pressure
        /// </summary>
        public IXPDataRef<int> fuel_pressure { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/fuel_pressure");} }

        /// <summary>
        ///  oil pressure low. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/oil_pressure
        /// </summary>
        public IXPDataRef<int> oil_pressure { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/oil_pressure");} }

        /// <summary>
        ///  oil temperature too high. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/oil_temperature
        /// </summary>
        public IXPDataRef<int> oil_temperature { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/oil_temperature");} }

        /// <summary>
        ///  generators are off or broken. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/generator
        /// </summary>
        public IXPDataRef<int> generator { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/generator");} }

        /// <summary>
        ///  a chip has been detected in, um, a prop or turbine?. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/chip_detect
        /// </summary>
        public IXPDataRef<int> chip_detect { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/chip_detect");} }

        /// <summary>
        ///  yer engines are on fire, fer cryin out loud. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/engine_fire
        /// </summary>
        public IXPDataRef<int> engine_fire { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/engine_fire");} }

        /// <summary>
        ///  reversers deployed. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/reverse
        /// </summary>
        public IXPDataRef<int> reverse { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/reverse");} }

        /// <summary>
        ///  afterburners on. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/afterburners_on
        /// </summary>
        public IXPDataRef<int> afterburners_on { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/afterburners_on");} }

        /// <summary>
        ///  inverters are off or broken. Units:bitfield
        ///  Raw path: sim/cockpit/warnings/annunciators/inverter
        /// </summary>
        public IXPDataRef<int> inverter { get { return m_data.GetInt("sim/cockpit/warnings/annunciators/inverter");} }
    }
}