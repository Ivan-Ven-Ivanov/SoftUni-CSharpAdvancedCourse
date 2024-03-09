namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionForKilometer = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionForKilometer);
                cars.Add(model, car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carToDrive = splittedCommand[1];
                int distanceToDrive = int.Parse(splittedCommand[2]);
                Car.Drive(carToDrive, distanceToDrive, cars);

                command = Console.ReadLine();
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}