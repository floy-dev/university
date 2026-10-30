using System.Diagnostics;
using System.Numerics;

namespace Lab4;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnDeterministicCheck_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            BigInteger number = ParseNumber(txtDeterministicNumber.Text);
            bool isPrime;
            string methodName;

            if (cmbDeterministicMethod.SelectedIndex == 0)
            {
                methodName = "Перебор делителей";
                isPrime = TrialDivisionTest.IsPrime(number);
            }
            else
            {
                methodName = "Решето Эратосфена";
                isPrime = CheckWithSieve(number);
            }

            string conclusion = isPrime
                ? "простое число"
                : number >= 2
                    ? "составное число"
                    : "не является простым числом";

            txtDeterministicResult.Text =
                $"Метод: {methodName}\r\n" +
                $"Число: {number}\r\n" +
                $"Точный результат: {conclusion}\r\n";
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException or OverflowException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void btnDeterministicClear_Click(object? sender, EventArgs eventArgs)
    {
        txtDeterministicNumber.Clear();
        txtDeterministicResult.Clear();
        txtDeterministicNumber.Focus();
    }

    private void btnProbabilisticCheck_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            BigInteger number = ParseNumber(txtProbabilisticNumber.Text);
            int iterations = decimal.ToInt32(nudProbabilisticIterations.Value);
            bool isProbablyPrime;
            string methodName;

            switch (cmbProbabilisticMethod.SelectedIndex)
            {
                case 0:
                    methodName = "Случайный общий делитель";
                    isProbablyPrime = RandomGcdTest.IsProbablyPrime(number, iterations);
                    break;

                case 1:
                    methodName = "Тест Ферма";
                    isProbablyPrime = FermatTest.IsProbablyPrime(number, iterations);
                    break;

                case 2:
                    methodName = "Тест Рабина-Миллера";
                    isProbablyPrime = MillerRabinTest.IsProbablyPrime(number, iterations);
                    break;

                default:
                    methodName = "Тест Соловея-Штрассена";
                    isProbablyPrime = SolovayStrassenTest.IsProbablyPrime(number, iterations);
                    break;
            }

            string conclusion = isProbablyPrime
                ? "вероятно простое число"
                : number >= 2
                    ? "составное число"
                    : "не является простым числом";

            txtProbabilisticResult.Text =
                $"Метод: {methodName}\r\n" +
                $"Число: {number}\r\n" +
                $"Количество итераций: {iterations}\r\n" +
                $"Результат: {conclusion}\r\n";
        }
        catch (Exception exception) when (exception is ArgumentException or FormatException)
        {
            ShowInputError(exception.Message);
        }
    }

    private void btnProbabilisticClear_Click(object? sender, EventArgs eventArgs)
    {
        txtProbabilisticNumber.Clear();
        txtProbabilisticResult.Clear();
        txtProbabilisticNumber.Focus();
    }

    private void btnGeneratePrime_Click(object? sender, EventArgs eventArgs)
    {
        try
        {
            int bitCount = decimal.ToInt32(nudPrimeBitCount.Value);
            int iterations = decimal.ToInt32(nudGenerationIterations.Value);
            Stopwatch stopwatch = Stopwatch.StartNew();
            BigInteger primeNumber = PrimeNumberGenerator.Generate(bitCount, iterations);
            stopwatch.Stop();

            txtGeneratedPrime.Text =
                $"Вероятно простое число ({bitCount} бит):\r\n" +
                $"{primeNumber}\r\n\r\n" +
                $"Проверка: Рабин-Миллер, k = {iterations}\r\n" +
                $"Время: {stopwatch.Elapsed.TotalMilliseconds:F4} мс";
        }
        catch (ArgumentException exception)
        {
            ShowInputError(exception.Message);
        }
    }

    private void btnGenerationClear_Click(object? sender, EventArgs eventArgs)
    {
        txtGeneratedPrime.Clear();
        nudPrimeBitCount.Focus();
    }

    private static BigInteger ParseNumber(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            throw new ArgumentException("Введите целое число для проверки.");
        }

        if (!BigInteger.TryParse(text, out BigInteger number))
        {
            throw new FormatException("Введено некорректное целое число.");
        }

        return number;
    }

    private static bool CheckWithSieve(BigInteger number)
    {
        if (number < 2)
        {
            return false;
        }

        if (number > EratosthenesSieve.MaximumNumber)
        {
            throw new ArgumentException(
                $"Для решета введите число не больше {EratosthenesSieve.MaximumNumber:N0}.");
        }

        return EratosthenesSieve.IsPrime((int)number);
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
