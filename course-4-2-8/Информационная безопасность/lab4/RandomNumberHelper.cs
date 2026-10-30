using System.Numerics;
using System.Security.Cryptography;

namespace Lab4;

public static class RandomNumberHelper
{
    public static BigInteger RandomBelow(BigInteger upperLimit)
    {
        if (upperLimit <= 0)
        {
            throw new ArgumentException("Верхняя граница должна быть положительной.");
        }

        byte[] bytes = upperLimit.ToByteArray(isUnsigned: true, isBigEndian: true);
        int significantBitCount = 0;
        byte firstByte = bytes[0];

        while (firstByte > 0)
        {
            significantBitCount++;
            firstByte >>= 1;
        }

        byte firstByteMask = significantBitCount == 8
            ? byte.MaxValue
            : (byte)((1 << significantBitCount) - 1);

        BigInteger randomNumber;

        do
        {
            RandomNumberGenerator.Fill(bytes);
            bytes[0] &= firstByteMask;
            randomNumber = new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
        }
        while (randomNumber >= upperLimit);

        return randomNumber;
    }

    public static BigInteger GenerateOddNumber(int bitCount)
    {
        int byteCount = (bitCount + 7) / 8;
        int unusedBitCount = byteCount * 8 - bitCount;
        byte[] bytes = new byte[byteCount];

        RandomNumberGenerator.Fill(bytes);
        bytes[0] &= (byte)(byte.MaxValue >> unusedBitCount);
        bytes[0] |= (byte)(1 << (7 - unusedBitCount));
        bytes[^1] |= 1;

        return new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
    }
}
