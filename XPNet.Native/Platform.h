#pragma once

#include <string>
#include <codecvt>

inline std::wstring widen(const std::string& str)
{
	using convert_typeX = std::codecvt_utf8<wchar_t>;
	std::wstring_convert<convert_typeX, wchar_t> converterX;

	return converterX.from_bytes(str);
}

inline std::string narrow(const std::wstring& wstr)
{
	using convert_typeX = std::codecvt_utf8<wchar_t>;
	std::wstring_convert<convert_typeX, wchar_t> converterX;

	return converterX.to_bytes(wstr);
}

std::wstring GetEntrypointExecutablePath();

std::wstring GetPluginDirectory();

#if defined(_MSC_VER)

#  include <SDKDDKVer.h>

#  define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers
#  include <windows.h>

	inline HMODULE SysLoadLibrary(const std::string& dllPath)
	{
		return ::LoadLibraryExA(dllPath.c_str(), NULL, 0);
	}

	inline void* SysGetProcAddress(HMODULE hModule, const char* name)
	{
		return ::GetProcAddress(hModule, name);
	}

#elif defined(__GNUC__) // GNU or a gnu-alike (like LLVM)

	typedef void* HMODULE;

	inline void* SysLoadLibrary(const std::string& dllPath)
	{
		return dlopen(dllPath.c_str(), RTLD_NOW | RTLD_LOCAL);
	}

	inline void* SysGetProcAddress(HMODULE hModule, const char* name)
	{
		return dlsym(hModule, name);
	}

#else

#  error Compilation on this platform is not yet supported.

#endif
