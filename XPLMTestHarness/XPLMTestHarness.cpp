// XPLMTestHarness.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "XPLMTestHarness.h"
#include <map>
#include <vector>
#include <string>
#include <algorithm>

using std::map;
using std::string;
using std::vector;
using std::remove;

static int idSource;

// NOTE: The data type naming conventions in this file match those used in the X-Plane API.
// E.g., int is 'i' and int array is 'iv'.  But I defined 'data' as 'bv' (byte vector) instead
// of 'b' like X-Plane does b/c resolving that inconsistency made writing the macros easier.

template <typename T>
struct dataref
{
	dataref(const string n, const T& v)
		: id(++idSource), name(n), value(v)
	{ }

	dataref(const dataref& other)
		: id(other.id), name(other.name), value(other.value)
	{ }

	int id;
	string name;
	T value;

	operator XPLMDataRef ()
	{
		return reinterpret_cast<XPLMDataRef>(static_cast<uintptr_t>(id));
	}

	bool operator == (XPLMDataRef id)
	{
		return static_cast<XPLMDataRef>(*this) == id;
	}
};

struct flightloop
{
	flightloop(const XPLMFlightLoop_f fl, float i)
		: flightLoop(fl), interval(i)
	{ }

	flightloop(const flightloop& other)
		: flightLoop(other.flightLoop), interval(other.interval)
	{ }

	XPLMFlightLoop_f flightLoop;
	float interval;
};

template <typename T>
using datarefmap = map<string, dataref<T>>;

static datarefmap<int> iData;
static datarefmap<vector<int>> ivData;
static datarefmap<float> fData;
static datarefmap<vector<float>> fvData;
static datarefmap<double> dData;
static datarefmap<vector<BYTE>> bvData;

static map<XPLMFlightLoop_f, flightloop> registeredFlightLoops;

template <typename T>
void SetDataRef(const string name, const T& value, datarefmap<T>& container)
{
	auto it = container.find(name);
	if (it == container.end())
		container.emplace(name, dataref<T>(name, value));
	else
		it->second.value = value;
}

template <typename T>
dataref<T>* FindDataRef(XPLMDataRef id, datarefmap<T>& container)
{
	for (auto i = container.begin(), end = container.end(); i != end; ++i)
	{
		if (i->second == id)
			return &i->second;
	}

	return nullptr;
}

template <typename T>
dataref<T>* FindDataRef(const string name, datarefmap<T>& container)
{
	auto it = container.find(name);
	if (it == container.end())
		return nullptr;
	else
		return &it->second;
}


#define DEFINE_DATA_SET(code, type) \
	XPLM_API void XPHarnessSetDataRef##code (const char* dataRefName, type data) { SetDataRef(dataRefName, data, code##Data); }

#define DEFINE_DATA_SET_VECTOR(code, type) \
	XPLM_API void XPHarnessSetDataRef##code##v (const char* dataRefName, type* data, int size) { SetDataRef(dataRefName, vector<type>(data, data + size), code##vData); }

DEFINE_DATA_SET(i, int)
DEFINE_DATA_SET_VECTOR(i, int)
DEFINE_DATA_SET(f, float)
DEFINE_DATA_SET_VECTOR(f, float)
DEFINE_DATA_SET(d, double)
DEFINE_DATA_SET_VECTOR(b, BYTE)


XPLM_API XPLMDataRef          XPLMFindDataRef(
	const char *         inDataRefName)
{
#   define TryReturnDataRef(name, container) { auto it = container.find(name); if (it != container.end()) return it->second; }

	TryReturnDataRef(inDataRefName, iData);
	TryReturnDataRef(inDataRefName, ivData);
	TryReturnDataRef(inDataRefName, fData);
	TryReturnDataRef(inDataRefName, fvData);
	TryReturnDataRef(inDataRefName, dData);
	TryReturnDataRef(inDataRefName, bvData);

	return nullptr;
}

XPLM_API XPLMDataTypeID       XPLMGetDataRefTypes(
	XPLMDataRef          inDataRef)
{
	XPLMDataTypeID types = 0;

	if (FindDataRef(inDataRef, iData))
		types |= xplmType_Int;
	if (FindDataRef(inDataRef, ivData))
		types |= xplmType_IntArray;
	if (FindDataRef(inDataRef, fData))
		types |= xplmType_Float;
	if (FindDataRef(inDataRef, fvData))
		types |= xplmType_FloatArray;
	if (FindDataRef(inDataRef, dData))
		types |= xplmType_Double;
	if (FindDataRef(inDataRef, bvData))
		types |= xplmType_Data;

	return types;
}

XPLM_API int                  XPLMGetDatai(
	XPLMDataRef          inDataRef)
{
	auto d = FindDataRef(inDataRef, iData);
	return d ? d->value : 0;
}

