
#include "TestCore.h"

using std::fstream;
using std::cout;
using std::endl;

string xpnetcfg_path()
{
	return "xpnetcfg.json"; // Currently, assume we're in the correct directory.
}

string xpnetlog_path()
{
	return "xpnet.log";     // Currently, assume we're in the correct directory.
}

void DeleteXPNetConfig()
{
	if (file_exists(xpnetcfg_path()))
	{
		int iRes = _unlink(xpnetcfg_path().c_str());
		ASSERT_TRUE(iRes == 0);
	}
}

void WriteTestPluginConfig(const string& name, XPNetConfigFlags flags)
{
	fstream cfg;
	cfg.exceptions(fstream::failbit | fstream::badbit);
	cfg.open(xpnetcfg_path(), fstream::out | fstream::out);

	cfg << "{" << endl;

	cfg << "  \"PluginAssemblyName\": \"XPNet.CLR.TestPlugins.dll\"," << endl;
	cfg << "  \"PluginType\": \"XPNet.CLR.TestPlugins." << name << "\"," << endl;

	cfg << "  \"LoggingEnabled\": " << ((flags & XPNC_EnableLogging) ? "true" : "false") << "," << endl;

	cfg << "}" << endl;

	cfg.close();
}

void WriteXPNetLoggerPluginConfig(XPNetConfigFlags flags)
{
	fstream cfg;
	cfg.exceptions(fstream::failbit | fstream::badbit);
	cfg.open(xpnetcfg_path(), fstream::out | fstream::out);

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

void RunPluginImpl(const string& name)
{
	RunPluginImpl(name, nullptr, nullptr);
}

void RunPluginImpl(const string& name, function< void(void) > postEnableCallback)
{
	RunPluginImpl(name, postEnableCallback, nullptr);
}

void RunPluginImpl(const string& name, function< void(void) > postEnableCallback, function< void(void) > postDisableCallback)
{
	// The point of whatever test is calling this is not to be explicitly
	// testing XPluginStart, and if it does fail something is seriously wrong
	// and there's no point continuing the test (thus the ASSERTs here).

	WriteTestPluginConfig(name, XPNC_None);

	char outName[256] = "", outSig[256] = "", outDesc[256] = "";

	int res = XPluginStart(outName, outSig, outDesc);
	ASSERT_NE(res, 0);

	res = XPluginEnable();
	ASSERT_NE(res, 0);

	if (postEnableCallback)
		postEnableCallback();

	XPluginDisable();

	if (postDisableCallback)
		postDisableCallback();
}
