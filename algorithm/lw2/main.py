def main():

    numbers = []
    i = 1

    print('Введите числа, 0 означает конец ввода')
    while True:
        number = int(input(f'Число #{i}: '))
        numbers.append(number)
        i = i + 1
        if number == 0:
            break

    result = []

    for j in range(len(numbers)):
        number = numbers[j]
        if number < 0 < j:
            result.append(str(numbers[j - 1]))

    if len(result) > 0:
        print('Все числа, идущие перед отрицательными числами:')
        print(", ".join(result))
    else:
        print('Нет отрицательных чисел')


if __name__ == '__main__':
    main()

