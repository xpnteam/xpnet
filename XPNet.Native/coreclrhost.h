#pragma once

#include <string>
#include <codecvt>

typedef void* ClrToken;

ClrToken LoadClr(std::wstring coreClrFolderPath, std::wstring appBase, std::wstring appPaths, std::wstring appDomainName);
void UnloadClr(ClrToken clrToken);

INT_PTR GetClrMethod(ClrToken clrToken, std::wstring assemblyName, std::wstring typeName, std::wstring methodName);

template <typename TFunction>
TFunction GetClrMethod(ClrToken clrToken, std::wstring assemblyName, std::wstring typeName, std::wstring methodName)
{
	return reinterpret_cast<TFunction>(GetClrMethod(clrToken, assemblyName, typeName, methodName));
}



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
