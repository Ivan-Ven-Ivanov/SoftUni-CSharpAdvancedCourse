namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] arguments = command.Split();
                switch(arguments[0])
                {
                    case "add":
                        int firstNum = int.Parse(arguments[1]);
                        int secondNum = int.Parse(arguments[2]);
                        stack.Push(firstNum);
                        stack.Push(secondNum);
                        break;
                    case "remove":
                        int removeCount = int.Parse(arguments[1]);
                        if (stack.Count > removeCount)
                        {
                            for (int i = 0; i < removeCount; i++)
                            {
                                stack.Pop();
                            }
                        }

                        break;
                }
            }

            int sum = 0;
            foreach (int number in stack)
            {
                sum += number;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}