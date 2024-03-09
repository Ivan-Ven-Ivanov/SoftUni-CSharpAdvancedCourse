namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            int diagonalSum = 0;

            for (int i = 0; i < matrixSize; i++)
            {
                diagonalSum += matrix[i,i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}