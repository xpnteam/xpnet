//
// coreclrhost.cpp
//
// A .NET Core host for XPNet plugins.
//
// https://docs.microsoft.com/en-us/dotnet/articles/core/tutorials/netcore-hosting
//
// This code is somewhat generic, but it doesn't strive to be a full-featured generic CLR
// host.  It makes assumptions and uses some types that are the right thing to do for XPNet.
//

// Include the windows sdk version.
#include <SDKDDKVer.h>

// Windows Headers
// Exclude rarely-used stuff from Windows headers
#define WIN32_LEAN_AND_MEAN
#include <windows.h>

#include "XPLMUtilities.h"

// Include common header files
#include <stdio.h>
#include <tchar.h>

// Include common stuff required from standard template library
#include <vector>
#include <string>

using namespace std;

#include <windows.h>
#include "coreclrhost.h"
#include "mscoree.h"

vector<wstring> ListFilesInDirectoryByPattern(LPCWSTR directoryName);

struct ClrTokenImp {
	DWORD domainId;
	ICLRRuntimeHost2* pCLRRuntimeHost;
};

ClrToken LoadClr(wstring coreClrFolderPath, wstring appBase, wstring appPaths, wstring appDomainName)
{
	HRESULT hr = S_OK;
	ICLRRuntimeHost2* pCLRRuntimeHost = nullptr;

	wstring coreClrFilePath = coreClrFolderPath + L"coreclr.dll";
	if (appPaths.length() > 0)
		appPaths += L";";
	appPaths += appBase + L";" + coreClrFolderPath;

	// For simplicity we add here all assemblies of the core clr to the list of fully trusted assemblies
	wstring searchPattern = coreClrFolderPath;
	searchPattern.append(L"*.dll");
	vector<wstring> files = ListFilesInDirectoryByPattern(searchPattern.c_str());

	// Append the path to the assemblies to the full path to all full trusted assemblies
	wstring fullTrustedAssemblies;

	for (unsigned int i = 0; i < files.size(); i++)
	{
		fullTrustedAssemblies.append(coreClrFolderPath);
		fullTrustedAssemblies.append(files[i]);
		fullTrustedAssemblies.append(L";");
	}

	// Load the CoreCRL dll into the process
	HMODULE hCoreCLRModule = ::LoadLibraryExW(coreClrFilePath.c_str(), NULL, 0);

	if (!hCoreCLRModule)
	{
		string msg = "Could not load CoreCLR from path (" + narrow(coreClrFilePath) + ").\n";
		XPLMDebugString(msg.c_str());
		return nullptr;
	}

	// Get the "factory" function for the runtime host
	FnGetCLRRuntimeHost pfnGetCLRRuntimeHost = (FnGetCLRRuntimeHost)::GetProcAddress(hCoreCLRModule, "GetCLRRuntimeHost");

	if (!pfnGetCLRRuntimeHost)
	{
		XPLMDebugString("Failed to find export GetCLRRuntimeHost.\n");
		return nullptr;
	}

	// Create a new instance of the runtime host
	hr = pfnGetCLRRuntimeHost(IID_ICLRRuntimeHost2, (IUnknown**)&pCLRRuntimeHost);

	if (FAILED(hr))
	{
		XPLMDebugString("Failed to get IID_ICLRRuntimeHost2 interface.\n");
		return nullptr;
	}

	// Set up the startup flags for the clr runtime
	STARTUP_FLAGS dwStartupFlags = (STARTUP_FLAGS)(
		STARTUP_FLAGS::STARTUP_LOADER_OPTIMIZATION_SINGLE_DOMAIN |
		STARTUP_FLAGS::STARTUP_SINGLE_APPDOMAIN |
		STARTUP_FLAGS::STARTUP_SERVER_GC
		);

	hr = pCLRRuntimeHost->SetStartupFlags(dwStartupFlags);

	if (FAILED(hr))
	{
		string msg = "Failed to set startup flags to the clr runtime: (" + to_string(hr) + ").\n";
		XPLMDebugString(msg.c_str());
		return nullptr;
	}

	// Authenticate with either CORECLR_HOST_AUTHENTICATION_KEY or CORECLR_HOST_AUTHENTICATION_KEY_NONGEN 
	hr = pCLRRuntimeHost->Authenticate(CORECLR_HOST_AUTHENTICATION_KEY);

	if (FAILED(hr))
	{
		XPLMDebugString("Failed to pCLRRuntimeHost->Authenticate.\n");
		return nullptr;
	}

	hr = pCLRRuntimeHost->Start();

	if (FAILED(hr))
	{
		XPLMDebugString("Failed to pCLRRuntimeHost->Start.\n");
		return nullptr;
	}

	const wchar_t* property_keys[] =
	{
		L"APPBASE",
		L"TRUSTED_PLATFORM_ASSEMBLIES",
		L"APP_PATHS",
	};

	const wchar_t* property_values[] = {
		// APPBASE
		appBase.c_str(),
		// TRUSTED_PLATFORM_ASSEMBLIES
		fullTrustedAssemblies.c_str(),
		// APP_PATHS
		appPaths.c_str()
	};

	DWORD domainId;
	DWORD appDomainFlags = APPDOMAIN_ENABLE_PLATFORM_SPECIFIC_APPS | APPDOMAIN_ENABLE_PINVOKE_AND_CLASSIC_COMINTEROP;

	hr = pCLRRuntimeHost->CreateAppDomainWithManager(
		appDomainName.c_str(),
		appDomainFlags,
		NULL,
		NULL,
		sizeof(property_keys) / sizeof(wchar_t*),
		property_keys,
		property_values,
		&domainId);

	if (FAILED(hr))
	{
		//wprintf_s(L"Full trusted assemblies: %S\n", pCoreClrStartupParams->FullTrustedAssembliePaths.c_str());
		//wprintf_s(L"AppPaths: %S\n", pCoreClrStartupParams->AppPaths.c_str());
		string msg = "Failed to create app domain (" + to_string(hr) + ").\n";
		XPLMDebugString(msg.c_str());
		return nullptr;
	}

	return new ClrTokenImp{ domainId, pCLRRuntimeHost };
}

