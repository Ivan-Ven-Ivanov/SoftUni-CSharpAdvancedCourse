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
            int elementsToPush = inputCommands[0];
            int elementsToPop = inputCommands[1];
            int elementToFind = inputCommands[2];

            int[]inputElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(inputElements.Take(elementsToPush));

            while (stack.Count > 0 && elementsToPop > 0)
            {
                stack.Pop();
                elementsToPop--;
            }

            if (stack.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}