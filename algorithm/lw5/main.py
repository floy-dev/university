def main():

    n = int(input("Введите кол-во столбцов: "))
    m = int(input("Введите кол-во строк: "))
    matrix = []

    for n_index in range(n):
        matrix.append([])
        for m_index in range(m):
            matrix[n_index].append(int(input(f'Введите число для позиции ({n_index + 1}:{m_index + 1}): ')))

    # matrix = [
    #     [1, 4, -1],
    #     [2, 6, -4],
    #     [1, -2, -6],
    # ]

    column_negative_values = []
    negative_values = 0
    i = 0

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

    for row in matrix:
        row_negative_values = len(list(filter(lambda item: item < 0, row)))
        row.append(row_negative_values)

    column_negative_values.append(negative_values)
    matrix.append(column_negative_values)

    for row in matrix:
        print(" ".join(str(value) for value in row))


if __name__ == '__main__':
    main()

