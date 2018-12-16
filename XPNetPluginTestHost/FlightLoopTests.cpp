
#include "TestCore.h"

class FlightLoopTests : public PluginTestsBase
{
};

TEST_F(FlightLoopTests, CanHookFlightLoop)
{
	string drElapsedTimeSinceLastCall = DataRefBase "fl/elapsedTimeSinceLastCall";
	string dfElapsedTimeSinceLastFlightLoop = DataRefBase "fl/elapsedTimeSinceLastFlightLoop";
	string drCounter = DataRefBase "fl/counter";

	XPMock.SetFloat(drElapsedTimeSinceLastCall.c_str(), 0.0f);
	XPMock.SetFloat(dfElapsedTimeSinceLastFlightLoop.c_str(), 0.0f);
	XPMock.SetInt(drCounter.c_str(), 0);

	RunPlugin("FlightLoopTestPlugin", [&] {

		XPHarnessInvokeFlightLoop(1.0f, 2.0f, 1);
		ASSERT_EQ(1.0f, XPMock.GetFloat(drElapsedTimeSinceLastCall.c_str()));
		ASSERT_EQ(2.0f, XPMock.GetFloat(dfElapsedTimeSinceLastFlightLoop.c_str()));
		ASSERT_EQ(1, XPMock.GetInt(drCounter.c_str()));

		XPHarnessInvokeFlightLoop(1.2f, 1.8f, 2);
		ASSERT_EQ(1.2f, XPMock.GetFloat(drElapsedTimeSinceLastCall.c_str()));
		ASSERT_EQ(1.8f, XPMock.GetFloat(dfElapsedTimeSinceLastFlightLoop.c_str()));
		ASSERT_EQ(2, XPMock.GetInt(drCounter.c_str()));

		XPHarnessInvokeFlightLoop(1.0f, 2.2f, 3);
		ASSERT_EQ(1.0f, XPMock.GetFloat(drElapsedTimeSinceLastCall.c_str()));
		ASSERT_EQ(2.2f, XPMock.GetFloat(dfElapsedTimeSinceLastFlightLoop.c_str()));
		ASSERT_EQ(3, XPMock.GetInt(drCounter.c_str()));
	});
}