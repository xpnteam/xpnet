
using System;

namespace XPNet.CLR.TestPlugins
{
    public static class TestData
    {
        public const int XPNET_MSGTEST_PLUGIN_COMMAND1 = (0x8000000 | 0x01);
        public const int XPNET_MSGTEST_PLUGIN_COMMAND2 = (0x8000000 | 0x02);

        public const int XPNET_CMDTEST_PLUGIN_STEP     = (0x8000000 | 0x03);

        public const int XPNET_LOGTEST_PLUGIN_IDENT    = (0x8000000 | 0x04);

        public static string DataRefBase => "xpnet/test/";

        public static string Name(string name) => DataRefBase + name;
    }

    // ENHANCE: Plugins derived from this class are not xUnit test cases;
    // rather, they are meant to be called from the native gtest test
    // cases.  However, for ease of writing tests, these plugins are
    // allowed and encouraged to make xUnit assertions (using XUnit.Assert).
    // _Currently_, if an assertion fails, the assumption is that the
    // native test will also fail, as a consequence of control not
    // reaching the end of the test plugin.  That works for the only
    // cases we've done so far, but I can easily imagine cases that it
    // wouldn't work for.  As soon as you have one to write working
    // code against, my proposed solution is to hook XPNetPluginBridge
    // to recognize xUnit exceptions and, when one is thrown, to set a
    // flag that the native side can query for to find out if a test
    // failure has been noted - similar to how ASSERT_NO_FATAL_FAILURE
    // works.  In fact the mechanism would bridge those two: when we
    // note that an xUnit failure was seen, we'll call whatever gtest
    // function is appropriate to fail the currently-executing test.
    // Result: xUnit failures become gtest failures, as you'd expect.

    public class TestPluginBase : IXPlanePlugin
    {
        public TestPluginBase(IXPlaneApi api)
        {
            Api = api ?? throw new ArgumentNullException(nameof(api));
        }

        protected IXPlaneApi Api { get; }

        public virtual void Dispose()
        {
            // Intentionally Empty
        }

        public virtual void Enable()
        {
            // Intentionally Empty
        }

        public virtual void Disable()
        {
            // Intentionally Empty
        }
    }
}
