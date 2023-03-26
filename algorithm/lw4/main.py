def main():
    array_length = int(input("Введите кол-во элементов в массиве: "))
    x = []
    for i in range(array_length):
        x.append(int(input("Введите число: ")))

    # x = [5, 8, 2, 3, 6, 3, 4, 10, 6, 9]

    min_value = min(x)
    max_value = max(x)

    min_value_index = x.index(min_value)
    max_value_index = x.index(max_value)

    min_index = max_value_index if min_value_index > max_value_index else min_value_index
    max_index = min_value_index if min_value_index > max_value_index else max_value_index

    values_before_min_value = sorted(x[0:min_index], reverse=True)
    values_after_max_value = sorted(x[max_index + 1:len(x)], reverse=True)

    sorted_result = values_before_min_value + x[min_index:max_index + 1] + values_after_max_value

    print(" ".join(str(value) for value in sorted_result))


if __name__ == '__main__':
    main()

