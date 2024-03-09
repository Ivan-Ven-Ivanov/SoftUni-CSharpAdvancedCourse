namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();
            List<Car> cars = new List<Car>();

            string command = Console.ReadLine();
            while (command != "No more tires")
            {
                Tire[] tireGroup = new Tire[4];
                double[] tireSpecs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                int counter = 0;

                for (int i = 0; i < tireSpecs.Length; i += 2)
                {
                    tireGroup[counter++] = new Tire((int)tireSpecs[i], tireSpecs[i + 1]);
                }

                tiresList.Add(tireGroup);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "Engines done")
            {
                double[] engineSpecs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                Engine engine = new Engine((int)engineSpecs[0], engineSpecs[1]);
                engineList.Add(engine);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "Show special")
            {
                string[] carSpecs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carSpecs[0];
                string model = carSpecs[1];
                int year = int.Parse(carSpecs[2]);
                double fuelQuantity = double.Parse(carSpecs[3]);
                double fuelConsumption = double.Parse(carSpecs[4]);
                int engineIndex = int.Parse(carSpecs[5]);
                int tiresIndex = int.Parse(carSpecs[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tiresList[tiresIndex]);
                cars.Add(car);

                command = Console.ReadLine();
            }

            List<Car> specialCars = cars.Where(c => c.Year >= 2017)
                .Where(c => c.Engine.HorsePower > 330)
                .Where(c => c.Tires[0].Pressure + c.Tires[1].Pressure + c.Tires[2].Pressure + c.Tires[3].Pressure >= 9 &&
                c.Tires[0].Pressure + c.Tires[1].Pressure + c.Tires[2].Pressure + c.Tires[3].Pressure <= 10).ToList();

            foreach (Car specialCar in specialCars)
            {
                specialCar.Drive(20);
            }

            foreach (Car specialCar in specialCars)
            {
                Console.WriteLine(specialCar.WhoAmI());
            }
        }
    }
}