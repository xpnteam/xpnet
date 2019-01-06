using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_ViewDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_ViewDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Tail number
        /// </summary>
        public IXPDataRef<string> Acf_tailnum { get { return m_data.GetString("sim/aircraft/view/acf_tailnum");} }

        /// <summary>
        ///  Author's Name
        /// </summary>
        public IXPDataRef<string> Acf_author { get { return m_data.GetString("sim/aircraft/view/acf_author");} }

        /// <summary>
        ///  Brief description of the plane.  Was 500 chars in older planes.
        /// </summary>
        public IXPDataRef<string> Acf_descrip { get { return m_data.GetString("sim/aircraft/view/acf_descrip");} }

        /// <summary>
        ///  Notes on the plane
        /// </summary>
        public IXPDataRef<string> Acf_notes { get { return m_data.GetString("sim/aircraft/view/acf_notes");} }

        /// <summary>
        ///  has single cue flight director?
        /// </summary>
        public IXPDataRef<bool> Acf_has_SC_fd { get { return m_data.GetBool("sim/aircraft/view/acf_has_sc_fd");} }

        /// <summary>
        ///  has audio stall warning?
        /// </summary>
        public IXPDataRef<bool> Acf_has_stallwarn { get { return m_data.GetBool("sim/aircraft/view/acf_has_stallwarn");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, X
        /// </summary>
        public IXPDataRef<float> Acf_peX { get { return m_data.GetFloat("sim/aircraft/view/acf_pex");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, Y
        /// </summary>
        public IXPDataRef<float> Acf_peY { get { return m_data.GetFloat("sim/aircraft/view/acf_pey");} }

        /// <summary>
        ///  Position of pilot's head relative to CG, Z
        /// </summary>
        public IXPDataRef<float> Acf_peZ { get { return m_data.GetFloat("sim/aircraft/view/acf_pez");} }

        /// <summary>
        ///  Various speed maxes for the aircraft.
        /// </summary>
        public IXPDataRef<float> Acf_Vso { get { return m_data.GetFloat("sim/aircraft/view/acf_vso");} }

        /// <summary>
        ///  ICAO code for aircraft (a string) entered by author
        /// </summary>
        public IXPDataRef<string> Acf_ICAO { get { return m_data.GetString("sim/aircraft/view/acf_icao");} }

        /// <summary>
        ///  position of door relative to CG, latitude offset in meters
        /// </summary>
        public IXPDataRef<float> Acf_door_x { get { return m_data.GetFloat("sim/aircraft/view/acf_door_x");} }

        /// <summary>
        ///  position of door relative to CG, vertical offset in meters
        /// </summary>
        public IXPDataRef<float> Acf_door_y { get { return m_data.GetFloat("sim/aircraft/view/acf_door_y");} }

        /// <summary>
        ///  position of door relative to CG, longitude offset in meters
        /// </summary>
        public IXPDataRef<float> Acf_door_z { get { return m_data.GetFloat("sim/aircraft/view/acf_door_z");} }

        /// <summary>
        ///  path of current livery.  dir separator i, ends in dir separator.  WARNING: slow dataref, don't read a lot!
        /// </summary>
        public IXPDataRef<string> Acf_livery_path { get { return m_data.GetString("sim/aircraft/view/acf_livery_path");} }
    }
}