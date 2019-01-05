using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_LimitsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_LimitsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Low value of the green arc for the manifold pressure instrument. Units:inhg
        /// </summary>
        public IXPDataRef<float> Green_lo_MP => m_data.GetFloat("sim/aircraft/limits/green_lo_mp");

        /// <summary>
        ///  High value of the green arc for the manifold pressure instrument. Units:inhg
        /// </summary>
        public IXPDataRef<float> Green_hi_MP => m_data.GetFloat("sim/aircraft/limits/green_hi_mp");

        /// <summary>
        ///  Low value of the yellow arc for the manifold pressure instrument. Units:inhg
        /// </summary>
        public IXPDataRef<float> Yellow_lo_MP => m_data.GetFloat("sim/aircraft/limits/yellow_lo_mp");

        /// <summary>
        ///  High value of the yellow arc for the manifold pressure instrument. Units:inhg
        /// </summary>
        public IXPDataRef<float> Yellow_hi_MP => m_data.GetFloat("sim/aircraft/limits/yellow_hi_mp");

        /// <summary>
        ///  Low value of the red arc for the manifold pressure instrument. Units:inhg
        /// </summary>
        public IXPDataRef<float> Red_lo_MP => m_data.GetFloat("sim/aircraft/limits/red_lo_mp");

        /// <summary>
        ///  High value of the red arc for the manifold pressure instrument. Units:inhg
        /// </summary>
        public IXPDataRef<float> Red_hi_MP => m_data.GetFloat("sim/aircraft/limits/red_hi_mp");

        /// <summary>
        ///  Low value of the green arc for the engine pressure ratio instrument. Units:ratio
        /// </summary>
        public IXPDataRef<float> Green_lo_EPR => m_data.GetFloat("sim/aircraft/limits/green_lo_epr");

        /// <summary>
        ///  High value of the green arc for the engine pressure ratio instrument. Units:ratio
        /// </summary>
        public IXPDataRef<float> Green_hi_EPR => m_data.GetFloat("sim/aircraft/limits/green_hi_epr");

        /// <summary>
        ///  Low value of the yellow arc for the engine pressure ratio instrument. Units:ratio
        /// </summary>
        public IXPDataRef<float> Yellow_lo_EPR => m_data.GetFloat("sim/aircraft/limits/yellow_lo_epr");

        /// <summary>
        ///  High value of the yellow arc for the engine pressure ratio instrument. Units:ratio
        /// </summary>
        public IXPDataRef<float> Yellow_hi_EPR => m_data.GetFloat("sim/aircraft/limits/yellow_hi_epr");

        /// <summary>
        ///  Low value of the red arc for the engine pressure ratio instrument. Units:ratio
        /// </summary>
        public IXPDataRef<float> Red_lo_EPR => m_data.GetFloat("sim/aircraft/limits/red_lo_epr");

        /// <summary>
        ///  High value of the red arc for the engine pressure ratio instrument. Units:ratio
        /// </summary>
        public IXPDataRef<float> Red_hi_EPR => m_data.GetFloat("sim/aircraft/limits/red_hi_epr");

        /// <summary>
        ///  Low value of the green arc for the torque instrument. Units:ft-lbs
        /// </summary>
        public IXPDataRef<float> Green_lo_TRQ => m_data.GetFloat("sim/aircraft/limits/green_lo_trq");

        /// <summary>
        ///  High value of the green arc for the torque instrument. Units:ft-lbs
        /// </summary>
        public IXPDataRef<float> Green_hi_TRQ => m_data.GetFloat("sim/aircraft/limits/green_hi_trq");

        /// <summary>
        ///  Low value of the yellow arc for the torque instrument. Units:ft-lbs
        /// </summary>
        public IXPDataRef<float> Yellow_lo_TRQ => m_data.GetFloat("sim/aircraft/limits/yellow_lo_trq");

        /// <summary>
        ///  High value of the yellow arc for the torque instrument. Units:ft-lbs
        /// </summary>
        public IXPDataRef<float> Yellow_hi_TRQ => m_data.GetFloat("sim/aircraft/limits/yellow_hi_trq");

        /// <summary>
        ///  Low value of the red arc for the torque instrument. Units:ft-lbs
        /// </summary>
        public IXPDataRef<float> Red_lo_TRQ => m_data.GetFloat("sim/aircraft/limits/red_lo_trq");

        /// <summary>
        ///  High value of the red arc for the torque instrument. Units:ft-lbs
        /// </summary>
        public IXPDataRef<float> Red_hi_TRQ => m_data.GetFloat("sim/aircraft/limits/red_hi_trq");

        /// <summary>
        ///  Low value of the green arc for the fuel flow instrument. Units:gal/Hr_or_lb/Hr
        /// </summary>
        public IXPDataRef<float> Green_lo_FF => m_data.GetFloat("sim/aircraft/limits/green_lo_ff");

        /// <summary>
        ///  High value of the green arc for the fuel flow instrument. Units:gal/Hr_or_lb/Hr
        /// </summary>
        public IXPDataRef<float> Green_hi_FF => m_data.GetFloat("sim/aircraft/limits/green_hi_ff");

        /// <summary>
        ///  Low value of the yellow arc for the fuel flow instrument. Units:gal/Hr_or_lb/Hr
        /// </summary>
        public IXPDataRef<float> Yellow_lo_FF => m_data.GetFloat("sim/aircraft/limits/yellow_lo_ff");

        /// <summary>
        ///  High value of the yellow arc for the fuel flow instrument. Units:gal/Hr_or_lb/Hr
        /// </summary>
        public IXPDataRef<float> Yellow_hi_FF => m_data.GetFloat("sim/aircraft/limits/yellow_hi_ff");

        /// <summary>
        ///  Low value of the red arc for the fuel flow instrument. Units:gal/Hr_or_lb/Hr
        /// </summary>
        public IXPDataRef<float> Red_lo_FF => m_data.GetFloat("sim/aircraft/limits/red_lo_ff");

        /// <summary>
        ///  High value of the red arc for the fuel flow instrument. Units:gal/Hr_or_lb/Hr
        /// </summary>
        public IXPDataRef<float> Red_hi_FF => m_data.GetFloat("sim/aircraft/limits/red_hi_ff");

        /// <summary>
        ///  Low value of the green arc for the interturbine temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_lo_ITT => m_data.GetFloat("sim/aircraft/limits/green_lo_itt");

        /// <summary>
        ///  High value of the green arc for the interturbine temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_hi_ITT => m_data.GetFloat("sim/aircraft/limits/green_hi_itt");

        /// <summary>
        ///  Low value of the yellow arc for the interturbine temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_lo_ITT => m_data.GetFloat("sim/aircraft/limits/yellow_lo_itt");

        /// <summary>
        ///  High value of the yellow arc for the interturbine temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_hi_ITT => m_data.GetFloat("sim/aircraft/limits/yellow_hi_itt");

        /// <summary>
        ///  Low value of the red arc for the interturbine temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_lo_ITT => m_data.GetFloat("sim/aircraft/limits/red_lo_itt");

        /// <summary>
        ///  High value of the red arc for the interturbine temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_hi_ITT => m_data.GetFloat("sim/aircraft/limits/red_hi_itt");

        /// <summary>
        ///  Low value of the green arc for the exhaust gas temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_lo_EGT => m_data.GetFloat("sim/aircraft/limits/green_lo_egt");

        /// <summary>
        ///  High value of the green arc for the exhaust gas temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_hi_EGT => m_data.GetFloat("sim/aircraft/limits/green_hi_egt");

        /// <summary>
        ///  Low value of the yellow arc for the exhaust gas temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_lo_EGT => m_data.GetFloat("sim/aircraft/limits/yellow_lo_egt");

        /// <summary>
        ///  High value of the yellow arc for the exhaust gas temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_hi_EGT => m_data.GetFloat("sim/aircraft/limits/yellow_hi_egt");

        /// <summary>
        ///  Low value of the red arc for the exhaust gas temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_lo_EGT => m_data.GetFloat("sim/aircraft/limits/red_lo_egt");

        /// <summary>
        ///  High value of the red arc for the exhaust gas temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_hi_EGT => m_data.GetFloat("sim/aircraft/limits/red_hi_egt");

        /// <summary>
        ///  Low value of the green arc for the cylinder-head temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_lo_CHT => m_data.GetFloat("sim/aircraft/limits/green_lo_cht");

        /// <summary>
        ///  High value of the green arc for the cylinder-head temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_hi_CHT => m_data.GetFloat("sim/aircraft/limits/green_hi_cht");

        /// <summary>
        ///  Low value of the yellow arc for the cylinder-head temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_lo_CHT => m_data.GetFloat("sim/aircraft/limits/yellow_lo_cht");

        /// <summary>
        ///  High value of the yellow arc for the cylinder-head temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_hi_CHT => m_data.GetFloat("sim/aircraft/limits/yellow_hi_cht");

        /// <summary>
        ///  Low value of the red arc for the cylinder-head temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_lo_CHT => m_data.GetFloat("sim/aircraft/limits/red_lo_cht");

        /// <summary>
        ///  High value of the red arc for the cylinder-head temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_hi_CHT => m_data.GetFloat("sim/aircraft/limits/red_hi_cht");

        /// <summary>
        ///  Low value of the green arc for the oil temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_lo_oilT => m_data.GetFloat("sim/aircraft/limits/green_lo_oilt");

        /// <summary>
        ///  High value of the green arc for the oil temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Green_hi_oilT => m_data.GetFloat("sim/aircraft/limits/green_hi_oilt");

        /// <summary>
        ///  Low value of the yellow arc for the oil temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_lo_oilT => m_data.GetFloat("sim/aircraft/limits/yellow_lo_oilt");

        /// <summary>
        ///  High value of the yellow arc for the oil temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Yellow_hi_oilT => m_data.GetFloat("sim/aircraft/limits/yellow_hi_oilt");

        /// <summary>
        ///  Low value of the red arc for the oil temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_lo_oilT => m_data.GetFloat("sim/aircraft/limits/red_lo_oilt");

        /// <summary>
        ///  High value of the red arc for the oil temperature instrument. Units:degC
        /// </summary>
        public IXPDataRef<float> Red_hi_oilT => m_data.GetFloat("sim/aircraft/limits/red_hi_oilt");

        /// <summary>
        ///  Low value of the green arc for the oil pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Green_lo_oilP => m_data.GetFloat("sim/aircraft/limits/green_lo_oilp");

        /// <summary>
        ///  High value of the green arc for the oil pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Green_hi_oilP => m_data.GetFloat("sim/aircraft/limits/green_hi_oilp");

        /// <summary>
        ///  Low value of the yellow arc for the oil pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Yellow_lo_oilP => m_data.GetFloat("sim/aircraft/limits/yellow_lo_oilp");

        /// <summary>
        ///  High value of the yellow arc for the oil pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Yellow_hi_oilP => m_data.GetFloat("sim/aircraft/limits/yellow_hi_oilp");

        /// <summary>
        ///  Low value of the red arc for the oil pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Red_lo_oilP => m_data.GetFloat("sim/aircraft/limits/red_lo_oilp");

        /// <summary>
        ///  High value of the red arc for the oil pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Red_hi_oilP => m_data.GetFloat("sim/aircraft/limits/red_hi_oilp");

        /// <summary>
        ///  Low value of the green arc for the fuel pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Green_lo_fuelP => m_data.GetFloat("sim/aircraft/limits/green_lo_fuelp");

        /// <summary>
        ///  High value of the green arc for the fuel pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Green_hi_fuelP => m_data.GetFloat("sim/aircraft/limits/green_hi_fuelp");

        /// <summary>
        ///  Low value of the yellow arc for the fuel pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Yellow_lo_fuelP => m_data.GetFloat("sim/aircraft/limits/yellow_lo_fuelp");

        /// <summary>
        ///  High value of the yellow arc for the fuel pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Yellow_hi_fuelP => m_data.GetFloat("sim/aircraft/limits/yellow_hi_fuelp");

        /// <summary>
        ///  Low value of the red arc for the fuel pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Red_lo_fuelP => m_data.GetFloat("sim/aircraft/limits/red_lo_fuelp");

        /// <summary>
        ///  High value of the red arc for the fuel pressure instrument. Units:PSI
        /// </summary>
        public IXPDataRef<float> Red_hi_fuelP => m_data.GetFloat("sim/aircraft/limits/red_hi_fuelp");

        /// <summary>
        ///  Low value of the green arc for the generator amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Green_lo_gen_amp => m_data.GetFloat("sim/aircraft/limits/green_lo_gen_amp");

        /// <summary>
        ///  High value of the green arc for the generator amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Green_hi_gen_amp => m_data.GetFloat("sim/aircraft/limits/green_hi_gen_amp");

        /// <summary>
        ///  Low value of the yellow arc for the generator amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Yellow_lo_gen_amp => m_data.GetFloat("sim/aircraft/limits/yellow_lo_gen_amp");

        /// <summary>
        ///  High value of the yellow arc for the generator amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Yellow_hi_gen_amp => m_data.GetFloat("sim/aircraft/limits/yellow_hi_gen_amp");

        /// <summary>
        ///  Low value of the red arc for the generator amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Red_lo_gen_amp => m_data.GetFloat("sim/aircraft/limits/red_lo_gen_amp");

        /// <summary>
        ///  High value of the red arc for the generator amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Red_hi_gen_amp => m_data.GetFloat("sim/aircraft/limits/red_hi_gen_amp");

        /// <summary>
        ///  Low value of the green arc for the battery amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Green_lo_bat_amp => m_data.GetFloat("sim/aircraft/limits/green_lo_bat_amp");

        /// <summary>
        ///  High value of the green arc for the battery amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Green_hi_bat_amp => m_data.GetFloat("sim/aircraft/limits/green_hi_bat_amp");

        /// <summary>
        ///  Low value of the yellow arc for the battery amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Yellow_lo_bat_amp => m_data.GetFloat("sim/aircraft/limits/yellow_lo_bat_amp");

        /// <summary>
        ///  High value of the yellow arc for the battery amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Yellow_hi_bat_amp => m_data.GetFloat("sim/aircraft/limits/yellow_hi_bat_amp");

        /// <summary>
        ///  Low value of the red arc for the battery amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Red_lo_bat_amp => m_data.GetFloat("sim/aircraft/limits/red_lo_bat_amp");

        /// <summary>
        ///  High value of the red arc for the battery amperage instrument. Units:amps
        /// </summary>
        public IXPDataRef<float> Red_hi_bat_amp => m_data.GetFloat("sim/aircraft/limits/red_hi_bat_amp");

        /// <summary>
        ///  Battery amp when the non-standby batteries are fully charged.. Units:amps
        /// </summary>
        public IXPDataRef<float> Max_bat_amp => m_data.GetFloat("sim/aircraft/limits/max_bat_amp");

        /// <summary>
        ///  Low value of the green arc for the battery voltage instrument. Units:volts
        /// </summary>
        public IXPDataRef<float> Green_lo_bat_volt => m_data.GetFloat("sim/aircraft/limits/green_lo_bat_volt");

        /// <summary>
        ///  High value of the green arc for the battery voltage instrument. Units:volts
        /// </summary>
        public IXPDataRef<float> Green_hi_bat_volt => m_data.GetFloat("sim/aircraft/limits/green_hi_bat_volt");

        /// <summary>
        ///  Low value of the yellow arc for the battery voltage instrument. Units:volts
        /// </summary>
        public IXPDataRef<float> Yellow_lo_bat_volt => m_data.GetFloat("sim/aircraft/limits/yellow_lo_bat_volt");

        /// <summary>
        ///  High value of the yellow arc for the battery voltage instrument. Units:volts
        /// </summary>
        public IXPDataRef<float> Yellow_hi_bat_volt => m_data.GetFloat("sim/aircraft/limits/yellow_hi_bat_volt");

        /// <summary>
        ///  Low value of the red arc for the battery voltage instrument. Units:volts
        /// </summary>
        public IXPDataRef<float> Red_lo_bat_volt => m_data.GetFloat("sim/aircraft/limits/red_lo_bat_volt");

        /// <summary>
        ///  High value of the red arc for the battery voltage instrument. Units:volts
        /// </summary>
        public IXPDataRef<float> Red_hi_bat_volt => m_data.GetFloat("sim/aircraft/limits/red_hi_bat_volt");

        /// <summary>
        ///  This is the voltage when the standard (non-standby) batteries are fully charged.. Units:volts
        /// </summary>
        public IXPDataRef<float> Max_bat_volt_standard => m_data.GetFloat("sim/aircraft/limits/max_bat_volt_standard");

        /// <summary>
        ///  Low value of the green arc for the vacuum pressure instrument. Units:psi
        /// </summary>
        public IXPDataRef<float> Green_lo_vac => m_data.GetFloat("sim/aircraft/limits/green_lo_vac");

        /// <summary>
        ///  High value of the green arc for the vacuum pressure instrument. Units:psi
        /// </summary>
        public IXPDataRef<float> Green_hi_vac => m_data.GetFloat("sim/aircraft/limits/green_hi_vac");

        /// <summary>
        ///  Low value of the yellow arc for the vacuum pressure instrument. Units:psi
        /// </summary>
        public IXPDataRef<float> Yellow_lo_vac => m_data.GetFloat("sim/aircraft/limits/yellow_lo_vac");

        /// <summary>
        ///  High value of the yellow arc for the vacuum pressure instrument. Units:psi
        /// </summary>
        public IXPDataRef<float> Yellow_hi_vac => m_data.GetFloat("sim/aircraft/limits/yellow_hi_vac");

        /// <summary>
        ///  Low value of the red arc for the vacuum pressure instrument. Units:psi
        /// </summary>
        public IXPDataRef<float> Red_lo_vac => m_data.GetFloat("sim/aircraft/limits/red_lo_vac");

        /// <summary>
        ///  High value of the red arc for the vacuum pressure instrument. Units:psi
        /// </summary>
        public IXPDataRef<float> Red_hi_vac => m_data.GetFloat("sim/aircraft/limits/red_hi_vac");

        /// <summary>
        ///  Vacuum pressure put out when the engine is running at the bottom of red line (max vacuum).. Units:psi
        /// </summary>
        public IXPDataRef<float> Max_vac => m_data.GetFloat("sim/aircraft/limits/max_vac");

        /// <summary>
        ///  Low value of the green arc for the N1 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Green_lo_N1 => m_data.GetFloat("sim/aircraft/limits/green_lo_n1");

        /// <summary>
        ///  High value of the green arc for the N1 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Green_hi_N1 => m_data.GetFloat("sim/aircraft/limits/green_hi_n1");

        /// <summary>
        ///  Low value of the yellow arc for the N1 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Yellow_lo_N1 => m_data.GetFloat("sim/aircraft/limits/yellow_lo_n1");

        /// <summary>
        ///  High value of the yellow arc for the N1 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Yellow_hi_N1 => m_data.GetFloat("sim/aircraft/limits/yellow_hi_n1");

        /// <summary>
        ///  Low value of the red arc for the N1 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Red_lo_N1 => m_data.GetFloat("sim/aircraft/limits/red_lo_n1");

        /// <summary>
        ///  High value of the red arc for the N1 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Red_hi_N1 => m_data.GetFloat("sim/aircraft/limits/red_hi_n1");

        /// <summary>
        ///  Low value of the green arc for the N2 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Green_lo_N2 => m_data.GetFloat("sim/aircraft/limits/green_lo_n2");

        /// <summary>
        ///  High value of the green arc for the N2 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Green_hi_N2 => m_data.GetFloat("sim/aircraft/limits/green_hi_n2");

        /// <summary>
        ///  Low value of the yellow arc for the N2 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Yellow_lo_N2 => m_data.GetFloat("sim/aircraft/limits/yellow_lo_n2");

        /// <summary>
        ///  High value of the yellow arc for the N2 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Yellow_hi_N2 => m_data.GetFloat("sim/aircraft/limits/yellow_hi_n2");

        /// <summary>
        ///  Low value of the red arc for the N2 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Red_lo_N2 => m_data.GetFloat("sim/aircraft/limits/red_lo_n2");

        /// <summary>
        ///  High value of the red arc for the N2 instrument. Units:percent
        /// </summary>
        public IXPDataRef<float> Red_hi_N2 => m_data.GetFloat("sim/aircraft/limits/red_hi_n2");
    }
}