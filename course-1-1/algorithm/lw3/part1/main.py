import re


def main():
    string = input('Введите строку: ')
    string_without_numbers = "".join(re.findall(r"[a-zA-Z]+", string))
    string_with_only_numbers = "".join(re.findall(r"\d+", string))

    print(f"Строка без чисел: {string_without_numbers}")
    print(f"Строка чисел: {string_with_only_numbers}")

    string_with_ord_numbers = ""
    for char in string_with_only_numbers:
        string_with_ord_numbers = string_with_ord_numbers + str(ord(char))

    print(f"Строка ASCII чисел: {string_with_ord_numbers}")


if __name__ == '__main__':
    main()

