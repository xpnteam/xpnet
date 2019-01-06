using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit_gyrosDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit_gyrosDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The indicated pitch on the panel for the first vacuum instrument
        /// </summary>
        public IXPDataRef<float> the_vac_ind_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_vac_ind_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the second vacuum instrument - dataref name is worng!
        /// </summary>
        public IXPDataRef<float> the_ele_ind_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ele_ind_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the first elect instrument
        /// </summary>
        public IXPDataRef<float> the_ind_deg3 { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_deg3");} }

        /// <summary>
        ///  The indicated pitch on the panel for the second elect instrument
        /// </summary>
        public IXPDataRef<float> the_ind_deg4 { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_deg4");} }

        /// <summary>
        ///  The indicated pitch on the panel for the pilot's side, vacuum driven
        /// </summary>
        public IXPDataRef<float> the_ind_vac_pilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_vac_pilot_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the copilot's side, vacuum driven
        /// </summary>
        public IXPDataRef<float> the_ind_vac_copilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_vac_copilot_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the pilot's side, electric
        /// </summary>
        public IXPDataRef<float> the_ind_elec_pilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_elec_pilot_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the copilot's side, electric
        /// </summary>
        public IXPDataRef<float> the_ind_elec_copilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_elec_copilot_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the pilot's side, AHARS
        /// </summary>
        public IXPDataRef<float> the_ind_ahars_pilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_ahars_pilot_deg");} }

        /// <summary>
        ///  The indicated pitch on the panel for the copilot's side, AHARS
        /// </summary>
        public IXPDataRef<float> the_ind_ahars_copilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/the_ind_ahars_copilot_deg");} }

        /// <summary>
        ///  The indicated heading on the panel for the first vacuum instrument
        /// </summary>
        public IXPDataRef<float> psi_vac_ind_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_vac_ind_degm");} }

        /// <summary>
        ///  The indicated heading on the panel for the second vacuum instrument - dataref name is worng!
        /// </summary>
        public IXPDataRef<float> psi_ele_ind_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ele_ind_degm");} }

        /// <summary>
        ///  The indicated heading on the panel for the first elect instrument
        /// </summary>
        public IXPDataRef<float> psi_ind_degm3 { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_degm3");} }

        /// <summary>
        ///  The indicated heading on the panel for the second elect instrument
        /// </summary>
        public IXPDataRef<float> psi_ind_degm4 { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_degm4");} }

        /// <summary>
        ///  The indicated magnetic heading on the panel for the pilot's side, vacuum driven
        /// </summary>
        public IXPDataRef<float> psi_ind_vac_pilot_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_vac_pilot_degm");} }

        /// <summary>
        ///  The indicated magnetic heading on the panel for the copilot's side, vacuum driven
        /// </summary>
        public IXPDataRef<float> psi_ind_vac_copilot_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_vac_copilot_degm");} }

        /// <summary>
        ///  The indicated magnetic heading on the panel for the pilot's side, electric
        /// </summary>
        public IXPDataRef<float> psi_ind_elec_pilot_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_elec_pilot_degm");} }

        /// <summary>
        ///  The indicated magnetic heading on the panel for the copilot's side, electric
        /// </summary>
        public IXPDataRef<float> psi_ind_elec_copilot_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_elec_copilot_degm");} }

        /// <summary>
        ///  The indicated magnetic heading on the panel for the pilot's side, AHARS
        /// </summary>
        public IXPDataRef<float> psi_ind_ahars_pilot_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_ahars_pilot_degm");} }

        /// <summary>
        ///  The indicated magnetic heading on the panel for the copilot's side, AHARS
        /// </summary>
        public IXPDataRef<float> psi_ind_ahars_copilot_degm { get { return m_data.GetFloat("sim/cockpit/gyros/psi_ind_ahars_copilot_degm");} }

        /// <summary>
        ///  The indicated roll on the panel for the first vacuum instrument
        /// </summary>
        public IXPDataRef<float> phi_vac_ind_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_vac_ind_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the second vacuum instrument - dataref name is worng!
        /// </summary>
        public IXPDataRef<float> phi_ele_ind_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ele_ind_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the first elect instrument
        /// </summary>
        public IXPDataRef<float> phi_ind_deg3 { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_deg3");} }

        /// <summary>
        ///  The indicated roll on the panel for the second elect instrument
        /// </summary>
        public IXPDataRef<float> phi_ind_deg4 { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_deg4");} }

        /// <summary>
        ///  The indicated roll on the panel for the pilot's side, vacuum driven
        /// </summary>
        public IXPDataRef<float> phi_ind_vac_pilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_vac_pilot_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the copilot's side, vacuum driven
        /// </summary>
        public IXPDataRef<float> phi_ind_vac_copilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_vac_copilot_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the pilot's side, electric
        /// </summary>
        public IXPDataRef<float> phi_ind_elec_pilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_elec_pilot_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the copilot's side, electric
        /// </summary>
        public IXPDataRef<float> phi_ind_elec_copilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_elec_copilot_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the pilot's side, AHARS
        /// </summary>
        public IXPDataRef<float> phi_ind_ahars_pilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_ahars_pilot_deg");} }

        /// <summary>
        ///  The indicated roll on the panel for the copilot's side, AHARS
        /// </summary>
        public IXPDataRef<float> phi_ind_ahars_copilot_deg { get { return m_data.GetFloat("sim/cockpit/gyros/phi_ind_ahars_copilot_deg");} }

        /// <summary>
        ///  A delta between the plane's heading and the DG for vacuum 1 powered DGs
        /// </summary>
        public IXPDataRef<float> dg_drift_vac_deg { get { return m_data.GetFloat("sim/cockpit/gyros/dg_drift_vac_deg");} }

        /// <summary>
        ///  A delta between the plane's heading and the DG for vacuum 2 powered DGs
        /// </summary>
        public IXPDataRef<float> dg_drift_vac2_deg { get { return m_data.GetFloat("sim/cockpit/gyros/dg_drift_vac2_deg");} }

        /// <summary>
        ///  A delta between the plane's heading and the DG for electric 1 powered DGs
        /// </summary>
        public IXPDataRef<float> dg_drift_ele_deg { get { return m_data.GetFloat("sim/cockpit/gyros/dg_drift_ele_deg");} }

        /// <summary>
        ///  A delta between the plane's heading and the DG for electric 2 powered DGs
        /// </summary>
        public IXPDataRef<float> dg_drift_ele2_deg { get { return m_data.GetFloat("sim/cockpit/gyros/dg_drift_ele2_deg");} }

        /// <summary>
        ///  A delta between the plane's heading and the DG for AHARS 1 powered DGs
        /// </summary>
        public IXPDataRef<float> dg_drift_ahars_deg { get { return m_data.GetFloat("sim/cockpit/gyros/dg_drift_ahars_deg");} }

        /// <summary>
        ///  A delta between the plane's heading and the DG for AHARS 2 powered DGs
        /// </summary>
        public IXPDataRef<float> dg_drift_ahars2_deg { get { return m_data.GetFloat("sim/cockpit/gyros/dg_drift_ahars2_deg");} }
    }
}