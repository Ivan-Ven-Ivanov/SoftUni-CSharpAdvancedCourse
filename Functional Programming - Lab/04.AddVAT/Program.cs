namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(d => d * 1.2)
                .ToArray();

            foreach (double price in prices)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}