using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryExample
{
    class ConcreteProductB : IProduct
    {
        public void DesplayInfo()
        {
            Console.WriteLine("This is ConcreteProductB.");
        }
    }
}
