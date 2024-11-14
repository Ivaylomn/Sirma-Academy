namespace _08.FillTheMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pattern = Console.ReadLine().Split();
            int matrixSize = int.Parse(pattern[0]);
            char aOrB = char.Parse(pattern[1]);

            int[,] matrix = new int[matrixSize, matrixSize];

            if (aOrB == 'A')
            {
                int initialValue = 1;
                for (int row = 0; row < matrixSize; row++)
                {
                    int currentValue = initialValue;
                    for (int col = 0; col < matrixSize; col++)
                    {
                        matrix[row, col] = currentValue;
                        currentValue += matrixSize;
                    }
                    initialValue++;
                }
            }
            else
            {
                int number = 1;

                for (int col = 0; col < matrixSize; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < matrixSize; row++)
                        {
                            matrix[row, col] = number++;
                        }
                    }
                    else
                    {
                        for (int row = matrixSize - 1; row >= 0; row--)
                        {
                            matrix[row, col] = number++;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
