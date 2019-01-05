using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Aircraft_ControlsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Aircraft_ControlsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Minimum prop speed with governor on, radians/Second. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Acf_RSC_mingov_prp => m_data.GetFloat("sim/aircraft/controls/acf_rsc_mingov_prp");

        /// <summary>
        ///  Prop idle speed radians/Second. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Acf_RSC_idlespeed_prp => m_data.GetFloat("sim/aircraft/controls/acf_rsc_idlespeed_prp");

        /// <summary>
        ///  Max prop speed radians/Second. Units:rad/Sec
        /// </summary>
        public IXPDataRef<float> Acf_RSC_redline_prp => m_data.GetFloat("sim/aircraft/controls/acf_rsc_redline_prp");

        /// <summary>
        ///  NOTE : This is now the same as acf_trq_max_en in v7. Units:newtonmeters
        /// </summary>
        public IXPDataRef<float> Acf_trq_max_prp => m_data.GetFloat("sim/aircraft/controls/acf_trq_max_prp");

        /// <summary>
        ///  This is the maximum degrees deflection up for a horizontal stabilizer that moves during trim. Units:degrees
        /// </summary>
        public IXPDataRef<float> Acf_hstb_trim_up => m_data.GetFloat("sim/aircraft/controls/acf_hstb_trim_up");

        /// <summary>
        ///  This is the maximum degrees deflection down for a horizontal stabilizer that moves during trim. Units:degrees
        /// </summary>
        public IXPDataRef<float> Acf_hstb_trim_dn => m_data.GetFloat("sim/aircraft/controls/acf_hstb_trim_dn");

        /// <summary>
        ///  This is the trim position for takeoff expressed as a ratio, 1 = max up trim, -1 = max down trim.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Acf_takeoff_trim => m_data.GetFloat("sim/aircraft/controls/acf_takeoff_trim");

        /// <summary>
        ///  Maximum nose-down trim, expressed as a ratio of maximum nose-down elevator deflection. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_min_trim_elev => m_data.GetFloat("sim/aircraft/controls/acf_min_trim_elev");

        /// <summary>
        ///  Maximum nose-up trim, expressed as a ratio of maximum nose-up elevator deflection. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_max_trim_elev => m_data.GetFloat("sim/aircraft/controls/acf_max_trim_elev");

        /// <summary>
        ///  This is the speed of trim time, expressed as a ratio, where 1.0 means it takes 20 seconds to fully move trim from one extreme to the other.  2.0 means trim is twice as fast.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Acf_elev_trim_speedrat => m_data.GetFloat("sim/aircraft/controls/acf_elev_trim_speedrat");

        /// <summary>
        ///  This is the amount of elevator deflection (as a ratio of max) induced by the aerodynamic effect of static trim tabs.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Acf_elev_tab => m_data.GetFloat("sim/aircraft/controls/acf_elev_tab");

        /// <summary>
        ///  Maximum aileron downward trim, expressed as a ratio of maximum aileron downward travel. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_min_trim_ailn => m_data.GetFloat("sim/aircraft/controls/acf_min_trim_ailn");

        /// <summary>
        ///  Maximum aileron upward trim, expressed as a ratio of maximum aileron upward travel. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_max_trim_ailn => m_data.GetFloat("sim/aircraft/controls/acf_max_trim_ailn");

        /// <summary>
        ///  This is the speed of trim time, expressed as a ratio, where 1.0 means it takes 20 seconds to fully move trim from one extreme to the other.  2.0 means trim is twice as fast.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Acf_ailn_trim_speedrat => m_data.GetFloat("sim/aircraft/controls/acf_ailn_trim_speedrat");

        /// <summary>
        ///  This is the amount of aileron deflection (as a ratio of max) induced by the aerodynamic effect of static trim tabs.. Units:[-1..1]
        /// </summary>
        public IXPDataRef<float> Acf_ailn_tab => m_data.GetFloat("sim/aircraft/controls/acf_ailn_tab");

        /// <summary>
        ///  Maximum rudder left trim, expressed as a ratio of maximum rudder left travel. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_min_trim_rudd => m_data.GetFloat("sim/aircraft/controls/acf_min_trim_rudd");

        /// <summary>
        ///  Maximum rudder right trim, expressed as a ratio of maximum rudder right travel. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_max_trim_rudd => m_data.GetFloat("sim/aircraft/controls/acf_max_trim_rudd");

        /// <summary>
        ///  This is the speed of trim time, expressed as a ratio, where 1.0 means it takes 20 seconds to fully move trim from one extreme to the other.  2.0 means trim is twice as fast.. Units:ratio
        /// </summary>
        public IXPDataRef<float> Acf_rudd_trim_speedrat => m_data.GetFloat("sim/aircraft/controls/acf_rudd_trim_speedrat");

        /// <summary>
        ///  This is the amount of rudder deflection (as a ratio of max) induced by the aerodynamic effect of static trim tabs.. Units:[0..1]
        /// </summary>
        public IXPDataRef<float> Acf_rudd_tab => m_data.GetFloat("sim/aircraft/controls/acf_rudd_tab");

        /// <summary>
        ///  Enter 0.0 to be able to deflect the controls as fast as the pilot can move the stick or the art stab system can command a deflection. If the plane has a hydraulic system and a max rate of control deflection, though, enter how long it takes to go from center to fully-deflected.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_elev_def_time => m_data.GetFloat("sim/aircraft/controls/acf_elev_def_time");

        /// <summary>
        ///  Enter 0.0 to be able to deflect the controls as fast as the pilot can move the stick or the art stab system can command a deflection. If the plane has a hydraulic system and a max rate of control deflection, though, enter how long it takes to go from center to fully-deflected.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_ailn_def_time => m_data.GetFloat("sim/aircraft/controls/acf_ailn_def_time");

        /// <summary>
        ///  Enter 0.0 to be able to deflect the controls as fast as the pilot can move the stick or the art stab system can command a deflection. If the plane has a hydraulic system and a max rate of control deflection, though, enter how long it takes to go from center to fully-deflected.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_rudd_def_time => m_data.GetFloat("sim/aircraft/controls/acf_rudd_def_time");

        /// <summary>
        ///  This is the total time taken for the elevator trim to go from one extreme to the other.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_elev_trim_time => m_data.GetFloat("sim/aircraft/controls/acf_elev_trim_time");

        /// <summary>
        ///  This is the total time taken for the aileron trim to go from one extreme to the other.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_ailn_trim_time => m_data.GetFloat("sim/aircraft/controls/acf_ailn_trim_time");

        /// <summary>
        ///  This is the total time taken for the rudder trim to go from one extreme to the other.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_rudd_trim_time => m_data.GetFloat("sim/aircraft/controls/acf_rudd_trim_time");

        /// <summary>
        ///  Speedbrake time to extend.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_speedbrake_ext_time => m_data.GetFloat("sim/aircraft/controls/acf_speedbrake_ext_time");

        /// <summary>
        ///  Speedbrake time to retract.. Units:secs
        /// </summary>
        public IXPDataRef<float> Acf_speedbrake_ret_time => m_data.GetFloat("sim/aircraft/controls/acf_speedbrake_ret_time");
    }
}