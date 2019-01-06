using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel2_miscDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel2_miscDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Canopy position: 0 = closed, 1 = open
        /// </summary>
        public IXPDataRef<float> canopy_open_ratio { get { return m_data.GetFloat("sim/flightmodel2/misc/canopy_open_ratio");} }

        /// <summary>
        ///  How open is the door, 0 = closed, 1 = open
        /// </summary>
        public IXPDataRef<float[]> door_open_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/misc/door_open_ratio");} }

        /// <summary>
        ///  Tailhook position: 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float> tailhook_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/misc/tailhook_deploy_ratio");} }

        /// <summary>
        ///  Water scoop position: 0 = up, 1 = down
        /// </summary>
        public IXPDataRef<float> water_scoop_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/misc/water_scoop_deploy_ratio");} }

        /// <summary>
        ///  Water drop door position: 0 = up, 1=  down
        /// </summary>
        public IXPDataRef<float> water_drop_deploy_ratio { get { return m_data.GetFloat("sim/flightmodel2/misc/water_drop_deploy_ratio");} }

        /// <summary>
        ///  current angle of the wiper.  range of motion is set in PlaneMaker.
        /// </summary>
        public IXPDataRef<float[]> wiper_angle_deg { get { return m_data.GetFloatArray("sim/flightmodel2/misc/wiper_angle_deg");} }

        /// <summary>
        ///  Misc. traveling items for your use.  You define the meaning.
        /// </summary>
        public IXPDataRef<float[]> custom_slider_ratio { get { return m_data.GetFloatArray("sim/flightmodel2/misc/custom_slider_ratio");} }

        /// <summary>
        ///  How far is the pressure-outflow valve open?  0=closed, 1=open
        /// </summary>
        public IXPDataRef<float> pressure_outflow_ratio { get { return m_data.GetFloat("sim/flightmodel2/misc/pressure_outflow_ratio");} }

        /// <summary>
        ///  Angle of attack probe.  Positive means aircracft nose is above the flight path in aircraft coordinates.
        /// </summary>
        public IXPDataRef<float> AoA_angle_degrees { get { return m_data.GetFloat("sim/flightmodel2/misc/aoa_angle_degrees");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> yaw_string_angle { get { return m_data.GetFloat("sim/flightmodel2/misc/yaw_string_angle");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> yaw_string_airspeed { get { return m_data.GetFloat("sim/flightmodel2/misc/yaw_string_airspeed");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> gforce_normal { get { return m_data.GetFloat("sim/flightmodel2/misc/gforce_normal");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> gforce_axil { get { return m_data.GetFloat("sim/flightmodel2/misc/gforce_axil");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float> gforce_side { get { return m_data.GetFloat("sim/flightmodel2/misc/gforce_side");} }

        /// <summary>
        ///  lateral offset in meters from default for this bouncer
        /// </summary>
        public IXPDataRef<float[]> bouncer_x { get { return m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_x");} }

        /// <summary>
        ///  vertical offset in meters from default for this bouncer
        /// </summary>
        public IXPDataRef<float[]> bouncer_y { get { return m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_y");} }

        /// <summary>
        ///  longitudinal offset in meters from default for this bouncer
        /// </summary>
        public IXPDataRef<float[]> bouncer_z { get { return m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_z");} }

        /// <summary>
        ///  lateral offset in meters from default for this bouncer
        /// </summary>
        public IXPDataRef<float[]> bouncer_vx { get { return m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_vx");} }

        /// <summary>
        ///  vertical offset in meters from default for this bouncer
        /// </summary>
        public IXPDataRef<float[]> bouncer_vy { get { return m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_vy");} }

        /// <summary>
        ///  longitudinal offset in meters from default for this bouncer
        /// </summary>
        public IXPDataRef<float[]> bouncer_vz { get { return m_data.GetFloatArray("sim/flightmodel2/misc/bouncer_vz");} }

        /// <summary>
        ///  True while the auto-start sequence is happening.  Plugins that override the auto-start sequence should set this to 1 during the sequence and clear it when done.
        /// </summary>
        public IXPDataRef<bool> auto_start_in_progress { get { return m_data.GetBool("sim/flightmodel2/misc/auto_start_in_progress");} }

        /// <summary>
        ///  True while the auto-board sequence is happening.  Plugins that override the auto-board sequence should set this to 1 during the sequence and clear it when done.
        /// </summary>
        public IXPDataRef<bool> auto_board_in_progress { get { return m_data.GetBool("sim/flightmodel2/misc/auto_board_in_progress");} }
    }
}