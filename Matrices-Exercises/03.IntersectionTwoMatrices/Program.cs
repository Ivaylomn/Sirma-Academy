namespace _03.IntersectionTwoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] matrixOne = new char[rows, cols];
            char[,] matrixTwo = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrixOne[row, col] = input[col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrixTwo[row, col] = input[col];
                }
            }

            char[,] resultMatrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrixOne[row, col] == matrixTwo[row, col])
                    {
                        resultMatrix[row, col] = matrixOne[row, col];
                    }
                    else
                    {
                        resultMatrix[row, col] = '*';
                    }
                }
            }

            for (int row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < resultMatrix.GetLength(1); col++)
                {
                    Console.Write(resultMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
