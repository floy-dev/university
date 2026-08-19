Main();

return;

static void Main()
{
    // data.txt
    string? pathname = Console.ReadLine();
    if (string.IsNullOrEmpty(pathname))
    {
        Console.WriteLine("Файл не найден");
        
        return;
    }

    string[] data = File.ReadAllLines(pathname);
    
    string mainText = data[0];
    string searchText = data[1];

    Console.WriteLine("Прямой поиск:");
    Console.WriteLine(DirectSearch(mainText, searchText) ? "Содержит": "Не содержит");
    
    int[] prefix = MakePrefix(searchText); 
    Console.WriteLine("Кнута, Морриса и Пратта поиск:");
    Console.WriteLine(KMPSearch(mainText, searchText, prefix) ? "Содержит": "Не содержит");
    
    Console.WriteLine("Бойера и Мура поиск:");
    Console.WriteLine(BoyerMooreSearch(mainText, searchText) ? "Содержит": "Не содержит");
}

static int[] MakePrefix(string searchText)
{
    int[] prefixArray = new int[searchText.Length];
    
    for (int i = 1; i < searchText.Length; i++)
    {
        string concatText = searchText.Substring(0, i + 1);

        for (int j = concatText.Length - 1; j > 0; j--)
        {
            string prefix = concatText.Substring(0, j); 
            string suffix = concatText.Substring(concatText.Length - j, j);
            
            if (prefix == suffix)
            {
                prefixArray[i] = j;
                break;
            }
        }
    }
    
    return prefixArray;
}

static bool DirectSearch(string mainText, string searchText)
{
    for (int i = 0; i < mainText.Length; i++)
    {
        for (int j = 0; j < searchText.Length; j++)
        {
            if (searchText[j] != mainText[i + j])
            {
                break;
            }
            
            if (j == searchText.Length - 1)
            {
                return true;
            }
        }
    }
    
    return false;
}

static bool KMPSearch(string mainText, string searchText, int[] prefixArray)
{
    for (int i = 0; i < mainText.Length; i++)
    {
        for (int j = 0; j < searchText.Length; j++)
        {
            if (searchText[j] != mainText[i + j])
            {
                if (j > 0 && prefixArray[j - 1] > 0)
                {
                    i += prefixArray[j - 1] - 1;
                }
                
                break;
            }

            if (j == searchText.Length - 1)
            {
                return true;
            }
        }
    }
    
    return false;
}

static bool BoyerMooreSearch(string mainText, string searchText)
{
    Dictionary<char, int> lastPositionDictionary = CalculateSymbolLastPosition(searchText);

    int i = searchText.Length - 1;
    while (i < mainText.Length)
    {
        int j = searchText.Length - 1;
        int textPosition = i;

        while (j >= 0 && mainText[textPosition] == searchText[j])
        {
            textPosition--;
            j--;
        }
        if (j < 0)
        {
            return true;
        }

        char badChar = mainText[textPosition];
        int skipCount = searchText.Length;
        if (lastPositionDictionary[badChar] >= 0)
        {
            skipCount = Math.Max(1, j - lastPositionDictionary[badChar]);
        }

        i += skipCount;
    }

    return false;
}


static Dictionary<char, int> CalculateSymbolLastPosition(string searchText)
{
    Dictionary<char, int> table = [];

    for (int i = 0; i < searchText.Length; i++)
    {
        table[searchText[i]] = i;
    }

    return table;
}