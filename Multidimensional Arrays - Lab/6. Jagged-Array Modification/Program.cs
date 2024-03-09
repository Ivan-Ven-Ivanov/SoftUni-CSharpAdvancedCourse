namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();
                int givenRow = int.Parse(command[1]);
                int givenCol = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (givenRow < 0 || givenRow > jagged.Length -1|| givenCol < 0 
                    || givenCol > jagged[givenRow].Length -1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command[0] == "Add")
                {
                    jagged[givenRow][givenCol] += value;
                }
                else if (command[0] == "Subtract")
                {
                    jagged[givenRow][givenCol] -= value;
                }
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}