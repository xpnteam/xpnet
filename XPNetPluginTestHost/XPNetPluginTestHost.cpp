// XPNetPluginTestHost.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <conio.h>
#include "XPNetPluginTestHost.h"
#include <XPNetPlugin.h>
#include <XPLMTestHarness.h>
#include <iostream>
#include <fstream>

#include "XPMock.h"

using std::fstream;
using std::cout;
using std::endl;

typedef enum {
	XPNC_None = 0x0,

	XPNC_EnableLogging = 0x01
} XPNetConfigFlags;

#define XPNET_MSG_PLUGIN_IDENT (0x8000000 | 0x01)
#define XPNET_MSG_PLUGIN_CMDTEST_BEGIN  (0x8000000 | 0x02)
#define XPNET_MSG_PLUGIN_CMDTEST_END  (0x8000000 | 0x03)
#define XPNET_MSG_PLUGIN_CMDTEST_INVOKE  (0x8000000 | 0x04)

inline bool file_exists(const std::string& name)
{
	struct stat buffer;
	return (stat(name.c_str(), &buffer) == 0);
}

void WriteXPNetLoggerPluginConfig(XPNetConfigFlags flags)
{
	fstream cfg;
	cfg.exceptions(fstream::failbit | fstream::badbit);
	cfg.open("xpnetcfg.json", fstream::out | fstream::out);

	cfg << "{" << endl;

	cfg << "  \"PluginAssemblyName\": \"XPNet.LoggerPlugin.dll\"," << endl;
	cfg << "  \"PluginType\": \"XPNet.LoggerPlugin\"," << endl;

	cfg << "  \"LoggingEnabled\": " << ((flags & XPNC_EnableLogging) ? "true" : "false") << "," << endl;

	cfg << "  \"XPNetLogger\": {" << endl;
		
    cfg << "    \"StringData\": [ " << endl;
	cfg << "      \"sim/aircraft/view/acf_tailnum\"," << endl;
	cfg << "    ]," << endl;

	cfg << "    \"IntData\": [ " << endl;
	cfg << "      \"sim/aircraft/electrical/num_buses\"," << endl;
	cfg << "    ]," << endl;

	cfg << "    \"BoolArrayData\": [ " << endl;
	cfg << "      \"sim/cockpit/engine/fadec_on\"," << endl;
	cfg << "    ]," << endl;

	cfg << "    \"FloatData\": [ " << endl;
	cfg << "      \"sim/cockpit/electrical/instrument_brightness\"," << endl;
	cfg << "    ]," << endl;

	cfg << "    \"BoolData\": [ " << endl;
	cfg << "      \"sim/cockpit/engine/inverter_eq\"," << endl;
	cfg << "    ]," << endl;

	cfg << "    \"FloatArrayData\": [ " << endl;
	cfg << "      \"sim/joystick/joystick_axis_values\"," << endl;
	cfg << "      \"sim/joystick/joystick_axis_minimum\"," << endl;
	cfg << "    ]" << endl;

	cfg << "  }" << endl;

	cfg << "}" << endl;

	cfg.close();
}

void WriteXPNetGraphicsTestPluginConfig()
{
	fstream cfg;
	cfg.exceptions(fstream::failbit | fstream::badbit);
	cfg.open("xpnetcfg.json", fstream::out | fstream::out);

	cfg << "{" << endl;

	cfg << "  \"PluginAssemblyName\": \"XPNet.GraphicsTestPlugin.dll\"," << endl;
	cfg << "  \"PluginType\": \"XPNet.GraphicsTestPlugin\"," << endl;

	cfg << "  \"LoggingEnabled\": true" << "," << endl;

	cfg << "}" << endl;

	cfg.close();
}

void Spacer()
{
	cout << endl << "-------------------------------------" << endl << endl;
}

bool StartupPlugin()
{
	char outName[256] = "", outSig[256] = "", outDesc[256] = "";

	int res;

	cout << "Test Host: Starting Plugin..." << endl;
	res = XPluginStart(outName, outSig, outDesc);
	cout << "Test Host: Start Result: " << res << endl;
	if (!res)
		return false;

	cout << "Test Host: Plugin Identity - Name : " << outName << endl;
	cout << "Test Host: Plugin Identity - Sig  : " << outSig << endl;
	cout << "Test Host: Plugin Identity - Desc : " << outDesc << endl;

	cout << "Test Host: Enabling Plugin..." << endl;
	res = XPluginEnable();
	cout << "Test Host: Enable Result: " << res << endl;

	return true;
}

bool TestStartupWithLogger(XPNetConfigFlags configFlags)
{
	WriteXPNetLoggerPluginConfig(configFlags);
	return StartupPlugin();
}

bool TestStartupWithGraphics()
{
	WriteXPNetGraphicsTestPluginConfig();
	return StartupPlugin();
}

bool TestMessages()
{
	int64_t lParam;

	cout << "Test Host: XPLM_MSG_PLANE_LOADED (Plane 2)" << endl;
	lParam = 2;
	XPluginReceiveMessage(0, XPLM_MSG_PLANE_LOADED, reinterpret_cast<void*>(lParam));

	cout << "Test Host: XPLM_MSG_PLANE_CRASHED" << endl;
	XPluginReceiveMessage(0, XPLM_MSG_PLANE_CRASHED, nullptr);

	return true;
}

