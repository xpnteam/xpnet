using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit2_Gauges_IndicatorsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit2_Gauges_IndicatorsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Slip indication, in degrees of ball deflection from centered.
        /// </summary>
        public IXPDataRef<float> Slip_deg { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/slip_deg");} }

        /// <summary>
        ///  Indicated heading of the wet compass, in degrees.
        /// </summary>
        public IXPDataRef<float> Compass_heading_deg_mag { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/compass_heading_deg_mag");} }

        /// <summary>
        ///  acceleration of airspeed (ASI trend)
        /// </summary>
        public IXPDataRef<float> Airspeed_acceleration_kts_sec_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_acceleration_kts_sec_pilot");} }

        /// <summary>
        ///  acceleration of airspeed (ASI trend)
        /// </summary>
        public IXPDataRef<float> Airspeed_acceleration_kts_sec_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_acceleration_kts_sec_copilot");} }

        /// <summary>
        ///  Indicated airspeed in knots, pilot.
        /// </summary>
        public IXPDataRef<float> Airspeed_kts_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_kts_pilot");} }

        /// <summary>
        ///  Indicated airspeed in knots, copilot.
        /// </summary>
        public IXPDataRef<float> Airspeed_kts_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/airspeed_kts_copilot");} }

        /// <summary>
        ///  Indicated height, MSL, in feet, primary system, based on pilots barometric pressure input.
        /// </summary>
        public IXPDataRef<float> Altitude_ft_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/altitude_ft_pilot");} }

        /// <summary>
        ///  Indicated height, MSL, in feet, primary system, based on co-pilots barometric pressure input.
        /// </summary>
        public IXPDataRef<float> Altitude_ft_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/altitude_ft_copilot");} }

        /// <summary>
        ///  Indicated vertical speed in feet per minute, pilot system.
        /// </summary>
        public IXPDataRef<float> Vvi_fpm_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/vvi_fpm_pilot");} }

        /// <summary>
        ///  Indicated vertical speed in feet per minute, copilot system.
        /// </summary>
        public IXPDataRef<float> Vvi_fpm_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/vvi_fpm_copilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for newer roll-augmented turn-indicators.  Pilot side.
        /// </summary>
        public IXPDataRef<float> Turn_rate_roll_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_roll_deg_pilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for newer roll-augmented turn-indicators.  Copilot side.
        /// </summary>
        public IXPDataRef<float> Turn_rate_roll_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_roll_deg_copilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for old-style turn-indicators.  Pilot side.
        /// </summary>
        public IXPDataRef<float> Turn_rate_heading_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_heading_deg_pilot");} }

        /// <summary>
        ///  Indicated rate-of-turn, in degrees deflection, for old-style turn-indicators.  Copilot side.
        /// </summary>
        public IXPDataRef<float> Turn_rate_heading_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/turn_rate_heading_deg_copilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: AHARS.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Heading_AHARS_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_ahars_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: AHARS.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Heading_AHARS_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_ahars_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: electric gyro.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Heading_electric_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_electric_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: electric gyro.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Heading_electric_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_electric_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: vacuum gyro.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Heading_vacuum_deg_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_vacuum_deg_mag_pilot");} }

        /// <summary>
        ///  Indicated magnetic heading, in degrees.  Source: vacuum gyro.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Heading_vacuum_deg_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/heading_vacuum_deg_mag_copilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: AHARS.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Pitch_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_ahars_deg_pilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: AHARS.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Pitch_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_ahars_deg_copilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: electric gyro.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Pitch_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_electric_deg_pilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: electric gyro.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Pitch_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_electric_deg_copilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: vacuum gyro.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Pitch_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_vacuum_deg_pilot");} }

        /// <summary>
        ///  Indicated pitch, in degrees, positive up.  Source: vacuum gyro.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Pitch_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/pitch_vacuum_deg_copilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side
        /// </summary>
        public IXPDataRef<float> Radio_altimeter_height_ft_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/radio_altimeter_height_ft_pilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side
        /// </summary>
        public IXPDataRef<float> Radio_altimeter_height_ft_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/radio_altimeter_height_ft_copilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side
        /// </summary>
        public IXPDataRef<bool> Radio_altimeter_dh_lit_pilot { get { return m_data.GetBool("sim/cockpit2/gauges/indicators/radio_altimeter_dh_lit_pilot");} }

        /// <summary>
        ///  Radio-altimeter indicated height in feet, pilot-side
        /// </summary>
        public IXPDataRef<bool> Radio_altimeter_dh_lit_copilot { get { return m_data.GetBool("sim/cockpit2/gauges/indicators/radio_altimeter_dh_lit_copilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: AHARS.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Roll_AHARS_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_ahars_deg_pilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: AHARS.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Roll_AHARS_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_ahars_deg_copilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: electric gyro.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Roll_electric_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_electric_deg_pilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: electric gyro.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Roll_electric_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_electric_deg_copilot");} }

        /// <summary>
        ///  Indicated roll, in degrees, positive right.  Source: vacuum gyro.  Side: Pilot
        /// </summary>
        public IXPDataRef<float> Roll_vacuum_deg_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_vacuum_deg_pilot");} }

        /// <summary>
        ///   Source: vacuum gyro.  Side: Copilot
        /// </summary>
        public IXPDataRef<float> Roll_vacuum_deg_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/roll_vacuum_deg_copilot");} }

        /// <summary>
        ///  Wind direction currently acting on the plane, in degrees magnetic.
        /// </summary>
        public IXPDataRef<float> Wind_heading_deg_mag { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/wind_heading_deg_mag");} }

        /// <summary>
        ///  Wind speed currently acting on the plane, in knots true.
        /// </summary>
        public IXPDataRef<float> Wind_speed_kts { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/wind_speed_kts");} }

        /// <summary>
        ///  Vacuum system 1 suction as ratio of max available in plane.
        /// </summary>
        public IXPDataRef<float> Suction_1_ratio { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/suction_1_ratio");} }

        /// <summary>
        ///  Vacuum system 2 suction as ratio of max available in plane.
        /// </summary>
        public IXPDataRef<float> Suction_2_ratio { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/suction_2_ratio");} }

        /// <summary>
        ///  Total energy in feet/Minute
        /// </summary>
        public IXPDataRef<float> Total_energy_fpm { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/total_energy_fpm");} }

        /// <summary>
        ///  Ratio of releasable water still in the tank, 0..1.
        /// </summary>
        public IXPDataRef<float> Water_ratio { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/water_ratio");} }

        /// <summary>
        ///  Sideslip in degrees
        /// </summary>
        public IXPDataRef<float> Sideslip_degrees { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/sideslip_degrees");} }

        /// <summary>
        ///  Degrees difference between two prop.  Can be used for prop sync display.
        /// </summary>
        public IXPDataRef<float> Prop_sync_degrees { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/prop_sync_degrees");} }

        /// <summary>
        ///  The ground track of the aircraft in degrees magnetic
        /// </summary>
        public IXPDataRef<float> Ground_track_mag_pilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/ground_track_mag_pilot");} }

        /// <summary>
        ///  The ground track of the aircraft in degrees magnetic
        /// </summary>
        public IXPDataRef<float> Ground_track_mag_copilot { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/ground_track_mag_copilot");} }

        /// <summary>
        ///  For planes with a max mach number, this is the max mach number converted to KIAS for the current plane altitude, etc. - useful for adaptive needles and limit markers on tapes
        /// </summary>
        public IXPDataRef<float> Max_mach_number_in_kias { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/max_mach_number_in_kias");} }

        /// <summary>
        ///  For planes with a max mach number, this is the lesser of the max mach number converted to KIAS for the current plane altitude and V-never-exceed.
        /// </summary>
        public IXPDataRef<float> Max_mach_number_or_speed_kias { get { return m_data.GetFloat("sim/cockpit2/gauges/indicators/max_mach_number_or_speed_kias");} }
    }
}