using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_RadiosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_RadiosDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Are we receiving an expected glide slope for nav1
        /// </summary>
        public IXPDataRef<bool> Nav1_CDI => m_data.GetBool("sim/cockpit/radios/nav1_cdi");

        /// <summary>
        ///  Are we receiving an expected glide slope for nav2
        /// </summary>
        public IXPDataRef<bool> Nav2_CDI => m_data.GetBool("sim/cockpit/radios/nav2_cdi");

        /// <summary>
        ///  Whether we are squawking ident right now.
        /// </summary>
        public IXPDataRef<bool> Transponder_id => m_data.GetBool("sim/cockpit/radios/transponder_id");

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Nav1_has_dme => m_data.GetBool("sim/cockpit/radios/nav1_has_dme");

        /// <summary>
        ///  Does this nav aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Nav2_has_dme => m_data.GetBool("sim/cockpit/radios/nav2_has_dme");

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Adf1_has_dme => m_data.GetBool("sim/cockpit/radios/adf1_has_dme");

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Adf2_has_dme => m_data.GetBool("sim/cockpit/radios/adf2_has_dme");

        /// <summary>
        ///  Does this adf aid have DME?  Use override_dme to set
        /// </summary>
        public IXPDataRef<bool> Dme5_has_dme => m_data.GetBool("sim/cockpit/radios/dme5_has_dme");
    }
}