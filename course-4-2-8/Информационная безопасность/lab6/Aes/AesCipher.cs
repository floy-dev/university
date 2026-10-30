namespace Lab6;

public static class AesCipher
{
    public const int BlockSize = 16;
    public const int KeySize = 16;

    private const int RoundCount = 10;
    private const int ExpandedKeySize = BlockSize * (RoundCount + 1);

    private static readonly byte[] substitutionTable = new byte[256];
    private static readonly byte[] inverseSubstitutionTable = new byte[256];

    static AesCipher()
    {
        BuildSubstitutionTables();
    }

    public static byte[] EncryptBlock(byte[] block, byte[] key)
    {
        CheckBlockAndKey(block, key);
        return EncryptBlockWithRoundKeys(block, ExpandKey(key));
    }

    public static byte[] DecryptBlock(byte[] block, byte[] key)
    {
        CheckBlockAndKey(block, key);
        return DecryptBlockWithRoundKeys(block, ExpandKey(key));
    }

    internal static byte[] ExpandKey(byte[] key)
    {
        if (key.Length != KeySize)
        {
            throw new ArgumentException("Ключ AES-128 должен содержать ровно 16 байтов");
        }

        byte[] roundKeys = new byte[ExpandedKeySize];
        Array.Copy(key, roundKeys, KeySize);

        int writtenBytes = KeySize;
        byte roundConstant = 1;
        byte[] previousWord = new byte[4];

        while (writtenBytes < roundKeys.Length)
        {
            Array.Copy(roundKeys, writtenBytes - 4, previousWord, 0, 4);

            if (writtenBytes % KeySize == 0)
            {
                RotateWord(previousWord);
                SubstituteWord(previousWord);
                previousWord[0] ^= roundConstant;
                roundConstant = Multiply(roundConstant, 2);
            }

            for (int byteIndex = 0; byteIndex < 4; byteIndex++)
            {
                roundKeys[writtenBytes] =
                    (byte)(roundKeys[writtenBytes - KeySize] ^ previousWord[byteIndex]);
                writtenBytes++;
            }
        }

        return roundKeys;
    }

    internal static byte[] EncryptBlockWithRoundKeys(byte[] block, byte[] roundKeys)
    {
        CheckBlock(block);
        byte[] state = (byte[])block.Clone();

        AddRoundKey(state, roundKeys, 0);

        for (int round = 1; round < RoundCount; round++)
        {
            SubBytes(state);
            ShiftRows(state);
            MixColumns(state);
            AddRoundKey(state, roundKeys, round);
        }

        SubBytes(state);
        ShiftRows(state);
        AddRoundKey(state, roundKeys, RoundCount);

        return state;
    }

    private static byte[] DecryptBlockWithRoundKeys(byte[] block, byte[] roundKeys)
    {
        CheckBlock(block);
        byte[] state = (byte[])block.Clone();

        AddRoundKey(state, roundKeys, RoundCount);

        for (int round = RoundCount - 1; round > 0; round--)
        {
            InvShiftRows(state);
            InvSubBytes(state);
            AddRoundKey(state, roundKeys, round);
            InvMixColumns(state);
        }

        InvShiftRows(state);
        InvSubBytes(state);
        AddRoundKey(state, roundKeys, 0);

        return state;
    }

    private static void AddRoundKey(byte[] state, byte[] roundKeys, int round)
    {
        int roundStart = round * BlockSize;

        for (int byteIndex = 0; byteIndex < BlockSize; byteIndex++)
        {
            state[byteIndex] ^= roundKeys[roundStart + byteIndex];
        }
    }

    private static void SubBytes(byte[] state)
    {
        for (int byteIndex = 0; byteIndex < BlockSize; byteIndex++)
        {
            state[byteIndex] = substitutionTable[state[byteIndex]];
        }
    }

    private static void InvSubBytes(byte[] state)
    {
        for (int byteIndex = 0; byteIndex < BlockSize; byteIndex++)
        {
            state[byteIndex] = inverseSubstitutionTable[state[byteIndex]];
        }
    }

