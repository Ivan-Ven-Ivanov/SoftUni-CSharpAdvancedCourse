namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());
            int sum = 0;
            int firstNumber = int.Parse(stack.Pop());
            sum += firstNumber;
            while (stack.Count > 0)
            {
                char operationChar = char.Parse(stack.Pop());
                int secondNumber = int.Parse(stack.Pop());
                switch (operationChar)
                {
                    case '+':
                        sum += secondNumber;
                        break;
                    case '-':
                        sum -= secondNumber;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}