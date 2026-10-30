using System.Numerics;

namespace Lab5;

internal static class ModularArithmetic
{
    public static BigInteger FindInverse(BigInteger number, BigInteger modulus)
    {
        if (modulus <= 1)
        {
            throw new ArgumentException("Модуль должен быть больше 1.");
        }

        BigInteger previousRemainder = modulus;
        BigInteger currentRemainder = Normalize(number, modulus);
        BigInteger previousCoefficient = 0;
        BigInteger currentCoefficient = 1;

        while (currentRemainder != 0)
        {
            BigInteger quotient = previousRemainder / currentRemainder;

            (previousRemainder, currentRemainder) =
                (currentRemainder, previousRemainder - quotient * currentRemainder);
            (previousCoefficient, currentCoefficient) =
                (currentCoefficient, previousCoefficient - quotient * currentCoefficient);
        }

        if (previousRemainder != 1)
        {
            throw new ArgumentException("Обратный элемент не существует.");
        }

        return Normalize(previousCoefficient, modulus);
    }

    private static BigInteger Normalize(BigInteger number, BigInteger modulus)
    {
        return (number % modulus + modulus) % modulus;
    }
}
