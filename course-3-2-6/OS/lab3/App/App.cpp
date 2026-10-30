#include "framework.h"
#include "App.h"
#include "MainWindowControls.h"

#define MAX_LOADSTRING 100

namespace
{
    // Размер внешнего окна рассчитан на все списки, кнопки и панели задания
    // Окно создаётся без рамки изменения размера
    constexpr int kWindowWidth = 880;
    constexpr int kWindowHeight = 760;
}

// Данные, необходимые для регистрации и создания главного окна
HINSTANCE hInst;
WCHAR szTitle[MAX_LOADSTRING];
WCHAR szWindowClass[MAX_LOADSTRING];

ATOM MyRegisterClass(HINSTANCE hInstance);
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow);
LRESULT CALLBACK WndProc(HWND windowHandle, UINT message, WPARAM wParam, LPARAM lParam);
INT_PTR CALLBACK About(HWND dialogHandle, UINT message, WPARAM wParam, LPARAM lParam);

int APIENTRY wWinMain(
    _In_ HINSTANCE hInstance,
    _In_opt_ HINSTANCE hPrevInstance,
    _In_ LPWSTR commandLine,
    _In_ int nCmdShow
)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(commandLine);

    // Загружаем заголовок и имя класса окна из ресурсов приложения
    LoadStringW(
        hInstance,
        IDS_APP_TITLE,
        szTitle,
        MAX_LOADSTRING
    );
    LoadStringW(
        hInstance,
        IDC_APP,
        szWindowClass,
        MAX_LOADSTRING
    );

    MyRegisterClass(hInstance);
    if (!InitInstance(hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL acceleratorTable = LoadAccelerators(
        hInstance,
        MAKEINTRESOURCE(IDC_APP)
    );
    MSG message{};

    // Основной цикл передаёт действия пользователя обработчику WndProc
    while (GetMessage(
        &message,
        nullptr,
        0,
        0
    ))
    {
        if (!TranslateAccelerator(message.hwnd, acceleratorTable, &message))
        {
            TranslateMessage(&message);
            DispatchMessage(&message);
        }
    }

    return static_cast<int>(message.wParam);
}

ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW windowClass{};
    windowClass.cbSize = sizeof(WNDCLASSEXW);
    windowClass.style = CS_HREDRAW | CS_VREDRAW;
    windowClass.lpfnWndProc = WndProc;
    windowClass.hInstance = hInstance;
    windowClass.hIcon = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_APP));
    windowClass.hCursor = LoadCursor(nullptr, IDC_ARROW);
    windowClass.hbrBackground = reinterpret_cast<HBRUSH>(
        static_cast<INT_PTR>(COLOR_WINDOW + 1)
    );
    windowClass.lpszMenuName = MAKEINTRESOURCEW(IDC_APP);
    windowClass.lpszClassName = szWindowClass;
    windowClass.hIconSm = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&windowClass);
}

BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
    hInst = hInstance;

    // Фиксированные размеры исключают необходимость переразмещать элементы
    // интерфейса при изменении размера окна
    const HWND mainWindow = CreateWindowW(
        szWindowClass,
        szTitle,
        WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_MINIMIZEBOX,
        CW_USEDEFAULT,
        CW_USEDEFAULT,
        kWindowWidth,
        kWindowHeight,
        nullptr,
        nullptr,
        hInstance,
        nullptr
    );
    if (mainWindow == nullptr)
    {
        return FALSE;
    }

    ShowWindow(mainWindow, nCmdShow);
    UpdateWindow(mainWindow);
    return TRUE;
}

LRESULT CALLBACK WndProc(HWND windowHandle, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
    case WM_CREATE:
        // Создаём списки процессов и модулей, панель задания и приоритетов
        CreateMainWindowControls(windowHandle, hInst);
        return 0;

    case WM_COMMAND:
    {
        const int commandId = LOWORD(wParam);
        const int notificationCode = HIWORD(wParam);

        // Команды кнопок выполняют операции с выбранным процессом,
        // объектом задания или приоритетами текущего приложения
        switch (commandId)
        {
        case IDM_ABOUT:
            DialogBox(
                hInst,
                MAKEINTRESOURCE(IDD_ABOUTBOX),
                windowHandle,
                About
            );
            return 0;

        case IDM_EXIT:
            DestroyWindow(windowHandle);
            return 0;

        case IDM_REFRESH_PROCESSES:
            RefreshProcessList();
            return 0;

        case IDM_WAIT_FOR_PROCESS:
            WaitForSelectedProcess(windowHandle);
            return 0;

        case IDM_TERMINATE_PROCESS:
            TerminateSelectedProcess(windowHandle);
            return 0;

        case IDM_CREATE_NOTEPAD_JOB:
            CreateNotepadJobFromWindow(windowHandle);
            return 0;

        case IDM_CHECK_CURRENT_JOB:
            CheckCurrentJobFromWindow(windowHandle);
            return 0;

        case IDM_APPLY_PRIORITY:
            ApplyPriorityFromWindow(windowHandle);
            return 0;

        case IDC_PROCESS_LIST:
            // При смене строки загружаем модули именно выбранного процесса
            if (notificationCode == LBN_SELCHANGE)
            {
                LoadModulesForSelectedProcess();
            }
            return 0;

        default:
            return DefWindowProc(
                windowHandle,
                message,
                wParam,
                lParam
            );
        }
    }

    case WM_PAINT:
    {
        // Отрисовку выполняют дочерние элементы управления; BeginPaint и
        // EndPaint подтверждают Windows обработку сообщения перерисовки
        PAINTSTRUCT paintStructure{};
        BeginPaint(windowHandle, &paintStructure);
        EndPaint(windowHandle, &paintStructure);
        return 0;
    }

    case WM_DESTROY:
        // Закрываем сохранённый дескриптор задания перед выходом из приложения
        ReleaseMainWindowControls();
        PostQuitMessage(0);
        return 0;

    default:
        return DefWindowProc(
            windowHandle,
            message,
            wParam,
            lParam
        );
    }
}

INT_PTR CALLBACK About(HWND dialogHandle, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);

    if (message == WM_INITDIALOG)
    {
        return static_cast<INT_PTR>(TRUE);
    }

    if (message == WM_COMMAND &&
        (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL))
    {
        EndDialog(dialogHandle, LOWORD(wParam));
        return static_cast<INT_PTR>(TRUE);
    }

    return static_cast<INT_PTR>(FALSE);
}
