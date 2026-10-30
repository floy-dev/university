using System.Globalization;

namespace lab1;

internal static class FrequencyAnalysis
{
    private const string RussianLetters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    public static string FormatFrequencies(string ciphertext)
    {
        Dictionary<char, double> frequencies = Calculate(ciphertext);
        CultureInfo russianCulture = CultureInfo.GetCultureInfo("ru-RU");

        return "Частоты русских букв в шифртексте:" + Environment.NewLine + Environment.NewLine
            + string.Join(Environment.NewLine, frequencies
                .OrderBy(pair => RussianLetters.IndexOf(pair.Key))
                .Select(pair => $"{pair.Key}: {pair.Value.ToString("F4", russianCulture)}"));
    }

    private static Dictionary<char, double> Calculate(string text)
    {
        var counts = RussianLetters.ToDictionary(symbol => symbol, _ => 0);
        int total = 0;

        foreach (char symbol in text)
        {
            char lowerSymbol = char.ToLowerInvariant(symbol);

            if (!RussianLetters.Contains(lowerSymbol))
            {
                continue;
            }

            counts[lowerSymbol] = counts.GetValueOrDefault(lowerSymbol) + 1;
            total++;
        }

        if (total == 0)
        {
            throw new ArgumentException("Для частотного анализа нужны буквы русского алфавита в шифртексте.");
        }

        return counts.ToDictionary(pair => pair.Key, pair => (double)pair.Value / total);
    }
}
