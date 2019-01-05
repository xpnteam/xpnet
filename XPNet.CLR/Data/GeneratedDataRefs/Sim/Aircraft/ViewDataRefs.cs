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
        public IXPDataRef<string> Acf_tailnum => m_data.GetString("sim/aircraft/view/acf_tailnum");

        /// <summary>
        ///  Author's Name
        /// </summary>
        public IXPDataRef<string> Acf_author => m_data.GetString("sim/aircraft/view/acf_author");

        /// <summary>
        ///  Brief description of the plane.  Was 500 chars in older planes.
        /// </summary>
        public IXPDataRef<string> Acf_descrip => m_data.GetString("sim/aircraft/view/acf_descrip");

        /// <summary>
        ///  Notes on the plane
        /// </summary>
        public IXPDataRef<string> Acf_notes => m_data.GetString("sim/aircraft/view/acf_notes");

        /// <summary>
        ///  has single cue flight director?
        /// </summary>
        public IXPDataRef<bool> Acf_has_SC_fd => m_data.GetBool("sim/aircraft/view/acf_has_sc_fd");

        /// <summary>
        ///  has audio stall warning?
        /// </summary>
        public IXPDataRef<bool> Acf_has_stallwarn => m_data.GetBool("sim/aircraft/view/acf_has_stallwarn");

        /// <summary>
        ///  ICAO code for aircraft (a string) entered by author
        /// </summary>
        public IXPDataRef<string> Acf_ICAO => m_data.GetString("sim/aircraft/view/acf_icao");

        /// <summary>
        ///  path of current livery.  dir separator i, ends in dir separator.  WARNING: slow dataref, don't read a lot!
        /// </summary>
        public IXPDataRef<string> Acf_livery_path => m_data.GetString("sim/aircraft/view/acf_livery_path");
    }
}