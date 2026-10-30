using System.Numerics;

namespace Lab5;

internal static class PrimeNumberGenerator
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
        while (true)
        {
            BigInteger candidate = RandomNumberHelper.GenerateOddNumber(bitCount);

            if (IsDivisibleBySmallPrime(candidate))
            {
                continue;
            }

            if (MillerRabinTest.IsProbablyPrime(candidate, iterations))
            {
                return candidate;
            }
        }
    }

    public static BigInteger GenerateSafePrime(int bitCount, int iterations)
    {
        while (true)
        {
            BigInteger primeDivisor = Generate(bitCount - 1, iterations);
            BigInteger safePrime = 2 * primeDivisor + 1;

            if (MillerRabinTest.IsProbablyPrime(safePrime, iterations))
            {
                return safePrime;
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
