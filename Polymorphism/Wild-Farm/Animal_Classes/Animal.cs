using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Animal_Classes;
using WildFarm.Food_Classes;

namespace WildFarm
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public virtual int FoodEaten { get; set; }

        public abstract void Eat(IFood food);

        public abstract void Sound();
    }
}
