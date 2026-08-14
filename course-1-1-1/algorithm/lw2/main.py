def main():
    i = 1
    number = None
    prev_value = None
    print('Введите числа, 0 означает конец ввода')
    while number != 0:
        number = int(input(f'Число #{i}: '))
        i += 1
        if number < 0 and prev_value is not None:
            print(f'Перед отрицательный числом {number} было число: {prev_value}')
        prev_value = number


if __name__ == '__main__':
    main()

