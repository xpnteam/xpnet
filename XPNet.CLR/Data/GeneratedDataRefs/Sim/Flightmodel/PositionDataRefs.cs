using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_positionDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_positionDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  The location of the plane in OpenGL coordinates. Units:meters
        ///  Raw path: sim/flightmodel/position/local_x
        /// </summary>
        public IXPDataRef<double> local_x { get { return m_data.GetDouble("sim/flightmodel/position/local_x");} }

        /// <summary>
        ///  The location of the plane in OpenGL coordinates. Units:meters
        ///  Raw path: sim/flightmodel/position/local_y
        /// </summary>
        public IXPDataRef<double> local_y { get { return m_data.GetDouble("sim/flightmodel/position/local_y");} }

        /// <summary>
        ///  The location of the plane in OpenGL coordinates. Units:meters
        ///  Raw path: sim/flightmodel/position/local_z
        /// </summary>
        public IXPDataRef<double> local_z { get { return m_data.GetDouble("sim/flightmodel/position/local_z");} }

        /// <summary>
        ///  The latitude of the point 0,0,0 in OpenGL coordinates (Writing NOT recommended!!). Units:degrees
        ///  Raw path: sim/flightmodel/position/lat_ref
        /// </summary>
        public IXPDataRef<float> lat_ref { get { return m_data.GetFloat("sim/flightmodel/position/lat_ref");} }

        /// <summary>
        ///  The longitude of the point 0,0,0 in OpenGL coordinates.. Units:degrees
        ///  Raw path: sim/flightmodel/position/lon_ref
        /// </summary>
        public IXPDataRef<float> lon_ref { get { return m_data.GetFloat("sim/flightmodel/position/lon_ref");} }

        /// <summary>
        ///  The latitude of the aircraft. Units:degrees
        ///  Raw path: sim/flightmodel/position/latitude
        /// </summary>
        public IXPDataRef<double> latitude { get { return m_data.GetDouble("sim/flightmodel/position/latitude");} }

        /// <summary>
        ///  The longitude of the aircraft. Units:degrees
        ///  Raw path: sim/flightmodel/position/longitude
        /// </summary>
        public IXPDataRef<double> longitude { get { return m_data.GetDouble("sim/flightmodel/position/longitude");} }

        /// <summary>
        ///  The elevation above MSL of the aircraft. Units:meters
        ///  Raw path: sim/flightmodel/position/elevation
        /// </summary>
        public IXPDataRef<double> elevation { get { return m_data.GetDouble("sim/flightmodel/position/elevation");} }

        /// <summary>
        ///  The pitch relative to the plane normal to the Y axis in degrees - OpenGL coordinates. Units:degrees
        ///  Raw path: sim/flightmodel/position/theta
        /// </summary>
        public IXPDataRef<float> theta { get { return m_data.GetFloat("sim/flightmodel/position/theta");} }

        /// <summary>
        ///  The roll of the aircraft in degrees - OpenGL coordinates. Units:degrees
        ///  Raw path: sim/flightmodel/position/phi
        /// </summary>
        public IXPDataRef<float> phi { get { return m_data.GetFloat("sim/flightmodel/position/phi");} }

        /// <summary>
        ///  The true heading of the aircraft in degrees from the Z axis - OpenGL coordinates. Units:degrees
        ///  Raw path: sim/flightmodel/position/psi
        /// </summary>
        public IXPDataRef<float> psi { get { return m_data.GetFloat("sim/flightmodel/position/psi");} }

        /// <summary>
        ///  DO NOT USE THIS. Units:degrees
        ///  Raw path: sim/flightmodel/position/magpsi
        /// </summary>
        public IXPDataRef<float> magpsi { get { return m_data.GetFloat("sim/flightmodel/position/magpsi");} }

        /// <summary>
        ///  The pitch of the aircraft relative to the earth precisely below the aircraft. Units:degrees
        ///  Raw path: sim/flightmodel/position/true_theta
        /// </summary>
        public IXPDataRef<float> true_theta { get { return m_data.GetFloat("sim/flightmodel/position/true_theta");} }

        /// <summary>
        ///  The roll of the aircraft relative to the earth precisely below the aircraft. Units:degrees
        ///  Raw path: sim/flightmodel/position/true_phi
        /// </summary>
        public IXPDataRef<float> true_phi { get { return m_data.GetFloat("sim/flightmodel/position/true_phi");} }

        /// <summary>
        ///  The heading of the aircraft relative to the earth precisely below the aircraft - true degrees north, always. Units:degrees
        ///  Raw path: sim/flightmodel/position/true_psi
        /// </summary>
        public IXPDataRef<float> true_psi { get { return m_data.GetFloat("sim/flightmodel/position/true_psi");} }

        /// <summary>
        ///  The real magnetic heading of the aircraft - the old magpsi dataref was FUBAR. Units:degrees
        ///  Raw path: sim/flightmodel/position/mag_psi
        /// </summary>
        public IXPDataRef<float> mag_psi { get { return m_data.GetFloat("sim/flightmodel/position/mag_psi");} }

        /// <summary>
        ///  The velocity in local OGL coordinates. Units:mtr/sec
        ///  Raw path: sim/flightmodel/position/local_vx
        /// </summary>
        public IXPDataRef<float> local_vx { get { return m_data.GetFloat("sim/flightmodel/position/local_vx");} }

        /// <summary>
        ///  The velocity in local OGL coordinates. Units:mtr/sec
        ///  Raw path: sim/flightmodel/position/local_vy
        /// </summary>
        public IXPDataRef<float> local_vy { get { return m_data.GetFloat("sim/flightmodel/position/local_vy");} }

        /// <summary>
        ///  The velocity in local OGL coordinates. Units:mtr/sec
        ///  Raw path: sim/flightmodel/position/local_vz
        /// </summary>
        public IXPDataRef<float> local_vz { get { return m_data.GetFloat("sim/flightmodel/position/local_vz");} }

        /// <summary>
        ///  The acceleration in local OGL coordinates. Units:mtr/sec2
        ///  Raw path: sim/flightmodel/position/local_ax
        /// </summary>
        public IXPDataRef<float> local_ax { get { return m_data.GetFloat("sim/flightmodel/position/local_ax");} }

        /// <summary>
        ///  The acceleration in local OGL coordinates. Units:mtr/sec2
        ///  Raw path: sim/flightmodel/position/local_ay
        /// </summary>
        public IXPDataRef<float> local_ay { get { return m_data.GetFloat("sim/flightmodel/position/local_ay");} }

        /// <summary>
        ///  The acceleration in local OGL coordinates. Units:mtr/sec2
        ///  Raw path: sim/flightmodel/position/local_az
        /// </summary>
        public IXPDataRef<float> local_az { get { return m_data.GetFloat("sim/flightmodel/position/local_az");} }

        /// <summary>
        ///  The pitch relative to the flown path (angle of attack). Units:degrees
        ///  Raw path: sim/flightmodel/position/alpha
        /// </summary>
        public IXPDataRef<float> alpha { get { return m_data.GetFloat("sim/flightmodel/position/alpha");} }

        /// <summary>
        ///  The heading relative to the flown path (yaw). Units:degrees
        ///  Raw path: sim/flightmodel/position/beta
        /// </summary>
        public IXPDataRef<float> beta { get { return m_data.GetFloat("sim/flightmodel/position/beta");} }

        /// <summary>
        ///  The pitch the aircraft actually flies.  (vpath+alpha=theta). Units:degrees
        ///  Raw path: sim/flightmodel/position/vpath
        /// </summary>
        public IXPDataRef<float> vpath { get { return m_data.GetFloat("sim/flightmodel/position/vpath");} }

        /// <summary>
        ///  The heading the aircraft actually flies.  (hpath+beta=psi). Units:degrees
        ///  Raw path: sim/flightmodel/position/hpath
        /// </summary>
        public IXPDataRef<float> hpath { get { return m_data.GetFloat("sim/flightmodel/position/hpath");} }

        /// <summary>
        ///  The ground speed of the aircraft. Units:meters/sec
        ///  Raw path: sim/flightmodel/position/groundspeed
        /// </summary>
        public IXPDataRef<float> groundspeed { get { return m_data.GetFloat("sim/flightmodel/position/groundspeed");} }

        /// <summary>
        ///  Air speed indicated - this takes into account air density and wind direction. Units:kias
        ///  Raw path: sim/flightmodel/position/indicated_airspeed
        /// </summary>
        public IXPDataRef<float> indicated_airspeed { get { return m_data.GetFloat("sim/flightmodel/position/indicated_airspeed");} }

        /// <summary>
        ///  Air speed indicated - this takes into account air density and wind direction. Units:kias
        ///  Raw path: sim/flightmodel/position/indicated_airspeed2
        /// </summary>
        public IXPDataRef<float> indicated_airspeed2 { get { return m_data.GetFloat("sim/flightmodel/position/indicated_airspeed2");} }

        /// <summary>
        ///  Air speed true - this does not take into account air density at altitude!. Units:meters/sec
        ///  Raw path: sim/flightmodel/position/true_airspeed
        /// </summary>
        public IXPDataRef<float> true_airspeed { get { return m_data.GetFloat("sim/flightmodel/position/true_airspeed");} }

        /// <summary>
        ///  The local magnetic variation. Units:degrees
        ///  Raw path: sim/flightmodel/position/magnetic_variation
        /// </summary>
        public IXPDataRef<float> magnetic_variation { get { return m_data.GetFloat("sim/flightmodel/position/magnetic_variation");} }

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis).. Units:NM
        ///  Raw path: sim/flightmodel/position/M
        /// </summary>
        public IXPDataRef<float> M { get { return m_data.GetFloat("sim/flightmodel/position/m");} }

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis). Units:NM
        ///  Raw path: sim/flightmodel/position/N
        /// </summary>
        public IXPDataRef<float> N { get { return m_data.GetFloat("sim/flightmodel/position/n");} }

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis). Units:NM
        ///  Raw path: sim/flightmodel/position/L
        /// </summary>
        public IXPDataRef<float> L { get { return m_data.GetFloat("sim/flightmodel/position/l");} }

        /// <summary>
        ///  The roll rotation rates (relative to the flight). Units:deg/sec
        ///  Raw path: sim/flightmodel/position/P
        /// </summary>
        public IXPDataRef<float> P { get { return m_data.GetFloat("sim/flightmodel/position/p");} }

        /// <summary>
        ///  The pitch rotation rates (relative to the flight). Units:deg/sec
        ///  Raw path: sim/flightmodel/position/Q
        /// </summary>
        public IXPDataRef<float> Q { get { return m_data.GetFloat("sim/flightmodel/position/q");} }

        /// <summary>
        ///  The yaw rotation rates (relative to the flight). Units:deg/sec
        ///  Raw path: sim/flightmodel/position/R
        /// </summary>
        public IXPDataRef<float> R { get { return m_data.GetFloat("sim/flightmodel/position/r");} }

        /// <summary>
        ///  The roll angular acceleration (relative to the flight). Units:deg/sec2
        ///  Raw path: sim/flightmodel/position/P_dot
        /// </summary>
        public IXPDataRef<float> P_dot { get { return m_data.GetFloat("sim/flightmodel/position/p_dot");} }

        /// <summary>
        ///  The pitch angular acceleration (relative to the flight). Units:deg/sec2
        ///  Raw path: sim/flightmodel/position/Q_dot
        /// </summary>
        public IXPDataRef<float> Q_dot { get { return m_data.GetFloat("sim/flightmodel/position/q_dot");} }

        /// <summary>
        ///  The yaw angular acceleration rates (relative to the flight). Units:deg/sec2
        ///  Raw path: sim/flightmodel/position/R_dot
        /// </summary>
        public IXPDataRef<float> R_dot { get { return m_data.GetFloat("sim/flightmodel/position/r_dot");} }

        /// <summary>
        ///  The roll rotation rates (relative to the flight). Units:rad/sec
        ///  Raw path: sim/flightmodel/position/Prad
        /// </summary>
        public IXPDataRef<float> Prad { get { return m_data.GetFloat("sim/flightmodel/position/prad");} }

        /// <summary>
        ///  The pitch rotation rates (relative to the flight). Units:rad/sec
        ///  Raw path: sim/flightmodel/position/Qrad
        /// </summary>
        public IXPDataRef<float> Qrad { get { return m_data.GetFloat("sim/flightmodel/position/qrad");} }

        /// <summary>
        ///  The yaw rotation rates (relative to the flight). Units:rad/sec
        ///  Raw path: sim/flightmodel/position/Rrad
        /// </summary>
        public IXPDataRef<float> Rrad { get { return m_data.GetFloat("sim/flightmodel/position/rrad");} }

        /// <summary>
        ///  A quaternion representing the rotation from local OpenGL coordinates to the aircraft's coordinates.. Units:quaternion
        ///  Raw path: sim/flightmodel/position/q
        /// </summary>
        public IXPDataRef<float[]> q { get { return m_data.GetFloatArray("sim/flightmodel/position/q");} }

        /// <summary>
        ///  VVI (vertical velocity in meters per second). Units:meters/second
        ///  Raw path: sim/flightmodel/position/vh_ind
        /// </summary>
        public IXPDataRef<float> vh_ind { get { return m_data.GetFloat("sim/flightmodel/position/vh_ind");} }

        /// <summary>
        ///  VVI (vertical velocity in feet per second). Units:fpm
        ///  Raw path: sim/flightmodel/position/vh_ind_fpm
        /// </summary>
        public IXPDataRef<float> vh_ind_fpm { get { return m_data.GetFloat("sim/flightmodel/position/vh_ind_fpm");} }

        /// <summary>
        ///  VVI (vertical velocity in feet per second). Units:fpm
        ///  Raw path: sim/flightmodel/position/vh_ind_fpm2
        /// </summary>
        public IXPDataRef<float> vh_ind_fpm2 { get { return m_data.GetFloat("sim/flightmodel/position/vh_ind_fpm2");} }

        /// <summary>
        ///  . Units:meters
        ///  Raw path: sim/flightmodel/position/y_agl
        /// </summary>
        public IXPDataRef<float> y_agl { get { return m_data.GetFloat("sim/flightmodel/position/y_agl");} }
    }
}