namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        int i = 19;
        int j = 9;
        
        var matrix = GetMatrix(i, j);
        
        PrintMatrix("Исходная матрица: ", matrix);
        
        SwapMaxAndMin(ref matrix);
        
        PrintMatrix("Обновленная матрица: ", matrix);
    }
    
    static List<List<double>> GetMatrix(int rows, int cols)
    {
        var matrix = new List<List<double>>();

        for (int i = 0; i <= rows; i++)
        {
            List<double> matrixRow = new List<double>(cols);
            
            for (int j = 0; j <= cols; j++)
            {
                double a = Math.Pow(i, 1.0 / 3.0) * Math.Sin(j);
                
                matrixRow.Add(a);        
            }
            
            matrix.Add(matrixRow);
        }
        
        return matrix;
    }

    static void SwapMaxAndMin(ref List<List<double>> matrix)
    {
        double min = Double.MaxValue;
        double max = Double.MinValue;
        
        int maxRowIndex = 0;
        int maxColIndex = 0;
        
        int minRowIndex = 0;
        int minColIndex = 0;

        for (int i = 0; i < matrix.Count; i++)
        {
            List<double> matrixRow = matrix[i];
            
            for (int j = 0; j < matrixRow.Count; j++)
            {
                double a = matrixRow[j];

                if (a < min)
                {
                    min = a;
                    minRowIndex = i;
                    minColIndex = j;
                }

                if (a > max)
                {
                    max = a;
                    maxRowIndex = i;
                    maxColIndex = j;
                }
            }
        }
        
        matrix[minRowIndex][minColIndex] = max;
        matrix[maxRowIndex][maxColIndex] = min;
    }

    static void PrintMatrix(string message, List<List<double>> matrix)
    {
        Console.Write(message + "\n");        

        for (int i = 0; i < matrix.Count; i++)
        {
            List<double> matrixRow = matrix[i];
            
            for (int j = 0; j < matrixRow.Count; j++)
            {
                double a = matrixRow[j];
                
                Console.Write(a + " ");        
            }
            Console.Write("\n");        
        }
    }
    
    static void Test()
    {
        Console.WriteLine("This program lists all the files in the directory:");

        DirectoryInfo dir = new DirectoryInfo("/home/floy");

        foreach (FileInfo file in dir.GetFiles("*.*"))
        {
            Console.WriteLine("{0}, {1}", file.Name, file.Length);
        }
        
        Console.ReadLine();
    }

}

// [
    // [1,2],
    // [1,2]
// ]