using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel2_MiscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel2_MiscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Canopy position: 0 = closed, 1 = open. Units:ratio
        /// </summary>
        public IXPDataRef<float> Canopy_open_ratio => m_data.GetFloat("sim/flightmodel2/misc/canopy_open_ratio");

        /// <summary>
        ///  How open is the door, 0 = closed, 1 = open. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Door_open_ratio => m_data.GetFloatArray("sim/flightmodel2/misc/door_open_ratio");

        /// <summary>
        ///  Tailhook position: 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float> Tailhook_deploy_ratio => m_data.GetFloat("sim/flightmodel2/misc/tailhook_deploy_ratio");

        /// <summary>
        ///  Water scoop position: 0 = up, 1 = down. Units:ratio
        /// </summary>
        public IXPDataRef<float> Water_scoop_deploy_ratio => m_data.GetFloat("sim/flightmodel2/misc/water_scoop_deploy_ratio");

        /// <summary>
        ///  Water drop door position: 0 = up, 1=  down. Units:ratio
        /// </summary>
        public IXPDataRef<float> Water_drop_deploy_ratio => m_data.GetFloat("sim/flightmodel2/misc/water_drop_deploy_ratio");

        /// <summary>
        ///  current angle of the wiper.  range of motion is set in PlaneMaker.. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Wiper_angle_deg => m_data.GetFloatArray("sim/flightmodel2/misc/wiper_angle_deg");

        /// <summary>
        ///  Misc. traveling items for your use.  You define the meaning.. Units:ratio
        /// </summary>
        public IXPDataRef<float[]> Custom_slider_ratio => m_data.GetFloatArray("sim/flightmodel2/misc/custom_slider_ratio");

        /// <summary>
        ///  How far is the pressure-outflow valve open?  0=closed, 1=open. Units:ratio
        /// </summary>
        public IXPDataRef<float> Pressure_outflow_ratio => m_data.GetFloat("sim/flightmodel2/misc/pressure_outflow_ratio");

        /// <summary>
        ///  Angle of attack probe.  Positive means aircracft nose is above the flight path in aircraft coordinates.. Units:degrees
        /// </summary>
        public IXPDataRef<float> AoA_angle_degrees => m_data.GetFloat("sim/flightmodel2/misc/aoa_angle_degrees");

        /// <summary>
        ///  . Units:degrees
        /// </summary>
        public IXPDataRef<float> Yaw_string_angle => m_data.GetFloat("sim/flightmodel2/misc/yaw_string_angle");

        /// <summary>
        ///  . Units:kias
        /// </summary>
        public IXPDataRef<float> Yaw_string_airspeed => m_data.GetFloat("sim/flightmodel2/misc/yaw_string_airspeed");

        /// <summary>
        ///  . Units:todo
        /// </summary>
        public IXPDataRef<float> Gforce_normal => m_data.GetFloat("sim/flightmodel2/misc/gforce_normal");

        /// <summary>
        ///  . Units:todo
        /// </summary>
        public IXPDataRef<float> Gforce_axil => m_data.GetFloat("sim/flightmodel2/misc/gforce_axil");

        /// <summary>
        ///  . Units:todo
        /// </summary>
        public IXPDataRef<float> Gforce_side => m_data.GetFloat("sim/flightmodel2/misc/gforce_side");

        /// <summary>
        ///  lateral offset in meters from default for this bouncer. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Bouncer_x => m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_x");

        /// <summary>
        ///  vertical offset in meters from default for this bouncer. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Bouncer_y => m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_y");

        /// <summary>
        ///  longitudinal offset in meters from default for this bouncer. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Bouncer_z => m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_z");

        /// <summary>
        ///  lateral offset in meters from default for this bouncer. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Bouncer_vx => m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_vx");

        /// <summary>
        ///  vertical offset in meters from default for this bouncer. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Bouncer_vy => m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_vy");

        /// <summary>
        ///  longitudinal offset in meters from default for this bouncer. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Bouncer_vz => m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_vz");
    }
}