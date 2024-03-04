import math


def combinations_count(input_data_count, combination_count, is_with_repeat):
    if is_with_repeat == 0 and combination_count > input_data_count:
        return 0

    if is_with_repeat == 1:
        input_data_count += combination_count - 1

    return int(math.factorial(input_data_count) / (
            math.factorial(input_data_count - combination_count) * math.factorial(combination_count)
    ))


def get_combinations_values(input_data, combination_count, is_with_repeat):

    def insert_value_to_variant(position, index):

        if len(variant) > position >= 0:
            variant[position] = input_data[index]
            return

        variant.insert(position, input_data[index])

    def add_variant_to_combination():

        variant_copy = variant.copy()
        variant_tuple = tuple(variant_copy)

        if variant_tuple not in combinations:
            combinations.append(variant_tuple)

    def combine_values_without_repeats(index=0, position=0):

        for input_element in range(index, input_data_count - combination_count + position + 1):

            insert_value_to_variant(position, input_element)

            if position == combination_count:
                add_variant_to_combination()
                continue

            combine_values_without_repeats(input_element + 1, position + 1)

    def combine_values_with_repeats(index=0, position=0):

        for input_element in range(index, input_data_count + 1):

            insert_value_to_variant(position, input_element)

            if position == combination_count:
                add_variant_to_combination()
                continue

            combine_values_without_repeats(input_element, position + 1)

    combinations = []
    variant = []

    combination_count -= 1
    input_data_count = len(input_data) - 1

    if is_with_repeat:
        combine_values_with_repeats()
    else:
        combine_values_without_repeats()

    return combinations


input_data = input("Введите n элементов, пример: [1 2 3]: ").split(' ')
combination_count = int(input("Введите длину сочетаний: "))
is_with_repeat = int(input("Включить повторения? Введите 1 или 0: ")) == 1

is_with_repeat_text = " без повторений"
if is_with_repeat:
    is_with_repeat_text = " с повторениями"

input_data_count = len(input_data)

print("Количество комбинаций (количество - " + str(input_data_count) + ") "
      + "по длине сочетаний " + str(combination_count) + is_with_repeat_text + ": "
      + str(combinations_count(input_data_count, combination_count, is_with_repeat))
)

print("Возможные комбинации:", get_combinations_values(input_data, combination_count, is_with_repeat))
