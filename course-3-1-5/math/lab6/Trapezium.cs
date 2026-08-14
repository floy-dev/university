class Trapezium
{
    static void Main()
    {
        double start = 0; 
        double end = 3; 
        int len = 100; 
        
        double h = (end - start) / len;
        double sum = 0.5 * (Math.Pow(4, start) + 1 + Math.Pow(4, end) + 1); 

        for (int i = 1; i < len; i++)
        {
            double x = start + i * h;
            sum += Math.Pow(4, x) + 1;
        }

        double integral = h * sum;
        
        Console.WriteLine($"Значение интеграла (метод трапеций): {integral}");
    }
}