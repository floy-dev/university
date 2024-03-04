import math


def calc_y(x, d, R):
    """
    Получить y исходя из условий задачи
    :param x: int координата
    :param d: точка на x оси
    :param R: радиус окружности
    :return: Значение y
    """
    if (abs(x) > 0.0 and abs(x) < abs(d) - R):
        y = 0.0
    elif (abs(x) > abs(d) + R):
        y = 0.0
    else:
        y = math.sqrt(R ** 2 - (x - abs(d)) ** 2)

    return y


def get_float_input(text):
    """
    Назначение - Получить int значение исходя из ввода пользователя
    :param text: Текст, для подстановки в input
    :return: int значение
    """
    float_value = float(input(text))

    return float_value


x = get_float_input('Введите точку x: ')
d = get_float_input('Введите точку d: ')
R = get_float_input('Введите радиус окружности: ')

y = calc_y(x, d, R)

print(f"Y = {y}")
