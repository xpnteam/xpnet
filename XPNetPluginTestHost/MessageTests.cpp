
#define XPNET_MSGTEST_PLUGIN_COMMAND1 (0x8000000 | 0x01)
#define XPNET_MSGTEST_PLUGIN_COMMAND2  (0x8000000 | 0x02)

#include "TestCore.h"

class MessagesTests : public PluginTestsBase
{
};

TEST_F(MessagesTests, ReceivesPlaneLoaded)
{
	int planeNumber = 2;
	string dr = DataRefBase "msg/plane_loaded/" + std::to_string(planeNumber) + "/count";

	XPMock.SetInt(dr.c_str(), 0);

	RunPlugin("MessageTestPlugin", [planeNumber] {
		int64_t lParam = planeNumber;
		XPluginReceiveMessage(0, XPLM_MSG_PLANE_LOADED, reinterpret_cast<void*>(lParam));
	});

	int ret = XPMock.GetInt(dr.c_str());
	ASSERT_EQ(ret, 1);
}

TEST_F(MessagesTests, ReceivesPlaneCrashed)
{
	string dr = DataRefBase "msg/plane_crashed/count";

	XPMock.SetInt(dr.c_str(), 0);

	RunPlugin("MessageTestPlugin", [] {
		XPluginReceiveMessage(0, XPLM_MSG_PLANE_CRASHED, nullptr);
	});

	int ret = XPMock.GetInt(dr.c_str());
	ASSERT_EQ(ret, 1);
}

TEST_F(MessagesTests, ReceivesCustomMessage)
{
	string dr = DataRefBase "msg/42/count";

	XPMock.SetInt(dr.c_str(), 0);

	RunPlugin("MessageTestPlugin", [] {
		XPluginReceiveMessage(0, 42, nullptr);
	});

	int ret = XPMock.GetInt(dr.c_str());
	ASSERT_EQ(ret, 1);
}
