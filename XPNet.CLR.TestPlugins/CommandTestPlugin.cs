
namespace XPNet.CLR.TestPlugins
{
    [XPlanePlugin(nameof(CommandTestPlugin), "xpnet.plugins.test." + nameof(CommandTestPlugin), description: "unit test plugin")]
    public class CommandTestPlugin : TestPluginBase
    {
        private int m_step = 0;

        private readonly IXPCommand m_headingUpCommand;

        public CommandTestPlugin(IXPlaneApi api)
            : base(api)
        {
            Api.Messages.MessageReceived += Messages_MessageReceived;

            m_headingUpCommand = Api.Commands.GetCommand("sim/autopilot/heading_up");
        }

        public override void Dispose()
        {
            Api.Messages.MessageReceived -= Messages_MessageReceived;

            base.Dispose();
        }

        private void Messages_MessageReceived(object sender, XPMessageEventArgs e)
        {
            if (e.MessageId != TestData.XPNET_CMDTEST_PLUGIN_STEP)
                return;

            switch (++m_step)
            {
                case 1:
                    m_headingUpCommand.Begin(); // BEGIN
                    break;

                case 2:
                    m_headingUpCommand.End();   // END
                    break;

                case 3:
                    m_headingUpCommand.InvokeOnce();  // ONCE
                    break;

                default:
                    // No programmed action.
                    break;
            }
        }
    }
}
