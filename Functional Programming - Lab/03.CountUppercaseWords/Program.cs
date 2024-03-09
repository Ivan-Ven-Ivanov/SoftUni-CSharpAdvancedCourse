namespace _03.CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isWordUppercase = x => x[0] == x.ToUpper()[0];

            string [] wordsWithUppercase = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(isWordUppercase)
                .ToArray();

            foreach (string word in wordsWithUppercase)
            {
                Console.WriteLine(word);
            }
        }
    }
}