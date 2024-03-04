#include <iostream>
#include <cmath>

using namespace std;

int main() {

    cout << "Введите значение x: ";

    double x, y, numerator, denominator;

    cin >> x;

    if (x == 0 || abs(x) == 2) {
        cout << "Значение x = " << x << " вне ОДЗ" << endl;
    }
    else
    {
        numerator = sin(x) + (1 / x);
        denominator = cbrt(pow(tan(-((pow(x, 3)) / (pow(x, 2) - 4))), 2));

        y = (numerator / denominator) + pow(2, (abs(x - 1)));

        cout << "При x = " << x << ", y = " << y << endl;
    }
}
