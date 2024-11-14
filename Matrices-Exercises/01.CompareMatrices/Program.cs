namespace _01.CompareMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[,] matrixOne = new int[rows, cols];
            FillMatrix(matrixOne);
            
            int[] rowsAndColsForMatrixTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rowsForMatrixTwo = rowsAndColsForMatrixTwo[0];
            int colsForMatrixTwo = rowsAndColsForMatrixTwo[1];

            int[,] matrixTwo = new int[rowsForMatrixTwo, colsForMatrixTwo];
            FillMatrix(matrixTwo);

            bool isEqual = false;
            if (matrixOne.Length == matrixTwo.Length)
            {
                for (int i = 0; i < matrixOne.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOne.GetLength(1); j++)
                    {
                        if (matrixOne[i, j] == matrixTwo[i, j])
                        {
                            isEqual = true;
                        }else
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (!isEqual)
                    {
                        break;
                    }
                }
            }
            else
            {
                isEqual = false;
            }

            if (isEqual)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            //PrintMatrix(matrixOne);
            //PrintMatrix(matrixTwo);
        }

        public static void FillMatrix(int[,] matrix) 
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }

        //public static void PrintMatrix(int[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            Console.Write(matrix[row, col] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
