using lab2;

Main();

return;

static void Main()
{
    // data.txt
    Console.WriteLine("Путь до исходного файла:");
    string? pathname = Console.ReadLine();
    if (string.IsNullOrEmpty(pathname))
    {
        Console.WriteLine("Файл не найден");
        
        return;
    }

    // бега
    Console.WriteLine("Слово для поиска:");
    string? searchWord = Console.ReadLine();
    if (string.IsNullOrEmpty(searchWord))
    {
        Console.WriteLine("Слово не задано");
        
        return;
    }

    string[] data = File.ReadAllLines(pathname);
    List<string> result = [];
    foreach (string word in data)
    {
        if (searchWord == Stemming.ProcessRawWord(word.ToLower()))
        {
            result.Add(word);
        }
    }

    File.WriteAllLines("result.txt", result);
}
