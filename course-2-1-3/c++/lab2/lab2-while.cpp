#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double h, x, y, a, b, n, numerator, denominator;
    int i = 0;

    cout << "Введите значение a: ";
    cin >> a;

    cout << "Введите значение b: ";
    cin >> b;

    cout << "Введите значение n: ";
    cin >> n;

    h = (b - a) / n;
    double max, avg = 0;
    int cycles = 0;

    while (i <= n)
    {
        x = a + i * h;

        i++;

        if (x == 0 || abs(x) == 2) {
            cout << "Значение x = " << x << " вне ОДЗ" << endl;
            continue;
        }

        numerator = sin(x) + (1 / x);
        denominator = cbrt(pow(tan(-((pow(x, 3)) / (pow(x, 2) - 4))), 2));

        y = (numerator / denominator) + pow(2, (abs(x - 1)));

        avg += y;
        if (y > max) {
            max = y;
        }
        cycles++;

        cout << "При x = " << x << ", y = " << y << endl;
    }

    if (cycles > 0) {
        cout << "Наибольшее значение: " << max << endl;
        cout << "Среднее значение: " << avg / cycles << endl;
    }
}