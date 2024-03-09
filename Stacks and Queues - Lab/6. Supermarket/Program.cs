namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Queue<string> queue = new Queue<string>();
            while ((command = Console.ReadLine()) != "End")
            {
                if (command != "Paid")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}