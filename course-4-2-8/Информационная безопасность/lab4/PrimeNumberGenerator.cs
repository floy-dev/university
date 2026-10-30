using System.Numerics;

namespace Lab4;

public static class PrimeNumberGenerator
{
    private static readonly int[] SmallPrimeNumbers =
    {
        3,
        5,
        7,
        11,
        13,
        17,
        19,
        23,
        29,
        31,
        37,
        41,
        43,
        47
    };

    public static BigInteger Generate(int bitCount, int iterations)
    {
        if (bitCount < 2 || bitCount > 2048)
        {
            throw new ArgumentException("Разрядность должна быть от 2 до 2048 бит.");
        }

        if (iterations < 1 || iterations > 1000)
        {
            throw new ArgumentException("Количество итераций должно быть от 1 до 1000.");
        }

        while (true)
        {
            BigInteger candidateNumber = RandomNumberHelper.GenerateOddNumber(bitCount);

            if (IsDivisibleBySmallPrime(candidateNumber))
            {
                continue;
            }

            if (MillerRabinTest.IsProbablyPrime(candidateNumber, iterations))
            {
                return candidateNumber;
            }
        }
    }

    private static bool IsDivisibleBySmallPrime(BigInteger number)
    {
        foreach (int smallPrime in SmallPrimeNumbers)
        {
            if (number != smallPrime && number % smallPrime == 0)
            {
                return true;
            }
        }

        return false;
    }
}
