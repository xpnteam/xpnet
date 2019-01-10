
// XPNetPlugin.cpp

#include "Platform.h"
#include "XPNetPlugin.h"
#include "xpnetclrhost.h"
#include <stdint.h>
#include <string>

#if defined(WIN32)
#  include <experimental/filesystem>
   namespace fs = std::experimental::filesystem;
#else
#  include <boost/filesystem.hpp>
   namespace fs = boost::filesystem;
#endif

// Data - X-Plane API Function Pointer Types
typedef XPLMDataRef(*PXPLMFindDataRef)(const char*);
typedef XPLMDataTypeID(*PXPLMGetDataRefTypes)(XPLMDataRef);
typedef int(*PXPLMGetDatai)(XPLMDataRef);
typedef void(*PXPLMSetDatai)(XPLMDataRef, int);
typedef int(*PXPLMGetDatavi)(XPLMDataRef, int*, int, int);
typedef void(*PXPLMSetDatavi)(XPLMDataRef, int*, int, int);
typedef float(*PXPLMGetDataf)(XPLMDataRef);
typedef void(*PXPLMSetDataf)(XPLMDataRef, float);
typedef int(*PXPLMGetDatavf)(XPLMDataRef, float*, int, int);
typedef void(*PXPLMSetDatavf)(XPLMDataRef, float*, int, int);
typedef double(*PXPLMGetDatad)(XPLMDataRef);
typedef void(*PXPLMSetDatad)(XPLMDataRef, double);
typedef int(*PXPLMGetDatab)(XPLMDataRef, void*, int, int);
typedef void(*PXPLMSetDatab)(XPLMDataRef, void*, int, int);
typedef XPLMDataRef(*PXPLMRegisterDataAccessor)(const char*, XPLMDataTypeID, int, XPLMGetDatai_f, XPLMSetDatai_f, XPLMGetDataf_f, XPLMSetDataf_f, XPLMGetDatad_f, XPLMSetDatad_f, XPLMGetDatavi_f, XPLMSetDatavi_f, XPLMGetDatavf_f, XPLMSetDatavf_f, XPLMGetDatab_f, XPLMSetDatab_f, void*, void*);

// Commands - X-Plane API Function Pointer Types
typedef XPLMCommandRef(*PXPLMFindCommand)(const char*);
typedef void(*PXPLMCommandBegin)(XPLMCommandRef);
typedef void(*PXPLMCommandEnd)(XPLMCommandRef);
typedef void(*PXPLMCommandOnce)(XPLMCommandRef);

// Processing - X-Plane API Function Pointer Types
typedef float(*PXPLMGetElapsedTime)();
typedef int(*PXPLMGetCycleNumber)();
typedef void(*PXPLMRegisterFlightLoopCallback)(XPLMFlightLoop_f, float, void*);
typedef void(*PXPLMUnregisterFlightLoopCallback)(XPLMFlightLoop_f, void*);
typedef void(*PXPLMSetFlightLoopCallbackInterval)(XPLMFlightLoop_f, float, int, void*);
typedef XPLMFlightLoopID(*PXPLMCreateFlightLoop)(XPLMCreateFlightLoop_t*);
typedef void(*PXPLMDestroyFlightLoop)(XPLMFlightLoopID);
typedef void(*PXPLMScheduleFlightLoop)(XPLMFlightLoopID, float, int);

// Display - X-Plane API Function Pointer Types
typedef int(*PXPLMRegisterDrawCallback)(XPLMDrawCallback_f, XPLMDrawingPhase, int, void*);
typedef int(*PXPLMUnregisterDrawCallback)(XPLMDrawCallback_f, XPLMDrawingPhase, int, void*);

// Scenery - X-Plane API Function Pointer Types
typedef XPLMProbeRef(*PXPLMCreateProbe)(XPLMProbeType);
typedef void(*PXPLMDestroyProbe)(XPLMProbeRef);
typedef XPLMProbeResult(*PXPLMProbeTerrainXYZ)(XPLMProbeRef, float, float, float, XPLMProbeInfo_t*);
typedef XPLMObjectRef(*PXPLMLoadObject)(const char*);
typedef void(*PXPLMLoadObjectAsync)(const char*, XPLMObjectLoaded_f, void*);
typedef void(*PXPLMDrawObjects)(XPLMObjectRef, int, XPLMDrawInfo_t*, int, int);
typedef void(*PXPLMUnloadObject)(XPLMObjectRef);
typedef int(*PXPLMLookupObjects)(const char*, float, float, XPLMLibraryEnumerator_f, void*);

