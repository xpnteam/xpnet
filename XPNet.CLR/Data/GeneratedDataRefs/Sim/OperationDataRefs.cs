using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operationDatarefs(IXPlaneData data)
        {
            m_data = data;
            failures = new sim_operation_failuresDatarefs(data);
            g430 = new sim_operation_g430Datarefs(data);
            misc = new sim_operation_miscDatarefs(data);
            override_ = new sim_operation_overrideDatarefs(data);
            prefs = new sim_operation_prefsDatarefs(data);
            sound = new sim_operation_soundDatarefs(data);
            windows = new sim_operation_windowsDatarefs(data);
        }
        public sim_operation_failuresDatarefs failures { get; }
        public sim_operation_g430Datarefs g430 { get; }
        public sim_operation_miscDatarefs misc { get; }
        public sim_operation_overrideDatarefs override_ { get; }
        public sim_operation_prefsDatarefs prefs { get; }
        public sim_operation_soundDatarefs sound { get; }
        public sim_operation_windowsDatarefs windows { get; }
    }
}