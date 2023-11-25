using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceExample
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car SetMake(string make)
        {
            Make = make;
            return this;
        }

        public Car SetModel(string model)
        {
            Model = model;
            return this;
        }

        public Car SetYear(int year)
        {
            Year = year;
            return this;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Year} {Make} {Model}");
        }
    }
}
