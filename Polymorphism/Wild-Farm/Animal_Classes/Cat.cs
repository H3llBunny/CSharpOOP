using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Food_Classes;

namespace WildFarm
{
    public class Cat : Feline
    {
        const double weightGain = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Meat")
            {
                this.Weight += food.Quantity * weightGain;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
