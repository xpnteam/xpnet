using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_WeatherDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_WeatherDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  . Units:Coverage
        /// </summary>
        public IXPDataRef<float> Cloud_coverage[0] => m_data.GetFloat("sim/weather/cloud_coverage[0]");

        /// <summary>
        ///  . Units:Coverage
        /// </summary>
        public IXPDataRef<float> Cloud_coverage[1] => m_data.GetFloat("sim/weather/cloud_coverage[1]");

        /// <summary>
        ///  . Units:Coverage
        /// </summary>
        public IXPDataRef<float> Cloud_coverage[2] => m_data.GetFloat("sim/weather/cloud_coverage[2]");

        /// <summary>
        ///  MSL >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Cloud_base_msl_m[0] => m_data.GetFloat("sim/weather/cloud_base_msl_m[0]");

        /// <summary>
        ///  MSL >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Cloud_base_msl_m[1] => m_data.GetFloat("sim/weather/cloud_base_msl_m[1]");

        /// <summary>
        ///  MSL >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Cloud_base_msl_m[2] => m_data.GetFloat("sim/weather/cloud_base_msl_m[2]");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Cloud_tops_msl_m[0] => m_data.GetFloat("sim/weather/cloud_tops_msl_m[0]");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Cloud_tops_msl_m[1] => m_data.GetFloat("sim/weather/cloud_tops_msl_m[1]");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Cloud_tops_msl_m[2] => m_data.GetFloat("sim/weather/cloud_tops_msl_m[2]");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Visibility_reported_m => m_data.GetFloat("sim/weather/visibility_reported_m");

        /// <summary>
        ///  - 1.0]. Units:[0.0
        /// </summary>
        public IXPDataRef<float> Rain_percent => m_data.GetFloat("sim/weather/rain_percent");

        /// <summary>
        ///  - 1.0]. Units:[0.0
        /// </summary>
        public IXPDataRef<float> Thunderstorm_percent => m_data.GetFloat("sim/weather/thunderstorm_percent");

        /// <summary>
        ///  - 1.0]. Units:[0.0
        /// </summary>
        public IXPDataRef<float> Wind_turbulence_percent => m_data.GetFloat("sim/weather/wind_turbulence_percent");

        /// <summary>
        ///  +- ..... Units:29.92
        /// </summary>
        public IXPDataRef<float> Barometer_sealevel_inhg => m_data.GetFloat("sim/weather/barometer_sealevel_inhg");

        /// <summary>
        ///  This is the barometric pressure at the point the current flight is at.. Units:29.92+-....
        /// </summary>
        public IXPDataRef<float> Barometer_current_inhg => m_data.GetFloat("sim/weather/barometer_current_inhg");

        /// <summary>
        ///  This is the acceleration of gravity for the current planet.. Units:meters/Sec^2
        /// </summary>
        public IXPDataRef<float> Gravity_mss => m_data.GetFloat("sim/weather/gravity_mss");

        /// <summary>
        ///  This is the speed of sound in meters/Second at the plane's location.. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float> Speed_sound_ms => m_data.GetFloat("sim/weather/speed_sound_ms");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Wind_altitude_msl_m[0] => m_data.GetFloat("sim/weather/wind_altitude_msl_m[0]");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Wind_altitude_msl_m[1] => m_data.GetFloat("sim/weather/wind_altitude_msl_m[1]");

        /// <summary>
        ///  >= 0. Units:meters
        /// </summary>
        public IXPDataRef<float> Wind_altitude_msl_m[2] => m_data.GetFloat("sim/weather/wind_altitude_msl_m[2]");

        /// <summary>
        ///  - 360). Units:[0
        /// </summary>
        public IXPDataRef<float> Wind_direction_degt[0] => m_data.GetFloat("sim/weather/wind_direction_degt[0]");

        /// <summary>
        ///  - 360). Units:[0
        /// </summary>
        public IXPDataRef<float> Wind_direction_degt[1] => m_data.GetFloat("sim/weather/wind_direction_degt[1]");

        /// <summary>
        ///  - 360). Units:[0
        /// </summary>
        public IXPDataRef<float> Wind_direction_degt[2] => m_data.GetFloat("sim/weather/wind_direction_degt[2]");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Wind_speed_kt[0] => m_data.GetFloat("sim/weather/wind_speed_kt[0]");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Wind_speed_kt[1] => m_data.GetFloat("sim/weather/wind_speed_kt[1]");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Wind_speed_kt[2] => m_data.GetFloat("sim/weather/wind_speed_kt[2]");

        /// <summary>
        ///  - 360). Units:[0
        /// </summary>
        public IXPDataRef<float> Shear_direction_degt[0] => m_data.GetFloat("sim/weather/shear_direction_degt[0]");

        /// <summary>
        ///  - 360). Units:[0
        /// </summary>
        public IXPDataRef<float> Shear_direction_degt[1] => m_data.GetFloat("sim/weather/shear_direction_degt[1]");

        /// <summary>
        ///  - 360). Units:[0
        /// </summary>
        public IXPDataRef<float> Shear_direction_degt[2] => m_data.GetFloat("sim/weather/shear_direction_degt[2]");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Shear_speed_kt[0] => m_data.GetFloat("sim/weather/shear_speed_kt[0]");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Shear_speed_kt[1] => m_data.GetFloat("sim/weather/shear_speed_kt[1]");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Shear_speed_kt[2] => m_data.GetFloat("sim/weather/shear_speed_kt[2]");

        /// <summary>
        ///  - 10]. Units:[0
        /// </summary>
        public IXPDataRef<float> Turbulence[0] => m_data.GetFloat("sim/weather/turbulence[0]");

        /// <summary>
        ///  - 10]. Units:[0
        /// </summary>
        public IXPDataRef<float> Turbulence[1] => m_data.GetFloat("sim/weather/turbulence[1]");

        /// <summary>
        ///  - 10]. Units:[0
        /// </summary>
        public IXPDataRef<float> Turbulence[2] => m_data.GetFloat("sim/weather/turbulence[2]");

        /// <summary>
        ///  Amplitude of waves in the water (height of waves). Units:meters
        /// </summary>
        public IXPDataRef<float> Wave_amplitude => m_data.GetFloat("sim/weather/wave_amplitude");

        /// <summary>
        ///  Length of a single wave in the water. Units:meters
        /// </summary>
        public IXPDataRef<float> Wave_length => m_data.GetFloat("sim/weather/wave_length");

        /// <summary>
        ///  Speed of water waves. Units:meters/Second
        /// </summary>
        public IXPDataRef<float> Wave_speed => m_data.GetFloat("sim/weather/wave_speed");

        /// <summary>
        ///  The temperature at sea level.. Units:degreesC
        /// </summary>
        public IXPDataRef<float> Temperature_sealevel_c => m_data.GetFloat("sim/weather/temperature_sealevel_c");

        /// <summary>
        ///  The dew point at sea level.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dewpoi_sealevel_c => m_data.GetFloat("sim/weather/dewpoi_sealevel_c");

        /// <summary>
        ///  The air temperature outside the aircraft (at altitude).. Units:degrees
        /// </summary>
        public IXPDataRef<float> Temperature_ambient_c => m_data.GetFloat("sim/weather/temperature_ambient_c");

        /// <summary>
        ///  The air temperature at the leading edge of the wings in degrees C.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Temperature_le_c => m_data.GetFloat("sim/weather/temperature_le_c");

        /// <summary>
        ///  - 1.0]. Units:[0.0
        /// </summary>
        public IXPDataRef<float> Thermal_percent => m_data.GetFloat("sim/weather/thermal_percent");

        /// <summary>
        ///  >= 0. Units:m/S
        /// </summary>
        public IXPDataRef<float> Thermal_rate_ms => m_data.GetFloat("sim/weather/thermal_rate_ms");

        /// <summary>
        ///  MSL >= 0. Units:m
        /// </summary>
        public IXPDataRef<float> Thermal_altitude_msl_m => m_data.GetFloat("sim/weather/thermal_altitude_msl_m");

        /// <summary>
        ///  The friction constant for runways (how wet they are).  0 = good, 1 = fair, 2 = poor. Units:0,1,2
        /// </summary>
        public IXPDataRef<float> Runway_friction => m_data.GetFloat("sim/weather/runway_friction");

        /// <summary>
        ///  0 = uniform conditions, 1 = patchy conditions. Units:Booelan
        /// </summary>
        public IXPDataRef<float> Runway_is_patchy => m_data.GetFloat("sim/weather/runway_is_patchy");

        /// <summary>
        ///  The effective direction of the wind at the plane's location.. Units:[0-359)
        /// </summary>
        public IXPDataRef<float> Wind_direction_degt => m_data.GetFloat("sim/weather/wind_direction_degt");

        /// <summary>
        ///  >= 0. Units:kts
        /// </summary>
        public IXPDataRef<float> Wind_speed_kt => m_data.GetFloat("sim/weather/wind_speed_kt");

        /// <summary>
        ///  Wind direction vector in OpenGL coordinates, X component.. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float> Wind_now_x_msc => m_data.GetFloat("sim/weather/wind_now_x_msc");

        /// <summary>
        ///  Wind direction vector in OpenGL coordinates, Y component.. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float> Wind_now_y_msc => m_data.GetFloat("sim/weather/wind_now_y_msc");

        /// <summary>
        ///  Wind direction vector in OpenGL coordinates, Z component.. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float> Wind_now_z_msc => m_data.GetFloat("sim/weather/wind_now_z_msc");

        /// <summary>
        ///  The amount of rain on the airplane windshield as a ratio from 0 to 1.. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Precipitation_on_aircraft_ratio => m_data.GetFloat("sim/weather/precipitation_on_aircraft_ratio");
    }
}