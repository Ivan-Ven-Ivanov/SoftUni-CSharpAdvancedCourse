namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chess = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string rowValues = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    chess[row, col] = rowValues[col];
                }
            }


        }
    }
}