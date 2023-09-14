using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Car
    {
        private const double withPassengersConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumptionPerKm = fuelConsumption;
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
        }

        public override void Drive(double distance)
        {
            var fuelRequired = distance * (this.FuelConsumptionPerKm + withPassengersConsumption);

            if (this.FuelQuantity >= fuelRequired)
            {
                this.FuelQuantity -= fuelRequired;
                Console.WriteLine("Bus travelled {0} km", distance);
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public void DriveEmpty(double distance)
        {
            var fuelRequired = distance * this.FuelConsumptionPerKm;

            if (this.FuelQuantity >= fuelRequired)
            {
                this.FuelQuantity -= fuelRequired;
                Console.WriteLine("Bus travelled {0} km", distance);
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override string ToString()
        {
            return $"Bus: {Math.Round(this.FuelQuantity, 2, MidpointRounding.AwayFromZero):F2}";
        }
    }
}
