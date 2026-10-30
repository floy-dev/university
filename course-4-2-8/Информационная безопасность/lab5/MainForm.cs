using System.Numerics;

namespace Lab5;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        btnCheckRootExistence.Click += (_, _) => CheckRootExistence();
        btnFindRoots.Click += (_, _) => FindRoots();
        btnGenerateSafePrime.Click += (_, _) => GenerateSafePrime();
        btnDhCalculate.Click += (_, _) => CalculateDiffieHellman();
        btnElGamalCalculatePublicKey.Click += (_, _) => CalculateElGamalPublicKey();
        btnElGamalGenerateSessionKey.Click += (_, _) => GenerateElGamalSessionKey();
        btnElGamalEncrypt.Click += (_, _) => EncryptElGamalMessage();
        btnElGamalDecrypt.Click += (_, _) => DecryptElGamalMessage();
    }

    private void CheckRootExistence()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtRootModulus, "модуль n");
            bool rootsExist = PrimitiveRootCalculator.CanHaveRoots(modulus);

            txtRootSearchResult.Text = rootsExist
                ? $"Модуль n = {modulus} может иметь первообразные корни."
                : $"Модуль n = {modulus} не имеет первообразных корней.";
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void FindRoots()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtRootModulus, "модуль n");
            int rootCount = decimal.ToInt32(nudRootCount.Value);
            List<BigInteger> roots = PrimitiveRootCalculator.FindFirst(modulus, rootCount);

            if (roots.Count == 0)
            {
                txtRootSearchResult.Text =
                    $"Модуль n = {modulus} не имеет первообразных корней.";
            }
            else
            {
                txtRootSearchResult.Text =
                    $"Первые первообразные корни для n = {modulus}:\r\n" +
                    string.Join(", ", roots);

                if (roots.Count < rootCount)
                {
                    txtRootSearchResult.AppendText(
                        $"\r\nНайдено всех корней: {roots.Count}. Это меньше заданного k.");
                }
            }
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void GenerateSafePrime()
    {
        try
        {
            int bitCount = decimal.ToInt32(nudSafePrimeBitCount.Value);
            int iterations = decimal.ToInt32(nudSafePrimeIterations.Value);

            BigInteger safePrime = PrimeNumberGenerator.GenerateSafePrime(bitCount, iterations);
            BigInteger primeDivisor = (safePrime - 1) / 2;
            BigInteger primitiveRoot = PrimitiveRootCalculator.FindForSafePrime(safePrime);

            txtSafePrimeP.Text = primeDivisor.ToString();
            txtSafePrimeN.Text = safePrime.ToString();
            txtSafePrimeRoot.Text = primitiveRoot.ToString();
            txtSafePrimeStatus.Text = $"Получено безопасное простое число ({bitCount} бит).\r\n";
        }
        catch (ArgumentException exception)
        {
            ShowInputError(exception.Message);
        }
    }

    private void CalculateDiffieHellman()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtDhModulus, "модуль n");
            BigInteger primitiveRoot = ParseNumber(txtDhPrimitiveRoot, "первообразный корень g");
            BigInteger aliceSecret = ParseNumber(txtDhAliceSecret, "секрет Алисы a");
            BigInteger bobSecret = ParseNumber(txtDhBobSecret, "секрет Боба b");

            BigInteger alicePublicValue = DiffieHellmanProtocol.CalculatePublicValue(
                modulus,
                primitiveRoot,
                aliceSecret);
            BigInteger bobPublicValue = DiffieHellmanProtocol.CalculatePublicValue(
                modulus,
                primitiveRoot,
                bobSecret);
            BigInteger aliceSharedKey = DiffieHellmanProtocol.CalculateSharedKey(
                modulus,
                bobPublicValue,
                aliceSecret);
            BigInteger bobSharedKey = DiffieHellmanProtocol.CalculateSharedKey(
                modulus,
                alicePublicValue,
                bobSecret);

            txtDhAlicePublic.Text = alicePublicValue.ToString();
            txtDhBobPublic.Text = bobPublicValue.ToString();
            txtDhAliceSharedKey.Text = aliceSharedKey.ToString();
            txtDhBobSharedKey.Text = bobSharedKey.ToString();
            
            txtDhStatus.Text = aliceSharedKey == bobSharedKey
                ? "Общие ключи совпадают. Обмен выполнен успешно."
                : "Общие ключи не совпадают.";
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void CalculateElGamalPublicKey()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtElGamalModulus, "модуль n");
            BigInteger primitiveRoot = ParseNumber(txtElGamalPrimitiveRoot, "первообразный корень g");
            BigInteger secret = ParseNumber(txtElGamalSecret, "закрытый ключ s");
            
            BigInteger publicKey = ElGamalCipher.CalculatePublicKey(
                modulus,
                primitiveRoot,
                secret);

            txtElGamalPublicKey.Text = publicKey.ToString();
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void GenerateElGamalSessionKey()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtElGamalModulus, "модуль n");

            if (modulus <= 4)
            {
                throw new ArgumentException("Для генерации k модуль n должен быть больше 4.");
            }

            BigInteger sessionKey = 2 + RandomNumberHelper.RandomBelow(modulus - 3);
            txtElGamalSessionKey.Text = sessionKey.ToString();
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void EncryptElGamalMessage()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtElGamalModulus, "модуль n");
            BigInteger primitiveRoot = ParseNumber(txtElGamalPrimitiveRoot, "первообразный корень g");
            BigInteger secret = ParseNumber(txtElGamalSecret, "закрытый ключ s");
            BigInteger sessionKey = ParseNumber(txtElGamalSessionKey, "сессионный ключ k");
            BigInteger message = ParseNumber(txtElGamalMessage, "сообщение M");
            
            BigInteger publicKey = ElGamalCipher.CalculatePublicKey(
                modulus,
                primitiveRoot,
                secret);
            (BigInteger firstComponent, BigInteger secondComponent) = ElGamalCipher.Encrypt(
                message,
                modulus,
                primitiveRoot,
                publicKey,
                sessionKey);

            txtElGamalPublicKey.Text = publicKey.ToString();
            txtElGamalFirstComponent.Text = firstComponent.ToString();
            txtElGamalSecondComponent.Text = secondComponent.ToString();
            txtElGamalDecryptedMessage.Clear();
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void DecryptElGamalMessage()
    {
        try
        {
            BigInteger modulus = ParseNumber(txtElGamalModulus, "модуль n");
            BigInteger secret = ParseNumber(txtElGamalSecret, "закрытый ключ s");
            BigInteger firstComponent = ParseNumber(txtElGamalFirstComponent, "компонент u");
            BigInteger secondComponent = ParseNumber(txtElGamalSecondComponent, "компонент v");
            BigInteger message = ElGamalCipher.Decrypt(
                firstComponent,
                secondComponent,
                modulus,
                secret);

            txtElGamalDecryptedMessage.Text = message.ToString();
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private static BigInteger ParseNumber(TextBox textBox, string parameterName)
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            throw new ArgumentException($"Введите {parameterName}.");
        }

        if (!BigInteger.TryParse(textBox.Text, out BigInteger number))
        {
            throw new FormatException($"Поле «{parameterName}» должно содержать целое число.");
        }

        return number;
    }

    private void ShowInputError(string message)
    {
        MessageBox.Show(
            this,
            message,
            "Некорректные параметры",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
    }
}
