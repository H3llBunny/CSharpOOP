namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carDetails = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carDetails[1]);
            double carFuelConsumption = double.Parse(carDetails[2]);
            double carRankCapacity = double.Parse(carDetails[3]);
            Car car = new Car(carFuelQuantity, carFuelConsumption, carRankCapacity);

            var truckDetails = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckDetails[1]);
            double truckFuelConsumption = double.Parse(truckDetails[2]);
            double truckTankCapacity = double.Parse(truckDetails[3]);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            var busDetials = Console.ReadLine().Split();
            double buskFuelQuantity = double.Parse(busDetials[1]);
            double buskFuelConsumption = double.Parse(busDetials[2]);
            double busTankCapacity = double.Parse(busDetials[3]);
            Bus bus = new Bus(buskFuelQuantity, buskFuelConsumption, busTankCapacity);

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
                    else if (command[1] == "Bus")
                    {
                        bus.Drive(distance);
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
                    else if (command[1] == "Bus")
                    {
                        bus.Refuel(fuel);
                    }
                }
                else if (command[0] == "DriveEmpty")
                {
                    var distance = double.Parse(command[2]);
                    bus.DriveEmpty(distance);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}