namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            int racksCount = 1;

            Stack<int> boxOfClothes = new Stack<int>(clothes);

            int currentCapacity = rackCapacity;
            while (boxOfClothes.Count > 0)
            {
                int currentPiece = boxOfClothes.Pop();
                if (currentPiece == currentCapacity && boxOfClothes.Count > 0)
                {
                    currentCapacity = rackCapacity;
                    racksCount++;
                }
                else if (currentPiece > currentCapacity)
                { 
                    racksCount++;
                    currentCapacity = rackCapacity - currentPiece;
                }
                else if (currentPiece < currentCapacity)
                {
                    currentCapacity -= currentPiece;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}