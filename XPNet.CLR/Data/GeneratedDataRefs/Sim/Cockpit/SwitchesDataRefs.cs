using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_switchesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_switchesDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Is the anti-icing system on.  This turns on EVERY anti-ice system.. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_on
        /// </summary>
        public IXPDataRef<bool> anti_ice_on { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_on");} }

        /// <summary>
        ///  Turns on inlet heating for engine 1. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_inlet_heat
        /// </summary>
        public IXPDataRef<bool> anti_ice_inlet_heat { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_inlet_heat");} }

        /// <summary>
        ///  Turns on inlet heating - array access to all engines, up to 8. (Deprecated - use correct spelled dataref). Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_inlet_heat_per_enigne
        /// </summary>
        public IXPDataRef<bool[]> anti_ice_inlet_heat_per_enigne { get { return m_data.GetBoolArray("sim/cockpit/switches/anti_ice_inlet_heat_per_enigne");} }

        /// <summary>
        ///  Turns on inlet heating - array access to all engines, up to 8.. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_inlet_heat_per_engine
        /// </summary>
        public IXPDataRef<bool[]> anti_ice_inlet_heat_per_engine { get { return m_data.GetBoolArray("sim/cockpit/switches/anti_ice_inlet_heat_per_engine");} }

        /// <summary>
        ///  Turns on prop heat for prop 1. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_prop_heat
        /// </summary>
        public IXPDataRef<bool> anti_ice_prop_heat { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_prop_heat");} }

        /// <summary>
        ///  Turns on prop heat - array access to all props, up to 8.. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_prop_heat_per_engine
        /// </summary>
        public IXPDataRef<bool[]> anti_ice_prop_heat_per_engine { get { return m_data.GetBoolArray("sim/cockpit/switches/anti_ice_prop_heat_per_engine");} }

        /// <summary>
        ///  Turns on anti-icing fr the windshield. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_window_heat
        /// </summary>
        public IXPDataRef<bool> anti_ice_window_heat { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_window_heat");} }

        /// <summary>
        ///  Is the pitot heat on. Units:bool
        ///  Raw path: sim/cockpit/switches/pitot_heat_on
        /// </summary>
        public IXPDataRef<bool> pitot_heat_on { get { return m_data.GetBool("sim/cockpit/switches/pitot_heat_on");} }

        /// <summary>
        ///  Is the backup pitot heat on. Units:bool
        ///  Raw path: sim/cockpit/switches/pitot_heat_on2
        /// </summary>
        public IXPDataRef<bool> pitot_heat_on2 { get { return m_data.GetBool("sim/cockpit/switches/pitot_heat_on2");} }

        /// <summary>
        ///  Turns on anti-icing for alpha vane heater, pilot side. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_AOA_heat
        /// </summary>
        public IXPDataRef<bool> anti_ice_AOA_heat { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_aoa_heat");} }

        /// <summary>
        ///  Turns on anti-icing for alpha vane heater, copilot side. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_AOA_heat2
        /// </summary>
        public IXPDataRef<bool> anti_ice_AOA_heat2 { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_aoa_heat2");} }

        /// <summary>
        ///  Turns on surface heat on the wings. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_surf_heat
        /// </summary>
        public IXPDataRef<bool> anti_ice_surf_heat { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_surf_heat");} }

        /// <summary>
        ///  Turns on surface heat on the left wing. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_surf_heat_left
        /// </summary>
        public IXPDataRef<bool> anti_ice_surf_heat_left { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_surf_heat_left");} }

        /// <summary>
        ///  Turns on surface heat on the right wing. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_surf_heat_right
        /// </summary>
        public IXPDataRef<bool> anti_ice_surf_heat_right { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_surf_heat_right");} }

        /// <summary>
        ///  Turns on the wing-surface anti-ice boot (knocks ice off I think).. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_surf_boot
        /// </summary>
        public IXPDataRef<bool> anti_ice_surf_boot { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_surf_boot");} }

        /// <summary>
        ///  ignition source is turned on automatically on low N1 to prevent flameout. Units:bool
        ///  Raw path: sim/cockpit/switches/anti_ice_auto_ignite
        /// </summary>
        public IXPDataRef<bool> anti_ice_auto_ignite { get { return m_data.GetBool("sim/cockpit/switches/anti_ice_auto_ignite");} }

        /// <summary>
        ///  Turns on ice detect. Units:bool
        ///  Raw path: sim/cockpit/switches/ice_detect
        /// </summary>
        public IXPDataRef<bool> ice_detect { get { return m_data.GetBool("sim/cockpit/switches/ice_detect");} }

        /// <summary>
        ///  0=app,1=vor,2=map,3=nav,4=pln specific mode of the map (or HSI). Units:enum
        ///  Raw path: sim/cockpit/switches/EFIS_map_submode
        /// </summary>
        public IXPDataRef<int> EFIS_map_submode { get { return m_data.GetInt("sim/cockpit/switches/efis_map_submode");} }

        /// <summary>
        ///  Gear handle is up or down?. Units:boolean
        ///  Raw path: sim/cockpit/switches/gear_handle_status
        /// </summary>
        public IXPDataRef<bool> gear_handle_status { get { return m_data.GetBool("sim/cockpit/switches/gear_handle_status");} }

        /// <summary>
        ///  Does the EFIS display show storms/weather? - legacy - origin dataref contained a typo. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIFS_shows_weather
        /// </summary>
        public IXPDataRef<bool> EFIFS_shows_weather { get { return m_data.GetBool("sim/cockpit/switches/efifs_shows_weather");} }

        /// <summary>
        ///  Does the EFIS display show storms/weather?. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIS_shows_weather
        /// </summary>
        public IXPDataRef<bool> EFIS_shows_weather { get { return m_data.GetBool("sim/cockpit/switches/efis_shows_weather");} }

        /// <summary>
        ///  Alpha level of EFIS weather from 0 to 1. Units:ratio
        ///  Raw path: sim/cockpit/switches/EFIS_weather_alpha
        /// </summary>
        public IXPDataRef<float> EFIS_weather_alpha { get { return m_data.GetFloat("sim/cockpit/switches/efis_weather_alpha");} }

        /// <summary>
        ///  Does the EFIS show other aircraft?. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIS_shows_tcas
        /// </summary>
        public IXPDataRef<bool> EFIS_shows_tcas { get { return m_data.GetBool("sim/cockpit/switches/efis_shows_tcas");} }

        /// <summary>
        ///  Does the EFIS show other airports?. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIS_shows_airports
        /// </summary>
        public IXPDataRef<bool> EFIS_shows_airports { get { return m_data.GetBool("sim/cockpit/switches/efis_shows_airports");} }

        /// <summary>
        ///  Does the EFIS show waypoints?. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIS_shows_waypoints
        /// </summary>
        public IXPDataRef<bool> EFIS_shows_waypoints { get { return m_data.GetBool("sim/cockpit/switches/efis_shows_waypoints");} }

        /// <summary>
        ///  Does the EFIS show VORs?. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIS_shows_VORs
        /// </summary>
        public IXPDataRef<bool> EFIS_shows_VORs { get { return m_data.GetBool("sim/cockpit/switches/efis_shows_vors");} }

        /// <summary>
        ///  Does the EFIS show NDBs?. Units:boolean
        ///  Raw path: sim/cockpit/switches/EFIS_shows_NDBs
        /// </summary>
        public IXPDataRef<bool> EFIS_shows_NDBs { get { return m_data.GetBool("sim/cockpit/switches/efis_shows_ndbs");} }

        /// <summary>
        ///  What mode is the Argus 2000 in. Units:enum
        ///  Raw path: sim/cockpit/switches/argus_mode
        /// </summary>
        public IXPDataRef<int> argus_mode { get { return m_data.GetInt("sim/cockpit/switches/argus_mode");} }

        /// <summary>
        ///  No Smoking. Units:boolean
        ///  Raw path: sim/cockpit/switches/no_smoking
        /// </summary>
        public IXPDataRef<bool> no_smoking { get { return m_data.GetBool("sim/cockpit/switches/no_smoking");} }

        /// <summary>
        ///  Fasten Seat Belts. Units:boolean
        ///  Raw path: sim/cockpit/switches/fasten_seat_belts
        /// </summary>
        public IXPDataRef<bool> fasten_seat_belts { get { return m_data.GetBool("sim/cockpit/switches/fasten_seat_belts");} }
    }
}