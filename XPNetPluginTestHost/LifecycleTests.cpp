
#include "TestCore.h"


class LifecycleTests : public PluginTestsBase
{
};

TEST_F(LifecycleTests, ProvidesPluginIdentity)
{
	string acf_tailnum = "N90U";
	std::vector<char> acf_tailnumV = std::vector<char>(acf_tailnum.begin(), acf_tailnum.end());
	int num_buses = 2;
	std::vector<int> fadec_on = { true, false, true };
	float instrument_brightness = 0.8f;
	int inverter_eq = true;
	std::vector<float> joystick_axis_values = { 0.1f, 0.0f, 0.8f };
	std::vector<float> joystick_axis_minimum = std::vector<float>();
	XPHarnessAddDataRef("sim/aircraft/view/acf_tailnum", (XPLMGetDatab_f)XPMock.GetArrayAccessorFromVector<char>, &acf_tailnumV);
	XPHarnessAddDataRef("sim/aircraft/electrical/num_buses", XPMock.GetAccessor<int>, &num_buses);
	XPHarnessAddDataRef("sim/cockpit/engine/fadec_on", XPMock.GetArrayAccessorFromVector<int>, &fadec_on);
	XPHarnessAddDataRef("sim/cockpit/electrical/instrument_brightness", XPMock.GetAccessor<float>, &instrument_brightness);
	XPHarnessAddDataRef("sim/cockpit/engine/inverter_eq", XPMock.GetAccessor<int>, &inverter_eq);
	XPHarnessAddDataRef("sim/joystick/joystick_axis_values", XPMock.GetArrayAccessorFromVector<float>, &joystick_axis_values);
	XPHarnessAddDataRef("sim/joystick/joystick_axis_minimum", XPMock.GetArrayAccessorFromVector<float>, &joystick_axis_minimum); // Intentionally of Length zero to test handling zero-length arrays.

	WriteXPNetLoggerPluginConfig(XPNC_None);

	char outName[256] = "", outSig[256] = "", outDesc[256] = "";

	XPluginStart(outName, outSig, outDesc);

	ASSERT_STREQ(outName, "LoggerPlugin");
	ASSERT_STREQ(outSig, "xpnet.plugins.logger");
	ASSERT_STREQ(outDesc, "Logs various X-Plane events.");
}
