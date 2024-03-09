using System.Data;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            string[] groupsOfBombs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[,] bombs = new int[groupsOfBombs.Length, 2];

            for (int row = 0; row < groupsOfBombs.Length; row++)
            {
                int[] bombValues = groupsOfBombs[row].Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < 2; col++)
                {
                    bombs[row, col] = bombValues[col];
                }
            }

            for (int i = 0; i < bombs.GetLength(0); i++)
            {
                int bomb = matrix[bombs[i, 0], bombs[i, 1]];

                if (bomb <= 0)
                {
                    continue;
                }

                matrix[bombs[i, 0], bombs[i, 1]] = 0;
                RemoveLeftUpperDiagonal(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveLeft(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveUpper(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveRightUpperDiagonal(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveRight(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveRightLowerDiagonal(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveLower(bombs[i, 0], bombs[i, 1], matrix, bomb);
                RemoveLeftLowerDiagonal(bombs[i, 0], bombs[i, 1], matrix, bomb);
            }

            int aliveCellsCount = 0;
            int sumOfAliveCells = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCellsCount++;
                        sumOfAliveCells += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        static void RemoveLeftLowerDiagonal(int row, int col, int[,] matrix, int value)
        {
            if (row + 1 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
            {
                matrix[row + 1, col - 1] -= value;
            }
        }

        static void RemoveLower(int row, int col, int[,] matrix, int value)
        {
            if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] > 0)
            {
                matrix[row + 1, col] -= value;
            }
        }

        static void RemoveRightLowerDiagonal(int row, int col, int[,] matrix, int value)
        {
            if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row + 1, col + 1] > 0)
            {
                matrix[row + 1, col + 1] -= value;
            }
        }

        static void RemoveRight(int row, int col, int[,] matrix, int value)
        {
            if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] > 0)
            {
                matrix[row, col + 1] -= value;
            }
        }

        static void RemoveRightUpperDiagonal(int row, int col, int[,] matrix, int value)
        {
            if (row - 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 1, col + 1] > 0)
            {
                matrix[row - 1, col + 1] -= value;
            }
        }

        static void RemoveUpper(int row, int col, int[,] matrix, int value)
        {
            if (row - 1 >= 0 && matrix[row - 1, col] > 0)
            {
                matrix[row - 1, col] -= value;
            }
        }

        static void RemoveLeft(int row, int col, int[,] matrix, int value)
        {
            if (col - 1 >= 0 && matrix[row, col - 1] > 0)
            {
                matrix[row, col - 1] -= value;
            }
        }

        static void RemoveLeftUpperDiagonal(int row, int col, int[,] matrix, int value)
        {
            if (row - 1 >= 0 && col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
            {
                matrix[row - 1, col - 1] -= value;
            }
        }
    }
}