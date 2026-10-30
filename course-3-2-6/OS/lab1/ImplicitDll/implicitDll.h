#pragma once

#if !defined(__IMPLICIT_DLL_H__)
#define __IMPLICIT_DLL_H__

#ifdef IMPLICITDLL_EXPORTS
#define IMPLICITDLL_API __declspec(dllexport)
#else
#define IMPLICITDLL_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

IMPLICITDLL_API void PrintSysDirectories(const long csidl[], unsigned long count);
IMPLICITDLL_API void PrintOperatingSystemVersion();
IMPLICITDLL_API void PrintLocalDateTime();

#ifdef __cplusplus
}
#endif

#endif
