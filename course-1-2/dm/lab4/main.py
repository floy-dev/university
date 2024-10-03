import math


def get_placements_count(input_data_count, place_count, is_with_repeat):
    if is_with_repeat:
        return input_data_count ** place_count

    return math.factorial(input_data_count) / math.factorial(input_data_count - place_count)


def get_all_subsets(input_data):
    subsets = [
        []
    ]
    for input_element in input_data:
        for index in range(len(subsets)):
            subset_element_copy = subsets[index].copy()

            subset_element_copy.append(input_element)

            subsets.append(subset_element_copy)

    return subsets


def get_placements_values(input_data, combination_count, is_with_repeat):

    def insert_value_to_variant(position, element):

        if len(variant) > position >= 0:
            variant[position] = element
            return

        variant.insert(position, element)

    def add_variant_to_placement():

        variant_copy = variant.copy()
        variant_tuple = tuple(variant_copy)

        if variant_tuple not in placements:
            placements.append(variant_tuple)

    def combine_values_without_repeats(input_data, position=0):

        for input_element in input_data:

            insert_value_to_variant(position, input_element)

            if position == combination_count:
                add_variant_to_placement()
                continue

            new_list_data = []
            for element in input_data:
                if element != input_element:
                    new_list_data.append(element)

            combine_values_without_repeats(new_list_data, position + 1)

    def combine_values_with_repeats(position=0):

        for input_element in input_data:

            insert_value_to_variant(position, input_element)

            if position == combination_count:
                add_variant_to_placement()
                continue

            combine_values_with_repeats(position + 1)

    placements = []
    variant = []

    combination_count -= 1

    if is_with_repeat:
        combine_values_with_repeats()
    else:
        combine_values_without_repeats(input_data)

    return placements


input_data = input("Введите n элементов, пример: [1 2 3]: ").split(' ')
input_data_count = len(input_data)
place_count = int(input("Введите длину размещений: "))
is_with_repeat = int(input("Включить повторения? Введите 1 или 0: ")) == 1

is_with_repeat_text = " без повторений"
if is_with_repeat:
    is_with_repeat_text = " с повторениями"

print("Количество размещений из" + str(input_data_count) + " по " + str(place_count) + is_with_repeat_text + ": " +
      str(get_placements_count(input_data_count, place_count, is_with_repeat))
      )

print("Размещения:", get_placements_values(input_data, place_count, is_with_repeat))
print("Количество подмножеств:", input_data_count ** 2, ", значения:", get_all_subsets(input_data))
