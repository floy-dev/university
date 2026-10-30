using System.Text;

namespace lab1;

internal static class NatoCipher
{
    private static readonly Dictionary<char, string> CodeWords = new()
    {
        ['A'] = "Alfa", ['B'] = "Bravo", ['C'] = "Charlie", ['D'] = "Delta",
        ['E'] = "Echo", ['F'] = "Foxtrot", ['G'] = "Golf", ['H'] = "Hotel",
        ['I'] = "India", ['J'] = "Juliett", ['K'] = "Kilo", ['L'] = "Lima",
        ['M'] = "Mike", ['N'] = "November", ['O'] = "Oscar", ['P'] = "Papa",
        ['Q'] = "Quebec", ['R'] = "Romeo", ['S'] = "Sierra", ['T'] = "Tango",
        ['U'] = "Uniform", ['V'] = "Victor", ['W'] = "Whiskey", ['X'] = "Xray",
        ['Y'] = "Yankee", ['Z'] = "Zulu"
    };

    private static readonly Dictionary<string, char> Letters = CodeWords
        .ToDictionary(pair => pair.Value, pair => pair.Key, StringComparer.OrdinalIgnoreCase);

    public static string Encode(string text)
    {
        var tokens = new List<string>();

        foreach (char symbol in text)
        {
            if (CodeWords.TryGetValue(char.ToUpperInvariant(symbol), out string? word))
            {
                tokens.Add(word);
            }
            else if (char.IsWhiteSpace(symbol))
            {
                tokens.Add("/");
            }
            else
            {
                tokens.Add(symbol.ToString());
            }
        }

        return string.Join(' ', tokens);
    }

    public static string Decode(string codeText)
    {
        var result = new StringBuilder();
        string[] tokens = codeText.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        foreach (string token in tokens)
        {
            if (token == "/")
            {
                result.Append(' ');
            }
            else if (Letters.TryGetValue(token, out char letter))
            {
                result.Append(letter);
            }
            else if (token.Length == 1)
            {
                result.Append(token);
            }
            else
            {
                throw new ArgumentException($"Неизвестное кодовое слово: {token}.");
            }
        }

        return result.ToString();
    }
}
