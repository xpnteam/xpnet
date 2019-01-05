using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Multiplayer_PositionDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Multiplayer_PositionDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Plane 1 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane1_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_beacon_lights_on");

        /// <summary>
        ///  Plane 1 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane1_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_landing_lights_on");

        /// <summary>
        ///  Plane 1 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane1_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_nav_lights_on");

        /// <summary>
        ///  Plane 1 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane1_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane1_strobe_lights_on");

        /// <summary>
        ///  Plane 1 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane1_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane1_taxi_light_on");

        /// <summary>
        ///  Plane 2 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane2_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_beacon_lights_on");

        /// <summary>
        ///  Plane 2 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane2_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_landing_lights_on");

        /// <summary>
        ///  Plane 2 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane2_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_nav_lights_on");

        /// <summary>
        ///  Plane 2 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane2_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane2_strobe_lights_on");

        /// <summary>
        ///  Plane 2 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane2_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane2_taxi_light_on");

        /// <summary>
        ///  Plane 3 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane3_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_beacon_lights_on");

        /// <summary>
        ///  Plane 3 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane3_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_landing_lights_on");

        /// <summary>
        ///  Plane 3 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane3_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_nav_lights_on");

        /// <summary>
        ///  Plane 3 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane3_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane3_strobe_lights_on");

        /// <summary>
        ///  Plane 3 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane3_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane3_taxi_light_on");

        /// <summary>
        ///  Plane 4 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane4_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_beacon_lights_on");

        /// <summary>
        ///  Plane 4 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane4_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_landing_lights_on");

        /// <summary>
        ///  Plane 4 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane4_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_nav_lights_on");

        /// <summary>
        ///  Plane 4 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane4_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane4_strobe_lights_on");

        /// <summary>
        ///  Plane 4 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane4_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane4_taxi_light_on");

        /// <summary>
        ///  Plane 5 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane5_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_beacon_lights_on");

        /// <summary>
        ///  Plane 5 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane5_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_landing_lights_on");

        /// <summary>
        ///  Plane 5 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane5_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_nav_lights_on");

        /// <summary>
        ///  Plane 5 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane5_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane5_strobe_lights_on");

        /// <summary>
        ///  Plane 5 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane5_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane5_taxi_light_on");

        /// <summary>
        ///  Plane 6 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane6_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_beacon_lights_on");

        /// <summary>
        ///  Plane 6 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane6_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_landing_lights_on");

        /// <summary>
        ///  Plane 6 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane6_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_nav_lights_on");

        /// <summary>
        ///  Plane 6 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane6_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane6_strobe_lights_on");

        /// <summary>
        ///  Plane 6 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane6_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane6_taxi_light_on");

        /// <summary>
        ///  Plane 7 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane7_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_beacon_lights_on");

        /// <summary>
        ///  Plane 7 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane7_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_landing_lights_on");

        /// <summary>
        ///  Plane 7 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane7_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_nav_lights_on");

        /// <summary>
        ///  Plane 7 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane7_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane7_strobe_lights_on");

        /// <summary>
        ///  Plane 7 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane7_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane7_taxi_light_on");

        /// <summary>
        ///  Plane 8 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane8_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_beacon_lights_on");

        /// <summary>
        ///  Plane 8 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane8_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_landing_lights_on");

        /// <summary>
        ///  Plane 8 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane8_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_nav_lights_on");

        /// <summary>
        ///  Plane 8 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane8_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane8_strobe_lights_on");

        /// <summary>
        ///  Plane 8 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane8_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane8_taxi_light_on");

        /// <summary>
        ///  Plane 9 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane9_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_beacon_lights_on");

        /// <summary>
        ///  Plane 9 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane9_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_landing_lights_on");

        /// <summary>
        ///  Plane 9 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane9_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_nav_lights_on");

        /// <summary>
        ///  Plane 9 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane9_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane9_strobe_lights_on");

        /// <summary>
        ///  Plane 9 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane9_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane9_taxi_light_on");

        /// <summary>
        ///  Plane 10 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane10_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_beacon_lights_on");

        /// <summary>
        ///  Plane 10 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane10_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_landing_lights_on");

        /// <summary>
        ///  Plane 10 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane10_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_nav_lights_on");

        /// <summary>
        ///  Plane 10 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane10_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane10_strobe_lights_on");

        /// <summary>
        ///  Plane 10 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane10_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane10_taxi_light_on");

        /// <summary>
        ///  Plane 11 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane11_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_beacon_lights_on");

        /// <summary>
        ///  Plane 11 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane11_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_landing_lights_on");

        /// <summary>
        ///  Plane 11 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane11_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_nav_lights_on");

        /// <summary>
        ///  Plane 11 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane11_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane11_strobe_lights_on");

        /// <summary>
        ///  Plane 11 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane11_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane11_taxi_light_on");

        /// <summary>
        ///  Plane 12 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane12_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_beacon_lights_on");

        /// <summary>
        ///  Plane 12 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane12_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_landing_lights_on");

        /// <summary>
        ///  Plane 12 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane12_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_nav_lights_on");

        /// <summary>
        ///  Plane 12 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane12_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane12_strobe_lights_on");

        /// <summary>
        ///  Plane 12 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane12_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane12_taxi_light_on");

        /// <summary>
        ///  Plane 13 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane13_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_beacon_lights_on");

        /// <summary>
        ///  Plane 13 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane13_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_landing_lights_on");

        /// <summary>
        ///  Plane 13 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane13_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_nav_lights_on");

        /// <summary>
        ///  Plane 13 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane13_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane13_strobe_lights_on");

        /// <summary>
        ///  Plane 13 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane13_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane13_taxi_light_on");

        /// <summary>
        ///  Plane 14 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane14_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_beacon_lights_on");

        /// <summary>
        ///  Plane 14 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane14_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_landing_lights_on");

        /// <summary>
        ///  Plane 14 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane14_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_nav_lights_on");

        /// <summary>
        ///  Plane 14 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane14_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane14_strobe_lights_on");

        /// <summary>
        ///  Plane 14 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane14_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane14_taxi_light_on");

        /// <summary>
        ///  Plane 15 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane15_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_beacon_lights_on");

        /// <summary>
        ///  Plane 15 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane15_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_landing_lights_on");

        /// <summary>
        ///  Plane 15 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane15_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_nav_lights_on");

        /// <summary>
        ///  Plane 15 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane15_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane15_strobe_lights_on");

        /// <summary>
        ///  Plane 15 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane15_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane15_taxi_light_on");

        /// <summary>
        ///  Plane 16 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane16_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_beacon_lights_on");

        /// <summary>
        ///  Plane 16 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane16_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_landing_lights_on");

        /// <summary>
        ///  Plane 16 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane16_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_nav_lights_on");

        /// <summary>
        ///  Plane 16 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane16_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane16_strobe_lights_on");

        /// <summary>
        ///  Plane 16 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane16_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane16_taxi_light_on");

        /// <summary>
        ///  Plane 17 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane17_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_beacon_lights_on");

        /// <summary>
        ///  Plane 17 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane17_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_landing_lights_on");

        /// <summary>
        ///  Plane 17 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane17_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_nav_lights_on");

        /// <summary>
        ///  Plane 17 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane17_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane17_strobe_lights_on");

        /// <summary>
        ///  Plane 17 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane17_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane17_taxi_light_on");

        /// <summary>
        ///  Plane 18 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane18_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_beacon_lights_on");

        /// <summary>
        ///  Plane 18 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane18_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_landing_lights_on");

        /// <summary>
        ///  Plane 18 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane18_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_nav_lights_on");

        /// <summary>
        ///  Plane 18 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane18_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane18_strobe_lights_on");

        /// <summary>
        ///  Plane 18 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane18_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane18_taxi_light_on");

        /// <summary>
        ///  Plane 19 Beacon Light
        /// </summary>
        public IXPDataRef<bool> Plane19_beacon_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_beacon_lights_on");

        /// <summary>
        ///  Plane 19 Landing Light
        /// </summary>
        public IXPDataRef<bool> Plane19_landing_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_landing_lights_on");

        /// <summary>
        ///  Plane 19 Navigation Light
        /// </summary>
        public IXPDataRef<bool> Plane19_nav_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_nav_lights_on");

        /// <summary>
        ///  Plane 19 Strobe Light
        /// </summary>
        public IXPDataRef<bool> Plane19_strobe_lights_on => m_data.GetBool("sim/multiplayer/position/plane19_strobe_lights_on");

        /// <summary>
        ///  Plane 19 Taxi Lights
        /// </summary>
        public IXPDataRef<bool> Plane19_taxi_light_on => m_data.GetBool("sim/multiplayer/position/plane19_taxi_light_on");
    }
}