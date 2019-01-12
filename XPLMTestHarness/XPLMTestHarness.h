
#pragma once

// If building the test harness itself, pretend for purposes of the X-Plane headers that
// we're actually compiling XPLM itself, so that X-Plane will define XPLM_API to mean
// export.
#ifdef XPLMTESTHARNESS_EXPORTS
#  define XPLM 1
#else
#  define XPLM 0
#endif

// Opt into the XP API version we want.
#define XPLM200
#define XPLM210

// The X-Plane API
#include "XPLMPlugin.h"
#include "XPLMDefs.h"
#include "XPLMDataAccess.h"
#include "XPLMProcessing.h"
#include "XPLMDisplay.h"
#include "XPLMUtilities.h"

typedef enum {
	CommandPhase_Begin,
	CommandPhase_End,
	CommandPhase_Once
} CommandPhase;
using CommandCallback = void(*)(CommandPhase phase);

// Test Harness Functions
//
// These exports allow a test driver to set up the test harness.
//

#define MAX_REGISTERED_DRAW_CALLBACKS 256

XPLM_API void XPHarnessSetPluginPath(const char* pluginPath);

XPLM_API void XPHarnessClearDataRefs();
XPLM_API void XPHarnessClearCommands();
XPLM_API void XPHarnessClearFlightLoops();
XPLM_API void XPHarnessClearDrawCallbacks();

XPLM_API XPLMDataRef XPHarnessFindDataRef(const char* inDataRefName);

#define DECLARE_DATA_SET(code, type) \
	XPLM_API void XPHarnessSetDataRef##code(XPLMDataRef dataRef, type data);

#define DECLARE_DATA_SET_VECTOR(code, type) \
	XPLM_API void XPHarnessSetDataRef##code##v (const char* dataRefName, type* data, int size);

#define DECLARE_DATA_GET(code, type) \
	XPLM_API bool XPHarnessGetDataRef##code (XPLMDataRef dataRef, type& data);
#define DECLARE_DATA_GET_VECTOR(code, type) \
	XPLM_API bool XPHarnessGetDataRef##code##v (const char* dataRefName, type* data, int size);

DECLARE_DATA_SET(i, int)
DECLARE_DATA_SET_VECTOR(i, int)
DECLARE_DATA_SET(f, float)
DECLARE_DATA_SET_VECTOR(f, float)
DECLARE_DATA_SET(d, double)
DECLARE_DATA_SET_VECTOR(b, BYTE)

DECLARE_DATA_GET(i, int)
DECLARE_DATA_GET_VECTOR(i, int)
DECLARE_DATA_GET(f, float)
DECLARE_DATA_GET_VECTOR(f, float)
DECLARE_DATA_GET(d, double)
DECLARE_DATA_GET_VECTOR(b, BYTE)

// These functions are used to add datarefs that a plugin can assume existing during its lifecycle. 
// So those would be typically datarefs provided by X-Plane, or in case of the test plugins, 
// datarefs that are used to communicate between the test host and the plugin.
#define DECLARE_XPHARNESSADDDATAREF(CODE, XPLMTYPE) \
	XPLM_API void XPHarnessAddDataRef(const char * n, XPLMGetData##CODE##_f getData_f, void* readRefcon); \
	XPLM_API void XPHarnessAddDataRef(const char * n, XPLMSetData##CODE##_f setData_f, void* writeRefcon); \
	XPLM_API void XPHarnessAddDataRef(const char * n, XPLMGetData##CODE##_f getData_f, XPLMSetData##CODE##_f setData_f, void* readRefcon, void* writeRefcon);

DECLARE_XPHARNESSADDDATAREF(i, xplmType_Int)
DECLARE_XPHARNESSADDDATAREF(f, xplmType_Float)
DECLARE_XPHARNESSADDDATAREF(d, xplmType_Double)
DECLARE_XPHARNESSADDDATAREF(vi, xplmType_IntArray)
DECLARE_XPHARNESSADDDATAREF(vf, xplmType_FloatArray)
DECLARE_XPHARNESSADDDATAREF(b, xplmType_Data)

XPLM_API XPLMDataRef XPHarnessRegisterDataAccessor(
	const char *         inDataName,
	XPLMDataTypeID       inDataType,
	int                  inIsWritable,
	XPLMGetDatai_f       inReadInt = nullptr,
	XPLMSetDatai_f       inWriteInt = nullptr,
	XPLMGetDataf_f       inReadFloat = nullptr,
	XPLMSetDataf_f       inWriteFloat = nullptr,
	XPLMGetDatad_f       inReadDouble = nullptr,
	XPLMSetDatad_f       inWriteDouble = nullptr,
	XPLMGetDatavi_f      inReadIntArray = nullptr,
	XPLMSetDatavi_f      inWriteIntArray = nullptr,
	XPLMGetDatavf_f      inReadFloatArray = nullptr,
	XPLMSetDatavf_f      inWriteFloatArray = nullptr,
	XPLMGetDatab_f       inReadData = nullptr,
	XPLMSetDatab_f       inWriteData = nullptr,
	void *               inReadRefcon = nullptr,
	void *               inWriteRefcon = nullptr);

XPLM_API void          XPLMUnregisterDataAccessor(
	XPLMDataRef          inDataRef);

XPLM_API void XPHarnessSetCommandCallback(const char* commandName, CommandCallback cb);

XPLM_API void XPHarnessInvokeFlightLoop(float elapsedSinceLastCall, float elapsedTimeSinceLastFlightLoop, int counter);

XPLM_API void XPHarnessInvokeDrawCallback(int results[MAX_REGISTERED_DRAW_CALLBACKS]);

