namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[size][];

            pascalTriangle[0] = new long[1] { 1 };

            for (int row = 1; row < size; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    if (col == 0)
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col];
                        continue;
                    }

                    if (col == pascalTriangle[row].Length - 1)
                    {
                        pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1];
                        continue;
                    }

                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] +
                        pascalTriangle[row - 1][col];
                }
            }

            foreach (long[] row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}