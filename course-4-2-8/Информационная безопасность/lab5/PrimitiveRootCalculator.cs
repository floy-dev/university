using System.Numerics;

namespace Lab5;

internal static class PrimitiveRootCalculator
{
    public static bool CanHaveRoots(BigInteger modulus)
    {
        if (modulus == 2 || modulus == 4)
        {
            return true;
        }

        if (modulus < 2)
        {
            return false;
        }

        BigInteger oddPart = modulus;

        if (oddPart.IsEven)
        {
            oddPart /= 2;
        }

        if (oddPart.IsEven || oddPart == 1)
        {
            return false;
        }

        BigInteger primeDivisor = FindSmallestPrimeDivisor(oddPart);

        while (oddPart % primeDivisor == 0)
        {
            oddPart /= primeDivisor;
        }

        return oddPart == 1;
    }

    public static List<BigInteger> FindFirst(BigInteger modulus, int count)
    {
        var roots = new List<BigInteger>();

        if (!CanHaveRoots(modulus))
        {
            return roots;
        }

        if (modulus == 2)
        {
            roots.Add(1);
            return roots;
        }

        if (modulus == 4)
        {
            roots.Add(3);
            return roots;
        }

        BigInteger totient = CalculateEiler(modulus);
        List<BigInteger> totientPrimeFactors = FindDistinctPrimeFactors(totient);

        for (BigInteger candidate = 2; candidate < modulus && roots.Count < count; candidate++)
        {
            if (IsPrimitiveRoot(candidate, modulus, totient, totientPrimeFactors))
            {
                roots.Add(candidate);
            }
        }

        return roots;
    }

    public static BigInteger FindForSafePrime(BigInteger modulus)
    {
        BigInteger primeDivisor = (modulus - 1) / 2;

        for (BigInteger candidate = 2; candidate < modulus; candidate++)
        {
            if (BigInteger.ModPow(candidate, 2, modulus) != 1 &&
                BigInteger.ModPow(candidate, primeDivisor, modulus) != 1)
            {
                return candidate;
            }
        }

        throw new ArgumentException("Не удалось найти первообразный корень.");
    }

    private static bool IsPrimitiveRoot(
        BigInteger candidate,
        BigInteger modulus,
        BigInteger totient,
        List<BigInteger> totientPrimeFactors)
    {
        if (candidate < 1 || candidate >= modulus)
        {
            return false;
        }

        if (BigInteger.GreatestCommonDivisor(candidate, modulus) != 1)
        {
            return false;
        }

        foreach (BigInteger primeFactor in totientPrimeFactors)
        {
            if (BigInteger.ModPow(candidate, totient / primeFactor, modulus) == 1)
            {
                return false;
            }
        }

        return true;
    }

    private static BigInteger CalculateEiler(BigInteger number)
    {
        BigInteger result = number;

        foreach (BigInteger primeFactor in FindDistinctPrimeFactors(number))
        {
            result = result / primeFactor * (primeFactor - 1);
        }

        return result;
    }

    private static List<BigInteger> FindDistinctPrimeFactors(BigInteger number)
    {
        var factors = new List<BigInteger>();

        for (BigInteger divisor = 2; divisor * divisor <= number; divisor = divisor == 2 ? 3 : divisor + 2)
        {
            if (number % divisor != 0)
            {
                continue;
            }

            factors.Add(divisor);

            while (number % divisor == 0)
            {
                number /= divisor;
            }
        }

        if (number > 1)
        {
            factors.Add(number);
        }

        return factors;
    }

    private static BigInteger FindSmallestPrimeDivisor(BigInteger number)
    {
        for (BigInteger divisor = 3; divisor * divisor <= number; divisor += 2)
        {
            if (number % divisor == 0)
            {
                return divisor;
            }
        }

        return number;
    }
}
