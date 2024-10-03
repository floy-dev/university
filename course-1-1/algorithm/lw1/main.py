import math


def main():
    x = 15 * (math.pi / 180)
    y = 0.5
    z = 1.95

    cos = math.cos(math.tan(x ** 2) - math.sin(z))

    a = 1 - math.sqrt(cos / (y + cos))

    print(a)


if __name__ == '__main__':
    main()

