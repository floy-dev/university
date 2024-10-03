import math


def permutation_count(element_count, repeat_data):
    repeat_count = math.factorial(element_count)
    if repeat_data:
        total_repeat_number = 1
        for repeat_number in repeat_data:
            total_repeat_number *= math.factorial(repeat_number)

        return int(repeat_count / total_repeat_number)

    return repeat_count


def find_all_permutations(input_data):
    all_permutations = []

    input_data_count = len(input_data) - 1
    variant = []

    def find_new_permutations(data, position = 0):

        for element in data:
            if 0 <= position < len(variant):
                variant[position] = element
            else:
                variant.insert(position, element)

            if position == input_data_count:
                new_variant = tuple(variant.copy())
                if new_variant not in all_permutations:
                    all_permutations.append(new_variant)

                continue

            data_copy = data.copy()
            del data_copy[data.index(element)]
            find_new_permutations(data_copy, position + 1)

    find_new_permutations(input_data)

    return all_permutations


input_data = input("Введите n элементов, пример: [1 2 3]: ").split(' ')

repeat_dictionary = {}
for element in input_data:
    if element not in repeat_dictionary:
        repeat_dictionary[element] = 0
    repeat_dictionary[element] += 1

repeat_data = []
for element in repeat_dictionary:
    if repeat_dictionary[element] > 1:
        repeat_data.append(repeat_dictionary[element])

print("Общее количество перестановок: ", permutation_count(len(input_data), repeat_data))
print("Перестановки: ", find_all_permutations(input_data))