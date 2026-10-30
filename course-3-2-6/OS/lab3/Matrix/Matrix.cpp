
#define NOMINMAX
#include <windows.h>

#include <algorithm>
#include <cstdint>
#include <iostream>
#include <process.h>
#include <random>
#include <stdexcept>
#include <vector>

using namespace std;

namespace
{

    struct MatrixStatistics
    {
        long long twoDigitNumbersCount = 0;
        int minimumValue = 999;
        int maximumValue = 0;
    };

    struct RowThreadParameters
    {
        vector<vector<int>>* matrix = nullptr;
        int rowIndex = 0;
        MatrixStatistics* commonStatistics = nullptr;
        CRITICAL_SECTION* statisticsCriticalSection = nullptr;
    };

    unsigned __stdcall ProcessMatrixRow(void* parameter)
    {
        const auto* threadParameters = static_cast<RowThreadParameters*>(parameter);
        vector<int>& matrixRow = (*threadParameters->matrix)[threadParameters->rowIndex];

        random_device randomDevice;
        mt19937 randomGenerator(randomDevice());
        uniform_int_distribution valueDistribution(0,999);

        MatrixStatistics rowStatistics;

        for (int& value : matrixRow)
        {
            value = valueDistribution(randomGenerator);

            if (value >= 10 && value <= 99)
            {
                ++rowStatistics.twoDigitNumbersCount;
            }

            rowStatistics.minimumValue = min(value, rowStatistics.minimumValue);

            rowStatistics.maximumValue = max(value, rowStatistics.maximumValue);
        }

        EnterCriticalSection(threadParameters->statisticsCriticalSection);

        threadParameters->commonStatistics->twoDigitNumbersCount +=
            rowStatistics.twoDigitNumbersCount;

        threadParameters->commonStatistics->minimumValue = min(
            rowStatistics.minimumValue,
            threadParameters->commonStatistics->minimumValue
        );

        threadParameters->commonStatistics->maximumValue = max(
            rowStatistics.maximumValue,
            threadParameters->commonStatistics->maximumValue
        );

        LeaveCriticalSection(threadParameters->statisticsCriticalSection);

        return 0;
    }

    void PrintMatrix(const vector<vector<int>>& matrix)
    {
        cout << "\nСформированная матрица:\n";

        for (const vector<int>& matrixRow : matrix)
        {
            for (int value : matrixRow)
            {
                cout.width(4);
                cout << value;
            }

            cout << '\n';
        }
    }
}

int main()
{
    int rowsCount = 10;
    int columnsCount = 10;

    vector matrix(
        rowsCount,
        vector<int>(columnsCount)
    );
    vector<RowThreadParameters> threadParameters(rowsCount);
    vector<HANDLE> threadHandles;
    threadHandles.reserve(rowsCount);

    MatrixStatistics commonStatistics;
    CRITICAL_SECTION statisticsCriticalSection;
    InitializeCriticalSection(&statisticsCriticalSection);

    try
    {
        for (int rowIndex = 0; rowIndex < rowsCount; ++rowIndex)
        {
            threadParameters[rowIndex] = {
                &matrix,
                rowIndex,
                &commonStatistics,
                &statisticsCriticalSection
            };

            uintptr_t rowThreadValue = _beginthreadex(
                nullptr,
                0,
                ProcessMatrixRow,
                &threadParameters[rowIndex],
                0,
                nullptr
            );
            HANDLE rowThread = reinterpret_cast<HANDLE>(rowThreadValue);

            if (rowThread == nullptr)
            {
                throw runtime_error("Не удалось создать поток для строки матрицы");
            }

            threadHandles.push_back(rowThread);
        }

        for (HANDLE threadHandle : threadHandles)
        {
            WaitForSingleObject(
                threadHandle,
                INFINITE
            );
        }
    }
    catch (const exception& exception)
    {
        if (!threadHandles.empty())
        {
            for (HANDLE threadHandle : threadHandles)
            {
                WaitForSingleObject(
                    threadHandle,
                    INFINITE
                );
            }
        }

        for (HANDLE threadHandle : threadHandles)
        {
            CloseHandle(threadHandle);
        }

        DeleteCriticalSection(&statisticsCriticalSection);
        cerr << "Ошибка: " << exception.what() << '\n';
        return 1;
    }

    for (HANDLE threadHandle : threadHandles)
    {
        CloseHandle(threadHandle);
    }

    DeleteCriticalSection(&statisticsCriticalSection);

    PrintMatrix(matrix);
    cout << "\nКоличество двухзначных чисел: "
         << commonStatistics.twoDigitNumbersCount << '\n';
    cout << "Минимальное значение: " << commonStatistics.minimumValue << '\n';
    cout << "Максимальное значение: " << commonStatistics.maximumValue << '\n';

    return 0;
}
