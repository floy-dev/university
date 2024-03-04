def get_array_with_human_values():
    """
    Назначение - получить массив, где значения заполняет пользователь
    Входые данные - ничего
    Возвращаемые данные - Массив со значениями пользователя
    :return array:
    """
    array_length = int(input("Введите кол-во элементов в массиве: "))
    array_values = []
    for i in range(array_length):
        array_values.append(int(input("Введите число: ")))

    return array_values


def find_min_element(array_to_search):
    """
    Назначение - найти минимальный элемент в массиве
    Входые данные - массив для поиска
    Возвращаемые данные - Минимальный элемент массива
    :return int:
    """
    min_element = array_to_search[0]
    for i in range(len(array_to_search)):
        if array_to_search[i] < min_element:
            min_element = array_to_search[i]
    return min_element


def find_max_element(array_to_search):
    """
    Назначение - найти максимальный элемент в массиве
    Входые данные - массив для поиска
    Возвращаемые данные - Максимальный элемент массива
    :return int:
    """
    max_element = array_to_search[0]
    for i in range(1, len(array_to_search)):
        if array_to_search[i] > max_element:
            max_element = array_to_search[i]
    return max_element


def get_actual_min_index(array, min_value, max_value):
    """
    Назначение - Получить индекс минимального элемента массива
    Входые данные - массив для сортировки, минимальное значение в массиве, максимальное значение в массиве
    Возвращаемые данные - индекс минимального элемента массива
    :return int:
    """
    min_value_index = array.index(min_value)
    max_value_index = array.index(max_value)
    return max_value_index if min_value_index > max_value_index else min_value_index


def get_actual_max_index(array, min_value, max_value):
    """
    Назначение - Получить индекс максимального элемента массива
    Входые данные - массив для сортировки, минимальное значение в массиве, максимальное значение в массиве
    Возвращаемые данные - индекс максимального элемента массива
    :return int:
    """
    min_value_index = array.index(min_value)
    max_value_index = array.index(max_value)
    return min_value_index if min_value_index > max_value_index else max_value_index


def sort_reverse_array(array_to_sort):
    """
    Назначение - Отсортировать элементы массива по убыванию
    Входые данные - массив для сортировки
    Возвращаемые данные - Отсортированный массив
    :return array:
    """
    return sorted(array_to_sort, reverse=True)


# Массив, где значения заполняет пользователь
human_array = get_array_with_human_values()

# Минимальный элемент в массиве
min_value = find_min_element(human_array)
# Максимальный элемент в массиве
max_value = find_max_element(human_array)

# Индекс минимального элемента в массиве
min_index = get_actual_min_index(human_array, min_value, max_value)
# Индекс максимального элемента в массиве
max_index = get_actual_max_index(human_array, min_value, max_value)

# Отсортированные итоговые значения
sorted_result = sort_reverse_array(human_array[0:min_index]) \
                + human_array[min_index:max_index + 1] \
                + sort_reverse_array(human_array[max_index + 1:len(human_array)])

# Вывод значений
print(" ".join(str(value) for value in sorted_result))
