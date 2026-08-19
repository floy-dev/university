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

        string[] data = File.ReadAllLines(pathname);
        List<List<string>> stemmedWords = [];

        foreach (string lines in data)
        {
            List<string> wordsInLine = [];

            var line = lines.ToLower();

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

            stemmedWords.Add(wordsInLine);
        }

        Console.WriteLine(
            string.Join(
                "\n",
                stemmedWords.Select(words => string.Join(" ", words))
            )
        );
    }
}