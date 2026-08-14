using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символы (C, v, Q, w, e) для выполнения соответствующих действий. Для выхода нажмите ESC.");

        string folderPath = @"C:\Users\USer\Desktop\university\course-3-1\equipment\lab2\";
        string filePath = Path.Combine(folderPath, "test.txt");

        while (true)
        {
            var keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }

            char inputChar = keyInfo.KeyChar;
            string bit8Value = Convert.ToString(inputChar, 8);
            
            Console.WriteLine($"Символ: {inputChar}, восьмеричное значение: {bit8Value}");

            switch (inputChar)
            {
                case 'C':
                    Process.Start("explorer.exe");
                    
                    break;
                case 'v':
                    Console.WriteLine("Введите новый путь для создания файла");
                    
                    var value = Console.ReadLine() ?? folderPath;
                    folderPath = value;
                    filePath = Path.Combine(folderPath, "test.txt");

                    Console.WriteLine("Новый путь записан");

                    break;
                case 'Q':
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    File.Create(filePath).Close();
                    
                    Console.WriteLine($"Текстовый файл создан по пути {filePath}.");
                    
                    break;
                case 'w':
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        Console.WriteLine("Текстовый файл удален.");
                    }
                    else
                    {
                        Console.WriteLine("Файл не найден.");
                    }
                    
                    break;
                case 'e':
                    Process.Start("taskkill", "/IM explorer.exe");
                    
                    break;
                default:
                    Console.WriteLine("Неверный символ. Пожалуйста, используйте C, v, Q, w, e.");
                    
                    break;
            }
        }
    }
}
