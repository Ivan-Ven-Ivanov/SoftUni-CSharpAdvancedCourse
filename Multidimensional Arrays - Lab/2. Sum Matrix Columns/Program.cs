﻿namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = rowValues[col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int colSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    colSum += matrix[row,col];
                }

                Console.WriteLine(colSum);
            }
        }
    }
}