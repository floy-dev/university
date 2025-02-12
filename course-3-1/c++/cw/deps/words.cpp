#include <fstream>
#include <string>
#include <vector>
#include <filesystem>
#include <random>

#include "words.h"
#include "utils.h"

using namespace std;

const string LIBRARY_DIR_PATH = std::filesystem::absolute(__FILE__).parent_path().string() + "/../library";
const vector<string> LETTERS_DICTIONARY_EN = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

vector<string> generate_letters(const int length) {
    vector<string> result;
    vector<string> dictionary = shuffle_vector(LETTERS_DICTIONARY_EN);

    result.reserve(length);
    for (int i = 0; i < length; ++i) {
        result.push_back(dictionary[i]);
    }

    return result;
}

vector<string> generate_words(const int length) {
    ifstream input_file_stream(LIBRARY_DIR_PATH + "/words.en.dic");

    if (!input_file_stream.is_open()) {
        throw std::invalid_argument("Ошибка открытия словаря");
    }

    vector<string> words;

    while (!input_file_stream.eof()) {
        string word;
        input_file_stream >> word;

        if (!word.empty()) {
            words.push_back(word);
        }
    }

    words = shuffle_vector(words);
    words.resize(length);

    return words;
}

vector<string> generate_syllables(const int length) {
    ifstream input_file_stream(LIBRARY_DIR_PATH + "/syllables.en.dic");

    if (!input_file_stream.is_open()) {
        throw std::invalid_argument("Ошибка открытия словаря");
    }

    vector<vector<string>> words_syllables;
    vector<string> word_syllables;

    while (!input_file_stream.eof()) {
        string syllable;
        input_file_stream >> syllable;

        if (syllable != "-") {
            word_syllables.push_back(syllable);
        }
        else {
            words_syllables.push_back(word_syllables);
            word_syllables.clear();
        }
    }

    std::random_device rd;
    std::mt19937 g(rd());
    std::shuffle(words_syllables.begin(), words_syllables.end(), g);

    words_syllables.resize(length);

    vector<string> syllables;
    for (vector<string>& word_syllables : words_syllables) {
        for (string& syllable : word_syllables) {
            syllables.push_back(syllable);
        }
    }

    return syllables;
}
