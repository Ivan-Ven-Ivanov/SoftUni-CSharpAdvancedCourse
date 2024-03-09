namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            char[,] fishingArea = new char[dimensions, dimensions];

            int fishCaught = 0;
            int shipRow = 0;
            int shipCol = 0;
            int startRow = 0;
            int endRow = 0;

            for (int row = 0; row < dimensions; row++)
            {
                string rowValues = Console.ReadLine();

                for (int col = 0; col < dimensions; col++)
                {
                    fishingArea[row, col] = rowValues[col];

                    if (fishingArea[row, col] == 'S')
                    {
                        shipRow = row;
                        shipCol = col;
                        startRow = row;
                        endRow = col;
                    }
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == "left")
                {
                    shipCol--;
                    if (shipCol < 0)
                    {
                        shipCol = dimensions - 1;
                    }
                }
                if (command == "right")
                {
                    shipCol++;
                    if (shipCol >= dimensions)
                    {
                        shipCol = 0;
                    }
                }
                if (command == "up")
                {
                    shipRow--;
                    if (shipRow < 0)
                    {
                        shipRow = dimensions - 1;
                    }
                }
                if (command == "down")
                {
                    shipRow++;
                    if (shipRow >= dimensions)
                    {
                        shipRow = 0;
                    }
                }

                if (char.IsDigit(fishingArea[shipRow, shipCol]))
                {
                    int fish = int.Parse(fishingArea[shipRow, shipCol].ToString());
                    fishCaught += fish;
                    fishingArea[shipRow, shipCol] = '-';
                }
                else if (fishingArea[shipRow, shipCol] == 'W')
                {
                    break;
                }
            }

            if (fishingArea[shipRow, shipCol] == 'W')
            {
                Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{shipRow},{shipCol}]");
            }
            else
            {
                if (fishCaught >= 20)
                {
                    Console.WriteLine("Success! You managed to reach the quota!");
                }
                else
                {
                    Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - fishCaught} tons of fish more.");
                }

                if (fishCaught > 0)
                {
                    Console.WriteLine($"Amount of fish caught: {fishCaught} tons.");
                }

                fishingArea[startRow, endRow] = '-';
                fishingArea[shipRow, shipCol] = 'S';

                for (int row = 0; row < dimensions; row++)
                {
                    for (int col = 0; col < dimensions; col++)
                    {
                        Console.Write(fishingArea[row, col]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}