    private static void ShiftRows(byte[] state)
    {
        byte[] previousState = (byte[])state.Clone();

        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                int sourceColumn = (column + row) % 4;
                state[4 * column + row] = previousState[4 * sourceColumn + row];
            }
        }
    }

    private static void InvShiftRows(byte[] state)
    {
        byte[] previousState = (byte[])state.Clone();

        for (int row = 0; row < 4; row++)
        {
            for (int column = 0; column < 4; column++)
            {
                int sourceColumn = (column - row + 4) % 4;
                state[4 * column + row] = previousState[4 * sourceColumn + row];
            }
        }
    }

    private static void MixColumns(byte[] state)
    {
        byte[] previousState = (byte[])state.Clone();

        for (int column = 0; column < 4; column++)
        {
            int start = column * 4;
            byte first = previousState[start];
            byte second = previousState[start + 1];
            byte third = previousState[start + 2];
            byte fourth = previousState[start + 3];

            state[start] = (byte)(Multiply(first, 2) ^ Multiply(second, 3) ^ third ^ fourth);
            state[start + 1] = (byte)(first ^ Multiply(second, 2) ^ Multiply(third, 3) ^ fourth);
            state[start + 2] = (byte)(first ^ second ^ Multiply(third, 2) ^ Multiply(fourth, 3));
            state[start + 3] = (byte)(Multiply(first, 3) ^ second ^ third ^ Multiply(fourth, 2));
        }
    }

    private static void InvMixColumns(byte[] state)
    {
        byte[] previousState = (byte[])state.Clone();

        for (int column = 0; column < 4; column++)
        {
            int start = column * 4;
            byte first = previousState[start];
            byte second = previousState[start + 1];
            byte third = previousState[start + 2];
            byte fourth = previousState[start + 3];

            state[start] = (byte)(Multiply(first, 14) ^ Multiply(second, 11) ^ Multiply(third, 13) ^ Multiply(fourth, 9));
            state[start + 1] = (byte)(Multiply(first, 9) ^ Multiply(second, 14) ^ Multiply(third, 11) ^ Multiply(fourth, 13));
            state[start + 2] = (byte)(Multiply(first, 13) ^ Multiply(second, 9) ^ Multiply(third, 14) ^ Multiply(fourth, 11));
            state[start + 3] = (byte)(Multiply(first, 11) ^ Multiply(second, 13) ^ Multiply(third, 9) ^ Multiply(fourth, 14));
        }
    }

    private static void BuildSubstitutionTables()
    {
        for (int value = 0; value < 256; value++)
        {
            byte inverse = FindMultiplicativeInverse((byte)value);
            int inverseValue = inverse;
            int substitutedValue = inverseValue
                                   ^ RotateLeft(inverseValue, 1)
                                   ^ RotateLeft(inverseValue, 2)
                                   ^ RotateLeft(inverseValue, 3)
                                   ^ RotateLeft(inverseValue, 4)
                                   ^ 0x63;

            substitutionTable[value] = (byte)substitutedValue;
            inverseSubstitutionTable[substitutionTable[value]] = (byte)value;
        }
    }

    private static byte FindMultiplicativeInverse(byte value)
    {
        if (value == 0)
        {
            return 0;
        }

        for (int candidate = 1; candidate < 256; candidate++)
        {
            if (Multiply(value, (byte)candidate) == 1)
            {
                return (byte)candidate;
            }
        }

        throw new InvalidOperationException("Не удалось построить таблицу замен AES");
    }

    private static int RotateLeft(int value, int shiftCount)
    {
        return ((value << shiftCount) | (value >> (8 - shiftCount))) & 0xFF;
    }

    private static byte Multiply(byte leftFactor, byte rightFactor)
    {
        int result = 0;
        int multiplicand = leftFactor;
        int multiplier = rightFactor;

        while (multiplier != 0)
        {
            if ((multiplier & 1) != 0)
            {
                result ^= multiplicand;
            }

            multiplicand <<= 1;

            if ((multiplicand & 0x100) != 0)
            {
                multiplicand ^= 0x11B;
            }

            multiplier >>= 1;
        }

        return (byte)result;
    }

    private static void RotateWord(byte[] word)
    {
        byte firstByte = word[0];
        word[0] = word[1];
        word[1] = word[2];
        word[2] = word[3];
        word[3] = firstByte;
    }

    private static void SubstituteWord(byte[] word)
    {
        for (int byteIndex = 0; byteIndex < word.Length; byteIndex++)
        {
            word[byteIndex] = substitutionTable[word[byteIndex]];
        }
    }

    private static void CheckBlockAndKey(byte[] block, byte[] key)
    {
        CheckBlock(block);

        if (key.Length != KeySize)
        {
            throw new ArgumentException("Ключ AES-128 должен содержать ровно 16 байтов");
        }
    }

    private static void CheckBlock(byte[] block)
    {
        if (block.Length != BlockSize)
        {
            throw new ArgumentException("Блок AES должен содержать ровно 16 байтов");
        }
    }
}
