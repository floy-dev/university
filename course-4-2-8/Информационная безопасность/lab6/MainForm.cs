using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace Lab6;

public partial class MainForm : Form
{
    private byte[]? hybridEncryptedData;
    private BigInteger hybridEncryptedKey;
    private byte[]? hybridRestoredData;

    public MainForm()
    {
        InitializeComponent();
    }

    private void BtnRsaGeneratePrimes_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            int bitCount = (int)nudRsaBitCount.Value;
            BigInteger firstPrime = PrimeNumberGenerator.Generate(bitCount, 16);
            BigInteger secondPrime = firstPrime;

            while (secondPrime == firstPrime)
            {
                secondPrime = PrimeNumberGenerator.Generate(bitCount, 16);
            }

            txtRsaFirstPrime.Text = firstPrime.ToString();
            txtRsaSecondPrime.Text = secondPrime.ToString();
            txtRsaPublicExponent.Text = ChoosePublicExponent(firstPrime, secondPrime).ToString();
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaLoadPrimes_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            using OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            string[] values = File.ReadAllText(dialog.FileName)
                .Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

            if (values.Length != 2)
            {
                throw new ArgumentException("Файл должен содержать два числа: p и q");
            }

            BigInteger firstPrime = BigInteger.Parse(values[0]);
            BigInteger secondPrime = BigInteger.Parse(values[1]);
            txtRsaFirstPrime.Text = firstPrime.ToString();
            txtRsaSecondPrime.Text = secondPrime.ToString();
            txtRsaPublicExponent.Text = ChoosePublicExponent(firstPrime, secondPrime).ToString();
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaCalculateKeys_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            CalculateRsaKeys();
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaSavePublicKey_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            SaveRsaKey(txtRsaPublicExponent.Text, "public-key.txt");
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaSavePrivateKey_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            SaveRsaKey(txtRsaPrivateExponent.Text, "private-key.txt");
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaLoadPublicKey_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            LoadRsaKey(txtRsaPublicExponent);
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaLoadPrivateKey_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            LoadRsaKey(txtRsaPrivateExponent);
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaEncrypt_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            BigInteger message = BigInteger.Parse(txtRsaMessage.Text);
            BigInteger publicExponent = BigInteger.Parse(txtRsaPublicExponent.Text);
            BigInteger modulus = BigInteger.Parse(txtRsaModulus.Text);
            
            txtRsaEncryptedMessage.Text = RsaCipher.Encrypt(message, publicExponent, modulus).ToString();
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnRsaDecrypt_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            BigInteger encryptedMessage = BigInteger.Parse(txtRsaEncryptedMessage.Text);
            BigInteger privateExponent = BigInteger.Parse(txtRsaPrivateExponent.Text);
            BigInteger modulus = BigInteger.Parse(txtRsaModulus.Text);
            txtRsaRestoredMessage.Text = RsaCipher.Decrypt(encryptedMessage, privateExponent, modulus).ToString();
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnAesGenerateKey_Click(object? sender, EventArgs eventArgs)
    {
        txtAesKey.Text = Convert.ToHexString(RandomNumberGenerator.GetBytes(AesCipher.KeySize));
    }

    private void BtnAesGenerateIv_Click(object? sender, EventArgs eventArgs)
    {
        txtAesIv.Text = Convert.ToHexString(RandomNumberGenerator.GetBytes(AesCipher.BlockSize));
    }

    private void BtnAesEncrypt_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            byte[] key = Convert.FromHexString(txtAesKey.Text);
            byte[] initializationVector = Convert.FromHexString(txtAesIv.Text);
            byte[] plaintext = Encoding.UTF8.GetBytes(txtAesPlaintext.Text);
            byte[] encryptedData = CfbCipher.Encrypt(plaintext, key, initializationVector);
            txtAesCiphertext.Text = Convert.ToHexString(encryptedData);
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnAesDecrypt_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            byte[] key = Convert.FromHexString(txtAesKey.Text);
            byte[] initializationVector = Convert.FromHexString(txtAesIv.Text);
            byte[] encryptedData = Convert.FromHexString(txtAesCiphertext.Text);
            byte[] plaintext = CfbCipher.Decrypt(encryptedData, key, initializationVector);
            txtAesRestoredText.Text = new UTF8Encoding(false, true).GetString(plaintext);
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnHybridGenerateAesKey_Click(object? sender, EventArgs eventArgs)
    {
        txtHybridAesKey.Text = Convert.ToHexString(RandomNumberGenerator.GetBytes(AesCipher.KeySize));
    }

    private void BtnHybridEncrypt_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            BigInteger modulus = BigInteger.Parse(txtRsaModulus.Text);
            BigInteger publicExponent = BigInteger.Parse(txtRsaPublicExponent.Text);
            byte[] aesKey = Convert.FromHexString(txtHybridAesKey.Text);

            var result = HybridCipher.Encrypt(
                Encoding.UTF8.GetBytes(txtHybridPlaintext.Text),
                aesKey,
                modulus,
                publicExponent);

