#include<iostream>
#include<algorithm>

using namespace std;

int main() {

    int result[20];
    int array[20] {
        1, -1, 8, 2, 6,
        0, 2, -6, 1, 5,
        4, -4, 3, 6, -3,
        -3, 2, -1, 4, -2,
    };

    cout << "Исходный массив:" << endl;
    for (int i = 1; i <= 20; i++) {
        cout << array[i - 1] << " ";
        if (i % 5 == 0) {
            cout << endl;
        }
    }

    for (int i = 0; i < 20; i++) {
        result[i] = array[i] >= 0 ? 1 : array[i];
    }

    sort(&result[0], &result[20], greater<int>());

    cout << "Вычисленный массив:" << endl;
    for (int i = 1; i <= 20; i++) {
        cout << result[i - 1] << " ";
        if (i % 5 == 0) {
            cout << endl;
        }
    }
}

