
#include "TestCore.h"

// TODO: Test for InvalidOperationException trying to get a dataref that X-Plane doesn't respond to.

class DataRefTests : public PluginTestsBase
{
};

TEST_F(DataRefTests, StringsReadAndWrite)
{
	XPMock.SetString(DataRefBase "dr/addstring/lhs", "foo");
	XPMock.SetString(DataRefBase "dr/addstring/rhs", "bar");
	XPMock.SetString(DataRefBase "dr/addstring/res", "");

	RunPlugin("StringAdderPlugin");

	string ret = XPMock.GetString(DataRefBase "dr/addstring/res");
	ASSERT_EQ(ret, "foobar");
}

TEST_F(DataRefTests, IntsReadAndWrite)
{
	int lhs = 5, rhs = 11;

	XPMock.SetInt(DataRefBase "dr/addint/lhs", lhs);
	XPMock.SetInt(DataRefBase "dr/addint/rhs", rhs);
	XPMock.SetInt(DataRefBase "dr/addint/res", 0);

	RunPlugin("IntAdderPlugin");

	int ret = XPMock.GetInt(DataRefBase "dr/addint/res");
	ASSERT_EQ(ret, rhs + lhs);
}

TEST_F(DataRefTests, IntArraysReadAndWrite)
{
	std::vector<int> lhs = { 5, 10, 15, 20, 25 }, rhs = { 6, 11, 16, 21 };

	XPMock.SetIntArray(DataRefBase "dr/addintarr/lhs", lhs);
	XPMock.SetIntArray(DataRefBase "dr/addintarr/rhs", rhs);
	XPMock.SetIntArray(DataRefBase "dr/addintarr/res", std::vector<int>());

	RunPlugin("IntArrayAdderPlugin");

	std::vector<int> arr(min(lhs.size(), rhs.size()));

	bool ret = XPMock.GetIntArray(DataRefBase "dr/addintarr/res", arr);
	ASSERT_EQ(ret, true);
	ASSERT_THAT(arr, ElementsAre(11, 21, 31, 41));
}

TEST_F(DataRefTests, BoolsReadAndWriteFalsey)
{
	bool lhs = false, rhs = false;

	XPMock.SetBool(DataRefBase "dr/xorbool/lhs", lhs);
	XPMock.SetBool(DataRefBase "dr/xorbool/rhs", rhs);
	XPMock.SetBool(DataRefBase "dr/xorbool/res", true);

	RunPlugin("BoolXorPlugin");

	bool ret = XPMock.GetBool(DataRefBase "dr/xorbool/res");
	ASSERT_EQ(ret, false);
}

TEST_F(DataRefTests, BoolsReadAndWriteTruthey)
{
	bool lhs = true, rhs = false;

	XPMock.SetBool(DataRefBase "dr/xorbool/lhs", lhs);
	XPMock.SetBool(DataRefBase "dr/xorbool/rhs", rhs);
	XPMock.SetBool(DataRefBase "dr/xorbool/res", false);

	RunPlugin("BoolXorPlugin");

	bool ret = XPMock.GetBool(DataRefBase "dr/xorbool/res");
	ASSERT_EQ(ret, true);
}

TEST_F(DataRefTests, BoolArraysReadAndWrite)
{
	std::vector<bool> lhs = { false, false, true, true }, rhs = { false, true, false, true };

	XPMock.SetBoolArray(DataRefBase "dr/xorboolarr/lhs", lhs);
	XPMock.SetBoolArray(DataRefBase "dr/xorboolarr/rhs", rhs);
	XPMock.SetBoolArray(DataRefBase "dr/xorboolarr/res", std::vector<bool>());

	RunPlugin("BoolArrayXorPlugin");

	std::vector<bool> arr(max(lhs.size(), rhs.size()));

	bool ret = XPMock.GetBoolArray(DataRefBase "dr/xorboolarr/res", arr);
	ASSERT_EQ(ret, true);
	ASSERT_THAT(arr, ElementsAre(false, true, true, false));
}

TEST_F(DataRefTests, FloatsReadAndWrite)
{
	float lhs = 5.0f, rhs = 11.0f;

	XPMock.SetFloat(DataRefBase "dr/addfloat/lhs", lhs);
	XPMock.SetFloat(DataRefBase "dr/addfloat/rhs", rhs);
	XPMock.SetFloat(DataRefBase "dr/addfloat/res", 0);

	RunPlugin("FloatAdderPlugin");

	float ret = XPMock.GetFloat(DataRefBase "dr/addfloat/res");
	ASSERT_EQ(ret, rhs + lhs);
}

TEST_F(DataRefTests, FloatArraysReadAndWrite)
{
	std::vector<float> lhs = { 5.0f, 10.0f, 15.0f, 20.0f, 25.0f }, rhs = { 6.0f, 11.0f, 16.0f, 21.0f };

	XPMock.SetFloatArray(DataRefBase "dr/addfloatarr/lhs", lhs);
	XPMock.SetFloatArray(DataRefBase "dr/addfloatarr/rhs", rhs);
	XPMock.SetFloatArray(DataRefBase "dr/addfloatarr/res", std::vector<float>());

	RunPlugin("FloatArrayAdderPlugin");

	std::vector<float> arr(min(lhs.size(), rhs.size()));

	bool ret = XPMock.GetFloatArray(DataRefBase "dr/addfloatarr/res", arr);
	ASSERT_EQ(ret, true);
	ASSERT_THAT(arr, ElementsAre(11.0f, 21.0f, 31.0f, 41.0f));
}

TEST_F(DataRefTests, ByteArraysReadAndWrite)
{
	std::vector<BYTE> lhs = { 5, 10, 15, 20, 25 }, rhs = { 6, 11, 16, 21 };

	XPMock.SetByteArray(DataRefBase "dr/addbytearr/lhs", lhs);
	XPMock.SetByteArray(DataRefBase "dr/addbytearr/rhs", rhs);
	XPMock.SetByteArray(DataRefBase "dr/addbytearr/res", std::vector<BYTE>());

	RunPlugin("ByteArrayAdderPlugin");

	std::vector<BYTE> arr(min(lhs.size(), rhs.size()));

	bool ret = XPMock.GetByteArray(DataRefBase "dr/addbytearr/res", arr);
	ASSERT_EQ(ret, true);
	ASSERT_THAT(arr, ElementsAre(11, 21, 31, 41));
}
