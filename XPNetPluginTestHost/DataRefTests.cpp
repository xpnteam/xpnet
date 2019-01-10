
#include "TestCore.h"

// TODO: Test for InvalidOperationException trying to get a dataref that X-Plane doesn't respond to.

class DataRefTests : public PluginTestsBase
{
};

TEST_F(DataRefTests, StringsReadAndWrite)
{
	std::vector<BYTE> lhs = { 'f', 'o', 'o', 0 };
	std::vector<BYTE> rhs = { 'b', 'a', 'r', 0 };
	std::vector<BYTE> res(lhs.size(), rhs.size());

	XPHarnessAddDataRef(DataRefBase "dr/addstring/lhs", (XPLMGetDatab_f)XPMock.GetArrayAccessorFromVector<BYTE>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/addstring/rhs", (XPLMGetDatab_f)XPMock.GetArrayAccessorFromVector<BYTE>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/addstring/res", (XPLMSetDatab_f)XPMock.GetArrayAccessorFromVector<BYTE>, &res);

	RunPlugin("StringAdderPlugin");

	ASSERT_EQ((const char*)res.data, "foobar");
}

TEST_F(DataRefTests, IntsReadAndWrite)
{
	int lhs = 5, rhs = 11, res = 0;

	XPHarnessAddDataRef(DataRefBase "dr/addint/lhs", XPMock.GetAccessor<int>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/addint/rhs", XPMock.GetAccessor<int>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/addint/res", XPMock.SetAccessor<int>, &res);

	RunPlugin("IntAdderPlugin");

	ASSERT_EQ(res, rhs + lhs);
}

TEST_F(DataRefTests, IntArraysReadAndWrite)
{
	std::vector<int> lhs = { 5, 10, 15, 20, 25 }, rhs = { 6, 11, 16, 21 };
	std::vector<int> res(min(lhs.size(), rhs.size()));

	XPHarnessAddDataRef(DataRefBase "dr/addintarr/lhs", XPMock.GetArrayAccessorFromVector<int>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/addintarr/rhs", XPMock.GetArrayAccessorFromVector<int>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/addintarr/res", XPMock.SetArrayAccessorFromVector<int>, &res);

	RunPlugin("IntArrayAdderPlugin");

	ASSERT_THAT(res, ElementsAre(11, 21, 31, 41));
}

TEST_F(DataRefTests, BoolsReadAndWriteFalsey)
{
	int lhs = false, rhs = false;
	int res = true;

	XPHarnessAddDataRef(DataRefBase "dr/xorbool/lhs", XPMock.GetAccessor<int>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/xorbool/rhs", XPMock.GetAccessor<int>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/xorbool/res", XPMock.SetAccessor<int>, &res);

	RunPlugin("BoolXorPlugin");

	ASSERT_EQ(res, false);
}

TEST_F(DataRefTests, BoolsReadAndWriteTruthey)
{
	int lhs = true, rhs = false;
	int res = false;

	XPHarnessAddDataRef(DataRefBase "dr/xorbool/lhs", XPMock.GetAccessor<int>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/xorbool/rhs", XPMock.GetAccessor<int>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/xorbool/res", XPMock.SetAccessor<int>, &res);

	RunPlugin("BoolXorPlugin");

	ASSERT_EQ(res, true);
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
	float lhs = 5.0f, rhs = 11.0f, res = 0.f;

	XPHarnessAddDataRef(DataRefBase "dr/addfloat/lhs", XPMock.GetAccessor<float>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/addfloat/rhs", XPMock.GetAccessor<float>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/addfloat/res", XPMock.SetAccessor<float>, &res);
	
	RunPlugin("FloatAdderPlugin");

	ASSERT_EQ(res, rhs + lhs);
}

TEST_F(DataRefTests, FloatArraysReadAndWrite)
{
	std::vector<float> lhs = { 5.0f, 10.0f, 15.0f, 20.0f, 25.0f }, rhs = { 6.0f, 11.0f, 16.0f, 21.0f };
	std::vector<float> res(min(lhs.size(), rhs.size()));

	XPHarnessAddDataRef(DataRefBase "dr/addfloatarr/lhs", XPMock.GetArrayAccessorFromVector<float>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/addfloatarr/rhs", XPMock.GetArrayAccessorFromVector<float>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/addfloatarr/res", XPMock.SetArrayAccessorFromVector<float>, &res);

	RunPlugin("FloatArrayAdderPlugin");

	ASSERT_THAT(res, ElementsAre(11.0f, 21.0f, 31.0f, 41.0f));
}

TEST_F(DataRefTests, ByteArraysReadAndWrite)
{
	std::vector<BYTE> lhs = { 5, 10, 15, 20, 25 }, rhs = { 6, 11, 16, 21 };
	std::vector<BYTE> res(min(lhs.size(), rhs.size()));

	XPHarnessAddDataRef(DataRefBase "dr/addbytearr/lhs", (XPLMGetDatab_f)XPMock.GetArrayAccessorFromVector<BYTE>, &lhs);
	XPHarnessAddDataRef(DataRefBase "dr/addbytearr/rhs", (XPLMGetDatab_f)XPMock.GetArrayAccessorFromVector<BYTE>, &rhs);
	XPHarnessAddDataRef(DataRefBase "dr/addbytearr/res", (XPLMSetDatab_f)XPMock.SetArrayAccessorFromVector<BYTE>, &res);

	RunPlugin("ByteArrayAdderPlugin");

	ASSERT_THAT(res, ElementsAre(11, 21, 31, 41));
}

TEST_F(DataRefTests, CustomDataRefPlugin)
{
	int res2 = -1;

	XPHarnessAddDataRef(DataRefBase "cdr/test2", XPMock.SetAccessor<int>, &res2);
	RunPlugin("CustomDataRefPlugin");
	auto ref1 = XPLMFindDataRef(DataRefBase "cdr/test1");
	int res1 = XPLMGetDatai(ref1);
	XPLMSetDatai(ref1, 42);

	ASSERT_EQ(res1, 3);
	ASSERT_EQ(res2, 46);
}
