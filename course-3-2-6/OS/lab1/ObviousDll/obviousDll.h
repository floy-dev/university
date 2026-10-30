#pragma once

#if !defined(__OBVIOUS_DLL_H__)
#define __OBVIOUS_DLL_H__

#ifdef OBVIOUSDLL_EXPORTS
#define OBVIOUSDLL_API __declspec(dllexport)
#else
#define OBVIOUSDLL_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

OBVIOUSDLL_API void PrintSystemMetrics();

#ifdef __cplusplus
}
#endif

#endif
