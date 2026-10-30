#include "framework.h"
#include "ProcessList.h"

#include <Psapi.h>
#include <strsafe.h>
#include <windowsx.h>

#pragma comment(lib, "Psapi.lib")

static DWORD GetProcessName(DWORD processId, TCHAR processName[], DWORD processNameSize)
{
	DWORD writtenCharacters = 0;

	HANDLE processHandle = OpenProcess(
		PROCESS_VM_READ | PROCESS_QUERY_INFORMATION,
		FALSE,
		processId
	);
	if (processHandle != nullptr)
	{
		writtenCharacters = GetModuleBaseName(
			processHandle,
			nullptr,
			processName,
			processNameSize
		);
		CloseHandle(processHandle);
	}

	return writtenCharacters;
}

void LoadProcessesToListBox(HWND processListBox)
{
	// Удаляем все строки из списка
	ListBox_ResetContent(processListBox);

	// Получаем список идентификаторов процессов
	DWORD processIds[1024]{};
	DWORD bytesReturned = 0;
	const BOOL isEnumerationSuccessful =
		EnumProcesses(
			processIds,
			sizeof(processIds),
			&bytesReturned
		);

	if (!isEnumerationSuccessful)
	{
		return;
	}

	const DWORD processCount = bytesReturned / sizeof(DWORD);
	for (DWORD processIndex = 0; processIndex < processCount; ++processIndex)
	{
		const DWORD processId = processIds[processIndex];
		if (processId == 0)
		{
			continue;
		}

		TCHAR processName[MAX_PATH]{};
		TCHAR processDescription[300]{};
		const DWORD writtenCharacters = GetProcessName(
			processId,
			processName,
			MAX_PATH
		);

		if (writtenCharacters == 0)
		{
			StringCchCopy(
				processName,
				MAX_PATH,
				TEXT("Неизвестный процесс")
			);
		}

		StringCchPrintf(
			processDescription,
			_countof(processDescription),
			TEXT("%s (PID: %u)"),
			processName,
			processId
		);

		const int listItemIndex = ListBox_AddString(
			processListBox,
			processDescription
		);
		if (listItemIndex != LB_ERR && listItemIndex != LB_ERRSPACE)
		{
			ListBox_SetItemData(processListBox, listItemIndex, processId);
		}
	}
}

void LoadModulesToListBox(HWND moduleListBox, DWORD processId)
{
	// Удаляем список модулей предыдущего выбранного процесса
	ListBox_ResetContent(moduleListBox);

	// Открываем объект ядра «процесс»
	const HANDLE processHandle = OpenProcess(
		PROCESS_QUERY_INFORMATION | PROCESS_VM_READ,
		FALSE,
		processId
	);
	if (processHandle == nullptr)
	{
		return;
	}

	// Определяем размер списка модулей в байтах
	DWORD bytesNeeded = 0;
	EnumProcessModulesEx(
		processHandle,
		nullptr,
		0,
		&bytesNeeded,
		LIST_MODULES_ALL
	);

	const DWORD moduleCount = bytesNeeded / sizeof(HMODULE);
	if (moduleCount != 0)
	{
		HMODULE* moduleHandles = new HMODULE[moduleCount];
		bytesNeeded = moduleCount * sizeof(HMODULE);
		const BOOL areModulesReceived = EnumProcessModulesEx(
			processHandle,
			moduleHandles,
			bytesNeeded,
			&bytesNeeded,
			LIST_MODULES_ALL
		);

		if (areModulesReceived)
		{
			for (DWORD moduleIndex = 0; moduleIndex < moduleCount; ++moduleIndex)
			{
				TCHAR moduleFileName[MAX_PATH]{};
				const DWORD writtenCharacters = GetModuleFileNameEx(
					processHandle,
					moduleHandles[moduleIndex],
					moduleFileName,
					MAX_PATH
				);

				if (writtenCharacters != 0)
				{
					ListBox_AddString(
						moduleListBox,
						moduleFileName
					);
				}
			}
		}

		delete[] moduleHandles;
	}

	CloseHandle(processHandle);
}
