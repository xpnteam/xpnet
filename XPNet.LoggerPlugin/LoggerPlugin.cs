
using System;
using System.Collections.Generic;
using System.Linq;

namespace XPNet
{
    [XPlanePlugin(
        name: "LoggerPlugin",
        signature: "qbaum.plugins.logger",
        description: "Logs various X-Plane events."
    )]
    public class LoggerPlugin : IXPlanePlugin
    {
        private readonly IXPlaneApi m_api;
        private readonly IXPFlightLoopHook m_flightLoopHook;

        private const int XPNET_MSG_PLUGIN_IDENT = (0x8000000 | 0x01);
        private const int XPNET_MSG_PLUGIN_CMDTEST_BEGIN = (0x8000000 | 0x02);
        private const int XPNET_MSG_PLUGIN_CMDTEST_END = (0x8000000 | 0x03);
        private const int XPNET_MSG_PLUGIN_CMDTEST_ONCE = (0x8000000 | 0x04);

        private readonly List<Action> m_datarefLoggers = new List<Action>();

        public LoggerPlugin(IXPlaneApi api)
        {
            m_api = api ?? throw new ArgumentNullException("api");

            m_api.Log.Log("LoggerPlugin: Started");

            m_api.ConfigChanged += OnConfigurationChanged;

            m_api.Messages.MessageReceived += Messages_MessageReceived;
            m_api.Messages.PlaneCrashed += Messages_PlaneCrashed;
            m_api.Messages.PlaneLoaded += Messages_PlaneLoaded;

            m_flightLoopHook = m_api.Processing.RegisterFlightLoopHook(
                FlightLoopTime.FromSeconds(1.0f), OnFlightLoopHook
            );

            ReloadDataRefs();
        }

        public void Enable()
        {
            m_api.Log.Log("LoggerPlugin: Enabled");
        }

        public void Disable()
        {
            m_api.Log.Log("LoggerPlugin: Disabled");
        }

        public void Dispose()
        {
            m_flightLoopHook.Dispose();

            m_api.Messages.MessageReceived -= Messages_MessageReceived;
            m_api.Messages.PlaneCrashed -= Messages_PlaneCrashed;
            m_api.Messages.PlaneLoaded -= Messages_PlaneLoaded;

            m_api.ConfigChanged -= OnConfigurationChanged;

            m_api.Log.Log("LoggerPlugin: Stopped");
        }

        private void OnConfigurationChanged(object sender, EventArgs e)
        {
            ReloadDataRefs();
        }

        private void Messages_MessageReceived(object sender, XPMessageEventArgs e)
        {
            switch (e.MessageId)
            {
                case XPNET_MSG_PLUGIN_IDENT:
                    m_api.Log.Log("LoggerPlugin: IDENT");
                    break;

                    // TODO: The rest of what's in this plugin is generally useful, but this command stuff is
                    // really just specific to the test harness.  It could also be made generally
                    // useful I guess - we could define in the logger config file some way to identify
                    // that a given (set of) command(s) should be invoked any time that some signal is
                    // received, like say a custom message.  That's pushing the edge of the definition
                    // of "generally useful", but it would at least be better than hardcoded commands
                    // here.
                    //
                    // NOTE: See the TODO above - for test purposes, we don't cache the result of
                    // GetCommand the way we normally would/should.

                case XPNET_MSG_PLUGIN_CMDTEST_BEGIN:
                    {
                        var cmd = m_api.Commands.GetCommand("sim/autopilot/heading_up");
                        cmd.Begin();
                        break;
                    }

                case XPNET_MSG_PLUGIN_CMDTEST_END:
                    {
                        // NOTE: See the TODO above - for test purposes, we don't cache the result of
                        // GetCommand the way we normally would/should.
                        var cmd = m_api.Commands.GetCommand("sim/autopilot/heading_up");
                        cmd.End();
                        break;
                    }

                case XPNET_MSG_PLUGIN_CMDTEST_ONCE:
                    {
                        // NOTE: See the TODO above - for test purposes, we don't cache the result of
                        // GetCommand the way we normally would/should.
                        var cmd = m_api.Commands.GetCommand("sim/autopilot/heading_up");
                        cmd.InvokeOnce();
                        break;
                    }

                default:
                    // Nothing to do.
                    break;
            }
        }

        private void Messages_PlaneLoaded(object sender, XPPlaneMessageEventArgs e)
        {
            Log(nameof(IXPlaneMessages.PlaneLoaded), e);
        }

        private void Messages_PlaneCrashed(object sender, XPMessageEventArgs e)
        {
            Log(nameof(IXPlaneMessages.PlaneCrashed), e);
        }

