using System.Text;

namespace lab1;

internal static class VigenereCipher
{
    private const string LatinAlphabet = "abcdefghijklmnopqrstuvwxyz";

    public static string Transform(string text, string key, bool encrypt)
    {
        var keyIndexes = new List<int>();
        foreach (char keySymbol in key)
        {
            int keyIndex = LatinAlphabet.IndexOf(char.ToLowerInvariant(keySymbol));
            if (keyIndex >= 0)
            {
                keyIndexes.Add(keyIndex);
            }
        }

        if (keyIndexes.Count == 0)
        {
            throw new ArgumentException("Введите ключ, содержащий хотя бы один символ используемого алфавита.");
        }

        var result = new StringBuilder(text.Length);
        int keyPosition = 0;

        foreach (char symbol in text)
        {
            int textIndex = LatinAlphabet.IndexOf(char.ToLowerInvariant(symbol));
            if (textIndex < 0)
            {
                result.Append(symbol);
                continue;
            }

            int keyIndex = keyIndexes[keyPosition % keyIndexes.Count];
            int resultIndex = NormalizeIndex(textIndex + (encrypt ? keyIndex : -keyIndex), LatinAlphabet.Length);
            char resultSymbol = LatinAlphabet[resultIndex];
            
            result.Append(char.IsUpper(symbol) ? char.ToUpperInvariant(resultSymbol) : resultSymbol);
            keyPosition++;
        }

        return result.ToString();
    }

    private static int NormalizeIndex(int value, int alphabetLength)
    {
        while (value < 0)
        {
            value += alphabetLength;
        }

        while (value >= alphabetLength)
        {
            value -= alphabetLength;
        }

        return value;
    }
}
