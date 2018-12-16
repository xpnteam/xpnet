
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

#define DECLARE_DATA_SET(code, type) \
	XPLM_API void XPHarnessSetDataRef##code (const char* dataRefName, type data);

#define DECLARE_DATA_SET_VECTOR(code, type) \
	XPLM_API void XPHarnessSetDataRef##code##v (const char* dataRefName, type* data, int size);

#define DECLARE_DATA_GET(code, type) \
	XPLM_API bool XPHarnessGetDataRef##code (const char* dataRefName, type* data);
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

XPLM_API void XPHarnessSetCommandCallback(const char* commandName, CommandCallback cb);

XPLM_API void XPHarnessInvokeFlightLoop(float elapsedSinceLastCall, float elapsedTimeSinceLastFlightLoop, int counter);

XPLM_API void XPHarnessInvokeDrawCallback(int results[MAX_REGISTERED_DRAW_CALLBACKS]);

