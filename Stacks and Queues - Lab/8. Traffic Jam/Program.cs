namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leavingCars = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string command;
            int passedCars = 0;
            while((command = Console.ReadLine())!= "end")
            {
                if (command != "green")
                {
                    queue.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < leavingCars; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passedCars++;
                    }
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}