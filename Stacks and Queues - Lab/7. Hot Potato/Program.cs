namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split());
            int givenTosses = int.Parse(Console.ReadLine());
            int tossesCount = 0;
            while (queue.Count > 1)
            {
                tossesCount++;
                string childWithPotato = queue.Dequeue();
                if (tossesCount < givenTosses)
                {
                    queue.Enqueue(childWithPotato);
                }
                else
                {
                    Console.WriteLine($"Removed {childWithPotato}");
                    tossesCount = 0;
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}