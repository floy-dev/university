using System.Text;
using System.IO.Hashing;
using stemming;

namespace lab5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите имя первого текстового файла: ");
        string firstFileName = Console.ReadLine()!;

        Console.Write("Введите имя второго текстового файла: ");
        string secondFileName = Console.ReadLine()!;

        string firstText = File.ReadAllText(firstFileName);
        string secondText = File.ReadAllText(secondFileName);

        List<string> firstWords = CanonizeText(firstText);
        List<string> secondWords = CanonizeText(secondText);

        List<string> firstShingles = BuildShingles(firstWords);
        List<string> secondShingles = BuildShingles(secondWords);

        List<string> firstChecksums = CalculateChecksums(firstShingles);
        List<string> secondChecksums = CalculateChecksums(secondShingles);

        int matchingChecksums = CountMatchingChecksums(firstChecksums, secondChecksums);
        double similarity = CalculateSimilarity(matchingChecksums, firstChecksums.Count, secondChecksums.Count);

        Console.WriteLine();
        Console.WriteLine($"Количество шинглов в первом документе: {firstChecksums.Count}");
        Console.WriteLine($"Количество шинглов во втором документе: {secondChecksums.Count}");
        Console.WriteLine($"Совпавших контрольных сумм: {matchingChecksums}");
        Console.WriteLine($"Схожесть документов: {similarity:F2}%");
    }

    static List<string> CanonizeText(string text)
    {
        char[] separators = [' ', ',', '.', '!', '?', ':', ';', '"', '(', ')', '-', '—', '\r', '\n', '\t'];
        string[] sourceWords = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<string> words = [];

        for (int i = 0; i < sourceWords.Length; i++)
        {
            string word = Stemming.ProcessRawWord(sourceWords[i].Replace('ё', 'е'));

            if (!string.IsNullOrWhiteSpace(word))
            {
                words.Add(word);
            }
        }

        return words;
    }

    static List<string> BuildShingles(List<string> words)
    {
        const int shingleLength = 3;
        List<string> shingles = new List<string>();

        for (int i = 0; i <= words.Count - shingleLength; i++)
        {
            shingles.Add(words[i] + " " + words[i + 1] + " " + words[i + 2]);
        }

        return shingles;
    }

    static List<string> CalculateChecksums(List<string> shingles)
    {
        List<string> checksums = new List<string>();

        for (int i = 0; i < shingles.Count; i++)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(shingles[i]);
            checksums.Add(Convert.ToHexString(Crc32.Hash(bytes)));
        }

        return checksums;
    }

    static int CountMatchingChecksums(List<string> firstChecksums, List<string> secondChecksums)
    {
        List<bool> usedChecksums = new List<bool>();

        for (int i = 0; i < secondChecksums.Count; i++)
        {
            usedChecksums.Add(false);
        }

        int matchingChecksums = 0;

        for (int i = 0; i < firstChecksums.Count; i++)
        {
            for (int j = 0; j < secondChecksums.Count; j++)
            {
                if (!usedChecksums[j] && firstChecksums[i] == secondChecksums[j])
                {
                    usedChecksums[j] = true;
                    matchingChecksums++;
                    break;
                }
            }
        }

        return matchingChecksums;
    }

    static double CalculateSimilarity(int matchingChecksums, int firstCount, int secondCount)
    {
        int maxCount = Math.Max(firstCount, secondCount);

        if (maxCount == 0)
        {
            return 0;
        }

        return (double)matchingChecksums / maxCount * 100;
    }
}
