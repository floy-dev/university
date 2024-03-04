#include<iostream>
#include<algorithm>

using namespace std;

int main() {

    int array[4][5] = {
        {1, -1, 8, 2, 6},
        {0, 2, -6, 1, 5},
        {4, -4, 3, 6, -3},
        {-3, 2, -1, 4, -2},
    };

    cout << "Исходный массив:" << endl;
    for (int i = 0; i < size(array); i++) {
        for (int j = 0; j < size(array[i]); j++) {
            cout << array[i][j] << " ";
        }
        cout << endl;
    }

    for (int i = 0; i < size(array); i++) {
        for (int j = 0; j < size(array[i]); j++) {
            if (array[i][j] >= 0) {
                array[i][j] = 1;
            }
        }
        sort(&array[i][0], &array[i][size(array[i])], greater<int>());
    }

    cout << "Вычисленный массив:" << endl;
    for (int i = 0; i < size(array); i++) {
        for (int j = 0; j < size(array[i]); j++) {
            cout << array[i][j] << " ";
        }
        cout << endl;
    }
}

