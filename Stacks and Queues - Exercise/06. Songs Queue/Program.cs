namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ");
            Queue<string> songQueue = new Queue<string>(songs);

            while (songQueue.Count > 0)
            {
                string[] command = Console.ReadLine()
                    .Split();
                if (command[0] == "Play") 
                {
                    songQueue.Dequeue();
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songQueue));
                }
                else if (command[0] == "Add")
                {
                    string song = string.Join(" ", command.Skip(1));
                    if (songQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(song);
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}