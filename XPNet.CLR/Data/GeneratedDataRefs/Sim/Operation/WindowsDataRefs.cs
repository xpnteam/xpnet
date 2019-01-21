using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operation_windowsDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operation_windowsDataRefs(IXPlaneData data)
        {
            m_data = data;
        }

        /// <summary>
        ///  This is X-Plane's system native window as an int (either an HWND or WindowRef pre 102). Units:HWND
        ///  Raw path: sim/operation/windows/system_window
        /// </summary>
        public IXPDataRef<int> system_window { get { return m_data.GetInt("sim/operation/windows/system_window");} }

        /// <summary>
        ///  This is X-Plane's system native window as an array of two ints - low 32 bits first (either an HWND or WindowRef). Units:HWND
        ///  Raw path: sim/operation/windows/system_window_64
        /// </summary>
        public IXPDataRef<int[]> system_window_64 { get { return m_data.GetIntArray("sim/operation/windows/system_window_64");} }
    }
}