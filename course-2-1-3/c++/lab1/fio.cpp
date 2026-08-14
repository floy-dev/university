#include <iostream>
#include <cmath>

using namespace std;

int main() {

    cout << "Дмитриев Дмитрий Анатольевич ИТз-221" << endl;

    double x;

    int n1, n2;

    cout << "Введите первое число: ";
    cin >> n1;

    x = pow(n1, 3);

    cout << "Введите второе число: ";
    cin >> n2;

    cout << "Сумма " << n1 << " + " << n2 << " = " << n1 + n2 << endl;
}