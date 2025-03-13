class Program
{
    static void Main()
    {
        double[,] matrix = {
            { 2.19,  1.26,  -0.94 },
            { 0.93, -2.38,  4.02 },
            { 0.8,  -1.61, -3.76 },
        };
        double[] constants = [1.29, -2.5,  -1.75];
        double[] x = [0.0, 0.0, 0.0];

        double e = 0.001;
        int n = constants.Length;
        double[] newConstants = new double[n];
        int iteration = 0;

        while (true)
        {
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        sum += matrix[i, j] * x[j];
                    }
                }
                newConstants[i] = (constants[i] - sum) / matrix[i, i];
            }

            // Проверяем условие останова: максимальное изменение меньше tolerance
            double diff = 0;
            for (int i = 0; i < n; i++)
            {
                diff = Math.Max(diff, Math.Abs(newConstants[i] - x[i]));
                x[i] = newConstants[i];
            }

            iteration++;

            if (diff < e)
            {
                Console.WriteLine("Решение найдено за {0} итераций:", iteration);
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("x[{0}] = {1:F5}", i + 1, x[i]);
                }
                
                break;
            }
        }
    }
}
