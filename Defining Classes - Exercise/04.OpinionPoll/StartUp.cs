namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);  
                peopleList.Add(person);
            }

            List<Person> olderThanThirty = peopleList.Where(p => p.Age > 30).OrderBy(k => k.Name).ToList();
            foreach (Person person in olderThanThirty)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}