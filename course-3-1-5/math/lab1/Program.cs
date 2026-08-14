class Gauss
{
    static void Main()
    {
        double[,] matrix =
        {
            { 0.8, -1.61, -3.76 },
            {2.19, 1.26, -0.94},
            {0.93, -2.38, 4.02}
        };
        double[] constants = [-1.75, 1.29, -2.5];
        int size = constants.Length;
        double[] solutions = new double[size];

        for (int col = 0; col < size; col++)
        {
            int maxRow = col;
            for (int row = col + 1; row < size; row++)
            {
                if (Math.Abs(matrix[row, col]) > Math.Abs(matrix[maxRow, col]))
                {
                    maxRow = row;
                }
            }
                
            for (int k = col; k < size; k++)
            {
                (matrix[maxRow, k], matrix[col, k]) = (matrix[col, k], matrix[maxRow, k]);
            }

            (constants[maxRow], constants[col]) = (constants[col], constants[maxRow]);

            for (int row = col + 1; row < size; row++)
            {
                double factor = matrix[row, col] / matrix[col, col];
                constants[row] -= factor * constants[col];
                for (int k = col; k < size; k++)
                {
                    matrix[row, k] -= factor * matrix[col, k];
                }
            }
        }

        for (int row = size - 1; row >= 0; row--)
        {
            solutions[row] = constants[row];
            for (int col = row + 1; col < size; col++)
            {
                solutions[row] -= matrix[row, col] * solutions[col];
            }
            solutions[row] /= matrix[row, row];
        }

        Console.WriteLine("Решение системы:");
        for (int i = 0; i < solutions.Length; i++)
        {
            Console.WriteLine($"x{i + 1} = {solutions[i]:F4}");
        }
    }
}