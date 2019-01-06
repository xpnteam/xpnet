using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        ///  Raw path: sim/flightmodel/misc/h_ind
        /// </summary>
        public IXPDataRef<float> h_ind { get { return m_data.GetFloat("sim/flightmodel/misc/h_ind");} }

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        ///  Raw path: sim/flightmodel/misc/h_ind2
        /// </summary>
        public IXPDataRef<float> h_ind2 { get { return m_data.GetFloat("sim/flightmodel/misc/h_ind2");} }

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        ///  Raw path: sim/flightmodel/misc/h_ind_copilot
        /// </summary>
        public IXPDataRef<float> h_ind_copilot { get { return m_data.GetFloat("sim/flightmodel/misc/h_ind_copilot");} }

        /// <summary>
        ///  Indicated barometric altitude, quite probably in feet actually.. Units:meters
        ///  Raw path: sim/flightmodel/misc/h_ind_copilot2
        /// </summary>
        public IXPDataRef<float> h_ind_copilot2 { get { return m_data.GetFloat("sim/flightmodel/misc/h_ind_copilot2");} }

        /// <summary>
        ///  Ambient Q. Units:psf
        ///  Raw path: sim/flightmodel/misc/Qstatic
        /// </summary>
        public IXPDataRef<float> Qstatic { get { return m_data.GetFloat("sim/flightmodel/misc/qstatic");} }

        /// <summary>
        ///  Center of Gravity. Units:meters
        ///  Raw path: sim/flightmodel/misc/cgz_ref_to_default
        /// </summary>
        public IXPDataRef<float> cgz_ref_to_default { get { return m_data.GetFloat("sim/flightmodel/misc/cgz_ref_to_default");} }

        /// <summary>
        ///  Force feedback: total pounds on yoke by ACF due to pitch. Units:lbs
        ///  Raw path: sim/flightmodel/misc/act_frc_ptch_lb
        /// </summary>
        public IXPDataRef<float> act_frc_ptch_lb { get { return m_data.GetFloat("sim/flightmodel/misc/act_frc_ptch_lb");} }

        /// <summary>
        ///  Force feedback: total pounds on yoke by ACF due to roll. Units:lbs
        ///  Raw path: sim/flightmodel/misc/act_frc_roll_lb
        /// </summary>
        public IXPDataRef<float> act_frc_roll_lb { get { return m_data.GetFloat("sim/flightmodel/misc/act_frc_roll_lb");} }

        /// <summary>
        ///  Force feedback: total pounds on pedals by ACF due to heading. Units:lbs
        ///  Raw path: sim/flightmodel/misc/act_frc_hdng_lb
        /// </summary>
        public IXPDataRef<float> act_frc_hdng_lb { get { return m_data.GetFloat("sim/flightmodel/misc/act_frc_hdng_lb");} }

        /// <summary>
        ///  Force feedback: total pounds on pedals by ACF due to left brake. Units:lbs
        ///  Raw path: sim/flightmodel/misc/act_frc_lbrk_lb
        /// </summary>
        public IXPDataRef<float> act_frc_lbrk_lb { get { return m_data.GetFloat("sim/flightmodel/misc/act_frc_lbrk_lb");} }

        /// <summary>
        ///  Force feedback: total pounds on pedals by ACF due to right brake. Units:lbs
        ///  Raw path: sim/flightmodel/misc/act_frc_rbrk_lb
        /// </summary>
        public IXPDataRef<float> act_frc_rbrk_lb { get { return m_data.GetFloat("sim/flightmodel/misc/act_frc_rbrk_lb");} }

        /// <summary>
        ///  Global location of slung load, meters, x coordinate. Units:meters
        ///  Raw path: sim/flightmodel/misc/slung_load_x
        /// </summary>
        public IXPDataRef<float> slung_load_x { get { return m_data.GetFloat("sim/flightmodel/misc/slung_load_x");} }

        /// <summary>
        ///  Global location of slung load, meters, y coordinate. Units:meters
        ///  Raw path: sim/flightmodel/misc/slung_load_y
        /// </summary>
        public IXPDataRef<float> slung_load_y { get { return m_data.GetFloat("sim/flightmodel/misc/slung_load_y");} }

        /// <summary>
        ///  Global location of slung load, meters, z coordinate. Units:meters
        ///  Raw path: sim/flightmodel/misc/slung_load_z
        /// </summary>
        public IXPDataRef<float> slung_load_z { get { return m_data.GetFloat("sim/flightmodel/misc/slung_load_z");} }
    }
}