void UnloadClr(ClrToken clrToken)
{
	ClrTokenImp* clr = static_cast<ClrTokenImp*>(clrToken);

	// Unload the app domain
	clr->pCLRRuntimeHost->UnloadAppDomain(clr->domainId, true);

	// Stop the runtime host
	clr->pCLRRuntimeHost->Stop();

	delete clr;
}

INT_PTR GetClrMethod(ClrToken clrToken, std::wstring assemblyName, std::wstring typeName, std::wstring methodName)
{
	ClrTokenImp* clr = static_cast<ClrTokenImp*>(clrToken);

	INT_PTR pMethod;
	HRESULT hr = clr->pCLRRuntimeHost->CreateDelegate(
		clr->domainId, assemblyName.c_str(), typeName.c_str(), methodName.c_str(), &pMethod
	);
	if (FAILED(hr))
	{
		string msg = "Failed to create a delegate to managed method (" + narrow(methodName) + "): (" + to_string(hr) + ").\n";
		XPLMDebugString(msg.c_str());
		return 0;
	}

	return pMethod;
}

// Function to list all files in a specific directory with a specified pattern
vector<wstring> ListFilesInDirectoryByPattern(LPCWSTR directoryName)
{
	WIN32_FIND_DATA FindFileData;
	HANDLE hFind = ::FindFirstFile(directoryName, &FindFileData);

	vector<wstring> result;

	result.push_back(wstring(FindFileData.cFileName));

	while (FindNextFile(hFind, &FindFileData))
		result.push_back(wstring(FindFileData.cFileName));

	return result;
}
