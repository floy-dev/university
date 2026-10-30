#include "framework.h"
#include "MainWindowControls.h"
#include "JobActions.h"
#include "PriorityActions.h"
#include "ProcessActions.h"
#include "ProcessList.h"
#include "Resource.h"

#include <strsafe.h>
#include <windowsx.h>

namespace
{
    constexpr int kControlMargin = 12;
    constexpr int kTopRowTop = 12;
    constexpr int kTopButtonHeight = 28;
    constexpr int kHeaderTop = 52;
    constexpr int kHeaderHeight = 20;
    constexpr int kListTop = 76;
    constexpr int kBottomPanelHeight = 220;

    HWND g_processListBox = nullptr;
    HWND g_moduleListBox = nullptr;
    HWND g_jobProcessListBox = nullptr;
    HWND g_processPriorityComboBox = nullptr;
    HWND g_threadPriorityComboBox = nullptr;
    HWND g_jobStatusText = nullptr;
    HWND g_processListHeader = nullptr;
    HWND g_moduleListHeader = nullptr;
    HWND g_jobGroupBox = nullptr;
    HWND g_priorityGroupBox = nullptr;
    HWND g_createJobButton = nullptr;
    HWND g_checkJobButton = nullptr;
    HWND g_applyPriorityButton = nullptr;
    HWND g_processPriorityLabel = nullptr;
    HWND g_threadPriorityLabel = nullptr;
    HANDLE g_createdJobHandle = nullptr;

    void ShowMessage(HWND mainWindow, LPCWSTR text, LPCWSTR title, UINT flags)
    {
        MessageBoxW(
            mainWindow,
            text,
            title,
            flags
        );
    }

    bool TryGetSelectedProcessId(HWND mainWindow, DWORD& processId)
    {
        const int selectedItemIndex = ListBox_GetCurSel(g_processListBox);
        if (selectedItemIndex == LB_ERR)
        {
            ShowMessage(
                mainWindow,
                L"Сначала выберите процесс в списке",
                L"Процессы",
                MB_OK | MB_ICONINFORMATION
            );
            return false;
        }

        const LRESULT selectedProcessData = ListBox_GetItemData(
            g_processListBox,
            selectedItemIndex
        );
        processId = static_cast<DWORD>(selectedProcessData);
        return true;
    }

    void AddComboBoxItem(HWND comboBox, LPCWSTR text, LPARAM value)
    {
        const int itemIndex = ComboBox_AddString(
            comboBox,
            const_cast<LPWSTR>(text)
        );
        ComboBox_SetItemData(
            comboBox,
            itemIndex,
            value
        );
    }

    void SelectComboBoxItemByValue(HWND comboBox, LPARAM value)
    {
        const int itemCount = ComboBox_GetCount(comboBox);
        for (int itemIndex = 0; itemIndex < itemCount; ++itemIndex)
        {
            if (ComboBox_GetItemData(comboBox, itemIndex) == value)
            {
                ComboBox_SetCurSel(comboBox, itemIndex);
                return;
            }
        }
    }

    bool TryGetComboBoxValue(HWND comboBox, LPARAM& value)
    {
        const int selectedItemIndex = ComboBox_GetCurSel(comboBox);
        if (selectedItemIndex == CB_ERR)
        {
            return false;
        }

        value = ComboBox_GetItemData(comboBox, selectedItemIndex);
        return value != CB_ERR;
    }

    void FillJobProcessList(const std::vector<DWORD>& processIds)
    {
        ListBox_ResetContent(g_jobProcessListBox);
        for (const DWORD processId : processIds)
        {
            WCHAR processDescription[64]{};
            StringCchPrintfW(
                processDescription,
                _countof(processDescription),
                L"PID: %u",
                processId
            );
            ListBox_AddString(
                g_jobProcessListBox,
                processDescription
            );
        }
    }

