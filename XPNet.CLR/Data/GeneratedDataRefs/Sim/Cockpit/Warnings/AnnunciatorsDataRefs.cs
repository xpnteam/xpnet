using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_Warnings_AnnunciatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_Warnings_AnnunciatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Master caution light on/Off
        /// </summary>
        public IXPDataRef<bool> Master_caution { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/master_caution");} }

        /// <summary>
        ///  Master warning
        /// </summary>
        public IXPDataRef<bool> Master_warning { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/master_warning");} }

        /// <summary>
        ///  Master accept light on/Off
        /// </summary>
        public IXPDataRef<bool> Master_accept { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/master_accept");} }

        /// <summary>
        ///  autopilot has been disconnected
        /// </summary>
        public IXPDataRef<bool> Autopilot_disconnect { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_disconnect");} }

        /// <summary>
        ///  low vacuum pressure
        /// </summary>
        public IXPDataRef<bool> Low_vacuum { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/low_vacuum");} }

        /// <summary>
        ///  low battery voltage
        /// </summary>
        public IXPDataRef<bool> Low_voltage { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/low_voltage");} }

        /// <summary>
        ///  running out of fuel
        /// </summary>
        public IXPDataRef<bool> Fuel_quantity { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/fuel_quantity");} }

        /// <summary>
        ///  hydraulic pressure low
        /// </summary>
        public IXPDataRef<bool> Hydraulic_pressure { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/hydraulic_pressure");} }

        /// <summary>
        ///  speedbrakes deployed
        /// </summary>
        public IXPDataRef<bool> Speedbrake { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/speedbrake");} }

        /// <summary>
        ///  GPWS failed
        /// </summary>
        public IXPDataRef<bool> GPWS { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/gpws");} }

        /// <summary>
        ///  ice detected
        /// </summary>
        public IXPDataRef<bool> Ice { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/ice");} }

        /// <summary>
        ///  low rotor speed
        /// </summary>
        public IXPDataRef<bool> Lo_rotor { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/lo_rotor");} }

        /// <summary>
        ///  high rotor speed
        /// </summary>
        public IXPDataRef<bool> Hi_rotor { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/hi_rotor");} }

        /// <summary>
        ///  pitot heat off
        /// </summary>
        public IXPDataRef<bool> Pitot_heat_off { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/pitot_heat_off");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<bool> Transonic { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/transonic");} }

        /// <summary>
        ///  slats deployed
        /// </summary>
        public IXPDataRef<bool> Slats { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/slats");} }

        /// <summary>
        ///  flight director failure
        /// </summary>
        public IXPDataRef<bool> Flight_director { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/flight_director");} }

        /// <summary>
        ///  autopilot failure
        /// </summary>
        public IXPDataRef<bool> Autopilot { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot");} }

        /// <summary>
        ///  yaw damper failure
        /// </summary>
        public IXPDataRef<bool> Yaw_damper { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/yaw_damper");} }

        /// <summary>
        ///  fuel pressure low - per engine
        /// </summary>
        public IXPDataRef<bool[]> Fuel_pressure_low { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/fuel_pressure_low");} }

        /// <summary>
        ///  fuel pressure low - per engine
        /// </summary>
        public IXPDataRef<bool[]> Oil_pressure_low { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/oil_pressure_low");} }

        /// <summary>
        ///  oil temperature high - per engine
        /// </summary>
        public IXPDataRef<bool[]> Oil_temperature_high { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/oil_temperature_high");} }

        /// <summary>
        ///  generator off - per engine
        /// </summary>
        public IXPDataRef<bool[]> Generator_off { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/generator_off");} }

        /// <summary>
        ///  chip detected - per engine
        /// </summary>
        public IXPDataRef<bool[]> Chip_detected { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/chip_detected");} }

        /// <summary>
        ///  engine fire - per engine
        /// </summary>
        public IXPDataRef<bool[]> Engine_fires { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/engine_fires");} }

        /// <summary>
        ///  igniter on - per engine
        /// </summary>
        public IXPDataRef<bool[]> Igniter_on { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/igniter_on");} }

        /// <summary>
        ///  reverser on - per engine
        /// </summary>
        public IXPDataRef<bool[]> Reverser_on { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/reverser_on");} }

        /// <summary>
        ///  burner on - per engine
        /// </summary>
        public IXPDataRef<bool[]> Burner_on { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/burner_on");} }

        /// <summary>
        ///  inverter off - per 2 inverters
        /// </summary>
        public IXPDataRef<bool[]> Inverter_off { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/inverter_off");} }

        /// <summary>
        ///  N1 of engine is too low for AC - per engine
        /// </summary>
        public IXPDataRef<bool[]> N1_low { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/n1_low");} }

        /// <summary>
        ///  N1 too high - per engine
        /// </summary>
        public IXPDataRef<bool[]> N1_high { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/n1_high");} }

        /// <summary>
        ///  reversers not ready
        /// </summary>
        public IXPDataRef<bool[]> Reverser_not_ready { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/reverser_not_ready");} }

        /// <summary>
        ///  ice vain extended (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Ice_vane_extend { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/ice_vane_extend");} }

        /// <summary>
        ///  ice vain failed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Ice_vane_fail { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/ice_vane_fail");} }

        /// <summary>
        ///  bleed air off (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Bleed_air_off { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/bleed_air_off");} }

        /// <summary>
        ///  bleed air failed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Bleed_air_fail { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/bleed_air_fail");} }

        /// <summary>
        ///  auto feather armed (per engine)
        /// </summary>
        public IXPDataRef<bool[]> Auto_feather_arm { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/auto_feather_arm");} }

        /// <summary>
        ///  fuel transfer on (per tank)
        /// </summary>
        public IXPDataRef<bool[]> Fuel_transfer { get { return m_data.GetBoolArray("sim/cockpit/warnings/annunciators/fuel_transfer");} }

        /// <summary>
        ///  duct overheated
        /// </summary>
        public IXPDataRef<bool> Hvac { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/hvac");} }

        /// <summary>
        ///  battery is charging too rapidly - may overheat
        /// </summary>
        public IXPDataRef<bool> Battery_charge_hi { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/battery_charge_hi");} }

        /// <summary>
        ///  cabin altitude at or above 12500
        /// </summary>
        public IXPDataRef<bool> Cabin_altitude_12500 { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/cabin_altitude_12500");} }

        /// <summary>
        ///  autopilot trim failure
        /// </summary>
        public IXPDataRef<bool> Autopilot_trim_fail { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_trim_fail");} }

        /// <summary>
        ///  electric trim is off
        /// </summary>
        public IXPDataRef<bool> Electric_trim_off { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/electric_trim_off");} }

        /// <summary>
        ///  crossfeed on
        /// </summary>
        public IXPDataRef<bool> Crossfeed_on { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/crossfeed_on");} }

        /// <summary>
        ///  landing or taxiway light on but gear up
        /// </summary>
        public IXPDataRef<bool> Landing_taxi_lite { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/landing_taxi_lite");} }

        /// <summary>
        ///  cabin door is open
        /// </summary>
        public IXPDataRef<bool> Cabin_door_open { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/cabin_door_open");} }

        /// <summary>
        ///  external power is on
        /// </summary>
        public IXPDataRef<bool> External_power_on { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/external_power_on");} }

        /// <summary>
        ///  passenger oxygen on
        /// </summary>
        public IXPDataRef<bool> Passenger_oxy_on { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/passenger_oxy_on");} }

        /// <summary>
        ///  gear is unsafe
        /// </summary>
        public IXPDataRef<bool> Gear_unsafe { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/gear_unsafe");} }

        /// <summary>
        ///  autopilot trimming down
        /// </summary>
        public IXPDataRef<bool> Autopilot_trim_down { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_trim_down");} }

        /// <summary>
        ///  autopilot trimming up
        /// </summary>
        public IXPDataRef<bool> Autopilot_trim_up { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_trim_up");} }

        /// <summary>
        ///  autopilot bank limit is turned ON, autopilot will keep bank below 12.5 degrees of bank
        /// </summary>
        public IXPDataRef<bool> Autopilot_bank_limit { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_bank_limit");} }

        /// <summary>
        ///  autopilot soft ride is on
        /// </summary>
        public IXPDataRef<bool> Autopilot_soft_ride { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/autopilot_soft_ride");} }

        /// <summary>
        ///  no inverters are on
        /// </summary>
        public IXPDataRef<bool> No_inverters { get { return m_data.GetBool("sim/cockpit/warnings/annunciators/no_inverters");} }
    }
}