namespace _09.RowSumAndColumnSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColsOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = rowsAndColsOfMatrix[0];
            int cols = rowsAndColsOfMatrix[1];

            int[,] matrix = new int[rows, cols];
            List<int> rowsSum = new List<int>();
            int rowSum = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                    rowSum += input[col];
                }
                rowsSum.Add(rowSum);
                rowSum = 0;
            }

            List<int> colsSum = new List<int>();
            int colSum = 0;
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    colSum += matrix[row, col];
                }
                colsSum.Add(colSum);
                colSum = 0;
            }

            Console.Write("Row Sums: ");
            Console.WriteLine(string.Join(", ", rowsSum));

            Console.Write("Column Sums: ");
            Console.WriteLine(string.Join(", ", colsSum));
        }
    }
}
