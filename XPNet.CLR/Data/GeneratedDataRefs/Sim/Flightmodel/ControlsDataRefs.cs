using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Flightmodel_ControlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Flightmodel_ControlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Actual speed brake deployment [0..1 = schedule for in-air, 1..1.5 = extra deployment when on ground]. Units:[0..1.5]
        /// </summary>
        public IXPDataRef<float> Sbrkrat => m_data.GetFloat("sim/flightmodel/controls/sbrkrat");

        /// <summary>
        ///  Requested flap deployment, 0 = off, 1 = max. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Flaprqst => m_data.GetFloat("sim/flightmodel/controls/flaprqst");

        /// <summary>
        ///  This is how locked the tail-wheel is ... 0 is free castoring, 1 is locked.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Tail_lock_rat => m_data.GetFloat("sim/flightmodel/controls/tail_lock_rat");

        /// <summary>
        ///  Current Aileron Trim, -1 = max left, 1 = max right. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Ail_trim => m_data.GetFloat("sim/flightmodel/controls/ail_trim");

        /// <summary>
        ///  Distance Traveled. Units:meters
        /// </summary>
        public IXPDataRef<float> Dist => m_data.GetFloat("sim/flightmodel/controls/dist");

        /// <summary>
        ///  Elevation Trim, -1 = max nose down, 1 = max nose up. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Elv_trim => m_data.GetFloat("sim/flightmodel/controls/elv_trim");

        /// <summary>
        ///  Actual flap 1 deployment ratio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Flaprat => m_data.GetFloat("sim/flightmodel/controls/flaprat");

        /// <summary>
        ///  Actual flap 2 deployment ratio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Flap2rat => m_data.GetFloat("sim/flightmodel/controls/flap2rat");

        /// <summary>
        ///  Left Brake - additional braking force (. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> L_brake_add => m_data.GetFloat("sim/flightmodel/controls/l_brake_add");

        /// <summary>
        ///  Right Brake. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> R_brake_add => m_data.GetFloat("sim/flightmodel/controls/r_brake_add");

        /// <summary>
        ///  Deflection Left Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Lail1def => m_data.GetFloat("sim/flightmodel/controls/lail1def");

        /// <summary>
        ///  Deflection Left Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Lail2def => m_data.GetFloat("sim/flightmodel/controls/lail2def");

        /// <summary>
        ///  Deflection Right Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Rail1def => m_data.GetFloat("sim/flightmodel/controls/rail1def");

        /// <summary>
        ///  Deflection Right Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Rail2def => m_data.GetFloat("sim/flightmodel/controls/rail2def");

        /// <summary>
        ///  Deflection Left Rudder. Units:degrees
        /// </summary>
        public IXPDataRef<float> Ldruddef => m_data.GetFloat("sim/flightmodel/controls/ldruddef");

        /// <summary>
        ///  Deflection Right Rudder. Units:degrees
        /// </summary>
        public IXPDataRef<float> Rdruddef => m_data.GetFloat("sim/flightmodel/controls/rdruddef");

        /// <summary>
        ///  Deflection Left Spoiler. Units:degrees
        /// </summary>
        public IXPDataRef<float> Lsplrdef => m_data.GetFloat("sim/flightmodel/controls/lsplrdef");

        /// <summary>
        ///  Deflection Right Spoiler. Units:degrees
        /// </summary>
        public IXPDataRef<float> Rsplrdef => m_data.GetFloat("sim/flightmodel/controls/rsplrdef");

        /// <summary>
        ///  [WING] Deflection Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Ail1_def => m_data.GetFloatArray("sim/flightmodel/controls/ail1_def");

        /// <summary>
        ///  [WING] Deflection Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Ail2_def => m_data.GetFloatArray("sim/flightmodel/controls/ail2_def");

        /// <summary>
        ///  [WING] Deflection Spoilers. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Splr_def => m_data.GetFloatArray("sim/flightmodel/controls/splr_def");

        /// <summary>
        ///  [WING] Deflection Spoilers 2. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Splr2_def => m_data.GetFloatArray("sim/flightmodel/controls/splr2_def");

        /// <summary>
        ///  . Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Yawb_def => m_data.GetFloatArray("sim/flightmodel/controls/yawb_def");

        /// <summary>
        ///  [WING] Deflection Rudders. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rudd_def => m_data.GetFloatArray("sim/flightmodel/controls/rudd_def");

        /// <summary>
        ///  [WING] Deflection Rudders. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Rudd2_def => m_data.GetFloatArray("sim/flightmodel/controls/rudd2_def");

        /// <summary>
        ///  [WING] Deflection Elevators. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Elv1_def => m_data.GetFloatArray("sim/flightmodel/controls/elv1_def");

        /// <summary>
        ///  [WING] Deflection Elevators. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Elv2_def => m_data.GetFloatArray("sim/flightmodel/controls/elv2_def");

        /// <summary>
        ///  [WING] Deflection Flaps. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Fla1_def => m_data.GetFloatArray("sim/flightmodel/controls/fla1_def");

        /// <summary>
        ///  [WING] Deflection Flaps. Units:degrees
        /// </summary>
        public IXPDataRef<float[]> Fla2_def => m_data.GetFloatArray("sim/flightmodel/controls/fla2_def");

        /// <summary>
        ///  Speed Brake, -0.5 = armed, 0 = off, 1 = max deployment. Units:[-0.5..1]
        /// </summary>
        public IXPDataRef<float> Sbrkrqst => m_data.GetFloat("sim/flightmodel/controls/sbrkrqst");

        /// <summary>
        ///  Requested thrust vector. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Vectrqst => m_data.GetFloat("sim/flightmodel/controls/vectrqst");

        /// <summary>
        ///  Actual wing sweep ratio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Swdi => m_data.GetFloat("sim/flightmodel/controls/swdi");

        /// <summary>
        ///  Requested sweep ratio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Swdirqst => m_data.GetFloat("sim/flightmodel/controls/swdirqst");

        /// <summary>
        ///  Actual slat deployment ratio. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Slatrat => m_data.GetFloat("sim/flightmodel/controls/slatrat");

        /// <summary>
        ///  Parking Brake, 1 = max. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Parkbrake => m_data.GetFloat("sim/flightmodel/controls/parkbrake");

        /// <summary>
        ///  Rotor Trim. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Rot_trim => m_data.GetFloat("sim/flightmodel/controls/rot_trim");

        /// <summary>
        ///  Rudder Trim, -1 = max left, 1 = max right. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Rud_trim => m_data.GetFloat("sim/flightmodel/controls/rud_trim");

        /// <summary>
        ///  Requested incidence. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Incid_rqst => m_data.GetFloat("sim/flightmodel/controls/incid_rqst");

        /// <summary>
        ///  Requested dihedral. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Dihed_rqst => m_data.GetFloat("sim/flightmodel/controls/dihed_rqst");

        /// <summary>
        ///  Actual thrust vector. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Vect_rat => m_data.GetFloat("sim/flightmodel/controls/vect_rat");

        /// <summary>
        ///  Actual incidence. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Incid_rat => m_data.GetFloat("sim/flightmodel/controls/incid_rat");

        /// <summary>
        ///  Actual dihedral. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Dihed_rat => m_data.GetFloat("sim/flightmodel/controls/dihed_rat");

        /// <summary>
        ///  tailhook deployment ratio, 0 is up 1 is down. Units:ratio
        /// </summary>
        public IXPDataRef<float> Tailhook_ratio => m_data.GetFloat("sim/flightmodel/controls/tailhook_ratio");

        /// <summary>
        ///  canopy deployment ratio, 0 is down 1 is up. Units:ratio
        /// </summary>
        public IXPDataRef<float> Canopy_ratio => m_data.GetFloat("sim/flightmodel/controls/canopy_ratio");

        /// <summary>
        ///  Deflection Wing 1 Left Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing1l_ail1def");

        /// <summary>
        ///  Deflection Wing 1 Left Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing1l_ail2def");

        /// <summary>
        ///  Deflection Wing 1 Right Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing1r_ail1def");

        /// <summary>
        ///  Deflection Wing 1 Right Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing1r_ail2def");

        /// <summary>
        ///  Deflection Wing 2 Left Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing2l_ail1def");

        /// <summary>
        ///  Deflection Wing 2 Left Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing2l_ail2def");

        /// <summary>
        ///  Deflection Wing 2 Right Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing2r_ail1def");

        /// <summary>
        ///  Deflection Wing 2 Right Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing2r_ail2def");

        /// <summary>
        ///  Deflection Wing 3 Left Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing3l_ail1def");

        /// <summary>
        ///  Deflection Wing 3 Left Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing3l_ail2def");

        /// <summary>
        ///  Deflection Wing 3 Right Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing3r_ail1def");

        /// <summary>
        ///  Deflection Wing 3 Right Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing3r_ail2def");

        /// <summary>
        ///  Deflection Wing 4 Left Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing4l_ail1def");

        /// <summary>
        ///  Deflection Wing 4 Left Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing4l_ail2def");

        /// <summary>
        ///  Deflection Wing 4 Right Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_ail1def => m_data.GetFloat("sim/flightmodel/controls/wing4r_ail1def");

        /// <summary>
        ///  Deflection Wing 4 Right Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_ail2def => m_data.GetFloat("sim/flightmodel/controls/wing4r_ail2def");

        /// <summary>
        ///  Deflection Wing 1 Left Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing1l_spo1def");

        /// <summary>
        ///  Deflection Wing 1 Left Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing1l_spo2def");

        /// <summary>
        ///  Deflection Wing 1 Right Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing1r_spo1def");

        /// <summary>
        ///  Deflection Wing 1 Right Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing1r_spo2def");

        /// <summary>
        ///  Deflection Wing 2 Left Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing2l_spo1def");

        /// <summary>
        ///  Deflection Wing 2 Left Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing2l_spo2def");

        /// <summary>
        ///  Deflection Wing 2 Right Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing2r_spo1def");

        /// <summary>
        ///  Deflection Wing 2 Right Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing2r_spo2def");

        /// <summary>
        ///  Deflection Wing 3 Left Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing3l_spo1def");

        /// <summary>
        ///  Deflection Wing 3 Left Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing3l_spo2def");

        /// <summary>
        ///  Deflection Wing 3 Right Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing3r_spo1def");

        /// <summary>
        ///  Deflection Wing 3 Right Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing3r_spo2def");

        /// <summary>
        ///  Deflection Wing 4 Left Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing4l_spo1def");

        /// <summary>
        ///  Deflection Wing 4 Left Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing4l_spo2def");

        /// <summary>
        ///  Deflection Wing 4 Right Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_spo1def => m_data.GetFloat("sim/flightmodel/controls/wing4r_spo1def");

        /// <summary>
        ///  Deflection Wing 4 Right Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_spo2def => m_data.GetFloat("sim/flightmodel/controls/wing4r_spo2def");

        /// <summary>
        ///  Deflection Wing 1 Left Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing1l_fla1def");

        /// <summary>
        ///  Deflection Wing 1 Left Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing1l_fla2def");

        /// <summary>
        ///  Deflection Wing 1 Right Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing1r_fla1def");

        /// <summary>
        ///  Deflection Wing 1 Right Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing1r_fla2def");

        /// <summary>
        ///  Deflection Wing 2 Left Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing2l_fla1def");

        /// <summary>
        ///  Deflection Wing 2 Left Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing2l_fla2def");

        /// <summary>
        ///  Deflection Wing 2 Right Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing2r_fla1def");

        /// <summary>
        ///  Deflection Wing 2 Right Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing2r_fla2def");

        /// <summary>
        ///  Deflection Wing 3 Left Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing3l_fla1def");

        /// <summary>
        ///  Deflection Wing 3 Left Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing3l_fla2def");

        /// <summary>
        ///  Deflection Wing 3 Right Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing3r_fla1def");

        /// <summary>
        ///  Deflection Wing 3 Right Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing3r_fla2def");

        /// <summary>
        ///  Deflection Wing 4 Left Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing4l_fla1def");

        /// <summary>
        ///  Deflection Wing 4 Left Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing4l_fla2def");

        /// <summary>
        ///  Deflection Wing 4 Right Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_fla1def => m_data.GetFloat("sim/flightmodel/controls/wing4r_fla1def");

        /// <summary>
        ///  Deflection Wing 4 Right Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_fla2def => m_data.GetFloat("sim/flightmodel/controls/wing4r_fla2def");

        /// <summary>
        ///  Deflection Wing 1 Left Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing1l_yawbdef");

        /// <summary>
        ///  Deflection Wing 1 Right Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing1r_yawbdef");

        /// <summary>
        ///  Deflection Wing 2 Left Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing2l_yawbdef");

        /// <summary>
        ///  Deflection Wing 2 Right Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing2r_yawbdef");

        /// <summary>
        ///  Deflection Wing 3 Left Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing3l_yawbdef");

        /// <summary>
        ///  Deflection Wing 3 Right Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing3r_yawbdef");

        /// <summary>
        ///  Deflection Wing 4 Left Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing4l_yawbdef");

        /// <summary>
        ///  Deflection Wing 4 Right Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_yawbdef => m_data.GetFloat("sim/flightmodel/controls/wing4r_yawbdef");

        /// <summary>
        ///  Deflection Wing 1 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Hstab1_elv1def => m_data.GetFloat("sim/flightmodel/controls/hstab1_elv1def");

        /// <summary>
        ///  Deflection Wing 1 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Hstab1_elv2def => m_data.GetFloat("sim/flightmodel/controls/hstab1_elv2def");

        /// <summary>
        ///  Deflection Wing 2 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Hstab2_elv1def => m_data.GetFloat("sim/flightmodel/controls/hstab2_elv1def");

        /// <summary>
        ///  Deflection Wing 2 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Hstab2_elv2def => m_data.GetFloat("sim/flightmodel/controls/hstab2_elv2def");

        /// <summary>
        ///  Deflection Wing 1 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Vstab1_rud1def => m_data.GetFloat("sim/flightmodel/controls/vstab1_rud1def");

        /// <summary>
        ///  Deflection Wing 1 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Vstab1_rud2def => m_data.GetFloat("sim/flightmodel/controls/vstab1_rud2def");

        /// <summary>
        ///  Deflection Wing 2 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Vstab2_rud1def => m_data.GetFloat("sim/flightmodel/controls/vstab2_rud1def");

        /// <summary>
        ///  Deflection Wing 2 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Vstab2_rud2def => m_data.GetFloat("sim/flightmodel/controls/vstab2_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 1 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing01_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 1 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing01_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 1 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing01_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 1 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing01_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 1 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing01_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 1 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing01_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 1 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing01_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 1 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing01_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 1 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing01_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 1 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing01_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 1 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing01_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing01_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 2 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing02_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 2 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing02_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 2 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing02_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 2 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing02_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 2 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing02_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 2 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing02_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 2 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing02_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 2 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing02_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 2 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing02_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 2 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing02_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 2 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing02_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing02_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 3 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing03_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 3 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing03_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 3 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing03_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 3 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing03_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 3 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing03_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 3 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing03_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 3 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing03_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 3 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing03_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 3 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing03_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 3 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing03_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 3 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing03_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing03_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 4 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing04_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 4 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing04_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 4 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing04_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 4 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing04_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 4 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing04_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 4 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing04_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 4 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing04_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 4 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing04_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 4 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing04_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 4 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing04_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 4 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing04_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing04_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 5 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing05_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 5 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing05_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 5 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing05_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 5 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing05_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 5 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing05_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 5 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing05_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 5 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing05_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 5 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing05_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 5 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing05_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 5 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing05_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 5 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing05_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing05_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 6 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing06_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 6 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing06_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 6 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing06_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 6 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing06_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 6 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing06_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 6 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing06_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 6 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing06_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 6 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing06_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 6 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing06_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 6 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing06_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 6 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing06_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing06_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 7 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing07_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 7 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing07_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 7 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing07_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 7 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing07_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 7 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing07_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 7 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing07_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 7 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing07_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 7 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing07_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 7 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing07_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 7 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing07_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 7 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing07_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing07_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 8 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing08_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 8 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing08_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 8 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing08_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 8 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing08_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 8 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing08_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 8 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing08_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 8 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing08_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 8 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing08_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 8 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing08_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 8 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing08_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 8 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing08_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing08_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 9 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing09_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 9 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing09_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 9 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing09_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 9 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing09_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 9 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing09_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 9 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing09_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 9 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing09_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 9 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing09_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 9 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing09_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 9 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing09_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 9 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing09_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing09_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 10 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing10_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 10 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing10_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 10 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing10_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 10 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing10_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 10 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing10_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 10 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing10_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 10 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing10_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 10 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing10_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 10 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing10_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 10 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing10_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 10 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing10_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing10_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 11 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing11_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 11 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing11_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 11 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing11_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 11 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing11_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 11 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing11_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 11 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing11_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 11 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing11_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 11 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing11_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 11 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing11_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 11 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing11_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 11 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing11_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing11_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 12 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing12_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 12 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing12_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 12 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing12_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 12 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing12_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 12 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing12_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 12 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing12_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 12 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing12_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 12 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing12_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 12 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing12_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 12 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing12_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 12 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing12_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing12_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 13 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing13_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 13 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing13_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 13 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing13_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 13 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing13_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 13 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing13_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 13 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing13_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 13 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing13_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 13 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing13_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 13 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing13_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 13 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing13_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 13 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing13_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing13_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 14 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing14_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 14 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing14_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 14 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing14_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 14 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing14_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 14 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing14_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 14 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing14_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 14 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing14_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 14 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing14_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 14 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing14_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 14 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing14_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 14 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing14_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing14_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 15 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing15_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 15 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing15_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 15 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing15_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 15 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing15_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 15 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing15_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 15 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing15_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 15 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing15_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 15 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing15_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 15 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing15_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 15 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing15_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 15 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing15_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing15_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 16 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing16_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 16 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing16_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 16 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing16_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 16 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing16_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 16 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing16_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 16 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing16_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 16 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing16_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 16 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing16_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 16 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing16_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 16 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing16_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 16 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing16_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing16_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 17 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing17_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 17 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing17_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 17 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing17_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 17 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing17_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 17 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing17_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 17 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing17_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 17 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing17_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 17 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing17_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 17 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing17_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 17 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing17_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 17 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing17_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing17_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 18 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing18_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 18 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing18_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 18 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing18_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 18 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing18_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 18 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing18_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 18 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing18_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 18 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing18_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 18 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing18_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 18 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing18_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 18 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing18_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 18 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing18_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing18_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 19 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing19_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 19 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing19_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 19 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing19_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 19 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing19_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 19 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing19_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 19 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing19_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 19 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing19_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 19 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing19_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 19 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing19_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 19 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing19_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 19 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing19_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing19_rud2def");

        /// <summary>
        ///  Deflection Misc Wing 20 Aileron 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_ail1def => m_data.GetFloat("sim/flightmodel/controls/mwing20_ail1def");

        /// <summary>
        ///  Deflection Misc Wing 20 Aileron 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_ail2def => m_data.GetFloat("sim/flightmodel/controls/mwing20_ail2def");

        /// <summary>
        ///  Deflection Misc Wing 20 Spoiler 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_spo1def => m_data.GetFloat("sim/flightmodel/controls/mwing20_spo1def");

        /// <summary>
        ///  Deflection Misc Wing 20 Spoiler 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_spo2def => m_data.GetFloat("sim/flightmodel/controls/mwing20_spo2def");

        /// <summary>
        ///  Deflection Misc Wing 20 Flap 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_fla1def => m_data.GetFloat("sim/flightmodel/controls/mwing20_fla1def");

        /// <summary>
        ///  Deflection Misc Wing 20 Flap 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_fla2def => m_data.GetFloat("sim/flightmodel/controls/mwing20_fla2def");

        /// <summary>
        ///  Deflection Misc Wing 20 Yaw Brake. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_yawbdef => m_data.GetFloat("sim/flightmodel/controls/mwing20_yawbdef");

        /// <summary>
        ///  Deflection Misc Wing 20 Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_elv1def => m_data.GetFloat("sim/flightmodel/controls/mwing20_elv1def");

        /// <summary>
        ///  Deflection Misc Wing 20 Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_elv2def => m_data.GetFloat("sim/flightmodel/controls/mwing20_elv2def");

        /// <summary>
        ///  Deflection Misc Wing 20 Rudder 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_rud1def => m_data.GetFloat("sim/flightmodel/controls/mwing20_rud1def");

        /// <summary>
        ///  Deflection Misc Wing 20 Rudder 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Mwing20_rud2def => m_data.GetFloat("sim/flightmodel/controls/mwing20_rud2def");

        /// <summary>
        ///  Wing 1 Left Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing1l_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing1l_retract_now");

        /// <summary>
        ///  Wing 1 Right Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing1r_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing1r_retract_now");

        /// <summary>
        ///  Wing 2 Left Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing2l_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing2l_retract_now");

        /// <summary>
        ///  Wing 2 Right Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing2r_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing2r_retract_now");

        /// <summary>
        ///  Wing 3 Left Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing3l_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing3l_retract_now");

        /// <summary>
        ///  Wing 3 Right Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing3r_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing3r_retract_now");

        /// <summary>
        ///  Wing 4 Left Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing4l_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing4l_retract_now");

        /// <summary>
        ///  Wing 4 Right Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing4r_retract_now => m_data.GetFloat("sim/flightmodel/controls/wing4r_retract_now");

        /// <summary>
        ///  Horiz Stab Left Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hstab1_retract_now => m_data.GetFloat("sim/flightmodel/controls/hstab1_retract_now");

        /// <summary>
        ///  Horiz Stab Right Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hstab2_retract_now => m_data.GetFloat("sim/flightmodel/controls/hstab2_retract_now");

        /// <summary>
        ///  Vert Stab 1 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Vstab1_retract_now => m_data.GetFloat("sim/flightmodel/controls/vstab1_retract_now");

        /// <summary>
        ///  Vert Stab 2 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Vstab2_retract_now => m_data.GetFloat("sim/flightmodel/controls/vstab2_retract_now");

        /// <summary>
        ///  Misc Wing 1 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing01_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing01_retract_now");

        /// <summary>
        ///  Misc Wing 2 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing02_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing02_retract_now");

        /// <summary>
        ///  Misc Wing 3 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing03_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing03_retract_now");

        /// <summary>
        ///  Misc Wing 4 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing04_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing04_retract_now");

        /// <summary>
        ///  Misc Wing 5 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing05_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing05_retract_now");

        /// <summary>
        ///  Misc Wing 6 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing06_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing06_retract_now");

        /// <summary>
        ///  Misc Wing 7 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing07_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing07_retract_now");

        /// <summary>
        ///  Misc Wing 8 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing08_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing08_retract_now");

        /// <summary>
        ///  Misc Wing 9 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing09_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing09_retract_now");

        /// <summary>
        ///  Misc Wing 10 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing10_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing10_retract_now");

        /// <summary>
        ///  Misc Wing 11 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing11_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing11_retract_now");

        /// <summary>
        ///  Misc Wing 12 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing12_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing12_retract_now");

        /// <summary>
        ///  Misc Wing 13 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing13_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing13_retract_now");

        /// <summary>
        ///  Misc Wing 14 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing14_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing14_retract_now");

        /// <summary>
        ///  Misc Wing 15 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing15_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing15_retract_now");

        /// <summary>
        ///  Misc Wing 16 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing16_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing16_retract_now");

        /// <summary>
        ///  Misc Wing 17 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing17_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing17_retract_now");

        /// <summary>
        ///  Misc Wing 18 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing18_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing18_retract_now");

        /// <summary>
        ///  Misc Wing 19 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing19_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing19_retract_now");

        /// <summary>
        ///  Misc Wing 20 Retract Now. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing20_retract_now => m_data.GetFloat("sim/flightmodel/controls/mwing20_retract_now");

        /// <summary>
        ///  Wing 1 Left Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing1l_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing1l_retract_max");

        /// <summary>
        ///  Wing 1 Right Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing1r_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing1r_retract_max");

        /// <summary>
        ///  Wing 2 Left Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing2l_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing2l_retract_max");

        /// <summary>
        ///  Wing 2 Right Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing2r_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing2r_retract_max");

        /// <summary>
        ///  Wing 3 Left Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing3l_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing3l_retract_max");

        /// <summary>
        ///  Wing 3 Right Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing3r_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing3r_retract_max");

        /// <summary>
        ///  Wing 4 Left Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing4l_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing4l_retract_max");

        /// <summary>
        ///  Wing 4 Right Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Wing4r_retract_max => m_data.GetFloat("sim/flightmodel/controls/wing4r_retract_max");

        /// <summary>
        ///  Horiz Stab Left Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hstab1_retract_max => m_data.GetFloat("sim/flightmodel/controls/hstab1_retract_max");

        /// <summary>
        ///  Horiz Stab Right Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Hstab2_retract_max => m_data.GetFloat("sim/flightmodel/controls/hstab2_retract_max");

        /// <summary>
        ///  Vert Stab 1 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Vstab1_retract_max => m_data.GetFloat("sim/flightmodel/controls/vstab1_retract_max");

        /// <summary>
        ///  Vert Stab 2 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Vstab2_retract_max => m_data.GetFloat("sim/flightmodel/controls/vstab2_retract_max");

        /// <summary>
        ///  Misc Wing 1 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing01_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing01_retract_max");

        /// <summary>
        ///  Misc Wing 2 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing02_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing02_retract_max");

        /// <summary>
        ///  Misc Wing 3 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing03_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing03_retract_max");

        /// <summary>
        ///  Misc Wing 4 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing04_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing04_retract_max");

        /// <summary>
        ///  Misc Wing 5 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing05_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing05_retract_max");

        /// <summary>
        ///  Misc Wing 6 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing06_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing06_retract_max");

        /// <summary>
        ///  Misc Wing 7 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing07_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing07_retract_max");

        /// <summary>
        ///  Misc Wing 8 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing08_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing08_retract_max");

        /// <summary>
        ///  Misc Wing 9 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing09_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing09_retract_max");

        /// <summary>
        ///  Misc Wing 10 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing10_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing10_retract_max");

        /// <summary>
        ///  Misc Wing 11 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing11_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing11_retract_max");

        /// <summary>
        ///  Misc Wing 12 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing12_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing12_retract_max");

        /// <summary>
        ///  Misc Wing 13 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing13_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing13_retract_max");

        /// <summary>
        ///  Misc Wing 14 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing14_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing14_retract_max");

        /// <summary>
        ///  Misc Wing 15 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing15_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing15_retract_max");

        /// <summary>
        ///  Misc Wing 16 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing16_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing16_retract_max");

        /// <summary>
        ///  Misc Wing 17 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing17_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing17_retract_max");

        /// <summary>
        ///  Misc Wing 18 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing18_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing18_retract_max");

        /// <summary>
        ///  Misc Wing 19 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing19_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing19_retract_max");

        /// <summary>
        ///  Misc Wing 20 Retract Max. Units:ratio
        /// </summary>
        public IXPDataRef<float> Mwing20_retract_max => m_data.GetFloat("sim/flightmodel/controls/mwing20_retract_max");

        /// <summary>
        ///  Deflection Wing 1 Left Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing1l_elv1def");

        /// <summary>
        ///  Deflection Wing 1 Left Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1l_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing1l_elv2def");

        /// <summary>
        ///  Deflection Wing 1 Right Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing1r_elv1def");

        /// <summary>
        ///  Deflection Wing 1 Right Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing1r_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing1r_elv2def");

        /// <summary>
        ///  Deflection Wing 2 Left Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing2l_elv1def");

        /// <summary>
        ///  Deflection Wing 2 Left Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2l_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing2l_elv2def");

        /// <summary>
        ///  Deflection Wing 2 Right Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing2r_elv1def");

        /// <summary>
        ///  Deflection Wing 2 Right Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing2r_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing2r_elv2def");

        /// <summary>
        ///  Deflection Wing 3 Left Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing3l_elv1def");

        /// <summary>
        ///  Deflection Wing 3 Left Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3l_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing3l_elv2def");

        /// <summary>
        ///  Deflection Wing 3 Right Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing3r_elv1def");

        /// <summary>
        ///  Deflection Wing 3 Right Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing3r_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing3r_elv2def");

        /// <summary>
        ///  Deflection Wing 4 Left Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing4l_elv1def");

        /// <summary>
        ///  Deflection Wing 4 Left Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4l_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing4l_elv2def");

        /// <summary>
        ///  Deflection Wing 4 Right Elevator 1. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_elv1def => m_data.GetFloat("sim/flightmodel/controls/wing4r_elv1def");

        /// <summary>
        ///  Deflection Wing 4 Right Elevator 2. Units:degrees
        /// </summary>
        public IXPDataRef<float> Wing4r_elv2def => m_data.GetFloat("sim/flightmodel/controls/wing4r_elv2def");
    }
}