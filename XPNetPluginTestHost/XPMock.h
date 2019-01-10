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
		XPLMDataRef d = XPHarnessFindDataRef(name);

		XPHarnessSetDataRefi(d, value);
	}

	int GetInt(const char* name, int defaultValue = 0)
	{
		XPLMDataRef d = XPHarnessFindDataRef(name);

		int value = defaultValue;
		bool ret = XPHarnessGetDataRefi(d, value);
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
		XPLMDataRef d = XPHarnessFindDataRef(name);
		XPHarnessSetDataRefi(d, value ? 1 : 0);
	}

	int GetBool(const char* name, bool defaultValue = false)
	{
		XPLMDataRef d = XPHarnessFindDataRef(name);
		int value = defaultValue ? 1 : 0;
		bool ret = XPHarnessGetDataRefi(d, value);
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
		XPLMDataRef d = XPHarnessFindDataRef(name);
		XPHarnessSetDataReff(d, value);
	}

	float GetFloat(const char* name, float defaultValue = 0)
	{
		XPLMDataRef d = XPHarnessFindDataRef(name);
		float value = defaultValue;
		bool ret = XPHarnessGetDataReff(d, value);
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

	template <class T>
	static T GetAccessor(void* inRefcon)
	{
		return *(T*)inRefcon;
	}


	template <class T>
	static int GetArrayAccessorFromVector(void* inRefcon, T * outValues, int inOffset, int inMax)
	{
		std::vector<T>* d = (std::vector<T>*)inRefcon;
		if (!outValues)
			return (int)d->size();

		int numElementsToCopy = min((int)d->size() - inOffset, inMax);
		std::copy_n(d->data() + inOffset, numElementsToCopy, outValues);
		return numElementsToCopy;
	}

	template <class T>
	static void SetAccessor(void* inRefcon, T value)
	{
		*(T*)inRefcon = value;
	}	

	template <class T>
	static void SetArrayAccessorFromVector(void* inRefcon, T * inValues, int inOffset, int inCount)
	{
		std::vector<T>* d = (std::vector<T>*)inRefcon;
		int numElementsToWrite = min(inCount, (int)d->size()) - inOffset;
		if (numElementsToWrite > 0)
			std::copy_n(inValues, numElementsToWrite, d->data() + inOffset);
	}
	
	void CreateCommand(const char* name, CommandCallback cb)
	{
		XPHarnessSetCommandCallback(name, cb);
	}

} XPMock;