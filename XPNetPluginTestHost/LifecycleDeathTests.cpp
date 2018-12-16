
#include "TestCore.h"

// The tests in this file must be written as Death tests b/c they test
// various cases where the runtime fails to start.  Since .NET Core
// does not support being unloading at present, once loaded it must stay
// loaded, so these tests that leave it loaded in a bad state must each
// execute in their own child process.

class LifecycleDeathTests : public PluginTestsBase
{
};

void RunIsolatedLifecycleTest()
{
	// NOTE: This function runs in an isolated process separate from most the rest of
	// the test code.

	PluginTestsBase::SetUpTestCase(); // Have to do this manually in this case.

	// NOTE: redirect output to stderr so that EXPECT_EXIT can see it.

	char outName[256] = "", outSig[256] = "", outDesc[256] = "";

	int res = XPluginStart(outName, outSig, outDesc);

	if (!res)
	{
		std::cerr << PluginTestsBase::LogOutput() << std::flush;
		_exit(res);
	}

	res = XPluginEnable();
	if (!res)
	{
		std::cerr << PluginTestsBase::LogOutput() << std::flush;
		_exit(res);
	}

	XPluginDisable();

	XPluginStop();

	std::cerr << PluginTestsBase::LogOutput() << std::flush;

	// Exit with whatever the exit code of XPluginStart was so we can test for that as well.
	_exit(1);
}

TEST_F(LifecycleDeathTests, StartsAndStopsCleanlyWithValidConfigFile)
{
	EXPECT_EXIT(
		{
			// Pretend that the plugin is running from some location that probably
			// doesn't exist and definitely isn't an XPNet plugin install.
			XPHarnessSetPluginPath("./tmp/nonexist");

			WriteXPNetLoggerPluginConfig(XPNC_None);

			RunIsolatedLifecycleTest();
		},
		::testing::ExitedWithCode(0),
		"Probing found no CLR paths"
	);
}

TEST_F(LifecycleDeathTests, FailsToStartIfNoConfigFile)
{
	EXPECT_EXIT(RunIsolatedLifecycleTest(), ::testing::ExitedWithCode(0), "config file does not exist");
}

TEST_F(LifecycleDeathTests, FailsToStartIfNoCompatibleRuntime)
{
	EXPECT_EXIT(
		{
			// Pretend that the plugin is running from some location that probably
			// doesn't exist and definitely isn't an XPNet plugin install.
			XPHarnessSetPluginPath("./tmp/nonexist");

			WriteXPNetLoggerPluginConfig(XPNC_None);

			RunIsolatedLifecycleTest();
		},
		::testing::ExitedWithCode(0),
		"Probing found no CLR paths"
	);
}
