#pragma once

#if !defined(__DEFERRED_DLL_H__)
#define __DEFERRED_DLL_H__

#ifdef DEFERREDDLL_EXPORTS
#define DEFERREDDLL_API __declspec(dllexport)
#else
#define DEFERREDDLL_API __declspec(dllimport)
#endif

#ifdef __cplusplus
extern "C" {
#endif

// Выводит значения системных параметров для варианта 8.
DEFERREDDLL_API void PrintSystemParameters();

#ifdef __cplusplus
}
#endif

#endif // __DEFERRED_DLL_H__
