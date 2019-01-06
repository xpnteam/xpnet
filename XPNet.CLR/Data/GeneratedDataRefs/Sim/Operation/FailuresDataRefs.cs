using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_failuresDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_failuresDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Hydraulic pressure ratio. Units:ratio
        ///  Raw path: sim/operation/failures/hydraulic_pressure_ratio
        /// </summary>
        public IXPDataRef<float> hydraulic_pressure_ratio { get { return m_data.GetFloat("sim/operation/failures/hydraulic_pressure_ratio");} }

        /// <summary>
        ///  Hydraulic pressure ratio. Units:ratio
        ///  Raw path: sim/operation/failures/hydraulic_pressure_ratio2
        /// </summary>
        public IXPDataRef<float> hydraulic_pressure_ratio2 { get { return m_data.GetFloat("sim/operation/failures/hydraulic_pressure_ratio2");} }

        /// <summary>
        ///  Oil power or thrust ratio. Units:ratio
        ///  Raw path: sim/operation/failures/oil_power_thrust_ratio
        /// </summary>
        public IXPDataRef<float[]> oil_power_thrust_ratio { get { return m_data.GetFloatArray("sim/operation/failures/oil_power_thrust_ratio");} }

        /// <summary>
        ///  Enable random failures basde on mean time between failures. Units:boolean
        ///  Raw path: sim/operation/failures/enable_random_falures
        /// </summary>
        public IXPDataRef<bool> enable_random_falures { get { return m_data.GetBool("sim/operation/failures/enable_random_falures");} }

        /// <summary>
        ///  Mean time between failures. Units:hours
        ///  Raw path: sim/operation/failures/mean_time_between_failure_hrs
        /// </summary>
        public IXPDataRef<float> mean_time_between_failure_hrs { get { return m_data.GetFloat("sim/operation/failures/mean_time_between_failure_hrs");} }

        /// <summary>
        ///  Ram air turbine is on?. Units:boolean
        ///  Raw path: sim/operation/failures/ram_air_turbine_on
        /// </summary>
        public IXPDataRef<bool> ram_air_turbine_on { get { return m_data.GetBool("sim/operation/failures/ram_air_turbine_on");} }

        /// <summary>
        ///  564 separate failure codes [was 137]. Units:enum
        ///  Raw path: sim/operation/failures/failures
        /// </summary>
        public IXPDataRef<int[]> failures { get { return m_data.GetIntArray("sim/operation/failures/failures");} }

        /// <summary>
        ///  Controls locked. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_conlock
        /// </summary>
        public IXPDataRef<int> rel_conlock { get { return m_data.GetInt("sim/operation/failures/rel_conlock");} }

        /// <summary>
        ///  Door Open. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_door_open
        /// </summary>
        public IXPDataRef<int> rel_door_open { get { return m_data.GetInt("sim/operation/failures/rel_door_open");} }

        /// <summary>
        ///  External power is on. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ex_power_on
        /// </summary>
        public IXPDataRef<int> rel_ex_power_on { get { return m_data.GetInt("sim/operation/failures/rel_ex_power_on");} }

        /// <summary>
        ///  Passenger oxygen on. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pass_o2_on
        /// </summary>
        public IXPDataRef<int> rel_pass_o2_on { get { return m_data.GetInt("sim/operation/failures/rel_pass_o2_on");} }

        /// <summary>
        ///  Pilot has vertigo. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_make_vertigo
        /// </summary>
        public IXPDataRef<int> rel_make_vertigo { get { return m_data.GetInt("sim/operation/failures/rel_make_vertigo");} }

        /// <summary>
        ///  Fuel Cap left off. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelcap
        /// </summary>
        public IXPDataRef<int> rel_fuelcap { get { return m_data.GetInt("sim/operation/failures/rel_fuelcap");} }

        /// <summary>
        ///  Water in fuel. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_water
        /// </summary>
        public IXPDataRef<int> rel_fuel_water { get { return m_data.GetInt("sim/operation/failures/rel_fuel_water");} }

        /// <summary>
        ///  Wrong fuel type - JetA for props or Avgas for jets!. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_type
        /// </summary>
        public IXPDataRef<int> rel_fuel_type { get { return m_data.GetInt("sim/operation/failures/rel_fuel_type");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block0
        /// </summary>
        public IXPDataRef<int> rel_fuel_block0 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block0");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block1
        /// </summary>
        public IXPDataRef<int> rel_fuel_block1 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block1");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block2
        /// </summary>
        public IXPDataRef<int> rel_fuel_block2 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block2");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block3
        /// </summary>
        public IXPDataRef<int> rel_fuel_block3 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block3");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block4
        /// </summary>
        public IXPDataRef<int> rel_fuel_block4 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block4");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block5
        /// </summary>
        public IXPDataRef<int> rel_fuel_block5 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block5");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block6
        /// </summary>
        public IXPDataRef<int> rel_fuel_block6 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block6");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block7
        /// </summary>
        public IXPDataRef<int> rel_fuel_block7 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block7");} }

        /// <summary>
        ///  Fuel tank filter is blocked - tank 9. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuel_block8
        /// </summary>
        public IXPDataRef<int> rel_fuel_block8 { get { return m_data.GetInt("sim/operation/failures/rel_fuel_block8");} }

        /// <summary>
        ///  VASIs Inoperative. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_vasi
        /// </summary>
        public IXPDataRef<int> rel_vasi { get { return m_data.GetInt("sim/operation/failures/rel_vasi");} }

        /// <summary>
        ///  Runway lites Inoperative. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_rwy_lites
        /// </summary>
        public IXPDataRef<int> rel_rwy_lites { get { return m_data.GetInt("sim/operation/failures/rel_rwy_lites");} }

        /// <summary>
        ///  Bird has hit the plane. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bird_strike
        /// </summary>
        public IXPDataRef<int> rel_bird_strike { get { return m_data.GetInt("sim/operation/failures/rel_bird_strike");} }

        /// <summary>
        ///  Wind shear/microburst. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wind_shear
        /// </summary>
        public IXPDataRef<int> rel_wind_shear { get { return m_data.GetInt("sim/operation/failures/rel_wind_shear");} }

        /// <summary>
        ///  Smoke in cockpit. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_smoke_cpit
        /// </summary>
        public IXPDataRef<int> rel_smoke_cpit { get { return m_data.GetInt("sim/operation/failures/rel_smoke_cpit");} }

        /// <summary>
        ///  Induce dusty brown-out. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_brown_out
        /// </summary>
        public IXPDataRef<int> rel_brown_out { get { return m_data.GetInt("sim/operation/failures/rel_brown_out");} }

        /// <summary>
        ///  Electrical System (Bus 1). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_esys
        /// </summary>
        public IXPDataRef<int> rel_esys { get { return m_data.GetInt("sim/operation/failures/rel_esys");} }

        /// <summary>
        ///  Electrical System (Bus 2). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_esys2
        /// </summary>
        public IXPDataRef<int> rel_esys2 { get { return m_data.GetInt("sim/operation/failures/rel_esys2");} }

        /// <summary>
        ///  Electrical System (Bus 3). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_esys3
        /// </summary>
        public IXPDataRef<int> rel_esys3 { get { return m_data.GetInt("sim/operation/failures/rel_esys3");} }

        /// <summary>
        ///  Electrical System (Bus 4). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_esys4
        /// </summary>
        public IXPDataRef<int> rel_esys4 { get { return m_data.GetInt("sim/operation/failures/rel_esys4");} }

        /// <summary>
        ///  Electrical System (Bus 5). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_esys5
        /// </summary>
        public IXPDataRef<int> rel_esys5 { get { return m_data.GetInt("sim/operation/failures/rel_esys5");} }

        /// <summary>
        ///  Electrical System (Bus 6). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_esys6
        /// </summary>
        public IXPDataRef<int> rel_esys6 { get { return m_data.GetInt("sim/operation/failures/rel_esys6");} }

        /// <summary>
        ///  Inverter 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_invert0
        /// </summary>
        public IXPDataRef<int> rel_invert0 { get { return m_data.GetInt("sim/operation/failures/rel_invert0");} }

        /// <summary>
        ///  Inverter 2 (also in 740). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_invert1
        /// </summary>
        public IXPDataRef<int> rel_invert1 { get { return m_data.GetInt("sim/operation/failures/rel_invert1");} }

        /// <summary>
        ///  Generator 0 voltage low. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gen0_lo
        /// </summary>
        public IXPDataRef<int> rel_gen0_lo { get { return m_data.GetInt("sim/operation/failures/rel_gen0_lo");} }

        /// <summary>
        ///  Generator 0 voltage hi. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gen0_hi
        /// </summary>
        public IXPDataRef<int> rel_gen0_hi { get { return m_data.GetInt("sim/operation/failures/rel_gen0_hi");} }

        /// <summary>
        ///  Generator 1 voltage low. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gen1_lo
        /// </summary>
        public IXPDataRef<int> rel_gen1_lo { get { return m_data.GetInt("sim/operation/failures/rel_gen1_lo");} }

        /// <summary>
        ///  Generator 1 voltage hi. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gen1_hi
        /// </summary>
        public IXPDataRef<int> rel_gen1_hi { get { return m_data.GetInt("sim/operation/failures/rel_gen1_hi");} }

        /// <summary>
        ///  Battery 0 voltage low. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bat0_lo
        /// </summary>
        public IXPDataRef<int> rel_bat0_lo { get { return m_data.GetInt("sim/operation/failures/rel_bat0_lo");} }

        /// <summary>
        ///  Battery 0 voltage hi. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bat0_hi
        /// </summary>
        public IXPDataRef<int> rel_bat0_hi { get { return m_data.GetInt("sim/operation/failures/rel_bat0_hi");} }

        /// <summary>
        ///  Battery 1 voltage low. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bat1_lo
        /// </summary>
        public IXPDataRef<int> rel_bat1_lo { get { return m_data.GetInt("sim/operation/failures/rel_bat1_lo");} }

        /// <summary>
        ///  Battery 1 voltage hi. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bat1_hi
        /// </summary>
        public IXPDataRef<int> rel_bat1_hi { get { return m_data.GetInt("sim/operation/failures/rel_bat1_hi");} }

        /// <summary>
        ///  Nav lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_nav
        /// </summary>
        public IXPDataRef<int> rel_lites_nav { get { return m_data.GetInt("sim/operation/failures/rel_lites_nav");} }

        /// <summary>
        ///  Strobe lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_strobe
        /// </summary>
        public IXPDataRef<int> rel_lites_strobe { get { return m_data.GetInt("sim/operation/failures/rel_lites_strobe");} }

        /// <summary>
        ///  Beacon lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_beac
        /// </summary>
        public IXPDataRef<int> rel_lites_beac { get { return m_data.GetInt("sim/operation/failures/rel_lites_beac");} }

        /// <summary>
        ///  Taxi lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_taxi
        /// </summary>
        public IXPDataRef<int> rel_lites_taxi { get { return m_data.GetInt("sim/operation/failures/rel_lites_taxi");} }

        /// <summary>
        ///  Landing Lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_land
        /// </summary>
        public IXPDataRef<int> rel_lites_land { get { return m_data.GetInt("sim/operation/failures/rel_lites_land");} }

        /// <summary>
        ///  Instrument Lighting. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_ins
        /// </summary>
        public IXPDataRef<int> rel_lites_ins { get { return m_data.GetInt("sim/operation/failures/rel_lites_ins");} }

        /// <summary>
        ///  Cockpit Lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clights
        /// </summary>
        public IXPDataRef<int> rel_clights { get { return m_data.GetInt("sim/operation/failures/rel_clights");} }

        /// <summary>
        ///  HUD lights. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lites_hud
        /// </summary>
        public IXPDataRef<int> rel_lites_hud { get { return m_data.GetInt("sim/operation/failures/rel_lites_hud");} }

        /// <summary>
        ///  Stability Augmentation. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_stbaug
        /// </summary>
        public IXPDataRef<int> rel_stbaug { get { return m_data.GetInt("sim/operation/failures/rel_stbaug");} }

        /// <summary>
        ///  autopilot servos failed - rudder/yaw damper. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_servo_rudd
        /// </summary>
        public IXPDataRef<int> rel_servo_rudd { get { return m_data.GetInt("sim/operation/failures/rel_servo_rudd");} }

        /// <summary>
        ///  AutoPilot (Computer). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_otto
        /// </summary>
        public IXPDataRef<int> rel_otto { get { return m_data.GetInt("sim/operation/failures/rel_otto");} }

        /// <summary>
        ///  AutoPilot (Runaway!!!). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_auto_runaway
        /// </summary>
        public IXPDataRef<int> rel_auto_runaway { get { return m_data.GetInt("sim/operation/failures/rel_auto_runaway");} }

        /// <summary>
        ///  AutoPilot (Servos). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_auto_servos
        /// </summary>
        public IXPDataRef<int> rel_auto_servos { get { return m_data.GetInt("sim/operation/failures/rel_auto_servos");} }

        /// <summary>
        ///  autopilot servos failed - ailerons. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_servo_ailn
        /// </summary>
        public IXPDataRef<int> rel_servo_ailn { get { return m_data.GetInt("sim/operation/failures/rel_servo_ailn");} }

        /// <summary>
        ///  autopilot servos failed - elevators. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_servo_elev
        /// </summary>
        public IXPDataRef<int> rel_servo_elev { get { return m_data.GetInt("sim/operation/failures/rel_servo_elev");} }

        /// <summary>
        ///  autopilot servos failed - throttles. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_servo_thro
        /// </summary>
        public IXPDataRef<int> rel_servo_thro { get { return m_data.GetInt("sim/operation/failures/rel_servo_thro");} }

        /// <summary>
        ///  Yaw Left Control. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_rud_L
        /// </summary>
        public IXPDataRef<int> rel_fc_rud_L { get { return m_data.GetInt("sim/operation/failures/rel_fc_rud_l");} }

        /// <summary>
        ///  Yaw Right control. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_rud_R
        /// </summary>
        public IXPDataRef<int> rel_fc_rud_R { get { return m_data.GetInt("sim/operation/failures/rel_fc_rud_r");} }

        /// <summary>
        ///  Roll left control. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_ail_L
        /// </summary>
        public IXPDataRef<int> rel_fc_ail_L { get { return m_data.GetInt("sim/operation/failures/rel_fc_ail_l");} }

        /// <summary>
        ///  Roll Right Control. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_ail_R
        /// </summary>
        public IXPDataRef<int> rel_fc_ail_R { get { return m_data.GetInt("sim/operation/failures/rel_fc_ail_r");} }

        /// <summary>
        ///  Pitch Up Control. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_elv_U
        /// </summary>
        public IXPDataRef<int> rel_fc_elv_U { get { return m_data.GetInt("sim/operation/failures/rel_fc_elv_u");} }

        /// <summary>
        ///  Pitch Down Control. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_elv_D
        /// </summary>
        public IXPDataRef<int> rel_fc_elv_D { get { return m_data.GetInt("sim/operation/failures/rel_fc_elv_d");} }

        /// <summary>
        ///  Yaw Trim. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_trim_rud
        /// </summary>
        public IXPDataRef<int> rel_trim_rud { get { return m_data.GetInt("sim/operation/failures/rel_trim_rud");} }

        /// <summary>
        ///  roll trim. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_trim_ail
        /// </summary>
        public IXPDataRef<int> rel_trim_ail { get { return m_data.GetInt("sim/operation/failures/rel_trim_ail");} }

        /// <summary>
        ///  Pitch Trim. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_trim_elv
        /// </summary>
        public IXPDataRef<int> rel_trim_elv { get { return m_data.GetInt("sim/operation/failures/rel_trim_elv");} }

        /// <summary>
        ///  Yaw Trim Runaway. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_rud_trim_run
        /// </summary>
        public IXPDataRef<int> rel_rud_trim_run { get { return m_data.GetInt("sim/operation/failures/rel_rud_trim_run");} }

        /// <summary>
        ///  Pitch Trim Runaway. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ail_trim_run
        /// </summary>
        public IXPDataRef<int> rel_ail_trim_run { get { return m_data.GetInt("sim/operation/failures/rel_ail_trim_run");} }

        /// <summary>
        ///  Elevator Trim Runaway. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_elv_trim_run
        /// </summary>
        public IXPDataRef<int> rel_elv_trim_run { get { return m_data.GetInt("sim/operation/failures/rel_elv_trim_run");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_slt
        /// </summary>
        public IXPDataRef<int> rel_fc_slt { get { return m_data.GetInt("sim/operation/failures/rel_fc_slt");} }

        /// <summary>
        ///  Flap Actuator. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_flap_act
        /// </summary>
        public IXPDataRef<int> rel_flap_act { get { return m_data.GetInt("sim/operation/failures/rel_flap_act");} }

        /// <summary>
        ///  Left flap activate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_L_flp
        /// </summary>
        public IXPDataRef<int> rel_fc_L_flp { get { return m_data.GetInt("sim/operation/failures/rel_fc_l_flp");} }

        /// <summary>
        ///  Right Flap activate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_R_flp
        /// </summary>
        public IXPDataRef<int> rel_fc_R_flp { get { return m_data.GetInt("sim/operation/failures/rel_fc_r_flp");} }

        /// <summary>
        ///  Left flap remove. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_L_flp_off
        /// </summary>
        public IXPDataRef<int> rel_L_flp_off { get { return m_data.GetInt("sim/operation/failures/rel_l_flp_off");} }

        /// <summary>
        ///  Right flap remove. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_R_flp_off
        /// </summary>
        public IXPDataRef<int> rel_R_flp_off { get { return m_data.GetInt("sim/operation/failures/rel_r_flp_off");} }

        /// <summary>
        ///  Landing Gear actuator. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gear_act
        /// </summary>
        public IXPDataRef<int> rel_gear_act { get { return m_data.GetInt("sim/operation/failures/rel_gear_act");} }

        /// <summary>
        ///  Landing Gear indicator. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gear_ind
        /// </summary>
        public IXPDataRef<int> rel_gear_ind { get { return m_data.GetInt("sim/operation/failures/rel_gear_ind");} }

        /// <summary>
        ///  Left Brakes. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lbrakes
        /// </summary>
        public IXPDataRef<int> rel_lbrakes { get { return m_data.GetInt("sim/operation/failures/rel_lbrakes");} }

        /// <summary>
        ///  Right Brakes. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_rbrakes
        /// </summary>
        public IXPDataRef<int> rel_rbrakes { get { return m_data.GetInt("sim/operation/failures/rel_rbrakes");} }

        /// <summary>
        ///  Landing Gear 1 retract. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lagear1
        /// </summary>
        public IXPDataRef<int> rel_lagear1 { get { return m_data.GetInt("sim/operation/failures/rel_lagear1");} }

        /// <summary>
        ///  Landing Gear 2 retract. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lagear2
        /// </summary>
        public IXPDataRef<int> rel_lagear2 { get { return m_data.GetInt("sim/operation/failures/rel_lagear2");} }

        /// <summary>
        ///  Landing Gear 3 retract. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lagear3
        /// </summary>
        public IXPDataRef<int> rel_lagear3 { get { return m_data.GetInt("sim/operation/failures/rel_lagear3");} }

        /// <summary>
        ///  Landing Gear 4 retract. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lagear4
        /// </summary>
        public IXPDataRef<int> rel_lagear4 { get { return m_data.GetInt("sim/operation/failures/rel_lagear4");} }

        /// <summary>
        ///  Landing Gear 5 retract. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_lagear5
        /// </summary>
        public IXPDataRef<int> rel_lagear5 { get { return m_data.GetInt("sim/operation/failures/rel_lagear5");} }

        /// <summary>
        ///  Landing gear 1 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse1
        /// </summary>
        public IXPDataRef<int> rel_collapse1 { get { return m_data.GetInt("sim/operation/failures/rel_collapse1");} }

        /// <summary>
        ///  Landing gear 2 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse2
        /// </summary>
        public IXPDataRef<int> rel_collapse2 { get { return m_data.GetInt("sim/operation/failures/rel_collapse2");} }

        /// <summary>
        ///  Landing gear 3 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse3
        /// </summary>
        public IXPDataRef<int> rel_collapse3 { get { return m_data.GetInt("sim/operation/failures/rel_collapse3");} }

        /// <summary>
        ///  Landing gear 4 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse4
        /// </summary>
        public IXPDataRef<int> rel_collapse4 { get { return m_data.GetInt("sim/operation/failures/rel_collapse4");} }

        /// <summary>
        ///  Landing gear 5 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse5
        /// </summary>
        public IXPDataRef<int> rel_collapse5 { get { return m_data.GetInt("sim/operation/failures/rel_collapse5");} }

        /// <summary>
        ///  Landing gear 6 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse6
        /// </summary>
        public IXPDataRef<int> rel_collapse6 { get { return m_data.GetInt("sim/operation/failures/rel_collapse6");} }

        /// <summary>
        ///  Landing gear 7 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse7
        /// </summary>
        public IXPDataRef<int> rel_collapse7 { get { return m_data.GetInt("sim/operation/failures/rel_collapse7");} }

        /// <summary>
        ///  Landing gear 8 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse8
        /// </summary>
        public IXPDataRef<int> rel_collapse8 { get { return m_data.GetInt("sim/operation/failures/rel_collapse8");} }

        /// <summary>
        ///  Landing gear 9 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse9
        /// </summary>
        public IXPDataRef<int> rel_collapse9 { get { return m_data.GetInt("sim/operation/failures/rel_collapse9");} }

        /// <summary>
        ///  Landing gear 10 gear collapse. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_collapse10
        /// </summary>
        public IXPDataRef<int> rel_collapse10 { get { return m_data.GetInt("sim/operation/failures/rel_collapse10");} }

        /// <summary>
        ///  Landing gear 1 tire blowout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_tire1
        /// </summary>
        public IXPDataRef<int> rel_tire1 { get { return m_data.GetInt("sim/operation/failures/rel_tire1");} }

        /// <summary>
        ///  Landing gear 2 tire blowout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_tire2
        /// </summary>
        public IXPDataRef<int> rel_tire2 { get { return m_data.GetInt("sim/operation/failures/rel_tire2");} }

        /// <summary>
        ///  Landing gear 3 tire blowout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_tire3
        /// </summary>
        public IXPDataRef<int> rel_tire3 { get { return m_data.GetInt("sim/operation/failures/rel_tire3");} }

        /// <summary>
        ///  Landing gear 4 tire blowout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_tire4
        /// </summary>
        public IXPDataRef<int> rel_tire4 { get { return m_data.GetInt("sim/operation/failures/rel_tire4");} }

        /// <summary>
        ///  Landing gear 5 tire blowout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_tire5
        /// </summary>
        public IXPDataRef<int> rel_tire5 { get { return m_data.GetInt("sim/operation/failures/rel_tire5");} }

        /// <summary>
        ///  air conditioning failed. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_HVAC
        /// </summary>
        public IXPDataRef<int> rel_HVAC { get { return m_data.GetInt("sim/operation/failures/rel_hvac");} }

        /// <summary>
        ///  The left engine is not providing enough pressure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bleed_air_lft
        /// </summary>
        public IXPDataRef<int> rel_bleed_air_lft { get { return m_data.GetInt("sim/operation/failures/rel_bleed_air_lft");} }

        /// <summary>
        ///  The right engine is not providing enough pressure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_bleed_air_rgt
        /// </summary>
        public IXPDataRef<int> rel_bleed_air_rgt { get { return m_data.GetInt("sim/operation/failures/rel_bleed_air_rgt");} }

        /// <summary>
        ///  APU is not providing bleed air for engine start or pressurization. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_APU_press
        /// </summary>
        public IXPDataRef<int> rel_APU_press { get { return m_data.GetInt("sim/operation/failures/rel_apu_press");} }

        /// <summary>
        ///  Slow cabin leak - descend or black out. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_depres_slow
        /// </summary>
        public IXPDataRef<int> rel_depres_slow { get { return m_data.GetInt("sim/operation/failures/rel_depres_slow");} }

        /// <summary>
        ///  catastrophic decompression - yer dead. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_depres_fast
        /// </summary>
        public IXPDataRef<int> rel_depres_fast { get { return m_data.GetInt("sim/operation/failures/rel_depres_fast");} }

        /// <summary>
        ///  Hydraulic pump (electric). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp_ele
        /// </summary>
        public IXPDataRef<int> rel_hydpmp_ele { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp_ele");} }

        /// <summary>
        ///  Hydraulic System 1 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp
        /// </summary>
        public IXPDataRef<int> rel_hydpmp { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp");} }

        /// <summary>
        ///  Hydraulic System 2 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp2
        /// </summary>
        public IXPDataRef<int> rel_hydpmp2 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp2");} }

        /// <summary>
        ///  Hydraulic System 3 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp3
        /// </summary>
        public IXPDataRef<int> rel_hydpmp3 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp3");} }

        /// <summary>
        ///  Hydraulic System 4 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp4
        /// </summary>
        public IXPDataRef<int> rel_hydpmp4 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp4");} }

        /// <summary>
        ///  Hydraulic System 5 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp5
        /// </summary>
        public IXPDataRef<int> rel_hydpmp5 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp5");} }

        /// <summary>
        ///  Hydraulic System 6 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp6
        /// </summary>
        public IXPDataRef<int> rel_hydpmp6 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp6");} }

        /// <summary>
        ///  Hydraulic System 7 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp7
        /// </summary>
        public IXPDataRef<int> rel_hydpmp7 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp7");} }

        /// <summary>
        ///  Hydraulic System 8 (pump fail). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydpmp8
        /// </summary>
        public IXPDataRef<int> rel_hydpmp8 { get { return m_data.GetInt("sim/operation/failures/rel_hydpmp8");} }

        /// <summary>
        ///  Hydraulic System 1 (leak). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydleak
        /// </summary>
        public IXPDataRef<int> rel_hydleak { get { return m_data.GetInt("sim/operation/failures/rel_hydleak");} }

        /// <summary>
        ///  Hydraulic System 2 (leak). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydleak2
        /// </summary>
        public IXPDataRef<int> rel_hydleak2 { get { return m_data.GetInt("sim/operation/failures/rel_hydleak2");} }

        /// <summary>
        ///  Hydraulic System 1 (over pressure). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydoverp
        /// </summary>
        public IXPDataRef<int> rel_hydoverp { get { return m_data.GetInt("sim/operation/failures/rel_hydoverp");} }

        /// <summary>
        ///  Hydraulic System 2 (over pressure). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hydoverp2
        /// </summary>
        public IXPDataRef<int> rel_hydoverp2 { get { return m_data.GetInt("sim/operation/failures/rel_hydoverp2");} }

        /// <summary>
        ///  Throttle inop giving min thrust. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_throt_lo
        /// </summary>
        public IXPDataRef<int> rel_throt_lo { get { return m_data.GetInt("sim/operation/failures/rel_throt_lo");} }

        /// <summary>
        ///  Throttle inop giving max thrust. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_throt_hi
        /// </summary>
        public IXPDataRef<int> rel_throt_hi { get { return m_data.GetInt("sim/operation/failures/rel_throt_hi");} }

        /// <summary>
        ///  Throttle failure at current position. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fc_thr
        /// </summary>
        public IXPDataRef<int> rel_fc_thr { get { return m_data.GetInt("sim/operation/failures/rel_fc_thr");} }

        /// <summary>
        ///  Prop sync. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prop_sync
        /// </summary>
        public IXPDataRef<int> rel_prop_sync { get { return m_data.GetInt("sim/operation/failures/rel_prop_sync");} }

        /// <summary>
        ///  Autofeather system inop. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_feather
        /// </summary>
        public IXPDataRef<int> rel_feather { get { return m_data.GetInt("sim/operation/failures/rel_feather");} }

        /// <summary>
        ///  Tail rotor transmission. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_trotor
        /// </summary>
        public IXPDataRef<int> rel_trotor { get { return m_data.GetInt("sim/operation/failures/rel_trotor");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_antice
        /// </summary>
        public IXPDataRef<int> rel_antice { get { return m_data.GetInt("sim/operation/failures/rel_antice");} }

        /// <summary>
        ///  Ice detector. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_detect
        /// </summary>
        public IXPDataRef<int> rel_ice_detect { get { return m_data.GetInt("sim/operation/failures/rel_ice_detect");} }

        /// <summary>
        ///  Pitot heat 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_pitot_heat1
        /// </summary>
        public IXPDataRef<int> rel_ice_pitot_heat1 { get { return m_data.GetInt("sim/operation/failures/rel_ice_pitot_heat1");} }

        /// <summary>
        ///  Pitot heat 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_pitot_heat2
        /// </summary>
        public IXPDataRef<int> rel_ice_pitot_heat2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_pitot_heat2");} }

        /// <summary>
        ///  Static heat 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_static_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_static_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_static_heat");} }

        /// <summary>
        ///  Static heat 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_static_heat2
        /// </summary>
        public IXPDataRef<int> rel_ice_static_heat2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_static_heat2");} }

        /// <summary>
        ///  AOA indicator heat. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_AOA_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_AOA_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_aoa_heat");} }

        /// <summary>
        ///  AOA indicator heat. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_AOA_heat2
        /// </summary>
        public IXPDataRef<int> rel_ice_AOA_heat2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_aoa_heat2");} }

        /// <summary>
        ///  Window Heat. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_window_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_window_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_window_heat");} }

        /// <summary>
        ///  Surface Boot - Deprecated - Do Not Use. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_surf_boot
        /// </summary>
        public IXPDataRef<int> rel_ice_surf_boot { get { return m_data.GetInt("sim/operation/failures/rel_ice_surf_boot");} }

        /// <summary>
        ///  Surface Heat. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_surf_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_surf_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_surf_heat");} }

        /// <summary>
        ///  Surface Heat. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_surf_heat2
        /// </summary>
        public IXPDataRef<int> rel_ice_surf_heat2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_surf_heat2");} }

        /// <summary>
        ///  Brakes anti-ice. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_brake_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_brake_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_brake_heat");} }

        /// <summary>
        ///  Alternate Air. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_alt_air1
        /// </summary>
        public IXPDataRef<int> rel_ice_alt_air1 { get { return m_data.GetInt("sim/operation/failures/rel_ice_alt_air1");} }

        /// <summary>
        ///  Alternate Air. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_alt_air2
        /// </summary>
        public IXPDataRef<int> rel_ice_alt_air2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_alt_air2");} }

        /// <summary>
        ///  Vacuum System 1 - Pump Failure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_vacuum
        /// </summary>
        public IXPDataRef<int> rel_vacuum { get { return m_data.GetInt("sim/operation/failures/rel_vacuum");} }

        /// <summary>
        ///  Vacuum System 2 - Pump Failure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_vacuum2
        /// </summary>
        public IXPDataRef<int> rel_vacuum2 { get { return m_data.GetInt("sim/operation/failures/rel_vacuum2");} }

        /// <summary>
        ///  Pitot 1 - Blockage. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pitot
        /// </summary>
        public IXPDataRef<int> rel_pitot { get { return m_data.GetInt("sim/operation/failures/rel_pitot");} }

        /// <summary>
        ///  Pitot 2 - Blockage. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pitot2
        /// </summary>
        public IXPDataRef<int> rel_pitot2 { get { return m_data.GetInt("sim/operation/failures/rel_pitot2");} }

        /// <summary>
        ///  Static 1 - Blockage. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_static
        /// </summary>
        public IXPDataRef<int> rel_static { get { return m_data.GetInt("sim/operation/failures/rel_static");} }

        /// <summary>
        ///  Static 2 - Blockage. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_static2
        /// </summary>
        public IXPDataRef<int> rel_static2 { get { return m_data.GetInt("sim/operation/failures/rel_static2");} }

        /// <summary>
        ///  Static system 1 - Error. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_static1_err
        /// </summary>
        public IXPDataRef<int> rel_static1_err { get { return m_data.GetInt("sim/operation/failures/rel_static1_err");} }

        /// <summary>
        ///  Static system 2 - Error. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_static2_err
        /// </summary>
        public IXPDataRef<int> rel_static2_err { get { return m_data.GetInt("sim/operation/failures/rel_static2_err");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_oat
        /// </summary>
        public IXPDataRef<int> rel_g_oat { get { return m_data.GetInt("sim/operation/failures/rel_g_oat");} }

        /// <summary>
        ///  fuel quantity. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_fuel
        /// </summary>
        public IXPDataRef<int> rel_g_fuel { get { return m_data.GetInt("sim/operation/failures/rel_g_fuel");} }

        /// <summary>
        ///  Airspeed Indicator (Pilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ss_asi
        /// </summary>
        public IXPDataRef<int> rel_ss_asi { get { return m_data.GetInt("sim/operation/failures/rel_ss_asi");} }

        /// <summary>
        ///  Artificial Horizon (Pilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ss_ahz
        /// </summary>
        public IXPDataRef<int> rel_ss_ahz { get { return m_data.GetInt("sim/operation/failures/rel_ss_ahz");} }

        /// <summary>
        ///  Altimeter (Pilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ss_alt
        /// </summary>
        public IXPDataRef<int> rel_ss_alt { get { return m_data.GetInt("sim/operation/failures/rel_ss_alt");} }

        /// <summary>
        ///  Turn indicator (Pilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ss_tsi
        /// </summary>
        public IXPDataRef<int> rel_ss_tsi { get { return m_data.GetInt("sim/operation/failures/rel_ss_tsi");} }

        /// <summary>
        ///  Directional Gyro (Pilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ss_dgy
        /// </summary>
        public IXPDataRef<int> rel_ss_dgy { get { return m_data.GetInt("sim/operation/failures/rel_ss_dgy");} }

        /// <summary>
        ///  Vertical Velocity Indicator (Pilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ss_vvi
        /// </summary>
        public IXPDataRef<int> rel_ss_vvi { get { return m_data.GetInt("sim/operation/failures/rel_ss_vvi");} }

        /// <summary>
        ///  Airspeed Indicator (Copilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_cop_asi
        /// </summary>
        public IXPDataRef<int> rel_cop_asi { get { return m_data.GetInt("sim/operation/failures/rel_cop_asi");} }

        /// <summary>
        ///  Artificial Horizon (Copilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_cop_ahz
        /// </summary>
        public IXPDataRef<int> rel_cop_ahz { get { return m_data.GetInt("sim/operation/failures/rel_cop_ahz");} }

        /// <summary>
        ///  Altimeter (Copilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_cop_alt
        /// </summary>
        public IXPDataRef<int> rel_cop_alt { get { return m_data.GetInt("sim/operation/failures/rel_cop_alt");} }

        /// <summary>
        ///  Turn indicator (Copilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_cop_tsi
        /// </summary>
        public IXPDataRef<int> rel_cop_tsi { get { return m_data.GetInt("sim/operation/failures/rel_cop_tsi");} }

        /// <summary>
        ///  Directional Gyro (Copilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_cop_dgy
        /// </summary>
        public IXPDataRef<int> rel_cop_dgy { get { return m_data.GetInt("sim/operation/failures/rel_cop_dgy");} }

        /// <summary>
        ///  Vertical Velocity Indicator (Copilot). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_cop_vvi
        /// </summary>
        public IXPDataRef<int> rel_cop_vvi { get { return m_data.GetInt("sim/operation/failures/rel_cop_vvi");} }

        /// <summary>
        ///  Primary EFIS. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_efis_1
        /// </summary>
        public IXPDataRef<int> rel_efis_1 { get { return m_data.GetInt("sim/operation/failures/rel_efis_1");} }

        /// <summary>
        ///  Secondary EFIS. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_efis_2
        /// </summary>
        public IXPDataRef<int> rel_efis_2 { get { return m_data.GetInt("sim/operation/failures/rel_efis_2");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_AOA
        /// </summary>
        public IXPDataRef<int> rel_AOA { get { return m_data.GetInt("sim/operation/failures/rel_aoa");} }

        /// <summary>
        ///  Stall warning has failed. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_stall_warn
        /// </summary>
        public IXPDataRef<int> rel_stall_warn { get { return m_data.GetInt("sim/operation/failures/rel_stall_warn");} }

        /// <summary>
        ///  gear warning audio is broken. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gear_warning
        /// </summary>
        public IXPDataRef<int> rel_gear_warning { get { return m_data.GetInt("sim/operation/failures/rel_gear_warning");} }

        /// <summary>
        ///  Nav and com 1 radio. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_navcom1
        /// </summary>
        public IXPDataRef<int> rel_navcom1 { get { return m_data.GetInt("sim/operation/failures/rel_navcom1");} }

        /// <summary>
        ///  Nav and com 2 radio. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_navcom2
        /// </summary>
        public IXPDataRef<int> rel_navcom2 { get { return m_data.GetInt("sim/operation/failures/rel_navcom2");} }

        /// <summary>
        ///  Nav-1 radio. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_nav1
        /// </summary>
        public IXPDataRef<int> rel_nav1 { get { return m_data.GetInt("sim/operation/failures/rel_nav1");} }

        /// <summary>
        ///  Nav-2 radio. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_nav2
        /// </summary>
        public IXPDataRef<int> rel_nav2 { get { return m_data.GetInt("sim/operation/failures/rel_nav2");} }

        /// <summary>
        ///  Com-1 radio. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_com1
        /// </summary>
        public IXPDataRef<int> rel_com1 { get { return m_data.GetInt("sim/operation/failures/rel_com1");} }

        /// <summary>
        ///  Com-2 radio. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_com2
        /// </summary>
        public IXPDataRef<int> rel_com2 { get { return m_data.GetInt("sim/operation/failures/rel_com2");} }

        /// <summary>
        ///  ADF 1 (only one ADF failure in 830!). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_adf1
        /// </summary>
        public IXPDataRef<int> rel_adf1 { get { return m_data.GetInt("sim/operation/failures/rel_adf1");} }

        /// <summary>
        ///  ADF 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_adf2
        /// </summary>
        public IXPDataRef<int> rel_adf2 { get { return m_data.GetInt("sim/operation/failures/rel_adf2");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gps
        /// </summary>
        public IXPDataRef<int> rel_gps { get { return m_data.GetInt("sim/operation/failures/rel_gps");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gps2
        /// </summary>
        public IXPDataRef<int> rel_gps2 { get { return m_data.GetInt("sim/operation/failures/rel_gps2");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_dme
        /// </summary>
        public IXPDataRef<int> rel_dme { get { return m_data.GetInt("sim/operation/failures/rel_dme");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_loc
        /// </summary>
        public IXPDataRef<int> rel_loc { get { return m_data.GetInt("sim/operation/failures/rel_loc");} }

        /// <summary>
        ///  Glide Slope. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gls
        /// </summary>
        public IXPDataRef<int> rel_gls { get { return m_data.GetInt("sim/operation/failures/rel_gls");} }

        /// <summary>
        ///  WAAS GPS receiver. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gp
        /// </summary>
        public IXPDataRef<int> rel_gp { get { return m_data.GetInt("sim/operation/failures/rel_gp");} }

        /// <summary>
        ///  Transponder failure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_xpndr
        /// </summary>
        public IXPDataRef<int> rel_xpndr { get { return m_data.GetInt("sim/operation/failures/rel_xpndr");} }

        /// <summary>
        ///  Marker Beacons. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_marker
        /// </summary>
        public IXPDataRef<int> rel_marker { get { return m_data.GetInt("sim/operation/failures/rel_marker");} }

        /// <summary>
        ///  Panel Indicator Inop - rpm engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_RPM_ind_0
        /// </summary>
        public IXPDataRef<int> rel_RPM_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_rpm_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - rpm engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_RPM_ind_1
        /// </summary>
        public IXPDataRef<int> rel_RPM_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_rpm_ind_1");} }

        /// <summary>
        ///  Panel Indicator Inop - n1 engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_N1_ind0
        /// </summary>
        public IXPDataRef<int> rel_N1_ind0 { get { return m_data.GetInt("sim/operation/failures/rel_n1_ind0");} }

        /// <summary>
        ///  Panel Indicator Inop - n1 engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_N1_ind1
        /// </summary>
        public IXPDataRef<int> rel_N1_ind1 { get { return m_data.GetInt("sim/operation/failures/rel_n1_ind1");} }

        /// <summary>
        ///  Panel Indicator Inop - n2 engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_N2_ind0
        /// </summary>
        public IXPDataRef<int> rel_N2_ind0 { get { return m_data.GetInt("sim/operation/failures/rel_n2_ind0");} }

        /// <summary>
        ///  Panel Indicator Inop - n2 engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_N2_ind1
        /// </summary>
        public IXPDataRef<int> rel_N2_ind1 { get { return m_data.GetInt("sim/operation/failures/rel_n2_ind1");} }

        /// <summary>
        ///  Panel Indicator Inop - mp engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_MP_ind_0
        /// </summary>
        public IXPDataRef<int> rel_MP_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_mp_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - mp engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_MP_ind_1
        /// </summary>
        public IXPDataRef<int> rel_MP_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_mp_ind_1");} }

        /// <summary>
        ///  Panel Indicator Inop - trq engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_TRQind0
        /// </summary>
        public IXPDataRef<int> rel_TRQind0 { get { return m_data.GetInt("sim/operation/failures/rel_trqind0");} }

        /// <summary>
        ///  Panel Indicator Inop - trq engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_TRQind1
        /// </summary>
        public IXPDataRef<int> rel_TRQind1 { get { return m_data.GetInt("sim/operation/failures/rel_trqind1");} }

        /// <summary>
        ///  Panel Indicator Inop - epr engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_EPRind0
        /// </summary>
        public IXPDataRef<int> rel_EPRind0 { get { return m_data.GetInt("sim/operation/failures/rel_eprind0");} }

        /// <summary>
        ///  Panel Indicator Inop - epr engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_EPRind1
        /// </summary>
        public IXPDataRef<int> rel_EPRind1 { get { return m_data.GetInt("sim/operation/failures/rel_eprind1");} }

        /// <summary>
        ///  Panel Indicator Inop - cht engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_CHT_ind_0
        /// </summary>
        public IXPDataRef<int> rel_CHT_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_cht_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - cht engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_CHT_ind_1
        /// </summary>
        public IXPDataRef<int> rel_CHT_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_cht_ind_1");} }

        /// <summary>
        ///  Panel Indicator Inop - itt engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ITTind0
        /// </summary>
        public IXPDataRef<int> rel_ITTind0 { get { return m_data.GetInt("sim/operation/failures/rel_ittind0");} }

        /// <summary>
        ///  Panel Indicator Inop - itt engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ITTind1
        /// </summary>
        public IXPDataRef<int> rel_ITTind1 { get { return m_data.GetInt("sim/operation/failures/rel_ittind1");} }

        /// <summary>
        ///  Panel Indicator Inop - egt engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_EGT_ind_0
        /// </summary>
        public IXPDataRef<int> rel_EGT_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_egt_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - egt engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_EGT_ind_1
        /// </summary>
        public IXPDataRef<int> rel_EGT_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_egt_ind_1");} }

        /// <summary>
        ///  Panel Indicator Inop - ff engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_FF_ind0
        /// </summary>
        public IXPDataRef<int> rel_FF_ind0 { get { return m_data.GetInt("sim/operation/failures/rel_ff_ind0");} }

        /// <summary>
        ///  Panel Indicator Inop - ff engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_FF_ind1
        /// </summary>
        public IXPDataRef<int> rel_FF_ind1 { get { return m_data.GetInt("sim/operation/failures/rel_ff_ind1");} }

        /// <summary>
        ///  Panel Indicator Inop - Fuel Pressure 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fp_ind_0
        /// </summary>
        public IXPDataRef<int> rel_fp_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_fp_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - Fuel Pressure 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fp_ind_1
        /// </summary>
        public IXPDataRef<int> rel_fp_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_fp_ind_1");} }

        /// <summary>
        ///  Panel Indicator Inop - Oil Pressure 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilp_ind_0
        /// </summary>
        public IXPDataRef<int> rel_oilp_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_oilp_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - Oil Pressure 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilp_ind_1
        /// </summary>
        public IXPDataRef<int> rel_oilp_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_oilp_ind_1");} }

        /// <summary>
        ///  Panel Indicator Inop - Oil Temperature 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilt_ind_0
        /// </summary>
        public IXPDataRef<int> rel_oilt_ind_0 { get { return m_data.GetInt("sim/operation/failures/rel_oilt_ind_0");} }

        /// <summary>
        ///  Panel Indicator Inop - Oil Temperature 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilt_ind_1
        /// </summary>
        public IXPDataRef<int> rel_oilt_ind_1 { get { return m_data.GetInt("sim/operation/failures/rel_oilt_ind_1");} }

        /// <summary>
        ///  G430 GPS 1 Inop. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g430_gps1
        /// </summary>
        public IXPDataRef<int> rel_g430_gps1 { get { return m_data.GetInt("sim/operation/failures/rel_g430_gps1");} }

        /// <summary>
        ///  G430 GPS 2 Inop. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g430_gps2
        /// </summary>
        public IXPDataRef<int> rel_g430_gps2 { get { return m_data.GetInt("sim/operation/failures/rel_g430_gps2");} }

        /// <summary>
        ///  G430 Nav/Com Tuner 1 Inop. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g430_rad1_tune
        /// </summary>
        public IXPDataRef<int> rel_g430_rad1_tune { get { return m_data.GetInt("sim/operation/failures/rel_g430_rad1_tune");} }

        /// <summary>
        ///  G430 Nav/Com Tuner 2 Inop. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g430_rad2_tune
        /// </summary>
        public IXPDataRef<int> rel_g430_rad2_tune { get { return m_data.GetInt("sim/operation/failures/rel_g430_rad2_tune");} }

        /// <summary>
        ///  GIA 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_gia1
        /// </summary>
        public IXPDataRef<int> rel_g_gia1 { get { return m_data.GetInt("sim/operation/failures/rel_g_gia1");} }

        /// <summary>
        ///  GIA 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_gia2
        /// </summary>
        public IXPDataRef<int> rel_g_gia2 { get { return m_data.GetInt("sim/operation/failures/rel_g_gia2");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_gea
        /// </summary>
        public IXPDataRef<int> rel_g_gea { get { return m_data.GetInt("sim/operation/failures/rel_g_gea");} }

        /// <summary>
        ///  air data computer. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_adc_comp
        /// </summary>
        public IXPDataRef<int> rel_adc_comp { get { return m_data.GetInt("sim/operation/failures/rel_adc_comp");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_arthorz
        /// </summary>
        public IXPDataRef<int> rel_g_arthorz { get { return m_data.GetInt("sim/operation/failures/rel_g_arthorz");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_asi
        /// </summary>
        public IXPDataRef<int> rel_g_asi { get { return m_data.GetInt("sim/operation/failures/rel_g_asi");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_alt
        /// </summary>
        public IXPDataRef<int> rel_g_alt { get { return m_data.GetInt("sim/operation/failures/rel_g_alt");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_magmtr
        /// </summary>
        public IXPDataRef<int> rel_g_magmtr { get { return m_data.GetInt("sim/operation/failures/rel_g_magmtr");} }

        /// <summary>
        ///  . Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_vvi
        /// </summary>
        public IXPDataRef<int> rel_g_vvi { get { return m_data.GetInt("sim/operation/failures/rel_g_vvi");} }

        /// <summary>
        ///  nav radio 1 - removed from 10.00 - 10.36, compatibility only in 10.40 - DO NOT USE - use rel_nav1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_navrad1
        /// </summary>
        public IXPDataRef<int> rel_g_navrad1 { get { return m_data.GetInt("sim/operation/failures/rel_g_navrad1");} }

        /// <summary>
        ///  nav radio 2 - removed from 10.00 - 10.36, compatibility only in 10.40 - DO NOT USE - use rel_nav2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_navrad2
        /// </summary>
        public IXPDataRef<int> rel_g_navrad2 { get { return m_data.GetInt("sim/operation/failures/rel_g_navrad2");} }

        /// <summary>
        ///  com radio 1 - removed from 10.00 - 10.36, compatibility only in 10.40 - DO NOT USE - use rel_com1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_comrad1
        /// </summary>
        public IXPDataRef<int> rel_g_comrad1 { get { return m_data.GetInt("sim/operation/failures/rel_g_comrad1");} }

        /// <summary>
        ///  com radio 2 - removed from 10.00 - 10.36, compatibility only in 10.40 - DO NOT USE - use rel_com2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_comrad2
        /// </summary>
        public IXPDataRef<int> rel_g_comrad2 { get { return m_data.GetInt("sim/operation/failures/rel_g_comrad2");} }

        /// <summary>
        ///  transponder removed from 10.00 - 10.36, compatibility only in 10.40+ - DO NOT USE - use rel_xpndr. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_xpndr
        /// </summary>
        public IXPDataRef<int> rel_g_xpndr { get { return m_data.GetInt("sim/operation/failures/rel_g_xpndr");} }

        /// <summary>
        ///  generator amperage 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_gen1
        /// </summary>
        public IXPDataRef<int> rel_g_gen1 { get { return m_data.GetInt("sim/operation/failures/rel_g_gen1");} }

        /// <summary>
        ///  generator amperage 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_gen2
        /// </summary>
        public IXPDataRef<int> rel_g_gen2 { get { return m_data.GetInt("sim/operation/failures/rel_g_gen2");} }

        /// <summary>
        ///  battery voltage 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_bat1
        /// </summary>
        public IXPDataRef<int> rel_g_bat1 { get { return m_data.GetInt("sim/operation/failures/rel_g_bat1");} }

        /// <summary>
        ///  battery voltage 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_bat2
        /// </summary>
        public IXPDataRef<int> rel_g_bat2 { get { return m_data.GetInt("sim/operation/failures/rel_g_bat2");} }

        /// <summary>
        ///  bus voltage 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_bus1
        /// </summary>
        public IXPDataRef<int> rel_g_bus1 { get { return m_data.GetInt("sim/operation/failures/rel_g_bus1");} }

        /// <summary>
        ///  bus voltage 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_g_bus2
        /// </summary>
        public IXPDataRef<int> rel_g_bus2 { get { return m_data.GetInt("sim/operation/failures/rel_g_bus2");} }

        /// <summary>
        ///  Left Magneto Fail - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT0
        /// </summary>
        public IXPDataRef<int> rel_magLFT0 { get { return m_data.GetInt("sim/operation/failures/rel_maglft0");} }

        /// <summary>
        ///  Left Magneto Fail - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT1
        /// </summary>
        public IXPDataRef<int> rel_magLFT1 { get { return m_data.GetInt("sim/operation/failures/rel_maglft1");} }

        /// <summary>
        ///  Left Magneto Fail - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT2
        /// </summary>
        public IXPDataRef<int> rel_magLFT2 { get { return m_data.GetInt("sim/operation/failures/rel_maglft2");} }

        /// <summary>
        ///  Left Magneto Fail - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT3
        /// </summary>
        public IXPDataRef<int> rel_magLFT3 { get { return m_data.GetInt("sim/operation/failures/rel_maglft3");} }

        /// <summary>
        ///  Left Magneto Fail - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT4
        /// </summary>
        public IXPDataRef<int> rel_magLFT4 { get { return m_data.GetInt("sim/operation/failures/rel_maglft4");} }

        /// <summary>
        ///  Left Magneto Fail - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT5
        /// </summary>
        public IXPDataRef<int> rel_magLFT5 { get { return m_data.GetInt("sim/operation/failures/rel_maglft5");} }

        /// <summary>
        ///  Left Magneto Fail - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT6
        /// </summary>
        public IXPDataRef<int> rel_magLFT6 { get { return m_data.GetInt("sim/operation/failures/rel_maglft6");} }

        /// <summary>
        ///  Left Magneto Fail - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magLFT7
        /// </summary>
        public IXPDataRef<int> rel_magLFT7 { get { return m_data.GetInt("sim/operation/failures/rel_maglft7");} }

        /// <summary>
        ///  Right Magneto Fail - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT0
        /// </summary>
        public IXPDataRef<int> rel_magRGT0 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt0");} }

        /// <summary>
        ///  Right Magneto Fail - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT1
        /// </summary>
        public IXPDataRef<int> rel_magRGT1 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt1");} }

        /// <summary>
        ///  Right Magneto Fail - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT2
        /// </summary>
        public IXPDataRef<int> rel_magRGT2 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt2");} }

        /// <summary>
        ///  Right Magneto Fail - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT3
        /// </summary>
        public IXPDataRef<int> rel_magRGT3 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt3");} }

        /// <summary>
        ///  Right Magneto Fail - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT4
        /// </summary>
        public IXPDataRef<int> rel_magRGT4 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt4");} }

        /// <summary>
        ///  Right Magneto Fail - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT5
        /// </summary>
        public IXPDataRef<int> rel_magRGT5 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt5");} }

        /// <summary>
        ///  Right Magneto Fail - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT6
        /// </summary>
        public IXPDataRef<int> rel_magRGT6 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt6");} }

        /// <summary>
        ///  Right Magneto Fail - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_magRGT7
        /// </summary>
        public IXPDataRef<int> rel_magRGT7 { get { return m_data.GetInt("sim/operation/failures/rel_magrgt7");} }

        /// <summary>
        ///  Engine Failure - engine 1 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir0
        /// </summary>
        public IXPDataRef<int> rel_engfir0 { get { return m_data.GetInt("sim/operation/failures/rel_engfir0");} }

        /// <summary>
        ///  Engine Failure - engine 2 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir1
        /// </summary>
        public IXPDataRef<int> rel_engfir1 { get { return m_data.GetInt("sim/operation/failures/rel_engfir1");} }

        /// <summary>
        ///  Engine Failure - engine 3 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir2
        /// </summary>
        public IXPDataRef<int> rel_engfir2 { get { return m_data.GetInt("sim/operation/failures/rel_engfir2");} }

        /// <summary>
        ///  Engine Failure - engine 4 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir3
        /// </summary>
        public IXPDataRef<int> rel_engfir3 { get { return m_data.GetInt("sim/operation/failures/rel_engfir3");} }

        /// <summary>
        ///  Engine Failure - engine 5 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir4
        /// </summary>
        public IXPDataRef<int> rel_engfir4 { get { return m_data.GetInt("sim/operation/failures/rel_engfir4");} }

        /// <summary>
        ///  Engine Failure - engine 6 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir5
        /// </summary>
        public IXPDataRef<int> rel_engfir5 { get { return m_data.GetInt("sim/operation/failures/rel_engfir5");} }

        /// <summary>
        ///  Engine Failure - engine 7 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir6
        /// </summary>
        public IXPDataRef<int> rel_engfir6 { get { return m_data.GetInt("sim/operation/failures/rel_engfir6");} }

        /// <summary>
        ///  Engine Failure - engine 8 Fire. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfir7
        /// </summary>
        public IXPDataRef<int> rel_engfir7 { get { return m_data.GetInt("sim/operation/failures/rel_engfir7");} }

        /// <summary>
        ///  Engine Failure - engine 1 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla0
        /// </summary>
        public IXPDataRef<int> rel_engfla0 { get { return m_data.GetInt("sim/operation/failures/rel_engfla0");} }

        /// <summary>
        ///  Engine Failure - engine 2 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla1
        /// </summary>
        public IXPDataRef<int> rel_engfla1 { get { return m_data.GetInt("sim/operation/failures/rel_engfla1");} }

        /// <summary>
        ///  Engine Failure - engine 3 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla2
        /// </summary>
        public IXPDataRef<int> rel_engfla2 { get { return m_data.GetInt("sim/operation/failures/rel_engfla2");} }

        /// <summary>
        ///  Engine Failure - engine 4 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla3
        /// </summary>
        public IXPDataRef<int> rel_engfla3 { get { return m_data.GetInt("sim/operation/failures/rel_engfla3");} }

        /// <summary>
        ///  Engine Failure - engine 5 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla4
        /// </summary>
        public IXPDataRef<int> rel_engfla4 { get { return m_data.GetInt("sim/operation/failures/rel_engfla4");} }

        /// <summary>
        ///  Engine Failure - engine 6 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla5
        /// </summary>
        public IXPDataRef<int> rel_engfla5 { get { return m_data.GetInt("sim/operation/failures/rel_engfla5");} }

        /// <summary>
        ///  Engine Failure - engine 7 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla6
        /// </summary>
        public IXPDataRef<int> rel_engfla6 { get { return m_data.GetInt("sim/operation/failures/rel_engfla6");} }

        /// <summary>
        ///  Engine Failure - engine 8 Flameout. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfla7
        /// </summary>
        public IXPDataRef<int> rel_engfla7 { get { return m_data.GetInt("sim/operation/failures/rel_engfla7");} }

        /// <summary>
        ///  Engine Failure - engine 1 loss of power without smoke. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai0
        /// </summary>
        public IXPDataRef<int> rel_engfai0 { get { return m_data.GetInt("sim/operation/failures/rel_engfai0");} }

        /// <summary>
        ///  Engine Failure - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai1
        /// </summary>
        public IXPDataRef<int> rel_engfai1 { get { return m_data.GetInt("sim/operation/failures/rel_engfai1");} }

        /// <summary>
        ///  Engine Failure - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai2
        /// </summary>
        public IXPDataRef<int> rel_engfai2 { get { return m_data.GetInt("sim/operation/failures/rel_engfai2");} }

        /// <summary>
        ///  Engine Failure - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai3
        /// </summary>
        public IXPDataRef<int> rel_engfai3 { get { return m_data.GetInt("sim/operation/failures/rel_engfai3");} }

        /// <summary>
        ///  Engine Failure - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai4
        /// </summary>
        public IXPDataRef<int> rel_engfai4 { get { return m_data.GetInt("sim/operation/failures/rel_engfai4");} }

        /// <summary>
        ///  Engine Failure - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai5
        /// </summary>
        public IXPDataRef<int> rel_engfai5 { get { return m_data.GetInt("sim/operation/failures/rel_engfai5");} }

        /// <summary>
        ///  Engine Failure - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai6
        /// </summary>
        public IXPDataRef<int> rel_engfai6 { get { return m_data.GetInt("sim/operation/failures/rel_engfai6");} }

        /// <summary>
        ///  Engine Failure - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engfai7
        /// </summary>
        public IXPDataRef<int> rel_engfai7 { get { return m_data.GetInt("sim/operation/failures/rel_engfai7");} }

        /// <summary>
        ///  Engine Separation - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep0
        /// </summary>
        public IXPDataRef<int> rel_engsep0 { get { return m_data.GetInt("sim/operation/failures/rel_engsep0");} }

        /// <summary>
        ///  Engine Separation - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep1
        /// </summary>
        public IXPDataRef<int> rel_engsep1 { get { return m_data.GetInt("sim/operation/failures/rel_engsep1");} }

        /// <summary>
        ///  Engine Separation - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep2
        /// </summary>
        public IXPDataRef<int> rel_engsep2 { get { return m_data.GetInt("sim/operation/failures/rel_engsep2");} }

        /// <summary>
        ///  Engine Separation - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep3
        /// </summary>
        public IXPDataRef<int> rel_engsep3 { get { return m_data.GetInt("sim/operation/failures/rel_engsep3");} }

        /// <summary>
        ///  Engine Separation - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep4
        /// </summary>
        public IXPDataRef<int> rel_engsep4 { get { return m_data.GetInt("sim/operation/failures/rel_engsep4");} }

        /// <summary>
        ///  Engine Separation - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep5
        /// </summary>
        public IXPDataRef<int> rel_engsep5 { get { return m_data.GetInt("sim/operation/failures/rel_engsep5");} }

        /// <summary>
        ///  Engine Separation - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep6
        /// </summary>
        public IXPDataRef<int> rel_engsep6 { get { return m_data.GetInt("sim/operation/failures/rel_engsep6");} }

        /// <summary>
        ///  Engine Separation - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_engsep7
        /// </summary>
        public IXPDataRef<int> rel_engsep7 { get { return m_data.GetInt("sim/operation/failures/rel_engsep7");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 1 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp0
        /// </summary>
        public IXPDataRef<int> rel_fuepmp0 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp0");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 2 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp1
        /// </summary>
        public IXPDataRef<int> rel_fuepmp1 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp1");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 3 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp2
        /// </summary>
        public IXPDataRef<int> rel_fuepmp2 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp2");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 4 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp3
        /// </summary>
        public IXPDataRef<int> rel_fuepmp3 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp3");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 5 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp4
        /// </summary>
        public IXPDataRef<int> rel_fuepmp4 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp4");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 6 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp5
        /// </summary>
        public IXPDataRef<int> rel_fuepmp5 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp5");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 7 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp6
        /// </summary>
        public IXPDataRef<int> rel_fuepmp6 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp6");} }

        /// <summary>
        ///  Fuel Pump Inop - engine 8 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuepmp7
        /// </summary>
        public IXPDataRef<int> rel_fuepmp7 { get { return m_data.GetInt("sim/operation/failures/rel_fuepmp7");} }

        /// <summary>
        ///  Fuel Pump - engine 1 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp0
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp0 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp0");} }

        /// <summary>
        ///  Fuel Pump - engine 2 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp1
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp1 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp1");} }

        /// <summary>
        ///  Fuel Pump - engine 3 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp2
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp2 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp2");} }

        /// <summary>
        ///  Fuel Pump - engine 4 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp3
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp3 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp3");} }

        /// <summary>
        ///  Fuel Pump - engine 5 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp4
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp4 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp4");} }

        /// <summary>
        ///  Fuel Pump - engine 6 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp5
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp5 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp5");} }

        /// <summary>
        ///  Fuel Pump - engine 7 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp6
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp6 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp6");} }

        /// <summary>
        ///  Fuel Pump - engine 8 (electric driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ele_fuepmp7
        /// </summary>
        public IXPDataRef<int> rel_ele_fuepmp7 { get { return m_data.GetInt("sim/operation/failures/rel_ele_fuepmp7");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 1 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo0
        /// </summary>
        public IXPDataRef<int> rel_eng_lo0 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo0");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 2 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo1
        /// </summary>
        public IXPDataRef<int> rel_eng_lo1 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo1");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 3 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo2
        /// </summary>
        public IXPDataRef<int> rel_eng_lo2 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo2");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 4 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo3
        /// </summary>
        public IXPDataRef<int> rel_eng_lo3 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo3");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 5 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo4
        /// </summary>
        public IXPDataRef<int> rel_eng_lo4 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo4");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 6 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo5
        /// </summary>
        public IXPDataRef<int> rel_eng_lo5 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo5");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 7 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo6
        /// </summary>
        public IXPDataRef<int> rel_eng_lo6 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo6");} }

        /// <summary>
        ///  Fuel Pump Low Pressure - engine 8 (engine driven). Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_eng_lo7
        /// </summary>
        public IXPDataRef<int> rel_eng_lo7 { get { return m_data.GetInt("sim/operation/failures/rel_eng_lo7");} }

        /// <summary>
        ///  Airflow restricted - Engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres0
        /// </summary>
        public IXPDataRef<int> rel_airres0 { get { return m_data.GetInt("sim/operation/failures/rel_airres0");} }

        /// <summary>
        ///  Airflow restricted - Engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres1
        /// </summary>
        public IXPDataRef<int> rel_airres1 { get { return m_data.GetInt("sim/operation/failures/rel_airres1");} }

        /// <summary>
        ///  Airflow restricted - Engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres2
        /// </summary>
        public IXPDataRef<int> rel_airres2 { get { return m_data.GetInt("sim/operation/failures/rel_airres2");} }

        /// <summary>
        ///  Airflow restricted - Engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres3
        /// </summary>
        public IXPDataRef<int> rel_airres3 { get { return m_data.GetInt("sim/operation/failures/rel_airres3");} }

        /// <summary>
        ///  Airflow restricted - Engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres4
        /// </summary>
        public IXPDataRef<int> rel_airres4 { get { return m_data.GetInt("sim/operation/failures/rel_airres4");} }

        /// <summary>
        ///  Airflow restricted - Engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres5
        /// </summary>
        public IXPDataRef<int> rel_airres5 { get { return m_data.GetInt("sim/operation/failures/rel_airres5");} }

        /// <summary>
        ///  Airflow restricted - Engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres6
        /// </summary>
        public IXPDataRef<int> rel_airres6 { get { return m_data.GetInt("sim/operation/failures/rel_airres6");} }

        /// <summary>
        ///  Airflow restricted - Engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_airres7
        /// </summary>
        public IXPDataRef<int> rel_airres7 { get { return m_data.GetInt("sim/operation/failures/rel_airres7");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl0
        /// </summary>
        public IXPDataRef<int> rel_fuelfl0 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl0");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl1
        /// </summary>
        public IXPDataRef<int> rel_fuelfl1 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl1");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl2
        /// </summary>
        public IXPDataRef<int> rel_fuelfl2 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl2");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl3
        /// </summary>
        public IXPDataRef<int> rel_fuelfl3 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl3");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl4
        /// </summary>
        public IXPDataRef<int> rel_fuelfl4 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl4");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl5
        /// </summary>
        public IXPDataRef<int> rel_fuelfl5 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl5");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl6
        /// </summary>
        public IXPDataRef<int> rel_fuelfl6 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl6");} }

        /// <summary>
        ///  Fuel Flow Fluctuation - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fuelfl7
        /// </summary>
        public IXPDataRef<int> rel_fuelfl7 { get { return m_data.GetInt("sim/operation/failures/rel_fuelfl7");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta0
        /// </summary>
        public IXPDataRef<int> rel_comsta0 { get { return m_data.GetInt("sim/operation/failures/rel_comsta0");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta1
        /// </summary>
        public IXPDataRef<int> rel_comsta1 { get { return m_data.GetInt("sim/operation/failures/rel_comsta1");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta2
        /// </summary>
        public IXPDataRef<int> rel_comsta2 { get { return m_data.GetInt("sim/operation/failures/rel_comsta2");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta3
        /// </summary>
        public IXPDataRef<int> rel_comsta3 { get { return m_data.GetInt("sim/operation/failures/rel_comsta3");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta4
        /// </summary>
        public IXPDataRef<int> rel_comsta4 { get { return m_data.GetInt("sim/operation/failures/rel_comsta4");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta5
        /// </summary>
        public IXPDataRef<int> rel_comsta5 { get { return m_data.GetInt("sim/operation/failures/rel_comsta5");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta6
        /// </summary>
        public IXPDataRef<int> rel_comsta6 { get { return m_data.GetInt("sim/operation/failures/rel_comsta6");} }

        /// <summary>
        ///  Engine Compressor Stall - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_comsta7
        /// </summary>
        public IXPDataRef<int> rel_comsta7 { get { return m_data.GetInt("sim/operation/failures/rel_comsta7");} }

        /// <summary>
        ///  Starter - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr0
        /// </summary>
        public IXPDataRef<int> rel_startr0 { get { return m_data.GetInt("sim/operation/failures/rel_startr0");} }

        /// <summary>
        ///  Starter - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr1
        /// </summary>
        public IXPDataRef<int> rel_startr1 { get { return m_data.GetInt("sim/operation/failures/rel_startr1");} }

        /// <summary>
        ///  Starter - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr2
        /// </summary>
        public IXPDataRef<int> rel_startr2 { get { return m_data.GetInt("sim/operation/failures/rel_startr2");} }

        /// <summary>
        ///  Starter - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr3
        /// </summary>
        public IXPDataRef<int> rel_startr3 { get { return m_data.GetInt("sim/operation/failures/rel_startr3");} }

        /// <summary>
        ///  Starter - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr4
        /// </summary>
        public IXPDataRef<int> rel_startr4 { get { return m_data.GetInt("sim/operation/failures/rel_startr4");} }

        /// <summary>
        ///  Starter - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr5
        /// </summary>
        public IXPDataRef<int> rel_startr5 { get { return m_data.GetInt("sim/operation/failures/rel_startr5");} }

        /// <summary>
        ///  Starter - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr6
        /// </summary>
        public IXPDataRef<int> rel_startr6 { get { return m_data.GetInt("sim/operation/failures/rel_startr6");} }

        /// <summary>
        ///  Starter - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_startr7
        /// </summary>
        public IXPDataRef<int> rel_startr7 { get { return m_data.GetInt("sim/operation/failures/rel_startr7");} }

        /// <summary>
        ///  Ignitor - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr0
        /// </summary>
        public IXPDataRef<int> rel_ignitr0 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr0");} }

        /// <summary>
        ///  Ignitor - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr1
        /// </summary>
        public IXPDataRef<int> rel_ignitr1 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr1");} }

        /// <summary>
        ///  Ignitor - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr2
        /// </summary>
        public IXPDataRef<int> rel_ignitr2 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr2");} }

        /// <summary>
        ///  Ignitor - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr3
        /// </summary>
        public IXPDataRef<int> rel_ignitr3 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr3");} }

        /// <summary>
        ///  Ignitor - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr4
        /// </summary>
        public IXPDataRef<int> rel_ignitr4 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr4");} }

        /// <summary>
        ///  Ignitor - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr5
        /// </summary>
        public IXPDataRef<int> rel_ignitr5 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr5");} }

        /// <summary>
        ///  Ignitor - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr6
        /// </summary>
        public IXPDataRef<int> rel_ignitr6 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr6");} }

        /// <summary>
        ///  Ignitor - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ignitr7
        /// </summary>
        public IXPDataRef<int> rel_ignitr7 { get { return m_data.GetInt("sim/operation/failures/rel_ignitr7");} }

        /// <summary>
        ///  Hung Start - engine 0. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta0
        /// </summary>
        public IXPDataRef<int> rel_hunsta0 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta0");} }

        /// <summary>
        ///  Hung Start - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta1
        /// </summary>
        public IXPDataRef<int> rel_hunsta1 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta1");} }

        /// <summary>
        ///  Hung Start - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta2
        /// </summary>
        public IXPDataRef<int> rel_hunsta2 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta2");} }

        /// <summary>
        ///  Hung Start - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta3
        /// </summary>
        public IXPDataRef<int> rel_hunsta3 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta3");} }

        /// <summary>
        ///  Hung Start - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta4
        /// </summary>
        public IXPDataRef<int> rel_hunsta4 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta4");} }

        /// <summary>
        ///  Hung Start - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta5
        /// </summary>
        public IXPDataRef<int> rel_hunsta5 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta5");} }

        /// <summary>
        ///  Hung Start - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta6
        /// </summary>
        public IXPDataRef<int> rel_hunsta6 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta6");} }

        /// <summary>
        ///  Hung Start - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hunsta7
        /// </summary>
        public IXPDataRef<int> rel_hunsta7 { get { return m_data.GetInt("sim/operation/failures/rel_hunsta7");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz0
        /// </summary>
        public IXPDataRef<int> rel_clonoz0 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz0");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz1
        /// </summary>
        public IXPDataRef<int> rel_clonoz1 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz1");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz2
        /// </summary>
        public IXPDataRef<int> rel_clonoz2 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz2");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz3
        /// </summary>
        public IXPDataRef<int> rel_clonoz3 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz3");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz4
        /// </summary>
        public IXPDataRef<int> rel_clonoz4 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz4");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz5
        /// </summary>
        public IXPDataRef<int> rel_clonoz5 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz5");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz6
        /// </summary>
        public IXPDataRef<int> rel_clonoz6 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz6");} }

        /// <summary>
        ///  Hung start (clogged nozzles) - Engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_clonoz7
        /// </summary>
        public IXPDataRef<int> rel_clonoz7 { get { return m_data.GetInt("sim/operation/failures/rel_clonoz7");} }

        /// <summary>
        ///  Hot Start - engine 0. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta0
        /// </summary>
        public IXPDataRef<int> rel_hotsta0 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta0");} }

        /// <summary>
        ///  Hot Start - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta1
        /// </summary>
        public IXPDataRef<int> rel_hotsta1 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta1");} }

        /// <summary>
        ///  Hot Start - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta2
        /// </summary>
        public IXPDataRef<int> rel_hotsta2 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta2");} }

        /// <summary>
        ///  Hot Start - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta3
        /// </summary>
        public IXPDataRef<int> rel_hotsta3 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta3");} }

        /// <summary>
        ///  Hot Start - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta4
        /// </summary>
        public IXPDataRef<int> rel_hotsta4 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta4");} }

        /// <summary>
        ///  Hot Start - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta5
        /// </summary>
        public IXPDataRef<int> rel_hotsta5 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta5");} }

        /// <summary>
        ///  Hot Start - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta6
        /// </summary>
        public IXPDataRef<int> rel_hotsta6 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta6");} }

        /// <summary>
        ///  Hot Start - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hotsta7
        /// </summary>
        public IXPDataRef<int> rel_hotsta7 { get { return m_data.GetInt("sim/operation/failures/rel_hotsta7");} }

        /// <summary>
        ///  Runway Hot ITT - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT0
        /// </summary>
        public IXPDataRef<int> rel_runITT0 { get { return m_data.GetInt("sim/operation/failures/rel_runitt0");} }

        /// <summary>
        ///  Runway Hot ITT - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT1
        /// </summary>
        public IXPDataRef<int> rel_runITT1 { get { return m_data.GetInt("sim/operation/failures/rel_runitt1");} }

        /// <summary>
        ///  Runway Hot ITT - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT2
        /// </summary>
        public IXPDataRef<int> rel_runITT2 { get { return m_data.GetInt("sim/operation/failures/rel_runitt2");} }

        /// <summary>
        ///  Runway Hot ITT - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT3
        /// </summary>
        public IXPDataRef<int> rel_runITT3 { get { return m_data.GetInt("sim/operation/failures/rel_runitt3");} }

        /// <summary>
        ///  Runway Hot ITT - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT4
        /// </summary>
        public IXPDataRef<int> rel_runITT4 { get { return m_data.GetInt("sim/operation/failures/rel_runitt4");} }

        /// <summary>
        ///  Runway Hot ITT - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT5
        /// </summary>
        public IXPDataRef<int> rel_runITT5 { get { return m_data.GetInt("sim/operation/failures/rel_runitt5");} }

        /// <summary>
        ///  Runway Hot ITT - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT6
        /// </summary>
        public IXPDataRef<int> rel_runITT6 { get { return m_data.GetInt("sim/operation/failures/rel_runitt6");} }

        /// <summary>
        ///  Runway Hot ITT - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_runITT7
        /// </summary>
        public IXPDataRef<int> rel_runITT7 { get { return m_data.GetInt("sim/operation/failures/rel_runitt7");} }

        /// <summary>
        ///  Generator - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera0
        /// </summary>
        public IXPDataRef<int> rel_genera0 { get { return m_data.GetInt("sim/operation/failures/rel_genera0");} }

        /// <summary>
        ///  Generator - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera1
        /// </summary>
        public IXPDataRef<int> rel_genera1 { get { return m_data.GetInt("sim/operation/failures/rel_genera1");} }

        /// <summary>
        ///  Generator - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera2
        /// </summary>
        public IXPDataRef<int> rel_genera2 { get { return m_data.GetInt("sim/operation/failures/rel_genera2");} }

        /// <summary>
        ///  Generator - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera3
        /// </summary>
        public IXPDataRef<int> rel_genera3 { get { return m_data.GetInt("sim/operation/failures/rel_genera3");} }

        /// <summary>
        ///  Generator - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera4
        /// </summary>
        public IXPDataRef<int> rel_genera4 { get { return m_data.GetInt("sim/operation/failures/rel_genera4");} }

        /// <summary>
        ///  Generator - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera5
        /// </summary>
        public IXPDataRef<int> rel_genera5 { get { return m_data.GetInt("sim/operation/failures/rel_genera5");} }

        /// <summary>
        ///  Generator - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera6
        /// </summary>
        public IXPDataRef<int> rel_genera6 { get { return m_data.GetInt("sim/operation/failures/rel_genera6");} }

        /// <summary>
        ///  Generator - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_genera7
        /// </summary>
        public IXPDataRef<int> rel_genera7 { get { return m_data.GetInt("sim/operation/failures/rel_genera7");} }

        /// <summary>
        ///  Battery 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter0
        /// </summary>
        public IXPDataRef<int> rel_batter0 { get { return m_data.GetInt("sim/operation/failures/rel_batter0");} }

        /// <summary>
        ///  Battery 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter1
        /// </summary>
        public IXPDataRef<int> rel_batter1 { get { return m_data.GetInt("sim/operation/failures/rel_batter1");} }

        /// <summary>
        ///  Battery 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter2
        /// </summary>
        public IXPDataRef<int> rel_batter2 { get { return m_data.GetInt("sim/operation/failures/rel_batter2");} }

        /// <summary>
        ///  Battery 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter3
        /// </summary>
        public IXPDataRef<int> rel_batter3 { get { return m_data.GetInt("sim/operation/failures/rel_batter3");} }

        /// <summary>
        ///  Battery 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter4
        /// </summary>
        public IXPDataRef<int> rel_batter4 { get { return m_data.GetInt("sim/operation/failures/rel_batter4");} }

        /// <summary>
        ///  Battery 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter5
        /// </summary>
        public IXPDataRef<int> rel_batter5 { get { return m_data.GetInt("sim/operation/failures/rel_batter5");} }

        /// <summary>
        ///  Battery 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter6
        /// </summary>
        public IXPDataRef<int> rel_batter6 { get { return m_data.GetInt("sim/operation/failures/rel_batter6");} }

        /// <summary>
        ///  Battery 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_batter7
        /// </summary>
        public IXPDataRef<int> rel_batter7 { get { return m_data.GetInt("sim/operation/failures/rel_batter7");} }

        /// <summary>
        ///  Governor throttle fail - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_0
        /// </summary>
        public IXPDataRef<int> rel_govnr_0 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_0");} }

        /// <summary>
        ///  Governor throttle fail - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_1
        /// </summary>
        public IXPDataRef<int> rel_govnr_1 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_1");} }

        /// <summary>
        ///  Governor throttle fail - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_2
        /// </summary>
        public IXPDataRef<int> rel_govnr_2 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_2");} }

        /// <summary>
        ///  Governor throttle fail - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_3
        /// </summary>
        public IXPDataRef<int> rel_govnr_3 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_3");} }

        /// <summary>
        ///  Governor throttle fail - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_4
        /// </summary>
        public IXPDataRef<int> rel_govnr_4 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_4");} }

        /// <summary>
        ///  Governor throttle fail - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_5
        /// </summary>
        public IXPDataRef<int> rel_govnr_5 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_5");} }

        /// <summary>
        ///  Governor throttle fail - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_6
        /// </summary>
        public IXPDataRef<int> rel_govnr_6 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_6");} }

        /// <summary>
        ///  Governor throttle fail - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_govnr_7
        /// </summary>
        public IXPDataRef<int> rel_govnr_7 { get { return m_data.GetInt("sim/operation/failures/rel_govnr_7");} }

        /// <summary>
        ///  Fadec - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_0
        /// </summary>
        public IXPDataRef<int> rel_fadec_0 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_0");} }

        /// <summary>
        ///  Fadec - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_1
        /// </summary>
        public IXPDataRef<int> rel_fadec_1 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_1");} }

        /// <summary>
        ///  Fadec - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_2
        /// </summary>
        public IXPDataRef<int> rel_fadec_2 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_2");} }

        /// <summary>
        ///  Fadec - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_3
        /// </summary>
        public IXPDataRef<int> rel_fadec_3 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_3");} }

        /// <summary>
        ///  Fadec - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_4
        /// </summary>
        public IXPDataRef<int> rel_fadec_4 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_4");} }

        /// <summary>
        ///  Fadec - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_5
        /// </summary>
        public IXPDataRef<int> rel_fadec_5 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_5");} }

        /// <summary>
        ///  Fadec - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_6
        /// </summary>
        public IXPDataRef<int> rel_fadec_6 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_6");} }

        /// <summary>
        ///  Fadec - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_fadec_7
        /// </summary>
        public IXPDataRef<int> rel_fadec_7 { get { return m_data.GetInt("sim/operation/failures/rel_fadec_7");} }

        /// <summary>
        ///  Oil Pump - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp0
        /// </summary>
        public IXPDataRef<int> rel_oilpmp0 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp0");} }

        /// <summary>
        ///  Oil Pump - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp1
        /// </summary>
        public IXPDataRef<int> rel_oilpmp1 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp1");} }

        /// <summary>
        ///  Oil Pump - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp2
        /// </summary>
        public IXPDataRef<int> rel_oilpmp2 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp2");} }

        /// <summary>
        ///  Oil Pump - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp3
        /// </summary>
        public IXPDataRef<int> rel_oilpmp3 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp3");} }

        /// <summary>
        ///  Oil Pump - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp4
        /// </summary>
        public IXPDataRef<int> rel_oilpmp4 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp4");} }

        /// <summary>
        ///  Oil Pump - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp5
        /// </summary>
        public IXPDataRef<int> rel_oilpmp5 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp5");} }

        /// <summary>
        ///  Oil Pump - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp6
        /// </summary>
        public IXPDataRef<int> rel_oilpmp6 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp6");} }

        /// <summary>
        ///  Oil Pump - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_oilpmp7
        /// </summary>
        public IXPDataRef<int> rel_oilpmp7 { get { return m_data.GetInt("sim/operation/failures/rel_oilpmp7");} }

        /// <summary>
        ///  Chip Detected - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde0
        /// </summary>
        public IXPDataRef<int> rel_chipde0 { get { return m_data.GetInt("sim/operation/failures/rel_chipde0");} }

        /// <summary>
        ///  Chip Detected - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde1
        /// </summary>
        public IXPDataRef<int> rel_chipde1 { get { return m_data.GetInt("sim/operation/failures/rel_chipde1");} }

        /// <summary>
        ///  Chip Detected - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde2
        /// </summary>
        public IXPDataRef<int> rel_chipde2 { get { return m_data.GetInt("sim/operation/failures/rel_chipde2");} }

        /// <summary>
        ///  Chip Detected - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde3
        /// </summary>
        public IXPDataRef<int> rel_chipde3 { get { return m_data.GetInt("sim/operation/failures/rel_chipde3");} }

        /// <summary>
        ///  Chip Detected - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde4
        /// </summary>
        public IXPDataRef<int> rel_chipde4 { get { return m_data.GetInt("sim/operation/failures/rel_chipde4");} }

        /// <summary>
        ///  Chip Detected - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde5
        /// </summary>
        public IXPDataRef<int> rel_chipde5 { get { return m_data.GetInt("sim/operation/failures/rel_chipde5");} }

        /// <summary>
        ///  Chip Detected - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde6
        /// </summary>
        public IXPDataRef<int> rel_chipde6 { get { return m_data.GetInt("sim/operation/failures/rel_chipde6");} }

        /// <summary>
        ///  Chip Detected - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_chipde7
        /// </summary>
        public IXPDataRef<int> rel_chipde7 { get { return m_data.GetInt("sim/operation/failures/rel_chipde7");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin0
        /// </summary>
        public IXPDataRef<int> rel_prpfin0 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin0");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin1
        /// </summary>
        public IXPDataRef<int> rel_prpfin1 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin1");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin2
        /// </summary>
        public IXPDataRef<int> rel_prpfin2 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin2");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin3
        /// </summary>
        public IXPDataRef<int> rel_prpfin3 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin3");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin4
        /// </summary>
        public IXPDataRef<int> rel_prpfin4 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin4");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin5
        /// </summary>
        public IXPDataRef<int> rel_prpfin5 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin5");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin6
        /// </summary>
        public IXPDataRef<int> rel_prpfin6 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin6");} }

        /// <summary>
        ///  Prop governor fail to fine - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpfin7
        /// </summary>
        public IXPDataRef<int> rel_prpfin7 { get { return m_data.GetInt("sim/operation/failures/rel_prpfin7");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs0
        /// </summary>
        public IXPDataRef<int> rel_prpcrs0 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs0");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs1
        /// </summary>
        public IXPDataRef<int> rel_prpcrs1 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs1");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs2
        /// </summary>
        public IXPDataRef<int> rel_prpcrs2 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs2");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs3
        /// </summary>
        public IXPDataRef<int> rel_prpcrs3 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs3");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs4
        /// </summary>
        public IXPDataRef<int> rel_prpcrs4 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs4");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs5
        /// </summary>
        public IXPDataRef<int> rel_prpcrs5 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs5");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs6
        /// </summary>
        public IXPDataRef<int> rel_prpcrs6 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs6");} }

        /// <summary>
        ///  Prop governor fail to coarse - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_prpcrs7
        /// </summary>
        public IXPDataRef<int> rel_prpcrs7 { get { return m_data.GetInt("sim/operation/failures/rel_prpcrs7");} }

        /// <summary>
        ///  Drive Shaft - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft0
        /// </summary>
        public IXPDataRef<int> rel_pshaft0 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft0");} }

        /// <summary>
        ///  Drive Shaft - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft1
        /// </summary>
        public IXPDataRef<int> rel_pshaft1 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft1");} }

        /// <summary>
        ///  Drive Shaft - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft2
        /// </summary>
        public IXPDataRef<int> rel_pshaft2 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft2");} }

        /// <summary>
        ///  Drive Shaft - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft3
        /// </summary>
        public IXPDataRef<int> rel_pshaft3 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft3");} }

        /// <summary>
        ///  Drive Shaft - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft4
        /// </summary>
        public IXPDataRef<int> rel_pshaft4 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft4");} }

        /// <summary>
        ///  Drive Shaft - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft5
        /// </summary>
        public IXPDataRef<int> rel_pshaft5 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft5");} }

        /// <summary>
        ///  Drive Shaft - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft6
        /// </summary>
        public IXPDataRef<int> rel_pshaft6 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft6");} }

        /// <summary>
        ///  Drive Shaft - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pshaft7
        /// </summary>
        public IXPDataRef<int> rel_pshaft7 { get { return m_data.GetInt("sim/operation/failures/rel_pshaft7");} }

        /// <summary>
        ///  Engine Seize - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_0
        /// </summary>
        public IXPDataRef<int> rel_seize_0 { get { return m_data.GetInt("sim/operation/failures/rel_seize_0");} }

        /// <summary>
        ///  Engine Seize - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_1
        /// </summary>
        public IXPDataRef<int> rel_seize_1 { get { return m_data.GetInt("sim/operation/failures/rel_seize_1");} }

        /// <summary>
        ///  Engine Seize - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_2
        /// </summary>
        public IXPDataRef<int> rel_seize_2 { get { return m_data.GetInt("sim/operation/failures/rel_seize_2");} }

        /// <summary>
        ///  Engine Seize - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_3
        /// </summary>
        public IXPDataRef<int> rel_seize_3 { get { return m_data.GetInt("sim/operation/failures/rel_seize_3");} }

        /// <summary>
        ///  Engine Seize - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_4
        /// </summary>
        public IXPDataRef<int> rel_seize_4 { get { return m_data.GetInt("sim/operation/failures/rel_seize_4");} }

        /// <summary>
        ///  Engine Seize - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_5
        /// </summary>
        public IXPDataRef<int> rel_seize_5 { get { return m_data.GetInt("sim/operation/failures/rel_seize_5");} }

        /// <summary>
        ///  Engine Seize - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_6
        /// </summary>
        public IXPDataRef<int> rel_seize_6 { get { return m_data.GetInt("sim/operation/failures/rel_seize_6");} }

        /// <summary>
        ///  Engine Seize - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_seize_7
        /// </summary>
        public IXPDataRef<int> rel_seize_7 { get { return m_data.GetInt("sim/operation/failures/rel_seize_7");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers0
        /// </summary>
        public IXPDataRef<int> rel_revers0 { get { return m_data.GetInt("sim/operation/failures/rel_revers0");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers1
        /// </summary>
        public IXPDataRef<int> rel_revers1 { get { return m_data.GetInt("sim/operation/failures/rel_revers1");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers2
        /// </summary>
        public IXPDataRef<int> rel_revers2 { get { return m_data.GetInt("sim/operation/failures/rel_revers2");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers3
        /// </summary>
        public IXPDataRef<int> rel_revers3 { get { return m_data.GetInt("sim/operation/failures/rel_revers3");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers4
        /// </summary>
        public IXPDataRef<int> rel_revers4 { get { return m_data.GetInt("sim/operation/failures/rel_revers4");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers5
        /// </summary>
        public IXPDataRef<int> rel_revers5 { get { return m_data.GetInt("sim/operation/failures/rel_revers5");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers6
        /// </summary>
        public IXPDataRef<int> rel_revers6 { get { return m_data.GetInt("sim/operation/failures/rel_revers6");} }

        /// <summary>
        ///  Thrust Reversers Inop - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revers7
        /// </summary>
        public IXPDataRef<int> rel_revers7 { get { return m_data.GetInt("sim/operation/failures/rel_revers7");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep0
        /// </summary>
        public IXPDataRef<int> rel_revdep0 { get { return m_data.GetInt("sim/operation/failures/rel_revdep0");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep1
        /// </summary>
        public IXPDataRef<int> rel_revdep1 { get { return m_data.GetInt("sim/operation/failures/rel_revdep1");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep2
        /// </summary>
        public IXPDataRef<int> rel_revdep2 { get { return m_data.GetInt("sim/operation/failures/rel_revdep2");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep3
        /// </summary>
        public IXPDataRef<int> rel_revdep3 { get { return m_data.GetInt("sim/operation/failures/rel_revdep3");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep4
        /// </summary>
        public IXPDataRef<int> rel_revdep4 { get { return m_data.GetInt("sim/operation/failures/rel_revdep4");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep5
        /// </summary>
        public IXPDataRef<int> rel_revdep5 { get { return m_data.GetInt("sim/operation/failures/rel_revdep5");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep6
        /// </summary>
        public IXPDataRef<int> rel_revdep6 { get { return m_data.GetInt("sim/operation/failures/rel_revdep6");} }

        /// <summary>
        ///  Thrust Reversers Deploy - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revdep7
        /// </summary>
        public IXPDataRef<int> rel_revdep7 { get { return m_data.GetInt("sim/operation/failures/rel_revdep7");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc0
        /// </summary>
        public IXPDataRef<int> rel_revloc0 { get { return m_data.GetInt("sim/operation/failures/rel_revloc0");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc1
        /// </summary>
        public IXPDataRef<int> rel_revloc1 { get { return m_data.GetInt("sim/operation/failures/rel_revloc1");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc2
        /// </summary>
        public IXPDataRef<int> rel_revloc2 { get { return m_data.GetInt("sim/operation/failures/rel_revloc2");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc3
        /// </summary>
        public IXPDataRef<int> rel_revloc3 { get { return m_data.GetInt("sim/operation/failures/rel_revloc3");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc4
        /// </summary>
        public IXPDataRef<int> rel_revloc4 { get { return m_data.GetInt("sim/operation/failures/rel_revloc4");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc5
        /// </summary>
        public IXPDataRef<int> rel_revloc5 { get { return m_data.GetInt("sim/operation/failures/rel_revloc5");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc6
        /// </summary>
        public IXPDataRef<int> rel_revloc6 { get { return m_data.GetInt("sim/operation/failures/rel_revloc6");} }

        /// <summary>
        ///  Thrust Reversers Locked - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_revloc7
        /// </summary>
        public IXPDataRef<int> rel_revloc7 { get { return m_data.GetInt("sim/operation/failures/rel_revloc7");} }

        /// <summary>
        ///  Afterburners - engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur0
        /// </summary>
        public IXPDataRef<int> rel_aftbur0 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur0");} }

        /// <summary>
        ///  Afterburners - engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur1
        /// </summary>
        public IXPDataRef<int> rel_aftbur1 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur1");} }

        /// <summary>
        ///  Afterburners - engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur2
        /// </summary>
        public IXPDataRef<int> rel_aftbur2 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur2");} }

        /// <summary>
        ///  Afterburners - engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur3
        /// </summary>
        public IXPDataRef<int> rel_aftbur3 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur3");} }

        /// <summary>
        ///  Afterburners - engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur4
        /// </summary>
        public IXPDataRef<int> rel_aftbur4 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur4");} }

        /// <summary>
        ///  Afterburners - engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur5
        /// </summary>
        public IXPDataRef<int> rel_aftbur5 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur5");} }

        /// <summary>
        ///  Afterburners - engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur6
        /// </summary>
        public IXPDataRef<int> rel_aftbur6 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur6");} }

        /// <summary>
        ///  Afterburners - engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_aftbur7
        /// </summary>
        public IXPDataRef<int> rel_aftbur7 { get { return m_data.GetInt("sim/operation/failures/rel_aftbur7");} }

        /// <summary>
        ///  Inlet heat, engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat");} }

        /// <summary>
        ///  Inlet heat, engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat2
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat2");} }

        /// <summary>
        ///  Inlet heat, engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat3
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat3 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat3");} }

        /// <summary>
        ///  Inlet heat, engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat4
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat4 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat4");} }

        /// <summary>
        ///  Inlet heat, engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat5
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat5 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat5");} }

        /// <summary>
        ///  Inlet heat, engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat6
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat6 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat6");} }

        /// <summary>
        ///  Inlet heat, engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat7
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat7 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat7");} }

        /// <summary>
        ///  Inlet heat, engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_inlet_heat8
        /// </summary>
        public IXPDataRef<int> rel_ice_inlet_heat8 { get { return m_data.GetInt("sim/operation/failures/rel_ice_inlet_heat8");} }

        /// <summary>
        ///  Prop Heat, engine 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat");} }

        /// <summary>
        ///  Prop Heat, engine 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat2
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat2 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat2");} }

        /// <summary>
        ///  Prop Heat, engine 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat3
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat3 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat3");} }

        /// <summary>
        ///  Prop Heat, engine 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat4
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat4 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat4");} }

        /// <summary>
        ///  Prop Heat, engine 5. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat5
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat5 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat5");} }

        /// <summary>
        ///  Prop Heat, engine 6. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat6
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat6 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat6");} }

        /// <summary>
        ///  Prop Heat, engine 7. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat7
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat7 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat7");} }

        /// <summary>
        ///  Prop Heat, engine 8. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_ice_prop_heat8
        /// </summary>
        public IXPDataRef<int> rel_ice_prop_heat8 { get { return m_data.GetInt("sim/operation/failures/rel_ice_prop_heat8");} }

        /// <summary>
        ///  Wing separations - left wing 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing1L
        /// </summary>
        public IXPDataRef<int> rel_wing1L { get { return m_data.GetInt("sim/operation/failures/rel_wing1l");} }

        /// <summary>
        ///  Wing separations - right wing 1. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing1R
        /// </summary>
        public IXPDataRef<int> rel_wing1R { get { return m_data.GetInt("sim/operation/failures/rel_wing1r");} }

        /// <summary>
        ///  Wing separations - left wing 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing2L
        /// </summary>
        public IXPDataRef<int> rel_wing2L { get { return m_data.GetInt("sim/operation/failures/rel_wing2l");} }

        /// <summary>
        ///  Wing separations - right wing 2. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing2R
        /// </summary>
        public IXPDataRef<int> rel_wing2R { get { return m_data.GetInt("sim/operation/failures/rel_wing2r");} }

        /// <summary>
        ///  Wing separations - left wing 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing3L
        /// </summary>
        public IXPDataRef<int> rel_wing3L { get { return m_data.GetInt("sim/operation/failures/rel_wing3l");} }

        /// <summary>
        ///  Wing separations - right wing 3. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing3R
        /// </summary>
        public IXPDataRef<int> rel_wing3R { get { return m_data.GetInt("sim/operation/failures/rel_wing3r");} }

        /// <summary>
        ///  Wing separations - left wing 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing4L
        /// </summary>
        public IXPDataRef<int> rel_wing4L { get { return m_data.GetInt("sim/operation/failures/rel_wing4l");} }

        /// <summary>
        ///  Wing separations - right wing 4. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_wing4R
        /// </summary>
        public IXPDataRef<int> rel_wing4R { get { return m_data.GetInt("sim/operation/failures/rel_wing4r");} }

        /// <summary>
        ///  Left horizontal stabilizer separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hstbL
        /// </summary>
        public IXPDataRef<int> rel_hstbL { get { return m_data.GetInt("sim/operation/failures/rel_hstbl");} }

        /// <summary>
        ///  Right horizontal stabilizer separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_hstbR
        /// </summary>
        public IXPDataRef<int> rel_hstbR { get { return m_data.GetInt("sim/operation/failures/rel_hstbr");} }

        /// <summary>
        ///  Vertical stabilizer 1 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_vstb1
        /// </summary>
        public IXPDataRef<int> rel_vstb1 { get { return m_data.GetInt("sim/operation/failures/rel_vstb1");} }

        /// <summary>
        ///  Vertical stabilizer 2 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_vstb2
        /// </summary>
        public IXPDataRef<int> rel_vstb2 { get { return m_data.GetInt("sim/operation/failures/rel_vstb2");} }

        /// <summary>
        ///  Misc wing 1 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing1
        /// </summary>
        public IXPDataRef<int> rel_mwing1 { get { return m_data.GetInt("sim/operation/failures/rel_mwing1");} }

        /// <summary>
        ///  Misc wing 2 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing2
        /// </summary>
        public IXPDataRef<int> rel_mwing2 { get { return m_data.GetInt("sim/operation/failures/rel_mwing2");} }

        /// <summary>
        ///  Misc wing 3 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing3
        /// </summary>
        public IXPDataRef<int> rel_mwing3 { get { return m_data.GetInt("sim/operation/failures/rel_mwing3");} }

        /// <summary>
        ///  Misc wing 4 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing4
        /// </summary>
        public IXPDataRef<int> rel_mwing4 { get { return m_data.GetInt("sim/operation/failures/rel_mwing4");} }

        /// <summary>
        ///  Misc wing 5 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing5
        /// </summary>
        public IXPDataRef<int> rel_mwing5 { get { return m_data.GetInt("sim/operation/failures/rel_mwing5");} }

        /// <summary>
        ///  Misc wing 6 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing6
        /// </summary>
        public IXPDataRef<int> rel_mwing6 { get { return m_data.GetInt("sim/operation/failures/rel_mwing6");} }

        /// <summary>
        ///  Misc wing 7 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing7
        /// </summary>
        public IXPDataRef<int> rel_mwing7 { get { return m_data.GetInt("sim/operation/failures/rel_mwing7");} }

        /// <summary>
        ///  Misc wing 8 separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_mwing8
        /// </summary>
        public IXPDataRef<int> rel_mwing8 { get { return m_data.GetInt("sim/operation/failures/rel_mwing8");} }

        /// <summary>
        ///  Engine Pylon 1a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl1a
        /// </summary>
        public IXPDataRef<int> rel_pyl1a { get { return m_data.GetInt("sim/operation/failures/rel_pyl1a");} }

        /// <summary>
        ///  Engine Pylon 2a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl2a
        /// </summary>
        public IXPDataRef<int> rel_pyl2a { get { return m_data.GetInt("sim/operation/failures/rel_pyl2a");} }

        /// <summary>
        ///  Engine Pylon 3a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl3a
        /// </summary>
        public IXPDataRef<int> rel_pyl3a { get { return m_data.GetInt("sim/operation/failures/rel_pyl3a");} }

        /// <summary>
        ///  Engine Pylon 4a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl4a
        /// </summary>
        public IXPDataRef<int> rel_pyl4a { get { return m_data.GetInt("sim/operation/failures/rel_pyl4a");} }

        /// <summary>
        ///  Engine Pylon 5a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl5a
        /// </summary>
        public IXPDataRef<int> rel_pyl5a { get { return m_data.GetInt("sim/operation/failures/rel_pyl5a");} }

        /// <summary>
        ///  Engine Pylon 6a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl6a
        /// </summary>
        public IXPDataRef<int> rel_pyl6a { get { return m_data.GetInt("sim/operation/failures/rel_pyl6a");} }

        /// <summary>
        ///  Engine Pylon 7a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl7a
        /// </summary>
        public IXPDataRef<int> rel_pyl7a { get { return m_data.GetInt("sim/operation/failures/rel_pyl7a");} }

        /// <summary>
        ///  Engine Pylon 8a Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl8a
        /// </summary>
        public IXPDataRef<int> rel_pyl8a { get { return m_data.GetInt("sim/operation/failures/rel_pyl8a");} }

        /// <summary>
        ///  Engine Pylon 1b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl1b
        /// </summary>
        public IXPDataRef<int> rel_pyl1b { get { return m_data.GetInt("sim/operation/failures/rel_pyl1b");} }

        /// <summary>
        ///  Engine Pylon 2b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl2b
        /// </summary>
        public IXPDataRef<int> rel_pyl2b { get { return m_data.GetInt("sim/operation/failures/rel_pyl2b");} }

        /// <summary>
        ///  Engine Pylon 3b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl3b
        /// </summary>
        public IXPDataRef<int> rel_pyl3b { get { return m_data.GetInt("sim/operation/failures/rel_pyl3b");} }

        /// <summary>
        ///  Engine Pylon 4b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl4b
        /// </summary>
        public IXPDataRef<int> rel_pyl4b { get { return m_data.GetInt("sim/operation/failures/rel_pyl4b");} }

        /// <summary>
        ///  Engine Pylon 5b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl5b
        /// </summary>
        public IXPDataRef<int> rel_pyl5b { get { return m_data.GetInt("sim/operation/failures/rel_pyl5b");} }

        /// <summary>
        ///  Engine Pylon 6b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl6b
        /// </summary>
        public IXPDataRef<int> rel_pyl6b { get { return m_data.GetInt("sim/operation/failures/rel_pyl6b");} }

        /// <summary>
        ///  Engine Pylon 7b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl7b
        /// </summary>
        public IXPDataRef<int> rel_pyl7b { get { return m_data.GetInt("sim/operation/failures/rel_pyl7b");} }

        /// <summary>
        ///  Engine Pylon 8b Separate. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_pyl8b
        /// </summary>
        public IXPDataRef<int> rel_pyl8b { get { return m_data.GetInt("sim/operation/failures/rel_pyl8b");} }

        /// <summary>
        ///  General electrical failure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gen_esys
        /// </summary>
        public IXPDataRef<int> rel_gen_esys { get { return m_data.GetInt("sim/operation/failures/rel_gen_esys");} }

        /// <summary>
        ///  General avionics bus failure. Units:failure_enum
        ///  Raw path: sim/operation/failures/rel_gen_avio
        /// </summary>
        public IXPDataRef<int> rel_gen_avio { get { return m_data.GetInt("sim/operation/failures/rel_gen_avio");} }
    }
}