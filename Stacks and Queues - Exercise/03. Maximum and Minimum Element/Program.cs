namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < commandsCount; i++)
            {
                int[] command = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (command[0] == 1)
                {
                    numbers.Push(command[1]);
                }
                else if (command[0] == 2 && numbers.Count > 0)
                {
                    numbers.Pop();
                }
                else if (command[0] == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (command[0] == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}