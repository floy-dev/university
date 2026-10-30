#pragma once

#include <windows.h>

DWORD WaitForProcessById(DWORD processId, DWORD timeoutMilliseconds, LPDWORD exitCode);
BOOL TerminateProcessById(DWORD processId, UINT exitCode);
