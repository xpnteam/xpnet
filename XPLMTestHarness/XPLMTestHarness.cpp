// XPLMTestHarness.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include "XPLMTestHarness.h"
#include "XPLMScenery.h"
#include "XPLMGraphics.h"
#include <map>
#include <tuple>
#include <vector>
#include <string>
#include <algorithm>
#include <iostream>

using std::map;
using std::tuple;
using std::make_tuple;
using std::string;
using std::vector;
using std::remove;

static int idSource;

// NOTE: The data type naming conventions in this file match those used in the X-Plane API.
// E.g., int is 'i' and int array is 'iv'.  But I defined 'data' as 'bv' (byte vector) instead
// of 'b' like X-Plane does b/c resolving that inconsistency made writing the macros easier.

struct customdataref
{
	customdataref(const string n, XPLMDataTypeID inDataType, int inIsWritable, 
		XPLMGetDatai_f inReadInt, XPLMSetDatai_f inWriteInt,
		XPLMGetDataf_f inReadFloat, XPLMSetDataf_f inWriteFloat,
		XPLMGetDatad_f inReadDouble, XPLMSetDatad_f inWriteDouble,
		XPLMGetDatavi_f inReadIntArray, XPLMSetDatavi_f inWriteIntArray,
		XPLMGetDatavf_f inReadFloatArray, XPLMSetDatavf_f inWriteFloatArray,
		XPLMGetDatab_f inReadData, XPLMSetDatab_f inWriteData,
		void* inReadRefcon, void* inWriteRefcon
	)
		: id(++idSource), name(n), dataType(inDataType), isWritable(inIsWritable), 
		getDatai_f(inReadInt), setDatai_f(inWriteInt),
		getDataf_f(inReadFloat), setDataf_f(inWriteFloat),
		getDatad_f(inReadDouble), setDatad_f(inWriteDouble),
		getDatavi_f(inReadIntArray), setDatavi_f(inWriteIntArray),
		getDatavf_f(inReadFloatArray), setDatavf_f(inWriteFloatArray),
		getDatab_f(inReadData), setDatab_f(inWriteData),
		readRefcon(inReadRefcon), writeRefcon(inWriteRefcon)
	{ }

	customdataref(const string n, XPLMDataTypeID inDataType, int inIsWritable,
		void* inReadRefcon, void* inWriteRefcon = nullptr
	)
		: id(++idSource), name(n), dataType(inDataType), isWritable(inIsWritable),
		readRefcon(inReadRefcon), writeRefcon(inWriteRefcon)
	{ }

	customdataref(const customdataref& other)
		: id(other.id), name(other.name), dataType(other.dataType), isWritable(other.isWritable), 
		getDatai_f(other.getDatai_f), setDatai_f(other.setDatai_f),
		getDataf_f(other.getDataf_f), setDataf_f(other.setDataf_f),
		getDatad_f(other.getDatad_f), setDatad_f(other.setDatad_f),
		getDatavi_f(other.getDatavi_f), setDatavi_f(other.setDatavi_f),
		getDatavf_f(other.getDatavf_f), setDatavf_f(other.setDatavf_f),
		getDatab_f(other.getDatab_f), setDatab_f(other.setDatab_f),
		readRefcon(other.readRefcon), writeRefcon(other.writeRefcon)
	{ }

	int id;
	string name;
	XPLMDataTypeID       dataType;
	int                  isWritable;
	XPLMGetDatai_f       getDatai_f;
	XPLMSetDatai_f       setDatai_f;
	XPLMGetDataf_f       getDataf_f;	
	XPLMSetDataf_f       setDataf_f;
	XPLMGetDatad_f       getDatad_f;
	XPLMSetDatad_f       setDatad_f;
	XPLMGetDatavi_f      getDatavi_f;
	XPLMSetDatavi_f      setDatavi_f;
	XPLMGetDatavf_f      getDatavf_f;
	XPLMSetDatavf_f      setDatavf_f;
	XPLMGetDatab_f       getDatab_f;
	XPLMSetDatab_f       setDatab_f;
	void *               readRefcon;
	void *               writeRefcon;


