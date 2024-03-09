namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCommands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elementsToEnqueue = inputCommands[0];
            int elementsToDequeue = inputCommands[1];
            int elementToFind = inputCommands[2];

            int[]inputElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(inputElements.Take(elementsToEnqueue));

            while (queue.Count > 0 && elementsToDequeue > 0)
            {
                queue.Dequeue();
                elementsToDequeue--;
            }

            if (queue.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else if(queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}