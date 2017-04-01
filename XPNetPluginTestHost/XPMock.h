#pragma once

#include <XPLMTestHarness.h>
#include <vector>
#include <algorithm>

class
{
public:

	void SetString(const char* name, std::string str)
	{
		BYTE* pb = reinterpret_cast<BYTE*>(const_cast<char*>(str.c_str()));
		XPHarnessSetDataRefbv(name, pb, static_cast<int>(str.size()));
	}

	void SetInt(const char* name, int value)
	{
		XPHarnessSetDataRefi(name, value);
	}

	void SetInt(const char* name, std::vector<int> arr)
	{
		XPHarnessSetDataRefiv(name, arr.data(), static_cast<int>(arr.size()));
	}

	void SetBool(const char* name, bool value)
	{
		XPHarnessSetDataRefi(name, value ? 1 : 0);
	}

	void SetBool(const char* name, std::vector<bool> arr)
	{
		std::vector<int> intArr(arr.size());
		std::transform(
			arr.begin(), arr.end(), intArr.begin(),
			[](bool b) -> int { return b ? 1 : 0; }
		);
		SetInt(name, intArr);
	}

	void SetFloat(const char* name, float value)
	{
		XPHarnessSetDataReff(name, value);
	}

	void SetFloat(const char* name, std::vector<float> arr)
	{
		XPHarnessSetDataReffv(name, arr.data(), static_cast<int>(arr.size()));
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

} XPMock;
