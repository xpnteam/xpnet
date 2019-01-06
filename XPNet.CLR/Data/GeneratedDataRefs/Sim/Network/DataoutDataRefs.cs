using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_Network_DataoutDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_Network_DataoutDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Enable data output of this data ref to internet
        /// </summary>
        public IXPDataRef<bool[]> Data_to_internet { get { return m_data.GetBoolArray("sim/network/dataout/data_to_internet");} }

        /// <summary>
        ///  Enable data output of this data ref to disk file
        /// </summary>
        public IXPDataRef<bool[]> Data_to_disk { get { return m_data.GetBoolArray("sim/network/dataout/data_to_disk");} }

        /// <summary>
        ///  Enable data output of this data ref to graph
        /// </summary>
        public IXPDataRef<bool[]> Data_to_graph { get { return m_data.GetBoolArray("sim/network/dataout/data_to_graph");} }

        /// <summary>
        ///  Enable data output of this data ref to screen
        /// </summary>
        public IXPDataRef<bool[]> Data_to_screen { get { return m_data.GetBoolArray("sim/network/dataout/data_to_screen");} }

        /// <summary>
        ///  Dump extra prop data to screen
        /// </summary>
        public IXPDataRef<bool> Dump_parts_props { get { return m_data.GetBool("sim/network/dataout/dump_parts_props");} }

        /// <summary>
        ///  Dump wing prop data to screen
        /// </summary>
        public IXPDataRef<bool> Dump_parts_wings { get { return m_data.GetBool("sim/network/dataout/dump_parts_wings");} }

        /// <summary>
        ///  Dump vertical stabilizer prop data to screen
        /// </summary>
        public IXPDataRef<bool> Dump_parts_vstabs { get { return m_data.GetBool("sim/network/dataout/dump_parts_vstabs");} }

        /// <summary>
        ///  Is this machine running as an external visual for another X-Plane machine.
        /// </summary>
        public IXPDataRef<bool> Is_external_visual { get { return m_data.GetBool("sim/network/dataout/is_external_visual");} }

        /// <summary>
        ///  Is this machine part of an x-plane built-in multiplayer session?
        /// </summary>
        public IXPDataRef<bool> Is_multiplayer_session { get { return m_data.GetBool("sim/network/dataout/is_multiplayer_session");} }

        /// <summary>
        ///  Is this machine running in instructor-station mode?
        /// </summary>
        public IXPDataRef<bool> Is_instructor_station { get { return m_data.GetBool("sim/network/dataout/is_instructor_station");} }

        /// <summary>
        ///  True if this remote visual tracks the master's view changes
        /// </summary>
        public IXPDataRef<bool[]> Track_external_visual { get { return m_data.GetBoolArray("sim/network/dataout/track_external_visual");} }
    }
}