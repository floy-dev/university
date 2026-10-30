#include "framework.h"
#include "ProcessActions.h"

DWORD WaitForProcessById(DWORD processId, DWORD timeoutMilliseconds, LPDWORD exitCode)
{
    const HANDLE processHandle = OpenProcess(
        SYNCHRONIZE | PROCESS_QUERY_INFORMATION,
        FALSE,
        processId
    );
    if (processHandle == nullptr)
    {
        return WAIT_FAILED;
    }

    const DWORD waitResult = WaitForSingleObject(
        processHandle,
        timeoutMilliseconds
    );

    if (waitResult == WAIT_OBJECT_0 && exitCode != nullptr)
    {
        GetExitCodeProcess(
            processHandle,
            exitCode
        );
    }

    CloseHandle(processHandle);
    return waitResult;
}

BOOL TerminateProcessById(DWORD processId, UINT exitCode)
{
    const HANDLE processHandle = OpenProcess(
        PROCESS_TERMINATE,
        FALSE,
        processId
    );
    if (processHandle == nullptr)
    {
        return FALSE;
    }

    const BOOL isTerminated = TerminateProcess(
        processHandle,
        exitCode
    );
    CloseHandle(processHandle);
    return isTerminated;
}