    void FillPriorityComboBoxes()
    {
        AddComboBoxItem(g_processPriorityComboBox, L"Низкий", IDLE_PRIORITY_CLASS);
        AddComboBoxItem(g_processPriorityComboBox, L"Ниже обычного", BELOW_NORMAL_PRIORITY_CLASS);
        AddComboBoxItem(g_processPriorityComboBox, L"Обычный", NORMAL_PRIORITY_CLASS);
        AddComboBoxItem(g_processPriorityComboBox, L"Выше обычного", ABOVE_NORMAL_PRIORITY_CLASS);
        AddComboBoxItem(g_processPriorityComboBox, L"Высокий", HIGH_PRIORITY_CLASS);

        AddComboBoxItem(g_threadPriorityComboBox, L"Простой", THREAD_PRIORITY_IDLE);
        AddComboBoxItem(g_threadPriorityComboBox, L"Самый низкий", THREAD_PRIORITY_LOWEST);
        AddComboBoxItem(g_threadPriorityComboBox, L"Ниже обычного", THREAD_PRIORITY_BELOW_NORMAL);
        AddComboBoxItem(g_threadPriorityComboBox, L"Обычный", THREAD_PRIORITY_NORMAL);
        AddComboBoxItem(g_threadPriorityComboBox, L"Выше обычного", THREAD_PRIORITY_ABOVE_NORMAL);
        AddComboBoxItem(g_threadPriorityComboBox, L"Высокий", THREAD_PRIORITY_HIGHEST);

        SelectComboBoxItemByValue(
            g_processPriorityComboBox,
            GetPriorityClass(GetCurrentProcess())
        );
        SelectComboBoxItemByValue(
            g_threadPriorityComboBox,
            GetThreadPriority(GetCurrentThread())
        );
    }
}

