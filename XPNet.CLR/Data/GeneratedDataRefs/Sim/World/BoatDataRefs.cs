using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_world_boatDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_world_boatDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Velocity of the boat in meters per second in its current direction.  Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> velocity_msc { get { return m_data.GetFloatArray("sim/world/boat/velocity_msc");} }

        /// <summary>
        ///  X Position of the boat in meters in the local coordinate OpenGL coordinate system. Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> x_mtr { get { return m_data.GetFloatArray("sim/world/boat/x_mtr");} }

        /// <summary>
        ///  Y Position of the boat in meters in the local coordinate OpenGL coordinate system. Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> y_mtr { get { return m_data.GetFloatArray("sim/world/boat/y_mtr");} }

        /// <summary>
        ///  Z Position of the boat in meters in the local coordinate OpenGL coordinate system. Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> z_mtr { get { return m_data.GetFloatArray("sim/world/boat/z_mtr");} }

        /// <summary>
        ///  Heading of the boat in degrees from true north. Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> heading_deg { get { return m_data.GetFloatArray("sim/world/boat/heading_deg");} }

        /// <summary>
        ///  Frequency at which the boat pitches up and down. Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> pitch_frequency_hz { get { return m_data.GetFloatArray("sim/world/boat/pitch_frequency_hz");} }

        /// <summary>
        ///  Degrees that the boat pitches up for each meter of wave height. Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> pitch_amplitude_deg_mtr { get { return m_data.GetFloatArray("sim/world/boat/pitch_amplitude_deg_mtr");} }

        /// <summary>
        ///  Frequency at which the boat rolls from side to side.  Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> roll_frequency_hz { get { return m_data.GetFloatArray("sim/world/boat/roll_frequency_hz");} }

        /// <summary>
        ///  degrees that the boat rolls from side to side for each meter of wave height.  Index 0=carrier,1=frigate, writable using override_boats.
        /// </summary>
        public IXPDataRef<float[]> roll_amplitude_deg_mtr { get { return m_data.GetFloatArray("sim/world/boat/roll_amplitude_deg_mtr");} }

        /// <summary>
        ///  Deck height of the frigate (in coordinates of the OBJ model)
        /// </summary>
        public IXPDataRef<float> frigate_deck_height_mtr { get { return m_data.GetFloat("sim/world/boat/frigate_deck_height_mtr");} }

        /// <summary>
        ///  X position of the frigate ILS transmitter (in coordinates of the OBJ model)
        /// </summary>
        public IXPDataRef<float> frigate_ILS_offset_x_mtr { get { return m_data.GetFloat("sim/world/boat/frigate_ils_offset_x_mtr");} }

        /// <summary>
        ///  Z position of the frigate ILS transmitter (in coordinates of the OBJ model)
        /// </summary>
        public IXPDataRef<float> frigate_ILS_offset_z_mtr { get { return m_data.GetFloat("sim/world/boat/frigate_ils_offset_z_mtr");} }

        /// <summary>
        ///  Deck height of the carrier (in coordinates of the OBJ model)
        /// </summary>
        public IXPDataRef<float> carrier_deck_height_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_deck_height_mtr");} }

        /// <summary>
        ///  X position of the carrier ILS transmitter (in coordinates of the OBJ model)
        /// </summary>
        public IXPDataRef<float> carrier_ILS_offset_x_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_ils_offset_x_mtr");} }

        /// <summary>
        ///  Z position of the carrier ILS transmitter (in coordinates of the OBJ model)
        /// </summary>
        public IXPDataRef<float> carrier_ILS_offset_z_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_ils_offset_z_mtr");} }

        /// <summary>
        ///  Relative heading of the approach path from the carrier's heading
        /// </summary>
        public IXPDataRef<float> carrier_approach_heading { get { return m_data.GetFloat("sim/world/boat/carrier_approach_heading");} }

        /// <summary>
        ///  Relative heading of the catshot relative to the carrier's heading
        /// </summary>
        public IXPDataRef<float> carrier_catshot_heading { get { return m_data.GetFloat("sim/world/boat/carrier_catshot_heading");} }

        /// <summary>
        ///  X position (in model coordinates) of the start of the cat-shot track
        /// </summary>
        public IXPDataRef<float> carrier_catshot_start_x_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_catshot_start_x_mtr");} }

        /// <summary>
        ///  Z position (in model coordinates) of the start of the cat-shot track
        /// </summary>
        public IXPDataRef<float> carrier_catshot_start_z_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_catshot_start_z_mtr");} }

        /// <summary>
        ///  X position (in model coordinates) of the end of the cat-shot track
        /// </summary>
        public IXPDataRef<float> carrier_catshot_end_x_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_catshot_end_x_mtr");} }

        /// <summary>
        ///  Z position (in model coordinates) of the end of the cat-shot track
        /// </summary>
        public IXPDataRef<float> carrier_catshot_end_z_mtr { get { return m_data.GetFloat("sim/world/boat/carrier_catshot_end_z_mtr");} }

        /// <summary>
        ///  0=no cat shot set up,1=cat shot waiting to launch,2=in progress
        /// </summary>
        public IXPDataRef<int> carrier_catshot_status { get { return m_data.GetInt("sim/world/boat/carrier_catshot_status");} }
    }
}