#define WIN32_LEAN_AND_MEAN
#include <windows.h>

#include <cwchar>
#include <iostream>
#include <stdexcept>
#include <string>
#include <vector>

using namespace std;

namespace
{
    constexpr int childProcessesCount = 3;
    constexpr int countingCyclesCount = 3;

    bool IsChildProcess(int argumentsCount, wchar_t* arguments[])
    {
        return argumentsCount == 6 && wcscmp(arguments[1], L"--child") == 0;
    }

    int RunChildProcess(int argumentsCount, wchar_t* arguments[])
    {
        const int instanceNumber = stoi(arguments[2]);
        const DWORD parentProcessIdentifier = stoul(arguments[3]);
        HANDLE parentProcessHandle = OpenProcess(
            PROCESS_DUP_HANDLE,
            FALSE,
            parentProcessIdentifier
        );

        if (parentProcessHandle == nullptr)
        {
            throw runtime_error("Не удалось открыть родительский процесс");
        }

        HANDLE ownTurnEvent = nullptr;
        HANDLE nextTurnEvent = nullptr;
        const BOOL isOwnEventDuplicated = DuplicateHandle(
            parentProcessHandle,
            reinterpret_cast<HANDLE>(stoul(arguments[4])),
            GetCurrentProcess(),
            &ownTurnEvent,
            0,
            FALSE,
            DUPLICATE_SAME_ACCESS
        );
        const BOOL isNextEventDuplicated = DuplicateHandle(
            parentProcessHandle,
            reinterpret_cast<HANDLE>(stoul(arguments[5])),
            GetCurrentProcess(),
            &nextTurnEvent,
            0,
            FALSE,
            DUPLICATE_SAME_ACCESS
        );
        CloseHandle(parentProcessHandle);

        if (isOwnEventDuplicated == FALSE || isNextEventDuplicated == FALSE)
        {
            if (ownTurnEvent != nullptr)
            {
                CloseHandle(ownTurnEvent);
            }

            if (nextTurnEvent != nullptr)
            {
                CloseHandle(nextTurnEvent);
            }

            throw runtime_error("Не удалось продублировать дескрипторы событий");
        }

        for (int i = 1; i <= countingCyclesCount; ++i)
        {
            const DWORD waitResult = WaitForSingleObject(
                ownTurnEvent,
                INFINITE
            );

            cout << "Экземпляр " << instanceNumber << ", цикл " << i << ": ";

            for (int number = 1; number <= 10; ++number)
            {
                cout << number << ' ';
                Sleep(50);
            }

            cout << '\n';

            if (SetEvent(nextTurnEvent) == FALSE)
            {
                cerr << "Экземпляр " << instanceNumber << ": не удалось передать ход следующему экземпляру\n";
                CloseHandle(ownTurnEvent);
                CloseHandle(nextTurnEvent);
                return 1;
            }
        }

        CloseHandle(ownTurnEvent);
        CloseHandle(nextTurnEvent);
        return 0;
    }

    void CloseHandles(const vector<HANDLE>& handles)
    {
        for (HANDLE handle : handles)
        {
            if (handle != nullptr)
            {
                CloseHandle(handle);
            }
        }
    }

    HANDLE CreateChildProcess(
        const wstring& applicationPath,
        int instanceNumber,
        HANDLE ownTurnEvent,
        HANDLE nextTurnEvent
    )
    {
        wstring commandLine = L"\"" + applicationPath + L"\" --child " +
            to_wstring(instanceNumber) + L" " +
            to_wstring(GetCurrentProcessId()) + L" " +
            to_wstring(reinterpret_cast<uintptr_t>(ownTurnEvent)) + L" " +
            to_wstring(reinterpret_cast<uintptr_t>(nextTurnEvent));

        vector mutableCommandLine(commandLine.begin(), commandLine.end());
        mutableCommandLine.push_back(L'\0');

        STARTUPINFOW startupInformation{};
        startupInformation.cb = sizeof(startupInformation);
        PROCESS_INFORMATION processInformation{};

        if (CreateProcessW(
                applicationPath.c_str(),
                mutableCommandLine.data(),
                nullptr,
                nullptr,
                FALSE,
                0,
                nullptr,
                nullptr,
                &startupInformation,
                &processInformation
            ) == FALSE)
        {
            throw runtime_error("Не удалось создать дочерний процесс приложения");
        }

        CloseHandle(processInformation.hThread);

        return processInformation.hProcess;
    }

    int RunParentProcess()
    {
        vector<HANDLE> turnEvents;
        vector<HANDLE> childProcessHandles;
        turnEvents.reserve(childProcessesCount);
        childProcessHandles.reserve(childProcessesCount);

        wchar_t applicationPath[MAX_PATH]{};

        if (GetModuleFileNameW(
                nullptr,
                applicationPath,
                MAX_PATH
            ) == 0)
        {
            throw runtime_error("Не удалось определить путь к приложению");
        }

        for (int eventIndex = 0; eventIndex < childProcessesCount; ++eventIndex)
        {
            HANDLE turnEvent = CreateEventW(
                nullptr,
                FALSE,
                FALSE,
                nullptr
            );

            if (turnEvent == nullptr)
            {
                throw runtime_error("Не удалось создать событие синхронизации");
            }

            turnEvents.push_back(turnEvent);
        }

        for (int instanceIndex = 0; instanceIndex < childProcessesCount; ++instanceIndex)
        {
            const int nextInstanceIndex = (instanceIndex + 1) % childProcessesCount;
            HANDLE childProcessHandle = CreateChildProcess(
                applicationPath,
                instanceIndex + 1,
                turnEvents[instanceIndex],
                turnEvents[nextInstanceIndex]
            );
            childProcessHandles.push_back(childProcessHandle);
        }

        cout << "Создано экземпляров: " << childProcessesCount << "\n";
        SetEvent(turnEvents.front());

        const DWORD waitResult = WaitForMultipleObjects(
            static_cast<DWORD>(childProcessHandles.size()),
            childProcessHandles.data(),
            TRUE,
            INFINITE
        );
        if (waitResult == WAIT_FAILED)
        {
            throw runtime_error("Не удалось дождаться завершения дочерних экземпляров");
        }


        CloseHandles(childProcessHandles);
        CloseHandles(turnEvents);

        cout << "\nВсе дочерние экземпляры завершили работу\n";
        return 0;
    }
}

int wmain(int argumentsCount, wchar_t* arguments[])
{
    if (IsChildProcess(argumentsCount, arguments))
    {
        return RunChildProcess(argumentsCount, arguments);
    }

    return RunParentProcess();
}
