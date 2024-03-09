namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                string rowValues = Console.ReadLine();
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            char symbolToFind = char.Parse(Console.ReadLine());
            bool foundSymbol = false;

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == symbolToFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        foundSymbol = true;
                        break;
                    }
                }

                if (foundSymbol)
                {
                    break;
                }
            }

            if (!foundSymbol)
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
        }
    }
}