	operator XPLMDataRef ()
	{
		return reinterpret_cast<XPLMDataRef>(static_cast<uintptr_t>(id));
	}

	bool operator == (XPLMDataRef id)
	{
		return static_cast<XPLMDataRef>(*this) == id;
	}
};

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

struct command
{
	command(const string n, CommandCallback cb)
		: id(++idSource), name(n), callback(cb)
	{ }

	command(const command& other)
		: id(other.id), name(other.name), callback(other.callback)
	{ }

	int id;
	string name;
	CommandCallback callback;

	operator XPLMCommandRef ()
	{
		return reinterpret_cast<XPLMCommandRef>(static_cast<uintptr_t>(id));
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
	bool deleted = false;
};

struct drawcallback
{
	drawcallback(const XPLMDrawCallback_f dc, const XPLMDrawingPhase phase, int wb)
		: drawCallback(dc), drawingPhase(phase), wantsBefore(wb) 
	{ }

	XPLMDrawCallback_f drawCallback;
	XPLMDrawingPhase drawingPhase;
	int wantsBefore;
	bool deleted = false;
};

template <typename T>
using datarefmap = map<string, dataref<T>>;

static datarefmap<int> iData;
static datarefmap<vector<int>> ivData;
static datarefmap<float> fData;
static datarefmap<vector<float>> fvData;
static datarefmap<double> dData;
static datarefmap<vector<BYTE>> bvData;

using customdatarefmap = map<string, customdataref>;
static customdatarefmap customDataRefs;

using commandmap = map<string, command>;
static commandmap configuredCommands;

using flightloopmap = map<XPLMFlightLoop_f, flightloop>;
static flightloopmap registeredFlightLoops;

using drawcallbackmap = map<tuple<XPLMDrawCallback_f, XPLMDrawingPhase, int>, drawcallback>;
static drawcallbackmap registeredDrawCallbacks;

static std::string mockPluginPath;

XPLM_API void XPHarnessSetPluginPath(const char* pluginPath)
{
	mockPluginPath = pluginPath;
}

XPLM_API void XPHarnessClearDataRefs()
{
	customDataRefs.clear();
	ivData.clear();
	fData.clear();
	fvData.clear();
	dData.clear();
	bvData.clear();
}

XPLM_API void XPHarnessClearCommands()
{
	configuredCommands.clear();
}

XPLM_API void XPHarnessClearFlightLoops()
{
	registeredFlightLoops.clear();
}

XPLM_API void XPHarnessClearDrawCallbacks()
{
	registeredDrawCallbacks.clear();
}

XPLM_API XPLMDataRef XPHarnessFindDataRef(const char * inDataRefName)
{
	return XPLMFindDataRef(inDataRefName);
}

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
bool GetDataRef(const string name, T& value, datarefmap<T>& container)
{
	auto it = container.find(name);
	if (it == container.end())
		return false;

	value = it->second.value;
	return true;
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


customdataref* FindCustomDataRef(XPLMDataRef id)
{
	for (auto i = customDataRefs.begin(), end = customDataRefs.end(); i != end; ++i)
	{
		if (i->second == id)
			return &i->second;
	}

	return nullptr;
}

command* FindCommand(XPLMCommandRef id, commandmap& container)
{
	for (auto i = container.begin(), end = container.end(); i != end; ++i)
	{
		if (i->second == id)
			return &i->second;
	}

	return nullptr;
}

#define DEFINE_DATA_SET(code, type) \
	XPLM_API void XPHarnessSetDataRef##code (XPLMDataRef dataRef, type data) { XPLMSetData##code(dataRef, data); }

#define DEFINE_DATA_SET_VECTOR(code, type) \
	XPLM_API void XPHarnessSetDataRef##code##v (const char* dataRefName, type* data, int size) { SetDataRef(dataRefName, vector<type>(data, data + size), code##vData); }

#define DEFINE_DATA_GET(code, type) \
	XPLM_API bool XPHarnessGetDataRef##code (XPLMDataRef dataRef, type& data) { data = XPLMGetData##code(dataRef); return true; }

#define DEFINE_DATA_GET_VECTOR(code, type) \
	XPLM_API bool XPHarnessGetDataRef##code##v (const char* dataRefName, type* data, int size) { \
        vector<type> arr(data, data + size); \
		bool ret = GetDataRef(dataRefName, arr, code##vData); \
		if (!ret) return ret; \
        std::memcpy(data, arr.data(), size * sizeof(type)); \
		return true; \
    }

DEFINE_DATA_SET(i, int)
DEFINE_DATA_SET_VECTOR(i, int)
DEFINE_DATA_SET(f, float)
DEFINE_DATA_SET_VECTOR(f, float)
DEFINE_DATA_SET(d, double)
DEFINE_DATA_SET_VECTOR(b, BYTE)

DEFINE_DATA_GET(i, int)
DEFINE_DATA_GET_VECTOR(i, int)
DEFINE_DATA_GET(f, float)
DEFINE_DATA_GET_VECTOR(f, float)
DEFINE_DATA_GET(d, double)
DEFINE_DATA_GET_VECTOR(b, BYTE)

XPLM_API XPLMDataRef XPHarnessRegisterDataAccessor(
	const char *         inDataName,
	XPLMDataTypeID       inDataType,
	int                  inIsWritable,
	XPLMGetDatai_f       inReadInt,
	XPLMSetDatai_f       inWriteInt,
	XPLMGetDataf_f       inReadFloat,
	XPLMSetDataf_f       inWriteFloat,
	XPLMGetDatad_f       inReadDouble,
	XPLMSetDatad_f       inWriteDouble,
	XPLMGetDatavi_f      inReadIntArray,
	XPLMSetDatavi_f      inWriteIntArray,
	XPLMGetDatavf_f      inReadFloatArray,
	XPLMSetDatavf_f      inWriteFloatArray,
	XPLMGetDatab_f       inReadData,
	XPLMSetDatab_f       inWriteData,
	void *               inReadRefcon,
	void *               inWriteRefcon)
{
	return XPLMRegisterDataAccessor(inDataName, inDataType, inIsWritable, inReadInt,
		inWriteInt, inReadFloat, inWriteFloat, inReadDouble,
		inWriteDouble, inReadIntArray, inWriteIntArray, inReadFloatArray,
		inWriteFloatArray, inReadData, inWriteData, inReadRefcon, inWriteRefcon);
}

XPLM_API XPLMPluginID         XPLMGetMyID(void)
{
	return 1;
}

XPLM_API void                 XPLMDebugString(
	const char *         inString)
{
	std::cout << inString;
}

XPLM_API void                 XPLMEnableFeature(
	const char *         inFeature,
	int                  inEnable)
{
	// Not implemented.
}

XPLM_API void                 XPLMGetPluginInfo(
	XPLMPluginID         inPlugin,
	char *               outName,    /* Can be NULL */
	char *               outFilePath,    /* Can be NULL */
	char *               outSignature,    /* Can be NULL */
	char *               outDescription)    /* Can be NULL */
{
	if (outName)
		strcp(outName, "XPLMTestHarness");

	if (outFilePath)
	{
		if (mockPluginPath.empty())
		{
			// Heuristic: assume that we're in the test environment,
			// wherein the cwd is like x64/Debug and we want to
			// simulate running from, e.g., x64/Debug/64/win.xpl.
			// We need to get the bitness right for the current
			// platform, but the actual XPL name we report doesn't
			// matter.

			std::string hostPath = "./";

#ifdef PLATX64
			hostPath += "64/";
#elif defined(PLATX86)
			hostPath += "32/";
#else
#  error PLATX86 or PLATX64 must be defined.
#endif

			hostPath += "plat.xpl";

			fs::path fp = hostPath;
			strcp(outFilePath, fs::absolute(fp).c_str());
		}
		else
		{
			strcp(outFilePath, mockPluginPath.c_str());
		}
	}

	if (outSignature)
		strcp(outSignature, "1234");

	if (outDescription)
		strcp(outDescription, "Info provided by the test harness for XPNet, which simulates the X-Plane API.");
}

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
	TryReturnDataRef(inDataRefName, customDataRefs);
	return nullptr;
}

XPLM_API XPLMDataTypeID       XPLMGetDataRefTypes(
	XPLMDataRef          inDataRef)
{
	auto customDataRef = FindCustomDataRef(inDataRef);
	if (customDataRef)
		return customDataRef->dataType;

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
	if (auto c = FindCustomDataRef(inDataRef))
		return c->getDatai_f(c->readRefcon);
	else
		return 0;
}

XPLM_API void                 XPLMSetDatai(
	XPLMDataRef          inDataRef,
	int                  inValue)
{
	if (auto c = FindCustomDataRef(inDataRef))
	{
		c->setDatai_f(c->writeRefcon, inValue);
		return;
	}
}

XPLM_API float                XPLMGetDataf(
	XPLMDataRef          inDataRef)
{
	if (auto c = FindCustomDataRef(inDataRef))
		return c->getDataf_f(c->readRefcon);
	else
		return 0;
}

XPLM_API void                 XPLMSetDataf(
	XPLMDataRef          inDataRef,
	float                inValue)
{
	if (auto c = FindCustomDataRef(inDataRef))
	{
		c->setDataf_f(c->writeRefcon, inValue);
		return;
	}
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
	if (auto c = FindCustomDataRef(inDataRef))
		return c->getDatavi_f(c->readRefcon, outValues, inOffset, inMax);

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
	if (auto c = FindCustomDataRef(inDataRef))
		return c->setDatavi_f(c->writeRefcon, inValues, inoffset, inCount);

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
	if (auto c = FindCustomDataRef(inDataRef))
		return c->getDatavf_f(c->readRefcon, outValues, inOffset, inMax);

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
	if (auto c = FindCustomDataRef(inDataRef))
		return c->setDatavf_f(c->writeRefcon, inValues, inoffset, inCount);

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
	if (auto c = FindCustomDataRef(inDataRef))
		return c->getDatab_f(c->readRefcon, outValue, inOffset, inMaxBytes);
	else
		return 0;

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
	if (auto c = FindCustomDataRef(inDataRef))
	{
		c->setDatab_f(c->writeRefcon, inValue, inOffset, inLength);
		return;
	}

	auto d = FindDataRef(inDataRef, bvData);
	if (!d)
		return; // Dataref isn't defined, can't set it.
	BYTE* inValueBytes = reinterpret_cast<BYTE*>(inValue);
	d->value = vector<BYTE>(inValueBytes + inOffset, inValueBytes + inOffset + inLength);
}

XPLM_API XPLMDataRef          XPLMRegisterDataAccessor(
	const char *         inDataName,
	XPLMDataTypeID       inDataType,
	int                  inIsWritable,
	XPLMGetDatai_f       inReadInt,
	XPLMSetDatai_f       inWriteInt,
	XPLMGetDataf_f       inReadFloat,
	XPLMSetDataf_f       inWriteFloat,
	XPLMGetDatad_f       inReadDouble,
	XPLMSetDatad_f       inWriteDouble,
	XPLMGetDatavi_f      inReadIntArray,
	XPLMSetDatavi_f      inWriteIntArray,
	XPLMGetDatavf_f      inReadFloatArray,
	XPLMSetDatavf_f      inWriteFloatArray,
	XPLMGetDatab_f       inReadData,
	XPLMSetDatab_f       inWriteData,
	void *               inReadRefcon,
	void *               inWriteRefcon)
{
	auto dref = customdataref(inDataName, inDataType, inIsWritable, inReadInt,
		inWriteInt, inReadFloat, inWriteFloat, inReadDouble,
		inWriteDouble, inReadIntArray, inWriteIntArray, inReadFloatArray,
		inWriteFloatArray, inReadData, inWriteData, inReadRefcon, inWriteRefcon);
	customDataRefs.emplace(inDataName, dref);
	return dref;
}

XPLM_API void          XPLMUnregisterDataAccessor(
	XPLMDataRef          inDataRef)
{
	for (auto i = customDataRefs.begin(), end = customDataRefs.end(); i != end; ++i)
	{
		if (i->second == inDataRef) 
		{
			customDataRefs.erase(i);
			return;
		}
	}
}

#define DEFINE_XPHARNESSADDDATAREF(CODE, XPLMTYPE) \
	XPLM_API void XPHarnessAddDataRef(const char * n, XPLMGetData##CODE##_f getData_f, void* readRefcon) \
	{ auto dref = customdataref(n, ##XPLMTYPE##, 0, readRefcon); dref.getData##CODE##_f = getData_f; dref.readRefcon  = readRefcon; customDataRefs.emplace(n, dref); } \
	XPLM_API void XPHarnessAddDataRef(const char * n, XPLMSetData##CODE##_f setData_f, void* writeRefcon) \
	{ auto dref = customdataref(n, ##XPLMTYPE##, 1, writeRefcon); dref.setData##CODE##_f = setData_f; dref.writeRefcon  = writeRefcon; customDataRefs.emplace(n, dref); } \
	XPLM_API void XPHarnessAddDataRef(const char * n, XPLMGetData##CODE##_f getData_f, XPLMSetData##CODE##_f setData_f, void* readRefcon, void* writeRefcon) \
	{ auto dref = customdataref(n, ##XPLMTYPE##, 1, readRefcon, writeRefcon); dref.getData##CODE##_f = getData_f; dref.setData##CODE##_f = setData_f; dref.readRefcon = readRefcon; dref.writeRefcon = writeRefcon; customDataRefs.emplace(n, dref); }

DEFINE_XPHARNESSADDDATAREF(i, xplmType_Int)
DEFINE_XPHARNESSADDDATAREF(f, xplmType_Float)
DEFINE_XPHARNESSADDDATAREF(d, xplmType_Double)
DEFINE_XPHARNESSADDDATAREF(vi, xplmType_IntArray)
DEFINE_XPHARNESSADDDATAREF(vf, xplmType_FloatArray)
DEFINE_XPHARNESSADDDATAREF(b, xplmType_Data)

XPLM_API void XPHarnessSetCommandCallback(const char* commandName, CommandCallback cb)
{
	configuredCommands.emplace(commandName, command(commandName, cb));
}

XPLM_API XPLMCommandRef       XPLMFindCommand(
	const char *         inName)
{
	auto it = configuredCommands.find(inName);
	if (it != configuredCommands.end())
		return it->second;
	return nullptr;
}

XPLM_API void                 XPLMCommandBegin(
	XPLMCommandRef       inCommand)
{
	auto c = FindCommand(inCommand, configuredCommands);
	if (!c)
		return; // Command isn't defined, can't invoke it.

	c->callback(CommandPhase_Begin);
}

XPLM_API void                 XPLMCommandEnd(
	XPLMCommandRef       inCommand)
{
	auto c = FindCommand(inCommand, configuredCommands);
	if (!c)
		return; // Command isn't defined, can't invoke it.

	c->callback(CommandPhase_End);
}

XPLM_API void                 XPLMCommandOnce(
	XPLMCommandRef       inCommand)
{
	auto c = FindCommand(inCommand, configuredCommands);
	if (!c)
		return; // Command isn't defined, can't invoke it.

	c->callback(CommandPhase_Once);
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
	auto cb = registeredFlightLoops.find(inFlightLoop);
	cb->second.deleted = true;
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
	// Before invoking clean up all the unregistered flight loops.
	auto it = registeredFlightLoops.begin();
	while (it != registeredFlightLoops.end())
	{
		if (it->second.deleted)
			it = registeredFlightLoops.erase(it);
		else
			++it;
	}

	for (auto p = registeredFlightLoops.begin(); p != registeredFlightLoops.end(); ++p)
		p->first(elapsedSinceLastCall, elapsedTimeSinceLastFlightLoop, counter, nullptr);
}

XPLM_API int                  XPLMRegisterDrawCallback(
	XPLMDrawCallback_f   inCallback,
	XPLMDrawingPhase     inPhase,
	int                  inWantsBefore,
	void *               inRefcon)
{
	registeredDrawCallbacks.emplace(make_tuple(inCallback, inPhase, inWantsBefore), drawcallback(inCallback, inPhase, inWantsBefore));
	return 1;
}

XPLM_API int                  XPLMUnregisterDrawCallback(
	XPLMDrawCallback_f   inCallback,
	XPLMDrawingPhase     inPhase,
	int                  inWantsBefore,
	void *               inRefcon)
{
	auto cb = registeredDrawCallbacks.find(make_tuple(inCallback, inPhase, inWantsBefore));
	cb->second.deleted = true;
	return 1;
}

XPLM_API void XPHarnessInvokeDrawCallback(int results[MAX_REGISTERED_DRAW_CALLBACKS])
{
	// Before invoking clean up all the unregistered draw callbacks.
	auto it = registeredFlightLoops.begin();
	while (it != registeredFlightLoops.end())
	{
		if (it->second.deleted)
			it = registeredFlightLoops.erase(it);
		else
			++it;
	}

	int *pResult = &results[0];
	for (auto p = registeredDrawCallbacks.begin(); p != registeredDrawCallbacks.end(); ++p, ++pResult)
		*pResult = p->second.drawCallback(p->second.drawingPhase, p->second.wantsBefore, nullptr);
}

XPLM_API XPLMProbeRef         XPLMCreateProbe(
	XPLMProbeType        inProbeType) 
{
	return reinterpret_cast<XPLMProbeRef>(static_cast<uintptr_t>(43));
}

XPLM_API void                 XPLMDestroyProbe(
	XPLMProbeRef         inProbe) 
{
}

XPLM_API XPLMProbeResult      XPLMProbeTerrainXYZ(
	XPLMProbeRef         inProbe,
	float                inX,
	float                inY,
	float                inZ,
	XPLMProbeInfo_t *    outInfo)
{
	outInfo->locationX = inX;
	outInfo->locationY = 42;
	outInfo->locationZ = inZ;
	return xplm_ProbeHitTerrain;
}

XPLM_API XPLMObjectRef        XPLMLoadObject(
	const char *         inPath) 
{
	return reinterpret_cast<XPLMObjectRef>(static_cast<uintptr_t>(42));
}

XPLM_API void                 XPLMLoadObjectAsync(
	const char *         inPath,
	XPLMObjectLoaded_f   inCallback,
	void *               inRefcon) 
{
	inCallback(reinterpret_cast<XPLMObjectRef>(static_cast<uintptr_t>(42)), nullptr);
}

XPLM_API void                 XPLMDrawObjects(
	XPLMObjectRef        inObject,
	int                  inCount,
	XPLMDrawInfo_t *     inLocations,
	int                  lighting,
	int                  earth_relative)
{
}

XPLM_API void                 XPLMUnloadObject(
	XPLMObjectRef        inObject)
{
}

XPLM_API int                  XPLMLookupObjects(
	const char *         inPath,
	float                inLatitude,
	float                inLongitude,
	XPLMLibraryEnumerator_f enumerator,
	void *               ref)
{
	std::string fullPath ("/realpath/");
	fullPath.append(inPath);
	enumerator(fullPath.c_str(), ref);
	return 1;
}

XPLM_API void                 XPLMWorldToLocal(
	double               inLatitude,
	double               inLongitude,
	double               inAltitude,
	double *             outX,
	double *             outY,
	double *             outZ)
{
	*outX = inLongitude;
	*outY = inAltitude;
	*outZ = inLatitude;
}

XPLM_API void                 XPLMLocalToWorld(
	double               inX,
	double               inY,
	double               inZ,
	double *             outLatitude,
	double *             outLongitude,
	double *             outAltitude)
{
	*outLongitude = inX;
	*outAltitude = inY;
	*outLatitude = inZ;
}
