namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumpsCount = int.Parse(Console.ReadLine());

            Queue<int[]> petrolQueue = new Queue<int[]>();

            for (int i = 0; i < petrolPumpsCount; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                petrolQueue.Enqueue(input);
            }

            int pumpIndex = 0;
            int currentPetrol = 0;

            while (true)
            {
                foreach (int[] station in petrolQueue)
                {
                    currentPetrol += station[0];
                    int distanceBetweenPumps = station[1];

                    if (currentPetrol < distanceBetweenPumps)
                    {
                        pumpIndex++;
                        currentPetrol = 0;
                        break;
                    }
                    else
                    {
                        currentPetrol -= distanceBetweenPumps;
                    }
                }

                if (currentPetrol > 0)
                {
                    break;
                }
                petrolQueue.Enqueue(petrolQueue.Dequeue());
            }

            Console.WriteLine(pumpIndex);
        }
    }
}