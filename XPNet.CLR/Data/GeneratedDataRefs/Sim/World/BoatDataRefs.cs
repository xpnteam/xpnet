using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_World_BoatDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_World_BoatDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Velocity of the boat in meters per second in its current direction.  Index 0=carrier,1=frigate, writable using override_boats.. Units:meters/Sec
        /// </summary>
        public IXPDataRef<float[]> Velocity_msc => m_data.GetFloatArray("sim/world/boat/velocity_msc");

        /// <summary>
        ///  X Position of the boat in meters in the local coordinate OpenGL coordinate system. Index 0=carrier,1=frigate, writable using override_boats.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> X_mtr => m_data.GetFloatArray("sim/world/boat/x_mtr");

        /// <summary>
        ///  Y Position of the boat in meters in the local coordinate OpenGL coordinate system. Index 0=carrier,1=frigate, writable using override_boats.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Y_mtr => m_data.GetFloatArray("sim/world/boat/y_mtr");

        /// <summary>
        ///  Z Position of the boat in meters in the local coordinate OpenGL coordinate system. Index 0=carrier,1=frigate, writable using override_boats.. Units:meters
        /// </summary>
        public IXPDataRef<float[]> Z_mtr => m_data.GetFloatArray("sim/world/boat/z_mtr");

        /// <summary>
        ///  Heading of the boat in degrees from true north. Index 0=carrier,1=frigate, writable using override_boats.. Units:degrees(true)
        /// </summary>
        public IXPDataRef<float[]> Heading_deg => m_data.GetFloatArray("sim/world/boat/heading_deg");

        /// <summary>
        ///  Frequency at which the boat pitches up and down. Index 0=carrier,1=frigate, writable using override_boats.. Units:hz
        /// </summary>
        public IXPDataRef<float[]> Pitch_frequency_hz => m_data.GetFloatArray("sim/world/boat/pitch_frequency_hz");

        /// <summary>
        ///  Degrees that the boat pitches up for each meter of wave height. Index 0=carrier,1=frigate, writable using override_boats.. Units:deg/Meter
        /// </summary>
        public IXPDataRef<float[]> Pitch_amplitude_deg_mtr => m_data.GetFloatArray("sim/world/boat/pitch_amplitude_deg_mtr");

        /// <summary>
        ///  Frequency at which the boat rolls from side to side.  Index 0=carrier,1=frigate, writable using override_boats.. Units:hz
        /// </summary>
        public IXPDataRef<float[]> Roll_frequency_hz => m_data.GetFloatArray("sim/world/boat/roll_frequency_hz");

        /// <summary>
        ///  degrees that the boat rolls from side to side for each meter of wave height.  Index 0=carrier,1=frigate, writable using override_boats.. Units:deg/Meter
        /// </summary>
        public IXPDataRef<float[]> Roll_amplitude_deg_mtr => m_data.GetFloatArray("sim/world/boat/roll_amplitude_deg_mtr");

        /// <summary>
        ///  Deck height of the frigate (in coordinates of the OBJ model). Units:meters
        /// </summary>
        public IXPDataRef<float> Frigate_deck_height_mtr => m_data.GetFloat("sim/world/boat/frigate_deck_height_mtr");

        /// <summary>
        ///  X position of the frigate ILS transmitter (in coordinates of the OBJ model). Units:meters
        /// </summary>
        public IXPDataRef<float> Frigate_ILS_offset_x_mtr => m_data.GetFloat("sim/world/boat/frigate_ils_offset_x_mtr");

        /// <summary>
        ///  Z position of the frigate ILS transmitter (in coordinates of the OBJ model). Units:meters
        /// </summary>
        public IXPDataRef<float> Frigate_ILS_offset_z_mtr => m_data.GetFloat("sim/world/boat/frigate_ils_offset_z_mtr");

        /// <summary>
        ///  Deck height of the carrier (in coordinates of the OBJ model). Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_deck_height_mtr => m_data.GetFloat("sim/world/boat/carrier_deck_height_mtr");

        /// <summary>
        ///  X position of the carrier ILS transmitter (in coordinates of the OBJ model). Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_ILS_offset_x_mtr => m_data.GetFloat("sim/world/boat/carrier_ils_offset_x_mtr");

        /// <summary>
        ///  Z position of the carrier ILS transmitter (in coordinates of the OBJ model). Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_ILS_offset_z_mtr => m_data.GetFloat("sim/world/boat/carrier_ils_offset_z_mtr");

        /// <summary>
        ///  Relative heading of the approach path from the carrier's heading. Units:degrees(true)
        /// </summary>
        public IXPDataRef<float> Carrier_approach_heading => m_data.GetFloat("sim/world/boat/carrier_approach_heading");

        /// <summary>
        ///  Relative heading of the catshot relative to the carrier's heading. Units:degrees(true)
        /// </summary>
        public IXPDataRef<float> Carrier_catshot_heading => m_data.GetFloat("sim/world/boat/carrier_catshot_heading");

        /// <summary>
        ///  X position (in model coordinates) of the start of the cat-shot track. Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_catshot_start_x_mtr => m_data.GetFloat("sim/world/boat/carrier_catshot_start_x_mtr");

        /// <summary>
        ///  Z position (in model coordinates) of the start of the cat-shot track. Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_catshot_start_z_mtr => m_data.GetFloat("sim/world/boat/carrier_catshot_start_z_mtr");

        /// <summary>
        ///  X position (in model coordinates) of the end of the cat-shot track. Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_catshot_end_x_mtr => m_data.GetFloat("sim/world/boat/carrier_catshot_end_x_mtr");

        /// <summary>
        ///  Z position (in model coordinates) of the end of the cat-shot track. Units:meters
        /// </summary>
        public IXPDataRef<float> Carrier_catshot_end_z_mtr => m_data.GetFloat("sim/world/boat/carrier_catshot_end_z_mtr");
    }
}