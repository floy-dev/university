#include <iostream>
#include <vector>
#include <string>
#include <chrono>
#include <unistd.h>
#include <clocale>

#include "deps/words.h"
#include "deps/utils.h"

using namespace std;
using namespace chrono;


void print_word_with_highlight(const string& word, int pos) {
    // Ставим курсор в начало строки
    cout << "\r";

    for (int i = 0; i < word.size(); i++) {
        if (i == pos) {
            cout << "\033[1;31m" << word[i] << "\033[0m";
        }
        else {
            cout << word[i];
        }
    }

    cout.flush();
}

vector<string> get_test_data()
{
    vector<string> data;

    vector<string> letters = generate_letters(25);
    vector<string> syllables = generate_syllables(25);
    vector<string> words = generate_words(25);

    data.insert(data.end(), letters.begin(), letters.end());
    data.insert(data.end(), syllables.begin(), syllables.end());
    data.insert(data.end(), words.begin(), words.end());

    data = shuffle_vector(data);

    return data;
}

int get_time_limit_on_symbol(int difficulty) {
    if (difficulty == 1) {
        return 3;
    }
    if (difficulty == 2) {
        return 2;
    }
    if (difficulty == 3) {
        return 1;
    }

    throw runtime_error("Сложность не найдена");
}

int get_time_for_test(int difficulty) {
    if (difficulty == 1) {
        return 40;
    }
    if (difficulty == 2) {
        return 30;
    }
    if (difficulty == 3) {
        return 25;
    }

    throw runtime_error("Сложность не найдена");
}

bool is_still_ongoing(auto start_time, auto symbol_start_time, int limit_on_symbol, int limit_for_test) {
    if (duration_cast<seconds>(steady_clock::now() - symbol_start_time).count() > limit_on_symbol) {
        return false;
    }

    if (duration_cast<seconds>(steady_clock::now() - start_time).count() > limit_for_test) {
        return false;
    }

    return true;
}

void print_time_left(auto start_time, int limit_for_test) {
    int seconds_left = limit_for_test - duration_cast<seconds>(steady_clock::now() - start_time).count();

    if (seconds_left > 0) {
        #ifdef _WIN32
            cout << "Time left:" << endl;
        #else
            cout << "Осталось секунд:" << endl;
        #endif
        cout << seconds_left << endl;
    }
    else {
        #ifdef _WIN32
            cout << "Time end" << endl;
        #else
            cout << "Время окончено" << endl;
        #endif
    }
}

void typing_test(const vector<string>& data, int difficulty) {

    int score = 0;
    int decrease_score = 0;
    int target_index = 0;

    int limit_on_symbol = get_time_limit_on_symbol(difficulty);
    int limit_for_test = get_time_for_test(difficulty);
    auto symbol_start_time = steady_clock::now();
    auto start_time = steady_clock::now();

    while (duration_cast<seconds>(steady_clock::now() - start_time).count() < limit_for_test) {
        const string& target = data[target_index];
        int pos = 0;

        while (pos < target.size()) {

            // Проверяем время до ввода символа
            if (!is_still_ongoing(start_time, symbol_start_time, limit_on_symbol, limit_for_test)) {
                break;
            }

            print_time_left(start_time, limit_for_test);
            print_word_with_highlight(target, pos);

            // Ввод символа без энтера
            char cin_char;
            read(STDIN_FILENO, &cin_char, 1);

            // Проверяем время после ввода символа
            if (!is_still_ongoing(start_time, symbol_start_time, limit_on_symbol, limit_for_test)) {
                break;
            }

            if (cin_char == target[pos]) {
                symbol_start_time = steady_clock::now();
                pos++;
                score++;
            } else {
                decrease_score += difficulty;
            }

            clear_terminal();
        }

        if (duration_cast<seconds>(steady_clock::now() - symbol_start_time).count() > limit_on_symbol) {
            break;
        }

        target_index++;
    }

    if (score - decrease_score < 50) {
        #ifdef _WIN32
            cout << "Test failed" << endl;
            cout << "Number of incorrectly entered characters: " << decrease_score / difficulty << endl;
        #else
            cout << "Тест провален" << endl;
            cout << "Количество неверно введенных символов: " << decrease_score / difficulty << endl;
        #endif
    }
    else {
        #ifdef _WIN32
            cout << "Test pass" << endl;
        #else
            cout << "Тест пройден" << endl;
        #endif
    }

    #ifdef _WIN32
        cout << "Your score: " << score - decrease_score << endl;
    #else
        cout << "Ваш счёт: " << score - decrease_score << endl;
    #endif
}

int main() {

    setlocale(LC_ALL, "Russian");
    setlocale(LC_CTYPE, "Russian");

    clear_terminal();

    #ifdef _WIN32
        cout << "Welcome to the keyboard trainer!" << endl << endl;

        cout << "Select difficulty level:" << endl;
        cout << "1 - Easy (3 seconds per character, points deduction for incorrect input - 1, number of seconds for test - 40, number of points required - 60)" << endl;
        cout << "2 - Average (2 seconds per character, points deduction for incorrect input - 2, number of seconds for test - 30, number of points required - 80)" << endl;
        cout << "3 - Complex (1 second per character, points deduction for incorrect input - 3, number of seconds for test - 25, number of points required - 100)" << endl;
    #else
        cout << "Добро пожаловать в клавиатурный тренажер!" << endl << endl;

        cout << "Выберите уровень сложности:\n";
        cout << "1 - Легкий (3 секунды на один символ, списание очков за ошибочный ввод - 1, количество секунд на тест - 40, количество необходимых очков - 60)" << endl;
        cout << "2 - Средний (2 секунды на один символ, списание очков за ошибочный ввод - 2, количество секунд на тест - 30, количество необходимых очков - 80)" << endl;
        cout << "3 - Сложный (1 секунды на один символ, списание очков за ошибочный ввод - 3, количество секунд на тест - 25, количество необходимых очков - 100)" << endl;
    #endif

    int difficulty = 1;
    cin >> difficulty;

    if (difficulty < 1 || difficulty > 3) {
        difficulty = 3;
    }

    clear_terminal();

    set_input_mode(true);
    typing_test(get_test_data(), difficulty);
    set_input_mode(false);

    return 0;
}