void CreateMainWindowControls(HWND mainWindow, HINSTANCE applicationInstance)
{
    CreateWindowW(
        L"BUTTON", L"Обновить список", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
        12, kTopRowTop, 150, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDM_REFRESH_PROCESSES)),
        applicationInstance, nullptr
    );
    CreateWindowW(
        L"STATIC", L"Время ожидания (мс):", WS_CHILD | WS_VISIBLE,
        174, 18, 140, 20, mainWindow, nullptr, applicationInstance, nullptr
    );
    CreateWindowExW(
        WS_EX_CLIENTEDGE, L"EDIT", L"5000", WS_CHILD | WS_VISIBLE | ES_AUTOHSCROLL | ES_NUMBER,
        316, kTopRowTop, 90, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDC_TIMEOUT_EDIT)),
        applicationInstance, nullptr
    );
    CreateWindowW(
        L"BUTTON", L"Ожидать завершения", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
        418, kTopRowTop, 170, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDM_WAIT_FOR_PROCESS)),
        applicationInstance, nullptr
    );
    CreateWindowW(
        L"BUTTON", L"Завершить процесс", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
        600, kTopRowTop, 160, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDM_TERMINATE_PROCESS)),
        applicationInstance, nullptr
    );

    g_processListHeader = CreateWindowW(
        L"STATIC", L"Процессы", WS_CHILD | WS_VISIBLE,
        kControlMargin, kHeaderTop, 350, kHeaderHeight, mainWindow,
        nullptr, applicationInstance, nullptr
    );
    g_processListBox = CreateWindowExW(
        WS_EX_CLIENTEDGE, L"LISTBOX", nullptr,
        WS_CHILD | WS_VISIBLE | WS_VSCROLL | LBS_NOTIFY | LBS_NOINTEGRALHEIGHT,
        kControlMargin, kListTop, 400, 350, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDC_PROCESS_LIST)),
        applicationInstance, nullptr
    );
    g_moduleListHeader = CreateWindowW(
        L"STATIC", L"Модули выбранного процесса", WS_CHILD | WS_VISIBLE,
        424, kHeaderTop, 400, kHeaderHeight, mainWindow,
        nullptr, applicationInstance, nullptr
    );
    g_moduleListBox = CreateWindowExW(
        WS_EX_CLIENTEDGE, L"LISTBOX", nullptr,
        WS_CHILD | WS_VISIBLE | WS_VSCROLL | WS_HSCROLL | LBS_NOINTEGRALHEIGHT,
        424, kListTop, 426, 350, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDC_MODULE_LIST)),
        applicationInstance, nullptr
    );

    g_jobGroupBox = CreateWindowW(
        L"BUTTON", L"Задание", WS_CHILD | WS_VISIBLE | BS_GROUPBOX,
        12, 438, 500, 200, mainWindow, nullptr, applicationInstance, nullptr
    );
    g_createJobButton = CreateWindowW(
        L"BUTTON", L"Создать 3 Блокнота и задание", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
        24, 466, 220, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDM_CREATE_NOTEPAD_JOB)),
        applicationInstance, nullptr
    );
    g_checkJobButton = CreateWindowW(
        L"BUTTON", L"Проверить своё задание", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
        24, 500, 220, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDM_CHECK_CURRENT_JOB)),
        applicationInstance, nullptr
    );
    g_jobStatusText = CreateWindowW(
        L"STATIC", L"Текущее приложение: не проверено", WS_CHILD | WS_VISIBLE,
        24, 536, 450, 20, mainWindow, nullptr, applicationInstance, nullptr
    );
    g_jobProcessListBox = CreateWindowExW(
        WS_EX_CLIENTEDGE, L"LISTBOX", nullptr,
        WS_CHILD | WS_VISIBLE | WS_VSCROLL | LBS_NOINTEGRALHEIGHT,
        24, 562, 460, 64, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDC_JOB_PROCESS_LIST)),
        applicationInstance, nullptr
    );

    g_priorityGroupBox = CreateWindowW(
        L"BUTTON", L"Приоритеты текущего приложения", WS_CHILD | WS_VISIBLE | BS_GROUPBOX,
        524, 438, 330, 200, mainWindow, nullptr, applicationInstance, nullptr
    );
    g_processPriorityLabel = CreateWindowW(
        L"STATIC", L"Класс процесса:", WS_CHILD | WS_VISIBLE,
        536, 470, 130, 20, mainWindow, nullptr, applicationInstance, nullptr
    );
    g_processPriorityComboBox = CreateWindowW(
        L"COMBOBOX", nullptr, WS_CHILD | WS_VISIBLE | CBS_DROPDOWNLIST | WS_VSCROLL,
        668, 466, 180, 160, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDC_PROCESS_PRIORITY)),
        applicationInstance, nullptr
    );
    g_threadPriorityLabel = CreateWindowW(
        L"STATIC", L"Приоритет главного потока:", WS_CHILD | WS_VISIBLE,
        536, 506, 130, 36, mainWindow, nullptr, applicationInstance, nullptr
    );
    g_threadPriorityComboBox = CreateWindowW(
        L"COMBOBOX", nullptr, WS_CHILD | WS_VISIBLE | CBS_DROPDOWNLIST | WS_VSCROLL,
        668, 506, 180, 180, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDC_THREAD_PRIORITY)),
        applicationInstance, nullptr
    );
    g_applyPriorityButton = CreateWindowW(
        L"BUTTON", L"Применить", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
        668, 550, 140, kTopButtonHeight, mainWindow,
        reinterpret_cast<HMENU>(static_cast<INT_PTR>(IDM_APPLY_PRIORITY)),
        applicationInstance, nullptr
    );

    FillPriorityComboBoxes();
    LoadProcessesToListBox(g_processListBox);
}

void RefreshProcessList()
{
    if (g_processListBox != nullptr)
    {
        LoadProcessesToListBox(g_processListBox);
        ListBox_ResetContent(g_moduleListBox);
    }
}

void LoadModulesForSelectedProcess()
{
    DWORD selectedProcessId = 0;
    if (!TryGetSelectedProcessId(GetParent(g_processListBox), selectedProcessId))
    {
        return;
    }
    LoadModulesToListBox(g_moduleListBox, selectedProcessId);
}

void WaitForSelectedProcess(HWND mainWindow)
{
    DWORD selectedProcessId = 0;
    if (!TryGetSelectedProcessId(mainWindow, selectedProcessId))
    {
        return;
    }
    BOOL isTimeoutValid = FALSE;
    const UINT timeoutMilliseconds = GetDlgItemInt(
        mainWindow, IDC_TIMEOUT_EDIT, &isTimeoutValid, FALSE
    );

    DWORD exitCode = 0;
    const DWORD waitResult = WaitForProcessById(
        selectedProcessId, timeoutMilliseconds, &exitCode
    );
    if (waitResult == WAIT_OBJECT_0)
    {
        WCHAR message[160]{};
        StringCchPrintfW(message, _countof(message),
            L"Процесс с PID %u завершился. Код завершения: %u", selectedProcessId, exitCode);
        ShowMessage(mainWindow, message, L"Ожидание завершено", MB_OK | MB_ICONINFORMATION);
        RefreshProcessList();
        return;
    }
    if (waitResult == WAIT_TIMEOUT)
    {
        ShowMessage(mainWindow, L"Время ожидания истекло. Процесс продолжает работу",
            L"Ожидание завершено", MB_OK | MB_ICONINFORMATION);
        return;
    }
    ShowMessage(mainWindow, L"Не удалось открыть процесс для ожидания",
        L"Ошибка", MB_OK | MB_ICONERROR);
}

