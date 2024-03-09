namespace _4._Matrix_Shuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (IsValid(command, matrix))
                {
                    matrix = SwapElements(command, matrix);

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }

                Console.WriteLine();
            }
        }

        static string[,] SwapElements(string command, string[,] matrix)
        {
            string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int firstCoordinate = int.Parse(commandParts[1]);
            int secondCoordinate = int.Parse(commandParts[2]);
            int thirdCoordinate = int.Parse(commandParts[3]);
            int fourthCoordinate = int.Parse(commandParts[4]);

            string firstElement = matrix[firstCoordinate, secondCoordinate];
            string secondElement = matrix[thirdCoordinate, fourthCoordinate];

            matrix[firstCoordinate, secondCoordinate] = secondElement;
            matrix[thirdCoordinate, fourthCoordinate] = firstElement;

            return matrix;
        }

        static bool IsValid(string command, string[,] matrix)
        {
            string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            bool isValidCommand = commandParts[0] == "swap";
            bool isValidLength = commandParts.Length == 5;
            bool validCoordinates = false;

            if (isValidCommand && isValidLength)
            {
                int firstCoordinate = int.Parse(commandParts[1]);
                int secondCoordinate = int.Parse(commandParts[2]);
                int thirdCoordinate = int.Parse(commandParts[3]);
                int fourthCoordinate = int.Parse(commandParts[4]);

                validCoordinates = firstCoordinate >= 0 && firstCoordinate < matrix.GetLength(0) &&
                    secondCoordinate >= 0 && secondCoordinate < matrix.GetLength(1) &&
                    thirdCoordinate >= 0 && thirdCoordinate < matrix.GetLength(0) &&
                    fourthCoordinate >= 0 && fourthCoordinate < matrix.GetLength(1);
            }

            return validCoordinates;
        }
    }
}