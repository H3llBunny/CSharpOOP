using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Food_Classes;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        const double weightGain = 0.10;

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Vegetable" || food.GetType().Name == "Fruit")
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
            Console.WriteLine("Squeak");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
