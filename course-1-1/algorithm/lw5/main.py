def append_row_of_negative_values(matrix):
    """
    Назначение - Добавить количество отрицательных элементов в ряду
    Входые данные - матрица
    Возвращаемые данные - ничего, так как матрица изменяется по ссылке
    :param matrix матрица
    """
    for row in matrix:
        # Поиск отрицательных значений с помощью анонимной функции
        row_negative_values = len(list(filter(lambda item: item < 0, row)))
        # Добавление в ряд значение отрицательных чисел
        row.append(row_negative_values)


def get_array_of_negative_values_in_columns(matrix):
    """
    Назначение - Посчитать количество отрицательных элементов в столбцах и записать их в массив
    Входые данные - матрица
    Возвращаемые данные - количество отрицательных элементов в столбцах в виде массива
    :param matrix матрица
    :return array:
    """
    column_negative_values = []
    negative_values = 0
    i = 0

    # Проходим по матрице и ищем отрицательные числа
    for row in matrix:
        counter = 0
        j = 0
        for value in range(len(row)):
            if matrix[j][i] < 0:
                counter += 1
                negative_values += 1
            j += 1
        i += 1
        column_negative_values.append(counter)

    # Всего отрицательных чисел
    column_negative_values.append(negative_values)

    return column_negative_values


def get_matrix_filled_by_human(n, m):
    """
    Назначение - Заполнить и вывести матрицу по заданным параметрам n и m
    Входые данные - количества столбцов, количество строк
    Возвращаемые данные - матрица заполненная человеком
    :param n количества столбцов
    :param m количество строк
    :return array:
    """
    matrix = []
    for n_index in range(n):
        matrix.append([])
        for m_index in range(m):
            matrix[n_index].append(int(input(f'Введите число для позиции ({n_index + 1}:{m_index + 1}): ')))
    return matrix


n = int(input("Введите кол-во столбцов: "))
m = int(input("Введите кол-во строк: "))

# Матрица заполненная человеком
matrix = get_matrix_filled_by_human(n, m)

# Количество отрицательных элементов в столбцах
new_row_of_negative_values = get_array_of_negative_values_in_columns(matrix)
# Добавляем отрицательные числа в строки
append_row_of_negative_values(matrix)
# Добавляем отрицательные числа в столбцы
matrix.append(new_row_of_negative_values)

# вывод матрицы с помощью цикла
for row in matrix:
    print(" ".join(str(value) for value in row))
