
#include "TestCore.h"


class LifecycleTests : public PluginTestsBase
{
};

TEST_F(LifecycleTests, ProvidesPluginIdentity)
{
	WriteXPNetLoggerPluginConfig(XPNC_None);

	char outName[256] = "", outSig[256] = "", outDesc[256] = "";

	XPluginStart(outName, outSig, outDesc);

	ASSERT_STREQ(outName, "LoggerPlugin");
	ASSERT_STREQ(outSig, "xpnet.plugins.logger");
	ASSERT_STREQ(outDesc, "Logs various X-Plane events.");
}
