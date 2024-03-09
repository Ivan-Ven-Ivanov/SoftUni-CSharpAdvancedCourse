namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            int[,] squareMatrix = new int[3, 3];

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                        squareMatrix = new int[3, 3]{
                            { matrix[row, col], matrix[row, col + 1], matrix[row, col + 2]},
                            { matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2]},
                            { matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]}
                        };
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    Console.Write(squareMatrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}