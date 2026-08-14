import random


def main():
    floats = []

    for i in range(10):
        floats.append(round(random.uniform(1, 100), 2))

    print(f"Изначальные числа: {floats}")

    first_element = floats[0]
    result = [first_element]
    del floats[0]

    for value in floats:
        if value > first_element:
            result.insert(0, value)
            continue
        result.append(value)

    print(f"Отсортированные числа: {result}")


if __name__ == '__main__':
    main()
