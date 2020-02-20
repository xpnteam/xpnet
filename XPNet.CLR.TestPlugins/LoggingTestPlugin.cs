
namespace XPNet.CLR.TestPlugins
{
    [XPlanePlugin(nameof(LoggingTestPlugin), "xpnet.plugins.test." + nameof(LoggingTestPlugin), description: "unit test plugin")]
    public class LoggingTestPlugin : TestPluginBase
    {
        public LoggingTestPlugin(IXPlaneApi api)
            : base(api)
        {
            Api.Messages.MessageReceived += Messages_MessageReceived;
        }

        public override void Dispose()
        {
            Api.Messages.MessageReceived -= Messages_MessageReceived;

            base.Dispose();
        }

        private void Messages_MessageReceived(object sender, XPMessageEventArgs e)
        {
            if (e.MessageId == TestData.XPNET_LOGTEST_PLUGIN_IDENT)
            {
                Api.Log.Log("IDENT: LoggingTestPlugin");
            }
        }
    }
}
