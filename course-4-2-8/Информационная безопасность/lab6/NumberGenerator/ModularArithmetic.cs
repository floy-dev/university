using System.Numerics;

namespace Lab6;

public static class ModularArithmetic
{
    public static BigInteger FindInverse(BigInteger number, BigInteger modulus)
    {
        BigInteger previousRemainder = number;
        BigInteger currentRemainder = modulus;
        BigInteger previousCoefficient = 1;
        BigInteger currentCoefficient = 0;

        while (currentRemainder != 0)
        {
            BigInteger quotient = previousRemainder / currentRemainder;

            BigInteger nextRemainder = previousRemainder % currentRemainder;
            previousRemainder = currentRemainder;
            currentRemainder = nextRemainder;

            BigInteger nextCoefficient = previousCoefficient - quotient * currentCoefficient;
            previousCoefficient = currentCoefficient;
            currentCoefficient = nextCoefficient;
        }

        if (previousRemainder != 1)
        {
            throw new ArgumentException("Обратный элемент не существует");
        }

        return (previousCoefficient % modulus + modulus) % modulus;
    }
}
