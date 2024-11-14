namespace _02.MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColsForMyMatrices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowsAndColsForMyMatrices[0];
            int cols = rowsAndColsForMyMatrices[1];

            int[,] matrixOne = new int[rows, cols];
            for (int row = 0; row < matrixOne.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrixOne.GetLength(1); col++)
                {
                    matrixOne[row, col] = input[col];
                }
            }

            int[,] matrixTwo = new int[rows, cols];
            for (int row = 0; row < matrixTwo.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrixTwo.GetLength(1); col++)
                {
                    matrixTwo[row, col] = input[col];
                }
            }

            int[,] resultMatrix = new int[rows, cols];
            for (int row = 0; row < matrixOne.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.GetLength(1); col++)
                {
                    resultMatrix[row, col] = matrixOne[row, col] + matrixTwo[row, col];
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