        private void ReloadDataRefs()
        {
            m_datarefLoggers.Clear();

            LoadDataRefs<int>("XPNetLogger:IntData", (s) => m_api.Data.GetInt(s));
            LoadDataRefs<int[]>("XPNetLogger:IntArrayData", (s) => m_api.Data.GetIntArray(s));
            LoadDataRefs<bool>("XPNetLogger:BoolData", (s) => m_api.Data.GetBool(s));
            LoadDataRefs<bool[]>("XPNetLogger:BoolArrayData", (s) => m_api.Data.GetBoolArray(s));
            LoadDataRefs<float>("XPNetLogger:FloatData", (s) => m_api.Data.GetFloat(s));
            LoadDataRefs<float[]>("XPNetLogger:FloatArrayData", (s) => m_api.Data.GetFloatArray(s));
            LoadDataRefs<double>("XPNetLogger:DoubleData", (s) => m_api.Data.GetDouble(s));
            LoadDataRefs<string>("XPNetLogger:StringData", (s) => m_api.Data.GetString(s));
            LoadDataRefs<byte[]>("XPNetLogger:ByteArrayData", (s) => m_api.Data.GetByteArray(s));
        }

        private void LoadDataRefs<T>(string sectionName, Func<string, IXPDataRef> dataRefFactory)
        {
            var refs = m_api.Config.GetSection(sectionName).GetChildren().Select(x => x.Value).ToArray();
            m_datarefLoggers.AddRange(refs.Select(dataRefFactory).Select(CreateLogger));
        }

        private FlightLoopTime OnFlightLoopHook(TimeSpan elapsedTimeSinceLastCall, TimeSpan elapsedTimeSinceLastFlightLoop, int counter)
        {
            m_api.Log.Log($"LoggerPlugin: Hook(Now = {DateTime.Now.ToString("T")}, SinceLastCall = {elapsedTimeSinceLastCall.TotalSeconds}s, SinceLastLoop = {elapsedTimeSinceLastFlightLoop}s, Counter = {counter:000000})");
            LogDataRefs();
            m_api.Log.Log("");

            return FlightLoopTime.FromSeconds(1.0f);
        }

        private void LogDataRefs()
        {
            foreach (var logger in m_datarefLoggers)
                logger();

            //Log(m_api.Data.Sim.Cockpit.Engine.FadecOn);
            //Log(m_api.Data.Sim.Cockpit.Engine.InverterEq);
            //Log(m_api.Data.Sim.Aircraft.View.TailNumber);
        }

        private Action CreateLogger(IXPDataRef dataRef)
        {
            switch (dataRef)
            {
                case IXPDataRef<int> d:
                    return () => Log(d);
                case IXPDataRef<int[]> d:
                    return () => Log(d);
                case IXPDataRef<bool> d:
                    return () => Log(d);
                case IXPDataRef<bool[]> d:
                    return () => Log(d);
                case IXPDataRef<float> d:
                    return () => Log(d);
                case IXPDataRef<float[]> d:
                    return () => Log(d);
                case IXPDataRef<double> d:
                    return () => Log(d);
                case IXPDataRef<string> d:
                    return () => Log(d);
                case IXPDataRef<byte[]> d:
                    return () => Log(d);
                default:
                    throw new InvalidOperationException("Unexpected dataRef type.");
            }
        }

        private void Log(IXPDataRef<int> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{dref.Value}]");

        private void Log(IXPDataRef<int[]> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{string.Join(", ", dref.Value)}]");

        private void Log(IXPDataRef<bool> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{dref.Value}]");

        private void Log(IXPDataRef<bool[]> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{string.Join(", ", dref.Value)}]");

        private void Log(IXPDataRef<float> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{dref.Value}]");

        private void Log(IXPDataRef<float[]> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{string.Join(", ", dref.Value)}]");

        private void Log(IXPDataRef<double> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{dref.Value}]");

        private void Log(IXPDataRef<byte[]> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{BitConverter.ToString(dref.Value)}]");

        private void Log(IXPDataRef<string> dref) =>
            m_api.Log.Log($"LoggerPlugin: {dref.Name} = [{dref.Value}]");

        private void Log(string eventName, XPMessageEventArgs e) =>
            m_api.Log.Log($"LoggerPlugin: {eventName}()");

        private void Log(string eventName, XPPlaneMessageEventArgs e) =>
            m_api.Log.Log($"LoggerPlugin: {eventName}({{Plane = {e.PlaneNumber}}})");
    }
}
