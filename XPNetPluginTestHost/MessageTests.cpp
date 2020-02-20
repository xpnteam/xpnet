
#define XPNET_MSGTEST_PLUGIN_COMMAND1 (0x8000000 | 0x01)
#define XPNET_MSGTEST_PLUGIN_COMMAND2  (0x8000000 | 0x02)

#include "TestCore.h"

class MessagesTests : public PluginTestsBase
{
};

TEST_F(MessagesTests, ReceivesPlaneLoaded)
{
	int planeNumber = 2;
	int counter = 0;
	string dr = DataRefBase "msg/plane_loaded/" + std::to_string(planeNumber) + "/count";
	XPHarnessAddDataRef(dr.c_str(), XPMock.GetAccessor<int>, XPMock.SetAccessor<int>, &counter, &counter);

	RunPlugin("MessageTestPlugin", [planeNumber] {
		int64_t lParam = planeNumber;
		XPluginReceiveMessage(0, XPLM_MSG_PLANE_LOADED, reinterpret_cast<void*>(lParam));
	});

	ASSERT_EQ(counter, 1);
}

TEST_F(MessagesTests, ReceivesPlaneCrashed)
{
	int counter = 0;
	XPHarnessAddDataRef(DataRefBase "msg/plane_crashed/count", XPMock.GetAccessor<int>, XPMock.SetAccessor<int>, &counter, &counter);

	RunPlugin("MessageTestPlugin", [] {
		XPluginReceiveMessage(0, XPLM_MSG_PLANE_CRASHED, nullptr);
	});

	ASSERT_EQ(counter, 1);
}

TEST_F(MessagesTests, ReceivesCustomMessage)
{
	int counter = 0;
	XPHarnessAddDataRef(DataRefBase "msg/42/count", XPMock.GetAccessor<int>, XPMock.SetAccessor<int>, &counter, &counter);

	RunPlugin("MessageTestPlugin", [] {
		XPluginReceiveMessage(0, 42, nullptr);
	});

	ASSERT_EQ(counter, 1);
}