            hybridEncryptedData = result.EncryptedData;
            hybridEncryptedKey = result.EncryptedKey;
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnHybridSaveEncrypted_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            byte[] encryptedData = hybridEncryptedData
                ?? throw new ArgumentException("Сначала выполните шифрование или откройте файлы");

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "Зашифрованные данные|*.aes|Все файлы|*.*",
                FileName = "message.aes"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            string keyPath = dialog.FileName + ".key.txt";

            if (File.Exists(keyPath))
            {
                throw new IOException("Файл зашифрованного ключа уже существует, выберите другое имя");
            }

            File.WriteAllBytes(dialog.FileName, encryptedData);
            File.WriteAllText(keyPath, hybridEncryptedKey.ToString());

        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnHybridOpenEncrypted_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            using OpenFileDialog dataDialog = new OpenFileDialog
            {
                Title = "Выберите файл шифротекста",
                Filter = "Зашифрованные данные|*.aes|Все файлы|*.*"
            };

            if (dataDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            using OpenFileDialog keyDialog = new OpenFileDialog
            {
                Title = "Выберите файл зашифрованного AES-ключа",
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*",
                FileName = dataDialog.FileName + ".key.txt"
            };

            if (keyDialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            byte[] encryptedData = File.ReadAllBytes(dataDialog.FileName);
            BigInteger encryptedKey = BigInteger.Parse(File.ReadAllText(keyDialog.FileName).Trim());
            hybridEncryptedData = encryptedData;
            hybridEncryptedKey = encryptedKey;
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnHybridDecrypt_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            byte[] encryptedData = hybridEncryptedData
                ?? throw new ArgumentException("Сначала выполните шифрование или откройте файлы");

            BigInteger modulus = BigInteger.Parse(txtRsaModulus.Text);
            BigInteger privateExponent = BigInteger.Parse(txtRsaPrivateExponent.Text);
            byte[] plaintext = HybridCipher.Decrypt(
                encryptedData,
                hybridEncryptedKey,
                modulus,
                privateExponent);

            txtHybridRestoredText.Text = new UTF8Encoding(false, true).GetString(plaintext);
            hybridRestoredData = plaintext;
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void BtnHybridSaveRestored_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            if (hybridRestoredData == null)
            {
                throw new ArgumentException("Сначала выполните дешифрование");
            }

            using SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*",
                FileName = "restored.txt"
            };

            if (saveDialog.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, hybridRestoredData);
            }
        }
        catch (Exception exception)
        {
            ShowError(exception.Message);
        }
    }

    private void CalculateRsaKeys()
    {
        BigInteger firstPrime = BigInteger.Parse(txtRsaFirstPrime.Text);
        BigInteger secondPrime = BigInteger.Parse(txtRsaSecondPrime.Text);
        BigInteger publicExponent = BigInteger.Parse(txtRsaPublicExponent.Text);
        var keys = RsaCipher.CreateKeys(firstPrime, secondPrime, publicExponent);

        txtRsaModulus.Text = keys.Modulus.ToString();
        txtRsaPrivateExponent.Text = keys.PrivateExponent.ToString();
    }

    private static BigInteger ChoosePublicExponent(BigInteger firstPrime, BigInteger secondPrime)
    {
        if (firstPrime < 3 || secondPrime < 3)
        {
            throw new ArgumentException("Числа p и q должны быть простыми и не меньше 3");
        }

        BigInteger totient = (firstPrime - 1) * (secondPrime - 1);
        BigInteger publicExponent = 65537;

        if (publicExponent < totient
            && BigInteger.GreatestCommonDivisor(publicExponent, totient) == 1)
        {
            return publicExponent;
        }

        publicExponent = 3;

        while (BigInteger.GreatestCommonDivisor(publicExponent, totient) != 1)
        {
            publicExponent += 2;
        }

        return publicExponent;
    }

    private void SaveRsaKey(string exponentText, string defaultFileName)
    {
        BigInteger modulus = BigInteger.Parse(txtRsaModulus.Text);
        BigInteger exponent = BigInteger.Parse(exponentText);

        using SaveFileDialog dialog = new SaveFileDialog
        {
            Filter = "Текстовые файлы|*.txt|Все файлы|*.*",
            FileName = defaultFileName
        };

        if (dialog.ShowDialog(this) == DialogResult.OK)
        {
            File.WriteAllLines(dialog.FileName, [modulus.ToString(), exponent.ToString()]);
        }
    }

    private void LoadRsaKey(TextBox exponentTextBox)
    {
        using OpenFileDialog dialog = new OpenFileDialog
        {
            Filter = "Текстовые файлы|*.txt|Все файлы|*.*"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        string[] values = File.ReadAllLines(dialog.FileName);

        if (values.Length != 2)
        {
            throw new ArgumentException("Файл ключа должен содержать модуль n и экспоненту");
        }

        txtRsaModulus.Text = BigInteger.Parse(values[0]).ToString();
        exponentTextBox.Text = BigInteger.Parse(values[1]).ToString();
    }


    private void ShowError(string message)
    {
        MessageBox.Show(this, message, "Проверьте данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
