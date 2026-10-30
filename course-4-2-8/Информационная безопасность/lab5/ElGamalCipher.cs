using System.Numerics;

namespace Lab5;

internal static class ElGamalCipher
{
    public static BigInteger CalculatePublicKey(
        BigInteger modulus,
        BigInteger primitiveRoot,
        BigInteger secret)
    {
        return BigInteger.ModPow(primitiveRoot, secret, modulus);
    }

    public static (BigInteger FirstComponent, BigInteger SecondComponent) Encrypt
    (
        BigInteger message,
        BigInteger modulus,
        BigInteger primitiveRoot,
        BigInteger publicKey,
        BigInteger sessionKey)
    {
        if (message < 0 || message >= modulus)
        {
            throw new ArgumentException("Сообщение M должно удовлетворять условию 0 <= M < n.");
        }

        ValidateExponent(sessionKey, modulus, "k");

        BigInteger firstComponent = BigInteger.ModPow(primitiveRoot, sessionKey, modulus);
        BigInteger secondComponent = BigInteger.ModPow(publicKey, sessionKey, modulus) * message % modulus;

        return (firstComponent, secondComponent);
    }

    public static BigInteger Decrypt(
        BigInteger firstComponent,
        BigInteger secondComponent,
        BigInteger modulus,
        BigInteger secret)
    {
        ValidateExponent(secret, modulus, "s");

        if (firstComponent <= 0 || firstComponent >= modulus)
        {
            throw new ArgumentException("Компонент u должен находиться в диапазоне от 1 до n - 1.");
        }
        if (secondComponent < 0 || secondComponent >= modulus)
        {
            throw new ArgumentException("Компонент v должен находиться в диапазоне от 0 до n - 1.");
        }

        BigInteger sharedMultiplier = BigInteger.ModPow(firstComponent, secret, modulus);
        BigInteger inverseMultiplier = ModularArithmetic.FindInverse(sharedMultiplier, modulus);
        return inverseMultiplier * secondComponent % modulus;
    }

    private static void ValidateExponent(BigInteger exponent, BigInteger modulus, string name)
    {
        if (exponent <= 1 || exponent >= modulus - 1)
        {
            throw new ArgumentException($"Показатель {name} должен удовлетворять условию 1 < {name} < n - 1.");
        }
    }
}
