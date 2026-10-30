#include "pch.h"

#include <tchar.h>

#include "obviousDll.h"

// --------------------------------------------------------------
void PrintSystemMetrics()
{
    _tprintf(TEXT("Системные метрики:\n"));
    _tprintf(TEXT("SM_CXDOUBLECLK (ширина области двойного щелчка): %d\n"),
        GetSystemMetrics(SM_CXDOUBLECLK));
    _tprintf(TEXT("SM_CYDOUBLECLK (высота области двойного щелчка): %d\n"),
        GetSystemMetrics(SM_CYDOUBLECLK));
    _tprintf(TEXT("SM_CXMIN (минимальная ширина окна): %d\n"),
        GetSystemMetrics(SM_CXMIN));
    _tprintf(TEXT("SM_CYMIN (минимальная высота окна): %d\n"),
        GetSystemMetrics(SM_CYMIN));
    _tprintf(TEXT("SM_REMOTECONTROL (сеанс удаленно управляется): %d\n"),
        GetSystemMetrics(SM_REMOTECONTROL));
}
