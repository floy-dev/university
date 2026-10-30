#include "framework.h"
#include "PriorityActions.h"

bool SetCurrentProcessAndThreadPriority(DWORD processPriorityClass, int threadPriority)
{
    const BOOL isProcessPrioritySet = SetPriorityClass(
        GetCurrentProcess(),
        processPriorityClass
    );
    if (!isProcessPrioritySet)
    {
        return false;
    }

    return SetThreadPriority(
        GetCurrentThread(),
        threadPriority
    ) != FALSE;
}
