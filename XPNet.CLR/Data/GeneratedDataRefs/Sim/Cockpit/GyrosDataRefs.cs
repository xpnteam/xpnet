using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Cockpit_GyrosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Cockpit_GyrosDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The indicated pitch on the panel for the first vacuum instrument. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_vac_ind_deg => m_data.GetFloat("sim/cockpit/gyros/the_vac_ind_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the second vacuum instrument - dataref name is worng!. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ele_ind_deg => m_data.GetFloat("sim/cockpit/gyros/the_ele_ind_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the first elect instrument. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_deg3 => m_data.GetFloat("sim/cockpit/gyros/the_ind_deg3");

        /// <summary>
        ///  The indicated pitch on the panel for the second elect instrument. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_deg4 => m_data.GetFloat("sim/cockpit/gyros/the_ind_deg4");

        /// <summary>
        ///  The indicated pitch on the panel for the pilot's side, vacuum driven. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_vac_pilot_deg => m_data.GetFloat("sim/cockpit/gyros/the_ind_vac_pilot_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the copilot's side, vacuum driven. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_vac_copilot_deg => m_data.GetFloat("sim/cockpit/gyros/the_ind_vac_copilot_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the pilot's side, electric. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_elec_pilot_deg => m_data.GetFloat("sim/cockpit/gyros/the_ind_elec_pilot_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the copilot's side, electric. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_elec_copilot_deg => m_data.GetFloat("sim/cockpit/gyros/the_ind_elec_copilot_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the pilot's side, AHARS. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_ahars_pilot_deg => m_data.GetFloat("sim/cockpit/gyros/the_ind_ahars_pilot_deg");

        /// <summary>
        ///  The indicated pitch on the panel for the copilot's side, AHARS. Units:degrees
        /// </summary>
        public IXPDataRef<float> The_ind_ahars_copilot_deg => m_data.GetFloat("sim/cockpit/gyros/the_ind_ahars_copilot_deg");

        /// <summary>
        ///  The indicated heading on the panel for the first vacuum instrument. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_vac_ind_degm => m_data.GetFloat("sim/cockpit/gyros/psi_vac_ind_degm");

        /// <summary>
        ///  The indicated heading on the panel for the second vacuum instrument - dataref name is worng!. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ele_ind_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ele_ind_degm");

        /// <summary>
        ///  The indicated heading on the panel for the first elect instrument. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_degm3 => m_data.GetFloat("sim/cockpit/gyros/psi_ind_degm3");

        /// <summary>
        ///  The indicated heading on the panel for the second elect instrument. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_degm4 => m_data.GetFloat("sim/cockpit/gyros/psi_ind_degm4");

        /// <summary>
        ///  The indicated magnetic heading on the panel for the pilot's side, vacuum driven. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_vac_pilot_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ind_vac_pilot_degm");

        /// <summary>
        ///  The indicated magnetic heading on the panel for the copilot's side, vacuum driven. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_vac_copilot_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ind_vac_copilot_degm");

        /// <summary>
        ///  The indicated magnetic heading on the panel for the pilot's side, electric. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_elec_pilot_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ind_elec_pilot_degm");

        /// <summary>
        ///  The indicated magnetic heading on the panel for the copilot's side, electric. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_elec_copilot_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ind_elec_copilot_degm");

        /// <summary>
        ///  The indicated magnetic heading on the panel for the pilot's side, AHARS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_ahars_pilot_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ind_ahars_pilot_degm");

        /// <summary>
        ///  The indicated magnetic heading on the panel for the copilot's side, AHARS. Units:degrees_magnetic
        /// </summary>
        public IXPDataRef<float> Psi_ind_ahars_copilot_degm => m_data.GetFloat("sim/cockpit/gyros/psi_ind_ahars_copilot_degm");

        /// <summary>
        ///  The indicated roll on the panel for the first vacuum instrument. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_vac_ind_deg => m_data.GetFloat("sim/cockpit/gyros/phi_vac_ind_deg");

        /// <summary>
        ///  The indicated roll on the panel for the second vacuum instrument - dataref name is worng!. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ele_ind_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ele_ind_deg");

        /// <summary>
        ///  The indicated roll on the panel for the first elect instrument. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_deg3 => m_data.GetFloat("sim/cockpit/gyros/phi_ind_deg3");

        /// <summary>
        ///  The indicated roll on the panel for the second elect instrument. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_deg4 => m_data.GetFloat("sim/cockpit/gyros/phi_ind_deg4");

        /// <summary>
        ///  The indicated roll on the panel for the pilot's side, vacuum driven. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_vac_pilot_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ind_vac_pilot_deg");

        /// <summary>
        ///  The indicated roll on the panel for the copilot's side, vacuum driven. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_vac_copilot_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ind_vac_copilot_deg");

        /// <summary>
        ///  The indicated roll on the panel for the pilot's side, electric. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_elec_pilot_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ind_elec_pilot_deg");

        /// <summary>
        ///  The indicated roll on the panel for the copilot's side, electric. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_elec_copilot_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ind_elec_copilot_deg");

        /// <summary>
        ///  The indicated roll on the panel for the pilot's side, AHARS. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_ahars_pilot_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ind_ahars_pilot_deg");

        /// <summary>
        ///  The indicated roll on the panel for the copilot's side, AHARS. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi_ind_ahars_copilot_deg => m_data.GetFloat("sim/cockpit/gyros/phi_ind_ahars_copilot_deg");

        /// <summary>
        ///  A delta between the plane's heading and the DG for vacuum 1 powered DGs. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dg_drift_vac_deg => m_data.GetFloat("sim/cockpit/gyros/dg_drift_vac_deg");

        /// <summary>
        ///  A delta between the plane's heading and the DG for vacuum 2 powered DGs. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dg_drift_vac2_deg => m_data.GetFloat("sim/cockpit/gyros/dg_drift_vac2_deg");

        /// <summary>
        ///  A delta between the plane's heading and the DG for electric 1 powered DGs. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dg_drift_ele_deg => m_data.GetFloat("sim/cockpit/gyros/dg_drift_ele_deg");

        /// <summary>
        ///  A delta between the plane's heading and the DG for electric 2 powered DGs. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dg_drift_ele2_deg => m_data.GetFloat("sim/cockpit/gyros/dg_drift_ele2_deg");

        /// <summary>
        ///  A delta between the plane's heading and the DG for AHARS 1 powered DGs. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dg_drift_ahars_deg => m_data.GetFloat("sim/cockpit/gyros/dg_drift_ahars_deg");

        /// <summary>
        ///  A delta between the plane's heading and the DG for AHARS 2 powered DGs. Units:degrees
        /// </summary>
        public IXPDataRef<float> Dg_drift_ahars2_deg => m_data.GetFloat("sim/cockpit/gyros/dg_drift_ahars2_deg");
    }
}