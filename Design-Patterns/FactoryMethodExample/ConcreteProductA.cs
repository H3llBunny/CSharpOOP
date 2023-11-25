using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodExample
{
    class ConcreteProductA : IProduct
    {
        public void DisplayInfo()
        {
            Console.WriteLine("This is ConcreteProductA.");
        }
    }
}
