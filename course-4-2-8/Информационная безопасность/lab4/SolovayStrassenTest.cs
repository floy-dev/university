using System.Numerics;

namespace Lab4;

public static class SolovayStrassenTest
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
            BigInteger randomBase = 2 + RandomNumberHelper.RandomBelow(number - 3);

            if (BigInteger.GreatestCommonDivisor(randomBase, number) != 1)
            {
                return false;
            }

            int jacobiSymbol = CalculateJacobiSymbol(randomBase, number);
            BigInteger expectedResult = jacobiSymbol == -1 ? number - 1 : jacobiSymbol;
            BigInteger actualResult = BigInteger.ModPow(randomBase, (number - 1) / 2, number);

            if (actualResult != expectedResult)
            {
                return false;
            }
        }

        return true;
    }

    public static int CalculateJacobiSymbol(BigInteger numerator, BigInteger denominator)
    {
        if (denominator <= 0 || denominator.IsEven)
        {
            throw new ArgumentException("Знаменатель должен быть положительным нечётным числом.");
        }

        numerator = (numerator % denominator + denominator) % denominator;
        int result = 1;

        while (numerator != 0)
        {
            while (numerator.IsEven)
            {
                numerator /= 2;
                BigInteger remainder = denominator % 8;

                if (remainder == 3 || remainder == 5)
                {
                    result = -result;
                }
            }

            (numerator, denominator) = (denominator, numerator);

            if (numerator % 4 == 3 && denominator % 4 == 3)
            {
                result = -result;
            }

            numerator %= denominator;
        }

        return denominator == 1 ? result : 0;
    }

    private static void ValidateIterations(int iterations)
    {
        if (iterations < 1 || iterations > 1000)
        {
            throw new ArgumentException("Количество итераций должно быть от 1 до 1000.");
        }
    }
}
