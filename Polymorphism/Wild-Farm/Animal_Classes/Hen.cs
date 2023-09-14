using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Food_Classes;

namespace WildFarm.Animal_Classes
{
    public class Hen : Bird
    {
        const double weightGain = 0.35;

        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            this.Weight += food.Quantity * weightGain;
            this.FoodEaten += food.Quantity;
        }

        public override void Sound()
        {
            Console.WriteLine("Cluck");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
