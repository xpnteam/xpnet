
#include "TestCore.h"
#include "StdCapture.h"

void PluginTestsBase::SetUpPluginTest()
{
	XPMock.ClearMockedData();

	DeleteXPNetConfig();

	// By default for these tests, point XPNet logging to stdout
	// and capture logging/stdout for tests to examine.
#ifdef _MSC_VER
	XPNetPluginSetExternalLoggingHandle(GetStdHandle(STD_OUTPUT_HANDLE));
#else
	XPNetPluginSetExternalLoggingHandle(reinterpret_cast<void*>(STDOUT_FILENO));
#endif

	StdCapture::Init();
	StdCapture::BeginCapture();
}

void PluginTestsBase::TearDownPluginTest()
{
	// The test may have tested Stop explicitly, but if it didn't,
	// make sure it's not left running for the next test.

	if (XPNetPluginIsEnabled())
		XPluginDisable();

	if (XPNetPluginIsStarted())
		XPluginStop();

	// In case the test didn't already do this.
	StdCapture::EndCapture();

	// In case the test failed or never wrote any log output, repeat the
	// log output on stdout now for debugging purposes.
	if (HasFailure())
		std::cout << StdCapture::GetCapture() << std::endl;
}

string PluginTestsBase::LogOutput()
{
	StdCapture::EndCapture();
	return StdCapture::GetCapture();
}
