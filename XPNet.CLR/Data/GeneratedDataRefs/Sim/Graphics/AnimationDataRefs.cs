using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Graphics_AnimationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Graphics_AnimationDatarefs(IXPlaneData data)
        {
            m_data = data;
            Birds = new Sim_Graphics_Animation_BirdsDatarefs(data);
            Deer = new Sim_Graphics_Animation_DeerDatarefs(data);
            Lights = new Sim_Graphics_Animation_LightsDatarefs(data);
            Ground_traffic = new Sim_Graphics_Animation_Ground_trafficDatarefs(data);
        }
        public Sim_Graphics_Animation_BirdsDatarefs Birds { get; }
        public Sim_Graphics_Animation_DeerDatarefs Deer { get; }
        public Sim_Graphics_Animation_LightsDatarefs Lights { get; }
        public Sim_Graphics_Animation_Ground_trafficDatarefs Ground_traffic { get; }

        /// <summary>
        ///  X position in cartesian space of currently drawn object. Units:float
        /// </summary>
        public IXPDataRef<float> Draw_object_x => m_data.GetFloat("sim/graphics/animation/draw_object_x");

        /// <summary>
        ///  Y position in cartesian space of currently drawn object. Units:float
        /// </summary>
        public IXPDataRef<float> Draw_object_y => m_data.GetFloat("sim/graphics/animation/draw_object_y");

        /// <summary>
        ///  Z position in cartesian space of currently drawn object. Units:float
        /// </summary>
        public IXPDataRef<float> Draw_object_z => m_data.GetFloat("sim/graphics/animation/draw_object_z");

        /// <summary>
        ///  rotation in cartesian space of currently drawn object. Units:float
        /// </summary>
        public IXPDataRef<float> Draw_object_psi => m_data.GetFloat("sim/graphics/animation/draw_object_psi");

        /// <summary>
        ///  This is the default _LIT light level that the object is being drawn at, before ATTR_light_level is applied.. Units:float
        /// </summary>
        public IXPDataRef<float> Draw_light_level => m_data.GetFloat("sim/graphics/animation/draw_light_level");

        /// <summary>
        ///  angle this beacon is rotating (0-360). Units:degrees
        /// </summary>
        public IXPDataRef<float> Airport_beacon_rotation => m_data.GetFloat("sim/graphics/animation/airport_beacon_rotation");

        /// <summary>
        ///  windsock heading. Units:degrees
        /// </summary>
        public IXPDataRef<float> Windsock_psi => m_data.GetFloat("sim/graphics/animation/windsock_psi");

        /// <summary>
        ///  windsock pitch. Units:degrees
        /// </summary>
        public IXPDataRef<float> Windsock_the => m_data.GetFloat("sim/graphics/animation/windsock_the");

        /// <summary>
        ///  windsock roll. Units:degrees
        /// </summary>
        public IXPDataRef<float> Windsock_phi => m_data.GetFloat("sim/graphics/animation/windsock_phi");

        /// <summary>
        ///  crane heading. Units:ratio
        /// </summary>
        public IXPDataRef<float> Crane_psi => m_data.GetFloat("sim/graphics/animation/crane_psi");

        /// <summary>
        ///  how high above MSL 0 is this buoy riding?. Units:meters
        /// </summary>
        public IXPDataRef<float> Buoy_height => m_data.GetFloat("sim/graphics/animation/buoy_height");

        /// <summary>
        ///  -1 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Ping_pong_2 => m_data.GetFloat("sim/graphics/animation/ping_pong_2");

        /// <summary>
        ///  -1 to 1. Units:ratio
        /// </summary>
        public IXPDataRef<float> Sin_wave_2 => m_data.GetFloat("sim/graphics/animation/sin_wave_2");

        /// <summary>
        ///  Brightness of the wig-wag lights - stays in sync with sim/Graphics/Animation/Lights/Wigwag. Units:ratio
        /// </summary>
        public IXPDataRef<float> Obj_wigwag_brightness => m_data.GetFloat("sim/graphics/animation/obj_wigwag_brightness");

        /// <summary>
        ///  Ratio of deployment of carrier blast door (left front). Units:ratio
        /// </summary>
        public IXPDataRef<float> Carrier_blast_def_lf => m_data.GetFloat("sim/graphics/animation/carrier_blast_def_lf");

        /// <summary>
        ///  Ratio of deployment of carrier blast door (right front). Units:ratio
        /// </summary>
        public IXPDataRef<float> Carrier_blast_def_rf => m_data.GetFloat("sim/graphics/animation/carrier_blast_def_rf");

        /// <summary>
        ///  Ratio of deployment of carrier blast door (left rear). Units:ratio
        /// </summary>
        public IXPDataRef<float> Carrier_blast_def_lr => m_data.GetFloat("sim/graphics/animation/carrier_blast_def_lr");

        /// <summary>
        ///  Ratio of deployment of carrier blast door (right rear). Units:ratio
        /// </summary>
        public IXPDataRef<float> Carrier_blast_def_rr => m_data.GetFloat("sim/graphics/animation/carrier_blast_def_rr");

        /// <summary>
        ///  Ratio of the position of all level crossing gates, 0 is up, 1 is down. Units:ratio
        /// </summary>
        public IXPDataRef<float> Level_crossing_gate => m_data.GetFloat("sim/graphics/animation/level_crossing_gate");
    }
}