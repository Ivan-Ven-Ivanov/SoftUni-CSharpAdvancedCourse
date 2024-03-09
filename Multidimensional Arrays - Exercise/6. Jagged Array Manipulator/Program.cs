namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;
                    }

                    for (int j = 0; j < jagged[i + 1].Length; j++)
                    {
                        jagged[i + 1][j] /= 2;
                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int givenRow = int.Parse(splittedCommand[1]);
                int givenCol = int.Parse(splittedCommand[2]);
                int givenValue = int.Parse(splittedCommand[3]);

                if (splittedCommand[0] == "Add")
                {
                    if (AreCoordinatesValid(givenRow, givenCol, jagged))
                    {
                        jagged[givenRow][givenCol] += givenValue;
                    }
                }
                else if(splittedCommand[0] == "Subtract")
                {
                    if (AreCoordinatesValid(givenRow, givenCol, jagged))
                    {
                        jagged[givenRow][givenCol] -= givenValue;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                Console.WriteLine(string.Join(" ", jagged[row]));
            }
        }

        static bool AreCoordinatesValid(int givenRow, int givenCol, int[][] jagged)
        {
            if (givenRow < 0 || givenRow >= jagged.Length || givenCol < 0 || givenCol >= jagged[givenRow].Length)
            {
                return false;
            }

            return true;
        }
    }
}