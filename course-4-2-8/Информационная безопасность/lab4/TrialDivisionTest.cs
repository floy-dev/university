using System.Numerics;

namespace Lab4;

public static class TrialDivisionTest
{
    public static bool IsPrime(BigInteger number)
    {
        if (number < 2)
        {
            return false;
        }

        if (number == 2)
        {
            return true;
        }

        if (number.IsEven)
        {
            return false;
        }

        for (BigInteger divisor = 3; divisor * divisor <= number; divisor += 2)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
