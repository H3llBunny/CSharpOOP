namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstCommand = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(firstCommand[1]);
            double carFuelConsumption = double.Parse(firstCommand[2]);
            Car car = new Car(carFuelQuantity, carFuelConsumption);

            var secondCommand = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(secondCommand[1]);
            double truckFuelConsumption = double.Parse(secondCommand[2]);
            Car truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "Drive") 
                {
                    var distance = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if (command[0] == "Refuel")
                {
                    var fuel = double.Parse(command[2]);

                    if (command[1] == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}