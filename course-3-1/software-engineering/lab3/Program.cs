namespace lab2;

class Program
{
    static void Main()
    {
        Time time1 = new Time(14, 30, 45);
        Time time2 = new Time(12, 40);
        Time time3 = new Time(17);

        Console.WriteLine("Исходное время:");
        Console.WriteLine("Время 1: " + time1);
        Console.WriteLine("Время 2: " + time2);
        Console.WriteLine("Время 3: " + time3);
        
        var diff = Time.DifferenceInSeconds(time1, time2);
        Console.WriteLine($"Разница между {time1} и {time2}: {diff} секунд");
        
        Time timeAdded = time1 + 500;
        Console.WriteLine($"{time1} + 500 секунд");
        timeAdded.Display();
        
        Time timeSubtracted = time2 - 1000;
        Console.WriteLine($"{time2} - 1000 секунд");
        timeSubtracted.Display();
        
        Console.WriteLine($"{time1} в секундах: {time1.ToSeconds()}");
        Console.WriteLine($"{time1} в минутах: {time1.ToMinutes():F2}");
        
        Console.WriteLine($"{time1} > {time2} {time1 > time2}");
        Console.WriteLine($"{time3} < {time1} {time3 < time1}");
    }
}