using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_limitsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_limitsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Low value of the green arc for the manifold pressure instrument. Units:inhg
        ///  Raw path: sim/aircraft/limits/green_lo_MP
        /// </summary>
        public IXPDataRef<float> green_lo_MP { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_mp");} }

        /// <summary>
        ///  High value of the green arc for the manifold pressure instrument. Units:inhg
        ///  Raw path: sim/aircraft/limits/green_hi_MP
        /// </summary>
        public IXPDataRef<float> green_hi_MP { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_mp");} }

        /// <summary>
        ///  Low value of the yellow arc for the manifold pressure instrument. Units:inhg
        ///  Raw path: sim/aircraft/limits/yellow_lo_MP
        /// </summary>
        public IXPDataRef<float> yellow_lo_MP { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_mp");} }

        /// <summary>
        ///  High value of the yellow arc for the manifold pressure instrument. Units:inhg
        ///  Raw path: sim/aircraft/limits/yellow_hi_MP
        /// </summary>
        public IXPDataRef<float> yellow_hi_MP { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_mp");} }

        /// <summary>
        ///  Low value of the red arc for the manifold pressure instrument. Units:inhg
        ///  Raw path: sim/aircraft/limits/red_lo_MP
        /// </summary>
        public IXPDataRef<float> red_lo_MP { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_mp");} }

        /// <summary>
        ///  High value of the red arc for the manifold pressure instrument. Units:inhg
        ///  Raw path: sim/aircraft/limits/red_hi_MP
        /// </summary>
        public IXPDataRef<float> red_hi_MP { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_mp");} }

        /// <summary>
        ///  Low value of the green arc for the engine pressure ratio instrument. Units:ratio
        ///  Raw path: sim/aircraft/limits/green_lo_EPR
        /// </summary>
        public IXPDataRef<float> green_lo_EPR { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_epr");} }

        /// <summary>
        ///  High value of the green arc for the engine pressure ratio instrument. Units:ratio
        ///  Raw path: sim/aircraft/limits/green_hi_EPR
        /// </summary>
        public IXPDataRef<float> green_hi_EPR { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_epr");} }

        /// <summary>
        ///  Low value of the yellow arc for the engine pressure ratio instrument. Units:ratio
        ///  Raw path: sim/aircraft/limits/yellow_lo_EPR
        /// </summary>
        public IXPDataRef<float> yellow_lo_EPR { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_epr");} }

        /// <summary>
        ///  High value of the yellow arc for the engine pressure ratio instrument. Units:ratio
        ///  Raw path: sim/aircraft/limits/yellow_hi_EPR
        /// </summary>
        public IXPDataRef<float> yellow_hi_EPR { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_epr");} }

        /// <summary>
        ///  Low value of the red arc for the engine pressure ratio instrument. Units:ratio
        ///  Raw path: sim/aircraft/limits/red_lo_EPR
        /// </summary>
        public IXPDataRef<float> red_lo_EPR { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_epr");} }

        /// <summary>
        ///  High value of the red arc for the engine pressure ratio instrument. Units:ratio
        ///  Raw path: sim/aircraft/limits/red_hi_EPR
        /// </summary>
        public IXPDataRef<float> red_hi_EPR { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_epr");} }

        /// <summary>
        ///  Low value of the green arc for the torque instrument. Units:ft-lbs
        ///  Raw path: sim/aircraft/limits/green_lo_TRQ
        /// </summary>
        public IXPDataRef<float> green_lo_TRQ { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_trq");} }

        /// <summary>
        ///  High value of the green arc for the torque instrument. Units:ft-lbs
        ///  Raw path: sim/aircraft/limits/green_hi_TRQ
        /// </summary>
        public IXPDataRef<float> green_hi_TRQ { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_trq");} }

        /// <summary>
        ///  Low value of the yellow arc for the torque instrument. Units:ft-lbs
        ///  Raw path: sim/aircraft/limits/yellow_lo_TRQ
        /// </summary>
        public IXPDataRef<float> yellow_lo_TRQ { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_trq");} }

        /// <summary>
        ///  High value of the yellow arc for the torque instrument. Units:ft-lbs
        ///  Raw path: sim/aircraft/limits/yellow_hi_TRQ
        /// </summary>
        public IXPDataRef<float> yellow_hi_TRQ { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_trq");} }

        /// <summary>
        ///  Low value of the red arc for the torque instrument. Units:ft-lbs
        ///  Raw path: sim/aircraft/limits/red_lo_TRQ
        /// </summary>
        public IXPDataRef<float> red_lo_TRQ { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_trq");} }

        /// <summary>
        ///  High value of the red arc for the torque instrument. Units:ft-lbs
        ///  Raw path: sim/aircraft/limits/red_hi_TRQ
        /// </summary>
        public IXPDataRef<float> red_hi_TRQ { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_trq");} }

        /// <summary>
        ///  Low value of the green arc for the fuel flow instrument. Units:gal/hr_or_lb/hr
        ///  Raw path: sim/aircraft/limits/green_lo_FF
        /// </summary>
        public IXPDataRef<float> green_lo_FF { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_ff");} }

        /// <summary>
        ///  High value of the green arc for the fuel flow instrument. Units:gal/hr_or_lb/hr
        ///  Raw path: sim/aircraft/limits/green_hi_FF
        /// </summary>
        public IXPDataRef<float> green_hi_FF { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_ff");} }

        /// <summary>
        ///  Low value of the yellow arc for the fuel flow instrument. Units:gal/hr_or_lb/hr
        ///  Raw path: sim/aircraft/limits/yellow_lo_FF
        /// </summary>
        public IXPDataRef<float> yellow_lo_FF { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_ff");} }

        /// <summary>
        ///  High value of the yellow arc for the fuel flow instrument. Units:gal/hr_or_lb/hr
        ///  Raw path: sim/aircraft/limits/yellow_hi_FF
        /// </summary>
        public IXPDataRef<float> yellow_hi_FF { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_ff");} }

        /// <summary>
        ///  Low value of the red arc for the fuel flow instrument. Units:gal/hr_or_lb/hr
        ///  Raw path: sim/aircraft/limits/red_lo_FF
        /// </summary>
        public IXPDataRef<float> red_lo_FF { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_ff");} }

        /// <summary>
        ///  High value of the red arc for the fuel flow instrument. Units:gal/hr_or_lb/hr
        ///  Raw path: sim/aircraft/limits/red_hi_FF
        /// </summary>
        public IXPDataRef<float> red_hi_FF { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_ff");} }

        /// <summary>
        ///  Low value of the green arc for the interturbine temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_lo_ITT
        /// </summary>
        public IXPDataRef<float> green_lo_ITT { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_itt");} }

        /// <summary>
        ///  High value of the green arc for the interturbine temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_hi_ITT
        /// </summary>
        public IXPDataRef<float> green_hi_ITT { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_itt");} }

        /// <summary>
        ///  Low value of the yellow arc for the interturbine temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_lo_ITT
        /// </summary>
        public IXPDataRef<float> yellow_lo_ITT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_itt");} }

        /// <summary>
        ///  High value of the yellow arc for the interturbine temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_hi_ITT
        /// </summary>
        public IXPDataRef<float> yellow_hi_ITT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_itt");} }

        /// <summary>
        ///  Low value of the red arc for the interturbine temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_lo_ITT
        /// </summary>
        public IXPDataRef<float> red_lo_ITT { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_itt");} }

        /// <summary>
        ///  High value of the red arc for the interturbine temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_hi_ITT
        /// </summary>
        public IXPDataRef<float> red_hi_ITT { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_itt");} }

        /// <summary>
        ///  Low value of the green arc for the exhaust gas temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_lo_EGT
        /// </summary>
        public IXPDataRef<float> green_lo_EGT { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_egt");} }

        /// <summary>
        ///  High value of the green arc for the exhaust gas temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_hi_EGT
        /// </summary>
        public IXPDataRef<float> green_hi_EGT { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_egt");} }

        /// <summary>
        ///  Low value of the yellow arc for the exhaust gas temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_lo_EGT
        /// </summary>
        public IXPDataRef<float> yellow_lo_EGT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_egt");} }

        /// <summary>
        ///  High value of the yellow arc for the exhaust gas temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_hi_EGT
        /// </summary>
        public IXPDataRef<float> yellow_hi_EGT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_egt");} }

        /// <summary>
        ///  Low value of the red arc for the exhaust gas temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_lo_EGT
        /// </summary>
        public IXPDataRef<float> red_lo_EGT { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_egt");} }

        /// <summary>
        ///  High value of the red arc for the exhaust gas temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_hi_EGT
        /// </summary>
        public IXPDataRef<float> red_hi_EGT { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_egt");} }

        /// <summary>
        ///  Low value of the green arc for the cylinder-head temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_lo_CHT
        /// </summary>
        public IXPDataRef<float> green_lo_CHT { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_cht");} }

        /// <summary>
        ///  High value of the green arc for the cylinder-head temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_hi_CHT
        /// </summary>
        public IXPDataRef<float> green_hi_CHT { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_cht");} }

        /// <summary>
        ///  Low value of the yellow arc for the cylinder-head temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_lo_CHT
        /// </summary>
        public IXPDataRef<float> yellow_lo_CHT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_cht");} }

        /// <summary>
        ///  High value of the yellow arc for the cylinder-head temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_hi_CHT
        /// </summary>
        public IXPDataRef<float> yellow_hi_CHT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_cht");} }

        /// <summary>
        ///  Low value of the red arc for the cylinder-head temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_lo_CHT
        /// </summary>
        public IXPDataRef<float> red_lo_CHT { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_cht");} }

        /// <summary>
        ///  High value of the red arc for the cylinder-head temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_hi_CHT
        /// </summary>
        public IXPDataRef<float> red_hi_CHT { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_cht");} }

        /// <summary>
        ///  Low value of the green arc for the oil temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_lo_oilT
        /// </summary>
        public IXPDataRef<float> green_lo_oilT { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_oilt");} }

        /// <summary>
        ///  High value of the green arc for the oil temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/green_hi_oilT
        /// </summary>
        public IXPDataRef<float> green_hi_oilT { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_oilt");} }

        /// <summary>
        ///  Low value of the yellow arc for the oil temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_lo_oilT
        /// </summary>
        public IXPDataRef<float> yellow_lo_oilT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_oilt");} }

        /// <summary>
        ///  High value of the yellow arc for the oil temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/yellow_hi_oilT
        /// </summary>
        public IXPDataRef<float> yellow_hi_oilT { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_oilt");} }

        /// <summary>
        ///  Low value of the red arc for the oil temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_lo_oilT
        /// </summary>
        public IXPDataRef<float> red_lo_oilT { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_oilt");} }

        /// <summary>
        ///  High value of the red arc for the oil temperature instrument. Units:degC
        ///  Raw path: sim/aircraft/limits/red_hi_oilT
        /// </summary>
        public IXPDataRef<float> red_hi_oilT { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_oilt");} }

        /// <summary>
        ///  Low value of the green arc for the oil pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/green_lo_oilP
        /// </summary>
        public IXPDataRef<float> green_lo_oilP { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_oilp");} }

        /// <summary>
        ///  High value of the green arc for the oil pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/green_hi_oilP
        /// </summary>
        public IXPDataRef<float> green_hi_oilP { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_oilp");} }

        /// <summary>
        ///  Low value of the yellow arc for the oil pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/yellow_lo_oilP
        /// </summary>
        public IXPDataRef<float> yellow_lo_oilP { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_oilp");} }

        /// <summary>
        ///  High value of the yellow arc for the oil pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/yellow_hi_oilP
        /// </summary>
        public IXPDataRef<float> yellow_hi_oilP { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_oilp");} }

        /// <summary>
        ///  Low value of the red arc for the oil pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/red_lo_oilP
        /// </summary>
        public IXPDataRef<float> red_lo_oilP { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_oilp");} }

        /// <summary>
        ///  High value of the red arc for the oil pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/red_hi_oilP
        /// </summary>
        public IXPDataRef<float> red_hi_oilP { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_oilp");} }

        /// <summary>
        ///  Low value of the green arc for the fuel pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/green_lo_fuelP
        /// </summary>
        public IXPDataRef<float> green_lo_fuelP { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_fuelp");} }

        /// <summary>
        ///  High value of the green arc for the fuel pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/green_hi_fuelP
        /// </summary>
        public IXPDataRef<float> green_hi_fuelP { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_fuelp");} }

        /// <summary>
        ///  Low value of the yellow arc for the fuel pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/yellow_lo_fuelP
        /// </summary>
        public IXPDataRef<float> yellow_lo_fuelP { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_fuelp");} }

        /// <summary>
        ///  High value of the yellow arc for the fuel pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/yellow_hi_fuelP
        /// </summary>
        public IXPDataRef<float> yellow_hi_fuelP { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_fuelp");} }

        /// <summary>
        ///  Low value of the red arc for the fuel pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/red_lo_fuelP
        /// </summary>
        public IXPDataRef<float> red_lo_fuelP { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_fuelp");} }

        /// <summary>
        ///  High value of the red arc for the fuel pressure instrument. Units:PSI
        ///  Raw path: sim/aircraft/limits/red_hi_fuelP
        /// </summary>
        public IXPDataRef<float> red_hi_fuelP { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_fuelp");} }

        /// <summary>
        ///  Low value of the green arc for the generator amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/green_lo_gen_amp
        /// </summary>
        public IXPDataRef<float> green_lo_gen_amp { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_gen_amp");} }

        /// <summary>
        ///  High value of the green arc for the generator amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/green_hi_gen_amp
        /// </summary>
        public IXPDataRef<float> green_hi_gen_amp { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_gen_amp");} }

        /// <summary>
        ///  Low value of the yellow arc for the generator amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/yellow_lo_gen_amp
        /// </summary>
        public IXPDataRef<float> yellow_lo_gen_amp { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_gen_amp");} }

        /// <summary>
        ///  High value of the yellow arc for the generator amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/yellow_hi_gen_amp
        /// </summary>
        public IXPDataRef<float> yellow_hi_gen_amp { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_gen_amp");} }

        /// <summary>
        ///  Low value of the red arc for the generator amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/red_lo_gen_amp
        /// </summary>
        public IXPDataRef<float> red_lo_gen_amp { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_gen_amp");} }

        /// <summary>
        ///  High value of the red arc for the generator amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/red_hi_gen_amp
        /// </summary>
        public IXPDataRef<float> red_hi_gen_amp { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_gen_amp");} }

        /// <summary>
        ///  Low value of the green arc for the battery amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/green_lo_bat_amp
        /// </summary>
        public IXPDataRef<float> green_lo_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_bat_amp");} }

        /// <summary>
        ///  High value of the green arc for the battery amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/green_hi_bat_amp
        /// </summary>
        public IXPDataRef<float> green_hi_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_bat_amp");} }

        /// <summary>
        ///  Low value of the yellow arc for the battery amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/yellow_lo_bat_amp
        /// </summary>
        public IXPDataRef<float> yellow_lo_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_bat_amp");} }

        /// <summary>
        ///  High value of the yellow arc for the battery amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/yellow_hi_bat_amp
        /// </summary>
        public IXPDataRef<float> yellow_hi_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_bat_amp");} }

        /// <summary>
        ///  Low value of the red arc for the battery amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/red_lo_bat_amp
        /// </summary>
        public IXPDataRef<float> red_lo_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_bat_amp");} }

        /// <summary>
        ///  High value of the red arc for the battery amperage instrument. Units:amps
        ///  Raw path: sim/aircraft/limits/red_hi_bat_amp
        /// </summary>
        public IXPDataRef<float> red_hi_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_bat_amp");} }

        /// <summary>
        ///  Battery amp when the non-standby batteries are fully charged.. Units:amps
        ///  Raw path: sim/aircraft/limits/max_bat_amp
        /// </summary>
        public IXPDataRef<float> max_bat_amp { get { return m_data.GetFloat("sim/aircraft/limits/max_bat_amp");} }

        /// <summary>
        ///  Low value of the green arc for the battery voltage instrument. Units:volts
        ///  Raw path: sim/aircraft/limits/green_lo_bat_volt
        /// </summary>
        public IXPDataRef<float> green_lo_bat_volt { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_bat_volt");} }

        /// <summary>
        ///  High value of the green arc for the battery voltage instrument. Units:volts
        ///  Raw path: sim/aircraft/limits/green_hi_bat_volt
        /// </summary>
        public IXPDataRef<float> green_hi_bat_volt { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_bat_volt");} }

        /// <summary>
        ///  Low value of the yellow arc for the battery voltage instrument. Units:volts
        ///  Raw path: sim/aircraft/limits/yellow_lo_bat_volt
        /// </summary>
        public IXPDataRef<float> yellow_lo_bat_volt { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_bat_volt");} }

        /// <summary>
        ///  High value of the yellow arc for the battery voltage instrument. Units:volts
        ///  Raw path: sim/aircraft/limits/yellow_hi_bat_volt
        /// </summary>
        public IXPDataRef<float> yellow_hi_bat_volt { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_bat_volt");} }

        /// <summary>
        ///  Low value of the red arc for the battery voltage instrument. Units:volts
        ///  Raw path: sim/aircraft/limits/red_lo_bat_volt
        /// </summary>
        public IXPDataRef<float> red_lo_bat_volt { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_bat_volt");} }

        /// <summary>
        ///  High value of the red arc for the battery voltage instrument. Units:volts
        ///  Raw path: sim/aircraft/limits/red_hi_bat_volt
        /// </summary>
        public IXPDataRef<float> red_hi_bat_volt { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_bat_volt");} }

        /// <summary>
        ///  This is the voltage when the standard (non-standby) batteries are fully charged.. Units:volts
        ///  Raw path: sim/aircraft/limits/max_bat_volt_standard
        /// </summary>
        public IXPDataRef<float> max_bat_volt_standard { get { return m_data.GetFloat("sim/aircraft/limits/max_bat_volt_standard");} }

        /// <summary>
        ///  Low value of the green arc for the vacuum pressure instrument. Units:psi
        ///  Raw path: sim/aircraft/limits/green_lo_vac
        /// </summary>
        public IXPDataRef<float> green_lo_vac { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_vac");} }

        /// <summary>
        ///  High value of the green arc for the vacuum pressure instrument. Units:psi
        ///  Raw path: sim/aircraft/limits/green_hi_vac
        /// </summary>
        public IXPDataRef<float> green_hi_vac { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_vac");} }

        /// <summary>
        ///  Low value of the yellow arc for the vacuum pressure instrument. Units:psi
        ///  Raw path: sim/aircraft/limits/yellow_lo_vac
        /// </summary>
        public IXPDataRef<float> yellow_lo_vac { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_vac");} }

        /// <summary>
        ///  High value of the yellow arc for the vacuum pressure instrument. Units:psi
        ///  Raw path: sim/aircraft/limits/yellow_hi_vac
        /// </summary>
        public IXPDataRef<float> yellow_hi_vac { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_vac");} }

        /// <summary>
        ///  Low value of the red arc for the vacuum pressure instrument. Units:psi
        ///  Raw path: sim/aircraft/limits/red_lo_vac
        /// </summary>
        public IXPDataRef<float> red_lo_vac { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_vac");} }

        /// <summary>
        ///  High value of the red arc for the vacuum pressure instrument. Units:psi
        ///  Raw path: sim/aircraft/limits/red_hi_vac
        /// </summary>
        public IXPDataRef<float> red_hi_vac { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_vac");} }

        /// <summary>
        ///  Vacuum pressure put out when the engine is running at the bottom of red line (max vacuum).. Units:psi
        ///  Raw path: sim/aircraft/limits/max_vac
        /// </summary>
        public IXPDataRef<float> max_vac { get { return m_data.GetFloat("sim/aircraft/limits/max_vac");} }

        /// <summary>
        ///  Low value of the green arc for the N1 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/green_lo_N1
        /// </summary>
        public IXPDataRef<float> green_lo_N1 { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_n1");} }

        /// <summary>
        ///  High value of the green arc for the N1 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/green_hi_N1
        /// </summary>
        public IXPDataRef<float> green_hi_N1 { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_n1");} }

        /// <summary>
        ///  Low value of the yellow arc for the N1 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/yellow_lo_N1
        /// </summary>
        public IXPDataRef<float> yellow_lo_N1 { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_n1");} }

        /// <summary>
        ///  High value of the yellow arc for the N1 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/yellow_hi_N1
        /// </summary>
        public IXPDataRef<float> yellow_hi_N1 { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_n1");} }

        /// <summary>
        ///  Low value of the red arc for the N1 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/red_lo_N1
        /// </summary>
        public IXPDataRef<float> red_lo_N1 { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_n1");} }

        /// <summary>
        ///  High value of the red arc for the N1 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/red_hi_N1
        /// </summary>
        public IXPDataRef<float> red_hi_N1 { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_n1");} }

        /// <summary>
        ///  Low value of the green arc for the N2 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/green_lo_N2
        /// </summary>
        public IXPDataRef<float> green_lo_N2 { get { return m_data.GetFloat("sim/aircraft/limits/green_lo_n2");} }

        /// <summary>
        ///  High value of the green arc for the N2 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/green_hi_N2
        /// </summary>
        public IXPDataRef<float> green_hi_N2 { get { return m_data.GetFloat("sim/aircraft/limits/green_hi_n2");} }

        /// <summary>
        ///  Low value of the yellow arc for the N2 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/yellow_lo_N2
        /// </summary>
        public IXPDataRef<float> yellow_lo_N2 { get { return m_data.GetFloat("sim/aircraft/limits/yellow_lo_n2");} }

        /// <summary>
        ///  High value of the yellow arc for the N2 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/yellow_hi_N2
        /// </summary>
        public IXPDataRef<float> yellow_hi_N2 { get { return m_data.GetFloat("sim/aircraft/limits/yellow_hi_n2");} }

        /// <summary>
        ///  Low value of the red arc for the N2 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/red_lo_N2
        /// </summary>
        public IXPDataRef<float> red_lo_N2 { get { return m_data.GetFloat("sim/aircraft/limits/red_lo_n2");} }

        /// <summary>
        ///  High value of the red arc for the N2 instrument. Units:percent
        ///  Raw path: sim/aircraft/limits/red_hi_N2
        /// </summary>
        public IXPDataRef<float> red_hi_N2 { get { return m_data.GetFloat("sim/aircraft/limits/red_hi_n2");} }
    }
}