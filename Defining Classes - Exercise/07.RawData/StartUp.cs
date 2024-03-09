namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new(carInput[0], int.Parse(carInput[1]), int.Parse(carInput[2]), int.Parse(carInput[3]), carInput[4],
                    double.Parse(carInput[5]), int.Parse(carInput[6]), double.Parse(carInput[7]), int.Parse(carInput[8]),
                    double.Parse(carInput[9]), int.Parse(carInput[10]), double.Parse(carInput[11]), int.Parse(carInput[12]));

                cars.Add(car);
            }

            string command = Console.ReadLine();
            string[] sortedCars;

            if (command == "fragile")
            {
                sortedCars = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1))
                    .Select(c => c.Model).ToArray(); 
            }
            else
            {
                sortedCars = cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                    .Select(c => c.Model).ToArray();
            }

            Console.WriteLine(string.Join(Environment.NewLine, sortedCars));
        }
    }
}