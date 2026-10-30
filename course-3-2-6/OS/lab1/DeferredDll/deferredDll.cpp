#include "pch.h"

#include <tchar.h>

#include "deferredDll.h"

// --------------------------------------------------------------
void PrintSystemParameters()
{
    BOOL flatMenu = FALSE;
    UINT keyboardSpeed = 0;

    _tprintf(TEXT("Системные параметры варианта 8:\n"));

    if (FALSE != SystemParametersInfo(SPI_GETFLATMENU, 0, &flatMenu, 0))
    {
        _tprintf(TEXT("SPI_GETFLATMENU (плоское меню): %s\n"),
            flatMenu ? TEXT("включено") : TEXT("выключено"));
    }
    else
    {
        _tprintf(TEXT("Не удалось получить SPI_GETFLATMENU (ошибка %lu)\n"),
            GetLastError());
    }

    if (FALSE != SystemParametersInfo(SPI_GETKEYBOARDSPEED, 0, &keyboardSpeed, 0))
    {
        _tprintf(TEXT("SPI_GETKEYBOARDSPEED (скорость повтора клавиатуры): %u\n"),
            keyboardSpeed);
    }
    else
    {
        _tprintf(TEXT("Не удалось получить SPI_GETKEYBOARDSPEED (ошибка %lu)\n"),
            GetLastError());
    }
}
