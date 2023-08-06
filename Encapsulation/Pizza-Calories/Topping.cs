using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;
        private string toppingType;
        private double grams;
        internal double toppingGrams;

        public Topping(string toppingType, double grams)
        {
            this.ToppingType = toppingType;

            switch (toppingType.ToLower())
            {
                case "meat":
                    this.toppingGrams = Meat;
                    break;

                case "veggies":
                    this.toppingGrams = Veggies;
                    break;

                case "cheese":
                    this.toppingGrams = Cheese;
                    break;

                case "sauce":
                    this.toppingGrams = Sauce;
                    break;
            }

            this.Grams = grams;
        }

        public string ToppingType
        {
            get => this.toppingType;
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double Grams
        {
            get => this.grams;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }
                this.grams = value;
            }
        }
    }
}
