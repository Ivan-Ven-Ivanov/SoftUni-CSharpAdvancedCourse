namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person() 
            {
                Name = "Ivan",
                Age = 28
            };

            Person person1 = new Person();
            person1.Name = "Maria";
            person1.Age = 25;
        }
    }
}