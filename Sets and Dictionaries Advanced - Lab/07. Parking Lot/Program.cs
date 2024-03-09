namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            HashSet<string> cars = new HashSet<string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string command = input.Split(", ")[0];
                string carNumber = input.Split(", ")[1];

                if (command == "IN")
                {
                    cars.Add(carNumber);
                }
                else if(command == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Count > 0)
            {
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}