using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Operation_SoundDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Operation_SoundDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Exterior_volume_ratio => m_data.GetFloat("sim/operation/sound/exterior_volume_ratio");

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Interior_volume_ratio => m_data.GetFloat("sim/operation/sound/interior_volume_ratio");

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Copilot_volume_ratio => m_data.GetFloat("sim/operation/sound/copilot_volume_ratio");

        /// <summary>
        ///  Volume level for the com radios, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Radio_volume_ratio => m_data.GetFloat("sim/operation/sound/radio_volume_ratio");

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Enviro_volume_ratio => m_data.GetFloat("sim/operation/sound/enviro_volume_ratio");

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Ui_volume_ratio => m_data.GetFloat("sim/operation/sound/ui_volume_ratio");

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Engine_volume_ratio => m_data.GetFloat("sim/operation/sound/engine_volume_ratio");

        /// <summary>
        ///  Volume level for propeller sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Prop_volume_ratio => m_data.GetFloat("sim/operation/sound/prop_volume_ratio");

        /// <summary>
        ///  Volume level for ground contact effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Ground_volume_ratio => m_data.GetFloat("sim/operation/sound/ground_volume_ratio");

        /// <summary>
        ///  Volume level for weather sound effects, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Weather_volume_ratio => m_data.GetFloat("sim/operation/sound/weather_volume_ratio");

        /// <summary>
        ///  Volume level for warning systems, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Warning_volume_ratio => m_data.GetFloat("sim/operation/sound/warning_volume_ratio");

        /// <summary>
        ///  Volume level for the avionics fan, ratio from 0 (silent) to 1 (max loudness). Units:0-1
        /// </summary>
        public IXPDataRef<float> Fan_volume_ratio => m_data.GetFloat("sim/operation/sound/fan_volume_ratio");

        /// <summary>
        ///  1 if we are in this space, 0 if outside, and a fraction as we transition through the borer region. Units:0-1
        /// </summary>
        public IXPDataRef<float[]> Inside_ratio => m_data.GetFloatArray("sim/operation/sound/inside_ratio");
    }
}