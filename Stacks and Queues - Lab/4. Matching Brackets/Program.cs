namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                }
                if (expression[i] == ')')
                {
                    int bracketIndex = stack.Pop();
                    Console.WriteLine(expression.Substring(bracketIndex, i - bracketIndex + 1)); 
                }
            }
        }
    }
}