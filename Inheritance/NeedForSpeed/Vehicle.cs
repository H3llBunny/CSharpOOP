using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePowe = horsePower;
            this.Fuel = fuel;
        }

        private double fuelConsumption = DefaultFuelConsumption;
        public virtual double FuelConsuption
        {
            get
            {
                return fuelConsumption;
            }
            set
            {
                fuelConsumption = value;
            }
        }

        public double MyProperty { get; set; }
        public double Fuel { get; set; }
        public int HorsePowe { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsuption;
        }
    }
}
