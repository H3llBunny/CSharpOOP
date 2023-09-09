using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizen : IBuyer
    {
        public Citizen()
        {
            this.Citizens = new List<Citizen>();
        }
        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }

        public List<Citizen> Citizens { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }
        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }

        public void Add(string name, int age, string id, string birthDate)
        {
            this.Citizens.Add(new Citizen(name, age, id, birthDate));
        }
    }
}
