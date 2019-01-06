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
        ///  Does this machine have sound hardware that X-Plane understands?
        /// </summary>
        public IXPDataRef<bool> Has_sound { get { return m_data.GetBool("sim/operation/sound/has_sound");} }

        /// <summary>
        ///  Does this machine have speech synth capabilities?
        /// </summary>
        public IXPDataRef<bool> Has_speech_synth { get { return m_data.GetBool("sim/operation/sound/has_speech_synth");} }

        /// <summary>
        ///  Is sound on (set by user)
        /// </summary>
        public IXPDataRef<bool> Sound_on { get { return m_data.GetBool("sim/operation/sound/sound_on");} }

        /// <summary>
        ///  Is speech synth on (set by user)
        /// </summary>
        public IXPDataRef<bool> Speech_on { get { return m_data.GetBool("sim/operation/sound/speech_on");} }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Exterior_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/exterior_volume_ratio");} }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Interior_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/interior_volume_ratio");} }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Copilot_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/copilot_volume_ratio");} }

        /// <summary>
        ///  Volume level for the com radios, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Radio_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/radio_volume_ratio");} }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Enviro_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/enviro_volume_ratio");} }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Ui_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/ui_volume_ratio");} }

        /// <summary>
        ///  Volume level for engine sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Engine_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/engine_volume_ratio");} }

        /// <summary>
        ///  Volume level for propeller sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Prop_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/prop_volume_ratio");} }

        /// <summary>
        ///  Volume level for ground contact effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Ground_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/ground_volume_ratio");} }

        /// <summary>
        ///  Volume level for weather sound effects, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Weather_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/weather_volume_ratio");} }

        /// <summary>
        ///  Volume level for warning systems, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Warning_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/warning_volume_ratio");} }

        /// <summary>
        ///  Volume level for the avionics fan, ratio from 0 (silent) to 1 (max loudness)
        /// </summary>
        public IXPDataRef<float> Fan_volume_ratio { get { return m_data.GetFloat("sim/operation/sound/fan_volume_ratio");} }

        /// <summary>
        ///  1 if we are in this space, 0 if outside, and a fraction as we transition through the borer region
        /// </summary>
        public IXPDataRef<float[]> Inside_ratio { get { return m_data.GetFloatArray("sim/operation/sound/inside_ratio");} }
    }
}