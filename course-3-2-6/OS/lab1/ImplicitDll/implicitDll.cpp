#include "pch.h"

#include <ShlObj.h>
#include <tchar.h>
#include <winternl.h>

#include "implicitDll.h"

// Вместо устаревшего метода
extern "C" NTSTATUS WINAPI RtlGetVersion(PRTL_OSVERSIONINFOW versionInfo);

#pragma comment(lib, "shell32.lib")
#pragma comment(lib, "ntdll.lib")

void PrintSysDirectories(const long csidl[], unsigned long count)
{
    TCHAR buffer[MAX_PATH + 1];

    for (unsigned long index = 0; index < count; ++index)
    {
        const HRESULT result = SHGetFolderPath(
            NULL, csidl[index], NULL, SHGFP_TYPE_CURRENT, buffer);

        if (S_OK == result)
        {
            _tprintf(TEXT("Каталог %lu: %s\n"), index + 1, buffer);
        }
        else
        {
            _tprintf(TEXT("Каталог %lu: не удалось получить путь (0x%08lX)\n"), index + 1,
                static_cast<unsigned long>(result));
        }
    }
}

void PrintOperatingSystemVersion()
{
    RTL_OSVERSIONINFOW versionInfo{};
    versionInfo.dwOSVersionInfoSize = sizeof(versionInfo);

    if (RtlGetVersion(&versionInfo) == 0)
    {
        _tprintf(TEXT("Версия Windows: %lu.%lu, сборка %lu\n"),
            versionInfo.dwMajorVersion,
            versionInfo.dwMinorVersion,
            versionInfo.dwBuildNumber);
    }
    else
    {
        _tprintf(TEXT("Не удалось получить версию Windows\n"));
    }
}

void PrintLocalDateTime()
{
    SYSTEMTIME localTime{};
    TCHAR dateBuffer[LOCALE_NAME_MAX_LENGTH]{};
    TCHAR timeBuffer[LOCALE_NAME_MAX_LENGTH]{};

    GetLocalTime(&localTime);

    const int dateLength = GetDateFormat(
        LOCALE_USER_DEFAULT, 0, &localTime, TEXT("d/M/yyyy"),
        dateBuffer, _countof(dateBuffer));
    const int timeLength = GetTimeFormat(
        LOCALE_USER_DEFAULT, 0, &localTime, TEXT("H:m:s"),
        timeBuffer, _countof(timeBuffer));

    if (dateLength > 0 && timeLength > 0)
    {
        _tprintf(TEXT("Текущие дата и время: %s %s\n"), dateBuffer, timeBuffer);
    }
    else
    {
        _tprintf(TEXT("Не удалось отформатировать дату и время (ошибка %lu)\n"), GetLastError());
    }
}
