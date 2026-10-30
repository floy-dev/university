using System.Numerics;
using System.Security.Cryptography;

namespace Lab5;

internal static class RandomNumberHelper
{
    public static BigInteger RandomBelow(BigInteger upperBound)
    {
        if (upperBound <= 0)
        {
            throw new ArgumentException("Верхняя граница должна быть положительной.");
        }

        byte[] bytes = upperBound.ToByteArray(isUnsigned: true, isBigEndian: true);
        int unusedBitCount = bytes.Length * 8 - (int)upperBound.GetBitLength();
        byte firstByteMask = (byte)(255 >> unusedBitCount);
        BigInteger result;

        do
        {
            RandomNumberGenerator.Fill(bytes);
            bytes[0] &= firstByteMask;
            result = new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
        }
        while (result >= upperBound);

        return result;
    }

    public static BigInteger GenerateOddNumber(int bitCount)
    {
        if (bitCount < 2)
        {
            throw new ArgumentException("Разрядность должна быть не меньше 2 бит.");
        }

        int byteCount = (bitCount + 7) / 8;
        int unusedBitCount = byteCount * 8 - bitCount;
        byte[] bytes = new byte[byteCount];

        RandomNumberGenerator.Fill(bytes);
        bytes[0] &= (byte)(255 >> unusedBitCount);
        bytes[0] |= (byte)(1 << (7 - unusedBitCount));
        bytes[^1] |= 1;

        return new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
    }
}
