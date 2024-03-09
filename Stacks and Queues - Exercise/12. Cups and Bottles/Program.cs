namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupCapacity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] filledBottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> bottles = new Stack<int>(filledBottles);
            Queue<int> cups = new Queue<int>(cupCapacity);

            int wastedWater = 0;

            while (bottles.Count > 0 && cups.Count > 0)
            {
                int currentCup = cups.Peek();

                while (currentCup > 0)
                {
                    int currentBottle = bottles.Pop();
                    if (currentBottle > currentCup)
                    {
                        wastedWater += currentBottle - currentCup;
                    }

                    currentCup -= currentBottle;

                    if (currentCup <= 0)
                    {
                        cups.Dequeue();
                        break;
                    }
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}