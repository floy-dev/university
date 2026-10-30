#pragma once

#include <windows.h>

void LoadProcessesToListBox(HWND processListBox);
void LoadModulesToListBox(HWND moduleListBox, DWORD processId);
