using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Person> People;

        public Person()
        {
            this.People = new List<Person>();
        }

        public Person(string name, double money, List<string> shoppingBag)
        {
            this.Name = name;
            this.Money = money;
            this.ShoppingBag = shoppingBag;
        }

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public double Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        private List<string> ShoppingBag { get; set; }

        public void Add(Person person)
        {
            this.People.Add(person);
        }

        public void TryPurchaseProduct(string personName, Product product)
        {
            foreach (var person in People)
            {
                if (person.Name == personName)
                {
                    if (person.Money >= product.Cost)
                    {
                        person.Money -= product.Cost;
                        person.ShoppingBag.Add(product.Name);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                        break;
                    }
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var person in this.People)
            {
                if (person.ShoppingBag.Count > 0)
                {
                    sb.AppendLine($"{person.Name} - {string.Join(", ", person.ShoppingBag)}");
                }
                else
                {
                    sb.AppendLine($"{person.Name} - Nothing bought");
                }
            }

            return sb.ToString();
        }
    }
}
