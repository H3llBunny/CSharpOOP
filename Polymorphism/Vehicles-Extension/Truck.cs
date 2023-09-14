using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Car
    {
        private const double acConsumption = 1.6;
        private const double tankLeakFuel = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumptionPerKm = fuelConsumption + acConsumption;
        }

        public override void Drive(double distance)
        {
            double requiredFuel = distance * this.FuelConsumptionPerKm;

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                Console.WriteLine("Truck travelled {0} km", distance);
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double fuel)
        {
            if(this.TankCapacity >= fuel + this.FuelQuantity)
            {
                base.Refuel(fuel * tankLeakFuel);
            }
            else
            {
                base.Refuel(fuel);
            }
        }

        public override string ToString()
        {
            return $"Truck: {Math.Round(this.FuelQuantity, 2, MidpointRounding.AwayFromZero):F2}";
        }
    }
}
