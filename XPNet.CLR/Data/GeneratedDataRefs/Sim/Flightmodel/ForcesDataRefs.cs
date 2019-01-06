using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_ForcesDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_ForcesDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Aerodynamic forces - sideways - ACF X
        /// </summary>
        public IXPDataRef<float> Fside_aero { get { return m_data.GetFloat("sim/flightmodel/forces/fside_aero");} }

        /// <summary>
        ///  Aerodynamic forces - upward - ACF Y
        /// </summary>
        public IXPDataRef<float> Fnrml_aero { get { return m_data.GetFloat("sim/flightmodel/forces/fnrml_aero");} }

        /// <summary>
        ///  Aerodynamic forces - backward - ACF Z
        /// </summary>
        public IXPDataRef<float> Faxil_aero { get { return m_data.GetFloat("sim/flightmodel/forces/faxil_aero");} }

        /// <summary>
        ///  force sideways by all engines on the ACF.  Override with override_engines
        /// </summary>
        public IXPDataRef<float> Fside_prop { get { return m_data.GetFloat("sim/flightmodel/forces/fside_prop");} }

        /// <summary>
        ///  force upward by all engines on the ACF.  Override with override_engines  Writable in v10 only
        /// </summary>
        public IXPDataRef<float> Fnrml_prop { get { return m_data.GetFloat("sim/flightmodel/forces/fnrml_prop");} }

        /// <summary>
        ///  force backward by all engines on the ACF (usually this is a negative number).  Override with override_engines
        /// </summary>
        public IXPDataRef<float> Faxil_prop { get { return m_data.GetFloat("sim/flightmodel/forces/faxil_prop");} }

        /// <summary>
        ///  Gear/Ground forces - sideways - ACF X
        /// </summary>
        public IXPDataRef<float> Fside_gear { get { return m_data.GetFloat("sim/flightmodel/forces/fside_gear");} }

        /// <summary>
        ///  Gear/Ground forces - upward - ACF Y
        /// </summary>
        public IXPDataRef<float> Fnrml_gear { get { return m_data.GetFloat("sim/flightmodel/forces/fnrml_gear");} }

        /// <summary>
        ///  Gear/Ground forces - backward - ACF Z
        /// </summary>
        public IXPDataRef<float> Faxil_gear { get { return m_data.GetFloat("sim/flightmodel/forces/faxil_gear");} }

        /// <summary>
        ///  total/Ground forces - ACF X axis.  Override with override_forces
        /// </summary>
        public IXPDataRef<float> Fside_total { get { return m_data.GetFloat("sim/flightmodel/forces/fside_total");} }

        /// <summary>
        ///  Total/Ground forces - ACF Y axis.  Override with override_forces
        /// </summary>
        public IXPDataRef<float> Fnrml_total { get { return m_data.GetFloat("sim/flightmodel/forces/fnrml_total");} }

        /// <summary>
        ///  total/Ground forces - ACF Z axis.  Override with override_forces
        /// </summary>
        public IXPDataRef<float> Faxil_total { get { return m_data.GetFloat("sim/flightmodel/forces/faxil_total");} }

        /// <summary>
        ///  The roll moment due to aerodynamic forces - positive = right roll.
        /// </summary>
        public IXPDataRef<float> L_aero { get { return m_data.GetFloat("sim/flightmodel/forces/l_aero");} }

        /// <summary>
        ///  The pitch moment due to aerodynamic forces - positive = pitch up.
        /// </summary>
        public IXPDataRef<float> M_aero { get { return m_data.GetFloat("sim/flightmodel/forces/m_aero");} }

        /// <summary>
        ///  The yaw moment due to aerodynamic forces - positive = yaw right/Clockwise.
        /// </summary>
        public IXPDataRef<float> N_aero { get { return m_data.GetFloat("sim/flightmodel/forces/n_aero");} }

        /// <summary>
        ///  The roll moment due to prop forces. Override with override_engines - positive = right roll.
        /// </summary>
        public IXPDataRef<float> L_prop { get { return m_data.GetFloat("sim/flightmodel/forces/l_prop");} }

        /// <summary>
        ///  The pitch moment due to prop forces. Override with override_engines - positive = pitch up.
        /// </summary>
        public IXPDataRef<float> M_prop { get { return m_data.GetFloat("sim/flightmodel/forces/m_prop");} }

        /// <summary>
        ///  The yaw moment due to prop forces. Override with override_engines - positive = yaw right/Clockwise.
        /// </summary>
        public IXPDataRef<float> N_prop { get { return m_data.GetFloat("sim/flightmodel/forces/n_prop");} }

        /// <summary>
        ///  The roll moment due to gear forces - positive = right roll.
        /// </summary>
        public IXPDataRef<float> L_gear { get { return m_data.GetFloat("sim/flightmodel/forces/l_gear");} }

        /// <summary>
        ///  The pitch moment due to gear forces - positive = pitch up.
        /// </summary>
        public IXPDataRef<float> M_gear { get { return m_data.GetFloat("sim/flightmodel/forces/m_gear");} }

        /// <summary>
        ///  The yaw moment due to gear forces positive = yaw right/Clockwise.
        /// </summary>
        public IXPDataRef<float> N_gear { get { return m_data.GetFloat("sim/flightmodel/forces/n_gear");} }

        /// <summary>
        ///  The roll moment due to asymmetric loading - positive = right roll.
        /// </summary>
        public IXPDataRef<float> L_mass { get { return m_data.GetFloat("sim/flightmodel/forces/l_mass");} }

        /// <summary>
        ///  The pitch moment due to asymmetric loading - positive = pitch up.
        /// </summary>
        public IXPDataRef<float> M_mass { get { return m_data.GetFloat("sim/flightmodel/forces/m_mass");} }

        /// <summary>
        ///  The yaw moment due to asymmetric loading - positive = yaw right/Clockwise.
        /// </summary>
        public IXPDataRef<float> N_mass { get { return m_data.GetFloat("sim/flightmodel/forces/n_mass");} }

        /// <summary>
        ///  The roll moment total.  Override with override_force - positive = right roll.
        /// </summary>
        public IXPDataRef<float> L_total { get { return m_data.GetFloat("sim/flightmodel/forces/l_total");} }

        /// <summary>
        ///  The pitch moment total.  Override with override_force - positive = pitch up.
        /// </summary>
        public IXPDataRef<float> M_total { get { return m_data.GetFloat("sim/flightmodel/forces/m_total");} }

        /// <summary>
        ///  The yaw moment total.  Override with override_forces - positive = yaw right/Clockwise.
        /// </summary>
        public IXPDataRef<float> N_total { get { return m_data.GetFloat("sim/flightmodel/forces/n_total");} }

        /// <summary>
        ///  Extra plugin-provided sideways force (ACF X axis, positive pushes airplane to the right). ADD to this dataref to apply extra force.
        /// </summary>
        public IXPDataRef<float> Fside_plug_acf { get { return m_data.GetFloat("sim/flightmodel/forces/fside_plug_acf");} }

        /// <summary>
        ///  Extra plugin-provided upward force (ACF Y axis, positive pushes airplane up). ADD to this dataref to apply extra force.
        /// </summary>
        public IXPDataRef<float> Fnrml_plug_acf { get { return m_data.GetFloat("sim/flightmodel/forces/fnrml_plug_acf");} }

        /// <summary>
        ///  Extra plugin-provided forward force.  (ACF Z axis, positive pushes airplane backward). ADD to this dataref to apply extra force.
        /// </summary>
        public IXPDataRef<float> Faxil_plug_acf { get { return m_data.GetFloat("sim/flightmodel/forces/faxil_plug_acf");} }

        /// <summary>
        ///  Extra plugin-provided roll moment - ADD to this dataref to apply extra force - positive = right roll.
        /// </summary>
        public IXPDataRef<float> L_plug_acf { get { return m_data.GetFloat("sim/flightmodel/forces/l_plug_acf");} }

        /// <summary>
        ///  Extra plugin-provided pitch moment - ADD to this dataref to apply extra force - positive = pitch up.
        /// </summary>
        public IXPDataRef<float> M_plug_acf { get { return m_data.GetFloat("sim/flightmodel/forces/m_plug_acf");} }

        /// <summary>
        ///  Extra plugin-provided yaw moment - ADD to this dataref to apply extra force - positive = yaw right/Clockwise.
        /// </summary>
        public IXPDataRef<float> N_plug_acf { get { return m_data.GetFloat("sim/flightmodel/forces/n_plug_acf");} }

        /// <summary>
        ///  Total g-forces on the plane as a multiple, downward
        /// </summary>
        public IXPDataRef<float> G_nrml { get { return m_data.GetFloat("sim/flightmodel/forces/g_nrml");} }

        /// <summary>
        ///  Total g-forces on the plane as a multiple, along the plane
        /// </summary>
        public IXPDataRef<float> G_axil { get { return m_data.GetFloat("sim/flightmodel/forces/g_axil");} }

        /// <summary>
        ///  Total g-forces on the plane as a multiple, sideways
        /// </summary>
        public IXPDataRef<float> G_side { get { return m_data.GetFloat("sim/flightmodel/forces/g_side");} }

        /// <summary>
        ///  Velocity of air relative to airplane
        /// </summary>
        public IXPDataRef<float> Vx_air_on_acf { get { return m_data.GetFloat("sim/flightmodel/forces/vx_air_on_acf");} }

        /// <summary>
        ///  Velocity of air relative to airplane
        /// </summary>
        public IXPDataRef<float> Vy_air_on_acf { get { return m_data.GetFloat("sim/flightmodel/forces/vy_air_on_acf");} }

        /// <summary>
        ///  Velocity of air relative to airplane
        /// </summary>
        public IXPDataRef<float> Vz_air_on_acf { get { return m_data.GetFloat("sim/flightmodel/forces/vz_air_on_acf");} }

        /// <summary>
        ///  Velocity of aircraft in its own coordinate system
        /// </summary>
        public IXPDataRef<float> Vx_acf_axis { get { return m_data.GetFloat("sim/flightmodel/forces/vx_acf_axis");} }

        /// <summary>
        ///  Velocity of aircraft in its own coordinate system
        /// </summary>
        public IXPDataRef<float> Vy_acf_axis { get { return m_data.GetFloat("sim/flightmodel/forces/vy_acf_axis");} }

        /// <summary>
        ///  Velocity of aircraft in its own coordinate system
        /// </summary>
        public IXPDataRef<float> Vz_acf_axis { get { return m_data.GetFloat("sim/flightmodel/forces/vz_acf_axis");} }
    }
}