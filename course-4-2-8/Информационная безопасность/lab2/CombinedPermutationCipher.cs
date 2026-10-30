using System.Text;

namespace lab2;

public class CombinedPermutationCipher
{
    public static string Transform(string text, string key, bool encrypt)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentException("Введите ключ перестановки.");
        }

        var result = new StringBuilder(text.Length);

        for (int step = 0; step < text.Length; step += key.Length)
        {
            int blockLength = Math.Min(key.Length, text.Length - step);
            char[] reorderedBlock = new char[key.Length];
            bool[] filledPositions = new bool[key.Length];

            if (encrypt)
            {
                for (int i = 0; i < blockLength; i++)
                {
                    int destinationIndex = (int)char.GetNumericValue(key[i]) - 1;
                    reorderedBlock[destinationIndex] = text[step + i];
                    filledPositions[destinationIndex] = true;
                }

                for (int i = 0; i < key.Length; i++)
                {
                    if (filledPositions[i])
                    {
                        result.Append(reorderedBlock[i]);
                    }
                }
            }
            else
            {
                int ciphertextIndex = step;

                for (int i = 0; i < key.Length; i++)
                {
                    int sourceIndex = Array.IndexOf(key.ToCharArray(), (char)(i + '1'));
                    if (sourceIndex < blockLength)
                    {
                        reorderedBlock[i] = text[ciphertextIndex++];
                    }
                }

                for (int sourceIndex = 0; sourceIndex < blockLength; sourceIndex++)
                {
                    int destinationIndex = (int)char.GetNumericValue(key[sourceIndex]) - 1;
                    result.Append(reorderedBlock[destinationIndex]);
                }
            }
        }

        return result.ToString();
    }
}
