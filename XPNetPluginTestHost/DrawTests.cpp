
#include "TestCore.h"

class DrawTests : public PluginTestsBase
{
};

TEST_F(DrawTests, CanHookDraw)
{
	string drHookCount = DataRefBase "draw/hook/count";

	XPMock.SetInt(drHookCount.c_str(), 0);

	RunPlugin("DrawTestPlugin", [&] {

		int results[MAX_REGISTERED_DRAW_CALLBACKS];
		auto reinit = [&results]
		{
			for (int i = 0; i < MAX_REGISTERED_DRAW_CALLBACKS; ++i)
				results[i] = 25; // Set to an invalid value - only 1 and 0 are valid results from the API.
		};

		XPHarnessInvokeDrawCallback(results);
		ASSERT_EQ(results[0], 0);
		ASSERT_EQ(results[1], 1);
	});
}

// Delete this if we end up not needing it anymore after the test cases are swapped over to unit-test style.
//
//void WriteXPNetGraphicsTestPluginConfig()
//{
//	fstream cfg;
//	cfg.exceptions(fstream::failbit | fstream::badbit);
//	cfg.open("xpnetcfg.json", fstream::out | fstream::out);
//
//	cfg << "{" << endl;
//
//	cfg << "  \"PluginAssemblyName\": \"XPNet.GraphicsTestPlugin.dll\"," << endl;
//	cfg << "  \"PluginType\": \"XPNet.GraphicsTestPlugin\"," << endl;
//
//	cfg << "  \"LoggingEnabled\": true" << "," << endl;
//
//	cfg << "}" << endl;
//
//	cfg.close();
//}
