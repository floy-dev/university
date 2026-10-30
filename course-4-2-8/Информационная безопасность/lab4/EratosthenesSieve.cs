namespace Lab4;

public static class EratosthenesSieve
{
    public const int MaximumNumber = 10_000_000;

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        bool[] compositeNumbers = new bool[number + 1];

        for (int divisor = 2; (long)divisor * divisor <= number; divisor++)
        {
            if (compositeNumbers[divisor])
            {
                continue;
            }

            for (int multiple = divisor * divisor; multiple <= number; multiple += divisor)
            {
                compositeNumbers[multiple] = true;
            }
        }

        return !compositeNumbers[number];
    }
}
