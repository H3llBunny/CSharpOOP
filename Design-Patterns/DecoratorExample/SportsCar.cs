using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car)
        {
        }

        public override string Assemble()
        {
            return base.Assemble() + ", Add Sports Features";
        }
    }
}