// Graphics - X-Plane API Function Pointer Types
typedef void(*PXPLMWorldToLocal)(double, double, double, double*, double*, double*);
typedef void(*PXPLMLocalToWorld)(double, double, double, double*, double*, double*);

// Function types for calling into XPNet.PluginBridge in the CLR.
typedef int (STDMETHODCALLTYPE *PXPluginStart)(void*, void*);
typedef void (STDMETHODCALLTYPE *PXPluginStop)();
typedef int (STDMETHODCALLTYPE *PXPluginEnable)();
typedef void (STDMETHODCALLTYPE *PXPluginDisable)();
typedef int (STDMETHODCALLTYPE *PXPluginReceiveMessage)(int, int, void*);

static ClrToken s_clrToken;
static PXPluginStart ClrPluginStart;
static PXPluginStop ClrPluginStop;
static PXPluginEnable ClrPluginEnable;
static PXPluginDisable ClrPluginDisable;
static PXPluginReceiveMessage ClrPluginReceiveMessage;

static void* s_externalLoggingHandle = 0;
static bool s_isEnabled = false;
static bool s_isStarted = false;

typedef struct {
	// This type must be kept in sync with the version in C#.

	char name[256];
	char sig[256];
	char desc[256];

	int64_t hLog;

} StartParams;

typedef struct
{
	// This type must be kept in sync with the version in C#.

	// Data
	PXPLMFindDataRef XPLMFindDataRef;
	PXPLMGetDataRefTypes XPLMGetDataRefTypes;
	PXPLMGetDatai XPLMGetDatai;
	PXPLMSetDatai XPLMSetDatai;
	PXPLMGetDataf XPLMGetDataf;
	PXPLMSetDataf XPLMSetDataf;
	PXPLMGetDatad XPLMGetDatad;
	PXPLMSetDatad XPLMSetDatad;
	PXPLMGetDatavi XPLMGetDatavi;
	PXPLMSetDatavi XPLMSetDatavi;
	PXPLMGetDatavf XPLMGetDatavf;
	PXPLMSetDatavf XPLMSetDatavf;
	PXPLMGetDatab XPLMGetDatab;
	PXPLMSetDatab XPLMSetDatab;
	PXPLMRegisterDataAccessor XPLMRegisterDataAccessor;

	// Commands
	PXPLMFindCommand XPLMFindCommand;
	PXPLMCommandBegin XPLMCommandBegin;
	PXPLMCommandEnd XPLMCommandEnd;
	PXPLMCommandOnce XPLMCommandOnce;

	// Processing
	PXPLMGetElapsedTime XPLMGetElapsedTime;
	PXPLMGetCycleNumber XPLMGetCycleNumber;
	PXPLMRegisterFlightLoopCallback XPLMRegisterFlightLoopCallback;
	PXPLMUnregisterFlightLoopCallback XPLMUnregisterFlightLoopCallback;
	PXPLMSetFlightLoopCallbackInterval XPLMSetFlightLoopCallbackInterval;
	PXPLMCreateFlightLoop XPLMCreateFlightLoop;
	PXPLMDestroyFlightLoop XPLMDestroyFlightLoop;
	PXPLMScheduleFlightLoop XPLMScheduleFlightLoop;

	// Display
	PXPLMRegisterDrawCallback XPLMRegisterDrawCallback;
	PXPLMUnregisterDrawCallback XPLMUnregisterDrawCallback;

	// Scenery
	PXPLMCreateProbe XPLMCreateProbe;
	PXPLMDestroyProbe XPLMDestroyProbe;
	PXPLMProbeTerrainXYZ XPLMProbeTerrainXYZ;
	PXPLMLoadObject XPLMLoadObject;
	PXPLMLoadObjectAsync XPLMLoadObjectAsync;
	PXPLMDrawObjects XPLMDrawObjects;
	PXPLMUnloadObject XPLMUnloadObject;
	PXPLMLookupObjects XPLMLookupObjects;


	// Graphics
	PXPLMWorldToLocal XPLMWorldToLocal;
	PXPLMLocalToWorld XPLMLocalToWorld;

} ApiFunctions;


