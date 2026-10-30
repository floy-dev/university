using System.Numerics;

namespace Lab6;

public static class MillerRabinTest
{
    public static bool IsProbablyPrime(BigInteger number, int iterations)
    {
        if (iterations < 1)
        {
            throw new ArgumentException("Количество итераций должно быть положительным");
        }

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

        BigInteger oddPart = number - 1;
        int powerOfTwo = 0;

        while (oddPart.IsEven)
        {
            oddPart /= 2;
            powerOfTwo++;
        }

        for (int iteration = 0; iteration < iterations; iteration++)
        {
            BigInteger randomBase = 2 + RandomNumberHelper.RandomBelow(number - 3);
            BigInteger result = BigInteger.ModPow(randomBase, oddPart, number);

            if (result == 1 || result == number - 1)
            {
                continue;
            }

            bool roundPassed = false;

            for (int squaring = 1; squaring < powerOfTwo; squaring++)
            {
                result = result * result % number;

                if (result == number - 1)
                {
                    roundPassed = true;
                    break;
                }

                if (result == 1)
                {
                    return false;
                }
            }

            if (!roundPassed)
            {
                return false;
            }
        }

        return true;
    }
}
