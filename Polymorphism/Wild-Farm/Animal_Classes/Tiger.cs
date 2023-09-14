using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Food_Classes;

namespace WildFarm
{
    public class Tiger : Feline
    {
        const double weightGain = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food.GetType().Name == "Meat")
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
            Console.WriteLine("ROAR!!!");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
