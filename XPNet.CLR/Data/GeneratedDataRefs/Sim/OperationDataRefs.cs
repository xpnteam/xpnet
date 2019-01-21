using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class sim_operationDataRefs
    {
        private readonly IXPlaneData m_data;

        internal sim_operationDataRefs(IXPlaneData data)
        {
            m_data = data;
            failures = new sim_operation_failuresDataRefs(data);
            g430 = new sim_operation_g430DataRefs(data);
            misc = new sim_operation_miscDataRefs(data);
            override_ = new sim_operation_overrideDataRefs(data);
            prefs = new sim_operation_prefsDataRefs(data);
            sound = new sim_operation_soundDataRefs(data);
            windows = new sim_operation_windowsDataRefs(data);
        }
        public sim_operation_failuresDataRefs failures { get; }
        public sim_operation_g430DataRefs g430 { get; }
        public sim_operation_miscDataRefs misc { get; }
        public sim_operation_overrideDataRefs override_ { get; }
        public sim_operation_prefsDataRefs prefs { get; }
        public sim_operation_soundDataRefs sound { get; }
        public sim_operation_windowsDataRefs windows { get; }
    }
}