namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parenthesesInput = Console.ReadLine();
            Stack<char> openingBrackets = new Stack<char>();

            foreach (char character in parenthesesInput)
            {
                if (character == '(' || character == '[' || character == '{')
                {
                    openingBrackets.Push(character);
                    continue;
                }

                if (openingBrackets.Count == 0)
                {
                    openingBrackets.Push(character);
                    break;
                }

                if (character == ')' && openingBrackets.Peek() == '(')
                {
                    openingBrackets.Pop();
                }
                else if (character == ']' && openingBrackets.Peek() == '[')
                {
                    openingBrackets.Pop();
                }
                else if (character == '}' && openingBrackets.Peek() == '{')
                {
                    openingBrackets.Pop();
                }
            }

            if (openingBrackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}