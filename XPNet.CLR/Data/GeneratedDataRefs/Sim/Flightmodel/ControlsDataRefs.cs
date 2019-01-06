using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_controlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_controlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Actual speed brake deployment [0..1 = schedule for in-air, 1..1.5 = extra deployment when on ground]
        /// </summary>
        public IXPDataRef<float> sbrkrat { get { return m_data.GetFloat("sim/flightmodel/controls/sbrkrat");} }

        /// <summary>
        ///  Requested flap deployment, 0 = off, 1 = max
        /// </summary>
        public IXPDataRef<float> flaprqst { get { return m_data.GetFloat("sim/flightmodel/controls/flaprqst");} }

        /// <summary>
        ///  This is how locked the tail-wheel is ... 0 is free castoring, 1 is locked.
        /// </summary>
        public IXPDataRef<float> tail_lock_rat { get { return m_data.GetFloat("sim/flightmodel/controls/tail_lock_rat");} }

        /// <summary>
        ///  Current Aileron Trim, -1 = max left, 1 = max right
        /// </summary>
        public IXPDataRef<float> ail_trim { get { return m_data.GetFloat("sim/flightmodel/controls/ail_trim");} }

        /// <summary>
        ///  Distance Traveled
        /// </summary>
        public IXPDataRef<float> dist { get { return m_data.GetFloat("sim/flightmodel/controls/dist");} }

        /// <summary>
        ///  Elevation Trim, -1 = max nose down, 1 = max nose up
        /// </summary>
        public IXPDataRef<float> elv_trim { get { return m_data.GetFloat("sim/flightmodel/controls/elv_trim");} }

        /// <summary>
        ///  Actual flap 1 deployment ratio
        /// </summary>
        public IXPDataRef<float> flaprat { get { return m_data.GetFloat("sim/flightmodel/controls/flaprat");} }

        /// <summary>
        ///  Actual flap 2 deployment ratio
        /// </summary>
        public IXPDataRef<float> flap2rat { get { return m_data.GetFloat("sim/flightmodel/controls/flap2rat");} }

        /// <summary>
        ///  Left Brake - additional braking force (
        /// </summary>
        public IXPDataRef<float> l_brake_add { get { return m_data.GetFloat("sim/flightmodel/controls/l_brake_add");} }

        /// <summary>
        ///  Right Brake
        /// </summary>
        public IXPDataRef<float> r_brake_add { get { return m_data.GetFloat("sim/flightmodel/controls/r_brake_add");} }

        /// <summary>
        ///  Deflection Left Aileron 1
        /// </summary>
        public IXPDataRef<float> lail1def { get { return m_data.GetFloat("sim/flightmodel/controls/lail1def");} }

        /// <summary>
        ///  Deflection Left Aileron 2
        /// </summary>
        public IXPDataRef<float> lail2def { get { return m_data.GetFloat("sim/flightmodel/controls/lail2def");} }

        /// <summary>
        ///  Deflection Right Aileron 1
        /// </summary>
        public IXPDataRef<float> rail1def { get { return m_data.GetFloat("sim/flightmodel/controls/rail1def");} }

        /// <summary>
        ///  Deflection Right Aileron 2
        /// </summary>
        public IXPDataRef<float> rail2def { get { return m_data.GetFloat("sim/flightmodel/controls/rail2def");} }

        /// <summary>
        ///  Deflection Left Rudder
        /// </summary>
        public IXPDataRef<float> ldruddef { get { return m_data.GetFloat("sim/flightmodel/controls/ldruddef");} }

        /// <summary>
        ///  Deflection Right Rudder
        /// </summary>
        public IXPDataRef<float> rdruddef { get { return m_data.GetFloat("sim/flightmodel/controls/rdruddef");} }

        /// <summary>
        ///  Deflection Left Spoiler
        /// </summary>
        public IXPDataRef<float> lsplrdef { get { return m_data.GetFloat("sim/flightmodel/controls/lsplrdef");} }

        /// <summary>
        ///  Deflection Right Spoiler
        /// </summary>
        public IXPDataRef<float> rsplrdef { get { return m_data.GetFloat("sim/flightmodel/controls/rsplrdef");} }

        /// <summary>
        ///  [WING] Deflection Aileron 1
        /// </summary>
        public IXPDataRef<float[]> ail1_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/ail1_def");} }

        /// <summary>
        ///  [WING] Deflection Aileron 2
        /// </summary>
        public IXPDataRef<float[]> ail2_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/ail2_def");} }

        /// <summary>
        ///  [WING] Deflection Spoilers
        /// </summary>
        public IXPDataRef<float[]> splr_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/splr_def");} }

        /// <summary>
        ///  [WING] Deflection Spoilers 2
        /// </summary>
        public IXPDataRef<float[]> splr2_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/splr2_def");} }

        /// <summary>
        ///  
        /// </summary>
        public IXPDataRef<float[]> yawb_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/yawb_def");} }

        /// <summary>
        ///  [WING] Deflection Rudders
        /// </summary>
        public IXPDataRef<float[]> rudd_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/rudd_def");} }

        /// <summary>
        ///  [WING] Deflection Rudders
        /// </summary>
        public IXPDataRef<float[]> rudd2_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/rudd2_def");} }

        /// <summary>
        ///  [WING] Deflection Elevators
        /// </summary>
        public IXPDataRef<float[]> elv1_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/elv1_def");} }

        /// <summary>
        ///  [WING] Deflection Elevators
        /// </summary>
        public IXPDataRef<float[]> elv2_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/elv2_def");} }

        /// <summary>
        ///  [WING] Deflection Flaps
        /// </summary>
        public IXPDataRef<float[]> fla1_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/fla1_def");} }

        /// <summary>
        ///  [WING] Deflection Flaps
        /// </summary>
        public IXPDataRef<float[]> fla2_def { get { return m_data.GetFloatArray("sim/flightmodel/controls/fla2_def");} }

        /// <summary>
        ///  Speed Brake, -0.5 = armed, 0 = off, 1 = max deployment
        /// </summary>
        public IXPDataRef<float> sbrkrqst { get { return m_data.GetFloat("sim/flightmodel/controls/sbrkrqst");} }

        /// <summary>
        ///  Requested thrust vector
        /// </summary>
        public IXPDataRef<float> vectrqst { get { return m_data.GetFloat("sim/flightmodel/controls/vectrqst");} }

        /// <summary>
        ///  Actual wing sweep ratio
        /// </summary>
        public IXPDataRef<float> swdi { get { return m_data.GetFloat("sim/flightmodel/controls/swdi");} }

        /// <summary>
        ///  Requested sweep ratio
        /// </summary>
        public IXPDataRef<float> swdirqst { get { return m_data.GetFloat("sim/flightmodel/controls/swdirqst");} }

        /// <summary>
        ///  Actual slat deployment ratio
        /// </summary>
        public IXPDataRef<float> slatrat { get { return m_data.GetFloat("sim/flightmodel/controls/slatrat");} }

        /// <summary>
        ///  Parking Brake, 1 = max
        /// </summary>
        public IXPDataRef<float> parkbrake { get { return m_data.GetFloat("sim/flightmodel/controls/parkbrake");} }

        /// <summary>
        ///  Rotor Trim
        /// </summary>
        public IXPDataRef<float> rot_trim { get { return m_data.GetFloat("sim/flightmodel/controls/rot_trim");} }

        /// <summary>
        ///  Rudder Trim, -1 = max left, 1 = max right
        /// </summary>
        public IXPDataRef<float> rud_trim { get { return m_data.GetFloat("sim/flightmodel/controls/rud_trim");} }

        /// <summary>
        ///  Requested incidence
        /// </summary>
        public IXPDataRef<float> incid_rqst { get { return m_data.GetFloat("sim/flightmodel/controls/incid_rqst");} }

        /// <summary>
        ///  Requested dihedral
        /// </summary>
        public IXPDataRef<float> dihed_rqst { get { return m_data.GetFloat("sim/flightmodel/controls/dihed_rqst");} }

        /// <summary>
        ///  Actual thrust vector
        /// </summary>
        public IXPDataRef<float> vect_rat { get { return m_data.GetFloat("sim/flightmodel/controls/vect_rat");} }

        /// <summary>
        ///  Actual incidence
        /// </summary>
        public IXPDataRef<float> incid_rat { get { return m_data.GetFloat("sim/flightmodel/controls/incid_rat");} }

        /// <summary>
        ///  Actual dihedral
        /// </summary>
        public IXPDataRef<float> dihed_rat { get { return m_data.GetFloat("sim/flightmodel/controls/dihed_rat");} }

        /// <summary>
        ///  tailhook deployment ratio, 0 is up 1 is down
        /// </summary>
        public IXPDataRef<float> tailhook_ratio { get { return m_data.GetFloat("sim/flightmodel/controls/tailhook_ratio");} }

        /// <summary>
        ///  canopy deployment ratio, 0 is down 1 is up
        /// </summary>
        public IXPDataRef<float> canopy_ratio { get { return m_data.GetFloat("sim/flightmodel/controls/canopy_ratio");} }

        /// <summary>
        ///  Deflection Wing 1 Left Aileron 1
        /// </summary>
        public IXPDataRef<float> wing1l_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_ail1def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Aileron 2
        /// </summary>
        public IXPDataRef<float> wing1l_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_ail2def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Aileron 1
        /// </summary>
        public IXPDataRef<float> wing1r_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_ail1def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Aileron 2
        /// </summary>
        public IXPDataRef<float> wing1r_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_ail2def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Aileron 1
        /// </summary>
        public IXPDataRef<float> wing2l_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_ail1def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Aileron 2
        /// </summary>
        public IXPDataRef<float> wing2l_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_ail2def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Aileron 1
        /// </summary>
        public IXPDataRef<float> wing2r_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_ail1def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Aileron 2
        /// </summary>
        public IXPDataRef<float> wing2r_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_ail2def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Aileron 1
        /// </summary>
        public IXPDataRef<float> wing3l_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_ail1def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Aileron 2
        /// </summary>
        public IXPDataRef<float> wing3l_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_ail2def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Aileron 1
        /// </summary>
        public IXPDataRef<float> wing3r_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_ail1def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Aileron 2
        /// </summary>
        public IXPDataRef<float> wing3r_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_ail2def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Aileron 1
        /// </summary>
        public IXPDataRef<float> wing4l_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_ail1def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Aileron 2
        /// </summary>
        public IXPDataRef<float> wing4l_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_ail2def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Aileron 1
        /// </summary>
        public IXPDataRef<float> wing4r_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_ail1def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Aileron 2
        /// </summary>
        public IXPDataRef<float> wing4r_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_ail2def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing1l_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_spo1def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing1l_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_spo2def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing1r_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_spo1def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing1r_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_spo2def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing2l_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_spo1def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing2l_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_spo2def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing2r_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_spo1def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing2r_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_spo2def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing3l_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_spo1def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing3l_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_spo2def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing3r_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_spo1def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing3r_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_spo2def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing4l_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_spo1def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing4l_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_spo2def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Spoiler 1
        /// </summary>
        public IXPDataRef<float> wing4r_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_spo1def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Spoiler 2
        /// </summary>
        public IXPDataRef<float> wing4r_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_spo2def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Flap 1
        /// </summary>
        public IXPDataRef<float> wing1l_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_fla1def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Flap 2
        /// </summary>
        public IXPDataRef<float> wing1l_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_fla2def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Flap 1
        /// </summary>
        public IXPDataRef<float> wing1r_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_fla1def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Flap 2
        /// </summary>
        public IXPDataRef<float> wing1r_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_fla2def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Flap 1
        /// </summary>
        public IXPDataRef<float> wing2l_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_fla1def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Flap 2
        /// </summary>
        public IXPDataRef<float> wing2l_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_fla2def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Flap 1
        /// </summary>
        public IXPDataRef<float> wing2r_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_fla1def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Flap 2
        /// </summary>
        public IXPDataRef<float> wing2r_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_fla2def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Flap 1
        /// </summary>
        public IXPDataRef<float> wing3l_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_fla1def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Flap 2
        /// </summary>
        public IXPDataRef<float> wing3l_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_fla2def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Flap 1
        /// </summary>
        public IXPDataRef<float> wing3r_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_fla1def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Flap 2
        /// </summary>
        public IXPDataRef<float> wing3r_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_fla2def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Flap 1
        /// </summary>
        public IXPDataRef<float> wing4l_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_fla1def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Flap 2
        /// </summary>
        public IXPDataRef<float> wing4l_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_fla2def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Flap 1
        /// </summary>
        public IXPDataRef<float> wing4r_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_fla1def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Flap 2
        /// </summary>
        public IXPDataRef<float> wing4r_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_fla2def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing1l_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 1 Right Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing1r_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 2 Left Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing2l_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 2 Right Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing2r_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 3 Left Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing3l_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 3 Right Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing3r_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 4 Left Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing4l_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 4 Right Yaw Brake
        /// </summary>
        public IXPDataRef<float> wing4r_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_yawbdef");} }

        /// <summary>
        ///  Deflection Wing 1 Elevator 1
        /// </summary>
        public IXPDataRef<float> hstab1_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/hstab1_elv1def");} }

        /// <summary>
        ///  Deflection Wing 1 Elevator 2
        /// </summary>
        public IXPDataRef<float> hstab1_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/hstab1_elv2def");} }

        /// <summary>
        ///  Deflection Wing 2 Elevator 1
        /// </summary>
        public IXPDataRef<float> hstab2_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/hstab2_elv1def");} }

        /// <summary>
        ///  Deflection Wing 2 Elevator 2
        /// </summary>
        public IXPDataRef<float> hstab2_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/hstab2_elv2def");} }

        /// <summary>
        ///  Deflection Wing 1 Rudder 1
        /// </summary>
        public IXPDataRef<float> vstab1_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/vstab1_rud1def");} }

        /// <summary>
        ///  Deflection Wing 1 Rudder 2
        /// </summary>
        public IXPDataRef<float> vstab1_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/vstab1_rud2def");} }

        /// <summary>
        ///  Deflection Wing 2 Rudder 1
        /// </summary>
        public IXPDataRef<float> vstab2_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/vstab2_rud1def");} }

        /// <summary>
        ///  Deflection Wing 2 Rudder 2
        /// </summary>
        public IXPDataRef<float> vstab2_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/vstab2_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing01_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing01_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing01_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing01_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing01_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing01_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing01_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing01_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing01_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing01_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 1 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing01_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing02_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing02_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing02_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing02_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing02_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing02_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing02_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing02_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing02_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing02_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 2 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing02_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing03_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing03_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing03_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing03_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing03_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing03_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing03_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing03_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing03_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing03_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 3 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing03_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing04_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing04_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing04_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing04_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing04_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing04_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing04_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing04_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing04_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing04_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 4 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing04_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing05_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing05_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing05_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing05_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing05_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing05_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing05_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing05_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing05_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing05_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 5 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing05_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing06_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing06_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing06_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing06_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing06_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing06_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing06_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing06_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing06_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing06_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 6 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing06_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing07_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing07_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing07_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing07_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing07_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing07_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing07_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing07_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing07_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing07_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 7 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing07_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing08_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing08_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing08_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing08_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing08_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing08_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing08_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing08_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing08_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing08_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 8 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing08_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing09_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing09_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing09_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing09_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing09_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing09_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing09_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing09_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing09_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing09_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 9 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing09_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing10_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing10_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing10_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing10_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing10_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing10_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing10_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing10_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing10_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing10_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 10 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing10_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing11_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing11_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing11_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing11_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing11_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing11_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing11_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing11_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing11_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing11_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 11 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing11_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing12_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing12_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing12_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing12_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing12_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing12_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing12_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing12_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing12_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing12_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 12 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing12_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing13_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing13_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing13_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing13_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing13_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing13_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing13_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing13_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing13_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing13_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 13 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing13_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing14_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing14_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing14_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing14_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing14_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing14_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing14_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing14_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing14_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing14_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 14 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing14_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing15_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing15_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing15_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing15_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing15_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing15_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing15_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing15_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing15_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing15_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 15 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing15_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing16_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing16_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing16_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing16_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing16_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing16_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing16_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing16_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing16_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing16_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 16 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing16_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing17_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing17_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing17_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing17_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing17_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing17_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing17_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing17_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing17_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing17_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 17 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing17_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing18_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing18_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing18_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing18_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing18_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing18_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing18_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing18_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing18_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing18_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 18 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing18_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing19_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing19_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing19_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing19_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing19_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing19_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing19_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing19_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing19_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing19_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 19 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing19_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_rud2def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Aileron 1
        /// </summary>
        public IXPDataRef<float> mwing20_ail1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_ail1def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Aileron 2
        /// </summary>
        public IXPDataRef<float> mwing20_ail2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_ail2def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Spoiler 1
        /// </summary>
        public IXPDataRef<float> mwing20_spo1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_spo1def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Spoiler 2
        /// </summary>
        public IXPDataRef<float> mwing20_spo2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_spo2def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Flap 1
        /// </summary>
        public IXPDataRef<float> mwing20_fla1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_fla1def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Flap 2
        /// </summary>
        public IXPDataRef<float> mwing20_fla2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_fla2def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Yaw Brake
        /// </summary>
        public IXPDataRef<float> mwing20_yawbdef { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_yawbdef");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Elevator 1
        /// </summary>
        public IXPDataRef<float> mwing20_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_elv1def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Elevator 2
        /// </summary>
        public IXPDataRef<float> mwing20_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_elv2def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Rudder 1
        /// </summary>
        public IXPDataRef<float> mwing20_rud1def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_rud1def");} }

        /// <summary>
        ///  Deflection Misc Wing 20 Rudder 2
        /// </summary>
        public IXPDataRef<float> mwing20_rud2def { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_rud2def");} }

        /// <summary>
        ///  Wing 1 Left Retract
        /// </summary>
        public IXPDataRef<bool> wing1l_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing1l_retract");} }

        /// <summary>
        ///  Wing 1 Right Retract
        /// </summary>
        public IXPDataRef<bool> wing1r_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing1r_retract");} }

        /// <summary>
        ///  Wing 2 Left Retract
        /// </summary>
        public IXPDataRef<bool> wing2l_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing2l_retract");} }

        /// <summary>
        ///  Wing 2 Right Retract
        /// </summary>
        public IXPDataRef<bool> wing2r_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing2r_retract");} }

        /// <summary>
        ///  Wing 3 Left Retract
        /// </summary>
        public IXPDataRef<bool> wing3l_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing3l_retract");} }

        /// <summary>
        ///  Wing 3 Right Retract
        /// </summary>
        public IXPDataRef<bool> wing3r_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing3r_retract");} }

        /// <summary>
        ///  Wing 4 Left Retract
        /// </summary>
        public IXPDataRef<bool> wing4l_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing4l_retract");} }

        /// <summary>
        ///  Wing 4 Right Retract
        /// </summary>
        public IXPDataRef<bool> wing4r_retract { get { return m_data.GetBool("sim/flightmodel/controls/wing4r_retract");} }

        /// <summary>
        ///  Horiz Stab Left Retract
        /// </summary>
        public IXPDataRef<bool> hstab1_retract { get { return m_data.GetBool("sim/flightmodel/controls/hstab1_retract");} }

        /// <summary>
        ///  Horiz Stab Right Retract
        /// </summary>
        public IXPDataRef<bool> hstab2_retract { get { return m_data.GetBool("sim/flightmodel/controls/hstab2_retract");} }

        /// <summary>
        ///  Vert Stab 1 Retract
        /// </summary>
        public IXPDataRef<bool> vstab1_retract { get { return m_data.GetBool("sim/flightmodel/controls/vstab1_retract");} }

        /// <summary>
        ///  Vert Stab 2 Retract
        /// </summary>
        public IXPDataRef<bool> vstab2_retract { get { return m_data.GetBool("sim/flightmodel/controls/vstab2_retract");} }

        /// <summary>
        ///  Misc Wing 1 Retract
        /// </summary>
        public IXPDataRef<bool> mwing01_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing01_retract");} }

        /// <summary>
        ///  Misc Wing 2 Retract
        /// </summary>
        public IXPDataRef<bool> mwing02_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing02_retract");} }

        /// <summary>
        ///  Misc Wing 3 Retract
        /// </summary>
        public IXPDataRef<bool> mwing03_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing03_retract");} }

        /// <summary>
        ///  Misc Wing 4 Retract
        /// </summary>
        public IXPDataRef<bool> mwing04_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing04_retract");} }

        /// <summary>
        ///  Misc Wing 5 Retract
        /// </summary>
        public IXPDataRef<bool> mwing05_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing05_retract");} }

        /// <summary>
        ///  Misc Wing 6 Retract
        /// </summary>
        public IXPDataRef<bool> mwing06_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing06_retract");} }

        /// <summary>
        ///  Misc Wing 7 Retract
        /// </summary>
        public IXPDataRef<bool> mwing07_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing07_retract");} }

        /// <summary>
        ///  Misc Wing 8 Retract
        /// </summary>
        public IXPDataRef<bool> mwing08_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing08_retract");} }

        /// <summary>
        ///  Misc Wing 9 Retract
        /// </summary>
        public IXPDataRef<bool> mwing09_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing09_retract");} }

        /// <summary>
        ///  Misc Wing 10 Retract
        /// </summary>
        public IXPDataRef<bool> mwing10_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing10_retract");} }

        /// <summary>
        ///  Misc Wing 11 Retract
        /// </summary>
        public IXPDataRef<bool> mwing11_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing11_retract");} }

        /// <summary>
        ///  Misc Wing 12 Retract
        /// </summary>
        public IXPDataRef<bool> mwing12_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing12_retract");} }

        /// <summary>
        ///  Misc Wing 13 Retract
        /// </summary>
        public IXPDataRef<bool> mwing13_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing13_retract");} }

        /// <summary>
        ///  Misc Wing 14 Retract
        /// </summary>
        public IXPDataRef<bool> mwing14_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing14_retract");} }

        /// <summary>
        ///  Misc Wing 15 Retract
        /// </summary>
        public IXPDataRef<bool> mwing15_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing15_retract");} }

        /// <summary>
        ///  Misc Wing 16 Retract
        /// </summary>
        public IXPDataRef<bool> mwing16_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing16_retract");} }

        /// <summary>
        ///  Misc Wing 17 Retract
        /// </summary>
        public IXPDataRef<bool> mwing17_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing17_retract");} }

        /// <summary>
        ///  Misc Wing 18 Retract
        /// </summary>
        public IXPDataRef<bool> mwing18_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing18_retract");} }

        /// <summary>
        ///  Misc Wing 19 Retract
        /// </summary>
        public IXPDataRef<bool> mwing19_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing19_retract");} }

        /// <summary>
        ///  Misc Wing 20 Retract
        /// </summary>
        public IXPDataRef<bool> mwing20_retract { get { return m_data.GetBool("sim/flightmodel/controls/mwing20_retract");} }

        /// <summary>
        ///  Wing 1 Left Retract Now
        /// </summary>
        public IXPDataRef<float> wing1l_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_retract_now");} }

        /// <summary>
        ///  Wing 1 Right Retract Now
        /// </summary>
        public IXPDataRef<float> wing1r_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_retract_now");} }

        /// <summary>
        ///  Wing 2 Left Retract Now
        /// </summary>
        public IXPDataRef<float> wing2l_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_retract_now");} }

        /// <summary>
        ///  Wing 2 Right Retract Now
        /// </summary>
        public IXPDataRef<float> wing2r_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_retract_now");} }

        /// <summary>
        ///  Wing 3 Left Retract Now
        /// </summary>
        public IXPDataRef<float> wing3l_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_retract_now");} }

        /// <summary>
        ///  Wing 3 Right Retract Now
        /// </summary>
        public IXPDataRef<float> wing3r_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_retract_now");} }

        /// <summary>
        ///  Wing 4 Left Retract Now
        /// </summary>
        public IXPDataRef<float> wing4l_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_retract_now");} }

        /// <summary>
        ///  Wing 4 Right Retract Now
        /// </summary>
        public IXPDataRef<float> wing4r_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_retract_now");} }

        /// <summary>
        ///  Horiz Stab Left Retract Now
        /// </summary>
        public IXPDataRef<float> hstab1_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/hstab1_retract_now");} }

        /// <summary>
        ///  Horiz Stab Right Retract Now
        /// </summary>
        public IXPDataRef<float> hstab2_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/hstab2_retract_now");} }

        /// <summary>
        ///  Vert Stab 1 Retract Now
        /// </summary>
        public IXPDataRef<float> vstab1_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/vstab1_retract_now");} }

        /// <summary>
        ///  Vert Stab 2 Retract Now
        /// </summary>
        public IXPDataRef<float> vstab2_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/vstab2_retract_now");} }

        /// <summary>
        ///  Misc Wing 1 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing01_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_retract_now");} }

        /// <summary>
        ///  Misc Wing 2 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing02_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_retract_now");} }

        /// <summary>
        ///  Misc Wing 3 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing03_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_retract_now");} }

        /// <summary>
        ///  Misc Wing 4 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing04_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_retract_now");} }

        /// <summary>
        ///  Misc Wing 5 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing05_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_retract_now");} }

        /// <summary>
        ///  Misc Wing 6 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing06_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_retract_now");} }

        /// <summary>
        ///  Misc Wing 7 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing07_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_retract_now");} }

        /// <summary>
        ///  Misc Wing 8 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing08_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_retract_now");} }

        /// <summary>
        ///  Misc Wing 9 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing09_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_retract_now");} }

        /// <summary>
        ///  Misc Wing 10 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing10_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_retract_now");} }

        /// <summary>
        ///  Misc Wing 11 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing11_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_retract_now");} }

        /// <summary>
        ///  Misc Wing 12 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing12_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_retract_now");} }

        /// <summary>
        ///  Misc Wing 13 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing13_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_retract_now");} }

        /// <summary>
        ///  Misc Wing 14 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing14_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_retract_now");} }

        /// <summary>
        ///  Misc Wing 15 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing15_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_retract_now");} }

        /// <summary>
        ///  Misc Wing 16 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing16_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_retract_now");} }

        /// <summary>
        ///  Misc Wing 17 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing17_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_retract_now");} }

        /// <summary>
        ///  Misc Wing 18 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing18_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_retract_now");} }

        /// <summary>
        ///  Misc Wing 19 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing19_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_retract_now");} }

        /// <summary>
        ///  Misc Wing 20 Retract Now
        /// </summary>
        public IXPDataRef<float> mwing20_retract_now { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_retract_now");} }

        /// <summary>
        ///  Wing 1 Left Retract Max
        /// </summary>
        public IXPDataRef<float> wing1l_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_retract_max");} }

        /// <summary>
        ///  Wing 1 Right Retract Max
        /// </summary>
        public IXPDataRef<float> wing1r_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_retract_max");} }

        /// <summary>
        ///  Wing 2 Left Retract Max
        /// </summary>
        public IXPDataRef<float> wing2l_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_retract_max");} }

        /// <summary>
        ///  Wing 2 Right Retract Max
        /// </summary>
        public IXPDataRef<float> wing2r_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_retract_max");} }

        /// <summary>
        ///  Wing 3 Left Retract Max
        /// </summary>
        public IXPDataRef<float> wing3l_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_retract_max");} }

        /// <summary>
        ///  Wing 3 Right Retract Max
        /// </summary>
        public IXPDataRef<float> wing3r_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_retract_max");} }

        /// <summary>
        ///  Wing 4 Left Retract Max
        /// </summary>
        public IXPDataRef<float> wing4l_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_retract_max");} }

        /// <summary>
        ///  Wing 4 Right Retract Max
        /// </summary>
        public IXPDataRef<float> wing4r_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_retract_max");} }

        /// <summary>
        ///  Horiz Stab Left Retract Max
        /// </summary>
        public IXPDataRef<float> hstab1_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/hstab1_retract_max");} }

        /// <summary>
        ///  Horiz Stab Right Retract Max
        /// </summary>
        public IXPDataRef<float> hstab2_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/hstab2_retract_max");} }

        /// <summary>
        ///  Vert Stab 1 Retract Max
        /// </summary>
        public IXPDataRef<float> vstab1_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/vstab1_retract_max");} }

        /// <summary>
        ///  Vert Stab 2 Retract Max
        /// </summary>
        public IXPDataRef<float> vstab2_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/vstab2_retract_max");} }

        /// <summary>
        ///  Misc Wing 1 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing01_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing01_retract_max");} }

        /// <summary>
        ///  Misc Wing 2 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing02_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing02_retract_max");} }

        /// <summary>
        ///  Misc Wing 3 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing03_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing03_retract_max");} }

        /// <summary>
        ///  Misc Wing 4 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing04_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing04_retract_max");} }

        /// <summary>
        ///  Misc Wing 5 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing05_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing05_retract_max");} }

        /// <summary>
        ///  Misc Wing 6 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing06_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing06_retract_max");} }

        /// <summary>
        ///  Misc Wing 7 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing07_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing07_retract_max");} }

        /// <summary>
        ///  Misc Wing 8 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing08_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing08_retract_max");} }

        /// <summary>
        ///  Misc Wing 9 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing09_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing09_retract_max");} }

        /// <summary>
        ///  Misc Wing 10 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing10_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing10_retract_max");} }

        /// <summary>
        ///  Misc Wing 11 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing11_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing11_retract_max");} }

        /// <summary>
        ///  Misc Wing 12 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing12_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing12_retract_max");} }

        /// <summary>
        ///  Misc Wing 13 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing13_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing13_retract_max");} }

        /// <summary>
        ///  Misc Wing 14 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing14_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing14_retract_max");} }

        /// <summary>
        ///  Misc Wing 15 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing15_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing15_retract_max");} }

        /// <summary>
        ///  Misc Wing 16 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing16_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing16_retract_max");} }

        /// <summary>
        ///  Misc Wing 17 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing17_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing17_retract_max");} }

        /// <summary>
        ///  Misc Wing 18 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing18_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing18_retract_max");} }

        /// <summary>
        ///  Misc Wing 19 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing19_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing19_retract_max");} }

        /// <summary>
        ///  Misc Wing 20 Retract Max
        /// </summary>
        public IXPDataRef<float> mwing20_retract_max { get { return m_data.GetFloat("sim/flightmodel/controls/mwing20_retract_max");} }

        /// <summary>
        ///  Deflection Wing 1 Left Elevator 1
        /// </summary>
        public IXPDataRef<float> wing1l_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_elv1def");} }

        /// <summary>
        ///  Deflection Wing 1 Left Elevator 2
        /// </summary>
        public IXPDataRef<float> wing1l_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1l_elv2def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Elevator 1
        /// </summary>
        public IXPDataRef<float> wing1r_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_elv1def");} }

        /// <summary>
        ///  Deflection Wing 1 Right Elevator 2
        /// </summary>
        public IXPDataRef<float> wing1r_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing1r_elv2def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Elevator 1
        /// </summary>
        public IXPDataRef<float> wing2l_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_elv1def");} }

        /// <summary>
        ///  Deflection Wing 2 Left Elevator 2
        /// </summary>
        public IXPDataRef<float> wing2l_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2l_elv2def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Elevator 1
        /// </summary>
        public IXPDataRef<float> wing2r_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_elv1def");} }

        /// <summary>
        ///  Deflection Wing 2 Right Elevator 2
        /// </summary>
        public IXPDataRef<float> wing2r_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing2r_elv2def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Elevator 1
        /// </summary>
        public IXPDataRef<float> wing3l_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_elv1def");} }

        /// <summary>
        ///  Deflection Wing 3 Left Elevator 2
        /// </summary>
        public IXPDataRef<float> wing3l_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3l_elv2def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Elevator 1
        /// </summary>
        public IXPDataRef<float> wing3r_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_elv1def");} }

        /// <summary>
        ///  Deflection Wing 3 Right Elevator 2
        /// </summary>
        public IXPDataRef<float> wing3r_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing3r_elv2def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Elevator 1
        /// </summary>
        public IXPDataRef<float> wing4l_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_elv1def");} }

        /// <summary>
        ///  Deflection Wing 4 Left Elevator 2
        /// </summary>
        public IXPDataRef<float> wing4l_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4l_elv2def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Elevator 1
        /// </summary>
        public IXPDataRef<float> wing4r_elv1def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_elv1def");} }

        /// <summary>
        ///  Deflection Wing 4 Right Elevator 2
        /// </summary>
        public IXPDataRef<float> wing4r_elv2def { get { return m_data.GetFloat("sim/flightmodel/controls/wing4r_elv2def");} }
    }
}