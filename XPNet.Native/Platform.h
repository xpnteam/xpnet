#pragma once

#include <string>
#include <locale>
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

#  define PATH_MAX MAX_PATH

#  define PATH_ENTRY_SEP ";"

#  define strcp(dest, str) strcpy_s(dest, strlen(str) + 1, str)

#  define unlink _unlink
#  define fileno _fileno

#elif defined(__GNUC__) // GNU or a gnu-alike (like Clang)

#  include <dlfcn.h>
#  include <assert.h>

#  if defined(__APPLE__)
#    include <mach-o/dyld.h>
#  endif

#  define STDMETHODCALLTYPE

#  define FAILED(hr) (((int)(hr)) < 0)

	typedef void* HMODULE;

	inline void* SysLoadLibrary(const std::string& dllPath)
	{
		return dlopen(dllPath.c_str(), RTLD_NOW | RTLD_LOCAL);
	}

	inline void* SysGetProcAddress(HMODULE hModule, const char* name)
	{
		return dlsym(hModule, name);
	}

	typedef unsigned char BYTE;

#  define MAX_PATH PATH_MAX

#  define PATH_ENTRY_SEP ":"

#  define strcp(dest, str) strcpy(dest, str)

#  define max(a,b) (((a) > (b)) ? (a) : (b))
#  define min(a,b) (((a) < (b)) ? (a) : (b))

#else

#  error Compilation on this platform is not yet supported.

#endif

// TODO: It won't be long before we can rely on std::filesystem to be available
// everywhere, now that it's in the standard.  But in Feb 2018, we're not there
// yet.  In MSVC, we can get it via <experimental/filesystem>.  On macOS and Linux,
// we require Boost's implementation.  I don't want boost to be required for
// xpnet, but we'll make do in the short term here.
#if defined(WIN32)
#  include <experimental/filesystem>
   namespace fs = std::experimental::filesystem;
#else
#  include <boost/filesystem.hpp>
   namespace fs = boost::filesystem;
#endif
