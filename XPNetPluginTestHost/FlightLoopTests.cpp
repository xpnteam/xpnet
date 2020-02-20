
#include "TestCore.h"

class FlightLoopTests : public PluginTestsBase
{
};

TEST_F(FlightLoopTests, CanHookFlightLoop)
{
	float elapsedTimeSinceLastCall = 0.f;
	float elapsedTimeSinceLastFlightLoop = 0.f;
	int counter = 0;
	XPHarnessAddDataRef(DataRefBase "fl/elapsedTimeSinceLastCall", XPMock.SetAccessor<float>, &elapsedTimeSinceLastCall);
	XPHarnessAddDataRef(DataRefBase "fl/elapsedTimeSinceLastFlightLoop", XPMock.SetAccessor<float>, &elapsedTimeSinceLastFlightLoop);
	XPHarnessAddDataRef(DataRefBase "fl/counter", XPMock.SetAccessor<int>, &counter);

	RunPlugin("FlightLoopTestPlugin", [&] {

		XPHarnessInvokeFlightLoop(1.0f, 2.0f, 1);
		ASSERT_EQ(1.0f, elapsedTimeSinceLastCall);
		ASSERT_EQ(2.0f, elapsedTimeSinceLastFlightLoop);
		ASSERT_EQ(1, counter);

		XPHarnessInvokeFlightLoop(1.2f, 1.8f, 2);
		ASSERT_EQ(1.2f, elapsedTimeSinceLastCall);
		ASSERT_EQ(1.8f, elapsedTimeSinceLastFlightLoop);
		ASSERT_EQ(2, counter);

		XPHarnessInvokeFlightLoop(1.0f, 2.2f, 3);
		ASSERT_EQ(1.0f, elapsedTimeSinceLastCall);
		ASSERT_EQ(2.2f, elapsedTimeSinceLastFlightLoop);
		ASSERT_EQ(3, counter);
	});
}