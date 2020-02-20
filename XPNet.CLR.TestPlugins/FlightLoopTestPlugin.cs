
using System;

namespace XPNet.CLR.TestPlugins
{
    [XPlanePlugin(nameof(FlightLoopTestPlugin), "xpnet.plugins.test." + nameof(FlightLoopTestPlugin), description: "unit test plugin")]
    public class FlightLoopTestPlugin : TestPluginBase
    {
        private readonly IXPFlightLoopHook m_flightLoopHook;

        public FlightLoopTestPlugin(IXPlaneApi api)
            : base(api)
        {
            m_flightLoopHook = Api.Processing.RegisterFlightLoopHook(
                FlightLoopTime.FromSeconds(1.0f), OnFlightLoopHook
            );
        }

        public override void Dispose()
        {
            m_flightLoopHook.Dispose();

            base.Dispose();
        }

        private FlightLoopTime OnFlightLoopHook(TimeSpan elapsedTimeSinceLastCall, TimeSpan elapsedTimeSinceLastFlightLoop, int counter)
        {
            Api.Data.GetFloat(TestData.Name("fl/elapsedTimeSinceLastCall")).Value = (float)elapsedTimeSinceLastCall.TotalSeconds;
            Api.Data.GetFloat(TestData.Name("fl/elapsedTimeSinceLastFlightLoop")).Value = (float)elapsedTimeSinceLastFlightLoop.TotalSeconds;
            Api.Data.GetInt(TestData.Name("fl/counter")).Value = counter;

            return FlightLoopTime.FromSeconds(1.0f);
        }
    }
}
