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
        public IXPDataRef<string> Acf_tailnum => m_data.GetString("sim/aircraft/view/acf_tailnum");
        public IXPDataRef<string> Acf_author => m_data.GetString("sim/aircraft/view/acf_author");
        public IXPDataRef<string> Acf_descrip => m_data.GetString("sim/aircraft/view/acf_descrip");
        public IXPDataRef<string> Acf_notes => m_data.GetString("sim/aircraft/view/acf_notes");
        public IXPDataRef<string> Acf_ICAO => m_data.GetString("sim/aircraft/view/acf_icao");
        public IXPDataRef<string> Acf_livery_path => m_data.GetString("sim/aircraft/view/acf_livery_path");
    }
}