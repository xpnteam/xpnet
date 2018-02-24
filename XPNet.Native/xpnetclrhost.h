#pragma once

#include <string>
#include "Platform.h"

typedef void* ClrToken;

ClrToken LoadClr(std::wstring coreClrFolderPath, std::wstring appBase, std::wstring appPaths, std::wstring appDomainName);
void UnloadClr(ClrToken clrToken);

void* GetClrMethod(ClrToken clrToken, std::wstring assemblyName, std::wstring typeName, std::wstring methodName);

template <typename TFunction>
TFunction GetClrMethod(ClrToken clrToken, std::wstring assemblyName, std::wstring typeName, std::wstring methodName)
{
	return reinterpret_cast<TFunction>(GetClrMethod(clrToken, assemblyName, typeName, methodName));
}

