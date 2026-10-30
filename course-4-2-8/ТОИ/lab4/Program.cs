using stemming;

namespace lab4;

class Program
{
    static void Main()
    {
        ReadDocuments(
            out List<string> documents,
            out List<List<string>> documentWords,
            out List<string> titles,
            out Dictionary<string, List<int>> index
        );

        List<string> queryWords = ReadQuery();

        if (queryWords.Count == 0)
        {
            Console.WriteLine("Документы не найдены.");
            return;
        }

        List<int> foundDocuments = FindDocuments(documents, index, queryWords);
        List<(int Number, double Score)> results = CalculateResults(foundDocuments, documentWords, queryWords);

        WriteResults(results, titles, documents);
    }

    static void ReadDocuments(
        out List<string> documents,
        out List<List<string>> documentWords,
        out List<string> titles,
        out Dictionary<string, List<int>> index
    )
    {
        string[] paths = Directory.GetFiles("data", "*.txt");
        documents = [];
        documentWords = [];
        titles = [];
        index = [];

        for (int documentNumber = 0; documentNumber < paths.Length; documentNumber++)
        {
            string document = File.ReadAllText(paths[documentNumber]);
            List<string> words = GetWords(document);

            documents.Add(document);
            documentWords.Add(words);
            titles.Add(document.Split('\n', StringSplitOptions.RemoveEmptyEntries)[0].Trim());

            for (int wordNumber = 0; wordNumber < words.Count; wordNumber++)
            {
                string word = words[wordNumber];

                if (!index.ContainsKey(word))
                {
                    index[word] = [];
                }

                if (!index[word].Contains(documentNumber))
                {
                    index[word].Add(documentNumber);
                }
            }
        }

        Console.WriteLine($"Проиндексировано документов: {documents.Count}");
        Console.WriteLine($"Слов в индексе: {index.Count}");
        Console.WriteLine();
        Console.WriteLine("Введите запрос:");
        Console.WriteLine();
    }

    static List<string> ReadQuery()
    {
        string query = Console.ReadLine() ?? "";
        return GetWords(query).Distinct().ToList();
    }

    static List<int> FindDocuments(
        List<string> documents,
        Dictionary<string, List<int>> index,
        List<string> queryWords
    )
    {
        List<int> foundDocuments = [];
        for (int documentNumber = 0; documentNumber < documents.Count; documentNumber++)
        {
            bool containsAllWords = true;

            for (int wordNumber = 0; wordNumber < queryWords.Count; wordNumber++)
            {
                string word = queryWords[wordNumber];

                if (!index.ContainsKey(word) || !index[word].Contains(documentNumber))
                {
                    containsAllWords = false;
                    break;
                }
            }

            if (containsAllWords)
            {
                foundDocuments.Add(documentNumber);
            }
        }

        return foundDocuments;
    }

    static List<(int Number, double Score)> CalculateResults(
        List<int> foundDocuments,
        List<List<string>> documentWords,
        List<string> queryWords
    )
    {
        List<(int Number, double Score)> results = [];

        foreach (var documentNumber in foundDocuments)
        {
            int single = CountSingleWords(documentWords[documentNumber], queryWords);
            int pair = CountPairs(documentWords[documentNumber], queryWords);
            int phrase = CountPhrase(documentWords[documentNumber], queryWords);
            
            double score = single + pair + 1 + phrase / 350.0;

            results.Add((documentNumber, score));
        }

        results.Sort((first, second) => second.Score.CompareTo(first.Score));

        return results;
    }

    static void WriteResults(
        List<(int Number, double Score)> results,
        List<string> titles,
        List<string> documents
    )
    {
        if (results.Count == 0)
        {
            Console.WriteLine("Документы не найдены.");
            return;
        }

        Console.WriteLine($"Найдено документов: {results.Count}");
        for (int i = 0; i < results.Count; i++)
        {
            int documentNumber = results[i].Number;

            Console.WriteLine();
            Console.WriteLine($"{i + 1}. {titles[documentNumber]}");
            Console.WriteLine($"Релевантность: {results[i].Score:F3}");
            Console.WriteLine($"{documents[documentNumber][..120] + "..."}");
        }
    }

    static List<string> GetWords(string text)
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
    
    static int CountSingleWords(List<string> documentWords, List<string> queryWords)
    {
        int count = 0;

        for (int i = 0; i < documentWords.Count; i++)
        {
            for (int j = 0; j < queryWords.Count; j++)
            {
                if (documentWords[i] == queryWords[j])
                {
                    count++;
                }
            }
        }

        return count;
    }

    static int CountPairs(List<string> documentWords, List<string> queryWords)
    {
        int count = 0;

        for (int i = 0; i < queryWords.Count - 1; i++)
        {
            List<string> pair = [queryWords[i], queryWords[i + 1]];
            count += CountPhrase(documentWords, pair);
        }

        return count;
    }

    static int CountPhrase(List<string> documentWords, List<string> queryWords)
    {
        int count = 0;

        for (int i = 0; i <= documentWords.Count - queryWords.Count; i++)
        {
            bool phraseFound = true;

            for (int j = 0; j < queryWords.Count; j++)
            {
                if (documentWords[i + j] != queryWords[j])
                {
                    phraseFound = false;
                    break;
                }
            }

            if (phraseFound)
            {
                count++;
            }
        }

        return count;
    }

}
