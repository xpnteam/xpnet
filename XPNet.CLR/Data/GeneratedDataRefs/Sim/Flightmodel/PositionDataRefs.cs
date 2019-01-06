using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_PositionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_PositionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The latitude of the point 0,0,0 in OpenGL coordinates (Writing NOT recommended!!)
        /// </summary>
        public IXPDataRef<float> Lat_ref { get { return m_data.GetFloat("sim/flightmodel/position/lat_ref");} }

        /// <summary>
        ///  The longitude of the point 0,0,0 in OpenGL coordinates.
        /// </summary>
        public IXPDataRef<float> Lon_ref { get { return m_data.GetFloat("sim/flightmodel/position/lon_ref");} }

        /// <summary>
        ///  The pitch relative to the plane normal to the Y axis in degrees - OpenGL coordinates
        /// </summary>
        public IXPDataRef<float> Theta { get { return m_data.GetFloat("sim/flightmodel/position/theta");} }

        /// <summary>
        ///  The roll of the aircraft in degrees - OpenGL coordinates
        /// </summary>
        public IXPDataRef<float> Phi { get { return m_data.GetFloat("sim/flightmodel/position/phi");} }

        /// <summary>
        ///  The true heading of the aircraft in degrees from the Z axis - OpenGL coordinates
        /// </summary>
        public IXPDataRef<float> Psi { get { return m_data.GetFloat("sim/flightmodel/position/psi");} }

        /// <summary>
        ///  DO NOT USE THIS
        /// </summary>
        public IXPDataRef<float> Magpsi { get { return m_data.GetFloat("sim/flightmodel/position/magpsi");} }

        /// <summary>
        ///  The pitch of the aircraft relative to the earth precisely below the aircraft
        /// </summary>
        public IXPDataRef<float> True_theta { get { return m_data.GetFloat("sim/flightmodel/position/true_theta");} }

        /// <summary>
        ///  The roll of the aircraft relative to the earth precisely below the aircraft
        /// </summary>
        public IXPDataRef<float> True_phi { get { return m_data.GetFloat("sim/flightmodel/position/true_phi");} }

        /// <summary>
        ///  The heading of the aircraft relative to the earth precisely below the aircraft - true degrees north, always
        /// </summary>
        public IXPDataRef<float> True_psi { get { return m_data.GetFloat("sim/flightmodel/position/true_psi");} }

        /// <summary>
        ///  The real magnetic heading of the aircraft - the old magpsi dataref was FUBAR
        /// </summary>
        public IXPDataRef<float> Mag_psi { get { return m_data.GetFloat("sim/flightmodel/position/mag_psi");} }

        /// <summary>
        ///  The velocity in local OGL coordinates
        /// </summary>
        public IXPDataRef<float> Local_vx { get { return m_data.GetFloat("sim/flightmodel/position/local_vx");} }

        /// <summary>
        ///  The velocity in local OGL coordinates
        /// </summary>
        public IXPDataRef<float> Local_vy { get { return m_data.GetFloat("sim/flightmodel/position/local_vy");} }

        /// <summary>
        ///  The velocity in local OGL coordinates
        /// </summary>
        public IXPDataRef<float> Local_vz { get { return m_data.GetFloat("sim/flightmodel/position/local_vz");} }

        /// <summary>
        ///  The acceleration in local OGL coordinates
        /// </summary>
        public IXPDataRef<float> Local_ax { get { return m_data.GetFloat("sim/flightmodel/position/local_ax");} }

        /// <summary>
        ///  The acceleration in local OGL coordinates
        /// </summary>
        public IXPDataRef<float> Local_ay { get { return m_data.GetFloat("sim/flightmodel/position/local_ay");} }

        /// <summary>
        ///  The acceleration in local OGL coordinates
        /// </summary>
        public IXPDataRef<float> Local_az { get { return m_data.GetFloat("sim/flightmodel/position/local_az");} }

        /// <summary>
        ///  The pitch relative to the flown path (angle of attack)
        /// </summary>
        public IXPDataRef<float> Alpha { get { return m_data.GetFloat("sim/flightmodel/position/alpha");} }

        /// <summary>
        ///  The heading relative to the flown path (yaw)
        /// </summary>
        public IXPDataRef<float> Beta { get { return m_data.GetFloat("sim/flightmodel/position/beta");} }

        /// <summary>
        ///  The pitch the aircraft actually flies.  (vpath+alpha=theta)
        /// </summary>
        public IXPDataRef<float> Vpath { get { return m_data.GetFloat("sim/flightmodel/position/vpath");} }

        /// <summary>
        ///  The heading the aircraft actually flies.  (hpath+beta=psi)
        /// </summary>
        public IXPDataRef<float> Hpath { get { return m_data.GetFloat("sim/flightmodel/position/hpath");} }

        /// <summary>
        ///  The ground speed of the aircraft
        /// </summary>
        public IXPDataRef<float> Groundspeed { get { return m_data.GetFloat("sim/flightmodel/position/groundspeed");} }

        /// <summary>
        ///  Air speed indicated - this takes into account air density and wind direction
        /// </summary>
        public IXPDataRef<float> Indicated_airspeed { get { return m_data.GetFloat("sim/flightmodel/position/indicated_airspeed");} }

        /// <summary>
        ///  Air speed indicated - this takes into account air density and wind direction
        /// </summary>
        public IXPDataRef<float> Indicated_airspeed2 { get { return m_data.GetFloat("sim/flightmodel/position/indicated_airspeed2");} }

        /// <summary>
        ///  Air speed true - this does not take into account air density at altitude!
        /// </summary>
        public IXPDataRef<float> True_airspeed { get { return m_data.GetFloat("sim/flightmodel/position/true_airspeed");} }

        /// <summary>
        ///  The local magnetic variation
        /// </summary>
        public IXPDataRef<float> Magnetic_variation { get { return m_data.GetFloat("sim/flightmodel/position/magnetic_variation");} }

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis).
        /// </summary>
        public IXPDataRef<float> M { get { return m_data.GetFloat("sim/flightmodel/position/m");} }

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis)
        /// </summary>
        public IXPDataRef<float> N { get { return m_data.GetFloat("sim/flightmodel/position/n");} }

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis)
        /// </summary>
        public IXPDataRef<float> L { get { return m_data.GetFloat("sim/flightmodel/position/l");} }

        /// <summary>
        ///  The roll rotation rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> P { get { return m_data.GetFloat("sim/flightmodel/position/p");} }

        /// <summary>
        ///  The pitch rotation rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> Q { get { return m_data.GetFloat("sim/flightmodel/position/q");} }

        /// <summary>
        ///  The yaw rotation rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> R { get { return m_data.GetFloat("sim/flightmodel/position/r");} }

        /// <summary>
        ///  The roll angular acceleration (relative to the flight)
        /// </summary>
        public IXPDataRef<float> P_dot { get { return m_data.GetFloat("sim/flightmodel/position/p_dot");} }

        /// <summary>
        ///  The pitch angular acceleration (relative to the flight)
        /// </summary>
        public IXPDataRef<float> Q_dot { get { return m_data.GetFloat("sim/flightmodel/position/q_dot");} }

        /// <summary>
        ///  The yaw angular acceleration rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> R_dot { get { return m_data.GetFloat("sim/flightmodel/position/r_dot");} }

        /// <summary>
        ///  The roll rotation rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> Prad { get { return m_data.GetFloat("sim/flightmodel/position/prad");} }

        /// <summary>
        ///  The pitch rotation rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> Qrad { get { return m_data.GetFloat("sim/flightmodel/position/qrad");} }

        /// <summary>
        ///  The yaw rotation rates (relative to the flight)
        /// </summary>
        public IXPDataRef<float> Rrad { get { return m_data.GetFloat("sim/flightmodel/position/rrad");} }

        /// <summary>
        ///  A quaternion representing the rotation from local OpenGL coordinates to the aircraft's coordinates.
        /// </summary>
        public IXPDataRef<float[]> Q { get { return m_data.GetFloatArray("sim/flightmodel/position/q");} }

        /// <summary>
        ///  VVI (vertical velocity in meters per second)
        /// </summary>
        public IXPDataRef<float> Vh_ind { get { return m_data.GetFloat("sim/flightmodel/position/vh_ind");} }

        /// <summary>
        ///  VVI (vertical velocity in feet per second)
        /// </summary>
        public IXPDataRef<float> Vh_ind_fpm { get { return m_data.GetFloat("sim/flightmodel/position/vh_ind_fpm");} }

        /// <summary>
        ///  VVI (vertical velocity in feet per second)
        /// </summary>
        public IXPDataRef<float> Vh_ind_fpm2 { get { return m_data.GetFloat("sim/flightmodel/position/vh_ind_fpm2");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> Y_agl { get { return m_data.GetFloat("sim/flightmodel/position/y_agl");} }
    }
}