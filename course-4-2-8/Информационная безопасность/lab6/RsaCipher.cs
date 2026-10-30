using System.Numerics;

namespace Lab6;

public static class RsaCipher
{
    public static (BigInteger Modulus, BigInteger PrivateExponent) CreateKeys(
        BigInteger firstPrime,
        BigInteger secondPrime,
        BigInteger publicExponent)
    {
        if (!MillerRabinTest.IsProbablyPrime(firstPrime, 16)
            || !MillerRabinTest.IsProbablyPrime(secondPrime, 16))
        {
            throw new ArgumentException("Числа p и q должны быть простыми");
        }

        BigInteger totient = (firstPrime - 1) * (secondPrime - 1);

        if (publicExponent <= 1 || publicExponent >= totient)
        {
            throw new ArgumentException("Открытая экспонента e должна находиться между 1 и f(n)");
        }

        if (BigInteger.GreatestCommonDivisor(publicExponent, totient) != 1)
        {
            throw new ArgumentException("Открытая экспонента e должна быть взаимно простой с f(n)");
        }

        BigInteger modulus = firstPrime * secondPrime;
        BigInteger privateExponent = ModularArithmetic.FindInverse(publicExponent, totient);

        return (modulus, privateExponent);
    }

    public static BigInteger Encrypt(BigInteger message, BigInteger publicExponent, BigInteger modulus)
    {
        return BigInteger.ModPow(message, publicExponent, modulus);
    }

    public static BigInteger Decrypt(BigInteger encryptedMessage, BigInteger privateExponent, BigInteger modulus)
    {
        return BigInteger.ModPow(encryptedMessage, privateExponent, modulus);
    }

    public static BigInteger EncryptAesKey(byte[] aesKey, BigInteger publicExponent, BigInteger modulus)
    {
        BigInteger keyNumber = new BigInteger(aesKey, isUnsigned: true, isBigEndian: true);

        return Encrypt(keyNumber, publicExponent, modulus);
    }

    public static byte[] DecryptAesKey(
        BigInteger encryptedKey,
        BigInteger privateExponent,
        BigInteger modulus)
    {
        BigInteger keyNumber = Decrypt(encryptedKey, privateExponent, modulus);
        byte[] keyBytes = keyNumber.ToByteArray(isUnsigned: true, isBigEndian: true);

        byte[] aesKey = new byte[AesCipher.KeySize];
        Array.Copy(keyBytes, 0, aesKey, aesKey.Length - keyBytes.Length, keyBytes.Length);
        return aesKey;
    }
}
