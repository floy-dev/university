#pragma once

#include <windows.h>

bool SetCurrentProcessAndThreadPriority(DWORD processPriorityClass, int threadPriority);
