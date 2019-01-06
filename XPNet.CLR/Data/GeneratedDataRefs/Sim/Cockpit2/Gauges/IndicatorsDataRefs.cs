using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_gauges_indicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_gauges_indicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Slip indication, in degrees of ball deflection from centered.. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/slip_deg
        /// </summary>
        public IXPDataRef<float> slip_deg { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/slip_deg");} }

        /// <summary>
        ///  Indicated heading of the wet compass, in degrees.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/compass_heading_deg_mag
        /// </summary>
        public IXPDataRef<float> compass_heading_deg_mag { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/compass_heading_deg_mag");} }

        /// <summary>
        ///  acceleration of airspeed (ASI trend). Units:knots/second
        ///  Raw path: sim/cockpit2/gauges/indicators/airspeed_acceleration_kts_sec_pilot
        /// </summary>
        public IXPDataRef<float> airspeed_acceleration_kts_sec_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_acceleration_kts_sec_pilot");} }

        /// <summary>
        ///  acceleration of airspeed (ASI trend). Units:knots/second
        ///  Raw path: sim/cockpit2/gauges/indicators/airspeed_acceleration_kts_sec_copilot
        /// </summary>
        public IXPDataRef<float> airspeed_acceleration_kts_sec_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_acceleration_kts_sec_copilot");} }

        /// <summary>
        ///  Indicated airspeed in knots, pilot.. Units:knots
        ///  Raw path: sim/cockpit2/gauges/indicators/airspeed_kts_pilot
        /// </summary>
        public IXPDataRef<float> airspeed_kts_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_kts_pilot");} }

        /// <summary>
        ///  Indicated airspeed in knots, copilot.. Units:knots
        ///  Raw path: sim/cockpit2/gauges/indicators/airspeed_kts_copilot
        /// </summary>
        public IXPDataRef<float> airspeed_kts_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_kts_copilot");} }

        /// <summary>
        ///  Indicated height, MSL, in feet, primary system, based on pilots barometric pressure input.. Units:feet
        ///  Raw path: sim/cockpit2/gauges/indicators/altitude_ft_pilot
        /// </summary>
        public IXPDataRef<float> altitude_ft_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/altitude_ft_pilot");} }

        /// <summary>
        ///  Indicated height, MSL, in feet, primary system, based on co-pilots barometric pressure input.. Units:feet
        ///  Raw path: sim/cockpit2/gauges/indicators/altitude_ft_copilot
        /// </summary>
        public IXPDataRef<float> altitude_ft_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/altitude_ft_copilot");} }

        /// <summary>
        ///  Indicated vertical speed in feet per minute, pilot system.. Units:feet/minute
        ///  Raw path: sim/cockpit2/gauges/indicators/vvi_fpm_pilot
        /// </summary>
        public IXPDataRef<float> vvi_fpm_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/vvi_fpm_pilot");} }

        /// <summary>
        ///  Indicated vertical speed in feet per minute, copilot system.. Units:feet/minute
        ///  Raw path: sim/cockpit2/gauges/indicators/vvi_fpm_copilot
        /// </summary>
        public IXPDataRef<float> vvi_fpm_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/vvi_fpm_copilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for newer roll-augmented turn-indicators.  Pilot side.. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/turn_rate_roll_deg_pilot
        /// </summary>
        public IXPDataRef<float> turn_rate_roll_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_roll_deg_pilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for newer roll-augmented turn-indicators.  Copilot side.. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/turn_rate_roll_deg_copilot
        /// </summary>
        public IXPDataRef<float> turn_rate_roll_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_roll_deg_copilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for old-style turn-indicators.  Pilot side.. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/turn_rate_heading_deg_pilot
        /// </summary>
        public IXPDataRef<float> turn_rate_heading_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_heading_deg_pilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for old-style turn-indicators.  Copilot side.. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/turn_rate_heading_deg_copilot
        /// </summary>
        public IXPDataRef<float> turn_rate_heading_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_heading_deg_copilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: AHARS.  Side: Pilot. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/heading_AHARS_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> heading_AHARS_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_ahars_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: AHARS.  Side: Copilot. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/heading_AHARS_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> heading_AHARS_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_ahars_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: electric gyro.  Side: Pilot. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/heading_electric_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> heading_electric_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_electric_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: electric gyro.  Side: Copilot. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/heading_electric_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> heading_electric_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_electric_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: vacuum gyro.  Side: Pilot. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/heading_vacuum_deg_mag_pilot
        /// </summary>
        public IXPDataRef<float> heading_vacuum_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_vacuum_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: vacuum gyro.  Side: Copilot. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/heading_vacuum_deg_mag_copilot
        /// </summary>
        public IXPDataRef<float> heading_vacuum_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_vacuum_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: AHARS.  Side: Pilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/pitch_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> pitch_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_ahars_deg_pilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: AHARS.  Side: Copilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/pitch_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> pitch_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_ahars_deg_copilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: electric gyro.  Side: Pilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/pitch_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> pitch_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_electric_deg_pilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: electric gyro.  Side: Copilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/pitch_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> pitch_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_electric_deg_copilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: vacuum gyro.  Side: Pilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/pitch_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> pitch_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_vacuum_deg_pilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: vacuum gyro.  Side: Copilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/pitch_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> pitch_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_vacuum_deg_copilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side. Units:feet
        ///  Raw path: sim/cockpit2/gauges/indicators/radio_altimeter_height_ft_pilot
        /// </summary>
        public IXPDataRef<float> radio_altimeter_height_ft_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/radio_altimeter_height_ft_pilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side. Units:feet
        ///  Raw path: sim/cockpit2/gauges/indicators/radio_altimeter_height_ft_copilot
        /// </summary>
        public IXPDataRef<float> radio_altimeter_height_ft_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/radio_altimeter_height_ft_copilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side. Units:boolean
        ///  Raw path: sim/cockpit2/gauges/indicators/radio_altimeter_dh_lit_pilot
        /// </summary>
        public IXPDataRef<bool> radio_altimeter_dh_lit_pilot { get { return m_data.GetBool("sim/cockpit2/gauges/indicators/radio_altimeter_dh_lit_pilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side. Units:boolean
        ///  Raw path: sim/cockpit2/gauges/indicators/radio_altimeter_dh_lit_copilot
        /// </summary>
        public IXPDataRef<bool> radio_altimeter_dh_lit_copilot { get { return m_data.GetBool("sim/cockpit2/gauges/indicators/radio_altimeter_dh_lit_copilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: AHARS.  Side: Pilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/roll_AHARS_deg_pilot
        /// </summary>
        public IXPDataRef<float> roll_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_ahars_deg_pilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: AHARS.  Side: Copilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/roll_AHARS_deg_copilot
        /// </summary>
        public IXPDataRef<float> roll_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_ahars_deg_copilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: electric gyro.  Side: Pilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/roll_electric_deg_pilot
        /// </summary>
        public IXPDataRef<float> roll_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_electric_deg_pilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: electric gyro.  Side: Copilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/roll_electric_deg_copilot
        /// </summary>
        public IXPDataRef<float> roll_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_electric_deg_copilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: vacuum gyro.  Side: Pilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/roll_vacuum_deg_pilot
        /// </summary>
        public IXPDataRef<float> roll_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_vacuum_deg_pilot");} }

        /// <summary>
        ///   Source: vacuum gyro.  Side: Copilot. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/roll_vacuum_deg_copilot
        /// </summary>
        public IXPDataRef<float> roll_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_vacuum_deg_copilot");} }

        /// <summary>
        ///  Wind direction currently acting on the plane, in degrees magnetic.. Units:degrees_magnetic
        ///  Raw path: sim/cockpit2/gauges/indicators/wind_heading_deg_mag
        /// </summary>
        public IXPDataRef<float> wind_heading_deg_mag { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/wind_heading_deg_mag");} }

        /// <summary>
        ///  Wind speed currently acting on the plane, in knots true.. Units:knots
        ///  Raw path: sim/cockpit2/gauges/indicators/wind_speed_kts
        /// </summary>
        public IXPDataRef<float> wind_speed_kts { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/wind_speed_kts");} }

        /// <summary>
        ///  Vacuum system 1 suction as ratio of max available in plane.. Units:ratio
        ///  Raw path: sim/cockpit2/gauges/indicators/suction_1_ratio
        /// </summary>
        public IXPDataRef<float> suction_1_ratio { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/suction_1_ratio");} }

        /// <summary>
        ///  Vacuum system 2 suction as ratio of max available in plane.. Units:ratio
        ///  Raw path: sim/cockpit2/gauges/indicators/suction_2_ratio
        /// </summary>
        public IXPDataRef<float> suction_2_ratio { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/suction_2_ratio");} }

        /// <summary>
        ///  Total energy in feet/minute. Units:feet/minute
        ///  Raw path: sim/cockpit2/gauges/indicators/total_energy_fpm
        /// </summary>
        public IXPDataRef<float> total_energy_fpm { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/total_energy_fpm");} }

        /// <summary>
        ///  Ratio of releasable water still in the tank, 0..1.. Units:ratio
        ///  Raw path: sim/cockpit2/gauges/indicators/water_ratio
        /// </summary>
        public IXPDataRef<float> water_ratio { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/water_ratio");} }

        /// <summary>
        ///  Sideslip in degrees. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/sideslip_degrees
        /// </summary>
        public IXPDataRef<float> sideslip_degrees { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/sideslip_degrees");} }

        /// <summary>
        ///  Degrees difference between two prop.  Can be used for prop sync display.. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/prop_sync_degrees
        /// </summary>
        public IXPDataRef<float> prop_sync_degrees { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/prop_sync_degrees");} }

        /// <summary>
        ///  The ground track of the aircraft in degrees magnetic. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/ground_track_mag_pilot
        /// </summary>
        public IXPDataRef<float> ground_track_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/ground_track_mag_pilot");} }

        /// <summary>
        ///  The ground track of the aircraft in degrees magnetic. Units:degrees
        ///  Raw path: sim/cockpit2/gauges/indicators/ground_track_mag_copilot
        /// </summary>
        public IXPDataRef<float> ground_track_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/ground_track_mag_copilot");} }

        /// <summary>
        ///  For planes with a max mach number, this is the max mach number converted to KIAS for the current plane altitude, etc. - useful for adaptive needles and limit markers on tapes. Units:knots
        ///  Raw path: sim/cockpit2/gauges/indicators/max_mach_number_in_kias
        /// </summary>
        public IXPDataRef<float> max_mach_number_in_kias { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/max_mach_number_in_kias");} }

        /// <summary>
        ///  For planes with a max mach number, this is the lesser of the max mach number converted to KIAS for the current plane altitude and V-never-exceed.. Units:knots
        ///  Raw path: sim/cockpit2/gauges/indicators/max_mach_number_or_speed_kias
        /// </summary>
        public IXPDataRef<float> max_mach_number_or_speed_kias { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/max_mach_number_or_speed_kias");} }
    }
}