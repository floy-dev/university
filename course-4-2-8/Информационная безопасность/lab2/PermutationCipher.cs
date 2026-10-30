using System.Text;

namespace lab2;

public class PermutationCipher
{
    public static string Transform(string text, string key, bool encrypt)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentException("Введите ключ перестановки.");
        }
        
        StringBuilder result = new StringBuilder();
        
        char[] chars = new char[key.Length];
        int currentKeyIndex = 0;
        int step = 0;

        foreach (var symbol in text)
        {
            if (encrypt)
            {
                chars[(int)char.GetNumericValue(key[currentKeyIndex]) - 1] = symbol;
            }
            else
            {
                result.Append(text[(int)char.GetNumericValue(key[currentKeyIndex]) - 1 + (key.Length * step)]);
            }
            
            currentKeyIndex++;
            
            if (currentKeyIndex == key.Length)
            {
                currentKeyIndex = 0;
                step++;

                if (encrypt)
                {
                    result.Append(string.Join("", chars));
                    chars = new char[key.Length];        
                }
            }
        }

        if (encrypt && currentKeyIndex != 0)
        {
            foreach (char symbol in chars)
            {
                if (symbol != '\0')
                {
                    result.Append(symbol);
                }
            }
        }

        return result.ToString();
    }
}
