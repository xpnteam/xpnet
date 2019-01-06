using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_cockpit2_iceDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_cockpit2_iceDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  De-ice - all systems. This is the master switch for the de-icing systems.
        /// </summary>
        public IXPDataRef<bool> ice_all_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_all_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - inlet heat. This switch turns on de-icing heat in the engine air inlet keep ice from choking your engine. Engine 1 only
        /// </summary>
        public IXPDataRef<bool> ice_inlet_heat_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_inlet_heat_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - prop heat. This switch turns on de-icing of the propeller(s) to keep ice from building up on your prop. Engine 1 only
        /// </summary>
        public IXPDataRef<bool> ice_prop_heat_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_prop_heat_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - inlet heat. This switch turns on de-icing heat in the engine air inlet keep ice from choking your engine.  Per engine
        /// </summary>
        public IXPDataRef<bool[]> ice_inlet_heat_on_per_engine { get { return m_data.GetBoolArray("sim/cockpit2/ice/ice_inlet_heat_on_per_engine");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - prop heat. This switch turns on de-icing of the propeller(s) to keep ice from building up on your prop.  Per engine
        /// </summary>
        public IXPDataRef<bool[]> ice_prop_heat_on_per_engine { get { return m_data.GetBoolArray("sim/cockpit2/ice/ice_prop_heat_on_per_engine");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - windshield heat. This switch turns on windshield de-icing to keep ice from blocking your vision.
        /// </summary>
        public IXPDataRef<bool> ice_window_heat_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_window_heat_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - pitot tube heat. This switch turns on de-icing heat in the pitot tube. If it freezes up your airspeed indicator and altimeter stop working. Airspeed and altitude related autopilot functions are also affected.
        /// </summary>
        public IXPDataRef<bool> ice_pitot_heat_on_pilot { get { return m_data.GetBool("sim/cockpit2/ice/ice_pitot_heat_on_pilot");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  Pitot tube heat, co-pilot. This switch turns on de-icing heat in the co-pilot side pitot tube. If it freezes up your airspeed indicator and altimeter stop working. Airspeed and altitude related autopilot functions are also affected.
        /// </summary>
        public IXPDataRef<bool> ice_pitot_heat_on_copilot { get { return m_data.GetBool("sim/cockpit2/ice/ice_pitot_heat_on_copilot");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  AOA sensor heat. This switch turns on de-icing heat for the AOA sensor. If it freezes up your AOA indicator stops working. AOA sensor failure will also affect the aircraft's artificial stability system if it has one.  Pilot.
        /// </summary>
        public IXPDataRef<bool> ice_AOA_heat_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_aoa_heat_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  AOA sensor heat. This switch turns on de-icing heat for the AOA sensor. If it freezes up your AOA indicator stops working. AOA sensor failure will also affect the aircraft's artificial stability system if it has one.  Copilot.
        /// </summary>
        public IXPDataRef<bool> ice_AOA_heat_on_copilot { get { return m_data.GetBool("sim/cockpit2/ice/ice_aoa_heat_on_copilot");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - bleed air. This switch directs warm air from the engines into the wing leading edges to keep them free of ice. (All wings)
        /// </summary>
        public IXPDataRef<bool> ice_surfce_heat_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_surfce_heat_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - bleed air. This switch directs warm air from the engines into the wing leading edges to keep them free of ice. (Left wing)
        /// </summary>
        public IXPDataRef<bool> ice_surfce_heat_left_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_surfce_heat_left_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - bleed air. This switch directs warm air from the engines into the wing leading edges to keep them free of ice. (Right wing)
        /// </summary>
        public IXPDataRef<bool> ice_surfce_heat_right_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_surfce_heat_right_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - pneumatic. This switch inflates flexible bladders on the wing leading edges to pop off accumulated ice.
        /// </summary>
        public IXPDataRef<bool> ice_surface_boot_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_surface_boot_on");} }

        /// <summary>
        ///  De-Ice ratio.  (Description needed)
        /// </summary>
        public IXPDataRef<float[]> anti_ice_engine_air { get { return m_data.GetFloatArray("sim/cockpit2/ice/anti_ice_engine_air");} }

        /// <summary>
        ///  De-Ice ratio.  (Description needed)
        /// </summary>
        public IXPDataRef<float[]> anti_ice_engine_air_b { get { return m_data.GetFloatArray("sim/cockpit2/ice/anti_ice_engine_air_b");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  De-ice - auto-ignition. This switch turns on a continuous ignition source in the engine to automatically relight it if there is a flameout.
        /// </summary>
        public IXPDataRef<bool> ice_auto_ignite_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_auto_ignite_on");} }

        /// <summary>
        ///  De-ice switch, 0 or 1.  Ice-detection: Turn this switch on to enable ice-detection... if the system detects ice, it will light up the ICE annunciator.
        /// </summary>
        public IXPDataRef<bool> ice_detect_on { get { return m_data.GetBool("sim/cockpit2/ice/ice_detect_on");} }
    }
}