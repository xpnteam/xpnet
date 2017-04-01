
// Opt into the XP API version we want.
#define XPLM200
#define XPLM210

extern "C" {
#  include "XPLMPlugin.h"
#  include "XPLMDefs.h"
#  include "XPLMDataAccess.h"
#  include "XPLMProcessing.h"
#  include "XPLMUtilities.h"
}

// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the XPNETPLUGIN_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// XPNETPLUGIN_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#if defined XPNETPLUGIN_EXPORTS
#  if defined __cplusplus
#    define XPNETPLUGIN_API extern "C" __declspec(dllexport)
#  else
#    define XPNETPLUGIN_API __declspec(dllexport)
#  endif
#else
#  if defined __cplusplus
#    define XPNETPLUGIN_API extern "C" __declspec(dllimport)
#  else
#    define XPNETPLUGIN_API __declspec(dllimport)
#  endif
#endif

extern "C" {

	XPNETPLUGIN_API int XPluginStart(char* outName, char* outSig, char* outDesc);
	XPNETPLUGIN_API void XPluginStop(void);
	XPNETPLUGIN_API int XPluginEnable(void);
	XPNETPLUGIN_API void XPluginDisable(void);
	XPNETPLUGIN_API void XPluginReceiveMessage(XPLMPluginID inFrom, int inMsg, void * inParam);

	XPNETPLUGIN_API void XPNetPluginSetExternalLoggingHandle(void* externalLoggingHandle);
}