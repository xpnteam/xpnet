using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet
{
    public class SimDatarefs
    {
        private readonly XPlaneData m_data;

        internal SimDatarefs(XPlaneData data)
        {
            m_data = data;

            Cockpit = new CockpitDatarefs(data);
            Aircraft = new AircraftDatarefs(data);
        }

        public CockpitDatarefs Cockpit
        {
            get;
        }

        public AircraftDatarefs Aircraft
        {
            get;
        }

        public class AircraftDatarefs
        {
            private readonly XPlaneData m_data;

            internal AircraftDatarefs(XPlaneData data)
            {
                m_data = data;

                View = new ViewDatarefs(data);
            }

            public ViewDatarefs View
            {
                get;
            }

            public class ViewDatarefs
            {
                private readonly XPlaneData m_data;

                internal ViewDatarefs(XPlaneData data)
                {
                    m_data = data;
                }

                public IXPDataRef<string> TailNumber => m_data.GetString("sim/aircraft/view/acf_tailnum");
            }
        }

        public class CockpitDatarefs
        {
            private readonly XPlaneData m_data;

            internal CockpitDatarefs(XPlaneData data)
            {
                m_data = data;

                Engine = new EngineDatarefs(data);
            }

            public EngineDatarefs Engine
            {
                get;
            }

            public class EngineDatarefs
            {
                private readonly XPlaneData m_data;

                internal EngineDatarefs(XPlaneData data)
                {
                    m_data = data;
                }

                public IXPDataRef<bool[]> InverterOn => m_data.GetBoolArray("sim/cockpit/engine/inverter_on");
                public IXPDataRef<bool> InverterEq => m_data.GetBool("sim/cockpit/engine/inverter_eq");
                public IXPDataRef<bool[]> FuelPumpOn => m_data.GetBoolArray("sim/cockpit/engine/fuel_pump_on");
                public IXPDataRef<bool[]> FadecOn => m_data.GetBoolArray("sim/cockpit/engine/fadec_on");
                public IXPDataRef<bool[]> IdleSpeed => m_data.GetBoolArray("sim/cockpit/engine/idle_speed");
            }
        }
    }
}
