using System.Text;

namespace lab1;

internal static class RotorCipher
{
    public static string Transform(string text, string permutation, int startPosition, int step, bool encrypt)
    {
        int[] mapping = CreateMapping(permutation);
        int[] inverseMapping = CreateInverseMapping(mapping);
        int position = Alphabet.NormalizeIndex(startPosition);
        var result = new StringBuilder(text.Length);

        foreach (char symbol in text)
        {
            int inputIndex = Alphabet.Characters.IndexOf(char.ToLowerInvariant(symbol));
            if (inputIndex < 0)
            {
                result.Append(symbol);
                continue;
            }

            int shiftedInput = Alphabet.NormalizeIndex(inputIndex + position);
            int shiftedOutput = encrypt ? mapping[shiftedInput] : inverseMapping[shiftedInput];
            int outputIndex = Alphabet.NormalizeIndex(shiftedOutput - position);
            char outputSymbol = Alphabet.Characters[outputIndex];
            result.Append(char.IsUpper(symbol) ? char.ToUpperInvariant(outputSymbol) : outputSymbol);

            position = Alphabet.NormalizeIndex(position + step);
        }

        return result.ToString();
    }

    private static int[] CreateMapping(string permutation)
    {
        if (permutation.Length != Alphabet.Characters.Length)
        {
            throw new ArgumentException($"Перестановка должна содержать ровно {Alphabet.Characters.Length} символов.");
        }

        var mapping = new int[Alphabet.Characters.Length];
        var usedIndexes = new bool[Alphabet.Characters.Length];

        for (int i = 0; i < permutation.Length; i++)
        {
            int mappedIndex = Alphabet.Characters.IndexOf(char.ToLowerInvariant(permutation[i]));
            if (mappedIndex < 0 || usedIndexes[mappedIndex])
            {
                throw new ArgumentException("Перестановка должна содержать каждый символ алфавита ровно один раз.");
            }

            mapping[i] = mappedIndex;
            usedIndexes[mappedIndex] = true;
        }

        return mapping;
    }

    private static int[] CreateInverseMapping(int[] mapping)
    {
        var inverseMapping = new int[mapping.Length];
        for (int index = 0; index < mapping.Length; index++)
        {
            inverseMapping[mapping[index]] = index;
        }

        return inverseMapping;
    }
}
