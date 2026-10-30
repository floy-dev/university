using System.Text;

namespace lab1;

internal static class AffineCipher
{
    public static string Transform(string text, int a, int b, bool encrypt)
    {
        int alphabetLength = Alphabet.Characters.Length;
        if (GreatestCommonDivisor(a, alphabetLength) != 1)
        {
            throw new ArgumentException(
                $"Значение a должно быть взаимно простым с длиной алфавита ({alphabetLength}).");
        }

        int inverseA = encrypt ? 0 : ModularInverse(a, alphabetLength);
        var result = new StringBuilder(text.Length);

        foreach (char symbol in text)
        {
            int index = Alphabet.Characters.IndexOf(char.ToLowerInvariant(symbol));
            if (index < 0)
            {
                result.Append(symbol);
                continue;
            }

            int transformedIndex = encrypt
                ? Alphabet.NormalizeIndex(a * index + b)
                : Alphabet.NormalizeIndex(inverseA * (index - b));
            
            char transformedSymbol = Alphabet.Characters[transformedIndex];
            result.Append(char.IsUpper(symbol) ? char.ToUpperInvariant(transformedSymbol) : transformedSymbol);
        }

        return result.ToString();
    }

    public static int GreatestCommonDivisor(int first, int second)
    {
        while (second != 0)
        {
            (first, second) = (second, first % second);
        }

        return Math.Abs(first);
    }

    private static int ModularInverse(int value, int modulus)
    {
        int normalizedValue = Alphabet.NormalizeIndex(value);
        for (int candidate = 1; candidate < modulus; candidate++)
        {
            if (normalizedValue * candidate % modulus == 1)
            {
                return candidate;
            }
        }

        throw new ArgumentException("Для выбранного значения a не существует обратного элемента.");
    }
}
