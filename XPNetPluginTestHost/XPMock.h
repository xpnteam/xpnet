#pragma once

#include <XPLMTestHarness.h>
#include <vector>
#include <algorithm>

static class
{
public:

	void ClearMockedData()
	{
		XPHarnessClearDataRefs();
		XPHarnessClearCommands();
		XPHarnessClearFlightLoops();
		XPHarnessClearDrawCallbacks();
	}

	void SetString(const char* name, std::string str)
	{
		BYTE* pb = reinterpret_cast<BYTE*>(const_cast<char*>(str.c_str()));
		XPHarnessSetDataRefbv(name, pb, static_cast<int>(str.size()));
	}

	std::string GetString(const char* name, const int MaxSize = 1024)
	{
		std::vector<BYTE> v(MaxSize);
		BYTE* pb = v.data();
		bool ret = XPHarnessGetDataRefbv(name, pb, MaxSize);
		if (!ret)
			return "";

		return std::string(reinterpret_cast<char*>(v.data()));
	}

	void SetInt(const char* name, int value)
	{
		XPHarnessSetDataRefi(name, value);
	}

	int GetInt(const char* name, int defaultValue = 0)
	{
		int value = defaultValue;
		bool ret = XPHarnessGetDataRefi(name, &value);
		return ret ? value : defaultValue;
	}

	void SetIntArray(const char* name, std::vector<int> arr)
	{
		XPHarnessSetDataRefiv(name, arr.data(), static_cast<int>(arr.size()));
	}

	bool GetIntArray(const char* name, std::vector<int>& arr)
	{
		int* pValue = arr.data();
		return XPHarnessGetDataRefiv(name, pValue, static_cast<int>(arr.size()));
	}

	void SetBool(const char* name, bool value)
	{
		XPHarnessSetDataRefi(name, value ? 1 : 0);
	}

	int GetBool(const char* name, bool defaultValue = false)
	{
		int value = defaultValue ? 1 : 0;
		bool ret = XPHarnessGetDataRefi(name, &value);
		return ret ? (value ? 1 : 0) : defaultValue;
	}

	void SetBoolArray(const char* name, std::vector<bool> arr)
	{
		std::vector<int> intArr(arr.size());
		std::transform(
			arr.begin(), arr.end(), intArr.begin(),
			[](bool b) -> int { return b ? 1 : 0; }
		);
		SetIntArray(name, intArr);
	}

	bool GetBoolArray(const char* name, std::vector<bool>& arr)
	{
		std::vector<int> intArr(arr.size());
		int* pValue = intArr.data();
		bool ret = XPHarnessGetDataRefiv(name, pValue, static_cast<int>(intArr.size()));
		if (!ret)
			return false;
		std::transform(
			intArr.begin(), intArr.end(), arr.begin(),
			[](int i) -> bool { return i ? true : false; }
		);
		return true;
	}

	void SetFloat(const char* name, float value)
	{
		XPHarnessSetDataReff(name, value);
	}

	float GetFloat(const char* name, float defaultValue = 0)
	{
		float value = defaultValue;
		bool ret = XPHarnessGetDataReff(name, &value);
		return ret ? value : defaultValue;
	}

	void SetFloatArray(const char* name, std::vector<float> arr)
	{
		XPHarnessSetDataReffv(name, arr.data(), static_cast<int>(arr.size()));
	}

	bool GetFloatArray(const char* name, std::vector<float>& arr)
	{
		float* pValue = arr.data();
		return XPHarnessGetDataReffv(name, pValue, static_cast<int>(arr.size()));
	}

	void SetByteArray(const char* name, std::vector<BYTE> arr)
	{
		XPHarnessSetDataRefbv(name, arr.data(), static_cast<int>(arr.size()));
	}

	bool GetByteArray(const char* name, std::vector<BYTE>& arr)
	{
		BYTE* pValue = arr.data();
		return XPHarnessGetDataRefbv(name, pValue, static_cast<int>(arr.size()));
	}

	//void SetFloat(const char* name, double value)
	//{
	//	SetDataReff(name, value);
	//}

	//void SetFloat(const char* name, std::vector<double> arr)
	//{
	//	std::vector<float> v(arr.size());
	//	std::transform(
	//		arr.begin(), arr.end(), v.begin(),
	//		[](double b) -> float { static_cast<float>(b); }
	//	);
	//	SetDataReffv(name, v.data(), static_cast<int>(v.size()));
	//}

	void CreateCommand(const char* name, CommandCallback cb)
	{
		XPHarnessSetCommandCallback(name, cb);
	}

} XPMock;
