using System.Text;

namespace lab2;

public class PermutationCryptanalysis
{
    public static (string Key, string Plaintext, double Distance) FindBestKey(
        string ciphertext,
        string referenceText,
        int keyLength)
    {
        Dictionary<string, double> referenceFrequencies = GetBigramFrequencies(referenceText);

        string bestKey = "";
        string bestPlaintext = "";
        double bestDistance = double.MaxValue;
        int[] key = Enumerable.Range(1, keyLength).ToArray();

        CheckPermutations(
            key,
            0,
            ciphertext,
            referenceFrequencies,
            ref bestKey,
            ref bestPlaintext,
            ref bestDistance);

        return (bestKey, bestPlaintext, bestDistance);
    }

    private static void CheckPermutations(
        int[] key,
        int position,
        string ciphertext,
        Dictionary<string, double> referenceFrequencies,
        ref string bestKey,
        ref string bestPlaintext,
        ref double bestDistance)
    {
        if (position == key.Length)
        {
            string keyText = string.Concat(key);
            string plaintext = Decrypt(ciphertext, keyText);
            double distance = CalculateDistance(plaintext, referenceFrequencies);

            if (distance < bestDistance)
            {
                bestKey = keyText;
                bestPlaintext = plaintext;
                bestDistance = distance;
            }

            return;
        }

        for (int index = position; index < key.Length; index++)
        {
            (key[position], key[index]) = (key[index], key[position]);
            CheckPermutations(
                key,
                position + 1,
                ciphertext,
                referenceFrequencies,
                ref bestKey,
                ref bestPlaintext,
                ref bestDistance);
            (key[position], key[index]) = (key[index], key[position]);
        }
    }

    private static string Decrypt(string ciphertext, string key)
    {
        var result = new StringBuilder(ciphertext.Length);

        for (int blockStart = 0; blockStart < ciphertext.Length; blockStart += key.Length)
        {
            int blockLength = Math.Min(key.Length, ciphertext.Length - blockStart);
            char[] originalBlock = new char[key.Length];
            int ciphertextIndex = blockStart;

            for (int destinationIndex = 0; destinationIndex < key.Length; destinationIndex++)
            {
                int sourceIndex = key.IndexOf((char)(destinationIndex + '1'));

                if (sourceIndex < blockLength)
                {
                    originalBlock[destinationIndex] = ciphertext[ciphertextIndex++];
                }
            }

            for (int sourceIndex = 0; sourceIndex < blockLength; sourceIndex++)
            {
                result.Append(originalBlock[key[sourceIndex] - '1']);
            }
        }

        return result.ToString();
    }

    private static double CalculateDistance(
        string text,
        Dictionary<string, double> referenceFrequencies)
    {
        Dictionary<string, double> textFrequencies = GetBigramFrequencies(text);
        IEnumerable<string> allBigrams = referenceFrequencies.Keys.Union(textFrequencies.Keys);
        double distance = 0;

        foreach (string bigram in allBigrams)
        {
            double difference = textFrequencies.GetValueOrDefault(bigram)
                                - referenceFrequencies.GetValueOrDefault(bigram);
            distance += difference * difference;
        }

        return distance;
    }

    private static Dictionary<string, double> GetBigramFrequencies(string text)
    {
        var counts = new Dictionary<string, int>();
        string normalizedText = text.ToLowerInvariant();
        int bigramCount = 0;

        for (int index = 0; index < normalizedText.Length - 1; index++)
        {
            char first = normalizedText[index];
            char second = normalizedText[index + 1];

            if (!char.IsLetter(first) || !char.IsLetter(second))
            {
                continue;
            }

            string bigram = new string(new[] { first, second });
            counts[bigram] = counts.GetValueOrDefault(bigram) + 1;
            bigramCount++;
        }

        return counts.ToDictionary(
            pair => pair.Key,
            pair => pair.Value / (double)bigramCount);
    }
}
