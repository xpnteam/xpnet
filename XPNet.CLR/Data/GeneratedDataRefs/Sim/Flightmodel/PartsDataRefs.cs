using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_flightmodel_partsDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_flightmodel_partsDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  [GEAR] x location of the Nth gear's wheel relative to the CG, airplane coordinates.  This doesn't take into account strut compression.  Writable in v8/9, read-only in v10.. Units:meters
        ///  Raw path: sim/flightmodel/parts/tire_x_no_deflection
        /// </summary>
        public IXPDataRef<float[]> tire_x_no_deflection { get { return m_data.GetFloatArray("sim/flightmodel/parts/tire_x_no_deflection");} }

        /// <summary>
        ///  [GEAR] y location of the Nth gear's wheel relative to the CG, airplane coordinates.  This doesn't take into account strut compression.  Writable in v8/9, read-only in v10.. Units:meters
        ///  Raw path: sim/flightmodel/parts/tire_y_no_deflection
        /// </summary>
        public IXPDataRef<float[]> tire_y_no_deflection { get { return m_data.GetFloatArray("sim/flightmodel/parts/tire_y_no_deflection");} }

        /// <summary>
        ///  [GEAR] z location of the Nth gear's wheel relative to the CG, airplane coordinates.  This doesn't take into account strut compression.  Writable in v8/9, read-only in v10.. Units:meters
        ///  Raw path: sim/flightmodel/parts/tire_z_no_deflection
        /// </summary>
        public IXPDataRef<float[]> tire_z_no_deflection { get { return m_data.GetFloatArray("sim/flightmodel/parts/tire_z_no_deflection");} }

        /// <summary>
        ///  [GEAR] This is amount the Nth gear is deflected upwards due to vehicle weight on struts.. Units:meters
        ///  Raw path: sim/flightmodel/parts/tire_vrt_def_veh
        /// </summary>
        public IXPDataRef<float[]> tire_vrt_def_veh { get { return m_data.GetFloatArray("sim/flightmodel/parts/tire_vrt_def_veh");} }

        /// <summary>
        ///  Steering command being sent to this gear, degrees positive right.  This takes into account steering algorithms for big planes like 747, but does not free castoring and springiness. Writable in 1030.  Override via override_wheel_steer. Units:degrees
        ///  Raw path: sim/flightmodel/parts/tire_steer_cmd
        /// </summary>
        public IXPDataRef<float[]> tire_steer_cmd { get { return m_data.GetFloatArray("sim/flightmodel/parts/tire_steer_cmd");} }

        /// <summary>
        ///  Steering command actually enacted by the gear, degrees positive right. Writable in 1030.  Override via override_wheel_steer. Units:degrees
        ///  Raw path: sim/flightmodel/parts/tire_steer_act
        /// </summary>
        public IXPDataRef<float[]> tire_steer_act { get { return m_data.GetFloatArray("sim/flightmodel/parts/tire_steer_act");} }

        /// <summary>
        ///  73 [WING] with flap setting, and then variation with pitch and roll input, on a 4 wing plane, with flaps on every wing, some going up and down with pitch input, we better find the flap def on each surface!. Units:degrees
        ///  Raw path: sim/flightmodel/parts/flap_def
        /// </summary>
        public IXPDataRef<float[]> flap_def { get { return m_data.GetFloatArray("sim/flightmodel/parts/flap_def");} }

        /// <summary>
        ///  56 [WING] with flap setting, and then variation with pitch and roll input, on a 4 wing plane, with flaps on every wing, some going up and down with pitch input, we better find the flap def on each surface!. Units:degrees
        ///  Raw path: sim/flightmodel/parts/flap2_def
        /// </summary>
        public IXPDataRef<float[]> flap2_def { get { return m_data.GetFloatArray("sim/flightmodel/parts/flap2_def");} }

        /// <summary>
        ///  73 [WING] different for each part since def may be positive on a canard and negative on an aft wing... ON THE SAME PLANE AT THE SAME TIME!. Units:degrees
        ///  Raw path: sim/flightmodel/parts/elev_cont_def
        /// </summary>
        public IXPDataRef<float[]> elev_cont_def { get { return m_data.GetFloatArray("sim/flightmodel/parts/elev_cont_def");} }

        /// <summary>
        ///  73 [WING] different for each part since def may be positive on a canard and negative on an aft wing... ON THE SAME PLANE AT THE SAME TIME!. Units:degrees
        ///  Raw path: sim/flightmodel/parts/elev_trim_def
        /// </summary>
        public IXPDataRef<float[]> elev_trim_def { get { return m_data.GetFloatArray("sim/flightmodel/parts/elev_trim_def");} }

        /// <summary>
        ///  73 [WING] different for each part since def may be positive on top vstab and neg on the bottom one.... ON THE SAME PLANE AT THE SAME TIME!. Units:degrees
        ///  Raw path: sim/flightmodel/parts/rudd_cont_def
        /// </summary>
        public IXPDataRef<float[]> rudd_cont_def { get { return m_data.GetFloatArray("sim/flightmodel/parts/rudd_cont_def");} }

        /// <summary>
        ///  56 [WING] different for each part since def may be positive on top vstab and neg on the bottom one.... ON THE SAME PLANE AT THE SAME TIME!. Units:degrees
        ///  Raw path: sim/flightmodel/parts/rudd2_cont_def
        /// </summary>
        public IXPDataRef<float[]> rudd2_cont_def { get { return m_data.GetFloatArray("sim/flightmodel/parts/rudd2_cont_def");} }

        /// <summary>
        ///  . Units:degrees
        ///  Raw path: sim/flightmodel/parts/elem_inc
        /// </summary>
        public IXPDataRef<float[]> elem_inc { get { return m_data.GetFloatArray("sim/flightmodel/parts/elem_inc");} }
    }
}