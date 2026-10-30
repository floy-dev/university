#pragma once

#include <windows.h>

void CreateMainWindowControls(HWND mainWindow, HINSTANCE applicationInstance);
void RefreshProcessList();
void LoadModulesForSelectedProcess();
void WaitForSelectedProcess(HWND mainWindow);
void TerminateSelectedProcess(HWND mainWindow);
void CreateNotepadJobFromWindow(HWND mainWindow);
void CheckCurrentJobFromWindow(HWND mainWindow);
void ApplyPriorityFromWindow(HWND mainWindow);
void ReleaseMainWindowControls();
