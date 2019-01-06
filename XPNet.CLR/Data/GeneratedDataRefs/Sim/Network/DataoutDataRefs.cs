using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_network_dataoutDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_network_dataoutDatarefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  Enable data output of this data ref to internet
        /// </summary>
        public IXPDataRef<bool[]> data_to_internet { get { return m_data.GetBoolArray("sim/network/dataout/data_to_internet");} }

        /// <summary>
        ///  Enable data output of this data ref to disk file
        /// </summary>
        public IXPDataRef<bool[]> data_to_disk { get { return m_data.GetBoolArray("sim/network/dataout/data_to_disk");} }

        /// <summary>
        ///  Enable data output of this data ref to graph
        /// </summary>
        public IXPDataRef<bool[]> data_to_graph { get { return m_data.GetBoolArray("sim/network/dataout/data_to_graph");} }

        /// <summary>
        ///  Enable data output of this data ref to screen
        /// </summary>
        public IXPDataRef<bool[]> data_to_screen { get { return m_data.GetBoolArray("sim/network/dataout/data_to_screen");} }

        /// <summary>
        ///  Dump extra prop data to screen
        /// </summary>
        public IXPDataRef<bool> dump_parts_props { get { return m_data.GetBool("sim/network/dataout/dump_parts_props");} }

        /// <summary>
        ///  Dump wing prop data to screen
        /// </summary>
        public IXPDataRef<bool> dump_parts_wings { get { return m_data.GetBool("sim/network/dataout/dump_parts_wings");} }

        /// <summary>
        ///  Dump vertical stabilizer prop data to screen
        /// </summary>
        public IXPDataRef<bool> dump_parts_vstabs { get { return m_data.GetBool("sim/network/dataout/dump_parts_vstabs");} }

        /// <summary>
        ///  Is this machine running as an external visual for another X-Plane machine.
        /// </summary>
        public IXPDataRef<bool> is_external_visual { get { return m_data.GetBool("sim/network/dataout/is_external_visual");} }

        /// <summary>
        ///  Is this machine part of an x-plane built-in multiplayer session?
        /// </summary>
        public IXPDataRef<bool> is_multiplayer_session { get { return m_data.GetBool("sim/network/dataout/is_multiplayer_session");} }

        /// <summary>
        ///  Is this machine running in instructor-station mode?
        /// </summary>
        public IXPDataRef<bool> is_instructor_station { get { return m_data.GetBool("sim/network/dataout/is_instructor_station");} }

        /// <summary>
        ///  True if this remote visual tracks the master's view changes
        /// </summary>
        public IXPDataRef<bool[]> track_external_visual { get { return m_data.GetBoolArray("sim/network/dataout/track_external_visual");} }
    }
}