std::wstring GetPluginDirectory()
{
	char filePath[MAX_PATH];
	XPLMGetPluginInfo(XPLMGetMyID(), NULL, filePath, NULL, NULL);

	fs::path fp = filePath;
	return fp.parent_path().generic_wstring();
}

XPNETPLUGIN_API bool XPNetPluginIsEnabled()
{
	return s_isEnabled;
}

XPNETPLUGIN_API bool XPNetPluginIsStarted()
{
	return s_isStarted;
}

// For testing: provide an alternate log target than the normal log file.
XPNETPLUGIN_API void XPNetPluginSetExternalLoggingHandle(void* externalLoggingHandle)
{
	s_externalLoggingHandle = externalLoggingHandle;
}

XPNETPLUGIN_API int XPluginStart(char* outName, char* outSig, char* outDesc)
{
	if (!s_clrToken)
	{
		// The _very_ first thing to do is tell X-Plane to opt into Posix paths.
		// Otherwise, on macOS, it assumes the ancient Drive:Path:To:File convention.
		// We work entirely in Posix paths on all platforms.
		XPLMEnableFeature("XPLM_USE_NATIVE_PATHS", 1);

		fs::path pluginDir = GetPluginDirectory();

		XPLMDebugString(("XPNet: X-Plane reports plugin dir as " + pluginDir.generic_string() + "\n").c_str());

		fs::path dotnetProbePaths[]{
#           if defined(__APPLE__)
			  pluginDir / "dotnet-macos",
			  pluginDir.parent_path() / "dotnet-macos",
#           endif

#           if defined(_MSC_VER)
			  pluginDir / "dotnet-windows",
			  pluginDir.parent_path() / "dotnet-windows",
#           endif

			  // Fall back to the older name if no platform-specific folder found.
			  pluginDir / "dotnet",
			  pluginDir.parent_path() / "dotnet"
		};

		// Assuming that the pluginPath looks like <PluginDir>/32, we want to
		// be looking for our plugin resources one level higher, in <PluginDir>.
		fs::path effectivePluginDir = pluginDir.parent_path();

		fs::path sharedAppPath;
		for (auto& dotnetPath : dotnetProbePaths)
		{
			fs::path probeSharedAppPath = dotnetPath / "shared" / "Microsoft.NETCore.App";
			XPLMDebugString(("XPNet: Probing for a CLR at " + probeSharedAppPath.generic_string()).c_str());
			if (fs::exists(probeSharedAppPath))
			{
				sharedAppPath = probeSharedAppPath;

				XPLMDebugString("...FOUND\n");
				XPLMDebugString(("XPNet: Will load plugins from " + effectivePluginDir.generic_string() + "\n").c_str());

				break;
			}
			else
			{
				XPLMDebugString("...NO\n");
			}
		}

		if (sharedAppPath.empty())
		{
			XPLMDebugString("XPNet: Probing found no CLR paths.\n");
			return 0;
		}

		// In the Microsoft.NETCore.App folder, we expect to find exactly one directory,
		// whose name is the specific version number of Core.  If there is more than one
		// directory, we just use the first one we find there - we expect an installation
		// to put exactly one version there.
		fs::path dotnetPath = fs::directory_iterator(sharedAppPath)->path();

		s_clrToken = LoadClr(
			dotnetPath.generic_wstring() + L"/",
			effectivePluginDir.generic_wstring(),
			effectivePluginDir.generic_wstring(),
			L"XPNet"
		);
		if (!s_clrToken)
		{
			XPLMDebugString("XPNet: Failed to load CLR.\n");
			return 0;
		}
	}

	if (!ClrPluginStart)
	{
		ClrPluginStart = GetClrMethod<PXPluginStart>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Start");
		ClrPluginStop = GetClrMethod<PXPluginStop>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Stop");
		ClrPluginEnable = GetClrMethod<PXPluginEnable>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Enable");
		ClrPluginDisable = GetClrMethod<PXPluginDisable>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Disable");
		ClrPluginReceiveMessage = GetClrMethod<PXPluginReceiveMessage>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"ReceiveMessage");

		if (!ClrPluginStart || !ClrPluginStop || !ClrPluginEnable || !ClrPluginDisable || !ClrPluginReceiveMessage)
		{
			// ClrPluginStart is our sentinel for whether the callbacks were loaded, so make sure it's null'd out even if
			// it happens not to be the one that failed to be found above.
			ClrPluginStart = nullptr;

			XPLMDebugString("XPNet: Failed to load one or more required methods from XPNet.PluginBridge in XPNet.CLR.  Cannot continue.\n");
			return 0;
		}
	}

	StartParams sp = { "", "", "", reinterpret_cast<int64_t>(s_externalLoggingHandle) };
	ApiFunctions api =
	{
		// Data
		XPLMFindDataRef,
		XPLMGetDataRefTypes,
		XPLMGetDatai,
		XPLMSetDatai,
		XPLMGetDataf,
		XPLMSetDataf,
		XPLMGetDatad,
		XPLMSetDatad,
		XPLMGetDatavi,
		XPLMSetDatavi,
		XPLMGetDatavf,
		XPLMSetDatavf,
		XPLMGetDatab,
		XPLMSetDatab,
		XPLMRegisterDataAccessor,

		// Commands
		XPLMFindCommand,
		XPLMCommandBegin,
		XPLMCommandEnd,
		XPLMCommandOnce,

		// Processing
		XPLMGetElapsedTime,
		XPLMGetCycleNumber,
		XPLMRegisterFlightLoopCallback,
		XPLMUnregisterFlightLoopCallback,
		XPLMSetFlightLoopCallbackInterval,
		XPLMCreateFlightLoop,
		XPLMDestroyFlightLoop,
		XPLMScheduleFlightLoop,

		// Display
		XPLMRegisterDrawCallback,
		XPLMUnregisterDrawCallback,

		// Scenery
		XPLMCreateProbe,
		XPLMDestroyProbe,
		XPLMProbeTerrainXYZ,
		XPLMLoadObject,
		XPLMLoadObjectAsync,
		XPLMDrawObjects,
		XPLMUnloadObject,
		XPLMLookupObjects,

		// Graphics
		XPLMWorldToLocal,
		XPLMLocalToWorld
	};
	
	auto ret = ClrPluginStart(&sp, &api);
	if (ret)
	{
		strcp(outName, sp.name);
		strcp(outSig, sp.sig);
		strcp(outDesc, sp.desc);
	}
	else
	{
		// Couldn't start the plugin, so don't leave a loaded-but-unused CLR around.
		//
		// MAINT: See notes in XPluginStop about this.
		//
		// UnloadClr(s_clrToken);
		// s_clrToken = 0;
	}

	XPLMDebugString(("XPNet: ClrPluginStart Result = " + std::to_string(ret) + ".\n").c_str());

	s_isStarted = ret != 0;

	return ret;
}

XPNETPLUGIN_API void XPluginStop(void)
{
	if (!s_clrToken)
		return;

	ClrPluginStop();

	s_isStarted = false;

	// .NET Core does not support unloading and reloading a CLR - so basically they don't
	// _really_ support our use case.  Others have asked about it (e.g., for building plugins
	// for games, just like we're doing here) on the github issues page, so far to deaf ears.
	// But to a first approximation we can get the behavior we want just by never unloading
	// the CLR - it'll still be loaded and ready to go if XPluginStart is called again.
	//
	// UnloadClr(s_clrToken);
	// s_clrToken = 0;
}

XPNETPLUGIN_API int XPluginEnable(void)
{
	if (!s_clrToken)
		return 0;

	int ret = ClrPluginEnable();
	s_isEnabled = ret != 0;
	return ret;
}

XPNETPLUGIN_API void XPluginDisable(void)
{
	if (!s_clrToken)
		return;

	ClrPluginDisable();

	s_isEnabled = false;
}

XPNETPLUGIN_API void XPluginReceiveMessage(XPLMPluginID inFrom, int inMsg, void * inParam)
{
	if (!s_clrToken)
		return;

	ClrPluginReceiveMessage(inFrom, inMsg, inParam);
}
