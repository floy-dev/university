#include <iostream>

#include <ShlObj.h>
#include <delayimp.h>
#include <deferredDll.h>
#include <printLibrary.h>
#include <implicitDll.h>
#include <tchar.h>

void PrintMetricsFromObviousDll()
{
    const HMODULE module = LoadLibrary(TEXT("ObviousDll.dll"));

    if (NULL == module)
    {
        _tprintf(TEXT("Не удалось загрузить ObviousDll.dll (ошибка %lu)\n"), GetLastError());
        return;
    }

    using PrintSystemMetricsFunction = void (*)();
    const auto printSystemMetrics = reinterpret_cast<PrintSystemMetricsFunction>(
        GetProcAddress(module, "PrintSystemMetrics"));

    if (nullptr != printSystemMetrics)
    {
        printSystemMetrics();
    }
    else
    {
        _tprintf(TEXT("Не найдена функция PrintSystemMetrics (ошибка %lu)\n"), GetLastError());
    }

    FreeLibrary(module);
}

void PrintParametersFromDeferredDll()
{
    __try
    {
        PrintSystemParameters();
    }
    __except (EXCEPTION_EXECUTE_HANDLER)
    {
        switch (GetLastError())
        {
        case ERROR_MOD_NOT_FOUND:
            _tprintf(TEXT("Не найдена библиотека DeferredDll.dll\n"));
            break;
        case ERROR_PROC_NOT_FOUND:
            _tprintf(TEXT("Не найдена функция PrintSystemParameters\n"));
            break;
        default:
            _tprintf(TEXT("Ошибка отложенной загрузки DeferredDll.dll: %lu\n"),
                GetLastError());
            break;
        }
    }

    __FUnloadDelayLoadedDLL2("DeferredDll.dll");
}

int main()
{
    _tsetlocale(LC_ALL, TEXT("Russian"));

    PrintComputerName();
    PrintDNSHostname();
    PrintUserName();
    PrintUserFullName();

    const long systemDirectories[] = {
        CSIDL_APPDATA,
        CSIDL_COMMON_APPDATA,
        CSIDL_COMMON_DOCUMENTS,
        CSIDL_HISTORY,
        CSIDL_INTERNET_CACHE,
        CSIDL_LOCAL_APPDATA,
        CSIDL_PERSONAL,
        CSIDL_PROGRAM_FILES,
        CSIDL_PROGRAM_FILES_COMMON,
        CSIDL_SYSTEM,
        CSIDL_WINDOWS
    };

    PrintSysDirectories(systemDirectories, _countof(systemDirectories));
    PrintOperatingSystemVersion();
    PrintLocalDateTime();

    PrintMetricsFromObviousDll();
    PrintParametersFromDeferredDll();
}
