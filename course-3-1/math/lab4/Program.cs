class Program
{
    static void Main()
    {
        double[] x = { 1.6, 2.0, 2.4, 2.8};
        double[] xFunction = { 1.4359, 1.3645, 2.5063, 2.9112};

        double function01 = (xFunction[1] - xFunction[0]) / (x[1] - x[0]);
        double function12 = (xFunction[2] - xFunction[1]) / (x[2] - x[1]);

        double function012 = (function12 - function01) / (x[2] - x[0]);

        double a1 = (x[0] + x[1]) / 2;
        double a2 = (x[1] + x[2]) / 2;
        double a3 = (x[2] + x[3]) / 2;

        double[] aList = { a1, a2, a3 };

        foreach (var a in aList)
        {
            double result = xFunction[0] + (a - x[0]) * function01 + (a - x[0]) * (a - x[1]) * function012;
            
            Console.WriteLine($"Интерполированное значение в точке a = {a}: {result}");
        }
    }
}