namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            string command;

            Queue<string> carsQueue = new Queue<string>();

            int passedCars = 0;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command != "green")
                {
                    carsQueue.Enqueue(command);
                }
                else
                {
                    int secondsLeft = greenLightSeconds + freeWindowSeconds;

                    while (carsQueue.Count > 0)
                    {
                        string currentCar = carsQueue.Dequeue();

                        if (currentCar.Length <= secondsLeft)
                        {
                            secondsLeft -= currentCar.Length;
                            passedCars++;
                            if (secondsLeft <= freeWindowSeconds)
                            {
                                break;
                            }

                            continue;
                        }
                        else
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[secondsLeft]}.");
                            Environment.Exit(1);
                        }
                    }
                }
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}