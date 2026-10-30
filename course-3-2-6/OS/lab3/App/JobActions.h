#pragma once

#include <windows.h>

#include <vector>

bool CreateNotepadJob(HANDLE& jobHandle);
bool IsCurrentProcessInAnyJob(BOOL& isInJob);
bool GetProcessIdsFromJob(HANDLE jobHandle, std::vector<DWORD>& processIds);
