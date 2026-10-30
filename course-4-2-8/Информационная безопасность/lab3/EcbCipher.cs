namespace Lab3;

internal static class EcbCipher
{
    public static byte[] Encrypt(byte[] data, byte[] key)
    {
        byte[] paddedData = Iso7816Padding.Add(data);
        byte[] roundKeys = AesCipher.ExpandKey(key);
        return TransformBlocks(paddedData, roundKeys, false);
    }

    public static byte[] Decrypt(byte[] encryptedData, byte[] key)
    {
        CheckEncryptedData(encryptedData);

        byte[] roundKeys = AesCipher.ExpandKey(key);
        byte[] paddedData = TransformBlocks(encryptedData, roundKeys, true);
        return Iso7816Padding.Remove(paddedData);
    }

    private static byte[] TransformBlocks(byte[] data, byte[] roundKeys, bool decrypt)
    {
        byte[] result = new byte[data.Length];

        for (int offset = 0; offset < data.Length; offset += AesCipher.BlockSize)
        {
            byte[] block = new byte[AesCipher.BlockSize];
            Array.Copy(data, offset, block, 0, block.Length);

            byte[] transformedBlock = decrypt
                ? AesCipher.DecryptBlockWithRoundKeys(block, roundKeys)
                : AesCipher.EncryptBlockWithRoundKeys(block, roundKeys);

            Array.Copy(transformedBlock, 0, result, offset, transformedBlock.Length);
        }

        return result;
    }

    private static void CheckEncryptedData(byte[] encryptedData)
    {
        if (encryptedData.Length == 0 || encryptedData.Length % AesCipher.BlockSize != 0)
        {
            throw new ArgumentException("Шифротекст ECB должен содержать положительное число блоков по 16 байтов.");
        }
    }
}
