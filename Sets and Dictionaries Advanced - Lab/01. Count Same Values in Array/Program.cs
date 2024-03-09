namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> countOfEveryValue = new Dictionary<double, int>();

            foreach (double value in values)
            {
                if (!countOfEveryValue.ContainsKey(value))
                {
                    countOfEveryValue.Add(value, 1);
                }
                else
                {
                    countOfEveryValue[value]++;
                }
            }

            foreach (KeyValuePair<double, int> kvp in countOfEveryValue)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}