
#include "TestCore.h"

#define XPNET_LOGTEST_PLUGIN_IDENT  (0x8000000 | 0x04)

// ENHANCE: Tests that you can change configuration of xpnetcfg.log and
// see the updated configuration on the plugin side.  That's not strictly
// related to logging, I just put this note here b/c our logger plugin example
// _does_ use that capability -- but really it should be tested separately
// from logger capability.

class LoggingTests : public PluginTestsBase
{
};

TEST_F(LoggingTests, CanLog)
{
	// Override the default logging setup from PluginTestsBase - for this case
	// we _do_ want logging to the standard xpnet.log output file.
	XPNetPluginSetExternalLoggingHandle(nullptr);

	// The test doesn't have to clean up after itself (wrt setting the external
	// logging handle back) b/c PluginTestsBase handles that at the start of each
	// test - but if that log swapping mechanism _were_ to break
	// such that the logging can't be moved back off of the default file
	// later, you may see other tests that happen to run after this one
	// fail.  Many of these tests implicitly test the log redirection.

	if (file_exists(xpnetlog_path()))
	{
		int iRes = _unlink("xpnet.log");
		ASSERT_EQ(iRes, 0);
	}

	RunPlugin("LoggingTestPlugin", [] {

		XPluginReceiveMessage(0, XPNET_LOGTEST_PLUGIN_IDENT, nullptr);

		ASSERT_TRUE(file_exists(xpnetlog_path()));

		std::ifstream log(xpnetlog_path());
		string logContents((std::istreambuf_iterator<char>(log)), std::istreambuf_iterator<char>());

		ASSERT_THAT(logContents.c_str(), HasSubstr("IDENT: LoggingTestPlugin"));
	});
}