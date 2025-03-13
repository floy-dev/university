using System;

class Program
{
    static void Main()
    {
        double[,] matrix = {
            { 2, 5, -1 },
            { -1, -3, 0 },
            { 2, 3, -2 }
        };
        double[] v = { -1, -1, -1 };

        int n = v.Length;
        double[] vNext = new double[n];
        double lambda = 0;
        double lambdaPrev = 0;

        int iteration = 0;

        while (iteration < 100)
        {
            iteration++;

            for (int i = 0; i < n; i++)
            {
                vNext[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    vNext[i] += matrix[i, j] * v[j];
                }
            }

            double norm = 0;
            for (int i = 0; i < n; i++)
            {
                norm += vNext[i] * vNext[i];
            }
            norm = Math.Sqrt(norm);

            for (int i = 0; i < n; i++)
            {
                vNext[i] /= norm;
            }

            lambdaPrev = lambda;
            lambda = 0;
            for (int i = 0; i < n; i++)
            {
                lambda += vNext[i] * matrix[i, 0] * vNext[i];
            }

            if (Math.Abs(lambda - lambdaPrev) < 0.001)
            {
                break;
            }

            Array.Copy(vNext, v, n);
        }

        Console.WriteLine($"Максимальное собственное значение: {lambda}");
        Console.WriteLine("Соответствующий собственный вектор:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vNext[i]);
        }
    }
}
