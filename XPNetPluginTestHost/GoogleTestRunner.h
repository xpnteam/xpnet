
#include "TestCore.h"

class GoogleTestRunner
{
public:

	GoogleTestRunner(int argc, char** argv)
		: m_vargv(argv, argv + argc)
	{ }

	int Run()
	{
		// MAINT: This is overkill - could have just passed argc and argv straight
		// through.  However, it was set up so that we could do some custom parsing
		// and behavior; that turned out not to be necessary, but I left the vectorization
		// of argc/argv in place so that we can easily add parsing and custom parameters
		// here in the future.  See the commented-out IsFlagSet function below, which
		// checks argv for a given --parameter-in-this-style.

		int argc = (int)m_vargv.size();
		::testing::InitGoogleTest(&argc, &m_vargv[0]);
		return RUN_ALL_TESTS();
	}

private:

	//const std::string listTestsCommand = "--gtest_list_tests";
	//const std::string xpnetTestRunnerCommand = "--xpnet_test_runner";

	//bool IsFlagSet(const string& flagName)
	//{
	//	return std::any_of(m_vargv.begin(), m_vargv.end(), [&](char const * const arg) { return string(arg) == flagName; });
	//}

	std::vector<char*> m_vargv;
};