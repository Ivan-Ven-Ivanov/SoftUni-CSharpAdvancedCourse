namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> evenQueue = new Queue<int>();
            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                   evenQueue.Enqueue(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", evenQueue));
        }
    }
}