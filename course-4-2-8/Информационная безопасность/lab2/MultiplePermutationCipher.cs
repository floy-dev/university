using System.Text;

namespace lab2;

public class MultiplePermutationCipher
{
    public static string Transform(string text, string key, int count, bool encrypt)
    {
        string result = text;

        for (int i = 0; i < count; i++)
        {
            result = encrypt
                ? PermutationCipher.Transform(result, key, true)
                : PermutationCipher.Transform(result, key, false);
        }

        return result;
    }
}
