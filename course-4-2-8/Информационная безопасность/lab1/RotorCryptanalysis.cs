using System.Text;

namespace lab1;

internal static class RotorCryptanalysis
{
    public static string FindStates(string plaintext, string ciphertext, string permutation, int maximumStep)
    {
        if (string.IsNullOrEmpty(plaintext) || string.IsNullOrEmpty(ciphertext))
        {
            throw new ArgumentException("Заполните открытый фрагмент и соответствующий фрагмент шифртекста.");
        }

        if (plaintext.Length != ciphertext.Length)
        {
            throw new ArgumentException("Открытый текст и шифртекст должны иметь одинаковую длину.");
        }

        if (maximumStep < 1)
        {
            throw new ArgumentException("Максимальный шаг должен быть не меньше 1.");
        }

        var result = new StringBuilder();
        int maximumPosition = Alphabet.Characters.Length;

        for (int startPosition = 0; startPosition < maximumPosition; startPosition++)
        {
            for (int step = 1; step <= maximumStep; step++)
            {
                string candidate = RotorCipher.Transform(plaintext, permutation, startPosition, step, encrypt: true);
                if (string.Equals(candidate, ciphertext, StringComparison.Ordinal))
                {
                    result.AppendLine($"Начальная позиция: {startPosition}; шаг: {step}.");
                }
            }
        }

        return result.Length == 0
            ? "Совпадения не найдены. Проверьте фрагменты, перестановку и максимальный шаг."
            : result.ToString();
    }
}
