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
        ///  The latitude of the point 0,0,0 in OpenGL coordinates (Writing NOT recommended!!). Units:degrees
        /// </summary>
        public IXPDataRef<float> Lat_ref => m_data.GetFloat("sim/flightmodel/position/lat_ref");

        /// <summary>
        ///  The longitude of the point 0,0,0 in OpenGL coordinates.. Units:degrees
        /// </summary>
        public IXPDataRef<float> Lon_ref => m_data.GetFloat("sim/flightmodel/position/lon_ref");

        /// <summary>
        ///  The pitch relative to the plane normal to the Y axis in degrees - OpenGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Theta => m_data.GetFloat("sim/flightmodel/position/theta");

        /// <summary>
        ///  The roll of the aircraft in degrees - OpenGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Phi => m_data.GetFloat("sim/flightmodel/position/phi");

        /// <summary>
        ///  The true heading of the aircraft in degrees from the Z axis - OpenGL coordinates. Units:degrees
        /// </summary>
        public IXPDataRef<float> Psi => m_data.GetFloat("sim/flightmodel/position/psi");

        /// <summary>
        ///  DO NOT USE THIS. Units:degrees
        /// </summary>
        public IXPDataRef<float> Magpsi => m_data.GetFloat("sim/flightmodel/position/magpsi");

        /// <summary>
        ///  The pitch of the aircraft relative to the earth precisely below the aircraft. Units:degrees
        /// </summary>
        public IXPDataRef<float> True_theta => m_data.GetFloat("sim/flightmodel/position/true_theta");

        /// <summary>
        ///  The roll of the aircraft relative to the earth precisely below the aircraft. Units:degrees
        /// </summary>
        public IXPDataRef<float> True_phi => m_data.GetFloat("sim/flightmodel/position/true_phi");

        /// <summary>
        ///  The heading of the aircraft relative to the earth precisely below the aircraft - true degrees north, always. Units:degrees
        /// </summary>
        public IXPDataRef<float> True_psi => m_data.GetFloat("sim/flightmodel/position/true_psi");

        /// <summary>
        ///  The real magnetic heading of the aircraft - the old magpsi dataref was FUBAR. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mag_psi => m_data.GetFloat("sim/flightmodel/position/mag_psi");

        /// <summary>
        ///  The velocity in local OGL coordinates. Units:mtr/Sec
        /// </summary>
        public IXPDataRef<float> Local_vx => m_data.GetFloat("sim/flightmodel/position/local_vx");

        /// <summary>
        ///  The velocity in local OGL coordinates. Units:mtr/Sec
        /// </summary>
        public IXPDataRef<float> Local_vy => m_data.GetFloat("sim/flightmodel/position/local_vy");

        /// <summary>
        ///  The velocity in local OGL coordinates. Units:mtr/Sec
        /// </summary>
        public IXPDataRef<float> Local_vz => m_data.GetFloat("sim/flightmodel/position/local_vz");

        /// <summary>
        ///  The acceleration in local OGL coordinates. Units:mtr/Sec2
        /// </summary>
        public IXPDataRef<float> Local_ax => m_data.GetFloat("sim/flightmodel/position/local_ax");

        /// <summary>
        ///  The acceleration in local OGL coordinates. Units:mtr/Sec2
        /// </summary>
        public IXPDataRef<float> Local_ay => m_data.GetFloat("sim/flightmodel/position/local_ay");

        /// <summary>
        ///  The acceleration in local OGL coordinates. Units:mtr/Sec2
        /// </summary>
        public IXPDataRef<float> Local_az => m_data.GetFloat("sim/flightmodel/position/local_az");

        /// <summary>
        ///  The pitch relative to the flown path (angle of attack). Units:degrees
        /// </summary>
        public IXPDataRef<float> Alpha => m_data.GetFloat("sim/flightmodel/position/alpha");

        /// <summary>
        ///  The heading relative to the flown path (yaw). Units:degrees
        /// </summary>
        public IXPDataRef<float> Beta => m_data.GetFloat("sim/flightmodel/position/beta");

        /// <summary>
        ///  The pitch the aircraft actually flies.  (vpath+alpha=theta). Units:degrees
        /// </summary>
        public IXPDataRef<float> Vpath => m_data.GetFloat("sim/flightmodel/position/vpath");

        /// <summary>
        ///  The heading the aircraft actually flies.  (hpath+beta=psi). Units:degrees
        /// </summary>
        public IXPDataRef<float> Hpath => m_data.GetFloat("sim/flightmodel/position/hpath");

        /// <summary>
        ///  The ground speed of the aircraft. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float> Groundspeed => m_data.GetFloat("sim/flightmodel/position/groundspeed");

        /// <summary>
        ///  Air speed indicated - this takes into account air density and wind direction. Units:kias
        /// </summary>
        public IXPDataRef<float> Indicated_airspeed => m_data.GetFloat("sim/flightmodel/position/indicated_airspeed");

        /// <summary>
        ///  Air speed indicated - this takes into account air density and wind direction. Units:kias
        /// </summary>
        public IXPDataRef<float> Indicated_airspeed2 => m_data.GetFloat("sim/flightmodel/position/indicated_airspeed2");

        /// <summary>
        ///  Air speed true - this does not take into account air density at altitude!. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float> True_airspeed => m_data.GetFloat("sim/flightmodel/position/true_airspeed");

        /// <summary>
        ///  The local magnetic variation. Units:degrees
        /// </summary>
        public IXPDataRef<float> Magnetic_variation => m_data.GetFloat("sim/flightmodel/position/magnetic_variation");

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis).. Units:NM
        /// </summary>
        public IXPDataRef<float> M => m_data.GetFloat("sim/flightmodel/position/m");

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis). Units:NM
        /// </summary>
        public IXPDataRef<float> N => m_data.GetFloat("sim/flightmodel/position/n");

        /// <summary>
        ///  The angular momentum of the aircraft (relative to flight axis). Units:NM
        /// </summary>
        public IXPDataRef<float> L => m_data.GetFloat("sim/flightmodel/position/l");

        /// <summary>
        ///  The roll rotation rates (relative to the flight). Units:deg/Sec
        /// </summary>
        public IXPDataRef<float> P => m_data.GetFloat("sim/flightmodel/position/p");

        /// <summary>
        ///  The pitch rotation rates (relative to the flight). Units:deg/Sec
        /// </summary>
        public IXPDataRef<float> Q => m_data.GetFloat("sim/flightmodel/position/q");

        /// <summary>
        ///  The yaw rotation rates (relative to the flight). Units:deg/Sec
        /// </summary>
        public IXPDataRef<float> R => m_data.GetFloat("sim/flightmodel/position/r");

        /// <summary>
        ///  The roll angular acceleration (relative to the flight). Units:deg/Sec2
        /// </summary>
        public IXPDataRef<float> P_dot => m_data.GetFloat("sim/flightmodel/position/p_dot");

        /// <summary>
        ///  The pitch angular acceleration (relative to the flight). Units:deg/Sec2
        /// </summary>
        public IXPDataRef<float> Q_dot => m_data.GetFloat("sim/flightmodel/position/q_dot");

        /// <summary>
        ///  The yaw angular acceleration rates (relative to the flight). Units:deg/Sec2
        /// </summary>
        public IXPDataRef<float> R_dot => m_data.GetFloat("sim/flightmodel/position/r_dot");

        /// <summary>
        ///  The roll rotation rates (relative to the flight). Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Prad => m_data.GetFloat("sim/flightmodel/position/prad");

        /// <summary>
        ///  The pitch rotation rates (relative to the flight). Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Qrad => m_data.GetFloat("sim/flightmodel/position/qrad");

        /// <summary>
        ///  The yaw rotation rates (relative to the flight). Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Rrad => m_data.GetFloat("sim/flightmodel/position/rrad");

        /// <summary>
        ///  A quaternion representing the rotation from local OpenGL coordinates to the aircraft's coordinates.. Units:quaternion
        /// </summary>
        public IXPDataRef<float[]> Q => m_data.GetFloatArray("sim/flightmodel/position/q");

        /// <summary>
        ///  VVI (vertical velocity in meters per second). Units:meters/Second
        /// </summary>
        public IXPDataRef<float> Vh_ind => m_data.GetFloat("sim/flightmodel/position/vh_ind");

        /// <summary>
        ///  VVI (vertical velocity in feet per second). Units:fpm
        /// </summary>
        public IXPDataRef<float> Vh_ind_fpm => m_data.GetFloat("sim/flightmodel/position/vh_ind_fpm");

        /// <summary>
        ///  VVI (vertical velocity in feet per second). Units:fpm
        /// </summary>
        public IXPDataRef<float> Vh_ind_fpm2 => m_data.GetFloat("sim/flightmodel/position/vh_ind_fpm2");

        /// <summary>
        ///  . Units:meters
        /// </summary>
        public IXPDataRef<float> Y_agl => m_data.GetFloat("sim/flightmodel/position/y_agl");
    }
}