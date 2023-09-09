using ExplicitInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }

        public string Name { get; private set; }
        public string Country { get; private set; }

        public void GetName()
        {
            Console.WriteLine(this.Name);
        }

        void IResident.GetName()
        {
            Console.WriteLine($"Mr/Ms/Mrs {this.Name}");
        }
    }
}
