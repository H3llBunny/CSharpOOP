using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car
    {
        private const double acConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumption + acConsumption;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumptionPerKm { get; set; }

        public virtual void Drive(double distance)
        {
            double requiredFuel = distance * this.FuelConsumptionPerKm;

            if (requiredFuel <= this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                Console.WriteLine("Car travelled {0} km", distance);
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public virtual void Refuel(double fuel)
        {
            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:F2}";
        }
    }
}
