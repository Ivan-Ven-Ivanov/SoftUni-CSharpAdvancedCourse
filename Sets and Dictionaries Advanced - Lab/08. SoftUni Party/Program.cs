namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string command;
            while ((command = Console.ReadLine()) != "PARTY")
            {
                guests.Add(command);
            }

            while ((command = Console.ReadLine()) != "END")
            {
                guests.Remove(command);
            }

            Console.WriteLine(guests.Count);

            foreach (string guest in guests.OrderByDescending(g => char.IsDigit(g[0])))
            {
                Console.WriteLine(guest);
            }
        }
    }
}