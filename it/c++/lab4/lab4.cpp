#include <iostream>
#include <iomanip>
#include <fstream>

using namespace std;

// /home/floy/www/university/it/c++/lab4/asc.txt

int main() {

    string filename;

    cout << "Введите абсолютный путь до файла с исходными данными: ";
    cin >> filename;

    ifstream input_file_stream(filename);
    if (!input_file_stream.is_open()) {
        cout << "Ошибка открытия входного файла" << endl;

        return 1;
    }

    unsigned n,i,j;
    if (!(input_file_stream >> n)) {
        cout << "Ошибка чтения данных из файла" << endl;
        return 1;
    }

    int** matrix = new int *[n];
    bool is_matrix_asc_sorted = true;
    int last_number_in_matrix;

    for (i = 0; i < n; i++) {
        matrix[i] = new int[n];
        for (j = 0; j < n; j++) {
            if (!(input_file_stream >> matrix[i][j])) {
                cout << "Ошибка чтения данных из файла" << endl;

                return 1;
            }

            if (last_number_in_matrix && is_matrix_asc_sorted && last_number_in_matrix > matrix[i][j]) {
                is_matrix_asc_sorted = false;
            }

            last_number_in_matrix = matrix[i][j];
        }
    }

    input_file_stream.close();

    int array_value = is_matrix_asc_sorted ? 1 : -1;

    int* array = new int [n];
    for (int i = 0; i < n; ++i) {
        array[i] = array_value;
    }

    ofstream output_file_stream;

    cout << "Введите абсолютный путь до выходного файла: ";
    cin >> filename;

    output_file_stream.open(filename);
    if (!output_file_stream.is_open()) {
        cout << "Ошибка создания выходного файла" << endl;

        return 1;
    }

    output_file_stream << "Исходная матрица:" << endl;
    cout << "Исходная матрица:" << endl;
    for (i = 0; i < n; i++) {
        for (j = 0; j < n; j++) {
            output_file_stream << matrix[i][j];
            cout << matrix[i][j];
            if (j != n - 1) {
                output_file_stream << setw(4);
                cout << "  ";
            }
        }
        output_file_stream << endl;
        cout << endl;
    }

    output_file_stream << endl;
    cout << endl;

    output_file_stream << "Результирующий массив:" << endl;
    cout << "Результирующий массив:" << endl;
    for (i = 0; i < n; i++) {
        output_file_stream << array[i] << setw(4);
        cout << array[i] << "  ";
    }

    cout << endl;

    delete[] matrix;
    delete[] array;

    output_file_stream.close();
    cout << endl << "Работа программы завершена" << endl;

    return 0;
}