XPLM_API void                 XPLMSetDatai(
	XPLMDataRef          inDataRef,
	int                  inValue)
{
	auto d = FindDataRef(inDataRef, iData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	d->value = inValue;
}

XPLM_API float                XPLMGetDataf(
	XPLMDataRef          inDataRef)
{
	auto d = FindDataRef(inDataRef, fData);
	return d ? d->value : 0;
}

XPLM_API void                 XPLMSetDataf(
	XPLMDataRef          inDataRef,
	float                inValue)
{
	auto d = FindDataRef(inDataRef, fData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	d->value = inValue;
}

XPLM_API double               XPLMGetDatad(
	XPLMDataRef          inDataRef)
{
	auto d = FindDataRef(inDataRef, dData);
	return d ? d->value : 0;
}

XPLM_API void                 XPLMSetDatad(
	XPLMDataRef          inDataRef,
	double               inValue)
{
	auto d = FindDataRef(inDataRef, dData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	d->value = inValue;
}

XPLM_API int                  XPLMGetDatavi(
	XPLMDataRef          inDataRef,
	int *                outValues,    /* Can be NULL */
	int                  inOffset,
	int                  inMax)
{
	auto d = FindDataRef(inDataRef, ivData);
	if (!d)
		return 0;

	if (outValues)
		std::copy_n(d->value.begin(), min(d->value.size(), inMax), outValues + inOffset);

	return static_cast<int>(d->value.size());
}

XPLM_API void                 XPLMSetDatavi(
	XPLMDataRef          inDataRef,
	int *                inValues,
	int                  inoffset,
	int                  inCount)
{
	auto d = FindDataRef(inDataRef, ivData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	d->value = vector<int>(inValues + inoffset, inValues + inoffset + inCount);
}

XPLM_API int                  XPLMGetDatavf(
	XPLMDataRef          inDataRef,
	float *              outValues,    /* Can be NULL */
	int                  inOffset,
	int                  inMax)
{
	auto d = FindDataRef(inDataRef, fvData);
	if (!d)
		return 0;

	if (outValues)
		std::copy_n(d->value.begin(), min(d->value.size(), inMax), outValues + inOffset);

	return static_cast<int>(d->value.size());
}

XPLM_API void                 XPLMSetDatavf(
	XPLMDataRef          inDataRef,
	float *              inValues,
	int                  inoffset,
	int                  inCount)
{
	auto d = FindDataRef(inDataRef, fvData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	d->value = vector<float>(inValues + inoffset, inValues + inoffset + inCount);
}

XPLM_API int                  XPLMGetDatab(
	XPLMDataRef          inDataRef,
	void *               outValue,    /* Can be NULL */
	int                  inOffset,
	int                  inMaxBytes)
{
	auto d = FindDataRef(inDataRef, bvData);
	if (!d)
		return 0;

	if (outValue)
		std::copy_n(d->value.begin(), min(d->value.size(), inMaxBytes), reinterpret_cast<BYTE*>(outValue) + inOffset);

	return static_cast<int>(d->value.size());
}

XPLM_API void                 XPLMSetDatab(
	XPLMDataRef          inDataRef,
	void *               inValue,
	int                  inOffset,
	int                  inLength)
{
	auto d = FindDataRef(inDataRef, bvData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	BYTE* inValueBytes = reinterpret_cast<BYTE*>(inValue);
	d->value = vector<BYTE>(inValueBytes + inOffset, inValueBytes + inOffset + inLength);
}

XPLM_API float                XPLMGetElapsedTime(void)
{
	return 4242.0f;
}

XPLM_API int                  XPLMGetCycleNumber(void)
{
	return 84848484;
}

XPLM_API void                 XPLMRegisterFlightLoopCallback(
	XPLMFlightLoop_f     inFlightLoop,
	float                inInterval,
	void *               inRefcon)
{
	registeredFlightLoops.emplace(inFlightLoop, flightloop(inFlightLoop, inInterval));
}

XPLM_API void                 XPLMUnregisterFlightLoopCallback(
	XPLMFlightLoop_f     inFlightLoop,
	void *               inRefcon)
{
	registeredFlightLoops.erase(inFlightLoop);
}

XPLM_API void                 XPLMSetFlightLoopCallbackInterval(
	XPLMFlightLoop_f     inFlightLoop,
	float                inInterval,
	int                  inRelativeToNow,
	void *               inRefcon)
{
	// ENHANCE: Implement.
}

XPLM_API XPLMFlightLoopID     XPLMCreateFlightLoop(
	XPLMCreateFlightLoop_t * inParams)
{
	// Not implemented b/c we don't use it in XPNet.
	return nullptr;
}

XPLM_API void                 XPLMDestroyFlightLoop(
	XPLMFlightLoopID     inFlightLoopID)
{
	// Not implemented b/c we don't use it in XPNet.
}

XPLM_API void                 XPLMScheduleFlightLoop(
	XPLMFlightLoopID     inFlightLoopID,
	float                inInterval,
	int                  inRelativeToNow)
{
	// Not implemented b/c we don't use it in XPNet.
}

XPLM_API void XPHarnessInvokeFlightLoop(float elapsedSinceLastCall, float elapsedTimeSinceLastFlightLoop, int counter)
{
	for (auto p = registeredFlightLoops.begin(); p != registeredFlightLoops.end(); ++p)
		p->first(elapsedSinceLastCall, elapsedTimeSinceLastFlightLoop, counter, nullptr);
}
