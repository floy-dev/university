#include <string>
#include <vector>
#include <iostream>
#include <random>

#include <termios.h>
#include <unistd.h>

#include "utils.h"

using namespace std;

vector<string> shuffle_vector(vector<string> data) {

    std::random_device rd;
    std::mt19937 g(rd());
    std::shuffle(data.begin(), data.end(), g);

    return data;
}

void set_input_mode(bool enable) {
    static termios oldt, newt;
    if (enable) {
        tcgetattr(STDIN_FILENO, &oldt);
        newt = oldt;
        // Выключаем буферизацию и отображение символов
        newt.c_lflag &= ~(ICANON | ECHO);
        tcsetattr(STDIN_FILENO, TCSANOW, &newt);
    } else {
        tcsetattr(STDIN_FILENO, TCSANOW, &oldt);
    }
}

void clear_terminal() {
    std::cout << "\x1B[2J\x1B[H";
}