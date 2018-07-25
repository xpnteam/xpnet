
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

} ApiFunctions;


std::wstring GetPluginDirectory()
{
	char filePath[MAX_PATH];
	XPLMGetPluginInfo(XPLMGetMyID(), NULL, filePath, NULL, NULL);

	fs::path fp = filePath;
	return fp.parent_path().generic_wstring();
}

// This function is used for testing, to get logging to a different location
// than the normal log file.
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

		fs::path dotnetProbePaths[] {
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

		fs::path sharedAppPath, effectivePluginDir;
		for (auto& dotnetPath : dotnetProbePaths)
		{
			fs::path probeSharedAppPath = dotnetPath / "shared" / "Microsoft.NETCore.App";
			XPLMDebugString(("XPNet: Probing for a CLR at " + probeSharedAppPath.generic_string()).c_str());
			if (fs::exists(probeSharedAppPath))
			{
				sharedAppPath = probeSharedAppPath;
				effectivePluginDir = dotnetPath.parent_path();

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

		ClrPluginStart = GetClrMethod<PXPluginStart>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Start");
		ClrPluginStop = GetClrMethod<PXPluginStop>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Stop");
		ClrPluginEnable = GetClrMethod<PXPluginEnable>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Enable");
		ClrPluginDisable = GetClrMethod<PXPluginDisable>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"Disable");
		ClrPluginReceiveMessage = GetClrMethod<PXPluginReceiveMessage>(s_clrToken, L"XPNet.CLR", L"XPNet.PluginBridge", L"ReceiveMessage");
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
		XPLMScheduleFlightLoop
	};
	
	auto ret = ClrPluginStart(&sp, &api);
	if (ret)
	{
		strcp(outName, sp.name);
		strcp(outSig, sp.sig);
		strcp(outDesc, sp.desc);
	}

	XPLMDebugString(("XPNet: ClrPluginStart Result = " + std::to_string(ret) + ".\n").c_str());

	return ret;
}

XPNETPLUGIN_API void XPluginStop(void)
{
	if (!s_clrToken)
		return;

	ClrPluginStop();

	// MAINT: .NET Core doesn't implement unloading yet, so don't even try.  It would
	// return Success here but then fail when we try to load a new domain later.  Instead,
	// we just make sure to clean up as best we can in our own C# code so that we're in
	// as clean an environment as possible when we start it back up again later.
	//UnloadClr(s_clrToken);
	//s_clrToken = 0;
}

XPNETPLUGIN_API int XPluginEnable(void)
{
	if (!s_clrToken)
		return 0;

	return ClrPluginEnable();
}

XPNETPLUGIN_API void XPluginDisable(void)
{
	if (!s_clrToken)
		return;

	ClrPluginDisable();
}

XPNETPLUGIN_API void XPluginReceiveMessage(XPLMPluginID inFrom, int inMsg, void * inParam)
{
	if (!s_clrToken)
		return;

	ClrPluginReceiveMessage(inFrom, inMsg, inParam);
}