bool TestLogging()
{
	// For this test to succeed, all of the following must happen:
	//
	// 1. The log change detection mechanism must work and the log
	//    update take effect.
	// 2. Logging must swap to the output file and write a predictable
	//    thing to the log.

	// Send a message to the logger plugin that causes it to write a predictable thing to the log.
	cout << "Test Host: The next line should be 'LockerPlugin: IDENT'." << endl;
	XPluginReceiveMessage(0, XPNET_MSG_PLUGIN_IDENT, nullptr);

	return true;
}

bool TestShutdown()
{
	cout << "Test Host: Disabling Plugin..." << endl;
	XPluginDisable();
	cout << "Test Host: Plugin Disabled." << endl;

	cout << "Test Host: Stopping Plugin..." << endl;
	XPluginStop();
	cout << "Test Host: Plugin Stopped." << endl;

	return true;
}

bool TestCommands()
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

	cout << "Test Host: The next line should be 0 0 0." << endl;
	cout << nBegins << " " << nEnds << " " << nInvokes << endl;

	XPluginReceiveMessage(0, XPNET_MSG_PLUGIN_CMDTEST_BEGIN, nullptr);
	cout << "Test Host: The next line should be 1 0 0." << endl;
	cout << nBegins << " " << nEnds << " " << nInvokes << endl;

	XPluginReceiveMessage(0, XPNET_MSG_PLUGIN_CMDTEST_INVOKE, nullptr);
	cout << "Test Host: The next line should be 1 0 1." << endl;
	cout << nBegins << " " << nEnds << " " << nInvokes << endl;

	XPluginReceiveMessage(0, XPNET_MSG_PLUGIN_CMDTEST_END, nullptr);
	cout << "Test Host: The next line should be 1 1 1." << endl;
	cout << nBegins << " " << nEnds << " " << nInvokes << endl;

	return true;
}

bool TestFlightLoop()
{
	XPHarnessInvokeFlightLoop(1.0f, 2.0f, 1);
	XPHarnessInvokeFlightLoop(1.2f, 1.8f, 2);
	XPHarnessInvokeFlightLoop(1.0f, 2.2f, 3);
	
	return true;
}

bool RunMiscTestGroup1()
{
	// A set of misc. tests that all can run with the Logger plugin instantiated.

	XPNetPluginSetExternalLoggingHandle(GetStdHandle(STD_OUTPUT_HANDLE));

	XPMock.SetString("sim/aircraft/view/acf_tailnum", "N90U");
	XPMock.SetInt("sim/aircraft/electrical/num_buses", 2);
	XPMock.SetBool("sim/cockpit/engine/fadec_on", { true, false, true });
	XPMock.SetFloat("sim/cockpit/electrical/instrument_brightness", 0.8f);
	XPMock.SetBool("sim/cockpit/engine/inverter_eq", true);
	XPMock.SetFloat("sim/joystick/joystick_axis_values", { 0.1f, 0.0f, 0.8f });
	XPMock.SetFloat("sim/joystick/joystick_axis_minimum", std::vector<float>()); // Intentionally of Length zero to test handling zero-length arrays.

	Spacer();
	if (!TestStartupWithLogger(XPNC_None))
		return false;

	Spacer();
	if (!TestMessages())
		return false;

	Spacer();
	if (!TestLogging())
		return false;

	Spacer();
	if (!TestCommands())
		return false;

	Spacer();
	if (!TestFlightLoop())
		return false;

	Spacer();
	if (!TestShutdown())
		return false;

	return true;
}

bool RunXPNetLogTestGroup()
{
	// Tests with the logger plugin instantiated but with no custom log handle
	// set, so that ouptut goes to the default location (xpnet.log), so that we can
	// verify that logging to xpnet.log works.

	if (file_exists("xpnet.log"))
	{
		int iRes = _unlink("xpnet.log");
		if (iRes != 0)
		{
			cout << "Test Host: Deleting existing xpnet.log in preparation for the logging test failed." << endl;
			return false;
		}
	}

	XPNetPluginSetExternalLoggingHandle(nullptr);

	Spacer();
	if (!TestStartupWithLogger(XPNC_EnableLogging))
		return false;

	Spacer();
	if (!TestShutdown())
		return false;

	Spacer();
	cout << "Test Host: The last test tested writing to xpnet.log.  See xpnet.log for results." << endl;

	return true;
}

bool RunGraphicsTestGroup()
{
	XPNetPluginSetExternalLoggingHandle(GetStdHandle(STD_OUTPUT_HANDLE));

	Spacer();
	if (!TestStartupWithGraphics())
		return false;
	
	Spacer();
	cout << "Test Host: Invoking the flight loop; should see related output before the next spacer." << endl;
	XPHarnessInvokeFlightLoop(1.0f, 2.0f, 1);

	Spacer();
	cout << "Test Host: Invoking the draw callback; should see related output before the next spacer." << endl;
	XPHarnessInvokeDrawCallback();

	Spacer();
	if (!TestShutdown())
		return false;

	return true;
}

int main()
{
	// This looks a bit like a set of unit tests, but it's not fully automated.  You
	// have to read through the output of the run see if all of the tests actually
	// succeeded.
	//
	// A meta-test that also happens here: each test group instantiates a plugin and
	// takes it through its entire lifecycle, so that we know that disabling and
	// enabling plugins over time in the same process works.

	if (!RunMiscTestGroup1())
		return 1;

	if (!RunXPNetLogTestGroup())
		return 1;

	if (!RunGraphicsTestGroup())
		return 1;

    return 0;
}

// ENHANCE: Test for InvalidOperationException trying to get something that X-Plane doesn't respond to.
 