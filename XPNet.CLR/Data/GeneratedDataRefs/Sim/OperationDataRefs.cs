using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class Sim_OperationDatarefs
    {
        private readonly IXPlaneData m_data;

        internal Sim_OperationDatarefs(IXPlaneData data)
        {
            m_data = data;
            Failures = new Sim_Operation_FailuresDatarefs(data);
            G430 = new Sim_Operation_G430Datarefs(data);
            Misc = new Sim_Operation_MiscDatarefs(data);
            Override = new Sim_Operation_OverrideDatarefs(data);
            Prefs = new Sim_Operation_PrefsDatarefs(data);
            Sound = new Sim_Operation_SoundDatarefs(data);
            Windows = new Sim_Operation_WindowsDatarefs(data);
        }
        public Sim_Operation_FailuresDatarefs Failures { get; }
        public Sim_Operation_G430Datarefs G430 { get; }
        public Sim_Operation_MiscDatarefs Misc { get; }
        public Sim_Operation_OverrideDatarefs Override { get; }
        public Sim_Operation_PrefsDatarefs Prefs { get; }
        public Sim_Operation_SoundDatarefs Sound { get; }
        public Sim_Operation_WindowsDatarefs Windows { get; }
    }
}