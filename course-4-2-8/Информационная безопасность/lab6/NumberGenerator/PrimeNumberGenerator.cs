using System.Numerics;

namespace Lab6;

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
        if (bitCount < 4 || bitCount > 256)
        {
            throw new ArgumentException("Разрядность p и q должна быть от 4 до 256 бит");
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
