using System.Numerics;
using System.Security.Cryptography;

namespace Lab6;

public static class HybridCipher
{
    public static (byte[] EncryptedData, BigInteger EncryptedKey) Encrypt(
        byte[] plaintext,
        byte[] aesKey,
        BigInteger modulus,
        BigInteger publicExponent)
    {
        byte[] initializationVector = RandomNumberGenerator.GetBytes(AesCipher.BlockSize);
        byte[] encryptedData = CfbCipher.Encrypt(plaintext, aesKey, initializationVector);
        BigInteger encryptedKey = RsaCipher.EncryptAesKey(aesKey, publicExponent, modulus);

        byte[] fileContents = new byte[initializationVector.Length + encryptedData.Length];
        Array.Copy(initializationVector, 0, fileContents, 0, initializationVector.Length);
        Array.Copy(encryptedData, 0, fileContents, initializationVector.Length, encryptedData.Length);

        return (fileContents, encryptedKey);
    }

    public static byte[] Decrypt(
        byte[] fileContents,
        BigInteger encryptedKey,
        BigInteger modulus,
        BigInteger privateExponent)
    {
        if (fileContents.Length < AesCipher.BlockSize * 2
            || (fileContents.Length - AesCipher.BlockSize) % AesCipher.BlockSize != 0)
        {
            throw new ArgumentException("Выбранный файл не содержит корректный шифротекст AES");
        }

        byte[] initializationVector = fileContents[..AesCipher.BlockSize];
        byte[] encryptedData = fileContents[AesCipher.BlockSize..];
        byte[] aesKey = RsaCipher.DecryptAesKey(encryptedKey, privateExponent, modulus);

        return CfbCipher.Decrypt(encryptedData, aesKey, initializationVector);
    }
}
