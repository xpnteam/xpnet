
#define XPNET_CMDTEST_PLUGIN_STEP  (0x8000000 | 0x03)

#include "TestCore.h"

class CommandTests : public PluginTestsBase
{
};

TEST_F(CommandTests, CanInvokeCommands)
{
	int nBegins = 0, nEnds = 0, nInvokes = 0;

	auto handler = [&nBegins, &nEnds, &nInvokes](CommandPhase phase) {
		switch (phase)
		{
		case CommandPhase_Begin:
			++nBegins;
			break;

		case CommandPhase_End:
			++nEnds;
			break;

		case CommandPhase_Once:
			++nInvokes;
			break;
		}
	};

	XPMock.CreateCommand("sim/autopilot/heading_up", fnptr<void(CommandPhase)>(handler));

	RunPlugin("CommandTestPlugin", [&nBegins, &nEnds, &nInvokes]
	{
		// The test plugin invokes the command in a different way for each
		// time we Step it.

		XPluginReceiveMessage(0, XPNET_CMDTEST_PLUGIN_STEP, nullptr);
		ASSERT_EQ(nBegins, 1);
		ASSERT_EQ(nEnds, 0);
		ASSERT_EQ(nInvokes, 0);

		XPluginReceiveMessage(0, XPNET_CMDTEST_PLUGIN_STEP, nullptr);
		ASSERT_EQ(nBegins, 1);
		ASSERT_EQ(nEnds, 1);
		ASSERT_EQ(nInvokes, 0);

		XPluginReceiveMessage(0, XPNET_CMDTEST_PLUGIN_STEP, nullptr);
		ASSERT_EQ(nBegins, 1);
		ASSERT_EQ(nEnds, 1);
		ASSERT_EQ(nInvokes, 1);
	});
}
