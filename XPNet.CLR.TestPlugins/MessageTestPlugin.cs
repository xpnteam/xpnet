
namespace XPNet.CLR.TestPlugins
{
    [XPlanePlugin(nameof(MessageTestPlugin), "xpnet.plugins.test." + nameof(MessageTestPlugin), description: "unit test plugin")]
    public class MessageTestPlugin : TestPluginBase
    {
        public MessageTestPlugin(IXPlaneApi api)
            : base(api)
        {
            Api.Messages.MessageReceived += Messages_MessageReceived;
            Api.Messages.PlaneCrashed += Messages_PlaneCrashed;
            Api.Messages.PlaneLoaded += Messages_PlaneLoaded;
        }

        public override void Dispose()
        {
            Api.Messages.MessageReceived -= Messages_MessageReceived;
            Api.Messages.PlaneCrashed -= Messages_PlaneCrashed;
            Api.Messages.PlaneLoaded -= Messages_PlaneLoaded;

            base.Dispose();
        }

        private void Messages_MessageReceived(object sender, XPMessageEventArgs e)
        {
            var dr = Api.Data.GetInt(TestData.Name($"msg/{e.MessageId}/count"));
            ++dr.Value;
        }

        private void Messages_PlaneLoaded(object sender, XPPlaneMessageEventArgs e)
        {
            var dr = Api.Data.GetInt(TestData.Name($"msg/plane_loaded/{e.PlaneNumber}/count"));
            ++dr.Value;
        }

        private void Messages_PlaneCrashed(object sender, XPMessageEventArgs e)
        {
            var dr = Api.Data.GetInt(TestData.Name($"msg/plane_crashed/count"));
            ++dr.Value;
        }
    }
}
