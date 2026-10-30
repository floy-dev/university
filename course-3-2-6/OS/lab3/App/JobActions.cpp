#include "framework.h"
#include "JobActions.h"

namespace
{
    constexpr DWORD kNotepadProcessCount = 3;

    void CloseProcessHandles(PROCESS_INFORMATION& processInformation)
    {
        if (processInformation.hThread != nullptr)
        {
            CloseHandle(processInformation.hThread);
        }

        if (processInformation.hProcess != nullptr)
        {
            CloseHandle(processInformation.hProcess);
        }
    }

    bool StartNotepadInJob(HANDLE jobHandle)
    {
        WCHAR commandLine[] = L"notepad.exe";
        STARTUPINFOW startupInformation{};
        startupInformation.cb = sizeof(startupInformation);
        PROCESS_INFORMATION processInformation{};

        const BOOL isProcessCreated = CreateProcessW(
            nullptr,
            commandLine,
            nullptr,
            nullptr,
            FALSE,
            CREATE_SUSPENDED | CREATE_BREAKAWAY_FROM_JOB,
            nullptr,
            nullptr,
            &startupInformation,
            &processInformation
        );
        if (!isProcessCreated)
        {
            return false;
        }

        const BOOL isAssignedToJob = AssignProcessToJobObject(
            jobHandle,
            processInformation.hProcess
        );
        if (!isAssignedToJob)
        {
            TerminateProcess(
                processInformation.hProcess,
                1
            );
            CloseProcessHandles(processInformation);
            return false;
        }

        const DWORD resumeResult = ResumeThread(processInformation.hThread);
        const bool isThreadResumed = resumeResult != static_cast<DWORD>(-1);

        CloseProcessHandles(processInformation);
        return isThreadResumed;
    }
}

bool CreateNotepadJob(HANDLE& jobHandle)
{
    jobHandle = CreateJobObjectW(
        nullptr,
        nullptr
    );
    if (jobHandle == nullptr)
    {
        return false;
    }

    for (DWORD processIndex = 0; processIndex < kNotepadProcessCount; ++processIndex)
    {
        if (StartNotepadInJob(jobHandle))
        {
            continue;
        }

        TerminateJobObject(
            jobHandle,
            1
        );
        CloseHandle(jobHandle);
        jobHandle = nullptr;
        return false;
    }

    return true;
}

bool IsCurrentProcessInAnyJob(BOOL& isInJob)
{
    isInJob = FALSE;
    return IsProcessInJob(
        GetCurrentProcess(),
        nullptr,
        &isInJob
    ) != FALSE;
}

bool GetProcessIdsFromJob(HANDLE jobHandle, std::vector<DWORD>& processIds)
{
    processIds.clear();
    DWORD bufferProcessCount = 16;

    while (bufferProcessCount <= 4096)
    {
        const DWORD bufferSize = sizeof(JOBOBJECT_BASIC_PROCESS_ID_LIST) +
            (bufferProcessCount - 1) * sizeof(ULONG_PTR);
        std::vector<BYTE> buffer(bufferSize);
        auto* processIdList =
            reinterpret_cast<JOBOBJECT_BASIC_PROCESS_ID_LIST*>(buffer.data());
        processIdList->NumberOfAssignedProcesses = bufferProcessCount;

        const BOOL isListReceived = QueryInformationJobObject(
            jobHandle,
            JobObjectBasicProcessIdList,
            processIdList,
            bufferSize,
            nullptr
        );
        if (isListReceived)
        {
            for (DWORD processIndex = 0;
                processIndex < processIdList->NumberOfProcessIdsInList;
                ++processIndex)
            {
                processIds.push_back(
                    static_cast<DWORD>(processIdList->ProcessIdList[processIndex])
                );
            }
            return true;
        }

        if (GetLastError() != ERROR_MORE_DATA)
        {
            return false;
        }

        bufferProcessCount *= 2;
    }

    return false;
}
