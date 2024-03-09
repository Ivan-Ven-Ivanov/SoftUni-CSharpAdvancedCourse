namespace _5._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string snake = Console.ReadLine();

            int charIndex = 0;

            char[,] stairs = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (charIndex > snake.Length - 1)
                    {
                        charIndex = 0;
                    }

                    if (row % 2 == 0)
                    {
                        stairs[row, col] = snake[charIndex];
                    }
                    else
                    {
                        stairs[row, cols - col - 1] = snake[charIndex];
                    }
                    charIndex++;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(stairs[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}