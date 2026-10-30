using System.Text;

namespace lab1;

internal static class AffineCryptanalysis
{
    public static string BruteForce(string ciphertext)
    {
        if (string.IsNullOrWhiteSpace(ciphertext))
        {
            throw new ArgumentException("Сначала укажите шифртекст для перебора.");
        }

        const int previewLength = 100;
        var result = new StringBuilder();
        int alphabetLength = Alphabet.Characters.Length;

        for (int a = 1; a < alphabetLength; a++)
        {
            if (AffineCipher.GreatestCommonDivisor(a, alphabetLength) != 1)
            {
                continue;
            }

            for (int b = 0; b < alphabetLength; b++)
            {
                string candidate = AffineCipher.Transform(ciphertext, a, b, encrypt: false);
                string preview = candidate.Length > previewLength ? candidate[..previewLength] + "…" : candidate;
                result.AppendLine($"a = {a,2}; b = {b,2}: {preview}");
            }
        }

        return result.ToString();
    }
}
