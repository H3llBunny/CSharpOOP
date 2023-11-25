using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    class ConcreteProductB : IProduct
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is ConcreteProductB.");
        }
    }
}
