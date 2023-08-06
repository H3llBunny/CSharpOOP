using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private double calories;
        private string pizzaName;

        public Pizza(string pizzaName, Dough dough)
        {
            this.PizzaName = pizzaName;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }

        public Dough Dough { get; private set; }
        private  List<Topping> Toppings { get; set; }

        public string PizzaName
        {
            get => this.pizzaName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) && value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.pizzaName = value;
            }
        }

        public double Calories()
        {
            this.calories += (2  * this.Dough.Grams) * this.Dough.doughModifierGrams * this.Dough.bakingModifierGrams;

            foreach (var topping in this.Toppings)
            {
                this.calories += (2 * topping.Grams) * topping.toppingGrams;
            }

            return this.calories;
        }

        public void AddTopping(Topping topping)
        {
            if(this.Toppings.Count + 1 <= 10)
            {
                this.Toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }
    }
}
