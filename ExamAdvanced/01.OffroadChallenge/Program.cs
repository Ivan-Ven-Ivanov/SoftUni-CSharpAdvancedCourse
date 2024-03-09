using System.Text;

namespace _01.OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <int> fuel = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> consumption = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> amountNeeded = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            List<string> altitudes = new List<string>();

            int reachedAltitudes = 0;

            for (int i = 1; i <= 4; i++)
            {
                int currentFuel = fuel.Pop();
                int currentConsumption = consumption.Dequeue();
                int currentAmountNeeded = amountNeeded.Dequeue();

                if (currentFuel - currentConsumption >= currentAmountNeeded)
                {
                    Console.WriteLine($"John has reached: Altitude {i}");
                    altitudes.Add($"Altitude {i}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {i}");
                    break;
                }
            }

            if (altitudes.Count == 0)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }
            else if(altitudes.Count < 4)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.Write($"Reached altitudes: {string.Join(", ", altitudes)}");
            }
            else if(altitudes.Count == 4)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}