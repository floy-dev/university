using System.Numerics;

namespace Lab4;

public static class RandomGcdTest
{
    public static bool IsProbablyPrime(BigInteger number, int iterations)
    {
        ValidateIterations(iterations);

        if (number < 2)
        {
            return false;
        }

        if (number == 2 || number == 3)
        {
            return true;
        }

        if (number.IsEven)
        {
            return false;
        }

        for (int iteration = 0; iteration < iterations; iteration++)
        {
            BigInteger randomDivisor = 2 + RandomNumberHelper.RandomBelow(number - 2);

            if (BigInteger.GreatestCommonDivisor(randomDivisor, number) != 1)
            {
                return false;
            }
        }

        return true;
    }

    private static void ValidateIterations(int iterations)
    {
        if (iterations < 1 || iterations > 1000)
        {
            throw new ArgumentException("Количество итераций должно быть от 1 до 1000.");
        }
    }
}
