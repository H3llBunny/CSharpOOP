using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class BasicCar : ICar
    {
        public string Assemble()
        {
            return "Basic Car";
        }
    }
}
