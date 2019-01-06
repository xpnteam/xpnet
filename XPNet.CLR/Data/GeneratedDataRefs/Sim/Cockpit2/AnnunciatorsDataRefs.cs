using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_annunciatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_annunciatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This goes off any time there is a major problem with the bird: like it is on fire or something    // array of annunciators... kept as array for UDP IO. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/master_caution
        /// </summary>
        public IXPDataRef<bool> master_caution { get { return m_data.GetBool("sim/cockpit2/annunciators/master_caution");} }

        /// <summary>
        ///  This goes off whenever there is some more moderate problem with the bird... maybe lo fuel pressure ot qty. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/master_warning
        /// </summary>
        public IXPDataRef<bool> master_warning { get { return m_data.GetBool("sim/cockpit2/annunciators/master_warning");} }

        /// <summary>
        ///  Hit this button to CLEAR the master caution and warning: it says that you hear the buzzer and to shut it up already. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/master_accept
        /// </summary>
        public IXPDataRef<bool> master_accept { get { return m_data.GetBool("sim/cockpit2/annunciators/master_accept");} }

        /// <summary>
        ///  This goes off for a few moments when the autopilot disconnects.. you wanna KNOW if otto just quit on you!. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot_disconnect
        /// </summary>
        public IXPDataRef<bool> autopilot_disconnect { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_disconnect");} }

        /// <summary>
        ///  The vacuum pressure, which drives the instruments in the old prop planes, is low: the artificial horizon may loose it is orientation!. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/low_vacuum
        /// </summary>
        public IXPDataRef<bool> low_vacuum { get { return m_data.GetBool("sim/cockpit2/annunciators/low_vacuum");} }

        /// <summary>
        ///  The voltage os too high or low on one of the electrical buses. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/low_voltage
        /// </summary>
        public IXPDataRef<bool> low_voltage { get { return m_data.GetBool("sim/cockpit2/annunciators/low_voltage");} }

        /// <summary>
        ///  Fuel qty. no points for guessing if it is too high or too low to trigger this one. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/fuel_quantity
        /// </summary>
        public IXPDataRef<bool> fuel_quantity { get { return m_data.GetBool("sim/cockpit2/annunciators/fuel_quantity");} }

        /// <summary>
        ///  Hydraulic pressure. should indicate if press is lo or hi. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/hydraulic_pressure
        /// </summary>
        public IXPDataRef<bool> hydraulic_pressure { get { return m_data.GetBool("sim/cockpit2/annunciators/hydraulic_pressure");} }

        /// <summary>
        ///  Speedbrake deployed: good to know so you do not forget it... Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/speedbrake
        /// </summary>
        public IXPDataRef<bool> speedbrake { get { return m_data.GetBool("sim/cockpit2/annunciators/speedbrake");} }

        /// <summary>
        ///  Ground proximity warning system: PULL UP! PULL UP! my lancair does this during my typical red-baron approaches!. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/GPWS
        /// </summary>
        public IXPDataRef<bool> GPWS { get { return m_data.GetBool("sim/cockpit2/annunciators/gpws");} }

        /// <summary>
        ///  Ice detected on the plane.. most people agree this is NOT a good thing.. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/ice
        /// </summary>
        public IXPDataRef<bool> ice { get { return m_data.GetBool("sim/cockpit2/annunciators/ice");} }

        /// <summary>
        ///  Rotor rpm on the helo has dropped below normal operating: power availability will be reduced!. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/low_rotor
        /// </summary>
        public IXPDataRef<bool> low_rotor { get { return m_data.GetBool("sim/cockpit2/annunciators/low_rotor");} }

        /// <summary>
        ///  Rotor rpm on the helo has exceeded normal operating: power availability will be reduced, and god knows if the blades will stay ON!. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/high_rotor
        /// </summary>
        public IXPDataRef<bool> high_rotor { get { return m_data.GetBool("sim/cockpit2/annunciators/high_rotor");} }

        /// <summary>
        ///  Pitot heat is OFF (YUP! OFF!) turn it on to heat up the pitot tube, which measures air pressure to give you air speed.. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/pitot_heat
        /// </summary>
        public IXPDataRef<bool> pitot_heat { get { return m_data.GetBool("sim/cockpit2/annunciators/pitot_heat");} }

        /// <summary>
        ///  You are about to break the speed of sound when accelerating, or drop below the speed of sound if decelerating! the handling of the plane will change!. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/transonic
        /// </summary>
        public IXPDataRef<bool> transonic { get { return m_data.GetBool("sim/cockpit2/annunciators/transonic");} }

        /// <summary>
        ///  slats deployed. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/slats
        /// </summary>
        public IXPDataRef<bool> slats { get { return m_data.GetBool("sim/cockpit2/annunciators/slats");} }

        /// <summary>
        ///  flight director failure. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/flight_director
        /// </summary>
        public IXPDataRef<bool> flight_director { get { return m_data.GetBool("sim/cockpit2/annunciators/flight_director");} }

        /// <summary>
        ///  autopilot failure. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot
        /// </summary>
        public IXPDataRef<bool> autopilot { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot");} }

        /// <summary>
        ///  yaw damper failure. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/yaw_damper
        /// </summary>
        public IXPDataRef<bool> yaw_damper { get { return m_data.GetBool("sim/cockpit2/annunciators/yaw_damper");} }

        /// <summary>
        ///  fuel pressure low - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/fuel_pressure_low
        /// </summary>
        public IXPDataRef<bool[]> fuel_pressure_low { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/fuel_pressure_low");} }

        /// <summary>
        ///  fuel pressure low - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/oil_pressure_low
        /// </summary>
        public IXPDataRef<bool[]> oil_pressure_low { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/oil_pressure_low");} }

        /// <summary>
        ///  oil temperature high - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/oil_temperature_high
        /// </summary>
        public IXPDataRef<bool[]> oil_temperature_high { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/oil_temperature_high");} }

        /// <summary>
        ///  generator off - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/generator_off
        /// </summary>
        public IXPDataRef<bool[]> generator_off { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/generator_off");} }

        /// <summary>
        ///  chip detected - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/chip_detected
        /// </summary>
        public IXPDataRef<bool[]> chip_detected { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/chip_detected");} }

        /// <summary>
        ///  engine fire - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/engine_fires
        /// </summary>
        public IXPDataRef<bool[]> engine_fires { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/engine_fires");} }

        /// <summary>
        ///  igniter on - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/igniter_on
        /// </summary>
        public IXPDataRef<bool[]> igniter_on { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/igniter_on");} }

        /// <summary>
        ///  reverser on - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/reverser_on
        /// </summary>
        public IXPDataRef<bool[]> reverser_on { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/reverser_on");} }

        /// <summary>
        ///  burner on - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/burner_on
        /// </summary>
        public IXPDataRef<bool[]> burner_on { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/burner_on");} }

        /// <summary>
        ///  inverter off - per 2 inverters. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/inverter_off
        /// </summary>
        public IXPDataRef<bool[]> inverter_off { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/inverter_off");} }

        /// <summary>
        ///  N1 of engine is too low for AC - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/N1_low
        /// </summary>
        public IXPDataRef<bool[]> N1_low { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/n1_low");} }

        /// <summary>
        ///  N1 too high - per engine. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/N1_high
        /// </summary>
        public IXPDataRef<bool[]> N1_high { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/n1_high");} }

        /// <summary>
        ///  reversers not ready. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/reverser_not_ready
        /// </summary>
        public IXPDataRef<bool[]> reverser_not_ready { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/reverser_not_ready");} }

        /// <summary>
        ///  ice vain extended (per engine). Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/ice_vane_extend
        /// </summary>
        public IXPDataRef<bool[]> ice_vane_extend { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/ice_vane_extend");} }

        /// <summary>
        ///  ice vain failed (per engine). Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/ice_vane_fail
        /// </summary>
        public IXPDataRef<bool[]> ice_vane_fail { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/ice_vane_fail");} }

        /// <summary>
        ///  bleed air off (per engine). Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/bleed_air_off
        /// </summary>
        public IXPDataRef<bool[]> bleed_air_off { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/bleed_air_off");} }

        /// <summary>
        ///  bleed air failed (per engine). Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/bleed_air_fail
        /// </summary>
        public IXPDataRef<bool[]> bleed_air_fail { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/bleed_air_fail");} }

        /// <summary>
        ///  auto feather armed (per engine). Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/auto_feather_arm
        /// </summary>
        public IXPDataRef<bool[]> auto_feather_arm { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/auto_feather_arm");} }

        /// <summary>
        ///  fuel transfer on (per tank). Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/fuel_transfer
        /// </summary>
        public IXPDataRef<bool[]> fuel_transfer { get { return m_data.GetBoolArray("sim/cockpit2/annunciators/fuel_transfer");} }

        /// <summary>
        ///  duct overheated. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/hvac
        /// </summary>
        public IXPDataRef<bool> hvac { get { return m_data.GetBool("sim/cockpit2/annunciators/hvac");} }

        /// <summary>
        ///  battery is charging too rapidly - may overheat. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/battery_charge_hi
        /// </summary>
        public IXPDataRef<bool> battery_charge_hi { get { return m_data.GetBool("sim/cockpit2/annunciators/battery_charge_hi");} }

        /// <summary>
        ///  cabin altitude at or above 12500. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/cabin_altitude_12500
        /// </summary>
        public IXPDataRef<bool> cabin_altitude_12500 { get { return m_data.GetBool("sim/cockpit2/annunciators/cabin_altitude_12500");} }

        /// <summary>
        ///  autopilot trim failure. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot_trim_fail
        /// </summary>
        public IXPDataRef<bool> autopilot_trim_fail { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_trim_fail");} }

        /// <summary>
        ///  electric trim is off. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/electric_trim_off
        /// </summary>
        public IXPDataRef<bool> electric_trim_off { get { return m_data.GetBool("sim/cockpit2/annunciators/electric_trim_off");} }

        /// <summary>
        ///  crossfeed on. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/crossfeed_on
        /// </summary>
        public IXPDataRef<bool> crossfeed_on { get { return m_data.GetBool("sim/cockpit2/annunciators/crossfeed_on");} }

        /// <summary>
        ///  landing or taxiway light on but gear up. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/landing_taxi_lite
        /// </summary>
        public IXPDataRef<bool> landing_taxi_lite { get { return m_data.GetBool("sim/cockpit2/annunciators/landing_taxi_lite");} }

        /// <summary>
        ///  cabin door is open. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/cabin_door_open
        /// </summary>
        public IXPDataRef<bool> cabin_door_open { get { return m_data.GetBool("sim/cockpit2/annunciators/cabin_door_open");} }

        /// <summary>
        ///  external power is on. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/external_power_on
        /// </summary>
        public IXPDataRef<bool> external_power_on { get { return m_data.GetBool("sim/cockpit2/annunciators/external_power_on");} }

        /// <summary>
        ///  passenger oxygen on. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/passenger_oxy_on
        /// </summary>
        public IXPDataRef<bool> passenger_oxy_on { get { return m_data.GetBool("sim/cockpit2/annunciators/passenger_oxy_on");} }

        /// <summary>
        ///  gear is unsafe. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/gear_unsafe
        /// </summary>
        public IXPDataRef<bool> gear_unsafe { get { return m_data.GetBool("sim/cockpit2/annunciators/gear_unsafe");} }

        /// <summary>
        ///  autopilot trimming down. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot_trim_down
        /// </summary>
        public IXPDataRef<bool> autopilot_trim_down { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_trim_down");} }

        /// <summary>
        ///  autopilot trimming up. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot_trim_up
        /// </summary>
        public IXPDataRef<bool> autopilot_trim_up { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_trim_up");} }

        /// <summary>
        ///  autopilot bank limit is turned ON, autopilot will keep bank below 12.5 degrees of bank. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot_bank_limit
        /// </summary>
        public IXPDataRef<bool> autopilot_bank_limit { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_bank_limit");} }

        /// <summary>
        ///  autopilot soft ride is on. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/autopilot_soft_ride
        /// </summary>
        public IXPDataRef<bool> autopilot_soft_ride { get { return m_data.GetBool("sim/cockpit2/annunciators/autopilot_soft_ride");} }

        /// <summary>
        ///  no inverters are on. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/no_inverters
        /// </summary>
        public IXPDataRef<bool> no_inverters { get { return m_data.GetBool("sim/cockpit2/annunciators/no_inverters");} }

        /// <summary>
        ///  Fuel pressure is lo, or maybe hi, for this engine    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/fuel_pressure
        /// </summary>
        public IXPDataRef<int> fuel_pressure { get { return m_data.GetInt("sim/cockpit2/annunciators/fuel_pressure");} }

        /// <summary>
        ///  Oil pressure is lo, or maybe hi, for this engine    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/oil_pressure
        /// </summary>
        public IXPDataRef<int> oil_pressure { get { return m_data.GetInt("sim/cockpit2/annunciators/oil_pressure");} }

        /// <summary>
        ///  Oil temperature hi for this engine    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/oil_temperature
        /// </summary>
        public IXPDataRef<int> oil_temperature { get { return m_data.GetInt("sim/cockpit2/annunciators/oil_temperature");} }

        /// <summary>
        ///  The generator has failed! the plane cannot charge up. this may happen at lo rpm and go away as the engine revs. happens with my plane    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/generator
        /// </summary>
        public IXPDataRef<int> generator { get { return m_data.GetInt("sim/cockpit2/annunciators/generator");} }

        /// <summary>
        ///  We detected chips of metal in the engine somewhere. most people agree this is not good.    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/chip_detect
        /// </summary>
        public IXPDataRef<int> chip_detect { get { return m_data.GetInt("sim/cockpit2/annunciators/chip_detect");} }

        /// <summary>
        ///  The engine is on FIRE! this adds to excitement    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/engine_fire
        /// </summary>
        public IXPDataRef<int> engine_fire { get { return m_data.GetInt("sim/cockpit2/annunciators/engine_fire");} }

        /// <summary>
        ///  Thrust-reverse deployed!    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/reverser_deployed
        /// </summary>
        public IXPDataRef<int> reverser_deployed { get { return m_data.GetInt("sim/cockpit2/annunciators/reverser_deployed");} }

        /// <summary>
        ///  Afterburners on!    // x8. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/afterburner
        /// </summary>
        public IXPDataRef<int> afterburner { get { return m_data.GetInt("sim/cockpit2/annunciators/afterburner");} }

        /// <summary>
        ///  The inverter has failed! the plane cannot convert ac from the generators to dc for the instruments.     // x2. Units:bitfield
        ///  Raw path: sim/cockpit2/annunciators/inverter
        /// </summary>
        public IXPDataRef<int> inverter { get { return m_data.GetInt("sim/cockpit2/annunciators/inverter");} }

        /// <summary>
        ///  Stall warning going off, yes or no.. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/stall_warning
        /// </summary>
        public IXPDataRef<bool> stall_warning { get { return m_data.GetBool("sim/cockpit2/annunciators/stall_warning");} }

        /// <summary>
        ///  For aircraft with variable stall warnings, 0 = no stall, 1 = full stall. Units:0..1
        ///  Raw path: sim/cockpit2/annunciators/stall_warning_ratio
        /// </summary>
        public IXPDataRef<float> stall_warning_ratio { get { return m_data.GetFloat("sim/cockpit2/annunciators/stall_warning_ratio");} }

        /// <summary>
        ///  Gear warning going off, yes or no.. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/gear_warning
        /// </summary>
        public IXPDataRef<bool> gear_warning { get { return m_data.GetBool("sim/cockpit2/annunciators/gear_warning");} }

        /// <summary>
        ///  No smoking alert on, yes or no.. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/no_smoking
        /// </summary>
        public IXPDataRef<bool> no_smoking { get { return m_data.GetBool("sim/cockpit2/annunciators/no_smoking");} }

        /// <summary>
        ///  Seatbelt sign on, yes or no.. Units:boolean
        ///  Raw path: sim/cockpit2/annunciators/fasten_seatbelt
        /// </summary>
        public IXPDataRef<bool> fasten_seatbelt { get { return m_data.GetBool("sim/cockpit2/annunciators/fasten_seatbelt");} }
    }
}