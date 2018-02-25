
#include "Platform.h"

#if defined(WIN32)

#  include <Shlwapi.h>

#elif defined(__linux__)

#  define symlinkEntrypointExecutable "/proc/self/exe"

#elif !defined(__APPLE__)

#  define symlinkEntrypointExecutable "/proc/curproc/exe"

#endif


bool GetEntrypointExecutableAbsolutePath(std::string& entrypointExecutable)
{
	bool result = false;

	entrypointExecutable.clear();

	// Get path to the executable for the current process using
	// platform specific means.
#if defined(WIN32)

	WCHAR path[MAX_PATH];
	GetModuleFileNameW(NULL, path, sizeof(path));
	entrypointExecutable = narrow(path);
	result = true;

#elif defined(__APPLE__)

	// On Mac, we ask the OS for the absolute path to the entrypoint executable
	uint32_t lenActualPath = 0;
	if (_NSGetExecutablePath(nullptr, &lenActualPath) == -1)
	{
		// OSX has placed the actual path length in lenActualPath,
		// so re-attempt the operation
		std::string resizedPath(lenActualPath, '\0');
		char *pResizedPath = const_cast<char *>(resizedPath.c_str());
		if (_NSGetExecutablePath(pResizedPath, &lenActualPath) == 0)
		{
			entrypointExecutable.assign(pResizedPath);
			result = true;
		}
	}
#elif defined (__FreeBSD__)
	static const int name[] = {
		CTL_KERN, KERN_PROC, KERN_PROC_PATHNAME, -1
	};
	char path[PATH_MAX];
	size_t len;

	len = sizeof(path);
	if (sysctl(name, 4, path, &len, nullptr, 0) == 0)
	{
		entrypointExecutable.assign(path);
		result = true;
	}
	else
	{
		// ENOMEM
		result = false;
	}
#elif defined(__NetBSD__) && defined(KERN_PROC_PATHNAME)
	static const int name[] = {
		CTL_KERN, KERN_PROC_ARGS, -1, KERN_PROC_PATHNAME,
	};
	char path[MAXPATHLEN];
	size_t len;

	len = sizeof(path);
	if (sysctl(name, __arraycount(name), path, &len, NULL, 0) != -1)
	{
		entrypointExecutable.assign(path);
		result = true;
	}
	else
	{
		result = false;
	}
#else
	// On other OSs, return the symlink that will be resolved by GetAbsolutePath
	// to fetch the entrypoint EXE absolute path, inclusive of filename.
	result = GetAbsolutePath(symlinkEntrypointExecutable, entrypointExecutable);
#endif 

	return result;
}

#if !defined(WIN32)
bool GetAbsolutePath(const char* path, std::string& absolutePath)
{
	bool result = false;

	char realPath[PATH_MAX];
	if (realpath(path, realPath) != nullptr && realPath[0] != '\0')
	{
		absolutePath.assign(realPath);
		// realpath should return canonicalized path without the trailing slash
		assert(absolutePath.back() != '/');

		result = true;
	}

	return result;
}
#endif

std::wstring GetEntrypointExecutablePath()
{
	std::string entrypointExePath;
	if (GetEntrypointExecutableAbsolutePath(entrypointExePath))
		return widen(entrypointExePath);
	else
		return L"";
}


