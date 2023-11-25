using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryExample
{
    class SimpleFactory
    {
        public IProduct CreateProduct(string productType)
        {
            switch (productType)
            {
                case "A":
                    return new ConcreteProductA();
                case "B":
                    return new ConcreteProductB();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