void TerminateSelectedProcess(HWND mainWindow)
{
    DWORD selectedProcessId = 0;
    if (!TryGetSelectedProcessId(mainWindow, selectedProcessId))
    {
        return;
    }
    if (!TerminateProcessById(selectedProcessId, 0))
    {
        ShowMessage(mainWindow, L"Не удалось завершить выбранный процесс",
            L"Ошибка", MB_OK | MB_ICONERROR);
        return;
    }
    RefreshProcessList();
    ShowMessage(mainWindow, L"Команда на завершение процесса отправлена",
        L"Процессы", MB_OK | MB_ICONINFORMATION);
}

void CreateNotepadJobFromWindow(HWND mainWindow)
{
    HANDLE newJobHandle = nullptr;
    if (!CreateNotepadJob(newJobHandle))
    {
        ShowMessage(mainWindow, L"Не удалось создать задание с тремя Блокнотами",
            L"Ошибка", MB_OK | MB_ICONERROR);
        return;
    }
    if (g_createdJobHandle != nullptr)
    {
        CloseHandle(g_createdJobHandle);
    }
    g_createdJobHandle = newJobHandle;

    std::vector<DWORD> processIds;
    if (GetProcessIdsFromJob(g_createdJobHandle, processIds))
    {
        FillJobProcessList(processIds);
    }
    SetWindowTextW(g_jobStatusText, L"Создано задание с тремя процессами Блокнот");
    RefreshProcessList();
}

void CheckCurrentJobFromWindow(HWND mainWindow)
{
    BOOL isInJob = FALSE;
    if (!IsCurrentProcessInAnyJob(isInJob))
    {
        ShowMessage(mainWindow, L"Не удалось проверить принадлежность приложения заданию",
            L"Ошибка", MB_OK | MB_ICONERROR);
        return;
    }
    if (!isInJob)
    {
        SetWindowTextW(g_jobStatusText, L"Текущее приложение: не включено в задание");
        ListBox_ResetContent(g_jobProcessListBox);
        return;
    }

    std::vector<DWORD> processIds;
    if (!GetProcessIdsFromJob(nullptr, processIds))
    {
        ShowMessage(mainWindow, L"Не удалось получить список процессов задания",
            L"Ошибка", MB_OK | MB_ICONERROR);
        return;
    }
    SetWindowTextW(g_jobStatusText, L"Текущее приложение: включено в задание");
    FillJobProcessList(processIds);
}

void ApplyPriorityFromWindow(HWND mainWindow)
{
    LPARAM processPriorityClass = 0;
    LPARAM threadPriority = 0;
    if (!TryGetComboBoxValue(g_processPriorityComboBox, processPriorityClass) ||
        !TryGetComboBoxValue(g_threadPriorityComboBox, threadPriority))
    {
        ShowMessage(mainWindow, L"Выберите оба значения приоритета",
            L"Приоритеты", MB_OK | MB_ICONWARNING);
        return;
    }
    if (!SetCurrentProcessAndThreadPriority(
        static_cast<DWORD>(processPriorityClass),
        static_cast<int>(threadPriority)
    ))
    {
        ShowMessage(mainWindow, L"Не удалось применить выбранные приоритеты",
            L"Ошибка", MB_OK | MB_ICONERROR);
        return;
    }
    ShowMessage(mainWindow, L"Приоритеты текущего приложения изменены",
        L"Приоритеты", MB_OK | MB_ICONINFORMATION);
}

void ReleaseMainWindowControls()
{
    if (g_createdJobHandle != nullptr)
    {
        CloseHandle(g_createdJobHandle);
        g_createdJobHandle = nullptr;
    }
}
