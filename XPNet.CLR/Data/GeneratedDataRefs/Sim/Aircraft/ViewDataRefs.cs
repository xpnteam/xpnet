using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_aircraft_viewDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_aircraft_viewDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Tail number. Units:string
        ///  Raw path: sim/aircraft/view/acf_tailnum
        /// </summary>
        public IXPDataRef<string> acf_tailnum { get { return m_data.GetString("sim/aircraft/view/acf_tailnum");} }

        /// <summary>
        ///  Author's Name. Units:string
        ///  Raw path: sim/aircraft/view/acf_author
        /// </summary>
        public IXPDataRef<string> acf_author { get { return m_data.GetString("sim/aircraft/view/acf_author");} }

        /// <summary>
        ///  Brief description of the plane.  Was 500 chars in older planes.. Units:string
        ///  Raw path: sim/aircraft/view/acf_descrip
        /// </summary>
        public IXPDataRef<string> acf_descrip { get { return m_data.GetString("sim/aircraft/view/acf_descrip");} }

        /// <summary>
        ///  Notes on the plane. Units:string
        ///  Raw path: sim/aircraft/view/acf_notes
        /// </summary>
        public IXPDataRef<string> acf_notes { get { return m_data.GetString("sim/aircraft/view/acf_notes");} }

        /// <summary>
        ///  air speed indicator knots calibration. Units:enum
        ///  Raw path: sim/aircraft/view/acf_asi_kts
        /// </summary>
        public IXPDataRef<int> acf_asi_kts { get { return m_data.GetInt("sim/aircraft/view/acf_asi_kts");} }

        /// <summary>
        ///  cockpit panel type. Units:enum
        ///  Raw path: sim/aircraft/view/acf_cockpit_type
        /// </summary>
        public IXPDataRef<int> acf_cockpit_type { get { return m_data.GetInt("sim/aircraft/view/acf_cockpit_type");} }

        /// <summary>
        ///  has single cue flight director?. Units:bool
        ///  Raw path: sim/aircraft/view/acf_has_SC_fd
        /// </summary>
        public IXPDataRef<bool> acf_has_SC_fd { get { return m_data.GetBool("sim/aircraft/view/acf_has_sc_fd");} }

        /// <summary>
        ///  has audio stall warning?. Units:bool
        ///  Raw path: sim/aircraft/view/acf_has_stallwarn
        /// </summary>
        public IXPDataRef<bool> acf_has_stallwarn { get { return m_data.GetBool("sim/aircraft/view/acf_has_stallwarn");} }

        /// <summary>
        ///  Do we have a lite map texture for this?. Units:enum
        ///  Raw path: sim/aircraft/view/acf_has_litemap_tex
        /// </summary>
        public IXPDataRef<int> acf_has_litemap_tex { get { return m_data.GetInt("sim/aircraft/view/acf_has_litemap_tex");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, X. Units:pos
        ///  Raw path: sim/aircraft/view/acf_peX
        /// </summary>
        public IXPDataRef<float> acf_peX { get { return m_data.GetFloat("sim/aircraft/view/acf_pex");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, Y. Units:pos
        ///  Raw path: sim/aircraft/view/acf_peY
        /// </summary>
        public IXPDataRef<float> acf_peY { get { return m_data.GetFloat("sim/aircraft/view/acf_pey");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, Z. Units:pos
        ///  Raw path: sim/aircraft/view/acf_peZ
        /// </summary>
        public IXPDataRef<float> acf_peZ { get { return m_data.GetFloat("sim/aircraft/view/acf_pez");} }

        /// <summary>
        ///  Various speed maxes for the aircraft.. Units:kias
        ///  Raw path: sim/aircraft/view/acf_Vso
        /// </summary>
        public IXPDataRef<float> acf_Vso { get { return m_data.GetFloat("sim/aircraft/view/acf_vso");} }

        /// <summary>
        ///  ICAO code for aircraft (a string) entered by author. Units:string
        ///  Raw path: sim/aircraft/view/acf_ICAO
        /// </summary>
        public IXPDataRef<string> acf_ICAO { get { return m_data.GetString("sim/aircraft/view/acf_icao");} }

        /// <summary>
        ///  position of door relative to CG, latitude offset in meters. Units:meters
        ///  Raw path: sim/aircraft/view/acf_door_x
        /// </summary>
        public IXPDataRef<float> acf_door_x { get { return m_data.GetFloat("sim/aircraft/view/acf_door_x");} }

        /// <summary>
        ///  position of door relative to CG, vertical offset in meters. Units:meters
        ///  Raw path: sim/aircraft/view/acf_door_y
        /// </summary>
        public IXPDataRef<float> acf_door_y { get { return m_data.GetFloat("sim/aircraft/view/acf_door_y");} }

        /// <summary>
        ///  position of door relative to CG, longitude offset in meters. Units:meters
        ///  Raw path: sim/aircraft/view/acf_door_z
        /// </summary>
        public IXPDataRef<float> acf_door_z { get { return m_data.GetFloat("sim/aircraft/view/acf_door_z");} }

        /// <summary>
        ///  index number of livery. Units:index
        ///  Raw path: sim/aircraft/view/acf_livery_index
        /// </summary>
        public IXPDataRef<int> acf_livery_index { get { return m_data.GetInt("sim/aircraft/view/acf_livery_index");} }

        /// <summary>
        ///  path of current livery.  dir separator i, ends in dir separator.  WARNING: slow dataref, don't read a lot!. Units:string
        ///  Raw path: sim/aircraft/view/acf_livery_path
        /// </summary>
        public IXPDataRef<string> acf_livery_path { get { return m_data.GetString("sim/aircraft/view/acf_livery_path");} }
    }
}