using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public Rebel()
        {
            this.Rebels = new List<Rebel>();
        }
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public List<Rebel> Rebels { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }

        public void Add(string name, int age, string group)
        {
            this.Rebels.Add(new Rebel(name, age, group));
        }
    }
}
