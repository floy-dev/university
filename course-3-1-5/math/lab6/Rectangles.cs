public class Rectangles
{
    static void Main()
    {
        double start = 1; 
        double end = 3; 
        int len = 100; 
        
        double h = (end - start) / len;
        double sum = 0;

        for (int i = 0; i < len; i++)
        {
            double x = start + i * h + h / 2;
            sum += 4 * x * Math.Sin(x);
        }

        double integral = h * sum;
        
        Console.WriteLine($"Значение интеграла (метод прямоугольников): {integral}");
    }
}