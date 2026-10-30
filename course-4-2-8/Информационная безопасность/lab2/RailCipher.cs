namespace lab2;

public class RailCipher
{
    public static string Transform(string text, int railCount, bool encrypt)
    {
        if (railCount < 2)
        {
            throw new ArgumentException("Количество рельсов должно быть не меньше 2.");
        }

        if (string.IsNullOrEmpty(text) || text.Length == 1)
        {
            return text;
        }

        return encrypt
            ? Encrypt(text, railCount)
            : Decrypt(text, railCount);
    }

    private static string Encrypt(string text, int railCount)
    {
        string[] rails = new string[railCount];
        
        int currentRail = 0;
        bool direction = true;

        foreach (char symbol in text)
        {
            rails[currentRail] += symbol;

            currentRail += direction ? 1 : -1;

            if (currentRail == railCount - 1 || currentRail == 0)
            {
                direction = !direction;
            }
        }

        return string.Join("", rails);
    }

    private static string Decrypt(string ciphertext, int railCount)
    {
        int[] railIndexes = GetRailIndexes(ciphertext.Length, railCount);
        int[] railLengths = new int[railCount];

        foreach (int railIndex in railIndexes)
        {
            railLengths[railIndex]++;
        }

        string[] rails = new string[railCount];
        int position = 0;
        for (int i = 0; i < railCount; i++)
        {
            rails[i] = ciphertext.Substring(position, railLengths[i]);
            position += railLengths[i];
        }

        int[] positionsInRails = new int[railCount];
        var result = new System.Text.StringBuilder(ciphertext.Length);

        foreach (int railIndex in railIndexes)
        {
            result.Append(rails[railIndex][positionsInRails[railIndex]++]);
        }

        return result.ToString();
    }

    private static int[] GetRailIndexes(int textLength, int railCount)
    {
        var matrix = new int[textLength];
        
        int railIndex = 0;
        int direction = 1;

        for (int i = 0; i < textLength; i++)
        {
            matrix[i] = railIndex;

            if (railIndex == railCount - 1)
            {
                direction = -1;
            }
            else if (railIndex == 0)
            {
                direction = 1;
            }

            railIndex += direction;
        }

        return matrix;
    }
}
