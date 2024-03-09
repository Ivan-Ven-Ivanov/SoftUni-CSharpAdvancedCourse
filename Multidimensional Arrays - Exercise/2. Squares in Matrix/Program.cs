using System.Drawing;

namespace _2._Squares_in_Matrix
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

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int squaresCount = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currentChar = matrix[row, col];

                    bool sameAsRight = currentChar == matrix[row, col + 1];
                    bool sameAsBelow = currentChar == matrix[row + 1, col];
                    bool sameAsDiagonal = currentChar == matrix[row + 1, col + 1];

                    if (sameAsRight && sameAsBelow && sameAsDiagonal)
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }
    }
}