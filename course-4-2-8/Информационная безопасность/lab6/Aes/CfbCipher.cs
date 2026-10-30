namespace Lab6;

public static class CfbCipher
{
    public static byte[] Encrypt(byte[] data, byte[] key, byte[] initializationVector)
    {
        CheckInitializationVector(initializationVector);

        byte[] paddedData = Iso7816Padding.Add(data);
        byte[] roundKeys = AesCipher.ExpandKey(key);
        return TransformBlocks(paddedData, roundKeys, initializationVector, false);
    }

    public static byte[] Decrypt(byte[] encryptedData, byte[] key, byte[] initializationVector)
    {
        CheckInitializationVector(initializationVector);

        if (encryptedData.Length == 0 || encryptedData.Length % AesCipher.BlockSize != 0)
        {
            throw new ArgumentException("Шифротекст должен состоять из целого числа блоков по 16 байтов");
        }

        byte[] roundKeys = AesCipher.ExpandKey(key);
        byte[] paddedData = TransformBlocks(encryptedData, roundKeys, initializationVector, true);
        return Iso7816Padding.Remove(paddedData);
    }

    private static byte[] TransformBlocks(
        byte[] data,
        byte[] roundKeys,
        byte[] initializationVector,
        bool decrypt)
    {
        byte[] result = new byte[data.Length];
        byte[] feedback = (byte[])initializationVector.Clone();

        for (int offset = 0; offset < data.Length; offset += AesCipher.BlockSize)
        {
            byte[] gamma = AesCipher.EncryptBlockWithRoundKeys(feedback, roundKeys);
            byte[] transformedBlock = new byte[AesCipher.BlockSize];

            for (int byteIndex = 0; byteIndex < AesCipher.BlockSize; byteIndex++)
            {
                transformedBlock[byteIndex] = (byte)(data[offset + byteIndex] ^ gamma[byteIndex]);
            }

            Array.Copy(transformedBlock, 0, result, offset, transformedBlock.Length);

            if (decrypt)
            {
                Array.Copy(data, offset, feedback, 0, AesCipher.BlockSize);
            }
            else
            {
                feedback = transformedBlock;
            }
        }

        return result;
    }

    private static void CheckInitializationVector(byte[] initializationVector)
    {
        if (initializationVector.Length != AesCipher.BlockSize)
        {
            throw new ArgumentException("IV должен содержать ровно 16 байтов");
        }
    }
}
