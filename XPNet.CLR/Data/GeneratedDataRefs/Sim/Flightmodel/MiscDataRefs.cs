using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        /// </summary>
        public IXPDataRef<float> H_ind => m_data.GetFloat("sim/flightmodel/misc/h_ind");

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        /// </summary>
        public IXPDataRef<float> H_ind2 => m_data.GetFloat("sim/flightmodel/misc/h_ind2");

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        /// </summary>
        public IXPDataRef<float> H_ind_copilot => m_data.GetFloat("sim/flightmodel/misc/h_ind_copilot");

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        /// </summary>
        public IXPDataRef<float> H_ind_copilot2 => m_data.GetFloat("sim/flightmodel/misc/h_ind_copilot2");

        /// <summary>
        ///  Ambient Q. Units:psf
        /// </summary>
        public IXPDataRef<float> Qstatic => m_data.GetFloat("sim/flightmodel/misc/qstatic");

        /// <summary>
        ///  Center of Gravity. Units:meters
        /// </summary>
        public IXPDataRef<float> Cgz_ref_to_default => m_data.GetFloat("sim/flightmodel/misc/cgz_ref_to_default");

        /// <summary>
        ///  Force feedback: total pounds on yoke by ACF due to pitch. Units:lbs
        /// </summary>
        public IXPDataRef<float> Act_frc_ptch_lb => m_data.GetFloat("sim/flightmodel/misc/act_frc_ptch_lb");

        /// <summary>
        ///  Force feedback: total pounds on yoke by ACF due to roll. Units:lbs
        /// </summary>
        public IXPDataRef<float> Act_frc_roll_lb => m_data.GetFloat("sim/flightmodel/misc/act_frc_roll_lb");

        /// <summary>
        ///  Force feedback: total pounds on pedals by ACF due to heading. Units:lbs
        /// </summary>
        public IXPDataRef<float> Act_frc_hdng_lb => m_data.GetFloat("sim/flightmodel/misc/act_frc_hdng_lb");

        /// <summary>
        ///  Force feedback: total pounds on pedals by ACF due to left brake. Units:lbs
        /// </summary>
        public IXPDataRef<float> Act_frc_lbrk_lb => m_data.GetFloat("sim/flightmodel/misc/act_frc_lbrk_lb");

        /// <summary>
        ///  Force feedback: total pounds on pedals by ACF due to right brake. Units:lbs
        /// </summary>
        public IXPDataRef<float> Act_frc_rbrk_lb => m_data.GetFloat("sim/flightmodel/misc/act_frc_rbrk_lb");

        /// <summary>
        ///  Global location of slung load, meters, x coordinate. Units:meters
        /// </summary>
        public IXPDataRef<float> Slung_load_x => m_data.GetFloat("sim/flightmodel/misc/slung_load_x");

        /// <summary>
        ///  Global location of slung load, meters, y coordinate. Units:meters
        /// </summary>
        public IXPDataRef<float> Slung_load_y => m_data.GetFloat("sim/flightmodel/misc/slung_load_y");

        /// <summary>
        ///  Global location of slung load, meters, z coordinate. Units:meters
        /// </summary>
        public IXPDataRef<float> Slung_load_z => m_data.GetFloat("sim/flightmodel/misc/slung_load_z");
    }
}