
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

// Test Harness Functions
//
// These exports extend the X-Plane API to allow a
// test driver to set up the test harness.
//

#define DECLARE_DATA_SET(code, type) \
	XPLM_API void XPHarnessSetDataRef##code (const char* dataRefName, type data);

#define DECLARE_DATA_SET_VECTOR(code, type) \
	XPLM_API void XPHarnessSetDataRef##code##v (const char* dataRefName, type* data, int size);

DECLARE_DATA_SET(i, int)
DECLARE_DATA_SET_VECTOR(i, int)
DECLARE_DATA_SET(f, float)
DECLARE_DATA_SET_VECTOR(f, float)
DECLARE_DATA_SET(d, double)
DECLARE_DATA_SET_VECTOR(b, BYTE)


XPLM_API void XPHarnessInvokeFlightLoop(float elapsedSinceLastCall, float elapsedTimeSinceLastFlightLoop, int counter);

