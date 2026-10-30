using ESPkMeansLib;
using stemming;

namespace lab3;

class Program
{
    private static HashSet<string> stopWords =
    [
        "еще", "него", "сказать", "а", "ж", "нее", "со", "без", "же", "ней", "совсем", "более", "жизнь", "нельзя",
        "так", "больше", "за", "нет", "такой", "будет", "зачем", "ни", "там", "будто", "здесь", "нибудь", "тебя", "бы",
        "и", "никогда", "тем", "был", "из", "ним", "теперь", "была", "из-,за", "них", "то", "были", "или", "ничего",
        "тогда", "было", "им", "но", "того", "быть", "иногда", "ну", "тоже", "в", "их", "о", "только", "вам", "к", "об",
        "том", "вас", "кажется", "один", "тот", "вдруг", "как", "он", "три", "ведь", "какая", "она", "тут", "во",
        "какой", "они", "ты", "вот", "когда", "опять", "у", "впрочем", "конечно", "от", "уж", "все", "которого",
        "перед", "уже", "всегда", "которые", "по", "хорошо", "всего", "кто", "под", "хоть", "всех", "куда", "после",
        "чего", "всю", "ли", "потом", "человек", "вы", "лучше", "потому", "чем", "г", "между", "почти", "через", "где",
        "меня", "при", "что", "говорил", "мне", "про", "чтоб", "да", "много", "раз", "чтобы", "даже", "может", "разве",
        "чуть", "два", "можно", "с", "эти", "для", "мой", "сам", "этого", "до", "моя", "свое", "этой", "другой", "мы",
        "свою", "этом", "его", "на", "себе", "этот", "ее", "над", "себя", "эту", "ей",
        "надо", "сегодня", "я", "ему", "наконец", "сейчас", "если", "нас", "сказал", "есть", "не", "сказала"
    ];

    static void Main(string[] args)
    {
        // data.txt
        Console.WriteLine("Путь до исходного файла:");
        string? pathname = Console.ReadLine();
        if (string.IsNullOrEmpty(pathname))
        {
            Console.WriteLine("Файл не найден");
        
            return;
        }

        string[] documents = File.ReadAllLines(pathname);

        WriteDocuments(documents);
        Console.WriteLine();
        ClusterByKMeans(BuildFrequencyMatrix(SearchRepeatableWords(GetDocumentsWithStemmedWords(documents))));
    }

    static void WriteDocuments(string[] documents)
    {
        Console.WriteLine("Документы:");
        for (int i = 0; i < documents.Length; i++)
        {
            Console.WriteLine($"Документ {i + 1}: {documents[i]}");
        }
    }

    static void ClusterByKMeans(float[][] frequencyMatrix)
    {
        KMeans kMeans = new KMeans();

        var (clustering, centroids) = kMeans.Cluster(frequencyMatrix, 2);

        Console.WriteLine("Результат кластеризации:");
        for (int i = 0; i < clustering.Length; i++)
        {
            Console.WriteLine($"Документ {i + 1}: кластер {clustering[i] + 1}");
        }
    }

    static float[][] BuildFrequencyMatrix(List<List<string>> documentsStemmedWords)
    {
        List<string> vocabulary = [];

        foreach (List<string> documentStemmedWords in documentsStemmedWords)
        {
            foreach (string word in documentStemmedWords)
            {
                vocabulary.Add(word);
            }
        }

        vocabulary = vocabulary.Distinct().Order().ToList();

        Dictionary<string, int> wordIndexes = [];
        for (int i = 0; i < vocabulary.Count; i++)
        {
            wordIndexes[vocabulary[i]] = i;
        }

        float[][] matrix = new float[documentsStemmedWords.Count][];

        for (int i = 0; i < documentsStemmedWords.Count; i++)
        {
            List<string> documentStemmedWords = documentsStemmedWords[i];
            
            matrix[i] = new float[vocabulary.Count];
                
            foreach (string word in documentStemmedWords)
            {
                matrix[i][wordIndexes[word]]++;
            }
        }

        return matrix;
    }

    static List<List<string>> SearchRepeatableWords(List<List<string>> documentsWithStemmedWords)
    {
        Dictionary<string, int> wordsRepeat = [];
        foreach (List<string> stemmedWords in documentsWithStemmedWords)
        {
            foreach (string word in stemmedWords.ToList().Distinct())
            {
                if (wordsRepeat.ContainsKey(word))
                {
                    wordsRepeat[word]++;
                    continue;
                }
                
                wordsRepeat.Add(word, 1);
            }
        }
        
        foreach (List<string> stemmedWords in documentsWithStemmedWords)
        {
            foreach (string word in stemmedWords.ToList())
            {
                if (wordsRepeat.ContainsKey(word) && wordsRepeat[word] < 2)
                {
                    stemmedWords.Remove(word);
                }
            }
        }
        
        return documentsWithStemmedWords;
    }

    static List<List<string>> GetDocumentsWithStemmedWords(string[] documents)
    {
        List<List<string>> documentsWithStemmedWords = [];
        
        foreach (string document in documents)
        {
            List<string> wordsInLine = [];
            string line = document.ToLower();
            string[] words = line.Split(
                [' ', ',', '.', '!', '?', ':', ';', '"', '(', ')', '-', '—'],
                StringSplitOptions.RemoveEmptyEntries
            );

            foreach (string word in words)
            {
                string rawWord = word.Trim();

                if (stopWords.Contains(rawWord))
                {
                    continue;
                }

                rawWord = Stemming.ProcessRawWord(rawWord);

                wordsInLine.Add(rawWord);
            }

            documentsWithStemmedWords.Add(wordsInLine);
        }
        
        return documentsWithStemmedWords;
    }
}