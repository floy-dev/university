namespace Lab6;

public static class Iso7816Padding
{
    public static byte[] Add(byte[] data)
    {
        int paddingLength = AesCipher.BlockSize - data.Length % AesCipher.BlockSize;
        byte[] paddedData = new byte[data.Length + paddingLength];

        Array.Copy(data, paddedData, data.Length);
        paddedData[data.Length] = 0x80;

        return paddedData;
    }

    public static byte[] Remove(byte[] paddedData)
    {
        if (paddedData.Length == 0 || paddedData.Length % AesCipher.BlockSize != 0)
        {
            throw new ArgumentException("Дополненные данные должны состоять из целого числа блоков по 16 байтов");
        }

        int markerPosition = paddedData.Length - 1;
        int lastBlockStart = paddedData.Length - AesCipher.BlockSize;

        while (markerPosition >= lastBlockStart && paddedData[markerPosition] == 0)
        {
            markerPosition--;
        }

        if (markerPosition < lastBlockStart || paddedData[markerPosition] != 0x80)
        {
            throw new ArgumentException("Неверное дополнение ISO/IEC 7816-4. Проверьте ключ, IV и шифротекст");
        }

        byte[] data = new byte[markerPosition];
        Array.Copy(paddedData, data, markerPosition);
        return data;
    }
}
