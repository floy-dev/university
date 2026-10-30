using System.Numerics;

namespace Lab5;

internal static class DiffieHellmanProtocol
{
    public static BigInteger CalculatePublicValue(
        BigInteger modulus,
        BigInteger primitiveRoot,
        BigInteger secret)
    {
        return BigInteger.ModPow(primitiveRoot, secret, modulus);
    }

    public static BigInteger CalculateSharedKey(
        BigInteger modulus,
        BigInteger receivedPublicValue,
        BigInteger secret)
    {
        if (receivedPublicValue <= 0 || receivedPublicValue >= modulus)
        {
            throw new ArgumentException("Открытое значение должно находиться в диапазоне от 1 до n - 1.");
        }

        return BigInteger.ModPow(receivedPublicValue, secret, modulus);
    }
}
