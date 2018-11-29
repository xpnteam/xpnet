//
// xpnetclrhost.cpp
//
// A .NET Core host for XPNet plugins.
//
// https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/netcore-hosting
//
// This code is somewhat generic, but it doesn't strive to be a full-featured generic CLR
// host.  It makes assumptions and uses some types that are the right thing to do for XPNet.
//

#include "xpnetclrhost.h"
#include "Platform.h"
#include "XPLMUtilities.h"

// Include common header files
#include <stdio.h>
// #include <tchar.h>

#include <vector>
#include <string>

#include "coreclrhost.h"

using namespace std;

vector<string> ListAssembliesInDirectory(const char* dirPath);

struct ClrTokenImp {
	unsigned int domainId;
	void* pCLRRuntimeHost;

	coreclr_initialize_ptr      coreclr_initialize;
	coreclr_create_delegate_ptr coreclr_create_delegate;
	coreclr_shutdown_2_ptr      coreclr_shutdown_2;
};

ClrToken LoadClr(wstring wCoreClrFolderPath, wstring wAppBase, wstring wAppPaths, wstring wAppDomainName)
{
	// The bulk of the plugin is written assuming Unicode strings, stored as 16-bit-char wstring.
	// The hosting API is all 8-bit-char strings.  To make things simple, we work entirely in
	// 8-bit in this method, so start off narrowing our input.
	//
	string coreClrFolderPath = narrow(wCoreClrFolderPath);
	string appPaths = narrow(wAppPaths);
	string appDomainName = narrow(wAppDomainName);
	string appBase = narrow(wAppBase);

#if APL
	string coreClrFilePath = coreClrFolderPath + "libcoreclr.dylib";
#else
	string coreClrFilePath = coreClrFolderPath + "coreclr.dll";
#endif

	XPLMDebugString(("XPNet: Will load CLR from: " + coreClrFilePath + "\n").c_str());

	if (appPaths.length() > 0)
		appPaths += PATH_ENTRY_SEP;
	appPaths += appBase + PATH_ENTRY_SEP + coreClrFolderPath;

	// For simplicity we add here all assemblies of the core clr to the list of fully trusted assemblies
	vector<string> files = ListAssembliesInDirectory(coreClrFolderPath.c_str());

	// Append the path to the assemblies to the full path to all full trusted assemblies
	string fullTrustedAssemblies;

	for (unsigned int i = 0; i < files.size(); i++)
	{
		fullTrustedAssemblies.append(coreClrFolderPath);
		fullTrustedAssemblies.append(files[i]);
		fullTrustedAssemblies.append(PATH_ENTRY_SEP);
	}

	// Load the CoreCLR dll into the process
	HMODULE hCoreCLRModule = SysLoadLibrary(coreClrFilePath);
	if (!hCoreCLRModule)
	{
		string msg = "XPNet: Could not load CoreCLR from path (" + coreClrFilePath + ").\n";
		XPLMDebugString(msg.c_str());
		return nullptr;
	}

	coreclr_initialize_ptr      coreclr_initialize = (coreclr_initialize_ptr)SysGetProcAddress(hCoreCLRModule, "coreclr_initialize");
	coreclr_create_delegate_ptr coreclr_create_delegate = (coreclr_create_delegate_ptr)SysGetProcAddress(hCoreCLRModule, "coreclr_create_delegate");
	coreclr_shutdown_2_ptr      coreclr_shutdown_2 = (coreclr_shutdown_2_ptr)SysGetProcAddress(hCoreCLRModule, "coreclr_shutdown_2");

	if (!coreclr_initialize)
	{
		XPLMDebugString("XPNet: Failed to find coreclr export: coreclr_initialize.\n");
		return nullptr;
	}

	if (!coreclr_create_delegate)
	{
		XPLMDebugString("XPNet: Failed to find coreclr export: coreclr_create_delegate.\n");
		return nullptr;
	}

	if (!coreclr_shutdown_2)
	{
		XPLMDebugString("XPNet: Failed to find coreclr export: coreclr_shutdown_2.\n");
		return nullptr;
	}

	const char* property_keys[] =
	{
		"APPBASE",
		"TRUSTED_PLATFORM_ASSEMBLIES",
		"APP_PATHS",
	};

	const char* property_values[] = {
		// APPBASE
		appBase.c_str(),
		// TRUSTED_PLATFORM_ASSEMBLIES
		fullTrustedAssemblies.c_str(),
		// APP_PATHS
		appPaths.c_str()
	};

	string entrypointExePath = narrow(GetEntrypointExecutablePath());

	unsigned int domainId;
	void* pCLRRuntimeHost;
	int st = coreclr_initialize(
		entrypointExePath.c_str(),
		appDomainName.c_str(),
		sizeof(property_keys) / sizeof(property_keys[0]),
		property_keys,
		property_values,
		&pCLRRuntimeHost,
		&domainId
	);

	if (FAILED(st))
	{
		//wprintf_s(L"Full trusted assemblies: %S\n", pCoreClrStartupParams->FullTrustedAssembliePaths.c_str());
		//wprintf_s(L"AppPaths: %S\n", pCoreClrStartupParams->AppPaths.c_str());
		string msg = "XPNet: coreclr_initialize failed - status:  (" + to_string(st) + ").\n";
		XPLMDebugString(msg.c_str());
		return nullptr;
	}

	return new ClrTokenImp{ domainId, pCLRRuntimeHost, coreclr_initialize, coreclr_create_delegate, coreclr_shutdown_2 };
}

void UnloadClr(ClrToken clrToken)
{
	ClrTokenImp* clr = static_cast<ClrTokenImp*>(clrToken);

	int latchedExitCode;
	int st = clr->coreclr_shutdown_2(clr->pCLRRuntimeHost, clr->domainId, &latchedExitCode);
	if (FAILED(st))
	{
		string msg = "XPNet: coreclr_shutdown_2 failed - status:  (" + to_string(st) + ").\n";
		XPLMDebugString(msg.c_str());
	}

	delete clr;
}

void* GetClrMethod(ClrToken clrToken, std::wstring assemblyName, std::wstring typeName, std::wstring methodName)
{
	ClrTokenImp* clr = static_cast<ClrTokenImp*>(clrToken);

	void *pMethod;
	int st = clr->coreclr_create_delegate(
		clr->pCLRRuntimeHost, clr->domainId, narrow(assemblyName).c_str(), narrow(typeName).c_str(), narrow(methodName).c_str(), &pMethod
	);

	if (FAILED(st))
	{
		string msg = "XPNet: coreclr_create_delegate - failed to create a delegate to managed method (" + narrow(methodName) + "): (" + to_string(st) + ").\n";
		XPLMDebugString(msg.c_str());
		return 0;
	}

	return pMethod;
}

// Function to list all files in a specific directory with a specified pattern
vector<string> ListAssembliesInDirectory(const char* dirPath)
{
	vector<string> result;

	for (auto& dirEntry : fs::recursive_directory_iterator(dirPath))
	{
		const auto& filename = dirEntry.path().filename();
		if (filename.extension() == ".dll")
			result.push_back(filename.string());
	}

	return result;
}
