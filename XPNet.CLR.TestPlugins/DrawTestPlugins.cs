
using Xunit;

namespace XPNet.CLR.TestPlugins
{
    [XPlanePlugin(nameof(DrawTestPlugin), "xpnet.plugins.test." + nameof(DrawTestPlugin), description: "unit test plugin")]
    public class DrawTestPlugin : TestPluginBase
    {
        private readonly IXPDrawingLoopHook m_drawBeforeHook;
        private readonly IXPDrawingLoopHook m_drawAfterHook;

        public DrawTestPlugin(IXPlaneApi api)
            : base(api)
        {
            m_drawBeforeHook = Api.Display.RegisterDrawHook(DrawBeforeHook, XPLMDrawingPhase.xplm_Phase_Airplanes, 1);
            m_drawAfterHook = Api.Display.RegisterDrawHook(DrawAfterHook, XPLMDrawingPhase.xplm_Phase_Airplanes, 0);
        }

        public override void Dispose()
        {
            m_drawBeforeHook.Dispose();
            m_drawAfterHook.Dispose();
            base.Dispose();
        }

        private int DrawBeforeHook(XPLMDrawingPhase inPhase, int inIsBefore)
        {
            Assert.Equal(1, inIsBefore);

            var dr = Api.Data.GetInt(TestData.Name($"draw/hook/count"));
            ++dr.Value;

            return 0;
        }

        private int DrawAfterHook(XPLMDrawingPhase inPhase, int inIsBefore)
        {
            Assert.Equal(0, inIsBefore);

            var dr = Api.Data.GetInt(TestData.Name($"draw/hook/count"));
            ++dr.Value;

            return 1;
        }
    }
}
